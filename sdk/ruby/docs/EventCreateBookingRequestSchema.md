# SwaggerClient::EventCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **String** | Unique identifier for the offer. | [optional] 
**ticket_id** | **String** | Unique identifier for the ticket. | [optional] 
**ticket_qty** | [**BigDecimal**](BigDecimal.md) | Ticket quantity for ordering. | [optional] 
**customer** | [**EventCreateBookingCustomerSchema**](EventCreateBookingCustomerSchema.md) |  | [optional] 
**payment** | [**EventCreateBookingPaymentSchema**](EventCreateBookingPaymentSchema.md) |  | [optional] 
**currency** | **String** | Currency used for the booking. | [optional] 
**customer_reference** | **String** | Customer reference identifier. | [optional] 
**booking_reference** | **String** | Booking reference identifier. | [optional] 
**payment_reference** | **String** | Payment transaction reference. | [optional] 
**booking_questions** | **Array&lt;String&gt;** | Questions related to booking the tour variant. | [optional] 

