# ToursAndActivitiesOfferDetailsSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **string** | Identifier of the individual offer. | [optional] 
**supplier_offer_id** | **string** | Identifier provided by the supplier for the offer. | [optional] 
**offer_index** | **int** | Index of the offer for ordering. | [optional] 
**offer_tax** | **float** | Tax applied on the offer. | [optional] 
**offer_price** | **float** | Price of the offer. | [optional] 
**offer_currency** | **string** | Currency of the offer price. | [optional] 
**offer_cancelation_policies** | **string** | Cancellation policies applicable to the offer. | [optional] 
**date** | [**\DateTime**](\DateTime.md) | Date of the tour. | [optional] 
**adults** | **int** | Number of adults attending. | [optional] 
**children** | **int** | Number of children attending. | [optional] 
**tour_name** | **string** | Name of the tour. | [optional] 
**tour_description** | **string** | Description of the tour. | [optional] 
**tour_address** | **string** | Address where the tour will take place. | [optional] 
**tour_latitude** | **float** | Latitude for the tour location. | [optional] 
**tour_longitude** | **float** | Longitude for the tour location. | [optional] 
**tour_distance** | **float** | Distance covered by the tour. | [optional] 
**tour_distance_metric** | **string** | Metric for measuring distance (miles or kilometers). | [optional] 
**tour_images** | **string[]** | Array of images related to the tour. | [optional] 
**tour_rating** | **float** | Rating of the tour. | [optional] 
**tour_reviews** | **string[]** | Array of reviews for the tour. | [optional] 
**tour_subcategories** | **string[]** | Subcategories of the tour. | [optional] 
**booking_questions** | **string[]** | Questions related to booking the tour. | [optional] 
**variants** | [**\Swagger\Client\Model\ToursAndActivitiesVariantSchema[]**](ToursAndActivitiesVariantSchema.md) | Array of ToursAndActivitiesVariantSchema. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

