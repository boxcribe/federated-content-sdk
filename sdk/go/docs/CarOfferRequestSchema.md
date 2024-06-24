# CarOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PickupLocationLatitude** | **float32** | Latitude for car pickup location. | [optional] [default to null]
**PickupLocationLongitude** | **float32** | Longitude for car pickup location. | [optional] [default to null]
**PickupDate** | **string** | Scheduled date for car pickup. | [optional] [default to null]
**PickupTime** | **string** | Scheduled time for car pickup. | [optional] [default to null]
**DropoffLocationLatitude** | **float32** | Latitude for car dropoff location. | [optional] [default to null]
**DropoffLocationLongitude** | **float32** | Longitude for car dropoff location. | [optional] [default to null]
**DropoffDate** | **string** | Scheduled date for car dropoff. | [optional] [default to null]
**DropoffTime** | **string** | Scheduled time for car dropoff. | [optional] [default to null]
**FilterByKeyword** | **string** | Keyword to filter car offers. | [optional] [default to null]
**FilterByPriceMin** | **float64** | Minimum price to filter car offers. | [optional] [default to null]
**FilterByPriceMax** | **float64** | Maximum price to filter car offers. | [optional] [default to null]
**FilterByDistanceMin** | **int32** | Minimum distance filter for car offers. | [optional] [default to null]
**FilterByDistanceMax** | **int32** | Maximum distance filter for car offers. | [optional] [default to null]
**FilterByRatingMin** | **int32** | Minimum rating filter for car offers. | [optional] [default to null]
**FilterByRatingMax** | **int32** | Maximum rating filter for car offers. | [optional] [default to null]
**FilterByPassengersMin** | **int32** | Minimum passengers capacity filter for car offers. | [optional] [default to null]
**FilterByPassengersMax** | **int32** | Maximum passengers capacity filter for car offers. | [optional] [default to null]
**FilterByType** | **[]string** | Types of cars to filter by. | [optional] [default to null]
**FilterByCompany** | **[]string** | Car rental companies to filter by. | [optional] [default to null]
**SortBy** | **string** | Field to sort car offers by. | [optional] [default to null]
**SortOrder** | **string** | Order to sort car offers (asc, desc). | [optional] [default to null]
**Page** | **int32** | Page number for pagination. | [optional] [default to null]
**Limit** | **int32** | Number of offers per page. | [optional] [default to null]
**Language** | **string** | Language for the offers. | [optional] [default to null]
**Currency** | **string** | Currency for the offers. | [optional] [default to null]
**Metric** | **string** | Distance metric (mi/km) used in filters. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

