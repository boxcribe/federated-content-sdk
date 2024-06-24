# CarCancelBookingResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**companyId** | [**UUID**](UUID.md) | Identifier for the company associated with the booking. |  [optional]
**tenantId** | [**UUID**](UUID.md) | Identifier for the tenant associated with the booking. |  [optional]
**categoryId** | [**UUID**](UUID.md) | Identifier for the category of the booking. |  [optional]
**supplierId** | [**UUID**](UUID.md) | Identifier for the supplier of the booking. |  [optional]
**bookingId** | [**UUID**](UUID.md) | Unique identifier for the booking. |  [optional]
**supplierBookingId** | [**UUID**](UUID.md) | Supplier’s identifier for the booking. |  [optional]
**supplierBookingReference** | **String** | Reference number provided by the supplier for the booking. |  [optional]
**customerReference** | **String** | Customer reference number associated with the booking. |  [optional]
**bookingReference** | **String** | Internal reference number for the booking. |  [optional]
**paymentReference** | **String** | Reference number for the payment associated with the booking. |  [optional]
**bookingStatus** | **String** | Current status of the booking. |  [optional]
**bookingTax** | [**BigDecimal**](BigDecimal.md) | Tax applied to the booking. |  [optional]
**bookingPrice** | [**BigDecimal**](BigDecimal.md) | Total price of the booking. |  [optional]
**bookingCurrency** | **String** | Currency used for the booking pricing. |  [optional]
**bookingCancelationPolicies** | **String** | Cancellation policies applicable to the booking. |  [optional]
**customer** | [**CarBookingCustomerSchema**](CarBookingCustomerSchema.md) |  |  [optional]
**offerRequest** | [**CarOfferRequestSchema**](CarOfferRequestSchema.md) |  |  [optional]
**offer** | [**CarOfferResponseItemSchema**](CarOfferResponseItemSchema.md) |  |  [optional]
**success** | **Boolean** | Indicates if the booking was successful. |  [optional]
**errorMessage** | **String** | Provides details on any error that occurred during the booking process. |  [optional]
