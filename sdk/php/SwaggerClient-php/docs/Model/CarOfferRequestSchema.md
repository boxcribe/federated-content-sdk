# CarOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**pickup_location_latitude** | **float** | Latitude for car pickup location. | [optional] 
**pickup_location_longitude** | **float** | Longitude for car pickup location. | [optional] 
**pickup_date** | [**\DateTime**](\DateTime.md) | Scheduled date for car pickup. | [optional] 
**pickup_time** | **string** | Scheduled time for car pickup. | [optional] 
**dropoff_location_latitude** | **float** | Latitude for car dropoff location. | [optional] 
**dropoff_location_longitude** | **float** | Longitude for car dropoff location. | [optional] 
**dropoff_date** | [**\DateTime**](\DateTime.md) | Scheduled date for car dropoff. | [optional] 
**dropoff_time** | **string** | Scheduled time for car dropoff. | [optional] 
**filter_by_keyword** | **string** | Keyword to filter car offers. | [optional] 
**filter_by_price_min** | **float** | Minimum price to filter car offers. | [optional] 
**filter_by_price_max** | **float** | Maximum price to filter car offers. | [optional] 
**filter_by_distance_min** | **int** | Minimum distance filter for car offers. | [optional] 
**filter_by_distance_max** | **int** | Maximum distance filter for car offers. | [optional] 
**filter_by_rating_min** | **int** | Minimum rating filter for car offers. | [optional] 
**filter_by_rating_max** | **int** | Maximum rating filter for car offers. | [optional] 
**filter_by_passengers_min** | **int** | Minimum passengers capacity filter for car offers. | [optional] 
**filter_by_passengers_max** | **int** | Maximum passengers capacity filter for car offers. | [optional] 
**filter_by_type** | **string[]** | Types of cars to filter by. | [optional] 
**filter_by_company** | **string[]** | Car rental companies to filter by. | [optional] 
**sort_by** | **string** | Field to sort car offers by. | [optional] 
**sort_order** | **string** | Order to sort car offers (asc, desc). | [optional] 
**page** | **int** | Page number for pagination. | [optional] 
**limit** | **int** | Number of offers per page. | [optional] 
**language** | **string** | Language for the offers. | [optional] 
**currency** | **string** | Currency for the offers. | [optional] 
**metric** | **string** | Distance metric (mi/km) used in filters. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

