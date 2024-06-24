# FlightOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cabin** | **list** | Class options: first, business, premium economy, economy. | [optional] 
**legs** | **list** | Array of flight legs, each described in FlightLegOfferRequestSchema. | [optional] 
**passengers** | **list** | Array of passengers, each described in FlightPassengerOfferRequestSchema. | [optional] 
**private_fare_codes** | **list** | Array of codes for accessing special negotiated fares. | [optional] 
**filter_by_keyword** | **str** | Keyword to filter offers. | [optional] 
**filter_by_price_min** | **float** | Minimum price filter. | [optional] 
**filter_by_price_max** | **float** | Maximum price filter. | [optional] 
**filter_by_duration_min** | **int** | Minimum flight duration filter. | [optional] 
**filter_by_duration_max** | **int** | Maximum flight duration filter. | [optional] 
**filter_by_departure_time_min** | **str** | Earliest departure time filter. | [optional] 
**filter_by_departure_time_max** | **str** | Latest departure time filter. | [optional] 
**filter_by_arrival_time_min** | **str** | Earliest arrival time filter. | [optional] 
**filter_by_arrival_time_max** | **str** | Latest arrival time filter. | [optional] 
**filter_by_stops_min** | **int** | Minimum number of stops filter. | [optional] 
**filter_by_stops_max** | **int** | Maximum number of stops filter. | [optional] 
**filter_by_airlines** | **list** | List of airline filters. | [optional] 
**filter_by_airports** | **list** | List of airport filters. | [optional] 
**sort_by** | **str** | Sorting criteria. | [optional] 
**sort_order** | **str** | Sorting order, asc or desc. | [optional] 
**page** | **int** | Pagination: page number. | [optional] 
**limit** | **int** | Pagination: maximum items per page. | [optional] 
**language** | **str** | Language selection for offer details. | [optional] 
**currency** | **str** | Currency in which prices should be provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

