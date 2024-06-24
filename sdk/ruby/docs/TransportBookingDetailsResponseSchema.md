# SwaggerClient::TransportBookingDetailsResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **String** | Identifier for the company associated with the booking. | [optional] 
**tenant_id** | **String** | Identifier for the tenant associated with the booking. | [optional] 
**category_id** | **String** | Identifier for the category of the booking. | [optional] 
**supplier_id** | **String** | Identifier for the supplier of the booking. | [optional] 
**booking_id** | **String** | Unique identifier for the booking. | [optional] 
**supplier_booking_id** | **String** | Supplier’s identifier for the booking. | [optional] 
**supplier_booking_reference** | **String** | Reference number provided by the supplier for the booking. | [optional] 
**customer_reference** | **String** | Customer reference number associated with the booking. | [optional] 
**booking_reference** | **String** | Internal reference number for the booking. | [optional] 
**payment_reference** | **String** | Reference number for the payment associated with the booking. | [optional] 
**booking_status** | **String** | Current status of the booking. | [optional] 
**booking_tax** | [**BigDecimal**](BigDecimal.md) | Tax applied to the booking. | [optional] 
**booking_price** | [**BigDecimal**](BigDecimal.md) | Total price of the booking. | [optional] 
**booking_currency** | **String** | Currency used for the booking pricing. | [optional] 
**booking_cancelation_policies** | **String** | Cancellation policies applicable to the booking. | [optional] 
**customer** | [**TransportBookingCustomerSchema**](TransportBookingCustomerSchema.md) |  | [optional] 
**offer_request** | [**TransportOfferRequestSchema**](TransportOfferRequestSchema.md) |  | [optional] 
**offer** | [**TransportOfferResponseItemSchema**](TransportOfferResponseItemSchema.md) |  | [optional] 
**success** | **BOOLEAN** | Indicates if the booking was successful. | [optional] 
**error_message** | **String** | Provides details on any error that occurred during the booking process. | [optional] 

