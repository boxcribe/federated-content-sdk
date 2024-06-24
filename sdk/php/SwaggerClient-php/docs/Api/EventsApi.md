# Swagger\Client\EventsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**eventsBookingsBookingIdCancelPost**](EventsApi.md#eventsbookingsbookingidcancelpost) | **POST** /events/bookings/{bookingId}/cancel | Cancel Booking
[**eventsBookingsBookingIdGet**](EventsApi.md#eventsbookingsbookingidget) | **GET** /events/bookings/{bookingId} | Get Booking Details
[**eventsBookingsPost**](EventsApi.md#eventsbookingspost) | **POST** /events/bookings | Create Booking
[**eventsOfferAvailabilityOfferIdGet**](EventsApi.md#eventsofferavailabilityofferidget) | **GET** /events/offer_availability/{offerId} | Get Offer Availability
[**eventsOffersOfferIdGet**](EventsApi.md#eventsoffersofferidget) | **GET** /events/offers/{offerId} | Get Offer Details
[**eventsOffersSearchPost**](EventsApi.md#eventsofferssearchpost) | **POST** /events/offers/search | Search Offers

# **eventsBookingsBookingIdCancelPost**
> \Swagger\Client\Model\EventCancelBookingResponseSchema eventsBookingsBookingIdCancelPost($body, $booking_id)

Cancel Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\EventCancelBookingRequestSchema(); // \Swagger\Client\Model\EventCancelBookingRequestSchema | 
$booking_id = "booking_id_example"; // string | 

try {
    $result = $apiInstance->eventsBookingsBookingIdCancelPost($body, $booking_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsBookingsBookingIdCancelPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\EventCancelBookingRequestSchema**](../Model/EventCancelBookingRequestSchema.md)|  |
 **booking_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\EventCancelBookingResponseSchema**](../Model/EventCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **eventsBookingsBookingIdGet**
> \Swagger\Client\Model\EventBookingDetailsResponseSchema eventsBookingsBookingIdGet($booking_id)

Get Booking Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$booking_id = "booking_id_example"; // string | 

try {
    $result = $apiInstance->eventsBookingsBookingIdGet($booking_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsBookingsBookingIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\EventBookingDetailsResponseSchema**](../Model/EventBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **eventsBookingsPost**
> \Swagger\Client\Model\EventBookingResponseSchema eventsBookingsPost($body)

Create Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\EventCreateBookingRequestSchema(); // \Swagger\Client\Model\EventCreateBookingRequestSchema | 

try {
    $result = $apiInstance->eventsBookingsPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsBookingsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\EventCreateBookingRequestSchema**](../Model/EventCreateBookingRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\EventBookingResponseSchema**](../Model/EventBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **eventsOfferAvailabilityOfferIdGet**
> \Swagger\Client\Model\EventGetOfferAvailabilityResponse eventsOfferAvailabilityOfferIdGet($body, $offer_id)

Get Offer Availability

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\EventGetOfferAvailabilityRequest(); // \Swagger\Client\Model\EventGetOfferAvailabilityRequest | 
$offer_id = "offer_id_example"; // string | 

try {
    $result = $apiInstance->eventsOfferAvailabilityOfferIdGet($body, $offer_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsOfferAvailabilityOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\EventGetOfferAvailabilityRequest**](../Model/EventGetOfferAvailabilityRequest.md)|  |
 **offer_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\EventGetOfferAvailabilityResponse**](../Model/EventGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **eventsOffersOfferIdGet**
> \Swagger\Client\Model\EventOfferDetailsSchema eventsOffersOfferIdGet($offer_id)

Get Offer Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$offer_id = "offer_id_example"; // string | 

try {
    $result = $apiInstance->eventsOffersOfferIdGet($offer_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsOffersOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\EventOfferDetailsSchema**](../Model/EventOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **eventsOffersSearchPost**
> \Swagger\Client\Model\EventOfferResponseSchema eventsOffersSearchPost($body)

Search Offers

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\EventsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\EventOfferRequestSchema(); // \Swagger\Client\Model\EventOfferRequestSchema | 

try {
    $result = $apiInstance->eventsOffersSearchPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling EventsApi->eventsOffersSearchPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\EventOfferRequestSchema**](../Model/EventOfferRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\EventOfferResponseSchema**](../Model/EventOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

