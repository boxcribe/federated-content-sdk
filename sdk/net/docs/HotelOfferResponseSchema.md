# IO.Swagger.Model.HotelOfferResponseSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **Guid?** | Identifier for the company making the offer. | [optional] 
**TenantId** | **Guid?** | Identifier for the tenant involved in the offer. | [optional] 
**CategoryId** | **Guid?** | Category identifier for the offer. | [optional] 
**SupplierId** | **Guid?** | Identifier for the supplier of the offer. | [optional] 
**OfferTax** | **double?** | Tax applied to the offer price. | [optional] 
**Offers** | [**List&lt;HotelOfferResponseItemSchema&gt;**](HotelOfferResponseItemSchema.md) | Array of offers detailed in the HotelOfferResponseItemSchema. | [optional] 
**Page** | **int?** | Current page in the pagination of offers. | [optional] 
**Limit** | **int?** | Number of items per page in the offer list. | [optional] 
**Total** | **int?** | Total number of offers available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

