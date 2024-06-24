# SwaggerClient::ToursAndActivitiesVariantSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**variant_id** | **String** | Unique identifier for the tour variant. | [optional] 
**supplier_variant_id** | **String** | Identifier given by the supplier for the variant. | [optional] 
**variant_index** | **Integer** | Index of the variant for ordering. | [optional] 
**variant_tax** | [**BigDecimal**](BigDecimal.md) | Tax applied to the variant price. | [optional] 
**variant_price** | [**BigDecimal**](BigDecimal.md) | Price of the tour variant. | [optional] 
**variant_currency** | **String** | Currency of the variant price. | [optional] 
**variant_cancellation_policies** | **String** | Cancellation policies applicable to the tour variant. | [optional] 
**date** | **Date** | Date of the tour. | [optional] 
**start_time** | **String** | Start time of the tour. | [optional] 
**adults** | **Integer** | Number of adults for the tour. | [optional] 
**children** | **Integer** | Number of children for the tour. | [optional] 
**variant_name** | **String** | Name of the tour variant. | [optional] 
**variant_description** | **String** | Description of the tour variant. | [optional] 
**variant_address** | **String** | Address where the tour variant takes place. | [optional] 
**variant_latitude** | **Float** | Latitude coordinate of the tour location. | [optional] 
**variant_longitude** | **Float** | Longitude coordinate of the tour location. | [optional] 
**variant_distance** | [**BigDecimal**](BigDecimal.md) | Distance covered during the tour. | [optional] 
**variant_distance_metric** | **String** | Metric used for distance measurement (miles or kilometers). | [optional] 
**variant_images** | **Array&lt;String&gt;** | Array of images related to the tour variant. | [optional] 
**variant_rating** | [**BigDecimal**](BigDecimal.md) | Rating of the tour variant. | [optional] 
**variant_reviews** | **Array&lt;String&gt;** | Collection of reviews for the tour variant. | [optional] 
**variant_subcategories** | **Array&lt;String&gt;** | Subcategories of the tour variant. | [optional] 
**booking_questions** | **Array&lt;String&gt;** | Questions related to booking the tour variant. | [optional] 

