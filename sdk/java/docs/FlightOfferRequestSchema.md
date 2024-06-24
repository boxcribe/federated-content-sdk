# FlightOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cabin** | [**List**](List.md) | Class options: first, business, premium economy, economy. |  [optional]
**legs** | [**List**](List.md) | Array of flight legs, each described in FlightLegOfferRequestSchema. |  [optional]
**passengers** | [**List**](List.md) | Array of passengers, each described in FlightPassengerOfferRequestSchema. |  [optional]
**privateFareCodes** | [**List**](List.md) | Array of codes for accessing special negotiated fares. |  [optional]
**filterByKeyword** | **String** | Keyword to filter offers. |  [optional]
**filterByPriceMin** | **Float** | Minimum price filter. |  [optional]
**filterByPriceMax** | **Float** | Maximum price filter. |  [optional]
**filterByDurationMin** | **Integer** | Minimum flight duration filter. |  [optional]
**filterByDurationMax** | **Integer** | Maximum flight duration filter. |  [optional]
**filterByDepartureTimeMin** | **String** | Earliest departure time filter. |  [optional]
**filterByDepartureTimeMax** | **String** | Latest departure time filter. |  [optional]
**filterByArrivalTimeMin** | **String** | Earliest arrival time filter. |  [optional]
**filterByArrivalTimeMax** | **String** | Latest arrival time filter. |  [optional]
**filterByStopsMin** | **Integer** | Minimum number of stops filter. |  [optional]
**filterByStopsMax** | **Integer** | Maximum number of stops filter. |  [optional]
**filterByAirlines** | [**List**](List.md) | List of airline filters. |  [optional]
**filterByAirports** | [**List**](List.md) | List of airport filters. |  [optional]
**sortBy** | **String** | Sorting criteria. |  [optional]
**sortOrder** | **String** | Sorting order, asc or desc. |  [optional]
**page** | **Integer** | Pagination: page number. |  [optional]
**limit** | **Integer** | Pagination: maximum items per page. |  [optional]
**language** | **String** | Language selection for offer details. |  [optional]
**currency** | **String** | Currency in which prices should be provided. |  [optional]
