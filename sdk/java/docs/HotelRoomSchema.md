# HotelRoomSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**roomId** | [**UUID**](UUID.md) | Unique identifier for each room. |  [optional]
**supplierRoomId** | **String** | Supplier specific identifier for the room. |  [optional]
**roomIndex** | **Integer** | Position of the room in the list. |  [optional]
**checkinDate** | [**LocalDate**](LocalDate.md) | Start date of the hotel reservation. |  [optional]
**checkoutDate** | [**LocalDate**](LocalDate.md) | End date of the hotel reservation. |  [optional]
**adults** | **Integer** | Number of adults that can be accommodated in the room. |  [optional]
**children** | **Integer** | Number of children that can be accommodated in the room. |  [optional]
**roomTax** | **Double** | Tax rate applicable to the room price. |  [optional]
**roomPrice** | **Double** | Nightly rate for the room. |  [optional]
**roomCurrency** | **String** | Currency used for the room pricing. |  [optional]
**roomCancellationPolicies** | **Object** | Details about the cancellation policy for the room. |  [optional]
**roomName** | **String** | Type or name of the room. |  [optional]
**roomDescription** | **String** | Description of the room including amenities and features. |  [optional]
**roomImages** | **List&lt;String&gt;** | Images showcasing the room. |  [optional]
**roomQuantityMax** | **Integer** | Maximum quantity of this room type available. |  [optional]
