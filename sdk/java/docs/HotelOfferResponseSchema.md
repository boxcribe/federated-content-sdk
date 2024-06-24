# HotelOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**companyId** | [**UUID**](UUID.md) | Identifier for the company making the offer. |  [optional]
**tenantId** | [**UUID**](UUID.md) | Identifier for the tenant involved in the offer. |  [optional]
**categoryId** | [**UUID**](UUID.md) | Category identifier for the offer. |  [optional]
**supplierId** | [**UUID**](UUID.md) | Identifier for the supplier of the offer. |  [optional]
**offerTax** | **Double** | Tax applied to the offer price. |  [optional]
**offers** | [**List&lt;HotelOfferResponseItemSchema&gt;**](HotelOfferResponseItemSchema.md) | Array of offers detailed in the HotelOfferResponseItemSchema. |  [optional]
**page** | **Integer** | Current page in the pagination of offers. |  [optional]
**limit** | **Integer** | Number of items per page in the offer list. |  [optional]
**total** | **Integer** | Total number of offers available. |  [optional]
