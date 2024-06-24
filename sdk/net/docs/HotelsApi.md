# IO.Swagger.Api.HotelsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HotelsBookingsBookingIdCancelPost**](HotelsApi.md#hotelsbookingsbookingidcancelpost) | **POST** /hotels/bookings/{bookingId}/cancel | Cancel Booking
[**HotelsBookingsBookingIdGet**](HotelsApi.md#hotelsbookingsbookingidget) | **GET** /hotels/bookings/{bookingId} | Get Booking Details
[**HotelsBookingsPost**](HotelsApi.md#hotelsbookingspost) | **POST** /hotels/bookings | Create Booking
[**HotelsOfferAvailabilityOfferIdGet**](HotelsApi.md#hotelsofferavailabilityofferidget) | **GET** /hotels/offer_availability/{offerId} | Get Offer Availability
[**HotelsOffersOfferIdGet**](HotelsApi.md#hotelsoffersofferidget) | **GET** /hotels/offers/{offerId} | Get Offer Details
[**HotelsOffersSearchPost**](HotelsApi.md#hotelsofferssearchpost) | **POST** /hotels/offers/search | Search Offers

<a name="hotelsbookingsbookingidcancelpost"></a>
# **HotelsBookingsBookingIdCancelPost**
> HotelCancelBookingResponseSchema HotelsBookingsBookingIdCancelPost (HotelCancelBookingRequestSchema body, string bookingId)

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
    public class HotelsBookingsBookingIdCancelPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new HotelsApi();
            var body = new HotelCancelBookingRequestSchema(); // HotelCancelBookingRequestSchema | 
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Cancel Booking
                HotelCancelBookingResponseSchema result = apiInstance.HotelsBookingsBookingIdCancelPost(body, bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelsApi.HotelsBookingsBookingIdCancelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelCancelBookingRequestSchema**](HotelCancelBookingRequestSchema.md)|  | 
 **bookingId** | **string**|  | 

### Return type

[**HotelCancelBookingResponseSchema**](HotelCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hotelsbookingsbookingidget"></a>
# **HotelsBookingsBookingIdGet**
> HotelBookingDetailsResponseSchema HotelsBookingsBookingIdGet (string bookingId)

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
    public class HotelsBookingsBookingIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new HotelsApi();
            var bookingId = bookingId_example;  // string | 

            try
            {
                // Get Booking Details
                HotelBookingDetailsResponseSchema result = apiInstance.HotelsBookingsBookingIdGet(bookingId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelsApi.HotelsBookingsBookingIdGet: " + e.Message );
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

[**HotelBookingDetailsResponseSchema**](HotelBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hotelsbookingspost"></a>
# **HotelsBookingsPost**
> HotelBookingResponseSchema HotelsBookingsPost (HotelCreateBookingRequestSchema body)

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
    public class HotelsBookingsPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new HotelsApi();
            var body = new HotelCreateBookingRequestSchema(); // HotelCreateBookingRequestSchema | 

            try
            {
                // Create Booking
                HotelBookingResponseSchema result = apiInstance.HotelsBookingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelsApi.HotelsBookingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelCreateBookingRequestSchema**](HotelCreateBookingRequestSchema.md)|  | 

### Return type

[**HotelBookingResponseSchema**](HotelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hotelsofferavailabilityofferidget"></a>
# **HotelsOfferAvailabilityOfferIdGet**
> HotelGetOfferAvailabilityResponse HotelsOfferAvailabilityOfferIdGet (HotelGetOfferAvailabilityRequest body, string offerId)

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
    public class HotelsOfferAvailabilityOfferIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new HotelsApi();
            var body = new HotelGetOfferAvailabilityRequest(); // HotelGetOfferAvailabilityRequest | 
            var offerId = offerId_example;  // string | 

            try
            {
                // Get Offer Availability
                HotelGetOfferAvailabilityResponse result = apiInstance.HotelsOfferAvailabilityOfferIdGet(body, offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelsApi.HotelsOfferAvailabilityOfferIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelGetOfferAvailabilityRequest**](HotelGetOfferAvailabilityRequest.md)|  | 
 **offerId** | **string**|  | 

### Return type

[**HotelGetOfferAvailabilityResponse**](HotelGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hotelsoffersofferidget"></a>
# **HotelsOffersOfferIdGet**
> HotelOfferDetailsSchema HotelsOffersOfferIdGet (string offerId)

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
    public class HotelsOffersOfferIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new HotelsApi();
            var offerId = offerId_example;  // string | 

            try
            {
                // Get Offer Details
                HotelOfferDetailsSchema result = apiInstance.HotelsOffersOfferIdGet(offerId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelsApi.HotelsOffersOfferIdGet: " + e.Message );
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

[**HotelOfferDetailsSchema**](HotelOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hotelsofferssearchpost"></a>
# **HotelsOffersSearchPost**
> HotelOfferResponseSchema HotelsOffersSearchPost (HotelOfferRequestSchema body)

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
    public class HotelsOffersSearchPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new HotelsApi();
            var body = new HotelOfferRequestSchema(); // HotelOfferRequestSchema | 

            try
            {
                // Search Offers
                HotelOfferResponseSchema result = apiInstance.HotelsOffersSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HotelsApi.HotelsOffersSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelOfferRequestSchema**](HotelOfferRequestSchema.md)|  | 

### Return type

[**HotelOfferResponseSchema**](HotelOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

