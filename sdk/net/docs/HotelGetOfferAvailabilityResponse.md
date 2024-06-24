# IO.Swagger.Model.HotelGetOfferAvailabilityResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **Guid?** | Unique identifier for the hotel offer. | [optional] 
**SupplierOfferId** | **Guid?** | Unique identifier given by the supplier for the hotel offer. | [optional] 
**OfferIndex** | **int?** | Index number of the offer for sorting and referencing purposes. | [optional] 
**OfferTax** | **double?** | Applicable tax amount for the offer. | [optional] 
**OfferPrice** | **double?** | Total price of the hotel offer. | [optional] 
**OfferCurrency** | **string** | Currency in which the offer price is denominated. | [optional] 
**OfferCancelationPolicies** | **Dictionary&lt;string, Object&gt;** | Details of the cancellation policies applicable to the offer. | [optional] 
**CheckinDate** | **DateTime?** | Scheduled check-in date for the hotel stay. | [optional] 
**CheckoutDate** | **DateTime?** | Scheduled check-out date for the hotel stay. | [optional] 
**HotelName** | **string** | Name of the hotel. | [optional] 
**HotelDescription** | **string** | Description of the hotel. | [optional] 
**HotelAddress** | **string** | Physical address of the hotel. | [optional] 
**HotelLatitude** | **float?** | Geographic latitude of the hotel. | [optional] 
**HotelLongitude** | **float?** | Geographic longitude of the hotel. | [optional] 
**HotelDistance** | **double?** | Distance of the hotel from a central point of interest, if applicable. | [optional] 
**HotelDistanceMetric** | **string** | Unit of measurement for the distance (e.g., km, miles). | [optional] 
**HotelImages** | **List&lt;string&gt;** | Array of images associated with the hotel. | [optional] 
**HotelRating** | **float?** | Overall rating of the hotel. | [optional] 
**HotelReviews** | **Dictionary&lt;string, Object&gt;** | Collection of reviews for the hotel. | [optional] 
**HotelStars** | **int?** | Star rating of the hotel. | [optional] 
**HotelCheckinTime** | **string** | Standard check-in time at the hotel. | [optional] 
**HotelCheckoutTime** | **string** | Standard check-out time at the hotel. | [optional] 
**HotelFacilities** | **List&lt;string&gt;** | List of facilities available at the hotel. | [optional] 
**HotelAmenities** | **List&lt;string&gt;** | List of amenities offered by the hotel. | [optional] 
**HotelPolicies** | **List&lt;string&gt;** | General policies of the hotel. | [optional] 
**Rooms** | [**List&lt;HotelRoomSchema&gt;**](HotelRoomSchema.md) | Array of HotelRoomSchema. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

