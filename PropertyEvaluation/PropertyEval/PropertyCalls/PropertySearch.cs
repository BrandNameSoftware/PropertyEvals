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
        public static Dictionary<int, PropertyInfo> SearchForProperties(List<String> streetAddresses)
        {
            PropertyWSCalls wsCalls = new PropertyWSCalls();

            //get the detailed property info from Zillow
            List<ZillowPropertySearchDTO.searchresults> zillowSearchData = wsCalls.GetZillowPropertyBasicInfo(streetAddresses);

            Dictionary<int, PropertyInfo> properties = MapZillowXMLtoDTO(zillowSearchData);
            
            //Get the listing info from Zillow
            List<ZillowPropertyDetailsDTO.updatedPropertyDetails> propDetails = wsCalls.GetZillowPropertyDetailInfo(properties);

            UpdateZillowDataWithDetails(properties, propDetails);

            return properties;
        }

        private static void UpdateZillowDataWithDetails(Dictionary<int, PropertyInfo> properties, List<ZillowPropertyDetailsDTO.updatedPropertyDetails> additionalDetails)
        {
            foreach (ZillowPropertyDetailsDTO.updatedPropertyDetails details in additionalDetails)
            {
                try
                {
                    int zpid = (int)details.response.zpid;
                    properties[zpid].askingPrice = (details.response.price == null) ? null : (int?)details.response.price.Value;
                    properties[zpid].description = (String)details.response.homeDescription;
                    properties[zpid].status = details.response.posting.status;
                }
                    catch (KeyNotFoundException knfe)
                {

                    //eat the error
                }
            }
        }

        private static Dictionary<int, PropertyInfo> MapZillowXMLtoDTO(List<ZillowPropertySearchDTO.searchresults> zillowSearchData)
        {
            Dictionary<int, PropertyInfo> properties = new Dictionary<int, PropertyInfo>();
            foreach (ZillowPropertySearchDTO.searchresults searchData in zillowSearchData)
            {
                ZillowPropertySearchDTO.responseResultsResult result = searchData.response.results.result;
                PropertyInfo property = new PropertyInfo();
                property.city = result.address.city;
                property.estimateRent = (result.rentzestimate == null)? null : (int?)result.rentzestimate.amount.Value;
                property.estimateValue = Convert.ToInt32(result.zestimate.amount.Value);
                property.linkToProperty = new Uri(result.links.homedetails);
                property.state = result.address.state;
                property.streetAddress = result.address.street;
                property.zillowPropertyID = Convert.ToInt32(result.zpid);
                property.ZIP = Convert.ToInt32(result.address.zipcode);

                PropertyInfo.NeighborhoodInfo neighborhoodInfo = new PropertyInfo.NeighborhoodInfo();
                neighborhoodInfo.regionID = Convert.ToInt32(result.localRealEstate.region.id);
                neighborhoodInfo.regionName = result.localRealEstate.region.name;
                if (result.localRealEstate.region.zindexValue != null)
                {
                    neighborhoodInfo.zillowRegionIndex = Convert.ToInt32(result.localRealEstate.region.zindexValue.Replace(",", ""));
                }
                property.neighborhoodInfo = neighborhoodInfo;

                properties.Add(property.zillowPropertyID, property);
            }
            return properties;
        }
    }
}