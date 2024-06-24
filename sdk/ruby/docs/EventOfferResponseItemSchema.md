# SwaggerClient::EventOfferResponseItemSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **String** | Unique identifier for the offer. | [optional] 
**supplier_offer_id** | **String** | Unique identifier for the supplier’s offer. | [optional] 
**offer_index** | [**BigDecimal**](BigDecimal.md) | Index of the offer for sorting purposes. | [optional] 
**offer_tax** | [**BigDecimal**](BigDecimal.md) | Tax applied to the offer. | [optional] 
**offer_price** | [**BigDecimal**](BigDecimal.md) | Price of the offer. | [optional] 
**offer_currency** | **String** | Currency of the offer price. | [optional] 
**offer_cancelation_policies** | **String** | Cancellation policies applicable to the offer. | [optional] 
**date** | **Date** | Date of the event. | [optional] 
**adults** | [**BigDecimal**](BigDecimal.md) | Number of adults involved in the event. | [optional] 
**children** | [**BigDecimal**](BigDecimal.md) | Number of children involved in the event. | [optional] 
**event_name** | **String** | Name of the event. | [optional] 
**event_description** | **String** | Description of the event. | [optional] 
**event_address** | **String** | Address where the event will take place. | [optional] 
**event_latitude** | **Float** | Latitude of the event location. | [optional] 
**event_longitude** | **Float** | Longitude of the event location. | [optional] 
**event_distance** | [**BigDecimal**](BigDecimal.md) | Distance to the event from a reference point. | [optional] 
**event_distance_metric** | **String** | Metric used to measure the distance to the event. | [optional] 
**event_images** | **Array&lt;String&gt;** | Images of the event. | [optional] 
**event_rating** | [**BigDecimal**](BigDecimal.md) | Rating of the event. | [optional] 
**event_reviews** | **Array&lt;String&gt;** | Reviews of the event. | [optional] 
**event_venue** | **String** | Venue where the event will take place. | [optional] 
**event_venue_capacity** | [**BigDecimal**](BigDecimal.md) | Capacity of the venue. | [optional] 
**event_performers** | **Array&lt;String&gt;** | Performers at the event. | [optional] 
**event_subcategories** | **Array&lt;String&gt;** | Subcategories of the event. | [optional] 
**booking_questions** | **Array&lt;String&gt;** | Questions related to booking the event. | [optional] 

