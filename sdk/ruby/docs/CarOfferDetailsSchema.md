# SwaggerClient::CarOfferDetailsSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offer_id** | **String** | Unique identifier for the car offer. | [optional] 
**supplier_offer_id** | **String** | Unique identifier for the supplier’s offer. | [optional] 
**offer_index** | **Integer** | Index of the offer for sorting purposes. | [optional] 
**offer_tax** | [**BigDecimal**](BigDecimal.md) | Tax applied to the offer. | [optional] 
**offer_price** | [**BigDecimal**](BigDecimal.md) | Price of the offer. | [optional] 
**offer_currency** | **String** | Currency of the offer price. | [optional] 
**offer_cancelation_policies** | **Object** | Cancellation policies applicable to the offer. | [optional] 
**pickup_date** | **Date** | Scheduled date for car pickup. | [optional] 
**pickup_time** | **String** | Scheduled time for car pickup. | [optional] 
**dropoff_date** | **Date** | Scheduled date for car dropoff. | [optional] 
**dropoff_time** | **String** | Scheduled time for car dropoff. | [optional] 
**car_name** | **String** | Name of the car model. | [optional] 
**car_description** | **String** | Description of the car. | [optional] 
**car_address** | **String** | Address where the car can be picked up. | [optional] 
**car_latitude** | **Float** | Latitude of the car pickup location. | [optional] 
**car_longitude** | **Float** | Longitude of the car pickup location. | [optional] 
**car_distance** | **Integer** | Distance the car can be driven. | [optional] 
**car_distance_metric** | **String** | Metric system used for car distance (miles/km). | [optional] 
**car_images** | **Array&lt;String&gt;** | Array of images of the car. | [optional] 
**car_rating** | [**BigDecimal**](BigDecimal.md) | Rating of the car based on user reviews. | [optional] 
**car_reviews** | **Integer** | Number of reviews for the car. | [optional] 
**car_type** | **String** | Type of the car (e.g., sedan, SUV). | [optional] 
**car_class** | **String** | Class of the car (e.g., economy, luxury). | [optional] 
**car_company** | **String** | Company owning the car or rental service. | [optional] 
**car_company_logo** | **String** | Logo of the company owning the car. | [optional] 
**car_passengers_number** | **Integer** | Number of passengers the car can hold. | [optional] 
**car_bags_number** | **Integer** | Number of bags the car can hold. | [optional] 

