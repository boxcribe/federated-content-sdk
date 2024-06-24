# FlightOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**companyId** | [**UUID**](UUID.md) | Identifier for the company making the offer. |  [optional]
**tenantId** | [**UUID**](UUID.md) | Identifier for the tenant. |  [optional]
**categoryId** | [**UUID**](UUID.md) | Identifier for the category of the offer. |  [optional]
**supplierId** | [**UUID**](UUID.md) | Identifier for the supplier of the offer. |  [optional]
**offerTax** | [**BigDecimal**](BigDecimal.md) | Tax applied to the offer. |  [optional]
**offers** | [**List&lt;FlightOfferResponseItemSchema&gt;**](FlightOfferResponseItemSchema.md) | Array of FlightOfferResponseItemSchema detailing individual offers. |  [optional]
**page** | **Integer** | Current page in pagination. |  [optional]
**limit** | **Integer** | Page size in pagination. |  [optional]
**total** | **Integer** | Total number of records available. |  [optional]
