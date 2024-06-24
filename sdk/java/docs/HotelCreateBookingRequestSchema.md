# HotelCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Unique identifier for the hotel offer. |  [optional]
**roomId** | [**UUID**](UUID.md) | Identifier for the specific room being booked. |  [optional]
**roomQty** | **Integer** | Number of rooms of this type being booked. |  [optional]
**customer** | [**HotelCreateBookingCustomerSchema**](HotelCreateBookingCustomerSchema.md) |  |  [optional]
**payment** | [**HotelCreateBookingPaymentSchema**](HotelCreateBookingPaymentSchema.md) |  |  [optional]
**currency** | **String** | Currency used for the booking. |  [optional]
**customerReference** | **String** | Customer reference identifier. |  [optional]
**bookingReference** | **String** | Booking reference identifier. |  [optional]
**paymentReference** | **String** | Payment transaction reference. |  [optional]
