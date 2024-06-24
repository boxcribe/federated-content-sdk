# ToursAndActivitiesOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**location_latitude** | **float** | Latitude for the location. | [optional] 
**location_longitude** | **float** | Longitude for the location. | [optional] 
**location_radius** | **float** | Radius to search for tours and activities from the specified location. | [optional] 
**start_date** | [**\DateTime**](\DateTime.md) | Starting date for tours and activities. | [optional] 
**end_date** | [**\DateTime**](\DateTime.md) | Ending date for tours and activities. | [optional] 
**adults** | **int** | Number of adults participating. | [optional] 
**children** | **int** | Number of children participating. | [optional] 
**filter_by_keyword** | **string** | Keyword to filter tours and activities. | [optional] 
**filter_by_price_min** | **float** | Minimum price filter. | [optional] 
**filter_by_price_max** | **float** | Maximum price filter. | [optional] 
**filter_by_distance_min** | **int** | Minimum distance filter. | [optional] 
**filter_by_distance_max** | **int** | Maximum distance filter. | [optional] 
**filter_by_rating_min** | **int** | Minimum rating filter. | [optional] 
**filter_by_rating_max** | **int** | Maximum rating filter. | [optional] 
**filter_by_subcategories** | **string[]** | Subcategories to filter tours and activities. | [optional] 
**sort_by** | **string** | Criteria to sort the search results. | [optional] 
**sort_order** | **string** | Order to sort the results (ascending or descending). | [optional] 
**page** | **int** | Page number for pagination. | [optional] 
**limit** | **int** | Number of items per page. | [optional] 
**language** | **string** | Language of the tour offers. | [optional] 
**currency** | **string** | Currency in which prices are displayed. | [optional] 
**metric** | **string** | Unit for distance measurement (mi/km) used in filters. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

