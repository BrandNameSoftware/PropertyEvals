using Newtonsoft.Json;
using PropertyEval.DTOs;
using System;
using System.Collections;
using System.IO;
using PropertyEval.Helpers;
using System.Web;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

namespace PropertyEval.PropertyCalls.WebserviceCalls
{
    public class PropertyWSCalls
    {
        private WebserviceConfig wsConfig;
        public PropertyWSCalls()
        {
            String configPath = HttpContext.Current.Server.MapPath("~") + "config.json";
            using (StreamReader r = new StreamReader(configPath))
            {
                string json = r.ReadToEnd();
                wsConfig = JsonConvert.DeserializeObject<WebserviceConfig>(json);
            }
        }

        //gets the list of initial properties to evaluate. Getting just a list of addresses
        public List<String> GetListOfProperties()
        {
            String propertiesJSON = WebserviceHelper.CallWS(wsConfig.ImportIOEndpoint, "");
            ImportIOPropertyInfo iioPropertyInfo = JsonConvert.DeserializeObject<ImportIOPropertyInfo>(propertiesJSON);

            List<String> addresses = new List<String>();

            if (iioPropertyInfo.pageData.statusCode == 200 && iioPropertyInfo.extractorData.data.Length > 0)
            {
                foreach (ImportIOPropertyInfo.Group group in iioPropertyInfo.extractorData.data[0].group)
                {
                    addresses.Add(group.Address[0].text);
                }
            }

            return addresses;
        }

        public List<ZillowPropertySearchDTO.searchresults> GetZillowPropertyBasicInfo(List<String> streetAddresses)
        {
            List<ZillowPropertySearchDTO.searchresults> zillowProperties = new List<ZillowPropertySearchDTO.searchresults>();

            foreach (String streetAddress in streetAddresses)
            {
                String urlParms = CreateURLParmsFromStreetAddress(streetAddress);
                String propertiesDetailXML = WebserviceHelper.CallWS(wsConfig.ZillowSearchByStreetEndpoint, urlParms);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ZillowPropertySearchDTO.searchresults));
                ZillowPropertySearchDTO.searchresults zillowProperty = null;
                using (var reader = new StringReader(propertiesDetailXML))
                {
                    XmlReader xmlReader = XmlReader.Create(reader);
                    zillowProperty = (ZillowPropertySearchDTO.searchresults)xmlSerializer.Deserialize(xmlReader);
                }

                if (zillowProperty.message.code == 0)
                {
                    zillowProperties.Add(zillowProperty);
                }
            }

            return zillowProperties;
        }

        private String CreateURLParmsFromStreetAddress(String streetAddress)
        {
            var collection = HttpUtility.ParseQueryString(string.Empty);
            String street = streetAddress.Substring(0, streetAddress.IndexOf(","));
            String cityState = streetAddress.Substring(streetAddress.IndexOf(",") + 2);

            collection["zws-id"] = this.wsConfig.ZWSID;
            collection["address"] = street;
            collection["citystatezip"] = cityState;
            collection["rentzestimate"] = "true";

            return collection.ToString();
        }

        public Dictionary<int, ZillowPropertyDetailsDTO.updatedPropertyDetails> GetZillowPropertyDetailInfo(List<PropertyInfo> properties)
        {
            Dictionary<int, ZillowPropertyDetailsDTO.updatedPropertyDetails> detailedProperty = new Dictionary<int, ZillowPropertyDetailsDTO.updatedPropertyDetails>();

            //501 code in the message means it's not available
            foreach (PropertyInfo property in properties)
            {
                try
                {
                    String urlParms = CreateURLParmsFromProperty(property);
                    String propertiesDetailXML = WebserviceHelper.CallWS(wsConfig.ZillowGetDetailPropertyEndpoint, urlParms);
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(ZillowPropertyDetailsDTO.updatedPropertyDetails));
                    ZillowPropertyDetailsDTO.updatedPropertyDetails zillowProperty = null;
                    using (var reader = new StringReader(propertiesDetailXML))
                    {
                        XmlReader xmlReader = XmlReader.Create(reader);
                        zillowProperty = (ZillowPropertyDetailsDTO.updatedPropertyDetails)xmlSerializer.Deserialize(xmlReader);
                    }

                    if (zillowProperty.message.code == 0)
                    {
                        detailedProperty.Add(property.zillowPropertyID, zillowProperty);
                    }
                }

                catch (Exception e)
                {
                    //eat the exception. All that will happen is the data won't get populated
                    Console.WriteLine(e.ToString());
                }
            }

            return detailedProperty;
        }

        private String CreateURLParmsFromProperty(PropertyInfo property)
        {
            var collection = HttpUtility.ParseQueryString(string.Empty);

            collection["zws-id"] = this.wsConfig.ZWSID;
            collection["zpid"] = property.zillowPropertyID.ToString();

            return collection.ToString();
        }
    }
}