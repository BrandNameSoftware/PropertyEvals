﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyEval.DTOs
{
    public class WebserviceConfig
    {
        public String ZWSID { get; set; }
        public String ZillowSearchByStreetEndpoint { get; set; }
        public String ImportIOEndpoint { get; set; }
        public String ZillowGetDetailPropertyEndpoint { get; set; }
    }
}