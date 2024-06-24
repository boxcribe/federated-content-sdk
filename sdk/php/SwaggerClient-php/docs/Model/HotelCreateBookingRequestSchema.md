# HotelCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **string** | Unique identifier for the hotel offer. | [optional] 
**room_id** | **string** | Identifier for the specific room being booked. | [optional] 
**room_qty** | **int** | Number of rooms of this type being booked. | [optional] 
**customer** | [**\Swagger\Client\Model\HotelCreateBookingCustomerSchema**](HotelCreateBookingCustomerSchema.md) |  | [optional] 
**payment** | [**\Swagger\Client\Model\HotelCreateBookingPaymentSchema**](HotelCreateBookingPaymentSchema.md) |  | [optional] 
**currency** | **string** | Currency used for the booking. | [optional] 
**customer_reference** | **string** | Customer reference identifier. | [optional] 
**booking_reference** | **string** | Booking reference identifier. | [optional] 
**payment_reference** | **string** | Payment transaction reference. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

