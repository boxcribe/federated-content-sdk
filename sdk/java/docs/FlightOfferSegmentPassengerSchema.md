# FlightOfferSegmentPassengerSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**passengerId** | [**UUID**](UUID.md) | Unique identifier for a passenger. |  [optional]
**cabin** | **String** | Class options: first, business, premium economy, economy. |  [optional]
**bags** | [**List&lt;FlightOfferSegmentPassengerSchemaBags&gt;**](FlightOfferSegmentPassengerSchemaBags.md) | Array of extra baggage, detailing type and qty. |  [optional]
**seatNumber** | **String** | Seat number assigned to the passenger, returned only on reprice with seat selection. |  [optional]
