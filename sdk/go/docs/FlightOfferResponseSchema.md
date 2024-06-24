# FlightOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **string** | Identifier for the company making the offer. | [optional] [default to null]
**TenantId** | **string** | Identifier for the tenant. | [optional] [default to null]
**CategoryId** | **string** | Identifier for the category of the offer. | [optional] [default to null]
**SupplierId** | **string** | Identifier for the supplier of the offer. | [optional] [default to null]
**OfferTax** | **float64** | Tax applied to the offer. | [optional] [default to null]
**Offers** | [**[]FlightOfferResponseItemSchema**](FlightOfferResponseItemSchema.md) | Array of FlightOfferResponseItemSchema detailing individual offers. | [optional] [default to null]
**Page** | **int32** | Current page in pagination. | [optional] [default to null]
**Limit** | **int32** | Page size in pagination. | [optional] [default to null]
**Total** | **int32** | Total number of records available. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

