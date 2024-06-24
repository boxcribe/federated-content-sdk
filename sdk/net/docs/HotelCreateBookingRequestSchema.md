# IO.Swagger.Model.HotelCreateBookingRequestSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **Guid?** | Unique identifier for the hotel offer. | [optional] 
**RoomId** | **Guid?** | Identifier for the specific room being booked. | [optional] 
**RoomQty** | **int?** | Number of rooms of this type being booked. | [optional] 
**Customer** | [**HotelCreateBookingCustomerSchema**](HotelCreateBookingCustomerSchema.md) |  | [optional] 
**Payment** | [**HotelCreateBookingPaymentSchema**](HotelCreateBookingPaymentSchema.md) |  | [optional] 
**Currency** | **string** | Currency used for the booking. | [optional] 
**CustomerReference** | **string** | Customer reference identifier. | [optional] 
**BookingReference** | **string** | Booking reference identifier. | [optional] 
**PaymentReference** | **string** | Payment transaction reference. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

