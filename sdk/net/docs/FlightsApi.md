# IO.Swagger.Api.FlightsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FlightsBookingsBookingIdCancelPost**](FlightsApi.md#flightsbookingsbookingidcancelpost) | **POST** /flights/bookings/{bookingId}/cancel | Cancel Booking
[**FlightsBookingsBookingIdGet**](FlightsApi.md#flightsbookingsbookingidget) | **GET** /flights/bookings/{bookingId} | Get Booking Details
[**FlightsBookingsPost**](FlightsApi.md#flightsbookingspost) | **POST** /flights/bookings | Create Booking
[**FlightsOffersOfferIdGet**](FlightsApi.md#flightsoffersofferidget) | **GET** /flights/offers/{offerId} | Get Offer Details
[**FlightsOffersOfferIdSeatmapsGet**](FlightsApi.md#flightsoffersofferidseatmapsget) | **GET** /flights/offers/{offerId}/seatmaps | Get Offer Seatmaps
[**FlightsOffersSearchPost**](FlightsApi.md#flightsofferssearchpost) | **POST** /flights/offers/search | Search Offers

<a name="flightsbookingsbookingidcancelpost"></a>
# **FlightsBookingsBookingIdCancelPost**
> FlightCancelBookingResponseSchema FlightsBookingsBookingIdCancelPost (FlightCancelBookingRequestSchema body)

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
    public class FlightsBookingsBookingIdCancelPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new FlightsApi();
            var body = new FlightCancelBookingRequestSchema(); // FlightCancelBookingRequestSchema | 

            try
            {
                // Cancel Booking
                FlightCancelBookingResponseSchema result = apiInstance.FlightsBookingsBookingIdCancelPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightsApi.FlightsBookingsBookingIdCancelPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightCancelBookingRequestSchema**](FlightCancelBookingRequestSchema.md)|  | 

### Return type

[**FlightCancelBookingResponseSchema**](FlightCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="flightsbookingsbookingidget"></a>
# **FlightsBookingsBookingIdGet**
> FlightGetBookingDetailsResponseSchema FlightsBookingsBookingIdGet (FlightBookingDetailsRequestSchema body)

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
    public class FlightsBookingsBookingIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new FlightsApi();
            var body = new FlightBookingDetailsRequestSchema(); // FlightBookingDetailsRequestSchema | 

            try
            {
                // Get Booking Details
                FlightGetBookingDetailsResponseSchema result = apiInstance.FlightsBookingsBookingIdGet(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightsApi.FlightsBookingsBookingIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightBookingDetailsRequestSchema**](FlightBookingDetailsRequestSchema.md)|  | 

### Return type

[**FlightGetBookingDetailsResponseSchema**](FlightGetBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="flightsbookingspost"></a>
# **FlightsBookingsPost**
> FlightBookingResponseSchema FlightsBookingsPost (FlightCreateBookingRequestSchema body)

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
    public class FlightsBookingsPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new FlightsApi();
            var body = new FlightCreateBookingRequestSchema(); // FlightCreateBookingRequestSchema | 

            try
            {
                // Create Booking
                FlightBookingResponseSchema result = apiInstance.FlightsBookingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightsApi.FlightsBookingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightCreateBookingRequestSchema**](FlightCreateBookingRequestSchema.md)|  | 

### Return type

[**FlightBookingResponseSchema**](FlightBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="flightsoffersofferidget"></a>
# **FlightsOffersOfferIdGet**
> FlightOfferDetailsResponseSchema FlightsOffersOfferIdGet (FlightOfferDetailsRequestSchema body)

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
    public class FlightsOffersOfferIdGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new FlightsApi();
            var body = new FlightOfferDetailsRequestSchema(); // FlightOfferDetailsRequestSchema | 

            try
            {
                // Get Offer Details
                FlightOfferDetailsResponseSchema result = apiInstance.FlightsOffersOfferIdGet(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightsApi.FlightsOffersOfferIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightOfferDetailsRequestSchema**](FlightOfferDetailsRequestSchema.md)|  | 

### Return type

[**FlightOfferDetailsResponseSchema**](FlightOfferDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="flightsoffersofferidseatmapsget"></a>
# **FlightsOffersOfferIdSeatmapsGet**
> FlightOfferSeatmapsResponseSchema FlightsOffersOfferIdSeatmapsGet (FlightOfferSeatmapsRequestSchema body)

Get Offer Seatmaps

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FlightsOffersOfferIdSeatmapsGetExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new FlightsApi();
            var body = new FlightOfferSeatmapsRequestSchema(); // FlightOfferSeatmapsRequestSchema | 

            try
            {
                // Get Offer Seatmaps
                FlightOfferSeatmapsResponseSchema result = apiInstance.FlightsOffersOfferIdSeatmapsGet(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightsApi.FlightsOffersOfferIdSeatmapsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightOfferSeatmapsRequestSchema**](FlightOfferSeatmapsRequestSchema.md)|  | 

### Return type

[**FlightOfferSeatmapsResponseSchema**](FlightOfferSeatmapsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="flightsofferssearchpost"></a>
# **FlightsOffersSearchPost**
> FlightOfferResponseSchema FlightsOffersSearchPost (FlightOfferRequestSchema body)

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
    public class FlightsOffersSearchPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new FlightsApi();
            var body = new FlightOfferRequestSchema(); // FlightOfferRequestSchema | 

            try
            {
                // Search Offers
                FlightOfferResponseSchema result = apiInstance.FlightsOffersSearchPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FlightsApi.FlightsOffersSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightOfferRequestSchema**](FlightOfferRequestSchema.md)|  | 

### Return type

[**FlightOfferResponseSchema**](FlightOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

