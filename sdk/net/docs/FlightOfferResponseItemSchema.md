# IO.Swagger.Model.FlightOfferResponseItemSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **Guid?** | Unique identifier for the offer. | [optional] 
**SupplierOfferId** | **Guid?** | Unique identifier for the supplier’s offer. | [optional] 
**OfferIndex** | **int?** | Index of the offer for sorting purposes. | [optional] 
**OfferPrice** | **double?** | Price of the offer. | [optional] 
**OfferCurrency** | **string** | Currency of the offer price. | [optional] 
**OfferCancelationPolicies** | **Dictionary&lt;string, Object&gt;** | Cancellation policies applicable to the offer. | [optional] 
**OfferAirlineName** | **string** | Name of the airline providing the offer. | [optional] 
**OfferAirlineCode** | **string** | Code of the airline providing the offer. | [optional] 
**OfferAirlineLogo** | **string** | Logo URL of the airline. | [optional] 
**Legs** | [**List&lt;FlightLegOfferRequestSchema&gt;**](FlightLegOfferRequestSchema.md) | Array of flight legs, each described in FlightLegOfferRequestSchema. | [optional] 
**Passengers** | [**List&lt;FlightPassengerOfferRequestSchema&gt;**](FlightPassengerOfferRequestSchema.md) | Array of passengers, each described in FlightPassengerOfferRequestSchema. | [optional] 
**PrivateFareCodes** | **List&lt;string&gt;** | Array of codes for accessing special negotiated fares. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

