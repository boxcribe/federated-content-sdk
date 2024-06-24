# DiningCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Unique identifier for the offer. |  [optional]
**availabilityId** | [**UUID**](UUID.md) | Unique identifier for the availability. |  [optional]
**customer** | [**DiningCreateBookingCustomerSchema**](DiningCreateBookingCustomerSchema.md) |  |  [optional]
**payment** | [**DiningCreateBookingPaymentSchema**](DiningCreateBookingPaymentSchema.md) |  |  [optional]
**currency** | **String** | Currency used for the booking. |  [optional]
**customerReference** | **String** | Customer reference identifier. |  [optional]
**bookingReference** | **String** | Booking reference identifier. |  [optional]
**paymentReference** | **String** | Payment transaction reference. |  [optional]
**bookingQuestions** | **List&lt;String&gt;** | Questions related to booking the tour variant. |  [optional]
