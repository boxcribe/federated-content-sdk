# SwaggerClient::HotelOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**company_id** | **String** | Identifier for the company making the offer. | [optional] 
**tenant_id** | **String** | Identifier for the tenant involved in the offer. | [optional] 
**category_id** | **String** | Category identifier for the offer. | [optional] 
**supplier_id** | **String** | Identifier for the supplier of the offer. | [optional] 
**offer_tax** | **Float** | Tax applied to the offer price. | [optional] 
**offers** | [**Array&lt;HotelOfferResponseItemSchema&gt;**](HotelOfferResponseItemSchema.md) | Array of offers detailed in the HotelOfferResponseItemSchema. | [optional] 
**page** | **Integer** | Current page in the pagination of offers. | [optional] 
**limit** | **Integer** | Number of items per page in the offer list. | [optional] 
**total** | **Integer** | Total number of offers available. | [optional] 

