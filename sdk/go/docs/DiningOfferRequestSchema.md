# DiningOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationLatitude** | **float32** | Latitude for the event location. | [optional] [default to null]
**LocationLongitude** | **float32** | Longitude for the event location. | [optional] [default to null]
**LocationRadius** | **float32** | Radius to search for events around the location coordinates. | [optional] [default to null]
**Date** | **string** | Date for the dining search. | [optional] [default to null]
**FilterByKeyword** | **string** | Keywords to filter the events. | [optional] [default to null]
**FilterByPriceMin** | **float64** | Minimum price to filter the events. | [optional] [default to null]
**FilterByPriceMax** | **float64** | Maximum price to filter the events. | [optional] [default to null]
**FilterByDistanceMin** | **float64** | Minimum distance to filter events. | [optional] [default to null]
**FilterByDistanceMax** | **float64** | Maximum distance to filter events. | [optional] [default to null]
**FilterByRatingMin** | **float64** | Minimum rating to filter events. | [optional] [default to null]
**FilterByRatingMax** | **float64** | Maximum rating to filter events. | [optional] [default to null]
**FilterBySubcategories** | **[]string** | Filter events by specific subcategories. | [optional] [default to null]
**SortBy** | **string** | Field to sort events by. | [optional] [default to null]
**SortOrder** | **string** | Order to sort events (asc, desc). | [optional] [default to null]
**Page** | **float64** | Page number for pagination. | [optional] [default to null]
**Limit** | **float64** | Number of events per page. | [optional] [default to null]
**Language** | **string** | Language for the event offers. | [optional] [default to null]
**Currency** | **string** | Currency for the event offers. | [optional] [default to null]
**Metric** | **string** | Distance metric (mi/km) used in filters. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

