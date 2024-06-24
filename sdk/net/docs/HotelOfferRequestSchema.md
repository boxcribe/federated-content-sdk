# IO.Swagger.Model.HotelOfferRequestSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationLatitude** | **float?** | Latitude of the hotel location. | [optional] 
**LocationLongitude** | **float?** | Longitude of the hotel location. | [optional] 
**LocationRadius** | **float?** | Search radius from the specified location. | [optional] 
**CheckinDate** | **DateTime?** | Check-in date for the hotel booking. | [optional] 
**CheckoutDate** | **DateTime?** | Check-out date for the hotel booking. | [optional] 
**Rooms** | [**List&lt;HotelOfferRequestSchemaRooms&gt;**](HotelOfferRequestSchemaRooms.md) | Details of rooms including number of adults and children per room. | [optional] 
**FilterByKeyword** | **string** | Keyword to filter hotel offers. | [optional] 
**FilterByPriceMin** | **double?** | Minimum price filter for hotel offers. | [optional] 
**FilterByPriceMax** | **double?** | Maximum price filter for hotel offers. | [optional] 
**FilterByDistanceMin** | **float?** | Minimum distance filter for hotel location. | [optional] 
**FilterByDistanceMax** | **float?** | Maximum distance filter for hotel location. | [optional] 
**FilterByRatingMin** | **float?** | Minimum rating filter for hotels. | [optional] 
**FilterByRatingMax** | **float?** | Maximum rating filter for hotels. | [optional] 
**FilterByStars** | **List&lt;int?&gt;** | Filter hotels by star ratings. | [optional] 
**FilterByFacilities** | **List&lt;string&gt;** | Filter hotels by available facilities. | [optional] 
**FilterByAmenities** | **List&lt;string&gt;** | Filter hotels by available amenities. | [optional] 
**SortBy** | **string** | Field to sort the results by. | [optional] 
**SortOrder** | **string** | Order to sort the results, either asc or desc. | [optional] 
**Page** | **int?** | Page number for pagination. | [optional] 
**Limit** | **int?** | Number of items per page for pagination. | [optional] 
**Language** | **string** | Preferred language of the hotel information. | [optional] 
**Currency** | **string** | Currency in which prices should be displayed. | [optional] 
**Metric** | **string** | Unit of measure for distance, either miles (mi) or kilometers (km). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

