# SwaggerClient::ToursAndActivitiesOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**location_latitude** | **Float** | Latitude for the location. | [optional] 
**location_longitude** | **Float** | Longitude for the location. | [optional] 
**location_radius** | **Float** | Radius to search for tours and activities from the specified location. | [optional] 
**start_date** | **Date** | Starting date for tours and activities. | [optional] 
**end_date** | **Date** | Ending date for tours and activities. | [optional] 
**adults** | **Integer** | Number of adults participating. | [optional] 
**children** | **Integer** | Number of children participating. | [optional] 
**filter_by_keyword** | **String** | Keyword to filter tours and activities. | [optional] 
**filter_by_price_min** | [**BigDecimal**](BigDecimal.md) | Minimum price filter. | [optional] 
**filter_by_price_max** | [**BigDecimal**](BigDecimal.md) | Maximum price filter. | [optional] 
**filter_by_distance_min** | **Integer** | Minimum distance filter. | [optional] 
**filter_by_distance_max** | **Integer** | Maximum distance filter. | [optional] 
**filter_by_rating_min** | **Integer** | Minimum rating filter. | [optional] 
**filter_by_rating_max** | **Integer** | Maximum rating filter. | [optional] 
**filter_by_subcategories** | **Array&lt;String&gt;** | Subcategories to filter tours and activities. | [optional] 
**sort_by** | **String** | Criteria to sort the search results. | [optional] 
**sort_order** | **String** | Order to sort the results (ascending or descending). | [optional] 
**page** | **Integer** | Page number for pagination. | [optional] 
**limit** | **Integer** | Number of items per page. | [optional] 
**language** | **String** | Language of the tour offers. | [optional] 
**currency** | **String** | Currency in which prices are displayed. | [optional] 
**metric** | **String** | Unit for distance measurement (mi/km) used in filters. | [optional] 

