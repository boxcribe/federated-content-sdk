# IO.Swagger.Model.FlightOfferRequestSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cabin** | **List** | Class options: first, business, premium economy, economy. | [optional] 
**Legs** | **List** | Array of flight legs, each described in FlightLegOfferRequestSchema. | [optional] 
**Passengers** | **List** | Array of passengers, each described in FlightPassengerOfferRequestSchema. | [optional] 
**PrivateFareCodes** | **List** | Array of codes for accessing special negotiated fares. | [optional] 
**FilterByKeyword** | **string** | Keyword to filter offers. | [optional] 
**FilterByPriceMin** | **float?** | Minimum price filter. | [optional] 
**FilterByPriceMax** | **float?** | Maximum price filter. | [optional] 
**FilterByDurationMin** | **int?** | Minimum flight duration filter. | [optional] 
**FilterByDurationMax** | **int?** | Maximum flight duration filter. | [optional] 
**FilterByDepartureTimeMin** | **string** | Earliest departure time filter. | [optional] 
**FilterByDepartureTimeMax** | **string** | Latest departure time filter. | [optional] 
**FilterByArrivalTimeMin** | **string** | Earliest arrival time filter. | [optional] 
**FilterByArrivalTimeMax** | **string** | Latest arrival time filter. | [optional] 
**FilterByStopsMin** | **int?** | Minimum number of stops filter. | [optional] 
**FilterByStopsMax** | **int?** | Maximum number of stops filter. | [optional] 
**FilterByAirlines** | **List** | List of airline filters. | [optional] 
**FilterByAirports** | **List** | List of airport filters. | [optional] 
**SortBy** | **string** | Sorting criteria. | [optional] 
**SortOrder** | **string** | Sorting order, asc or desc. | [optional] 
**Page** | **int?** | Pagination: page number. | [optional] 
**Limit** | **int?** | Pagination: maximum items per page. | [optional] 
**Language** | **string** | Language selection for offer details. | [optional] 
**Currency** | **string** | Currency in which prices should be provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

