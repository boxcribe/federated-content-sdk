# IO.Swagger.Model.EventOfferResponseItemSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **Guid?** | Unique identifier for the offer. | [optional] 
**SupplierOfferId** | **Guid?** | Unique identifier for the supplier’s offer. | [optional] 
**OfferIndex** | [**decimal?**](BigDecimal.md) | Index of the offer for sorting purposes. | [optional] 
**OfferTax** | [**decimal?**](BigDecimal.md) | Tax applied to the offer. | [optional] 
**OfferPrice** | [**decimal?**](BigDecimal.md) | Price of the offer. | [optional] 
**OfferCurrency** | **string** | Currency of the offer price. | [optional] 
**OfferCancelationPolicies** | **string** | Cancellation policies applicable to the offer. | [optional] 
**Date** | **DateTime?** | Date of the event. | [optional] 
**Adults** | [**decimal?**](BigDecimal.md) | Number of adults involved in the event. | [optional] 
**Children** | [**decimal?**](BigDecimal.md) | Number of children involved in the event. | [optional] 
**EventName** | **string** | Name of the event. | [optional] 
**EventDescription** | **string** | Description of the event. | [optional] 
**EventAddress** | **string** | Address where the event will take place. | [optional] 
**EventLatitude** | **float?** | Latitude of the event location. | [optional] 
**EventLongitude** | **float?** | Longitude of the event location. | [optional] 
**EventDistance** | [**decimal?**](BigDecimal.md) | Distance to the event from a reference point. | [optional] 
**EventDistanceMetric** | **string** | Metric used to measure the distance to the event. | [optional] 
**EventImages** | **List&lt;string&gt;** | Images of the event. | [optional] 
**EventRating** | [**decimal?**](BigDecimal.md) | Rating of the event. | [optional] 
**EventReviews** | **List&lt;string&gt;** | Reviews of the event. | [optional] 
**EventVenue** | **string** | Venue where the event will take place. | [optional] 
**EventVenueCapacity** | [**decimal?**](BigDecimal.md) | Capacity of the venue. | [optional] 
**EventPerformers** | **List&lt;string&gt;** | Performers at the event. | [optional] 
**EventSubcategories** | **List&lt;string&gt;** | Subcategories of the event. | [optional] 
**BookingQuestions** | **List&lt;string&gt;** | Questions related to booking the event. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

