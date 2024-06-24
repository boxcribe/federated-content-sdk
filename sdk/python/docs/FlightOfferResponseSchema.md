# FlightOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **str** | Identifier for the company making the offer. | [optional] 
**tenant_id** | **str** | Identifier for the tenant. | [optional] 
**category_id** | **str** | Identifier for the category of the offer. | [optional] 
**supplier_id** | **str** | Identifier for the supplier of the offer. | [optional] 
**offer_tax** | **float** | Tax applied to the offer. | [optional] 
**offers** | [**list[FlightOfferResponseItemSchema]**](FlightOfferResponseItemSchema.md) | Array of FlightOfferResponseItemSchema detailing individual offers. | [optional] 
**page** | **int** | Current page in pagination. | [optional] 
**limit** | **int** | Page size in pagination. | [optional] 
**total** | **int** | Total number of records available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

