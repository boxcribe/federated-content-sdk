# SwaggerClient::FlightOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **String** | Unique identifier for the offer. | [optional] 
**supplier_offer_id** | **String** | Unique identifier for the supplier’s offer. | [optional] 
**offer_index** | **Integer** | Index of the offer for sorting purposes. | [optional] 
**offer_price** | **Float** | Price of the offer. | [optional] 
**offer_currency** | **String** | Currency of the offer price. | [optional] 
**offer_cancelation_policies** | **Hash** | Cancellation policies applicable to the offer. | [optional] 
**offer_airline_name** | **String** | Name of the airline providing the offer. | [optional] 
**offer_airline_code** | **String** | Code of the airline providing the offer. | [optional] 
**offer_airline_logo** | **String** | Logo URL of the airline. | [optional] 
**legs** | [**Array&lt;FlightLegOfferRequestSchema&gt;**](FlightLegOfferRequestSchema.md) | Array of flight legs, each described in FlightLegOfferRequestSchema. | [optional] 
**passengers** | [**Array&lt;FlightPassengerOfferRequestSchema&gt;**](FlightPassengerOfferRequestSchema.md) | Array of passengers, each described in FlightPassengerOfferRequestSchema. | [optional] 
**private_fare_codes** | **Array&lt;String&gt;** | Array of codes for accessing special negotiated fares. | [optional] 

