# DiningCreateBookingRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **string** | Unique identifier for the offer. | [optional] [default to null]
**AvailabilityId** | **string** | Unique identifier for the availability. | [optional] [default to null]
**Customer** | [***DiningCreateBookingCustomerSchema**](DiningCreateBookingCustomerSchema.md) |  | [optional] [default to null]
**Payment** | [***DiningCreateBookingPaymentSchema**](DiningCreateBookingPaymentSchema.md) |  | [optional] [default to null]
**Currency** | **string** | Currency used for the booking. | [optional] [default to null]
**CustomerReference** | **string** | Customer reference identifier. | [optional] [default to null]
**BookingReference** | **string** | Booking reference identifier. | [optional] [default to null]
**PaymentReference** | **string** | Payment transaction reference. | [optional] [default to null]
**BookingQuestions** | **[]string** | Questions related to booking the tour variant. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

