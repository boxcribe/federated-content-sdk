# SwaggerClient::HotelCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **String** | Unique identifier for the hotel offer. | [optional] 
**room_id** | **String** | Identifier for the specific room being booked. | [optional] 
**room_qty** | **Integer** | Number of rooms of this type being booked. | [optional] 
**customer** | [**HotelCreateBookingCustomerSchema**](HotelCreateBookingCustomerSchema.md) |  | [optional] 
**payment** | [**HotelCreateBookingPaymentSchema**](HotelCreateBookingPaymentSchema.md) |  | [optional] 
**currency** | **String** | Currency used for the booking. | [optional] 
**customer_reference** | **String** | Customer reference identifier. | [optional] 
**booking_reference** | **String** | Booking reference identifier. | [optional] 
**payment_reference** | **String** | Payment transaction reference. | [optional] 

