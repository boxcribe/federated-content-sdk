# HotelOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **str** | Unique identifier for the hotel offer. | [optional] 
**supplier_offer_id** | **str** | Unique identifier given by the supplier for the hotel offer. | [optional] 
**offer_index** | **int** | Index number of the offer for sorting and referencing purposes. | [optional] 
**offer_tax** | **float** | Applicable tax amount for the offer. | [optional] 
**offer_price** | **float** | Total price of the hotel offer. | [optional] 
**offer_currency** | **str** | Currency in which the offer price is denominated. | [optional] 
**offer_cancellation_policies** | **object** | Details of the cancellation policies applicable to the offer. | [optional] 
**checkin_date** | **date** | Scheduled check-in date for the hotel stay. | [optional] 
**checkout_date** | **date** | Scheduled check-out date for the hotel stay. | [optional] 
**hotel_name** | **str** | Name of the hotel. | [optional] 
**hotel_description** | **str** | Description of the hotel. | [optional] 
**hotel_address** | **str** | Physical address of the hotel. | [optional] 
**hotel_latitude** | **float** | Geographic latitude of the hotel. | [optional] 
**hotel_longitude** | **float** | Geographic longitude of the hotel. | [optional] 
**hotel_distance** | **float** | Distance of the hotel from a central point of interest, if applicable. | [optional] 
**hotel_distance_metric** | **str** | Unit of measurement for the distance (e.g., km, miles). | [optional] 
**hotel_images** | **list[str]** | Array of images associated with the hotel. | [optional] 
**hotel_rating** | **float** | Overall rating of the hotel. | [optional] 
**hotel_reviews** | **dict(str, object)** | Collection of reviews for the hotel. | [optional] 
**hotel_stars** | **int** | Star rating of the hotel. | [optional] 
**hotel_checkin_time** | **str** | Standard check-in time at the hotel. | [optional] 
**hotel_checkout_time** | **str** | Standard check-out time at the hotel. | [optional] 
**hotel_facilities** | **list[str]** | List of facilities available at the hotel. | [optional] 
**hotel_amenities** | **list[str]** | List of amenities offered by the hotel. | [optional] 
**hotel_policies** | **list[str]** | General policies of the hotel. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

