# HotelRoomSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RoomId** | **string** | Unique identifier for each room. | [optional] [default to null]
**SupplierRoomId** | **string** | Supplier specific identifier for the room. | [optional] [default to null]
**RoomIndex** | **int32** | Position of the room in the list. | [optional] [default to null]
**CheckinDate** | **string** | Start date of the hotel reservation. | [optional] [default to null]
**CheckoutDate** | **string** | End date of the hotel reservation. | [optional] [default to null]
**Adults** | **int32** | Number of adults that can be accommodated in the room. | [optional] [default to null]
**Children** | **int32** | Number of children that can be accommodated in the room. | [optional] [default to null]
**RoomTax** | **float64** | Tax rate applicable to the room price. | [optional] [default to null]
**RoomPrice** | **float64** | Nightly rate for the room. | [optional] [default to null]
**RoomCurrency** | **string** | Currency used for the room pricing. | [optional] [default to null]
**RoomCancellationPolicies** | [***interface{}**](interface{}.md) | Details about the cancellation policy for the room. | [optional] [default to null]
**RoomName** | **string** | Type or name of the room. | [optional] [default to null]
**RoomDescription** | **string** | Description of the room including amenities and features. | [optional] [default to null]
**RoomImages** | **[]string** | Images showcasing the room. | [optional] [default to null]
**RoomQuantityMax** | **int32** | Maximum quantity of this room type available. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

