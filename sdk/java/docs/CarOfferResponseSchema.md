# CarOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**companyId** | [**UUID**](UUID.md) | Identifier for the company offering the rental. |  [optional]
**tenantId** | [**UUID**](UUID.md) | Identifier for the tenant. |  [optional]
**categoryId** | [**UUID**](UUID.md) | Identifier for the category of the offer. |  [optional]
**supplierId** | [**UUID**](UUID.md) | Identifier for the supplier of the offer. |  [optional]
**offers** | [**List&lt;CarOfferResponseItemSchema&gt;**](CarOfferResponseItemSchema.md) | Array of CarOfferResponseItemSchema detailing individual car offers. |  [optional]
**page** | **Integer** | Current page in pagination. |  [optional]
**limit** | **Integer** | Page size in pagination. |  [optional]
**total** | **Integer** | Total number of records available. |  [optional]
