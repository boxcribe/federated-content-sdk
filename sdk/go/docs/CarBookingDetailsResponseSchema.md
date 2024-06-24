# CarBookingDetailsResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **string** | Identifier for the company associated with the booking. | [optional] [default to null]
**TenantId** | **string** | Identifier for the tenant associated with the booking. | [optional] [default to null]
**CategoryId** | **string** | Identifier for the category of the booking. | [optional] [default to null]
**SupplierId** | **string** | Identifier for the supplier of the booking. | [optional] [default to null]
**BookingId** | **string** | Unique identifier for the booking. | [optional] [default to null]
**SupplierBookingId** | **string** | Supplier’s identifier for the booking. | [optional] [default to null]
**SupplierBookingReference** | **string** | Reference number provided by the supplier for the booking. | [optional] [default to null]
**CustomerReference** | **string** | Customer reference number associated with the booking. | [optional] [default to null]
**BookingReference** | **string** | Internal reference number for the booking. | [optional] [default to null]
**PaymentReference** | **string** | Reference number for the payment associated with the booking. | [optional] [default to null]
**BookingStatus** | **string** | Current status of the booking. | [optional] [default to null]
**BookingTax** | **float64** | Tax applied to the booking. | [optional] [default to null]
**BookingPrice** | **float64** | Total price of the booking. | [optional] [default to null]
**BookingCurrency** | **string** | Currency used for the booking pricing. | [optional] [default to null]
**BookingCancelationPolicies** | **string** | Cancellation policies applicable to the booking. | [optional] [default to null]
**Customer** | [***CarBookingCustomerSchema**](CarBookingCustomerSchema.md) |  | [optional] [default to null]
**OfferRequest** | [***CarOfferRequestSchema**](CarOfferRequestSchema.md) |  | [optional] [default to null]
**Offer** | [***CarOfferResponseItemSchema**](CarOfferResponseItemSchema.md) |  | [optional] [default to null]
**Success** | **bool** | Indicates if the booking was successful. | [optional] [default to null]
**ErrorMessage** | **string** | Provides details on any error that occurred during the booking process. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

