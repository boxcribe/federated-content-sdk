# IO.Swagger.Model.CarOfferDetailsSchema
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **Guid?** | Unique identifier for the car offer. | [optional] 
**SupplierOfferId** | **Guid?** | Unique identifier for the supplier’s offer. | [optional] 
**OfferIndex** | **int?** | Index of the offer for sorting purposes. | [optional] 
**OfferTax** | [**decimal?**](BigDecimal.md) | Tax applied to the offer. | [optional] 
**OfferPrice** | [**decimal?**](BigDecimal.md) | Price of the offer. | [optional] 
**OfferCurrency** | **string** | Currency of the offer price. | [optional] 
**OfferCancelationPolicies** | **Object** | Cancellation policies applicable to the offer. | [optional] 
**PickupDate** | **DateTime?** | Scheduled date for car pickup. | [optional] 
**PickupTime** | **string** | Scheduled time for car pickup. | [optional] 
**DropoffDate** | **DateTime?** | Scheduled date for car dropoff. | [optional] 
**DropoffTime** | **string** | Scheduled time for car dropoff. | [optional] 
**CarName** | **string** | Name of the car model. | [optional] 
**CarDescription** | **string** | Description of the car. | [optional] 
**CarAddress** | **string** | Address where the car can be picked up. | [optional] 
**CarLatitude** | **float?** | Latitude of the car pickup location. | [optional] 
**CarLongitude** | **float?** | Longitude of the car pickup location. | [optional] 
**CarDistance** | **int?** | Distance the car can be driven. | [optional] 
**CarDistanceMetric** | **string** | Metric system used for car distance (miles/km). | [optional] 
**CarImages** | **List&lt;string&gt;** | Array of images of the car. | [optional] 
**CarRating** | [**decimal?**](BigDecimal.md) | Rating of the car based on user reviews. | [optional] 
**CarReviews** | **int?** | Number of reviews for the car. | [optional] 
**CarType** | **string** | Type of the car (e.g., sedan, SUV). | [optional] 
**CarClass** | **string** | Class of the car (e.g., economy, luxury). | [optional] 
**CarCompany** | **string** | Company owning the car or rental service. | [optional] 
**CarCompanyLogo** | **string** | Logo of the company owning the car. | [optional] 
**CarPassengersNumber** | **int?** | Number of passengers the car can hold. | [optional] 
**CarBagsNumber** | **int?** | Number of bags the car can hold. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

