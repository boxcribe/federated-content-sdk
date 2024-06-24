# DiningApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**diningBookingsBookingIdCancelPost**](DiningApi.md#diningBookingsBookingIdCancelPost) | **POST** /dining/bookings/{bookingId}/cancel | Cancel Booking
[**diningBookingsBookingIdGet**](DiningApi.md#diningBookingsBookingIdGet) | **GET** /dining/bookings/{bookingId} | Get Booking Details
[**diningBookingsPost**](DiningApi.md#diningBookingsPost) | **POST** /dining/bookings | Create Booking
[**diningOfferAvailabilityOfferIdGet**](DiningApi.md#diningOfferAvailabilityOfferIdGet) | **GET** /dining/offer_availability/{offerId} | Get Offer Availability
[**diningOffersOfferIdGet**](DiningApi.md#diningOffersOfferIdGet) | **GET** /dining/offers/{offerId} | Get Offer Details
[**diningOffersSearchPost**](DiningApi.md#diningOffersSearchPost) | **POST** /dining/offers/search | Search Offers

<a name="diningBookingsBookingIdCancelPost"></a>
# **diningBookingsBookingIdCancelPost**
> DiningCancelBookingResponseSchema diningBookingsBookingIdCancelPost(body, bookingId)

Cancel Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.DiningApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

DiningApi apiInstance = new DiningApi();
DiningCancelBookingRequestSchema body = new DiningCancelBookingRequestSchema(); // DiningCancelBookingRequestSchema | 
String bookingId = "bookingId_example"; // String | 
try {
    DiningCancelBookingResponseSchema result = apiInstance.diningBookingsBookingIdCancelPost(body, bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DiningApi#diningBookingsBookingIdCancelPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningCancelBookingRequestSchema**](DiningCancelBookingRequestSchema.md)|  |
 **bookingId** | **String**|  |

### Return type

[**DiningCancelBookingResponseSchema**](DiningCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="diningBookingsBookingIdGet"></a>
# **diningBookingsBookingIdGet**
> DiningBookingDetailsResponseSchema diningBookingsBookingIdGet(bookingId)

Get Booking Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.DiningApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

DiningApi apiInstance = new DiningApi();
String bookingId = "bookingId_example"; // String | 
try {
    DiningBookingDetailsResponseSchema result = apiInstance.diningBookingsBookingIdGet(bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DiningApi#diningBookingsBookingIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **String**|  |

### Return type

[**DiningBookingDetailsResponseSchema**](DiningBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="diningBookingsPost"></a>
# **diningBookingsPost**
> DiningBookingResponseSchema diningBookingsPost(body)

Create Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.DiningApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

DiningApi apiInstance = new DiningApi();
DiningCreateBookingRequestSchema body = new DiningCreateBookingRequestSchema(); // DiningCreateBookingRequestSchema | 
try {
    DiningBookingResponseSchema result = apiInstance.diningBookingsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DiningApi#diningBookingsPost");
    e.printStackTrace();
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

<a name="diningOfferAvailabilityOfferIdGet"></a>
# **diningOfferAvailabilityOfferIdGet**
> DiningGetOfferAvailabilityResponse diningOfferAvailabilityOfferIdGet(body, offerId)

Get Offer Availability

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.DiningApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

DiningApi apiInstance = new DiningApi();
DiningGetOfferAvailabilityRequest body = new DiningGetOfferAvailabilityRequest(); // DiningGetOfferAvailabilityRequest | 
String offerId = "offerId_example"; // String | 
try {
    DiningGetOfferAvailabilityResponse result = apiInstance.diningOfferAvailabilityOfferIdGet(body, offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DiningApi#diningOfferAvailabilityOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningGetOfferAvailabilityRequest**](DiningGetOfferAvailabilityRequest.md)|  |
 **offerId** | **String**|  |

### Return type

[**DiningGetOfferAvailabilityResponse**](DiningGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="diningOffersOfferIdGet"></a>
# **diningOffersOfferIdGet**
> DiningOfferDetailsSchema diningOffersOfferIdGet(offerId)

Get Offer Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.DiningApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

DiningApi apiInstance = new DiningApi();
String offerId = "offerId_example"; // String | 
try {
    DiningOfferDetailsSchema result = apiInstance.diningOffersOfferIdGet(offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DiningApi#diningOffersOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offerId** | **String**|  |

### Return type

[**DiningOfferDetailsSchema**](DiningOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="diningOffersSearchPost"></a>
# **diningOffersSearchPost**
> DiningOfferResponseSchema diningOffersSearchPost(body)

Search Offers

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.DiningApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

DiningApi apiInstance = new DiningApi();
DiningOfferRequestSchema body = new DiningOfferRequestSchema(); // DiningOfferRequestSchema | 
try {
    DiningOfferResponseSchema result = apiInstance.diningOffersSearchPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DiningApi#diningOffersSearchPost");
    e.printStackTrace();
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

