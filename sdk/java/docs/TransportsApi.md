# TransportsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**transportsBookingsBookingIdCancelPost**](TransportsApi.md#transportsBookingsBookingIdCancelPost) | **POST** /transports/bookings/{bookingId}/cancel | Cancel Booking
[**transportsBookingsBookingIdGet**](TransportsApi.md#transportsBookingsBookingIdGet) | **GET** /transports/bookings/{bookingId} | Get Booking Details
[**transportsBookingsPost**](TransportsApi.md#transportsBookingsPost) | **POST** /transports/bookings | Create Booking
[**transportsOfferAvailabilityOfferIdGet**](TransportsApi.md#transportsOfferAvailabilityOfferIdGet) | **GET** /transports/offer_availability/{offerId} | Get Offer Availability
[**transportsOffersOfferIdGet**](TransportsApi.md#transportsOffersOfferIdGet) | **GET** /transports/offers/{offerId} | Get Offer Details
[**transportsOffersSearchPost**](TransportsApi.md#transportsOffersSearchPost) | **POST** /transports/offers/search | Search Offers

<a name="transportsBookingsBookingIdCancelPost"></a>
# **transportsBookingsBookingIdCancelPost**
> TransportCancelBookingResponseSchema transportsBookingsBookingIdCancelPost(body, bookingId)

Cancel Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TransportsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

TransportsApi apiInstance = new TransportsApi();
TransportCancelBookingRequestSchema body = new TransportCancelBookingRequestSchema(); // TransportCancelBookingRequestSchema | 
String bookingId = "bookingId_example"; // String | 
try {
    TransportCancelBookingResponseSchema result = apiInstance.transportsBookingsBookingIdCancelPost(body, bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TransportsApi#transportsBookingsBookingIdCancelPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportCancelBookingRequestSchema**](TransportCancelBookingRequestSchema.md)|  |
 **bookingId** | **String**|  |

### Return type

[**TransportCancelBookingResponseSchema**](TransportCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="transportsBookingsBookingIdGet"></a>
# **transportsBookingsBookingIdGet**
> TransportBookingDetailsResponseSchema transportsBookingsBookingIdGet(bookingId)

Get Booking Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TransportsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

TransportsApi apiInstance = new TransportsApi();
String bookingId = "bookingId_example"; // String | 
try {
    TransportBookingDetailsResponseSchema result = apiInstance.transportsBookingsBookingIdGet(bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TransportsApi#transportsBookingsBookingIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **String**|  |

### Return type

[**TransportBookingDetailsResponseSchema**](TransportBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="transportsBookingsPost"></a>
# **transportsBookingsPost**
> TransportBookingResponseSchema transportsBookingsPost(body)

Create Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TransportsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

TransportsApi apiInstance = new TransportsApi();
TransportCreateBookingRequestSchema body = new TransportCreateBookingRequestSchema(); // TransportCreateBookingRequestSchema | 
try {
    TransportBookingResponseSchema result = apiInstance.transportsBookingsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TransportsApi#transportsBookingsPost");
    e.printStackTrace();
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

<a name="transportsOfferAvailabilityOfferIdGet"></a>
# **transportsOfferAvailabilityOfferIdGet**
> TransportGetOfferAvailabilityResponse transportsOfferAvailabilityOfferIdGet(body, offerId)

Get Offer Availability

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TransportsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

TransportsApi apiInstance = new TransportsApi();
TransportGetOfferAvailabilityRequest body = new TransportGetOfferAvailabilityRequest(); // TransportGetOfferAvailabilityRequest | 
String offerId = "offerId_example"; // String | 
try {
    TransportGetOfferAvailabilityResponse result = apiInstance.transportsOfferAvailabilityOfferIdGet(body, offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TransportsApi#transportsOfferAvailabilityOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportGetOfferAvailabilityRequest**](TransportGetOfferAvailabilityRequest.md)|  |
 **offerId** | **String**|  |

### Return type

[**TransportGetOfferAvailabilityResponse**](TransportGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="transportsOffersOfferIdGet"></a>
# **transportsOffersOfferIdGet**
> TransportOfferDetailsSchema transportsOffersOfferIdGet(offerId)

Get Offer Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TransportsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

TransportsApi apiInstance = new TransportsApi();
String offerId = "offerId_example"; // String | 
try {
    TransportOfferDetailsSchema result = apiInstance.transportsOffersOfferIdGet(offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TransportsApi#transportsOffersOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offerId** | **String**|  |

### Return type

[**TransportOfferDetailsSchema**](TransportOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="transportsOffersSearchPost"></a>
# **transportsOffersSearchPost**
> TransportOfferResponseSchema transportsOffersSearchPost(body)

Search Offers

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TransportsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

TransportsApi apiInstance = new TransportsApi();
TransportOfferRequestSchema body = new TransportOfferRequestSchema(); // TransportOfferRequestSchema | 
try {
    TransportOfferResponseSchema result = apiInstance.transportsOffersSearchPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TransportsApi#transportsOffersSearchPost");
    e.printStackTrace();
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

