# SwaggerClient::EventOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **String** | Identifier for the company offering the rental. | [optional] 
**tenant_id** | **String** | Identifier for the tenant. | [optional] 
**category_id** | **String** | Identifier for the category of the offer. | [optional] 
**supplier_id** | **String** | Identifier for the supplier of the offer. | [optional] 
**offers** | [**Array&lt;EventOfferResponseItemSchema&gt;**](EventOfferResponseItemSchema.md) | Array of EventOfferResponseItemSchema detailing individual car offers. | [optional] 
**page** | [**BigDecimal**](BigDecimal.md) | Current page in pagination. | [optional] 
**limit** | [**BigDecimal**](BigDecimal.md) | Page size in pagination. | [optional] 
**total** | [**BigDecimal**](BigDecimal.md) | Total number of records available. | [optional] 

