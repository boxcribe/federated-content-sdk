# IO.Swagger.Model.ToursAndActivitiesBookingDetailsResponseSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **Guid?** | Identifier for the company associated with the booking. | [optional] 
**TenantId** | **Guid?** | Identifier for the tenant associated with the booking. | [optional] 
**CategoryId** | **Guid?** | Identifier for the category of the booking. | [optional] 
**SupplierId** | **Guid?** | Identifier for the supplier of the booking. | [optional] 
**BookingId** | **Guid?** | Unique identifier for the booking. | [optional] 
**SupplierBookingId** | **Guid?** | Supplier’s identifier for the booking. | [optional] 
**SupplierBookingReference** | **string** | Reference number provided by the supplier for the booking. | [optional] 
**CustomerReference** | **string** | Customer reference number associated with the booking. | [optional] 
**BookingReference** | **string** | Internal reference number for the booking. | [optional] 
**PaymentReference** | **string** | Reference number for the payment associated with the booking. | [optional] 
**BookingStatus** | **string** | Current status of the booking. | [optional] 
**BookingTax** | [**decimal?**](BigDecimal.md) | Tax applied to the booking. | [optional] 
**BookingPrice** | [**decimal?**](BigDecimal.md) | Total price of the booking. | [optional] 
**BookingCurrency** | **string** | Currency used for the booking pricing. | [optional] 
**BookingCancelationPolicies** | **string** | Cancellation policies applicable to the booking. | [optional] 
**Customer** | [**ToursAndActivitiesBookingCustomerSchema**](ToursAndActivitiesBookingCustomerSchema.md) |  | [optional] 
**OfferRequest** | [**ToursAndActivitiesOfferRequestSchema**](ToursAndActivitiesOfferRequestSchema.md) |  | [optional] 
**Offer** | [**ToursAndActivitiesOfferResponseItemSchema**](ToursAndActivitiesOfferResponseItemSchema.md) |  | [optional] 
**Variant** | [**ToursAndActivitiesVariantSchema**](ToursAndActivitiesVariantSchema.md) |  | [optional] 
**Success** | **bool?** | Indicates if the booking was successful. | [optional] 
**ErrorMessage** | **string** | Provides details on any error that occurred during the booking process. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

