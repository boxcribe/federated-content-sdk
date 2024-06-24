# SwaggerClient::HotelOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**location_latitude** | **Float** | Latitude of the hotel location. | [optional] 
**location_longitude** | **Float** | Longitude of the hotel location. | [optional] 
**location_radius** | **Float** | Search radius from the specified location. | [optional] 
**checkin_date** | **Date** | Check-in date for the hotel booking. | [optional] 
**checkout_date** | **Date** | Check-out date for the hotel booking. | [optional] 
**rooms** | [**Array&lt;HotelOfferRequestSchemaRooms&gt;**](HotelOfferRequestSchemaRooms.md) | Details of rooms including number of adults and children per room. | [optional] 
**filter_by_keyword** | **String** | Keyword to filter hotel offers. | [optional] 
**filter_by_price_min** | **Float** | Minimum price filter for hotel offers. | [optional] 
**filter_by_price_max** | **Float** | Maximum price filter for hotel offers. | [optional] 
**filter_by_distance_min** | **Float** | Minimum distance filter for hotel location. | [optional] 
**filter_by_distance_max** | **Float** | Maximum distance filter for hotel location. | [optional] 
**filter_by_rating_min** | **Float** | Minimum rating filter for hotels. | [optional] 
**filter_by_rating_max** | **Float** | Maximum rating filter for hotels. | [optional] 
**filter_by_stars** | **Array&lt;Integer&gt;** | Filter hotels by star ratings. | [optional] 
**filter_by_facilities** | **Array&lt;String&gt;** | Filter hotels by available facilities. | [optional] 
**filter_by_amenities** | **Array&lt;String&gt;** | Filter hotels by available amenities. | [optional] 
**sort_by** | **String** | Field to sort the results by. | [optional] 
**sort_order** | **String** | Order to sort the results, either asc or desc. | [optional] 
**page** | **Integer** | Page number for pagination. | [optional] 
**limit** | **Integer** | Number of items per page for pagination. | [optional] 
**language** | **String** | Preferred language of the hotel information. | [optional] 
**currency** | **String** | Currency in which prices should be displayed. | [optional] 
**metric** | **String** | Unit of measure for distance, either miles (mi) or kilometers (km). | [optional] 

