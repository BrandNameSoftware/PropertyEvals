using Newtonsoft.Json;
using PropertyEval.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using PropertyEval.Helpers;
using System.Web;

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

        //gets the list of initial properties to evaluate
        public void GetListOfProperties()
        {
            String propertiesJSON = WebserviceHelper.CallWS(wsConfig.ImportIOEndpoint, "");
            ImportIOPropertyInfo iioPropertyInfo = JsonConvert.DeserializeObject<ImportIOPropertyInfo>(propertiesJSON);
            Console.WriteLine("blah");
        }
    }
}