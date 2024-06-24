# DiningOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**companyId** | [**UUID**](UUID.md) | Identifier for the company offering the rental. |  [optional]
**tenantId** | [**UUID**](UUID.md) | Identifier for the tenant. |  [optional]
**categoryId** | [**UUID**](UUID.md) | Identifier for the category of the offer. |  [optional]
**supplierId** | [**UUID**](UUID.md) | Identifier for the supplier of the offer. |  [optional]
**offers** | [**List&lt;DiningOfferResponseItemSchema&gt;**](DiningOfferResponseItemSchema.md) | Array of DiningOfferResponseItemSchema detailing individual car offers. |  [optional]
**page** | [**BigDecimal**](BigDecimal.md) | Current page in pagination. |  [optional]
**limit** | [**BigDecimal**](BigDecimal.md) | Page size in pagination. |  [optional]
**total** | [**BigDecimal**](BigDecimal.md) | Total number of records available. |  [optional]
