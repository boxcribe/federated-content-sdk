# IO.Swagger.Api.TransportsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TransportsBookingsBookingIdCancelPost**](TransportsApi.md#transportsbookingsbookingidcancelpost) | **POST** /transports/bookings/{bookingId}/cancel | Cancel Booking
[**TransportsBookingsBookingIdGet**](TransportsApi.md#transportsbookingsbookingidget) | **GET** /transports/bookings/{bookingId} | Get Booking Details
[**TransportsBookingsPost**](TransportsApi.md#transportsbookingspost) | **POST** /transports/bookings | Create Booking
[**TransportsOfferAvailabilityOfferIdGet**](TransportsApi.md#transportsofferavailabilityofferidget) | **GET** /transports/offer_availability/{offerId} | Get Offer Availability
[**TransportsOffersOfferIdGet**](TransportsApi.md#transportsoffersofferidget) | **GET** /transports/offers/{offerId} | Get Offer Details
[**TransportsOffersSearchPost**](TransportsApi.md#transportsofferssearchpost) | **POST** /transports/offers/search | Search Offers

<a name="transportsbookingsbookingidcancelpost"></a>
# **TransportsBookingsBookingIdCancelPost**
> TransportCancelBookingResponseSchema TransportsBookingsBookingIdCancelPost (TransportCancelBookingRequestSchema body, string bookingId)

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
    public class TransportsBookingsBookingIdCancelPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new TransportsApi();
            var body = new TransportCancelBookingRequestSchema(); // TransportCancelBookingRequestSchema | 
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Cancel Booking
                TransportCancelBookingResponseSchema result = apiInstance.TransportsBookingsBookingIdCancelPost(body, bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransportsApi.TransportsBookingsBookingIdCancelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportCancelBookingRequestSchema**](TransportCancelBookingRequestSchema.md)|  | 
 **bookingId** | **string**|  | 

### Return type

[**TransportCancelBookingResponseSchema**](TransportCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transportsbookingsbookingidget"></a>
# **TransportsBookingsBookingIdGet**
> TransportBookingDetailsResponseSchema TransportsBookingsBookingIdGet (string bookingId)

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
    public class TransportsBookingsBookingIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new TransportsApi();
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Get Booking Details
                TransportBookingDetailsResponseSchema result = apiInstance.TransportsBookingsBookingIdGet(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransportsApi.TransportsBookingsBookingIdGet: " + e.Message );
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

[**TransportBookingDetailsResponseSchema**](TransportBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transportsbookingspost"></a>
# **TransportsBookingsPost**
> TransportBookingResponseSchema TransportsBookingsPost (TransportCreateBookingRequestSchema body)

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
    public class TransportsBookingsPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new TransportsApi();
            var body = new TransportCreateBookingRequestSchema(); // TransportCreateBookingRequestSchema | 

            try
            {
                // Create Booking
                TransportBookingResponseSchema result = apiInstance.TransportsBookingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransportsApi.TransportsBookingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportCreateBookingRequestSchema**](TransportCreateBookingRequestSchema.md)|  | 

### Return type

[**TransportBookingResponseSchema**](TransportBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transportsofferavailabilityofferidget"></a>
# **TransportsOfferAvailabilityOfferIdGet**
> TransportGetOfferAvailabilityResponse TransportsOfferAvailabilityOfferIdGet (TransportGetOfferAvailabilityRequest body, string offerId)

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
    public class TransportsOfferAvailabilityOfferIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new TransportsApi();
            var body = new TransportGetOfferAvailabilityRequest(); // TransportGetOfferAvailabilityRequest | 
            var offerId = offerId_example;  // string | 

            try
            {
                // Get Offer Availability
                TransportGetOfferAvailabilityResponse result = apiInstance.TransportsOfferAvailabilityOfferIdGet(body, offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransportsApi.TransportsOfferAvailabilityOfferIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportGetOfferAvailabilityRequest**](TransportGetOfferAvailabilityRequest.md)|  | 
 **offerId** | **string**|  | 

### Return type

[**TransportGetOfferAvailabilityResponse**](TransportGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transportsoffersofferidget"></a>
# **TransportsOffersOfferIdGet**
> TransportOfferDetailsSchema TransportsOffersOfferIdGet (string offerId)

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
    public class TransportsOffersOfferIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new TransportsApi();
            var offerId = offerId_example;  // string | 

            try
            {
                // Get Offer Details
                TransportOfferDetailsSchema result = apiInstance.TransportsOffersOfferIdGet(offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransportsApi.TransportsOffersOfferIdGet: " + e.Message );
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

[**TransportOfferDetailsSchema**](TransportOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transportsofferssearchpost"></a>
# **TransportsOffersSearchPost**
> TransportOfferResponseSchema TransportsOffersSearchPost (TransportOfferRequestSchema body)

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
    public class TransportsOffersSearchPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new TransportsApi();
            var body = new TransportOfferRequestSchema(); // TransportOfferRequestSchema | 

            try
            {
                // Search Offers
                TransportOfferResponseSchema result = apiInstance.TransportsOffersSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransportsApi.TransportsOffersSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportOfferRequestSchema**](TransportOfferRequestSchema.md)|  | 

### Return type

[**TransportOfferResponseSchema**](TransportOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

