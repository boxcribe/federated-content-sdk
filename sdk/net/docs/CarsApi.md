# IO.Swagger.Api.CarsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CarsBookingsBookingIdCancelPost**](CarsApi.md#carsbookingsbookingidcancelpost) | **POST** /cars/bookings/{bookingId}/cancel | Cancel Booking
[**CarsBookingsBookingIdGet**](CarsApi.md#carsbookingsbookingidget) | **GET** /cars/bookings/{bookingId} | Get Booking Details
[**CarsBookingsPost**](CarsApi.md#carsbookingspost) | **POST** /cars/bookings | Create Booking
[**CarsOfferAvailabilityOfferIdGet**](CarsApi.md#carsofferavailabilityofferidget) | **GET** /cars/offer_availability/{offerId} | Get Offer Availability
[**CarsOffersOfferIdGet**](CarsApi.md#carsoffersofferidget) | **GET** /cars/offers/{offerId} | Get Offer Details
[**CarsOffersSearchPost**](CarsApi.md#carsofferssearchpost) | **POST** /cars/offers/search | Search Offers

<a name="carsbookingsbookingidcancelpost"></a>
# **CarsBookingsBookingIdCancelPost**
> CarCancelBookingResponseSchema CarsBookingsBookingIdCancelPost (CarCancelBookingRequestSchema body, string bookingId)

Cancel Booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarsBookingsBookingIdCancelPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new CarsApi();
            var body = new CarCancelBookingRequestSchema(); // CarCancelBookingRequestSchema | 
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Cancel Booking
                CarCancelBookingResponseSchema result = apiInstance.CarsBookingsBookingIdCancelPost(body, bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarsApi.CarsBookingsBookingIdCancelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarCancelBookingRequestSchema**](CarCancelBookingRequestSchema.md)|  | 
 **bookingId** | **string**|  | 

### Return type

[**CarCancelBookingResponseSchema**](CarCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carsbookingsbookingidget"></a>
# **CarsBookingsBookingIdGet**
> CarBookingDetailsResponseSchema CarsBookingsBookingIdGet (string bookingId)

Get Booking Details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarsBookingsBookingIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new CarsApi();
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Get Booking Details
                CarBookingDetailsResponseSchema result = apiInstance.CarsBookingsBookingIdGet(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarsApi.CarsBookingsBookingIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **string**|  | 

### Return type

[**CarBookingDetailsResponseSchema**](CarBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carsbookingspost"></a>
# **CarsBookingsPost**
> CarBookingResponseSchema CarsBookingsPost (CarCreateBookingRequestSchema body)

Create Booking

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarsBookingsPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new CarsApi();
            var body = new CarCreateBookingRequestSchema(); // CarCreateBookingRequestSchema | 

            try
            {
                // Create Booking
                CarBookingResponseSchema result = apiInstance.CarsBookingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarsApi.CarsBookingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarCreateBookingRequestSchema**](CarCreateBookingRequestSchema.md)|  | 

### Return type

[**CarBookingResponseSchema**](CarBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carsofferavailabilityofferidget"></a>
# **CarsOfferAvailabilityOfferIdGet**
> CarGetOfferAvailabilityResponse CarsOfferAvailabilityOfferIdGet (CarGetOfferAvailabilityRequest body, string offerId)

Get Offer Availability

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarsOfferAvailabilityOfferIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new CarsApi();
            var body = new CarGetOfferAvailabilityRequest(); // CarGetOfferAvailabilityRequest | 
            var offerId = offerId_example;  // string | 

            try
            {
                // Get Offer Availability
                CarGetOfferAvailabilityResponse result = apiInstance.CarsOfferAvailabilityOfferIdGet(body, offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarsApi.CarsOfferAvailabilityOfferIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarGetOfferAvailabilityRequest**](CarGetOfferAvailabilityRequest.md)|  | 
 **offerId** | **string**|  | 

### Return type

[**CarGetOfferAvailabilityResponse**](CarGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carsoffersofferidget"></a>
# **CarsOffersOfferIdGet**
> CarOfferDetailsSchema CarsOffersOfferIdGet (string offerId)

Get Offer Details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarsOffersOfferIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new CarsApi();
            var offerId = offerId_example;  // string | 

            try
            {
                // Get Offer Details
                CarOfferDetailsSchema result = apiInstance.CarsOffersOfferIdGet(offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarsApi.CarsOffersOfferIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offerId** | **string**|  | 

### Return type

[**CarOfferDetailsSchema**](CarOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="carsofferssearchpost"></a>
# **CarsOffersSearchPost**
> CarOfferResponseSchema CarsOffersSearchPost (CarOfferRequestSchema body)

Search Offers

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CarsOffersSearchPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new CarsApi();
            var body = new CarOfferRequestSchema(); // CarOfferRequestSchema | 

            try
            {
                // Search Offers
                CarOfferResponseSchema result = apiInstance.CarsOffersSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CarsApi.CarsOffersSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarOfferRequestSchema**](CarOfferRequestSchema.md)|  | 

### Return type

[**CarOfferResponseSchema**](CarOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

