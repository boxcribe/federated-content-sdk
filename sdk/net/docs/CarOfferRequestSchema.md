# IO.Swagger.Model.CarOfferRequestSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PickupLocationLatitude** | **float?** | Latitude for car pickup location. | [optional] 
**PickupLocationLongitude** | **float?** | Longitude for car pickup location. | [optional] 
**PickupDate** | **DateTime?** | Scheduled date for car pickup. | [optional] 
**PickupTime** | **string** | Scheduled time for car pickup. | [optional] 
**DropoffLocationLatitude** | **float?** | Latitude for car dropoff location. | [optional] 
**DropoffLocationLongitude** | **float?** | Longitude for car dropoff location. | [optional] 
**DropoffDate** | **DateTime?** | Scheduled date for car dropoff. | [optional] 
**DropoffTime** | **string** | Scheduled time for car dropoff. | [optional] 
**FilterByKeyword** | **string** | Keyword to filter car offers. | [optional] 
**FilterByPriceMin** | [**decimal?**](BigDecimal.md) | Minimum price to filter car offers. | [optional] 
**FilterByPriceMax** | [**decimal?**](BigDecimal.md) | Maximum price to filter car offers. | [optional] 
**FilterByDistanceMin** | **int?** | Minimum distance filter for car offers. | [optional] 
**FilterByDistanceMax** | **int?** | Maximum distance filter for car offers. | [optional] 
**FilterByRatingMin** | **int?** | Minimum rating filter for car offers. | [optional] 
**FilterByRatingMax** | **int?** | Maximum rating filter for car offers. | [optional] 
**FilterByPassengersMin** | **int?** | Minimum passengers capacity filter for car offers. | [optional] 
**FilterByPassengersMax** | **int?** | Maximum passengers capacity filter for car offers. | [optional] 
**FilterByType** | **List&lt;string&gt;** | Types of cars to filter by. | [optional] 
**FilterByCompany** | **List&lt;string&gt;** | Car rental companies to filter by. | [optional] 
**SortBy** | **string** | Field to sort car offers by. | [optional] 
**SortOrder** | **string** | Order to sort car offers (asc, desc). | [optional] 
**Page** | **int?** | Page number for pagination. | [optional] 
**Limit** | **int?** | Number of offers per page. | [optional] 
**Language** | **string** | Language for the offers. | [optional] 
**Currency** | **string** | Currency for the offers. | [optional] 
**Metric** | **string** | Distance metric (mi/km) used in filters. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

