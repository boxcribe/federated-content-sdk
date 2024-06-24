# IO.Swagger.Model.DiningOfferResponseItemSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **Guid?** | Unique identifier for the dining offer. | [optional] 
**SupplierOfferId** | **Guid?** | Identifier for the offer provided by the supplier. | [optional] 
**OfferIndex** | [**decimal?**](BigDecimal.md) | Index of the offer for sorting and reference. | [optional] 
**OfferTax** | [**decimal?**](BigDecimal.md) | Tax applied to the dining offer. | [optional] 
**OfferPrice** | [**decimal?**](BigDecimal.md) | Price of the dining experience. | [optional] 
**OfferCurrency** | **string** | Currency in which the offer is priced. | [optional] 
**OfferCancellationPolicies** | **string** | Cancellation policies applicable to the dining offer. | [optional] 
**DiningName** | **string** | Name of the dining establishment. | [optional] 
**DiningDescription** | **string** | Description of the dining establishment and the dining experience. | [optional] 
**DiningAddress** | **string** | Physical address of the dining establishment. | [optional] 
**DiningLatitude** | **float?** | Latitude coordinate of the dining location. | [optional] 
**DiningLongitude** | **float?** | Longitude coordinate of the dining location. | [optional] 
**DiningDistance** | **float?** | Distance to the dining location from a reference point, if applicable. | [optional] 
**DiningDistanceMetric** | **string** | Metric used to measure the distance (e.g., miles, kilometers). | [optional] 
**DiningImages** | **List&lt;string&gt;** | Collection of images of the dining establishment and dishes. | [optional] 
**DiningRating** | **float?** | Rating of the dining establishment based on customer reviews. | [optional] 
**DiningReviews** | **List&lt;string&gt;** | Customer reviews for the dining establishment. | [optional] 
**DiningSubcategories** | **List&lt;string&gt;** | List of subcategories the dining offer belongs to (e.g., Italian, Seafood, Fine Dining). | [optional] 
**DiningHours** | **List&lt;string&gt;** | Operating hours of the dining establishment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

