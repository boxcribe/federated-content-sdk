# HotelOfferRequestSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**location_latitude** | **float** | Latitude of the hotel location. | [optional] 
**location_longitude** | **float** | Longitude of the hotel location. | [optional] 
**location_radius** | **float** | Search radius from the specified location. | [optional] 
**checkin_date** | **date** | Check-in date for the hotel booking. | [optional] 
**checkout_date** | **date** | Check-out date for the hotel booking. | [optional] 
**rooms** | [**list[HotelOfferRequestSchemaRooms]**](HotelOfferRequestSchemaRooms.md) | Details of rooms including number of adults and children per room. | [optional] 
**filter_by_keyword** | **str** | Keyword to filter hotel offers. | [optional] 
**filter_by_price_min** | **float** | Minimum price filter for hotel offers. | [optional] 
**filter_by_price_max** | **float** | Maximum price filter for hotel offers. | [optional] 
**filter_by_distance_min** | **float** | Minimum distance filter for hotel location. | [optional] 
**filter_by_distance_max** | **float** | Maximum distance filter for hotel location. | [optional] 
**filter_by_rating_min** | **float** | Minimum rating filter for hotels. | [optional] 
**filter_by_rating_max** | **float** | Maximum rating filter for hotels. | [optional] 
**filter_by_stars** | **list[int]** | Filter hotels by star ratings. | [optional] 
**filter_by_facilities** | **list[str]** | Filter hotels by available facilities. | [optional] 
**filter_by_amenities** | **list[str]** | Filter hotels by available amenities. | [optional] 
**sort_by** | **str** | Field to sort the results by. | [optional] 
**sort_order** | **str** | Order to sort the results, either asc or desc. | [optional] 
**page** | **int** | Page number for pagination. | [optional] 
**limit** | **int** | Number of items per page for pagination. | [optional] 
**language** | **str** | Preferred language of the hotel information. | [optional] 
**currency** | **str** | Currency in which prices should be displayed. | [optional] 
**metric** | **str** | Unit of measure for distance, either miles (mi) or kilometers (km). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

