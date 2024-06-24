# FlightOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **string** | Unique identifier for the offer. | [optional] [default to null]
**SupplierOfferId** | **string** | Unique identifier for the supplier’s offer. | [optional] [default to null]
**OfferIndex** | **int32** | Index of the offer for sorting purposes. | [optional] [default to null]
**OfferPrice** | **float64** | Price of the offer. | [optional] [default to null]
**OfferCurrency** | **string** | Currency of the offer price. | [optional] [default to null]
**OfferCancelationPolicies** | [**ModelMap**](interface{}.md) | Cancellation policies applicable to the offer. | [optional] [default to null]
**OfferAirlineName** | **string** | Name of the airline providing the offer. | [optional] [default to null]
**OfferAirlineCode** | **string** | Code of the airline providing the offer. | [optional] [default to null]
**OfferAirlineLogo** | **string** | Logo URL of the airline. | [optional] [default to null]
**Legs** | [**[]FlightLegOfferRequestSchema**](FlightLegOfferRequestSchema.md) | Array of flight legs, each described in FlightLegOfferRequestSchema. | [optional] [default to null]
**Passengers** | [**[]FlightPassengerOfferRequestSchema**](FlightPassengerOfferRequestSchema.md) | Array of passengers, each described in FlightPassengerOfferRequestSchema. | [optional] [default to null]
**PrivateFareCodes** | **[]string** | Array of codes for accessing special negotiated fares. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

