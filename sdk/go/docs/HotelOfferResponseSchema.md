# HotelOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompanyId** | **string** | Identifier for the company making the offer. | [optional] [default to null]
**TenantId** | **string** | Identifier for the tenant involved in the offer. | [optional] [default to null]
**CategoryId** | **string** | Category identifier for the offer. | [optional] [default to null]
**SupplierId** | **string** | Identifier for the supplier of the offer. | [optional] [default to null]
**OfferTax** | **float64** | Tax applied to the offer price. | [optional] [default to null]
**Offers** | [**[]HotelOfferResponseItemSchema**](HotelOfferResponseItemSchema.md) | Array of offers detailed in the HotelOfferResponseItemSchema. | [optional] [default to null]
**Page** | **int32** | Current page in the pagination of offers. | [optional] [default to null]
**Limit** | **int32** | Number of items per page in the offer list. | [optional] [default to null]
**Total** | **int32** | Total number of offers available. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

