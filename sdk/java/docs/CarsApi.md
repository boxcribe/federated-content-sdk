# CarsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**carsBookingsBookingIdCancelPost**](CarsApi.md#carsBookingsBookingIdCancelPost) | **POST** /cars/bookings/{bookingId}/cancel | Cancel Booking
[**carsBookingsBookingIdGet**](CarsApi.md#carsBookingsBookingIdGet) | **GET** /cars/bookings/{bookingId} | Get Booking Details
[**carsBookingsPost**](CarsApi.md#carsBookingsPost) | **POST** /cars/bookings | Create Booking
[**carsOfferAvailabilityOfferIdGet**](CarsApi.md#carsOfferAvailabilityOfferIdGet) | **GET** /cars/offer_availability/{offerId} | Get Offer Availability
[**carsOffersOfferIdGet**](CarsApi.md#carsOffersOfferIdGet) | **GET** /cars/offers/{offerId} | Get Offer Details
[**carsOffersSearchPost**](CarsApi.md#carsOffersSearchPost) | **POST** /cars/offers/search | Search Offers

<a name="carsBookingsBookingIdCancelPost"></a>
# **carsBookingsBookingIdCancelPost**
> CarCancelBookingResponseSchema carsBookingsBookingIdCancelPost(body, bookingId)

Cancel Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CarsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

CarsApi apiInstance = new CarsApi();
CarCancelBookingRequestSchema body = new CarCancelBookingRequestSchema(); // CarCancelBookingRequestSchema | 
String bookingId = "bookingId_example"; // String | 
try {
    CarCancelBookingResponseSchema result = apiInstance.carsBookingsBookingIdCancelPost(body, bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CarsApi#carsBookingsBookingIdCancelPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarCancelBookingRequestSchema**](CarCancelBookingRequestSchema.md)|  |
 **bookingId** | **String**|  |

### Return type

[**CarCancelBookingResponseSchema**](CarCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="carsBookingsBookingIdGet"></a>
# **carsBookingsBookingIdGet**
> CarBookingDetailsResponseSchema carsBookingsBookingIdGet(bookingId)

Get Booking Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CarsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

CarsApi apiInstance = new CarsApi();
String bookingId = "bookingId_example"; // String | 
try {
    CarBookingDetailsResponseSchema result = apiInstance.carsBookingsBookingIdGet(bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CarsApi#carsBookingsBookingIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **String**|  |

### Return type

[**CarBookingDetailsResponseSchema**](CarBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="carsBookingsPost"></a>
# **carsBookingsPost**
> CarBookingResponseSchema carsBookingsPost(body)

Create Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CarsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

CarsApi apiInstance = new CarsApi();
CarCreateBookingRequestSchema body = new CarCreateBookingRequestSchema(); // CarCreateBookingRequestSchema | 
try {
    CarBookingResponseSchema result = apiInstance.carsBookingsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CarsApi#carsBookingsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarCreateBookingRequestSchema**](CarCreateBookingRequestSchema.md)|  |

### Return type

[**CarBookingResponseSchema**](CarBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="carsOfferAvailabilityOfferIdGet"></a>
# **carsOfferAvailabilityOfferIdGet**
> CarGetOfferAvailabilityResponse carsOfferAvailabilityOfferIdGet(body, offerId)

Get Offer Availability

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CarsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

CarsApi apiInstance = new CarsApi();
CarGetOfferAvailabilityRequest body = new CarGetOfferAvailabilityRequest(); // CarGetOfferAvailabilityRequest | 
String offerId = "offerId_example"; // String | 
try {
    CarGetOfferAvailabilityResponse result = apiInstance.carsOfferAvailabilityOfferIdGet(body, offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CarsApi#carsOfferAvailabilityOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarGetOfferAvailabilityRequest**](CarGetOfferAvailabilityRequest.md)|  |
 **offerId** | **String**|  |

### Return type

[**CarGetOfferAvailabilityResponse**](CarGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="carsOffersOfferIdGet"></a>
# **carsOffersOfferIdGet**
> CarOfferDetailsSchema carsOffersOfferIdGet(offerId)

Get Offer Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CarsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

CarsApi apiInstance = new CarsApi();
String offerId = "offerId_example"; // String | 
try {
    CarOfferDetailsSchema result = apiInstance.carsOffersOfferIdGet(offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CarsApi#carsOffersOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offerId** | **String**|  |

### Return type

[**CarOfferDetailsSchema**](CarOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="carsOffersSearchPost"></a>
# **carsOffersSearchPost**
> CarOfferResponseSchema carsOffersSearchPost(body)

Search Offers

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CarsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

CarsApi apiInstance = new CarsApi();
CarOfferRequestSchema body = new CarOfferRequestSchema(); // CarOfferRequestSchema | 
try {
    CarOfferResponseSchema result = apiInstance.carsOffersSearchPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CarsApi#carsOffersSearchPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarOfferRequestSchema**](CarOfferRequestSchema.md)|  |

### Return type

[**CarOfferResponseSchema**](CarOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

