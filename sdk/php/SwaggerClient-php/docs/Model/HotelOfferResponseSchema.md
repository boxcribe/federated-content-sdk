# HotelOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **string** | Identifier for the company making the offer. | [optional] 
**tenant_id** | **string** | Identifier for the tenant involved in the offer. | [optional] 
**category_id** | **string** | Category identifier for the offer. | [optional] 
**supplier_id** | **string** | Identifier for the supplier of the offer. | [optional] 
**offer_tax** | **double** | Tax applied to the offer price. | [optional] 
**offers** | [**\Swagger\Client\Model\HotelOfferResponseItemSchema[]**](HotelOfferResponseItemSchema.md) | Array of offers detailed in the HotelOfferResponseItemSchema. | [optional] 
**page** | **int** | Current page in the pagination of offers. | [optional] 
**limit** | **int** | Number of items per page in the offer list. | [optional] 
**total** | **int** | Total number of offers available. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

