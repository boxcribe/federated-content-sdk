# TransportOfferResponseSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**companyId** | [**UUID**](UUID.md) | Identifier of the company. |  [optional]
**tenantId** | [**UUID**](UUID.md) | Identifier of the tenant. |  [optional]
**categoryId** | [**UUID**](UUID.md) | Category identifier. |  [optional]
**supplierId** | [**UUID**](UUID.md) | Supplier identifier. |  [optional]
**page** | **Integer** | Current page of the response. |  [optional]
**limit** | **Integer** | Limit of items per page in the response. |  [optional]
**total** | **Integer** | Total number of items available. |  [optional]
**offers** | [**List&lt;TransportOfferResponseItemSchema&gt;**](TransportOfferResponseItemSchema.md) | Array of TransportOfferResponseItemSchema detailing individual offers. |  [optional]
