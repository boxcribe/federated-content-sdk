# DiningOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**location_latitude** | **float** | Latitude for the event location. | [optional] 
**location_longitude** | **float** | Longitude for the event location. | [optional] 
**location_radius** | **float** | Radius to search for events around the location coordinates. | [optional] 
**date** | [**\DateTime**](\DateTime.md) | Date for the dining search. | [optional] 
**filter_by_keyword** | **string** | Keywords to filter the events. | [optional] 
**filter_by_price_min** | **float** | Minimum price to filter the events. | [optional] 
**filter_by_price_max** | **float** | Maximum price to filter the events. | [optional] 
**filter_by_distance_min** | **float** | Minimum distance to filter events. | [optional] 
**filter_by_distance_max** | **float** | Maximum distance to filter events. | [optional] 
**filter_by_rating_min** | **float** | Minimum rating to filter events. | [optional] 
**filter_by_rating_max** | **float** | Maximum rating to filter events. | [optional] 
**filter_by_subcategories** | **string[]** | Filter events by specific subcategories. | [optional] 
**sort_by** | **string** | Field to sort events by. | [optional] 
**sort_order** | **string** | Order to sort events (asc, desc). | [optional] 
**page** | **float** | Page number for pagination. | [optional] 
**limit** | **float** | Number of events per page. | [optional] 
**language** | **string** | Language for the event offers. | [optional] 
**currency** | **string** | Currency for the event offers. | [optional] 
**metric** | **string** | Distance metric (mi/km) used in filters. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

