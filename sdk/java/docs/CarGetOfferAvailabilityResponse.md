# CarGetOfferAvailabilityResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**offerId** | [**UUID**](UUID.md) | Unique identifier for the car offer. |  [optional]
**supplierOfferId** | [**UUID**](UUID.md) | Unique identifier for the supplier’s offer. |  [optional]
**offerIndex** | **Integer** | Index of the offer for sorting purposes. |  [optional]
**offerTax** | **Double** | Tax applied to the offer. |  [optional]
**offerPrice** | **Double** | Price of the offer. |  [optional]
**offerCurrency** | **String** | Currency of the offer price. |  [optional]
**offerCancelationPolicies** | **Map&lt;String, Object&gt;** | Cancellation policies applicable to the offer. |  [optional]
**pickupDate** | [**LocalDate**](LocalDate.md) | Scheduled date for car pickup. |  [optional]
**pickupTime** | **String** | Scheduled time for car pickup. |  [optional]
**dropoffDate** | [**LocalDate**](LocalDate.md) | Scheduled date for car dropoff. |  [optional]
**dropoffTime** | **String** | Scheduled time for car dropoff. |  [optional]
**carName** | **String** | Name of the car model. |  [optional]
**carDescription** | **String** | Description of the car. |  [optional]
**carAddress** | **String** | Address where the car can be picked up. |  [optional]
**carLatitude** | **Float** | Latitude of the car pickup location. |  [optional]
**carLongitude** | **Float** | Longitude of the car pickup location. |  [optional]
**carDistance** | [**BigDecimal**](BigDecimal.md) | Distance the car can be driven. |  [optional]
**carDistanceMetric** | **String** | Metric system used for car distance (miles/km). |  [optional]
**carImages** | **List&lt;String&gt;** | Array of images of the car. |  [optional]
**carRating** | **Double** | Rating of the car based on user reviews. |  [optional]
**carReviews** | **Integer** | Number of reviews for the car. |  [optional]
**carType** | **String** | Type of the car (e.g., sedan, SUV). |  [optional]
**carClass** | **String** | Class of the car (e.g., economy, luxury). |  [optional]
**carCompany** | **String** | Company owning the car or rental service. |  [optional]
**carCompanyLogo** | **String** | Logo of the company owning the car. |  [optional]
**carPassengersNumber** | **Integer** | Number of passengers the car can hold. |  [optional]
**carBagsNumber** | **Integer** | Number of bags the car can hold. |  [optional]