# IO.Swagger.Model.EventOfferResponseSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **Guid?** | Identifier for the company offering the rental. | [optional] 
**TenantId** | **Guid?** | Identifier for the tenant. | [optional] 
**CategoryId** | **Guid?** | Identifier for the category of the offer. | [optional] 
**SupplierId** | **Guid?** | Identifier for the supplier of the offer. | [optional] 
**Offers** | [**List&lt;EventOfferResponseItemSchema&gt;**](EventOfferResponseItemSchema.md) | Array of EventOfferResponseItemSchema detailing individual car offers. | [optional] 
**Page** | [**decimal?**](BigDecimal.md) | Current page in pagination. | [optional] 
**Limit** | [**decimal?**](BigDecimal.md) | Page size in pagination. | [optional] 
**Total** | [**decimal?**](BigDecimal.md) | Total number of records available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

