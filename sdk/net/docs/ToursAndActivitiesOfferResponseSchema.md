# IO.Swagger.Model.ToursAndActivitiesOfferResponseSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **Guid?** | Identifier for the company offering the rental. | [optional] 
**TenantId** | **Guid?** | Identifier for the tenant. | [optional] 
**CategoryId** | **Guid?** | Identifier for the category of the offer. | [optional] 
**SupplierId** | **Guid?** | Identifier for the supplier of the offer. | [optional] 
**Offers** | [**List&lt;ToursAndActivitiesOfferResponseItemSchema&gt;**](ToursAndActivitiesOfferResponseItemSchema.md) | Array of TourOfferResponseItemSchema detailing individual car offers. | [optional] 
**Page** | **int?** | Current page in pagination. | [optional] 
**Limit** | **int?** | Page size in pagination. | [optional] 
**Total** | **int?** | Total number of records available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

