# FlightCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Identifier of the offer for which booking is initiated. |  [optional]
**passengers** | [**List&lt;FlightBookingPassengerSchema&gt;**](FlightBookingPassengerSchema.md) | Array of FlightBookingPassengerSchema detailing passenger information. |  [optional]
**customer** | [**FlightCreateBookingCustomerSchema**](FlightCreateBookingCustomerSchema.md) |  |  [optional]
**payment** | [**FlightCreateBookingPaymentSchema**](FlightCreateBookingPaymentSchema.md) |  |  [optional]
