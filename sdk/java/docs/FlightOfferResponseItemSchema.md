# FlightOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Unique identifier for the offer. |  [optional]
**supplierOfferId** | [**UUID**](UUID.md) | Unique identifier for the supplier’s offer. |  [optional]
**offerIndex** | **Integer** | Index of the offer for sorting purposes. |  [optional]
**offerPrice** | **Double** | Price of the offer. |  [optional]
**offerCurrency** | **String** | Currency of the offer price. |  [optional]
**offerCancelationPolicies** | **Map&lt;String, Object&gt;** | Cancellation policies applicable to the offer. |  [optional]
**offerAirlineName** | **String** | Name of the airline providing the offer. |  [optional]
**offerAirlineCode** | **String** | Code of the airline providing the offer. |  [optional]
**offerAirlineLogo** | **String** | Logo URL of the airline. |  [optional]
**legs** | [**List&lt;FlightLegOfferRequestSchema&gt;**](FlightLegOfferRequestSchema.md) | Array of flight legs, each described in FlightLegOfferRequestSchema. |  [optional]
**passengers** | [**List&lt;FlightPassengerOfferRequestSchema&gt;**](FlightPassengerOfferRequestSchema.md) | Array of passengers, each described in FlightPassengerOfferRequestSchema. |  [optional]
**privateFareCodes** | **List&lt;String&gt;** | Array of codes for accessing special negotiated fares. |  [optional]
