using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PropertyEval.PropertyCalls.WebserviceCalls;
using PropertyEval.DTOs;

namespace PropertyEval.PropertyCalls
{
    public class PropertySearch
    {
        public static void SearchForProperties()
        {
            PropertyWSCalls wsCalls = new PropertyWSCalls();

            //get a list of properties first
            List<String> streetAddresses = wsCalls.GetListOfProperties();
            List<PropertyInfo> properties = new List<PropertyInfo>();

            //get the detailed property info from Zillow. Don't search if above a threshold
            wsCalls.GetPropertyDetails(streetAddresses);
        }
    }
}