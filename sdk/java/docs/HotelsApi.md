# HotelsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**hotelsBookingsBookingIdCancelPost**](HotelsApi.md#hotelsBookingsBookingIdCancelPost) | **POST** /hotels/bookings/{bookingId}/cancel | Cancel Booking
[**hotelsBookingsBookingIdGet**](HotelsApi.md#hotelsBookingsBookingIdGet) | **GET** /hotels/bookings/{bookingId} | Get Booking Details
[**hotelsBookingsPost**](HotelsApi.md#hotelsBookingsPost) | **POST** /hotels/bookings | Create Booking
[**hotelsOfferAvailabilityOfferIdGet**](HotelsApi.md#hotelsOfferAvailabilityOfferIdGet) | **GET** /hotels/offer_availability/{offerId} | Get Offer Availability
[**hotelsOffersOfferIdGet**](HotelsApi.md#hotelsOffersOfferIdGet) | **GET** /hotels/offers/{offerId} | Get Offer Details
[**hotelsOffersSearchPost**](HotelsApi.md#hotelsOffersSearchPost) | **POST** /hotels/offers/search | Search Offers

<a name="hotelsBookingsBookingIdCancelPost"></a>
# **hotelsBookingsBookingIdCancelPost**
> HotelCancelBookingResponseSchema hotelsBookingsBookingIdCancelPost(body, bookingId)

Cancel Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.HotelsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

HotelsApi apiInstance = new HotelsApi();
HotelCancelBookingRequestSchema body = new HotelCancelBookingRequestSchema(); // HotelCancelBookingRequestSchema | 
String bookingId = "bookingId_example"; // String | 
try {
    HotelCancelBookingResponseSchema result = apiInstance.hotelsBookingsBookingIdCancelPost(body, bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling HotelsApi#hotelsBookingsBookingIdCancelPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelCancelBookingRequestSchema**](HotelCancelBookingRequestSchema.md)|  |
 **bookingId** | **String**|  |

### Return type

[**HotelCancelBookingResponseSchema**](HotelCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="hotelsBookingsBookingIdGet"></a>
# **hotelsBookingsBookingIdGet**
> HotelBookingDetailsResponseSchema hotelsBookingsBookingIdGet(bookingId)

Get Booking Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.HotelsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

HotelsApi apiInstance = new HotelsApi();
String bookingId = "bookingId_example"; // String | 
try {
    HotelBookingDetailsResponseSchema result = apiInstance.hotelsBookingsBookingIdGet(bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling HotelsApi#hotelsBookingsBookingIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **String**|  |

### Return type

[**HotelBookingDetailsResponseSchema**](HotelBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="hotelsBookingsPost"></a>
# **hotelsBookingsPost**
> HotelBookingResponseSchema hotelsBookingsPost(body)

Create Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.HotelsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

HotelsApi apiInstance = new HotelsApi();
HotelCreateBookingRequestSchema body = new HotelCreateBookingRequestSchema(); // HotelCreateBookingRequestSchema | 
try {
    HotelBookingResponseSchema result = apiInstance.hotelsBookingsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling HotelsApi#hotelsBookingsPost");
    e.printStackTrace();
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

<a name="hotelsOfferAvailabilityOfferIdGet"></a>
# **hotelsOfferAvailabilityOfferIdGet**
> HotelGetOfferAvailabilityResponse hotelsOfferAvailabilityOfferIdGet(body, offerId)

Get Offer Availability

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.HotelsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

HotelsApi apiInstance = new HotelsApi();
HotelGetOfferAvailabilityRequest body = new HotelGetOfferAvailabilityRequest(); // HotelGetOfferAvailabilityRequest | 
String offerId = "offerId_example"; // String | 
try {
    HotelGetOfferAvailabilityResponse result = apiInstance.hotelsOfferAvailabilityOfferIdGet(body, offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling HotelsApi#hotelsOfferAvailabilityOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelGetOfferAvailabilityRequest**](HotelGetOfferAvailabilityRequest.md)|  |
 **offerId** | **String**|  |

### Return type

[**HotelGetOfferAvailabilityResponse**](HotelGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="hotelsOffersOfferIdGet"></a>
# **hotelsOffersOfferIdGet**
> HotelOfferDetailsSchema hotelsOffersOfferIdGet(offerId)

Get Offer Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.HotelsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

HotelsApi apiInstance = new HotelsApi();
String offerId = "offerId_example"; // String | 
try {
    HotelOfferDetailsSchema result = apiInstance.hotelsOffersOfferIdGet(offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling HotelsApi#hotelsOffersOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offerId** | **String**|  |

### Return type

[**HotelOfferDetailsSchema**](HotelOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="hotelsOffersSearchPost"></a>
# **hotelsOffersSearchPost**
> HotelOfferResponseSchema hotelsOffersSearchPost(body)

Search Offers

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.HotelsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

HotelsApi apiInstance = new HotelsApi();
HotelOfferRequestSchema body = new HotelOfferRequestSchema(); // HotelOfferRequestSchema | 
try {
    HotelOfferResponseSchema result = apiInstance.hotelsOffersSearchPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling HotelsApi#hotelsOffersSearchPost");
    e.printStackTrace();
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

