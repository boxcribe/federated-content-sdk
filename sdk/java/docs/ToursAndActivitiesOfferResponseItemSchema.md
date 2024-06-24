# ToursAndActivitiesOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Identifier of the individual offer. |  [optional]
**supplierOfferId** | [**UUID**](UUID.md) | Identifier provided by the supplier for the offer. |  [optional]
**offerIndex** | **Integer** | Index of the offer for ordering. |  [optional]
**offerTax** | [**BigDecimal**](BigDecimal.md) | Tax applied on the offer. |  [optional]
**offerPrice** | [**BigDecimal**](BigDecimal.md) | Price of the offer. |  [optional]
**offerCurrency** | **String** | Currency of the offer price. |  [optional]
**offerCancelationPolicies** | **String** | Cancellation policies applicable to the offer. |  [optional]
**date** | [**LocalDate**](LocalDate.md) | Date of the tour. |  [optional]
**adults** | **Integer** | Number of adults attending. |  [optional]
**children** | **Integer** | Number of children attending. |  [optional]
**tourName** | **String** | Name of the tour. |  [optional]
**tourDescription** | **String** | Description of the tour. |  [optional]
**tourAddress** | **String** | Address where the tour will take place. |  [optional]
**tourLatitude** | **Float** | Latitude for the tour location. |  [optional]
**tourLongitude** | **Float** | Longitude for the tour location. |  [optional]
**tourDistance** | **Float** | Distance covered by the tour. |  [optional]
**tourDistanceMetric** | **String** | Metric for measuring distance (miles or kilometers). |  [optional]
**tourImages** | **List&lt;String&gt;** | Array of images related to the tour. |  [optional]
**tourRating** | **Float** | Rating of the tour. |  [optional]
**tourReviews** | **List&lt;String&gt;** | Array of reviews for the tour. |  [optional]
**tourSubcategories** | **List&lt;String&gt;** | Subcategories of the tour. |  [optional]
**bookingQuestions** | **List&lt;String&gt;** | Questions related to booking the tour. |  [optional]
