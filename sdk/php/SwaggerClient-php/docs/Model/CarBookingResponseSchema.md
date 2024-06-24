# CarBookingResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **string** | Identifier for the company associated with the booking. | [optional] 
**tenant_id** | **string** | Identifier for the tenant associated with the booking. | [optional] 
**category_id** | **string** | Identifier for the category of the booking. | [optional] 
**supplier_id** | **string** | Identifier for the supplier of the booking. | [optional] 
**booking_id** | **string** | Unique identifier for the booking. | [optional] 
**supplier_booking_id** | **string** | Supplier’s identifier for the booking. | [optional] 
**supplier_booking_reference** | **string** | Reference number provided by the supplier for the booking. | [optional] 
**customer_reference** | **string** | Customer reference number associated with the booking. | [optional] 
**booking_reference** | **string** | Internal reference number for the booking. | [optional] 
**payment_reference** | **string** | Reference number for the payment associated with the booking. | [optional] 
**booking_status** | **string** | Current status of the booking. | [optional] 
**booking_tax** | **float** | Tax applied to the booking. | [optional] 
**booking_price** | **float** | Total price of the booking. | [optional] 
**booking_currency** | **string** | Currency used for the booking pricing. | [optional] 
**booking_cancelation_policies** | **string** | Cancellation policies applicable to the booking. | [optional] 
**customer** | [**\Swagger\Client\Model\CarBookingCustomerSchema**](CarBookingCustomerSchema.md) |  | [optional] 
**offer_request** | [**\Swagger\Client\Model\CarOfferRequestSchema**](CarOfferRequestSchema.md) |  | [optional] 
**offer** | [**\Swagger\Client\Model\CarOfferResponseItemSchema**](CarOfferResponseItemSchema.md) |  | [optional] 
**success** | **bool** | Indicates if the booking was successful. | [optional] 
**error_message** | **string** | Provides details on any error that occurred during the booking process. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

