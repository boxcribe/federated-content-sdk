# HotelRoomSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**room_id** | **str** | Unique identifier for each room. | [optional] 
**supplier_room_id** | **str** | Supplier specific identifier for the room. | [optional] 
**room_index** | **int** | Position of the room in the list. | [optional] 
**checkin_date** | **date** | Start date of the hotel reservation. | [optional] 
**checkout_date** | **date** | End date of the hotel reservation. | [optional] 
**adults** | **int** | Number of adults that can be accommodated in the room. | [optional] 
**children** | **int** | Number of children that can be accommodated in the room. | [optional] 
**room_tax** | **float** | Tax rate applicable to the room price. | [optional] 
**room_price** | **float** | Nightly rate for the room. | [optional] 
**room_currency** | **str** | Currency used for the room pricing. | [optional] 
**room_cancellation_policies** | **object** | Details about the cancellation policy for the room. | [optional] 
**room_name** | **str** | Type or name of the room. | [optional] 
**room_description** | **str** | Description of the room including amenities and features. | [optional] 
**room_images** | **list[str]** | Images showcasing the room. | [optional] 
**room_quantity_max** | **int** | Maximum quantity of this room type available. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

