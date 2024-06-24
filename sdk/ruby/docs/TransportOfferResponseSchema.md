# SwaggerClient::TransportOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **String** | Identifier of the company. | [optional] 
**tenant_id** | **String** | Identifier of the tenant. | [optional] 
**category_id** | **String** | Category identifier. | [optional] 
**supplier_id** | **String** | Supplier identifier. | [optional] 
**page** | **Integer** | Current page of the response. | [optional] 
**limit** | **Integer** | Limit of items per page in the response. | [optional] 
**total** | **Integer** | Total number of items available. | [optional] 
**offers** | [**Array&lt;TransportOfferResponseItemSchema&gt;**](TransportOfferResponseItemSchema.md) | Array of TransportOfferResponseItemSchema detailing individual offers. | [optional] 

