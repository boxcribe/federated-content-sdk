# ToursAndActivitiesVariantSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**variant_id** | **string** | Unique identifier for the tour variant. | [optional] 
**supplier_variant_id** | **string** | Identifier given by the supplier for the variant. | [optional] 
**variant_index** | **int** | Index of the variant for ordering. | [optional] 
**variant_tax** | **float** | Tax applied to the variant price. | [optional] 
**variant_price** | **float** | Price of the tour variant. | [optional] 
**variant_currency** | **string** | Currency of the variant price. | [optional] 
**variant_cancellation_policies** | **string** | Cancellation policies applicable to the tour variant. | [optional] 
**date** | [**\DateTime**](\DateTime.md) | Date of the tour. | [optional] 
**start_time** | **string** | Start time of the tour. | [optional] 
**adults** | **int** | Number of adults for the tour. | [optional] 
**children** | **int** | Number of children for the tour. | [optional] 
**variant_name** | **string** | Name of the tour variant. | [optional] 
**variant_description** | **string** | Description of the tour variant. | [optional] 
**variant_address** | **string** | Address where the tour variant takes place. | [optional] 
**variant_latitude** | **float** | Latitude coordinate of the tour location. | [optional] 
**variant_longitude** | **float** | Longitude coordinate of the tour location. | [optional] 
**variant_distance** | **float** | Distance covered during the tour. | [optional] 
**variant_distance_metric** | **string** | Metric used for distance measurement (miles or kilometers). | [optional] 
**variant_images** | **string[]** | Array of images related to the tour variant. | [optional] 
**variant_rating** | **float** | Rating of the tour variant. | [optional] 
**variant_reviews** | **string[]** | Collection of reviews for the tour variant. | [optional] 
**variant_subcategories** | **string[]** | Subcategories of the tour variant. | [optional] 
**booking_questions** | **string[]** | Questions related to booking the tour variant. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

