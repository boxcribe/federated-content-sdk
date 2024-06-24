# IO.Swagger.Model.TransportOfferResponseSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **Guid?** | Identifier of the company. | [optional] 
**TenantId** | **Guid?** | Identifier of the tenant. | [optional] 
**CategoryId** | **Guid?** | Category identifier. | [optional] 
**SupplierId** | **Guid?** | Supplier identifier. | [optional] 
**Page** | **int?** | Current page of the response. | [optional] 
**Limit** | **int?** | Limit of items per page in the response. | [optional] 
**Total** | **int?** | Total number of items available. | [optional] 
**Offers** | [**List&lt;TransportOfferResponseItemSchema&gt;**](TransportOfferResponseItemSchema.md) | Array of TransportOfferResponseItemSchema detailing individual offers. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

