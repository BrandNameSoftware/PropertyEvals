using Newtonsoft.Json;
using PropertyEval.DTOs;
using System;
using System.Collections;
using System.IO;
using PropertyEval.Helpers;
using System.Web;
using System.Collections.Generic;

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



            return zillowProperties;
        }
    }
}