# FlightOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cabin** | [**array**](array.md) | Class options: first, business, premium economy, economy. | [optional] 
**legs** | [**array**](array.md) | Array of flight legs, each described in FlightLegOfferRequestSchema. | [optional] 
**passengers** | [**array**](array.md) | Array of passengers, each described in FlightPassengerOfferRequestSchema. | [optional] 
**private_fare_codes** | [**array**](array.md) | Array of codes for accessing special negotiated fares. | [optional] 
**filter_by_keyword** | **string** | Keyword to filter offers. | [optional] 
**filter_by_price_min** | **float** | Minimum price filter. | [optional] 
**filter_by_price_max** | **float** | Maximum price filter. | [optional] 
**filter_by_duration_min** | **int** | Minimum flight duration filter. | [optional] 
**filter_by_duration_max** | **int** | Maximum flight duration filter. | [optional] 
**filter_by_departure_time_min** | **string** | Earliest departure time filter. | [optional] 
**filter_by_departure_time_max** | **string** | Latest departure time filter. | [optional] 
**filter_by_arrival_time_min** | **string** | Earliest arrival time filter. | [optional] 
**filter_by_arrival_time_max** | **string** | Latest arrival time filter. | [optional] 
**filter_by_stops_min** | **int** | Minimum number of stops filter. | [optional] 
**filter_by_stops_max** | **int** | Maximum number of stops filter. | [optional] 
**filter_by_airlines** | [**array**](array.md) | List of airline filters. | [optional] 
**filter_by_airports** | [**array**](array.md) | List of airport filters. | [optional] 
**sort_by** | **string** | Sorting criteria. | [optional] 
**sort_order** | **string** | Sorting order, asc or desc. | [optional] 
**page** | **int** | Pagination: page number. | [optional] 
**limit** | **int** | Pagination: maximum items per page. | [optional] 
**language** | **string** | Language selection for offer details. | [optional] 
**currency** | **string** | Currency in which prices should be provided. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

