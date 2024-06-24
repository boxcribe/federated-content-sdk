# TransportCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **str** | Unique identifier for the offer. | [optional] 
**customer** | [**TransportCreateBookingCustomerSchema**](TransportCreateBookingCustomerSchema.md) |  | [optional] 
**payment** | [**TransportCreateBookingPaymentSchema**](TransportCreateBookingPaymentSchema.md) |  | [optional] 
**currency** | **str** | Currency used for the booking. | [optional] 
**customer_reference** | **str** | Customer reference identifier. | [optional] 
**booking_reference** | **str** | Booking reference identifier. | [optional] 
**payment_reference** | **str** | Payment transaction reference. | [optional] 
**booking_questions** | **list[str]** | Questions related to booking the transport. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

