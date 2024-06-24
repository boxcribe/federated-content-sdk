# TransportOfferDetailsSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **string** | Unique identifier of the offer. | [optional] 
**supplier_offer_id** | **string** | Unique identifier for the supplier’s offer. | [optional] 
**offer_index** | **int** | Index number of the offer. | [optional] 
**offer_tax** | **float** | Applicable taxes on the offer. | [optional] 
**offer_price** | **float** | Total price of the offer. | [optional] 
**offer_currency** | **string** | Currency of the offer. | [optional] 
**offer_cancelation_policies** | **string** | Cancellation policies of the offer. | [optional] 
**pickup_date** | [**\DateTime**](\DateTime.md) | Date when the transport is scheduled to be picked up. | [optional] 
**pickup_time** | **string** | Time when the transport is scheduled to be picked up. | [optional] 
**adults** | **int** | Number of adults included in the transport offer. | [optional] 
**children** | **int** | Number of children included in the transport offer. | [optional] 
**return_date** | [**\DateTime**](\DateTime.md) | Date when the transport is scheduled to be returned. | [optional] 
**return_time** | **string** | Time when the transport is scheduled to be returned. | [optional] 
**transport_name** | **string** | Name of the transport provider or vehicle. | [optional] 
**transport_description** | **string** | Description of the transport. | [optional] 
**transport_address** | **string** | Address where the transport is located or where it operates. | [optional] 
**transport_latitude** | **float** | Latitude coordinate of the transport location. | [optional] 
**transport_longitude** | **float** | Longitude coordinate of the transport location. | [optional] 
**transport_distance** | **float** | Distance covered by the transport offer. | [optional] 
**transport_distance_metric** | **string** | Metric unit for transport distance (e.g., kilometers, miles). | [optional] 
**transport_images** | **string[]** | Collection of images of the transport. | [optional] 
**transport_rating** | **float** | Rating of the transport. | [optional] 
**transport_reviews** | **string[]** | Reviews for the transport. | [optional] 
**transport_type** | **string** | Type of transport (e.g., car, van, scooter). | [optional] 
**transport_class** | **string** | Class of the transport (e.g., economy, luxury). | [optional] 
**transport_company** | **string** | Company providing the transport. | [optional] 
**transport_company_logo** | **string** | Logo of the company providing the transport. | [optional] 
**transport_passengers_number** | **int** | Number of passengers the transport can accommodate. | [optional] 
**transport_bags_number** | **int** | Number of bags the transport can accommodate. | [optional] 
**transport_amenities** | **string[]** | List of amenities provided with the transport. | [optional] 
**booking_questions** | **string[]** | Questions related to booking the transport. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

