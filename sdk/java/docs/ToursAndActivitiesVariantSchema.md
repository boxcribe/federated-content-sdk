# ToursAndActivitiesVariantSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**variantId** | [**UUID**](UUID.md) | Unique identifier for the tour variant. |  [optional]
**supplierVariantId** | [**UUID**](UUID.md) | Identifier given by the supplier for the variant. |  [optional]
**variantIndex** | **Integer** | Index of the variant for ordering. |  [optional]
**variantTax** | [**BigDecimal**](BigDecimal.md) | Tax applied to the variant price. |  [optional]
**variantPrice** | [**BigDecimal**](BigDecimal.md) | Price of the tour variant. |  [optional]
**variantCurrency** | **String** | Currency of the variant price. |  [optional]
**variantCancellationPolicies** | **String** | Cancellation policies applicable to the tour variant. |  [optional]
**date** | [**LocalDate**](LocalDate.md) | Date of the tour. |  [optional]
**startTime** | **String** | Start time of the tour. |  [optional]
**adults** | **Integer** | Number of adults for the tour. |  [optional]
**children** | **Integer** | Number of children for the tour. |  [optional]
**variantName** | **String** | Name of the tour variant. |  [optional]
**variantDescription** | **String** | Description of the tour variant. |  [optional]
**variantAddress** | **String** | Address where the tour variant takes place. |  [optional]
**variantLatitude** | **Float** | Latitude coordinate of the tour location. |  [optional]
**variantLongitude** | **Float** | Longitude coordinate of the tour location. |  [optional]
**variantDistance** | [**BigDecimal**](BigDecimal.md) | Distance covered during the tour. |  [optional]
**variantDistanceMetric** | **String** | Metric used for distance measurement (miles or kilometers). |  [optional]
**variantImages** | **List&lt;String&gt;** | Array of images related to the tour variant. |  [optional]
**variantRating** | [**BigDecimal**](BigDecimal.md) | Rating of the tour variant. |  [optional]
**variantReviews** | **List&lt;String&gt;** | Collection of reviews for the tour variant. |  [optional]
**variantSubcategories** | **List&lt;String&gt;** | Subcategories of the tour variant. |  [optional]
**bookingQuestions** | **List&lt;String&gt;** | Questions related to booking the tour variant. |  [optional]
