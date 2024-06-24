# SwaggerClient::FlightOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cabin** | **Array** | Class options: first, business, premium economy, economy. | [optional] 
**legs** | **Array** | Array of flight legs, each described in FlightLegOfferRequestSchema. | [optional] 
**passengers** | **Array** | Array of passengers, each described in FlightPassengerOfferRequestSchema. | [optional] 
**private_fare_codes** | **Array** | Array of codes for accessing special negotiated fares. | [optional] 
**filter_by_keyword** | **String** | Keyword to filter offers. | [optional] 
**filter_by_price_min** | **Float** | Minimum price filter. | [optional] 
**filter_by_price_max** | **Float** | Maximum price filter. | [optional] 
**filter_by_duration_min** | **Integer** | Minimum flight duration filter. | [optional] 
**filter_by_duration_max** | **Integer** | Maximum flight duration filter. | [optional] 
**filter_by_departure_time_min** | **String** | Earliest departure time filter. | [optional] 
**filter_by_departure_time_max** | **String** | Latest departure time filter. | [optional] 
**filter_by_arrival_time_min** | **String** | Earliest arrival time filter. | [optional] 
**filter_by_arrival_time_max** | **String** | Latest arrival time filter. | [optional] 
**filter_by_stops_min** | **Integer** | Minimum number of stops filter. | [optional] 
**filter_by_stops_max** | **Integer** | Maximum number of stops filter. | [optional] 
**filter_by_airlines** | **Array** | List of airline filters. | [optional] 
**filter_by_airports** | **Array** | List of airport filters. | [optional] 
**sort_by** | **String** | Sorting criteria. | [optional] 
**sort_order** | **String** | Sorting order, asc or desc. | [optional] 
**page** | **Integer** | Pagination: page number. | [optional] 
**limit** | **Integer** | Pagination: maximum items per page. | [optional] 
**language** | **String** | Language selection for offer details. | [optional] 
**currency** | **String** | Currency in which prices should be provided. | [optional] 

