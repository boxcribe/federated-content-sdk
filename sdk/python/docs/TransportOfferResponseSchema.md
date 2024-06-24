# TransportOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **str** | Identifier of the company. | [optional] 
**tenant_id** | **str** | Identifier of the tenant. | [optional] 
**category_id** | **str** | Category identifier. | [optional] 
**supplier_id** | **str** | Supplier identifier. | [optional] 
**page** | **int** | Current page of the response. | [optional] 
**limit** | **int** | Limit of items per page in the response. | [optional] 
**total** | **int** | Total number of items available. | [optional] 
**offers** | [**list[TransportOfferResponseItemSchema]**](TransportOfferResponseItemSchema.md) | Array of TransportOfferResponseItemSchema detailing individual offers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

