# IO.Swagger.Model.FlightOfferResponseSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **Guid?** | Identifier for the company making the offer. | [optional] 
**TenantId** | **Guid?** | Identifier for the tenant. | [optional] 
**CategoryId** | **Guid?** | Identifier for the category of the offer. | [optional] 
**SupplierId** | **Guid?** | Identifier for the supplier of the offer. | [optional] 
**OfferTax** | [**decimal?**](BigDecimal.md) | Tax applied to the offer. | [optional] 
**Offers** | [**List&lt;FlightOfferResponseItemSchema&gt;**](FlightOfferResponseItemSchema.md) | Array of FlightOfferResponseItemSchema detailing individual offers. | [optional] 
**Page** | **int?** | Current page in pagination. | [optional] 
**Limit** | **int?** | Page size in pagination. | [optional] 
**Total** | **int?** | Total number of records available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

