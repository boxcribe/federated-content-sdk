# SwaggerClient::ToursAndActivitiesOfferDetailsSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **String** | Identifier of the individual offer. | [optional] 
**supplier_offer_id** | **String** | Identifier provided by the supplier for the offer. | [optional] 
**offer_index** | **Integer** | Index of the offer for ordering. | [optional] 
**offer_tax** | [**BigDecimal**](BigDecimal.md) | Tax applied on the offer. | [optional] 
**offer_price** | [**BigDecimal**](BigDecimal.md) | Price of the offer. | [optional] 
**offer_currency** | **String** | Currency of the offer price. | [optional] 
**offer_cancelation_policies** | **String** | Cancellation policies applicable to the offer. | [optional] 
**date** | **Date** | Date of the tour. | [optional] 
**adults** | **Integer** | Number of adults attending. | [optional] 
**children** | **Integer** | Number of children attending. | [optional] 
**tour_name** | **String** | Name of the tour. | [optional] 
**tour_description** | **String** | Description of the tour. | [optional] 
**tour_address** | **String** | Address where the tour will take place. | [optional] 
**tour_latitude** | **Float** | Latitude for the tour location. | [optional] 
**tour_longitude** | **Float** | Longitude for the tour location. | [optional] 
**tour_distance** | **Float** | Distance covered by the tour. | [optional] 
**tour_distance_metric** | **String** | Metric for measuring distance (miles or kilometers). | [optional] 
**tour_images** | **Array&lt;String&gt;** | Array of images related to the tour. | [optional] 
**tour_rating** | **Float** | Rating of the tour. | [optional] 
**tour_reviews** | **Array&lt;String&gt;** | Array of reviews for the tour. | [optional] 
**tour_subcategories** | **Array&lt;String&gt;** | Subcategories of the tour. | [optional] 
**booking_questions** | **Array&lt;String&gt;** | Questions related to booking the tour. | [optional] 
**variants** | [**Array&lt;ToursAndActivitiesVariantSchema&gt;**](ToursAndActivitiesVariantSchema.md) | Array of ToursAndActivitiesVariantSchema. | [optional] 

