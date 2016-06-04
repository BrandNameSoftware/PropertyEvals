using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyEval.DTOs
{
    public class ImportIOPropertyInfo
    {
        public Extractordata extractorData { get; set; }
        public Pagedata pageData { get; set; }

        public class Extractordata
        {
            public string url { get; set; }
            public string resourceId { get; set; }
            public Datum[] data { get; set; }
        }

        public class Datum
        {
            public Group[] group { get; set; }
        }

        public class Group
        {
            public Address[] Address { get; set; }
            public StreetAddress[] Streetaddress { get; set; }
            public ZIPCode[] ZIPcode { get; set; }
            public ListedPrice[] Listedprice { get; set; }
            public State[] State { get; set; }
            public City[] City { get; set; }
        }

        public class Address
        {
            public string text { get; set; }
            public string href { get; set; }
        }

        public class StreetAddress
        {
            public string text { get; set; }
            public string href { get; set; }
        }

        public class ZIPCode
        {
            public string text { get; set; }
            public string href { get; set; }
        }

        public class ListedPrice
        {
            public string text { get; set; }
        }

        public class State
        {
            public string text { get; set; }
        }

        public class City
        {
            public string text { get; set; }
        }

        public class Pagedata
        {
            public int statusCode { get; set; }
            public long timestamp { get; set; }
        }
    }
}