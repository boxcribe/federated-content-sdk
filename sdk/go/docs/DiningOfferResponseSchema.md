# DiningOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **string** | Identifier for the company offering the rental. | [optional] [default to null]
**TenantId** | **string** | Identifier for the tenant. | [optional] [default to null]
**CategoryId** | **string** | Identifier for the category of the offer. | [optional] [default to null]
**SupplierId** | **string** | Identifier for the supplier of the offer. | [optional] [default to null]
**Offers** | [**[]DiningOfferResponseItemSchema**](DiningOfferResponseItemSchema.md) | Array of DiningOfferResponseItemSchema detailing individual car offers. | [optional] [default to null]
**Page** | **float64** | Current page in pagination. | [optional] [default to null]
**Limit** | **float64** | Page size in pagination. | [optional] [default to null]
**Total** | **float64** | Total number of records available. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

