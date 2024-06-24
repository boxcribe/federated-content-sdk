# HotelOfferDetailsSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **string** | Unique identifier for the hotel offer. | [optional] 
**supplier_offer_id** | **string** | Unique identifier given by the supplier for the hotel offer. | [optional] 
**offer_index** | **int** | Index number of the offer for sorting and referencing purposes. | [optional] 
**offer_tax** | **double** | Applicable tax amount for the offer. | [optional] 
**offer_price** | **double** | Total price of the hotel offer. | [optional] 
**offer_currency** | **string** | Currency in which the offer price is denominated. | [optional] 
**offer_cancellation_policies** | **object** | Details of the cancellation policies applicable to the offer. | [optional] 
**checkin_date** | [**\DateTime**](\DateTime.md) | Scheduled check-in date for the hotel stay. | [optional] 
**checkout_date** | [**\DateTime**](\DateTime.md) | Scheduled check-out date for the hotel stay. | [optional] 
**hotel_name** | **string** | Name of the hotel. | [optional] 
**hotel_description** | **string** | Description of the hotel. | [optional] 
**hotel_address** | **string** | Physical address of the hotel. | [optional] 
**hotel_latitude** | **float** | Geographic latitude of the hotel. | [optional] 
**hotel_longitude** | **float** | Geographic longitude of the hotel. | [optional] 
**hotel_distance** | **double** | Distance of the hotel from a central point of interest, if applicable. | [optional] 
**hotel_distance_metric** | **string** | Unit of measurement for the distance (e.g., km, miles). | [optional] 
**hotel_images** | **string[]** | Array of images associated with the hotel. | [optional] 
**hotel_rating** | **float** | Overall rating of the hotel. | [optional] 
**hotel_reviews** | **object** | Collection of reviews for the hotel. | [optional] 
**hotel_stars** | **int** | Star rating of the hotel. | [optional] 
**hotel_checkin_time** | **string** | Standard check-in time at the hotel. | [optional] 
**hotel_checkout_time** | **string** | Standard check-out time at the hotel. | [optional] 
**hotel_facilities** | **string[]** | List of facilities available at the hotel. | [optional] 
**hotel_amenities** | **string[]** | List of amenities offered by the hotel. | [optional] 
**hotel_policies** | **string[]** | General policies of the hotel. | [optional] 
**rooms** | [**\Swagger\Client\Model\HotelRoomSchema[]**](HotelRoomSchema.md) | Array of HotelRoomSchema. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

