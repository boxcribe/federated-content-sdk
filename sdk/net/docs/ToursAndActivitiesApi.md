# IO.Swagger.Api.ToursAndActivitiesApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ToursBookingsBookingIdCancelPost**](ToursAndActivitiesApi.md#toursbookingsbookingidcancelpost) | **POST** /tours/bookings/{bookingId}/cancel | Cancel Booking
[**ToursBookingsBookingIdGet**](ToursAndActivitiesApi.md#toursbookingsbookingidget) | **GET** /tours/bookings/{bookingId} | Get Booking Details
[**ToursBookingsPost**](ToursAndActivitiesApi.md#toursbookingspost) | **POST** /tours/bookings | Create Booking
[**ToursOfferAvailabilityOfferIdPost**](ToursAndActivitiesApi.md#toursofferavailabilityofferidpost) | **POST** /tours/offer_availability/{offerId} | Get Offer Availability
[**ToursOffersOfferIdGet**](ToursAndActivitiesApi.md#toursoffersofferidget) | **GET** /tours/offers/{offerId} | Get Offer Details
[**ToursOffersSearchPost**](ToursAndActivitiesApi.md#toursofferssearchpost) | **POST** /tours/offers/search | Search Offers

<a name="toursbookingsbookingidcancelpost"></a>
# **ToursBookingsBookingIdCancelPost**
> ToursAndActivitiesCancelBookingResponseSchema ToursBookingsBookingIdCancelPost (ToursAndActivitiesCancelBookingRequestSchema body, string bookingId)

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
    public class ToursBookingsBookingIdCancelPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ToursAndActivitiesApi();
            var body = new ToursAndActivitiesCancelBookingRequestSchema(); // ToursAndActivitiesCancelBookingRequestSchema | 
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Cancel Booking
                ToursAndActivitiesCancelBookingResponseSchema result = apiInstance.ToursBookingsBookingIdCancelPost(body, bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToursAndActivitiesApi.ToursBookingsBookingIdCancelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesCancelBookingRequestSchema**](ToursAndActivitiesCancelBookingRequestSchema.md)|  | 
 **bookingId** | **string**|  | 

### Return type

[**ToursAndActivitiesCancelBookingResponseSchema**](ToursAndActivitiesCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toursbookingsbookingidget"></a>
# **ToursBookingsBookingIdGet**
> ToursAndActivitiesBookingDetailsResponseSchema ToursBookingsBookingIdGet (string bookingId)

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
    public class ToursBookingsBookingIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ToursAndActivitiesApi();
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Get Booking Details
                ToursAndActivitiesBookingDetailsResponseSchema result = apiInstance.ToursBookingsBookingIdGet(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToursAndActivitiesApi.ToursBookingsBookingIdGet: " + e.Message );
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

[**ToursAndActivitiesBookingDetailsResponseSchema**](ToursAndActivitiesBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toursbookingspost"></a>
# **ToursBookingsPost**
> ToursAndActivitiesBookingResponseSchema ToursBookingsPost (ToursAndActivitiesCreateBookingRequestSchema body)

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
    public class ToursBookingsPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ToursAndActivitiesApi();
            var body = new ToursAndActivitiesCreateBookingRequestSchema(); // ToursAndActivitiesCreateBookingRequestSchema | 

            try
            {
                // Create Booking
                ToursAndActivitiesBookingResponseSchema result = apiInstance.ToursBookingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToursAndActivitiesApi.ToursBookingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesCreateBookingRequestSchema**](ToursAndActivitiesCreateBookingRequestSchema.md)|  | 

### Return type

[**ToursAndActivitiesBookingResponseSchema**](ToursAndActivitiesBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toursofferavailabilityofferidpost"></a>
# **ToursOfferAvailabilityOfferIdPost**
> ToursAndActivitiesGetOfferAvailabilityResponse ToursOfferAvailabilityOfferIdPost (ToursAndActivitiesGetOfferAvailabilityRequest body, string offerId)

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
    public class ToursOfferAvailabilityOfferIdPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ToursAndActivitiesApi();
            var body = new ToursAndActivitiesGetOfferAvailabilityRequest(); // ToursAndActivitiesGetOfferAvailabilityRequest | 
            var offerId = offerId_example;  // string | 

            try
            {
                // Get Offer Availability
                ToursAndActivitiesGetOfferAvailabilityResponse result = apiInstance.ToursOfferAvailabilityOfferIdPost(body, offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToursAndActivitiesApi.ToursOfferAvailabilityOfferIdPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesGetOfferAvailabilityRequest**](ToursAndActivitiesGetOfferAvailabilityRequest.md)|  | 
 **offerId** | **string**|  | 

### Return type

[**ToursAndActivitiesGetOfferAvailabilityResponse**](ToursAndActivitiesGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toursoffersofferidget"></a>
# **ToursOffersOfferIdGet**
> ToursAndActivitiesOfferDetailsSchema ToursOffersOfferIdGet (string offerId)

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
    public class ToursOffersOfferIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ToursAndActivitiesApi();
            var offerId = offerId_example;  // string | 

            try
            {
                // Get Offer Details
                ToursAndActivitiesOfferDetailsSchema result = apiInstance.ToursOffersOfferIdGet(offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToursAndActivitiesApi.ToursOffersOfferIdGet: " + e.Message );
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

[**ToursAndActivitiesOfferDetailsSchema**](ToursAndActivitiesOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toursofferssearchpost"></a>
# **ToursOffersSearchPost**
> ToursAndActivitiesOfferResponseSchema ToursOffersSearchPost (ToursAndActivitiesOfferRequestSchema body)

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
    public class ToursOffersSearchPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new ToursAndActivitiesApi();
            var body = new ToursAndActivitiesOfferRequestSchema(); // ToursAndActivitiesOfferRequestSchema | 

            try
            {
                // Search Offers
                ToursAndActivitiesOfferResponseSchema result = apiInstance.ToursOffersSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ToursAndActivitiesApi.ToursOffersSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesOfferRequestSchema**](ToursAndActivitiesOfferRequestSchema.md)|  | 

### Return type

[**ToursAndActivitiesOfferResponseSchema**](ToursAndActivitiesOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

