# IO.Swagger.Model.EventOfferRequestSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationLatitude** | **float?** | Latitude for the event location. | [optional] 
**LocationLongitude** | **float?** | Longitude for the event location. | [optional] 
**LocationRadius** | **float?** | Radius to search for events around the location coordinates. | [optional] 
**StartDate** | **DateTime?** | Start date for the event search. | [optional] 
**EndDate** | **DateTime?** | End date for the event search. | [optional] 
**FilterByKeyword** | **string** | Keywords to filter the events. | [optional] 
**FilterByPriceMin** | [**decimal?**](BigDecimal.md) | Minimum price to filter the events. | [optional] 
**FilterByPriceMax** | [**decimal?**](BigDecimal.md) | Maximum price to filter the events. | [optional] 
**FilterByDistanceMin** | [**decimal?**](BigDecimal.md) | Minimum distance to filter events. | [optional] 
**FilterByDistanceMax** | [**decimal?**](BigDecimal.md) | Maximum distance to filter events. | [optional] 
**FilterByRatingMin** | [**decimal?**](BigDecimal.md) | Minimum rating to filter events. | [optional] 
**FilterByRatingMax** | [**decimal?**](BigDecimal.md) | Maximum rating to filter events. | [optional] 
**FilterByPerformers** | **List&lt;string&gt;** | Filter events by specific performers. | [optional] 
**FilterBySubcategories** | **List&lt;string&gt;** | Filter events by specific subcategories. | [optional] 
**SortBy** | **string** | Field to sort events by. | [optional] 
**SortOrder** | **string** | Order to sort events (asc, desc). | [optional] 
**Page** | [**decimal?**](BigDecimal.md) | Page number for pagination. | [optional] 
**Limit** | [**decimal?**](BigDecimal.md) | Number of events per page. | [optional] 
**Language** | **string** | Language for the event offers. | [optional] 
**Currency** | **string** | Currency for the event offers. | [optional] 
**Metric** | **string** | Distance metric (mi/km) used in filters. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

