# HotelOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **string** | Unique identifier for the hotel offer. | [optional] [default to null]
**SupplierOfferId** | **string** | Unique identifier given by the supplier for the hotel offer. | [optional] [default to null]
**OfferIndex** | **int32** | Index number of the offer for sorting and referencing purposes. | [optional] [default to null]
**OfferTax** | **float64** | Applicable tax amount for the offer. | [optional] [default to null]
**OfferPrice** | **float64** | Total price of the hotel offer. | [optional] [default to null]
**OfferCurrency** | **string** | Currency in which the offer price is denominated. | [optional] [default to null]
**OfferCancellationPolicies** | [***interface{}**](interface{}.md) | Details of the cancellation policies applicable to the offer. | [optional] [default to null]
**CheckinDate** | **string** | Scheduled check-in date for the hotel stay. | [optional] [default to null]
**CheckoutDate** | **string** | Scheduled check-out date for the hotel stay. | [optional] [default to null]
**HotelName** | **string** | Name of the hotel. | [optional] [default to null]
**HotelDescription** | **string** | Description of the hotel. | [optional] [default to null]
**HotelAddress** | **string** | Physical address of the hotel. | [optional] [default to null]
**HotelLatitude** | **float32** | Geographic latitude of the hotel. | [optional] [default to null]
**HotelLongitude** | **float32** | Geographic longitude of the hotel. | [optional] [default to null]
**HotelDistance** | **float64** | Distance of the hotel from a central point of interest, if applicable. | [optional] [default to null]
**HotelDistanceMetric** | **string** | Unit of measurement for the distance (e.g., km, miles). | [optional] [default to null]
**HotelImages** | **[]string** | Array of images associated with the hotel. | [optional] [default to null]
**HotelRating** | **float32** | Overall rating of the hotel. | [optional] [default to null]
**HotelReviews** | [**ModelMap**](interface{}.md) | Collection of reviews for the hotel. | [optional] [default to null]
**HotelStars** | **int32** | Star rating of the hotel. | [optional] [default to null]
**HotelCheckinTime** | **string** | Standard check-in time at the hotel. | [optional] [default to null]
**HotelCheckoutTime** | **string** | Standard check-out time at the hotel. | [optional] [default to null]
**HotelFacilities** | **[]string** | List of facilities available at the hotel. | [optional] [default to null]
**HotelAmenities** | **[]string** | List of amenities offered by the hotel. | [optional] [default to null]
**HotelPolicies** | **[]string** | General policies of the hotel. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

