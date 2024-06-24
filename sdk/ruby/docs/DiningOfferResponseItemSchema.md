# SwaggerClient::DiningOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **String** | Unique identifier for the dining offer. | [optional] 
**supplier_offer_id** | **String** | Identifier for the offer provided by the supplier. | [optional] 
**offer_index** | [**BigDecimal**](BigDecimal.md) | Index of the offer for sorting and reference. | [optional] 
**offer_tax** | [**BigDecimal**](BigDecimal.md) | Tax applied to the dining offer. | [optional] 
**offer_price** | [**BigDecimal**](BigDecimal.md) | Price of the dining experience. | [optional] 
**offer_currency** | **String** | Currency in which the offer is priced. | [optional] 
**offer_cancellation_policies** | **String** | Cancellation policies applicable to the dining offer. | [optional] 
**dining_name** | **String** | Name of the dining establishment. | [optional] 
**dining_description** | **String** | Description of the dining establishment and the dining experience. | [optional] 
**dining_address** | **String** | Physical address of the dining establishment. | [optional] 
**dining_latitude** | **Float** | Latitude coordinate of the dining location. | [optional] 
**dining_longitude** | **Float** | Longitude coordinate of the dining location. | [optional] 
**dining_distance** | **Float** | Distance to the dining location from a reference point, if applicable. | [optional] 
**dining_distance_metric** | **String** | Metric used to measure the distance (e.g., miles, kilometers). | [optional] 
**dining_images** | **Array&lt;String&gt;** | Collection of images of the dining establishment and dishes. | [optional] 
**dining_rating** | **Float** | Rating of the dining establishment based on customer reviews. | [optional] 
**dining_reviews** | **Array&lt;String&gt;** | Customer reviews for the dining establishment. | [optional] 
**dining_subcategories** | **Array&lt;String&gt;** | List of subcategories the dining offer belongs to (e.g., Italian, Seafood, Fine Dining). | [optional] 
**dining_hours** | **Array&lt;String&gt;** | Operating hours of the dining establishment. | [optional] 

