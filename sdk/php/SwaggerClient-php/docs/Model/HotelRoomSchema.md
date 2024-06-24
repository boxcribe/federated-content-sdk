# HotelRoomSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**room_id** | **string** | Unique identifier for each room. | [optional] 
**supplier_room_id** | **string** | Supplier specific identifier for the room. | [optional] 
**room_index** | **int** | Position of the room in the list. | [optional] 
**checkin_date** | [**\DateTime**](\DateTime.md) | Start date of the hotel reservation. | [optional] 
**checkout_date** | [**\DateTime**](\DateTime.md) | End date of the hotel reservation. | [optional] 
**adults** | **int** | Number of adults that can be accommodated in the room. | [optional] 
**children** | **int** | Number of children that can be accommodated in the room. | [optional] 
**room_tax** | **double** | Tax rate applicable to the room price. | [optional] 
**room_price** | **double** | Nightly rate for the room. | [optional] 
**room_currency** | **string** | Currency used for the room pricing. | [optional] 
**room_cancellation_policies** | **object** | Details about the cancellation policy for the room. | [optional] 
**room_name** | **string** | Type or name of the room. | [optional] 
**room_description** | **string** | Description of the room including amenities and features. | [optional] 
**room_images** | **string[]** | Images showcasing the room. | [optional] 
**room_quantity_max** | **int** | Maximum quantity of this room type available. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

