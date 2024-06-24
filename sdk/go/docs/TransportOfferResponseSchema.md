# TransportOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **string** | Identifier of the company. | [optional] [default to null]
**TenantId** | **string** | Identifier of the tenant. | [optional] [default to null]
**CategoryId** | **string** | Category identifier. | [optional] [default to null]
**SupplierId** | **string** | Supplier identifier. | [optional] [default to null]
**Page** | **int32** | Current page of the response. | [optional] [default to null]
**Limit** | **int32** | Limit of items per page in the response. | [optional] [default to null]
**Total** | **int32** | Total number of items available. | [optional] [default to null]
**Offers** | [**[]TransportOfferResponseItemSchema**](TransportOfferResponseItemSchema.md) | Array of TransportOfferResponseItemSchema detailing individual offers. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

