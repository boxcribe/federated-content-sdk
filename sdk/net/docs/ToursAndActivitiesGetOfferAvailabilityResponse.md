# IO.Swagger.Model.ToursAndActivitiesGetOfferAvailabilityResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **Guid?** | Identifier of the individual offer. | [optional] 
**SupplierOfferId** | **Guid?** | Identifier provided by the supplier for the offer. | [optional] 
**OfferIndex** | **int?** | Index of the offer for ordering. | [optional] 
**OfferTax** | [**decimal?**](BigDecimal.md) | Tax applied on the offer. | [optional] 
**OfferPrice** | [**decimal?**](BigDecimal.md) | Price of the offer. | [optional] 
**OfferCurrency** | **string** | Currency of the offer price. | [optional] 
**OfferCancelationPolicies** | **string** | Cancellation policies applicable to the offer. | [optional] 
**Date** | **DateTime?** | Date of the tour. | [optional] 
**Adults** | **int?** | Number of adults attending. | [optional] 
**Children** | **int?** | Number of children attending. | [optional] 
**TourName** | **string** | Name of the tour. | [optional] 
**TourDescription** | **string** | Description of the tour. | [optional] 
**TourAddress** | **string** | Address where the tour will take place. | [optional] 
**TourLatitude** | **float?** | Latitude for the tour location. | [optional] 
**TourLongitude** | **float?** | Longitude for the tour location. | [optional] 
**TourDistance** | **float?** | Distance covered by the tour. | [optional] 
**TourDistanceMetric** | **string** | Metric for measuring distance (miles or kilometers). | [optional] 
**TourImages** | **List&lt;string&gt;** | Array of images related to the tour. | [optional] 
**TourRating** | **float?** | Rating of the tour. | [optional] 
**TourReviews** | **List&lt;string&gt;** | Array of reviews for the tour. | [optional] 
**TourSubcategories** | **List&lt;string&gt;** | Subcategories of the tour. | [optional] 
**BookingQuestions** | **List&lt;string&gt;** | Questions related to booking the tour. | [optional] 
**Variants** | [**List&lt;ToursAndActivitiesVariantSchema&gt;**](ToursAndActivitiesVariantSchema.md) | Array of ToursAndActivitiesVariantSchema. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

