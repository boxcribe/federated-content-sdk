# TransportOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **str** | Unique identifier of the offer. | [optional] 
**supplier_offer_id** | **str** | Unique identifier for the supplier’s offer. | [optional] 
**offer_index** | **int** | Index number of the offer. | [optional] 
**offer_tax** | **float** | Applicable taxes on the offer. | [optional] 
**offer_price** | **float** | Total price of the offer. | [optional] 
**offer_currency** | **str** | Currency of the offer. | [optional] 
**offer_cancelation_policies** | **str** | Cancellation policies of the offer. | [optional] 
**pickup_date** | **date** | Date when the transport is scheduled to be picked up. | [optional] 
**pickup_time** | **str** | Time when the transport is scheduled to be picked up. | [optional] 
**adults** | **int** | Number of adults included in the transport offer. | [optional] 
**children** | **int** | Number of children included in the transport offer. | [optional] 
**return_date** | **date** | Date when the transport is scheduled to be returned. | [optional] 
**return_time** | **str** | Time when the transport is scheduled to be returned. | [optional] 
**transport_name** | **str** | Name of the transport provider or vehicle. | [optional] 
**transport_description** | **str** | Description of the transport. | [optional] 
**transport_address** | **str** | Address where the transport is located or where it operates. | [optional] 
**transport_latitude** | **float** | Latitude coordinate of the transport location. | [optional] 
**transport_longitude** | **float** | Longitude coordinate of the transport location. | [optional] 
**transport_distance** | **float** | Distance covered by the transport offer. | [optional] 
**transport_distance_metric** | **str** | Metric unit for transport distance (e.g., kilometers, miles). | [optional] 
**transport_images** | **list[str]** | Collection of images of the transport. | [optional] 
**transport_rating** | **float** | Rating of the transport. | [optional] 
**transport_reviews** | **list[str]** | Reviews for the transport. | [optional] 
**transport_type** | **str** | Type of transport (e.g., car, van, scooter). | [optional] 
**transport_class** | **str** | Class of the transport (e.g., economy, luxury). | [optional] 
**transport_company** | **str** | Company providing the transport. | [optional] 
**transport_company_logo** | **str** | Logo of the company providing the transport. | [optional] 
**transport_passengers_number** | **int** | Number of passengers the transport can accommodate. | [optional] 
**transport_bags_number** | **int** | Number of bags the transport can accommodate. | [optional] 
**transport_amenities** | **list[str]** | List of amenities provided with the transport. | [optional] 
**booking_questions** | **list[str]** | Questions related to booking the transport. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

