# HotelOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LocationLatitude** | **float32** | Latitude of the hotel location. | [optional] [default to null]
**LocationLongitude** | **float32** | Longitude of the hotel location. | [optional] [default to null]
**LocationRadius** | **float32** | Search radius from the specified location. | [optional] [default to null]
**CheckinDate** | **string** | Check-in date for the hotel booking. | [optional] [default to null]
**CheckoutDate** | **string** | Check-out date for the hotel booking. | [optional] [default to null]
**Rooms** | [**[]HotelOfferRequestSchemaRooms**](HotelOfferRequestSchema_rooms.md) | Details of rooms including number of adults and children per room. | [optional] [default to null]
**FilterByKeyword** | **string** | Keyword to filter hotel offers. | [optional] [default to null]
**FilterByPriceMin** | **float64** | Minimum price filter for hotel offers. | [optional] [default to null]
**FilterByPriceMax** | **float64** | Maximum price filter for hotel offers. | [optional] [default to null]
**FilterByDistanceMin** | **float32** | Minimum distance filter for hotel location. | [optional] [default to null]
**FilterByDistanceMax** | **float32** | Maximum distance filter for hotel location. | [optional] [default to null]
**FilterByRatingMin** | **float32** | Minimum rating filter for hotels. | [optional] [default to null]
**FilterByRatingMax** | **float32** | Maximum rating filter for hotels. | [optional] [default to null]
**FilterByStars** | **[]int32** | Filter hotels by star ratings. | [optional] [default to null]
**FilterByFacilities** | **[]string** | Filter hotels by available facilities. | [optional] [default to null]
**FilterByAmenities** | **[]string** | Filter hotels by available amenities. | [optional] [default to null]
**SortBy** | **string** | Field to sort the results by. | [optional] [default to null]
**SortOrder** | **string** | Order to sort the results, either asc or desc. | [optional] [default to null]
**Page** | **int32** | Page number for pagination. | [optional] [default to null]
**Limit** | **int32** | Number of items per page for pagination. | [optional] [default to null]
**Language** | **string** | Preferred language of the hotel information. | [optional] [default to null]
**Currency** | **string** | Currency in which prices should be displayed. | [optional] [default to null]
**Metric** | **string** | Unit of measure for distance, either miles (mi) or kilometers (km). | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

