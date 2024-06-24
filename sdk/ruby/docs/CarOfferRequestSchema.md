# SwaggerClient::CarOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pickup_location_latitude** | **Float** | Latitude for car pickup location. | [optional] 
**pickup_location_longitude** | **Float** | Longitude for car pickup location. | [optional] 
**pickup_date** | **Date** | Scheduled date for car pickup. | [optional] 
**pickup_time** | **String** | Scheduled time for car pickup. | [optional] 
**dropoff_location_latitude** | **Float** | Latitude for car dropoff location. | [optional] 
**dropoff_location_longitude** | **Float** | Longitude for car dropoff location. | [optional] 
**dropoff_date** | **Date** | Scheduled date for car dropoff. | [optional] 
**dropoff_time** | **String** | Scheduled time for car dropoff. | [optional] 
**filter_by_keyword** | **String** | Keyword to filter car offers. | [optional] 
**filter_by_price_min** | [**BigDecimal**](BigDecimal.md) | Minimum price to filter car offers. | [optional] 
**filter_by_price_max** | [**BigDecimal**](BigDecimal.md) | Maximum price to filter car offers. | [optional] 
**filter_by_distance_min** | **Integer** | Minimum distance filter for car offers. | [optional] 
**filter_by_distance_max** | **Integer** | Maximum distance filter for car offers. | [optional] 
**filter_by_rating_min** | **Integer** | Minimum rating filter for car offers. | [optional] 
**filter_by_rating_max** | **Integer** | Maximum rating filter for car offers. | [optional] 
**filter_by_passengers_min** | **Integer** | Minimum passengers capacity filter for car offers. | [optional] 
**filter_by_passengers_max** | **Integer** | Maximum passengers capacity filter for car offers. | [optional] 
**filter_by_type** | **Array&lt;String&gt;** | Types of cars to filter by. | [optional] 
**filter_by_company** | **Array&lt;String&gt;** | Car rental companies to filter by. | [optional] 
**sort_by** | **String** | Field to sort car offers by. | [optional] 
**sort_order** | **String** | Order to sort car offers (asc, desc). | [optional] 
**page** | **Integer** | Page number for pagination. | [optional] 
**limit** | **Integer** | Number of offers per page. | [optional] 
**language** | **String** | Language for the offers. | [optional] 
**currency** | **String** | Currency for the offers. | [optional] 
**metric** | **String** | Distance metric (mi/km) used in filters. | [optional] 

