# EventsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventsBookingsBookingIdCancelPost**](EventsApi.md#eventsBookingsBookingIdCancelPost) | **POST** /events/bookings/{bookingId}/cancel | Cancel Booking
[**eventsBookingsBookingIdGet**](EventsApi.md#eventsBookingsBookingIdGet) | **GET** /events/bookings/{bookingId} | Get Booking Details
[**eventsBookingsPost**](EventsApi.md#eventsBookingsPost) | **POST** /events/bookings | Create Booking
[**eventsOfferAvailabilityOfferIdGet**](EventsApi.md#eventsOfferAvailabilityOfferIdGet) | **GET** /events/offer_availability/{offerId} | Get Offer Availability
[**eventsOffersOfferIdGet**](EventsApi.md#eventsOffersOfferIdGet) | **GET** /events/offers/{offerId} | Get Offer Details
[**eventsOffersSearchPost**](EventsApi.md#eventsOffersSearchPost) | **POST** /events/offers/search | Search Offers

<a name="eventsBookingsBookingIdCancelPost"></a>
# **eventsBookingsBookingIdCancelPost**
> EventCancelBookingResponseSchema eventsBookingsBookingIdCancelPost(body, bookingId)

Cancel Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.EventsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

EventsApi apiInstance = new EventsApi();
EventCancelBookingRequestSchema body = new EventCancelBookingRequestSchema(); // EventCancelBookingRequestSchema | 
String bookingId = "bookingId_example"; // String | 
try {
    EventCancelBookingResponseSchema result = apiInstance.eventsBookingsBookingIdCancelPost(body, bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EventsApi#eventsBookingsBookingIdCancelPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventCancelBookingRequestSchema**](EventCancelBookingRequestSchema.md)|  |
 **bookingId** | **String**|  |

### Return type

[**EventCancelBookingResponseSchema**](EventCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="eventsBookingsBookingIdGet"></a>
# **eventsBookingsBookingIdGet**
> EventBookingDetailsResponseSchema eventsBookingsBookingIdGet(bookingId)

Get Booking Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.EventsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

EventsApi apiInstance = new EventsApi();
String bookingId = "bookingId_example"; // String | 
try {
    EventBookingDetailsResponseSchema result = apiInstance.eventsBookingsBookingIdGet(bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EventsApi#eventsBookingsBookingIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **String**|  |

### Return type

[**EventBookingDetailsResponseSchema**](EventBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="eventsBookingsPost"></a>
# **eventsBookingsPost**
> EventBookingResponseSchema eventsBookingsPost(body)

Create Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.EventsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

EventsApi apiInstance = new EventsApi();
EventCreateBookingRequestSchema body = new EventCreateBookingRequestSchema(); // EventCreateBookingRequestSchema | 
try {
    EventBookingResponseSchema result = apiInstance.eventsBookingsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EventsApi#eventsBookingsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventCreateBookingRequestSchema**](EventCreateBookingRequestSchema.md)|  |

### Return type

[**EventBookingResponseSchema**](EventBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="eventsOfferAvailabilityOfferIdGet"></a>
# **eventsOfferAvailabilityOfferIdGet**
> EventGetOfferAvailabilityResponse eventsOfferAvailabilityOfferIdGet(body, offerId)

Get Offer Availability

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.EventsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

EventsApi apiInstance = new EventsApi();
EventGetOfferAvailabilityRequest body = new EventGetOfferAvailabilityRequest(); // EventGetOfferAvailabilityRequest | 
String offerId = "offerId_example"; // String | 
try {
    EventGetOfferAvailabilityResponse result = apiInstance.eventsOfferAvailabilityOfferIdGet(body, offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EventsApi#eventsOfferAvailabilityOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventGetOfferAvailabilityRequest**](EventGetOfferAvailabilityRequest.md)|  |
 **offerId** | **String**|  |

### Return type

[**EventGetOfferAvailabilityResponse**](EventGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="eventsOffersOfferIdGet"></a>
# **eventsOffersOfferIdGet**
> EventOfferDetailsSchema eventsOffersOfferIdGet(offerId)

Get Offer Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.EventsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

EventsApi apiInstance = new EventsApi();
String offerId = "offerId_example"; // String | 
try {
    EventOfferDetailsSchema result = apiInstance.eventsOffersOfferIdGet(offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EventsApi#eventsOffersOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offerId** | **String**|  |

### Return type

[**EventOfferDetailsSchema**](EventOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="eventsOffersSearchPost"></a>
# **eventsOffersSearchPost**
> EventOfferResponseSchema eventsOffersSearchPost(body)

Search Offers

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.EventsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

EventsApi apiInstance = new EventsApi();
EventOfferRequestSchema body = new EventOfferRequestSchema(); // EventOfferRequestSchema | 
try {
    EventOfferResponseSchema result = apiInstance.eventsOffersSearchPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling EventsApi#eventsOffersSearchPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventOfferRequestSchema**](EventOfferRequestSchema.md)|  |

### Return type

[**EventOfferResponseSchema**](EventOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

