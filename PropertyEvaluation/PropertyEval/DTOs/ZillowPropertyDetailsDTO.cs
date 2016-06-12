using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PropertyEval.DTOs
{
   public class ZillowPropertyDetailsDTO
    {
        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.zillow.com/static/xsd/UpdatedPropertyDetails.xsd", IsNullable = false)]
        public partial class updatedPropertyDetails
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

            private uint zpidField;

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

            private uint zpidField;

            private responsePageViewCount pageViewCountField;

            private responseAddress addressField;

            private responsePosting postingField;

            private responsePrice priceField;

            private responseLinks linksField;

            private responseImages imagesField;

            private responseEditedFacts editedFactsField;

            private string homeDescriptionField;

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
            public string homeDescription
            {
                get
                {
                    return this.homeDescriptionField;
                }
                set
                {
                    this.homeDescriptionField = value;
                }
            }

            /// <remarks/>
            public responsePageViewCount pageViewCount
            {
                get
                {
                    return this.pageViewCountField;
                }
                set
                {
                    this.pageViewCountField = value;
                }
            }

            /// <remarks/>
            public responseAddress address
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
            public responsePosting posting
            {
                get
                {
                    return this.postingField;
                }
                set
                {
                    this.postingField = value;
                }
            }

            /// <remarks/>
            public responsePrice price
            {
                get
                {
                    return this.priceField;
                }
                set
                {
                    this.priceField = value;
                }
            }

            /// <remarks/>
            public responseLinks links
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
            public responseImages images
            {
                get
                {
                    return this.imagesField;
                }
                set
                {
                    this.imagesField = value;
                }
            }

            /// <remarks/>
            public responseEditedFacts editedFacts
            {
                get
                {
                    return this.editedFactsField;
                }
                set
                {
                    this.editedFactsField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responsePageViewCount
        {

            private byte currentMonthField;

            private byte totalField;

            /// <remarks/>
            public byte currentMonth
            {
                get
                {
                    return this.currentMonthField;
                }
                set
                {
                    this.currentMonthField = value;
                }
            }

            /// <remarks/>
            public byte total
            {
                get
                {
                    return this.totalField;
                }
                set
                {
                    this.totalField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseAddress
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
        public partial class responsePosting
        {

            private string statusField;

            private string typeField;

            private string lastUpdatedDateField;

            /// <remarks/>
            public string status
            {
                get
                {
                    return this.statusField;
                }
                set
                {
                    this.statusField = value;
                }
            }

            /// <remarks/>
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

            /// <remarks/>
            public string lastUpdatedDate
            {
                get
                {
                    return this.lastUpdatedDateField;
                }
                set
                {
                    this.lastUpdatedDateField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responsePrice
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
        public partial class responseLinks
        {

            private string homeDetailsField;

            private string photoGalleryField;

            private string homeInfoField;

            /// <remarks/>
            public string homeDetails
            {
                get
                {
                    return this.homeDetailsField;
                }
                set
                {
                    this.homeDetailsField = value;
                }
            }

            /// <remarks/>
            public string photoGallery
            {
                get
                {
                    return this.photoGalleryField;
                }
                set
                {
                    this.photoGalleryField = value;
                }
            }

            /// <remarks/>
            public string homeInfo
            {
                get
                {
                    return this.homeInfoField;
                }
                set
                {
                    this.homeInfoField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseImages
        {

            private byte countField;

            private string[] imageField;

            /// <remarks/>
            public byte count
            {
                get
                {
                    return this.countField;
                }
                set
                {
                    this.countField = value;
                }
            }

            /// <remarks/>
            [System.Xml.Serialization.XmlArrayItemAttribute("url", IsNullable = false)]
            public string[] image
            {
                get
                {
                    return this.imageField;
                }
                set
                {
                    this.imageField = value;
                }
            }
        }

        /// <remarks/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class responseEditedFacts
        {

            private string useCodeField;

            private ushort lotSizeSqFtField;

            /// <remarks/>
            public string useCode
            {
                get
                {
                    return this.useCodeField;
                }
                set
                {
                    this.useCodeField = value;
                }
            }

            /// <remarks/>
            public ushort lotSizeSqFt
            {
                get
                {
                    return this.lotSizeSqFtField;
                }
                set
                {
                    this.lotSizeSqFtField = value;
                }
            }
        }


    }
}