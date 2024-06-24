# EventCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Unique identifier for the offer. |  [optional]
**ticketId** | [**UUID**](UUID.md) | Unique identifier for the ticket. |  [optional]
**ticketQty** | [**BigDecimal**](BigDecimal.md) | Ticket quantity for ordering. |  [optional]
**customer** | [**EventCreateBookingCustomerSchema**](EventCreateBookingCustomerSchema.md) |  |  [optional]
**payment** | [**EventCreateBookingPaymentSchema**](EventCreateBookingPaymentSchema.md) |  |  [optional]
**currency** | **String** | Currency used for the booking. |  [optional]
**customerReference** | **String** | Customer reference identifier. |  [optional]
**bookingReference** | **String** | Booking reference identifier. |  [optional]
**paymentReference** | **String** | Payment transaction reference. |  [optional]
**bookingQuestions** | **List&lt;String&gt;** | Questions related to booking the tour variant. |  [optional]
