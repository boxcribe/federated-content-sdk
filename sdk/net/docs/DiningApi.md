# IO.Swagger.Api.DiningApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DiningBookingsBookingIdCancelPost**](DiningApi.md#diningbookingsbookingidcancelpost) | **POST** /dining/bookings/{bookingId}/cancel | Cancel Booking
[**DiningBookingsBookingIdGet**](DiningApi.md#diningbookingsbookingidget) | **GET** /dining/bookings/{bookingId} | Get Booking Details
[**DiningBookingsPost**](DiningApi.md#diningbookingspost) | **POST** /dining/bookings | Create Booking
[**DiningOfferAvailabilityOfferIdGet**](DiningApi.md#diningofferavailabilityofferidget) | **GET** /dining/offer_availability/{offerId} | Get Offer Availability
[**DiningOffersOfferIdGet**](DiningApi.md#diningoffersofferidget) | **GET** /dining/offers/{offerId} | Get Offer Details
[**DiningOffersSearchPost**](DiningApi.md#diningofferssearchpost) | **POST** /dining/offers/search | Search Offers

<a name="diningbookingsbookingidcancelpost"></a>
# **DiningBookingsBookingIdCancelPost**
> DiningCancelBookingResponseSchema DiningBookingsBookingIdCancelPost (DiningCancelBookingRequestSchema body, string bookingId)

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
    public class DiningBookingsBookingIdCancelPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new DiningApi();
            var body = new DiningCancelBookingRequestSchema(); // DiningCancelBookingRequestSchema | 
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Cancel Booking
                DiningCancelBookingResponseSchema result = apiInstance.DiningBookingsBookingIdCancelPost(body, bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiningApi.DiningBookingsBookingIdCancelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningCancelBookingRequestSchema**](DiningCancelBookingRequestSchema.md)|  | 
 **bookingId** | **string**|  | 

### Return type

[**DiningCancelBookingResponseSchema**](DiningCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diningbookingsbookingidget"></a>
# **DiningBookingsBookingIdGet**
> DiningBookingDetailsResponseSchema DiningBookingsBookingIdGet (string bookingId)

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
    public class DiningBookingsBookingIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new DiningApi();
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Get Booking Details
                DiningBookingDetailsResponseSchema result = apiInstance.DiningBookingsBookingIdGet(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiningApi.DiningBookingsBookingIdGet: " + e.Message );
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

[**DiningBookingDetailsResponseSchema**](DiningBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diningbookingspost"></a>
# **DiningBookingsPost**
> DiningBookingResponseSchema DiningBookingsPost (DiningCreateBookingRequestSchema body)

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
    public class DiningBookingsPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new DiningApi();
            var body = new DiningCreateBookingRequestSchema(); // DiningCreateBookingRequestSchema | 

            try
            {
                // Create Booking
                DiningBookingResponseSchema result = apiInstance.DiningBookingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiningApi.DiningBookingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningCreateBookingRequestSchema**](DiningCreateBookingRequestSchema.md)|  | 

### Return type

[**DiningBookingResponseSchema**](DiningBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diningofferavailabilityofferidget"></a>
# **DiningOfferAvailabilityOfferIdGet**
> DiningGetOfferAvailabilityResponse DiningOfferAvailabilityOfferIdGet (DiningGetOfferAvailabilityRequest body, string offerId)

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
    public class DiningOfferAvailabilityOfferIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new DiningApi();
            var body = new DiningGetOfferAvailabilityRequest(); // DiningGetOfferAvailabilityRequest | 
            var offerId = offerId_example;  // string | 

            try
            {
                // Get Offer Availability
                DiningGetOfferAvailabilityResponse result = apiInstance.DiningOfferAvailabilityOfferIdGet(body, offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiningApi.DiningOfferAvailabilityOfferIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningGetOfferAvailabilityRequest**](DiningGetOfferAvailabilityRequest.md)|  | 
 **offerId** | **string**|  | 

### Return type

[**DiningGetOfferAvailabilityResponse**](DiningGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diningoffersofferidget"></a>
# **DiningOffersOfferIdGet**
> DiningOfferDetailsSchema DiningOffersOfferIdGet (string offerId)

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
    public class DiningOffersOfferIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new DiningApi();
            var offerId = offerId_example;  // string | 

            try
            {
                // Get Offer Details
                DiningOfferDetailsSchema result = apiInstance.DiningOffersOfferIdGet(offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiningApi.DiningOffersOfferIdGet: " + e.Message );
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

[**DiningOfferDetailsSchema**](DiningOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="diningofferssearchpost"></a>
# **DiningOffersSearchPost**
> DiningOfferResponseSchema DiningOffersSearchPost (DiningOfferRequestSchema body)

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
    public class DiningOffersSearchPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new DiningApi();
            var body = new DiningOfferRequestSchema(); // DiningOfferRequestSchema | 

            try
            {
                // Search Offers
                DiningOfferResponseSchema result = apiInstance.DiningOffersSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiningApi.DiningOffersSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningOfferRequestSchema**](DiningOfferRequestSchema.md)|  | 

### Return type

[**DiningOfferResponseSchema**](DiningOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

