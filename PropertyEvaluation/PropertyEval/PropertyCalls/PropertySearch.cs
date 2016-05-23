using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PropertyEval.PropertyCalls.WebserviceCalls;

namespace PropertyEval.PropertyCalls
{
    public class PropertySearch
    {
        public static void SearchForProperties()
        {
            PropertyWSCalls wsCalls = new PropertyWSCalls();

            //get a list of properties first
            wsCalls.GetListOfProperties();

            //get the detailed property info from Zillow. Don't search if above a threshold
        }
    }
}