using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyEval.DTOs
{
    public class PropertyInfo
    {
        public int zillowPropertyID { get; set; }
        public int estimateValue { get; set; }
        public int estimateRent { get; set; }
        public String streetAddress { get; set; }
        public int ZIP { get; set; }
        public String state { get; set; }
        public String city { get; set; }
        public Uri linkToProperty { get; set; }
        public NeighborhoodInfo neighborhoodInfo { get; set; }

        public struct NeighborhoodInfo
        {
            public String regionName { get; set; }
            public int regionID { get; set; }
            public int zillowRegionIndex { get; set; }
        }
    }
}