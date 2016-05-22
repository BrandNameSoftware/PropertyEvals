using Newtonsoft.Json;
using PropertyEval.DTOs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace PropertyEval.PropertyCalls.ZillowCalls
{
    public class ZillowWSCalls
    {
        private ZillowConfig zillowConfig;
        public ZillowWSCalls()
        {
            String configPath = HttpContext.Current.Server.MapPath("~") + "config.json";
            using (StreamReader r = new StreamReader(configPath))
            {
                string json = r.ReadToEnd();
                zillowConfig = JsonConvert.DeserializeObject<ZillowConfig>(json);
            }
        }

        public void SearchZillow()
        {

        }
    }
}