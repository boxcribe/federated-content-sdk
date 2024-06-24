# HotelOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**locationLatitude** | **Float** | Latitude of the hotel location. |  [optional]
**locationLongitude** | **Float** | Longitude of the hotel location. |  [optional]
**locationRadius** | **Float** | Search radius from the specified location. |  [optional]
**checkinDate** | [**LocalDate**](LocalDate.md) | Check-in date for the hotel booking. |  [optional]
**checkoutDate** | [**LocalDate**](LocalDate.md) | Check-out date for the hotel booking. |  [optional]
**rooms** | [**List&lt;HotelOfferRequestSchemaRooms&gt;**](HotelOfferRequestSchemaRooms.md) | Details of rooms including number of adults and children per room. |  [optional]
**filterByKeyword** | **String** | Keyword to filter hotel offers. |  [optional]
**filterByPriceMin** | **Double** | Minimum price filter for hotel offers. |  [optional]
**filterByPriceMax** | **Double** | Maximum price filter for hotel offers. |  [optional]
**filterByDistanceMin** | **Float** | Minimum distance filter for hotel location. |  [optional]
**filterByDistanceMax** | **Float** | Maximum distance filter for hotel location. |  [optional]
**filterByRatingMin** | **Float** | Minimum rating filter for hotels. |  [optional]
**filterByRatingMax** | **Float** | Maximum rating filter for hotels. |  [optional]
**filterByStars** | **List&lt;Integer&gt;** | Filter hotels by star ratings. |  [optional]
**filterByFacilities** | **List&lt;String&gt;** | Filter hotels by available facilities. |  [optional]
**filterByAmenities** | **List&lt;String&gt;** | Filter hotels by available amenities. |  [optional]
**sortBy** | **String** | Field to sort the results by. |  [optional]
**sortOrder** | **String** | Order to sort the results, either asc or desc. |  [optional]
**page** | **Integer** | Page number for pagination. |  [optional]
**limit** | **Integer** | Number of items per page for pagination. |  [optional]
**language** | **String** | Preferred language of the hotel information. |  [optional]
**currency** | **String** | Currency in which prices should be displayed. |  [optional]
**metric** | **String** | Unit of measure for distance, either miles (mi) or kilometers (km). |  [optional]
