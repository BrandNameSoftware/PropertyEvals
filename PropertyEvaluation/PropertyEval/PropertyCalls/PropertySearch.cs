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
        public static List<PropertyInfo> SearchForProperties(List<String> streetAddresses)
        {
            PropertyWSCalls wsCalls = new PropertyWSCalls();

            //get the detailed property info from Zillow
            List<ZillowPropertySearchDTO.searchresults> zillowSearchData = wsCalls.GetZillowPropertyBasicInfo(streetAddresses);
            List<PropertyInfo> properties = MapZillowXMLtoDTO(zillowSearchData);
            
            //Get the listing info from Zillow
            Dictionary<int, ZillowPropertyDetailsDTO.updatedPropertyDetails> propDetails = wsCalls.GetZillowPropertyDetailInfo(properties);

            AddDetailInfoToPropertyInfo(propDetails, properties);

            return properties;
        }

        private static void AddDetailInfoToPropertyInfo(Dictionary<int, ZillowPropertyDetailsDTO.updatedPropertyDetails> propDetails, List<PropertyInfo> properties)
        {
            foreach (PropertyInfo property in properties)
            {
                try
                {
                    ZillowPropertyDetailsDTO.updatedPropertyDetails details = propDetails[property.zillowPropertyID];
                    property.askingPrice = (int)details.response.price.Value;
                    property.status = details.response.posting.status;
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        private static List<PropertyInfo> MapZillowXMLtoDTO(List<ZillowPropertySearchDTO.searchresults> zillowSearchData)
        {
            List<PropertyInfo> properties = new List<PropertyInfo>();
            foreach (ZillowPropertySearchDTO.searchresults searchData in zillowSearchData)
            {
                ZillowPropertySearchDTO.responseResultsResult result = searchData.response.results.result;
                PropertyInfo property = new PropertyInfo();
                property.city = result.address.city;
                property.estimateRent = (result.rentzestimate == null)? -1 : result.rentzestimate.amount.Value;
                property.estimateValue = Convert.ToInt32(result.zestimate.amount.Value);
                property.linkToProperty = new Uri(result.links.homedetails);
                property.state = result.address.state;
                property.streetAddress = result.address.street;
                property.zillowPropertyID = Convert.ToInt32(result.zpid);
                property.ZIP = Convert.ToInt32(result.address.zipcode);

                PropertyInfo.NeighborhoodInfo neighborhoodInfo = new PropertyInfo.NeighborhoodInfo();
                neighborhoodInfo.regionID = Convert.ToInt32(result.localRealEstate.region.id);
                neighborhoodInfo.regionName = result.localRealEstate.region.name;
                neighborhoodInfo.zillowRegionIndex = Convert.ToInt32(result.localRealEstate.region.zindexValue.Replace(",", ""));
                property.neighborhoodInfo = neighborhoodInfo;

                properties.Add(property);
            }
            return properties;
        }
    }
}