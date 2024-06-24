# IO.Swagger.Model.ToursAndActivitiesOfferRequestSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationLatitude** | **float?** | Latitude for the location. | [optional] 
**LocationLongitude** | **float?** | Longitude for the location. | [optional] 
**LocationRadius** | **float?** | Radius to search for tours and activities from the specified location. | [optional] 
**StartDate** | **DateTime?** | Starting date for tours and activities. | [optional] 
**EndDate** | **DateTime?** | Ending date for tours and activities. | [optional] 
**Adults** | **int?** | Number of adults participating. | [optional] 
**Children** | **int?** | Number of children participating. | [optional] 
**FilterByKeyword** | **string** | Keyword to filter tours and activities. | [optional] 
**FilterByPriceMin** | [**decimal?**](BigDecimal.md) | Minimum price filter. | [optional] 
**FilterByPriceMax** | [**decimal?**](BigDecimal.md) | Maximum price filter. | [optional] 
**FilterByDistanceMin** | **int?** | Minimum distance filter. | [optional] 
**FilterByDistanceMax** | **int?** | Maximum distance filter. | [optional] 
**FilterByRatingMin** | **int?** | Minimum rating filter. | [optional] 
**FilterByRatingMax** | **int?** | Maximum rating filter. | [optional] 
**FilterBySubcategories** | **List&lt;string&gt;** | Subcategories to filter tours and activities. | [optional] 
**SortBy** | **string** | Criteria to sort the search results. | [optional] 
**SortOrder** | **string** | Order to sort the results (ascending or descending). | [optional] 
**Page** | **int?** | Page number for pagination. | [optional] 
**Limit** | **int?** | Number of items per page. | [optional] 
**Language** | **string** | Language of the tour offers. | [optional] 
**Currency** | **string** | Currency in which prices are displayed. | [optional] 
**Metric** | **string** | Unit for distance measurement (mi/km) used in filters. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

