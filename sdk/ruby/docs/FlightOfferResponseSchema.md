# SwaggerClient::FlightOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **String** | Identifier for the company making the offer. | [optional] 
**tenant_id** | **String** | Identifier for the tenant. | [optional] 
**category_id** | **String** | Identifier for the category of the offer. | [optional] 
**supplier_id** | **String** | Identifier for the supplier of the offer. | [optional] 
**offer_tax** | [**BigDecimal**](BigDecimal.md) | Tax applied to the offer. | [optional] 
**offers** | [**Array&lt;FlightOfferResponseItemSchema&gt;**](FlightOfferResponseItemSchema.md) | Array of FlightOfferResponseItemSchema detailing individual offers. | [optional] 
**page** | **Integer** | Current page in pagination. | [optional] 
**limit** | **Integer** | Page size in pagination. | [optional] 
**total** | **Integer** | Total number of records available. | [optional] 

