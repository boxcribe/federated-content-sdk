# FlightOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **string** | Unique identifier for the offer. | [optional] 
**supplier_offer_id** | **string** | Unique identifier for the supplier’s offer. | [optional] 
**offer_index** | **int** | Index of the offer for sorting purposes. | [optional] 
**offer_price** | **double** | Price of the offer. | [optional] 
**offer_currency** | **string** | Currency of the offer price. | [optional] 
**offer_cancelation_policies** | **map[string,object]** | Cancellation policies applicable to the offer. | [optional] 
**offer_airline_name** | **string** | Name of the airline providing the offer. | [optional] 
**offer_airline_code** | **string** | Code of the airline providing the offer. | [optional] 
**offer_airline_logo** | **string** | Logo URL of the airline. | [optional] 
**legs** | [**\Swagger\Client\Model\FlightLegOfferRequestSchema[]**](FlightLegOfferRequestSchema.md) | Array of flight legs, each described in FlightLegOfferRequestSchema. | [optional] 
**passengers** | [**\Swagger\Client\Model\FlightPassengerOfferRequestSchema[]**](FlightPassengerOfferRequestSchema.md) | Array of passengers, each described in FlightPassengerOfferRequestSchema. | [optional] 
**private_fare_codes** | **string[]** | Array of codes for accessing special negotiated fares. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

