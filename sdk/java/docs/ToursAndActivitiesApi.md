# ToursAndActivitiesApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**toursBookingsBookingIdCancelPost**](ToursAndActivitiesApi.md#toursBookingsBookingIdCancelPost) | **POST** /tours/bookings/{bookingId}/cancel | Cancel Booking
[**toursBookingsBookingIdGet**](ToursAndActivitiesApi.md#toursBookingsBookingIdGet) | **GET** /tours/bookings/{bookingId} | Get Booking Details
[**toursBookingsPost**](ToursAndActivitiesApi.md#toursBookingsPost) | **POST** /tours/bookings | Create Booking
[**toursOfferAvailabilityOfferIdPost**](ToursAndActivitiesApi.md#toursOfferAvailabilityOfferIdPost) | **POST** /tours/offer_availability/{offerId} | Get Offer Availability
[**toursOffersOfferIdGet**](ToursAndActivitiesApi.md#toursOffersOfferIdGet) | **GET** /tours/offers/{offerId} | Get Offer Details
[**toursOffersSearchPost**](ToursAndActivitiesApi.md#toursOffersSearchPost) | **POST** /tours/offers/search | Search Offers

<a name="toursBookingsBookingIdCancelPost"></a>
# **toursBookingsBookingIdCancelPost**
> ToursAndActivitiesCancelBookingResponseSchema toursBookingsBookingIdCancelPost(body, bookingId)

Cancel Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ToursAndActivitiesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

ToursAndActivitiesApi apiInstance = new ToursAndActivitiesApi();
ToursAndActivitiesCancelBookingRequestSchema body = new ToursAndActivitiesCancelBookingRequestSchema(); // ToursAndActivitiesCancelBookingRequestSchema | 
String bookingId = "bookingId_example"; // String | 
try {
    ToursAndActivitiesCancelBookingResponseSchema result = apiInstance.toursBookingsBookingIdCancelPost(body, bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ToursAndActivitiesApi#toursBookingsBookingIdCancelPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesCancelBookingRequestSchema**](ToursAndActivitiesCancelBookingRequestSchema.md)|  |
 **bookingId** | **String**|  |

### Return type

[**ToursAndActivitiesCancelBookingResponseSchema**](ToursAndActivitiesCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="toursBookingsBookingIdGet"></a>
# **toursBookingsBookingIdGet**
> ToursAndActivitiesBookingDetailsResponseSchema toursBookingsBookingIdGet(bookingId)

Get Booking Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ToursAndActivitiesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

ToursAndActivitiesApi apiInstance = new ToursAndActivitiesApi();
String bookingId = "bookingId_example"; // String | 
try {
    ToursAndActivitiesBookingDetailsResponseSchema result = apiInstance.toursBookingsBookingIdGet(bookingId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ToursAndActivitiesApi#toursBookingsBookingIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **bookingId** | **String**|  |

### Return type

[**ToursAndActivitiesBookingDetailsResponseSchema**](ToursAndActivitiesBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="toursBookingsPost"></a>
# **toursBookingsPost**
> ToursAndActivitiesBookingResponseSchema toursBookingsPost(body)

Create Booking

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ToursAndActivitiesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

ToursAndActivitiesApi apiInstance = new ToursAndActivitiesApi();
ToursAndActivitiesCreateBookingRequestSchema body = new ToursAndActivitiesCreateBookingRequestSchema(); // ToursAndActivitiesCreateBookingRequestSchema | 
try {
    ToursAndActivitiesBookingResponseSchema result = apiInstance.toursBookingsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ToursAndActivitiesApi#toursBookingsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesCreateBookingRequestSchema**](ToursAndActivitiesCreateBookingRequestSchema.md)|  |

### Return type

[**ToursAndActivitiesBookingResponseSchema**](ToursAndActivitiesBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="toursOfferAvailabilityOfferIdPost"></a>
# **toursOfferAvailabilityOfferIdPost**
> ToursAndActivitiesGetOfferAvailabilityResponse toursOfferAvailabilityOfferIdPost(body, offerId)

Get Offer Availability

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ToursAndActivitiesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

ToursAndActivitiesApi apiInstance = new ToursAndActivitiesApi();
ToursAndActivitiesGetOfferAvailabilityRequest body = new ToursAndActivitiesGetOfferAvailabilityRequest(); // ToursAndActivitiesGetOfferAvailabilityRequest | 
String offerId = "offerId_example"; // String | 
try {
    ToursAndActivitiesGetOfferAvailabilityResponse result = apiInstance.toursOfferAvailabilityOfferIdPost(body, offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ToursAndActivitiesApi#toursOfferAvailabilityOfferIdPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesGetOfferAvailabilityRequest**](ToursAndActivitiesGetOfferAvailabilityRequest.md)|  |
 **offerId** | **String**|  |

### Return type

[**ToursAndActivitiesGetOfferAvailabilityResponse**](ToursAndActivitiesGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="toursOffersOfferIdGet"></a>
# **toursOffersOfferIdGet**
> ToursAndActivitiesOfferDetailsSchema toursOffersOfferIdGet(offerId)

Get Offer Details

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ToursAndActivitiesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

ToursAndActivitiesApi apiInstance = new ToursAndActivitiesApi();
String offerId = "offerId_example"; // String | 
try {
    ToursAndActivitiesOfferDetailsSchema result = apiInstance.toursOffersOfferIdGet(offerId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ToursAndActivitiesApi#toursOffersOfferIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offerId** | **String**|  |

### Return type

[**ToursAndActivitiesOfferDetailsSchema**](ToursAndActivitiesOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="toursOffersSearchPost"></a>
# **toursOffersSearchPost**
> ToursAndActivitiesOfferResponseSchema toursOffersSearchPost(body)

Search Offers

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ToursAndActivitiesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

ToursAndActivitiesApi apiInstance = new ToursAndActivitiesApi();
ToursAndActivitiesOfferRequestSchema body = new ToursAndActivitiesOfferRequestSchema(); // ToursAndActivitiesOfferRequestSchema | 
try {
    ToursAndActivitiesOfferResponseSchema result = apiInstance.toursOffersSearchPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ToursAndActivitiesApi#toursOffersSearchPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesOfferRequestSchema**](ToursAndActivitiesOfferRequestSchema.md)|  |

### Return type

[**ToursAndActivitiesOfferResponseSchema**](ToursAndActivitiesOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

