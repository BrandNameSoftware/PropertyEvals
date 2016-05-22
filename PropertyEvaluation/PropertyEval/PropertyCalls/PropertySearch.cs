using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PropertyEval.PropertyCalls.ZillowCalls;

namespace PropertyEval.PropertyCalls
{
    public class PropertySearch
    {
        public static void SearchForProperties()
        {
            ZillowWSCalls zillow = new ZillowWSCalls();
            zillow.SearchZillow();
        }
    }
}