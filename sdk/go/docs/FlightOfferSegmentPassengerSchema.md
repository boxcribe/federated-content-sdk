# FlightOfferSegmentPassengerSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PassengerId** | **string** | Unique identifier for a passenger. | [optional] [default to null]
**Cabin** | **string** | Class options: first, business, premium economy, economy. | [optional] [default to null]
**Bags** | [**[]FlightOfferSegmentPassengerSchemaBags**](FlightOfferSegmentPassengerSchema_bags.md) | Array of extra baggage, detailing type and qty. | [optional] [default to null]
**SeatNumber** | **string** | Seat number assigned to the passenger, returned only on reprice with seat selection. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

