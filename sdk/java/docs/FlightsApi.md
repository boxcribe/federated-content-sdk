# FlightsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**flightsBookingsBookingIdCancelPost**](FlightsApi.md#flightsBookingsBookingIdCancelPost) | **POST** /flights/bookings/{bookingId}/cancel | Cancel Booking
[**flightsBookingsBookingIdGet**](FlightsApi.md#flightsBookingsBookingIdGet) | **GET** /flights/bookings/{bookingId} | Get Booking Details
[**flightsBookingsPost**](FlightsApi.md#flightsBookingsPost) | **POST** /flights/bookings | Create Booking
[**flightsOffersOfferIdGet**](FlightsApi.md#flightsOffersOfferIdGet) | **GET** /flights/offers/{offerId} | Get Offer Details
[**flightsOffersOfferIdSeatmapsGet**](FlightsApi.md#flightsOffersOfferIdSeatmapsGet) | **GET** /flights/offers/{offerId}/seatmaps | Get Offer Seatmaps
[**flightsOffersSearchPost**](FlightsApi.md#flightsOffersSearchPost) | **POST** /flights/offers/search | Search Offers

<a name="flightsBookingsBookingIdCancelPost"></a>
# **flightsBookingsBookingIdCancelPost**
> FlightCancelBookingResponseSchema flightsBookingsBookingIdCancelPost(body)

Cancel Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FlightsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

FlightsApi apiInstance = new FlightsApi();
FlightCancelBookingRequestSchema body = new FlightCancelBookingRequestSchema(); // FlightCancelBookingRequestSchema | 
try {
    FlightCancelBookingResponseSchema result = apiInstance.flightsBookingsBookingIdCancelPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling FlightsApi#flightsBookingsBookingIdCancelPost");
    e.printStackTrace();
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

<a name="flightsBookingsBookingIdGet"></a>
# **flightsBookingsBookingIdGet**
> FlightGetBookingDetailsResponseSchema flightsBookingsBookingIdGet(body)

Get Booking Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FlightsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

FlightsApi apiInstance = new FlightsApi();
FlightBookingDetailsRequestSchema body = new FlightBookingDetailsRequestSchema(); // FlightBookingDetailsRequestSchema | 
try {
    FlightGetBookingDetailsResponseSchema result = apiInstance.flightsBookingsBookingIdGet(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling FlightsApi#flightsBookingsBookingIdGet");
    e.printStackTrace();
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

<a name="flightsBookingsPost"></a>
# **flightsBookingsPost**
> FlightBookingResponseSchema flightsBookingsPost(body)

Create Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FlightsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

FlightsApi apiInstance = new FlightsApi();
FlightCreateBookingRequestSchema body = new FlightCreateBookingRequestSchema(); // FlightCreateBookingRequestSchema | 
try {
    FlightBookingResponseSchema result = apiInstance.flightsBookingsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling FlightsApi#flightsBookingsPost");
    e.printStackTrace();
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

<a name="flightsOffersOfferIdGet"></a>
# **flightsOffersOfferIdGet**
> FlightOfferDetailsResponseSchema flightsOffersOfferIdGet(body)

Get Offer Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FlightsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

FlightsApi apiInstance = new FlightsApi();
FlightOfferDetailsRequestSchema body = new FlightOfferDetailsRequestSchema(); // FlightOfferDetailsRequestSchema | 
try {
    FlightOfferDetailsResponseSchema result = apiInstance.flightsOffersOfferIdGet(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling FlightsApi#flightsOffersOfferIdGet");
    e.printStackTrace();
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

<a name="flightsOffersOfferIdSeatmapsGet"></a>
# **flightsOffersOfferIdSeatmapsGet**
> FlightOfferSeatmapsResponseSchema flightsOffersOfferIdSeatmapsGet(body)

Get Offer Seatmaps

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FlightsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

FlightsApi apiInstance = new FlightsApi();
FlightOfferSeatmapsRequestSchema body = new FlightOfferSeatmapsRequestSchema(); // FlightOfferSeatmapsRequestSchema | 
try {
    FlightOfferSeatmapsResponseSchema result = apiInstance.flightsOffersOfferIdSeatmapsGet(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling FlightsApi#flightsOffersOfferIdSeatmapsGet");
    e.printStackTrace();
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

<a name="flightsOffersSearchPost"></a>
# **flightsOffersSearchPost**
> FlightOfferResponseSchema flightsOffersSearchPost(body)

Search Offers

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FlightsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

FlightsApi apiInstance = new FlightsApi();
FlightOfferRequestSchema body = new FlightOfferRequestSchema(); // FlightOfferRequestSchema | 
try {
    FlightOfferResponseSchema result = apiInstance.flightsOffersSearchPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling FlightsApi#flightsOffersSearchPost");
    e.printStackTrace();
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

