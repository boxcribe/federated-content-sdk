# SwaggerClient::HotelRoomSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**room_id** | **String** | Unique identifier for each room. | [optional] 
**supplier_room_id** | **String** | Supplier specific identifier for the room. | [optional] 
**room_index** | **Integer** | Position of the room in the list. | [optional] 
**checkin_date** | **Date** | Start date of the hotel reservation. | [optional] 
**checkout_date** | **Date** | End date of the hotel reservation. | [optional] 
**adults** | **Integer** | Number of adults that can be accommodated in the room. | [optional] 
**children** | **Integer** | Number of children that can be accommodated in the room. | [optional] 
**room_tax** | **Float** | Tax rate applicable to the room price. | [optional] 
**room_price** | **Float** | Nightly rate for the room. | [optional] 
**room_currency** | **String** | Currency used for the room pricing. | [optional] 
**room_cancellation_policies** | **Object** | Details about the cancellation policy for the room. | [optional] 
**room_name** | **String** | Type or name of the room. | [optional] 
**room_description** | **String** | Description of the room including amenities and features. | [optional] 
**room_images** | **Array&lt;String&gt;** | Images showcasing the room. | [optional] 
**room_quantity_max** | **Integer** | Maximum quantity of this room type available. | [optional] 

