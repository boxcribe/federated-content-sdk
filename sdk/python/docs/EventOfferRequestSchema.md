# EventOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**location_latitude** | **float** | Latitude for the event location. | [optional] 
**location_longitude** | **float** | Longitude for the event location. | [optional] 
**location_radius** | **float** | Radius to search for events around the location coordinates. | [optional] 
**start_date** | **date** | Start date for the event search. | [optional] 
**end_date** | **date** | End date for the event search. | [optional] 
**filter_by_keyword** | **str** | Keywords to filter the events. | [optional] 
**filter_by_price_min** | **float** | Minimum price to filter the events. | [optional] 
**filter_by_price_max** | **float** | Maximum price to filter the events. | [optional] 
**filter_by_distance_min** | **float** | Minimum distance to filter events. | [optional] 
**filter_by_distance_max** | **float** | Maximum distance to filter events. | [optional] 
**filter_by_rating_min** | **float** | Minimum rating to filter events. | [optional] 
**filter_by_rating_max** | **float** | Maximum rating to filter events. | [optional] 
**filter_by_performers** | **list[str]** | Filter events by specific performers. | [optional] 
**filter_by_subcategories** | **list[str]** | Filter events by specific subcategories. | [optional] 
**sort_by** | **str** | Field to sort events by. | [optional] 
**sort_order** | **str** | Order to sort events (asc, desc). | [optional] 
**page** | **float** | Page number for pagination. | [optional] 
**limit** | **float** | Number of events per page. | [optional] 
**language** | **str** | Language for the event offers. | [optional] 
**currency** | **str** | Currency for the event offers. | [optional] 
**metric** | **str** | Distance metric (mi/km) used in filters. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

