# EventCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **string** | Unique identifier for the offer. | [optional] 
**ticket_id** | **string** | Unique identifier for the ticket. | [optional] 
**ticket_qty** | **float** | Ticket quantity for ordering. | [optional] 
**customer** | [**\Swagger\Client\Model\EventCreateBookingCustomerSchema**](EventCreateBookingCustomerSchema.md) |  | [optional] 
**payment** | [**\Swagger\Client\Model\EventCreateBookingPaymentSchema**](EventCreateBookingPaymentSchema.md) |  | [optional] 
**currency** | **string** | Currency used for the booking. | [optional] 
**customer_reference** | **string** | Customer reference identifier. | [optional] 
**booking_reference** | **string** | Booking reference identifier. | [optional] 
**payment_reference** | **string** | Payment transaction reference. | [optional] 
**booking_questions** | **string[]** | Questions related to booking the tour variant. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

