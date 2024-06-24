# CarCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Unique identifier for the offer. |  [optional]
**customer** | [**CarCreateBookingCustomerSchema**](CarCreateBookingCustomerSchema.md) |  |  [optional]
**payment** | [**CarCreateBookingPaymentSchema**](CarCreateBookingPaymentSchema.md) |  |  [optional]
**currency** | **String** | Currency used for the booking. |  [optional]
**customerReference** | **String** | Customer reference identifier. |  [optional]
**bookingReference** | **String** | Booking reference identifier. |  [optional]
**paymentReference** | **String** | Payment transaction reference. |  [optional]
