# SwaggerClient::HotelOfferDetailsSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **String** | Unique identifier for the hotel offer. | [optional] 
**supplier_offer_id** | **String** | Unique identifier given by the supplier for the hotel offer. | [optional] 
**offer_index** | **Integer** | Index number of the offer for sorting and referencing purposes. | [optional] 
**offer_tax** | **Float** | Applicable tax amount for the offer. | [optional] 
**offer_price** | **Float** | Total price of the hotel offer. | [optional] 
**offer_currency** | **String** | Currency in which the offer price is denominated. | [optional] 
**offer_cancellation_policies** | **Object** | Details of the cancellation policies applicable to the offer. | [optional] 
**checkin_date** | **Date** | Scheduled check-in date for the hotel stay. | [optional] 
**checkout_date** | **Date** | Scheduled check-out date for the hotel stay. | [optional] 
**hotel_name** | **String** | Name of the hotel. | [optional] 
**hotel_description** | **String** | Description of the hotel. | [optional] 
**hotel_address** | **String** | Physical address of the hotel. | [optional] 
**hotel_latitude** | **Float** | Geographic latitude of the hotel. | [optional] 
**hotel_longitude** | **Float** | Geographic longitude of the hotel. | [optional] 
**hotel_distance** | **Float** | Distance of the hotel from a central point of interest, if applicable. | [optional] 
**hotel_distance_metric** | **String** | Unit of measurement for the distance (e.g., km, miles). | [optional] 
**hotel_images** | **Array&lt;String&gt;** | Array of images associated with the hotel. | [optional] 
**hotel_rating** | **Float** | Overall rating of the hotel. | [optional] 
**hotel_reviews** | **Object** | Collection of reviews for the hotel. | [optional] 
**hotel_stars** | **Integer** | Star rating of the hotel. | [optional] 
**hotel_checkin_time** | **String** | Standard check-in time at the hotel. | [optional] 
**hotel_checkout_time** | **String** | Standard check-out time at the hotel. | [optional] 
**hotel_facilities** | **Array&lt;String&gt;** | List of facilities available at the hotel. | [optional] 
**hotel_amenities** | **Array&lt;String&gt;** | List of amenities offered by the hotel. | [optional] 
**hotel_policies** | **Array&lt;String&gt;** | General policies of the hotel. | [optional] 
**rooms** | [**Array&lt;HotelRoomSchema&gt;**](HotelRoomSchema.md) | Array of HotelRoomSchema. | [optional] 

