# ToursAndActivitiesOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **str** | Identifier for the company offering the rental. | [optional] 
**tenant_id** | **str** | Identifier for the tenant. | [optional] 
**category_id** | **str** | Identifier for the category of the offer. | [optional] 
**supplier_id** | **str** | Identifier for the supplier of the offer. | [optional] 
**offers** | [**list[ToursAndActivitiesOfferResponseItemSchema]**](ToursAndActivitiesOfferResponseItemSchema.md) | Array of TourOfferResponseItemSchema detailing individual car offers. | [optional] 
**page** | **int** | Current page in pagination. | [optional] 
**limit** | **int** | Page size in pagination. | [optional] 
**total** | **int** | Total number of records available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

