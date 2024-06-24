# DiningCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **str** | Unique identifier for the offer. | [optional] 
**availability_id** | **str** | Unique identifier for the availability. | [optional] 
**customer** | [**DiningCreateBookingCustomerSchema**](DiningCreateBookingCustomerSchema.md) |  | [optional] 
**payment** | [**DiningCreateBookingPaymentSchema**](DiningCreateBookingPaymentSchema.md) |  | [optional] 
**currency** | **str** | Currency used for the booking. | [optional] 
**customer_reference** | **str** | Customer reference identifier. | [optional] 
**booking_reference** | **str** | Booking reference identifier. | [optional] 
**payment_reference** | **str** | Payment transaction reference. | [optional] 
**booking_questions** | **list[str]** | Questions related to booking the tour variant. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

