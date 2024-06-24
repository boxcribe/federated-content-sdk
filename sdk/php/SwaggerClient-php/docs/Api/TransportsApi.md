# Swagger\Client\TransportsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**transportsBookingsBookingIdCancelPost**](TransportsApi.md#transportsbookingsbookingidcancelpost) | **POST** /transports/bookings/{bookingId}/cancel | Cancel Booking
[**transportsBookingsBookingIdGet**](TransportsApi.md#transportsbookingsbookingidget) | **GET** /transports/bookings/{bookingId} | Get Booking Details
[**transportsBookingsPost**](TransportsApi.md#transportsbookingspost) | **POST** /transports/bookings | Create Booking
[**transportsOfferAvailabilityOfferIdGet**](TransportsApi.md#transportsofferavailabilityofferidget) | **GET** /transports/offer_availability/{offerId} | Get Offer Availability
[**transportsOffersOfferIdGet**](TransportsApi.md#transportsoffersofferidget) | **GET** /transports/offers/{offerId} | Get Offer Details
[**transportsOffersSearchPost**](TransportsApi.md#transportsofferssearchpost) | **POST** /transports/offers/search | Search Offers

# **transportsBookingsBookingIdCancelPost**
> \Swagger\Client\Model\TransportCancelBookingResponseSchema transportsBookingsBookingIdCancelPost($body, $booking_id)

Cancel Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\TransportsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\TransportCancelBookingRequestSchema(); // \Swagger\Client\Model\TransportCancelBookingRequestSchema | 
$booking_id = "booking_id_example"; // string | 

try {
    $result = $apiInstance->transportsBookingsBookingIdCancelPost($body, $booking_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TransportsApi->transportsBookingsBookingIdCancelPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\TransportCancelBookingRequestSchema**](../Model/TransportCancelBookingRequestSchema.md)|  |
 **booking_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\TransportCancelBookingResponseSchema**](../Model/TransportCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **transportsBookingsBookingIdGet**
> \Swagger\Client\Model\TransportBookingDetailsResponseSchema transportsBookingsBookingIdGet($booking_id)

Get Booking Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\TransportsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$booking_id = "booking_id_example"; // string | 

try {
    $result = $apiInstance->transportsBookingsBookingIdGet($booking_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TransportsApi->transportsBookingsBookingIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\TransportBookingDetailsResponseSchema**](../Model/TransportBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **transportsBookingsPost**
> \Swagger\Client\Model\TransportBookingResponseSchema transportsBookingsPost($body)

Create Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\TransportsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\TransportCreateBookingRequestSchema(); // \Swagger\Client\Model\TransportCreateBookingRequestSchema | 

try {
    $result = $apiInstance->transportsBookingsPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TransportsApi->transportsBookingsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\TransportCreateBookingRequestSchema**](../Model/TransportCreateBookingRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\TransportBookingResponseSchema**](../Model/TransportBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **transportsOfferAvailabilityOfferIdGet**
> \Swagger\Client\Model\TransportGetOfferAvailabilityResponse transportsOfferAvailabilityOfferIdGet($body, $offer_id)

Get Offer Availability

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\TransportsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\TransportGetOfferAvailabilityRequest(); // \Swagger\Client\Model\TransportGetOfferAvailabilityRequest | 
$offer_id = "offer_id_example"; // string | 

try {
    $result = $apiInstance->transportsOfferAvailabilityOfferIdGet($body, $offer_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TransportsApi->transportsOfferAvailabilityOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\TransportGetOfferAvailabilityRequest**](../Model/TransportGetOfferAvailabilityRequest.md)|  |
 **offer_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\TransportGetOfferAvailabilityResponse**](../Model/TransportGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **transportsOffersOfferIdGet**
> \Swagger\Client\Model\TransportOfferDetailsSchema transportsOffersOfferIdGet($offer_id)

Get Offer Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\TransportsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$offer_id = "offer_id_example"; // string | 

try {
    $result = $apiInstance->transportsOffersOfferIdGet($offer_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TransportsApi->transportsOffersOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\TransportOfferDetailsSchema**](../Model/TransportOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **transportsOffersSearchPost**
> \Swagger\Client\Model\TransportOfferResponseSchema transportsOffersSearchPost($body)

Search Offers

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\TransportsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\TransportOfferRequestSchema(); // \Swagger\Client\Model\TransportOfferRequestSchema | 

try {
    $result = $apiInstance->transportsOffersSearchPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling TransportsApi->transportsOffersSearchPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\TransportOfferRequestSchema**](../Model/TransportOfferRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\TransportOfferResponseSchema**](../Model/TransportOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

