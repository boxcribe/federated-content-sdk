# FlightOfferDetailsRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Unique identifier of the flight offer to be repriced. |  [optional]
**seats** | [**List&lt;OfferPassengerSelectedSeatSchema&gt;**](OfferPassengerSelectedSeatSchema.md) | Array of passenger seats, each defined in OfferPassengerSelectedSeatSchema. |  [optional]
**bags** | [**List&lt;OfferPassengerExtraBagSchema&gt;**](OfferPassengerExtraBagSchema.md) | Array of extra baggage, each defined in OfferPassengerExtraBagSchema. |  [optional]
