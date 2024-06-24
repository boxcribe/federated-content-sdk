# HotelCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **string** | Unique identifier for the hotel offer. | [optional] [default to null]
**RoomId** | **string** | Identifier for the specific room being booked. | [optional] [default to null]
**RoomQty** | **int32** | Number of rooms of this type being booked. | [optional] [default to null]
**Customer** | [***HotelCreateBookingCustomerSchema**](HotelCreateBookingCustomerSchema.md) |  | [optional] [default to null]
**Payment** | [***HotelCreateBookingPaymentSchema**](HotelCreateBookingPaymentSchema.md) |  | [optional] [default to null]
**Currency** | **string** | Currency used for the booking. | [optional] [default to null]
**CustomerReference** | **string** | Customer reference identifier. | [optional] [default to null]
**BookingReference** | **string** | Booking reference identifier. | [optional] [default to null]
**PaymentReference** | **string** | Payment transaction reference. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

