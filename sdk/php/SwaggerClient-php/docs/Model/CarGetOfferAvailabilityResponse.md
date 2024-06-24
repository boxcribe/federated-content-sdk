# CarGetOfferAvailabilityResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **string** | Unique identifier for the car offer. | [optional] 
**supplier_offer_id** | **string** | Unique identifier for the supplier’s offer. | [optional] 
**offer_index** | **int** | Index of the offer for sorting purposes. | [optional] 
**offer_tax** | **double** | Tax applied to the offer. | [optional] 
**offer_price** | **double** | Price of the offer. | [optional] 
**offer_currency** | **string** | Currency of the offer price. | [optional] 
**offer_cancelation_policies** | **map[string,object]** | Cancellation policies applicable to the offer. | [optional] 
**pickup_date** | [**\DateTime**](\DateTime.md) | Scheduled date for car pickup. | [optional] 
**pickup_time** | **string** | Scheduled time for car pickup. | [optional] 
**dropoff_date** | [**\DateTime**](\DateTime.md) | Scheduled date for car dropoff. | [optional] 
**dropoff_time** | **string** | Scheduled time for car dropoff. | [optional] 
**car_name** | **string** | Name of the car model. | [optional] 
**car_description** | **string** | Description of the car. | [optional] 
**car_address** | **string** | Address where the car can be picked up. | [optional] 
**car_latitude** | **float** | Latitude of the car pickup location. | [optional] 
**car_longitude** | **float** | Longitude of the car pickup location. | [optional] 
**car_distance** | **float** | Distance the car can be driven. | [optional] 
**car_distance_metric** | **string** | Metric system used for car distance (miles/km). | [optional] 
**car_images** | **string[]** | Array of images of the car. | [optional] 
**car_rating** | **double** | Rating of the car based on user reviews. | [optional] 
**car_reviews** | **int** | Number of reviews for the car. | [optional] 
**car_type** | **string** | Type of the car (e.g., sedan, SUV). | [optional] 
**car_class** | **string** | Class of the car (e.g., economy, luxury). | [optional] 
**car_company** | **string** | Company owning the car or rental service. | [optional] 
**car_company_logo** | **string** | Logo of the company owning the car. | [optional] 
**car_passengers_number** | **int** | Number of passengers the car can hold. | [optional] 
**car_bags_number** | **int** | Number of bags the car can hold. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

