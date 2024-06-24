# HotelCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **str** | Unique identifier for the hotel offer. | [optional] 
**room_id** | **str** | Identifier for the specific room being booked. | [optional] 
**room_qty** | **int** | Number of rooms of this type being booked. | [optional] 
**customer** | [**HotelCreateBookingCustomerSchema**](HotelCreateBookingCustomerSchema.md) |  | [optional] 
**payment** | [**HotelCreateBookingPaymentSchema**](HotelCreateBookingPaymentSchema.md) |  | [optional] 
**currency** | **str** | Currency used for the booking. | [optional] 
**customer_reference** | **str** | Customer reference identifier. | [optional] 
**booking_reference** | **str** | Booking reference identifier. | [optional] 
**payment_reference** | **str** | Payment transaction reference. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

