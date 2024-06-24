# IO.Swagger.Model.ToursAndActivitiesCreateBookingRequestSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **Guid?** | Unique identifier for the offer. | [optional] 
**VariantId** | **Guid?** | Unique identifier for the variant. | [optional] 
**Customer** | [**ToursAndActivitiesCreateBookingCustomerSchema**](ToursAndActivitiesCreateBookingCustomerSchema.md) |  | [optional] 
**Payment** | [**ToursAndActivitiesCreateBookingPaymentSchema**](ToursAndActivitiesCreateBookingPaymentSchema.md) |  | [optional] 
**Currency** | **string** | Currency used for the booking. | [optional] 
**CustomerReference** | **string** | Customer reference identifier. | [optional] 
**BookingReference** | **string** | Booking reference identifier. | [optional] 
**PaymentReference** | **string** | Payment transaction reference. | [optional] 
**BookingQuestions** | **List&lt;string&gt;** | Questions related to booking the tour variant. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

