# SwaggerClient::ToursAndActivitiesOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **String** | Identifier for the company offering the rental. | [optional] 
**tenant_id** | **String** | Identifier for the tenant. | [optional] 
**category_id** | **String** | Identifier for the category of the offer. | [optional] 
**supplier_id** | **String** | Identifier for the supplier of the offer. | [optional] 
**offers** | [**Array&lt;ToursAndActivitiesOfferResponseItemSchema&gt;**](ToursAndActivitiesOfferResponseItemSchema.md) | Array of TourOfferResponseItemSchema detailing individual car offers. | [optional] 
**page** | **Integer** | Current page in pagination. | [optional] 
**limit** | **Integer** | Page size in pagination. | [optional] 
**total** | **Integer** | Total number of records available. | [optional] 

