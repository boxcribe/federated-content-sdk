# ToursAndActivitiesOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**locationLatitude** | **Float** | Latitude for the location. |  [optional]
**locationLongitude** | **Float** | Longitude for the location. |  [optional]
**locationRadius** | **Float** | Radius to search for tours and activities from the specified location. |  [optional]
**startDate** | [**LocalDate**](LocalDate.md) | Starting date for tours and activities. |  [optional]
**endDate** | [**LocalDate**](LocalDate.md) | Ending date for tours and activities. |  [optional]
**adults** | **Integer** | Number of adults participating. |  [optional]
**children** | **Integer** | Number of children participating. |  [optional]
**filterByKeyword** | **String** | Keyword to filter tours and activities. |  [optional]
**filterByPriceMin** | [**BigDecimal**](BigDecimal.md) | Minimum price filter. |  [optional]
**filterByPriceMax** | [**BigDecimal**](BigDecimal.md) | Maximum price filter. |  [optional]
**filterByDistanceMin** | **Integer** | Minimum distance filter. |  [optional]
**filterByDistanceMax** | **Integer** | Maximum distance filter. |  [optional]
**filterByRatingMin** | **Integer** | Minimum rating filter. |  [optional]
**filterByRatingMax** | **Integer** | Maximum rating filter. |  [optional]
**filterBySubcategories** | **List&lt;String&gt;** | Subcategories to filter tours and activities. |  [optional]
**sortBy** | **String** | Criteria to sort the search results. |  [optional]
**sortOrder** | **String** | Order to sort the results (ascending or descending). |  [optional]
**page** | **Integer** | Page number for pagination. |  [optional]
**limit** | **Integer** | Number of items per page. |  [optional]
**language** | **String** | Language of the tour offers. |  [optional]
**currency** | **String** | Currency in which prices are displayed. |  [optional]
**metric** | **String** | Unit for distance measurement (mi/km) used in filters. |  [optional]
