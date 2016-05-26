﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyEval.DTOs
{
    public class ZillowPropertySearchDTO
    {

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/SearchResults.xsd")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.zillow.com/static/xsd/SearchResults.xsd", IsNullable = false)]
        public partial class searchresults
        {

            private request requestField;

            private message messageField;

            private response responseField;

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public request request
            {
                get
                {
                    return this.requestField;
                }
                set
                {
                    this.requestField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public message message
            {
                get
                {
                    return this.messageField;
                }
                set
                {
                    this.messageField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute(Namespace = "")]
            public response response
            {
                get
                {
                    return this.responseField;
                }
                set
                {
                    this.responseField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class request
        {

            private string addressField;

            private string citystatezipField;

            /// <remarks/>
            public string address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            public string citystatezip
            {
                get
                {
                    return this.citystatezipField;
                }
                set
                {
                    this.citystatezipField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class message
        {

            private string textField;

            private byte codeField;

            /// <remarks/>
            public string text
            {
                get
                {
                    return this.textField;
                }
                set
                {
                    this.textField = value;
                }
            }

            /// <remarks/>
            public byte code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class response
        {

            private responseResults resultsField;

            /// <remarks/>
            public responseResults results
            {
                get
                {
                    return this.resultsField;
                }
                set
                {
                    this.resultsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResults
        {

            private responseResultsResult resultField;

            /// <remarks/>
            public responseResultsResult result
            {
                get
                {
                    return this.resultField;
                }
                set
                {
                    this.resultField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResult
        {

            private uint zpidField;

            private responseResultsResultLinks linksField;

            private responseResultsResultAddress addressField;

            private responseResultsResultZestimate zestimateField;

            private responseResultsResultLocalRealEstate localRealEstateField;

            /// <remarks/>
            public uint zpid
            {
                get
                {
                    return this.zpidField;
                }
                set
                {
                    this.zpidField = value;
                }
            }

            /// <remarks/>
            public responseResultsResultLinks links
            {
                get
                {
                    return this.linksField;
                }
                set
                {
                    this.linksField = value;
                }
            }

            /// <remarks/>
            public responseResultsResultAddress address
            {
                get
                {
                    return this.addressField;
                }
                set
                {
                    this.addressField = value;
                }
            }

            /// <remarks/>
            public responseResultsResultZestimate zestimate
            {
                get
                {
                    return this.zestimateField;
                }
                set
                {
                    this.zestimateField = value;
                }
            }

            /// <remarks/>
            public responseResultsResultLocalRealEstate localRealEstate
            {
                get
                {
                    return this.localRealEstateField;
                }
                set
                {
                    this.localRealEstateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultLinks
        {

            private string homedetailsField;

            private string mapthishomeField;

            private string comparablesField;

            /// <remarks/>
            public string homedetails
            {
                get
                {
                    return this.homedetailsField;
                }
                set
                {
                    this.homedetailsField = value;
                }
            }

            /// <remarks/>
            public string mapthishome
            {
                get
                {
                    return this.mapthishomeField;
                }
                set
                {
                    this.mapthishomeField = value;
                }
            }

            /// <remarks/>
            public string comparables
            {
                get
                {
                    return this.comparablesField;
                }
                set
                {
                    this.comparablesField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultAddress
        {

            private string streetField;

            private uint zipcodeField;

            private string cityField;

            private string stateField;

            private decimal latitudeField;

            private decimal longitudeField;

            /// <remarks/>
            public string street
            {
                get
                {
                    return this.streetField;
                }
                set
                {
                    this.streetField = value;
                }
            }

            /// <remarks/>
            public uint zipcode
            {
                get
                {
                    return this.zipcodeField;
                }
                set
                {
                    this.zipcodeField = value;
                }
            }

            /// <remarks/>
            public string city
            {
                get
                {
                    return this.cityField;
                }
                set
                {
                    this.cityField = value;
                }
            }

            /// <remarks/>
            public string state
            {
                get
                {
                    return this.stateField;
                }
                set
                {
                    this.stateField = value;
                }
            }

            /// <remarks/>
            public decimal latitude
            {
                get
                {
                    return this.latitudeField;
                }
                set
                {
                    this.latitudeField = value;
                }
            }

            /// <remarks/>
            public decimal longitude
            {
                get
                {
                    return this.longitudeField;
                }
                set
                {
                    this.longitudeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultZestimate
        {

            private responseResultsResultZestimateAmount amountField;

            private string lastupdatedField;

            private responseResultsResultZestimateOneWeekChange oneWeekChangeField;

            private object valueChangeField;

            private responseResultsResultZestimateValuationRange valuationRangeField;

            private byte percentileField;

            /// <remarks/>
            public responseResultsResultZestimateAmount amount
            {
                get
                {
                    return this.amountField;
                }
                set
                {
                    this.amountField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlElementAttribute("last-updated")]
            public string lastupdated
            {
                get
                {
                    return this.lastupdatedField;
                }
                set
                {
                    this.lastupdatedField = value;
                }
            }

            /// <remarks/>
            public responseResultsResultZestimateOneWeekChange oneWeekChange
            {
                get
                {
                    return this.oneWeekChangeField;
                }
                set
                {
                    this.oneWeekChangeField = value;
                }
            }

            /// <remarks/>
            public object valueChange
            {
                get
                {
                    return this.valueChangeField;
                }
                set
                {
                    this.valueChangeField = value;
                }
            }

            /// <remarks/>
            public responseResultsResultZestimateValuationRange valuationRange
            {
                get
                {
                    return this.valuationRangeField;
                }
                set
                {
                    this.valuationRangeField = value;
                }
            }

            /// <remarks/>
            public byte percentile
            {
                get
                {
                    return this.percentileField;
                }
                set
                {
                    this.percentileField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultZestimateAmount
        {

            private string currencyField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string currency
            {
                get
                {
                    return this.currencyField;
                }
                set
                {
                    this.currencyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultZestimateOneWeekChange
        {

            private bool deprecatedField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public bool deprecated
            {
                get
                {
                    return this.deprecatedField;
                }
                set
                {
                    this.deprecatedField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultZestimateValuationRange
        {

            private responseResultsResultZestimateValuationRangeLow lowField;

            private responseResultsResultZestimateValuationRangeHigh highField;

            /// <remarks/>
            public responseResultsResultZestimateValuationRangeLow low
            {
                get
                {
                    return this.lowField;
                }
                set
                {
                    this.lowField = value;
                }
            }

            /// <remarks/>
            public responseResultsResultZestimateValuationRangeHigh high
            {
                get
                {
                    return this.highField;
                }
                set
                {
                    this.highField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultZestimateValuationRangeLow
        {

            private string currencyField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string currency
            {
                get
                {
                    return this.currencyField;
                }
                set
                {
                    this.currencyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultZestimateValuationRangeHigh
        {

            private string currencyField;

            private uint valueField;

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string currency
            {
                get
                {
                    return this.currencyField;
                }
                set
                {
                    this.currencyField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlTextAttribute()]
            public uint Value
            {
                get
                {
                    return this.valueField;
                }
                set
                {
                    this.valueField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultLocalRealEstate
        {

            private responseResultsResultLocalRealEstateRegion regionField;

            /// <remarks/>
            public responseResultsResultLocalRealEstateRegion region
            {
                get
                {
                    return this.regionField;
                }
                set
                {
                    this.regionField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultLocalRealEstateRegion
        {

            private string zindexValueField;

            private responseResultsResultLocalRealEstateRegionLinks linksField;

            private string nameField;

            private uint idField;

            private string typeField;

            /// <remarks/>
            public string zindexValue
            {
                get
                {
                    return this.zindexValueField;
                }
                set
                {
                    this.zindexValueField = value;
                }
            }

            /// <remarks/>
            public responseResultsResultLocalRealEstateRegionLinks links
            {
                get
                {
                    return this.linksField;
                }
                set
                {
                    this.linksField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public uint id
            {
                get
                {
                    return this.idField;
                }
                set
                {
                    this.idField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string type
            {
                get
                {
                    return this.typeField;
                }
                set
                {
                    this.typeField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseResultsResultLocalRealEstateRegionLinks
        {

            private string overviewField;

            private string forSaleByOwnerField;

            private string forSaleField;

            /// <remarks/>
            public string overview
            {
                get
                {
                    return this.overviewField;
                }
                set
                {
                    this.overviewField = value;
                }
            }

            /// <remarks/>
            public string forSaleByOwner
            {
                get
                {
                    return this.forSaleByOwnerField;
                }
                set
                {
                    this.forSaleByOwnerField = value;
                }
            }

            /// <remarks/>
            public string forSale
            {
                get
                {
                    return this.forSaleField;
                }
                set
                {
                    this.forSaleField = value;
                }
            }
        }


    }
}