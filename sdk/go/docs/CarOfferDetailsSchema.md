# CarOfferDetailsSchema

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OfferId** | **string** | Unique identifier for the car offer. | [optional] [default to null]
**SupplierOfferId** | **string** | Unique identifier for the supplier’s offer. | [optional] [default to null]
**OfferIndex** | **int32** | Index of the offer for sorting purposes. | [optional] [default to null]
**OfferTax** | **float64** | Tax applied to the offer. | [optional] [default to null]
**OfferPrice** | **float64** | Price of the offer. | [optional] [default to null]
**OfferCurrency** | **string** | Currency of the offer price. | [optional] [default to null]
**OfferCancelationPolicies** | [***interface{}**](interface{}.md) | Cancellation policies applicable to the offer. | [optional] [default to null]
**PickupDate** | **string** | Scheduled date for car pickup. | [optional] [default to null]
**PickupTime** | **string** | Scheduled time for car pickup. | [optional] [default to null]
**DropoffDate** | **string** | Scheduled date for car dropoff. | [optional] [default to null]
**DropoffTime** | **string** | Scheduled time for car dropoff. | [optional] [default to null]
**CarName** | **string** | Name of the car model. | [optional] [default to null]
**CarDescription** | **string** | Description of the car. | [optional] [default to null]
**CarAddress** | **string** | Address where the car can be picked up. | [optional] [default to null]
**CarLatitude** | **float32** | Latitude of the car pickup location. | [optional] [default to null]
**CarLongitude** | **float32** | Longitude of the car pickup location. | [optional] [default to null]
**CarDistance** | **int32** | Distance the car can be driven. | [optional] [default to null]
**CarDistanceMetric** | **string** | Metric system used for car distance (miles/km). | [optional] [default to null]
**CarImages** | **[]string** | Array of images of the car. | [optional] [default to null]
**CarRating** | **float64** | Rating of the car based on user reviews. | [optional] [default to null]
**CarReviews** | **int32** | Number of reviews for the car. | [optional] [default to null]
**CarType** | **string** | Type of the car (e.g., sedan, SUV). | [optional] [default to null]
**CarClass** | **string** | Class of the car (e.g., economy, luxury). | [optional] [default to null]
**CarCompany** | **string** | Company owning the car or rental service. | [optional] [default to null]
**CarCompanyLogo** | **string** | Logo of the company owning the car. | [optional] [default to null]
**CarPassengersNumber** | **int32** | Number of passengers the car can hold. | [optional] [default to null]
**CarBagsNumber** | **int32** | Number of bags the car can hold. | [optional] [default to null]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

