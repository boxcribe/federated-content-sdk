# DiningOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Unique identifier for the dining offer. |  [optional]
**supplierOfferId** | [**UUID**](UUID.md) | Identifier for the offer provided by the supplier. |  [optional]
**offerIndex** | [**BigDecimal**](BigDecimal.md) | Index of the offer for sorting and reference. |  [optional]
**offerTax** | [**BigDecimal**](BigDecimal.md) | Tax applied to the dining offer. |  [optional]
**offerPrice** | [**BigDecimal**](BigDecimal.md) | Price of the dining experience. |  [optional]
**offerCurrency** | **String** | Currency in which the offer is priced. |  [optional]
**offerCancellationPolicies** | **String** | Cancellation policies applicable to the dining offer. |  [optional]
**diningName** | **String** | Name of the dining establishment. |  [optional]
**diningDescription** | **String** | Description of the dining establishment and the dining experience. |  [optional]
**diningAddress** | **String** | Physical address of the dining establishment. |  [optional]
**diningLatitude** | **Float** | Latitude coordinate of the dining location. |  [optional]
**diningLongitude** | **Float** | Longitude coordinate of the dining location. |  [optional]
**diningDistance** | **Float** | Distance to the dining location from a reference point, if applicable. |  [optional]
**diningDistanceMetric** | **String** | Metric used to measure the distance (e.g., miles, kilometers). |  [optional]
**diningImages** | **List&lt;String&gt;** | Collection of images of the dining establishment and dishes. |  [optional]
**diningRating** | **Float** | Rating of the dining establishment based on customer reviews. |  [optional]
**diningReviews** | **List&lt;String&gt;** | Customer reviews for the dining establishment. |  [optional]
**diningSubcategories** | **List&lt;String&gt;** | List of subcategories the dining offer belongs to (e.g., Italian, Seafood, Fine Dining). |  [optional]
**diningHours** | **List&lt;String&gt;** | Operating hours of the dining establishment. |  [optional]
