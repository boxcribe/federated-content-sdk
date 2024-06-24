# FlightOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cabin** | [***Array**](array.md) | Class options: first, business, premium economy, economy. | [optional] [default to null]
**Legs** | [***Array**](array.md) | Array of flight legs, each described in FlightLegOfferRequestSchema. | [optional] [default to null]
**Passengers** | [***Array**](array.md) | Array of passengers, each described in FlightPassengerOfferRequestSchema. | [optional] [default to null]
**PrivateFareCodes** | [***Array**](array.md) | Array of codes for accessing special negotiated fares. | [optional] [default to null]
**FilterByKeyword** | **string** | Keyword to filter offers. | [optional] [default to null]
**FilterByPriceMin** | **float32** | Minimum price filter. | [optional] [default to null]
**FilterByPriceMax** | **float32** | Maximum price filter. | [optional] [default to null]
**FilterByDurationMin** | **int32** | Minimum flight duration filter. | [optional] [default to null]
**FilterByDurationMax** | **int32** | Maximum flight duration filter. | [optional] [default to null]
**FilterByDepartureTimeMin** | **string** | Earliest departure time filter. | [optional] [default to null]
**FilterByDepartureTimeMax** | **string** | Latest departure time filter. | [optional] [default to null]
**FilterByArrivalTimeMin** | **string** | Earliest arrival time filter. | [optional] [default to null]
**FilterByArrivalTimeMax** | **string** | Latest arrival time filter. | [optional] [default to null]
**FilterByStopsMin** | **int32** | Minimum number of stops filter. | [optional] [default to null]
**FilterByStopsMax** | **int32** | Maximum number of stops filter. | [optional] [default to null]
**FilterByAirlines** | [***Array**](array.md) | List of airline filters. | [optional] [default to null]
**FilterByAirports** | [***Array**](array.md) | List of airport filters. | [optional] [default to null]
**SortBy** | **string** | Sorting criteria. | [optional] [default to null]
**SortOrder** | **string** | Sorting order, asc or desc. | [optional] [default to null]
**Page** | **int32** | Pagination: page number. | [optional] [default to null]
**Limit** | **int32** | Pagination: maximum items per page. | [optional] [default to null]
**Language** | **string** | Language selection for offer details. | [optional] [default to null]
**Currency** | **string** | Currency in which prices should be provided. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

