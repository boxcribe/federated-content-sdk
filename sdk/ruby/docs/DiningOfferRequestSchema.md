# SwaggerClient::DiningOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**location_latitude** | **Float** | Latitude for the event location. | [optional] 
**location_longitude** | **Float** | Longitude for the event location. | [optional] 
**location_radius** | **Float** | Radius to search for events around the location coordinates. | [optional] 
**date** | **Date** | Date for the dining search. | [optional] 
**filter_by_keyword** | **String** | Keywords to filter the events. | [optional] 
**filter_by_price_min** | [**BigDecimal**](BigDecimal.md) | Minimum price to filter the events. | [optional] 
**filter_by_price_max** | [**BigDecimal**](BigDecimal.md) | Maximum price to filter the events. | [optional] 
**filter_by_distance_min** | [**BigDecimal**](BigDecimal.md) | Minimum distance to filter events. | [optional] 
**filter_by_distance_max** | [**BigDecimal**](BigDecimal.md) | Maximum distance to filter events. | [optional] 
**filter_by_rating_min** | [**BigDecimal**](BigDecimal.md) | Minimum rating to filter events. | [optional] 
**filter_by_rating_max** | [**BigDecimal**](BigDecimal.md) | Maximum rating to filter events. | [optional] 
**filter_by_subcategories** | **Array&lt;String&gt;** | Filter events by specific subcategories. | [optional] 
**sort_by** | **String** | Field to sort events by. | [optional] 
**sort_order** | **String** | Order to sort events (asc, desc). | [optional] 
**page** | [**BigDecimal**](BigDecimal.md) | Page number for pagination. | [optional] 
**limit** | [**BigDecimal**](BigDecimal.md) | Number of events per page. | [optional] 
**language** | **String** | Language for the event offers. | [optional] 
**currency** | **String** | Currency for the event offers. | [optional] 
**metric** | **String** | Distance metric (mi/km) used in filters. | [optional] 

