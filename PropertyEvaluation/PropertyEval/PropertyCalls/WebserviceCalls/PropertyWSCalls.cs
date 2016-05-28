using Newtonsoft.Json;
using PropertyEval.DTOs;
using System;
using System.Collections;
using System.IO;
using PropertyEval.Helpers;
using System.Web;
using System.Collections.Generic;
using System.Xml.Serialization;

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

            if (iioPropertyInfo.pageData.statusCode == 200)
            {
                foreach (ImportIOPropertyInfo.Group group in iioPropertyInfo.extractorData.data[0].group)
                {
                    addresses.Add(group.Address[0].text);
                }
            }

            return addresses;
        }

        public List<ZillowPropertySearchDTO> GetPropertyDetails(List<String> streetAddresses)
        {
            List<ZillowPropertySearchDTO> zillowProperties = new List<ZillowPropertySearchDTO>();

            foreach (String streetAddress in streetAddresses)
            {
                String urlParms = CreateURLParmsFromStreetAddress(streetAddress);
                String propertiesDetailXML = WebserviceHelper.CallWS(wsConfig.ZillowSearchByStreetEndpoint, urlParms);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(ZillowPropertySearchDTO));
                ZillowPropertySearchDTO zillowProperty = null;
                using (var reader = new StringReader(propertiesDetailXML))
                {
                    zillowProperty = (ZillowPropertySearchDTO)xmlSerializer.Deserialize(reader);
                }
                zillowProperties.Add(zillowProperty);
            }

            return zillowProperties;
        }

        private String CreateURLParmsFromStreetAddress(String streetAddress)
        {
            // sneaky way to get a HttpValueCollection (which is internal)
            var collection = HttpUtility.ParseQueryString(string.Empty);
            String street = streetAddress.Substring(0, streetAddress.IndexOf(","));
            String cityState = streetAddress.Substring(streetAddress.IndexOf(",") + 2);

            collection["zws-id"] = this.wsConfig.ZWSID;
            collection["address"] = street;
            collection["citystatezip"] = cityState;
            collection["rentzestimate"] = "true";

            return collection.ToString();
        }
    }
}