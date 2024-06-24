# TransportCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Unique identifier for the offer. |  [optional]
**customer** | [**TransportCreateBookingCustomerSchema**](TransportCreateBookingCustomerSchema.md) |  |  [optional]
**payment** | [**TransportCreateBookingPaymentSchema**](TransportCreateBookingPaymentSchema.md) |  |  [optional]
**currency** | **String** | Currency used for the booking. |  [optional]
**customerReference** | **String** | Customer reference identifier. |  [optional]
**bookingReference** | **String** | Booking reference identifier. |  [optional]
**paymentReference** | **String** | Payment transaction reference. |  [optional]
**bookingQuestions** | **List&lt;String&gt;** | Questions related to booking the transport. |  [optional]
