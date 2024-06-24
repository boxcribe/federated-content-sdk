# Swagger\Client\DiningApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**diningBookingsBookingIdCancelPost**](DiningApi.md#diningbookingsbookingidcancelpost) | **POST** /dining/bookings/{bookingId}/cancel | Cancel Booking
[**diningBookingsBookingIdGet**](DiningApi.md#diningbookingsbookingidget) | **GET** /dining/bookings/{bookingId} | Get Booking Details
[**diningBookingsPost**](DiningApi.md#diningbookingspost) | **POST** /dining/bookings | Create Booking
[**diningOfferAvailabilityOfferIdGet**](DiningApi.md#diningofferavailabilityofferidget) | **GET** /dining/offer_availability/{offerId} | Get Offer Availability
[**diningOffersOfferIdGet**](DiningApi.md#diningoffersofferidget) | **GET** /dining/offers/{offerId} | Get Offer Details
[**diningOffersSearchPost**](DiningApi.md#diningofferssearchpost) | **POST** /dining/offers/search | Search Offers

# **diningBookingsBookingIdCancelPost**
> \Swagger\Client\Model\DiningCancelBookingResponseSchema diningBookingsBookingIdCancelPost($body, $booking_id)

Cancel Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\DiningApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\DiningCancelBookingRequestSchema(); // \Swagger\Client\Model\DiningCancelBookingRequestSchema | 
$booking_id = "booking_id_example"; // string | 

try {
    $result = $apiInstance->diningBookingsBookingIdCancelPost($body, $booking_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DiningApi->diningBookingsBookingIdCancelPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\DiningCancelBookingRequestSchema**](../Model/DiningCancelBookingRequestSchema.md)|  |
 **booking_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\DiningCancelBookingResponseSchema**](../Model/DiningCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **diningBookingsBookingIdGet**
> \Swagger\Client\Model\DiningBookingDetailsResponseSchema diningBookingsBookingIdGet($booking_id)

Get Booking Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\DiningApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$booking_id = "booking_id_example"; // string | 

try {
    $result = $apiInstance->diningBookingsBookingIdGet($booking_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DiningApi->diningBookingsBookingIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\DiningBookingDetailsResponseSchema**](../Model/DiningBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **diningBookingsPost**
> \Swagger\Client\Model\DiningBookingResponseSchema diningBookingsPost($body)

Create Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\DiningApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\DiningCreateBookingRequestSchema(); // \Swagger\Client\Model\DiningCreateBookingRequestSchema | 

try {
    $result = $apiInstance->diningBookingsPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DiningApi->diningBookingsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\DiningCreateBookingRequestSchema**](../Model/DiningCreateBookingRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\DiningBookingResponseSchema**](../Model/DiningBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **diningOfferAvailabilityOfferIdGet**
> \Swagger\Client\Model\DiningGetOfferAvailabilityResponse diningOfferAvailabilityOfferIdGet($body, $offer_id)

Get Offer Availability

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\DiningApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\DiningGetOfferAvailabilityRequest(); // \Swagger\Client\Model\DiningGetOfferAvailabilityRequest | 
$offer_id = "offer_id_example"; // string | 

try {
    $result = $apiInstance->diningOfferAvailabilityOfferIdGet($body, $offer_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DiningApi->diningOfferAvailabilityOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\DiningGetOfferAvailabilityRequest**](../Model/DiningGetOfferAvailabilityRequest.md)|  |
 **offer_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\DiningGetOfferAvailabilityResponse**](../Model/DiningGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **diningOffersOfferIdGet**
> \Swagger\Client\Model\DiningOfferDetailsSchema diningOffersOfferIdGet($offer_id)

Get Offer Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\DiningApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$offer_id = "offer_id_example"; // string | 

try {
    $result = $apiInstance->diningOffersOfferIdGet($offer_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DiningApi->diningOffersOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\DiningOfferDetailsSchema**](../Model/DiningOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **diningOffersSearchPost**
> \Swagger\Client\Model\DiningOfferResponseSchema diningOffersSearchPost($body)

Search Offers

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\DiningApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\DiningOfferRequestSchema(); // \Swagger\Client\Model\DiningOfferRequestSchema | 

try {
    $result = $apiInstance->diningOffersSearchPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DiningApi->diningOffersSearchPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\DiningOfferRequestSchema**](../Model/DiningOfferRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\DiningOfferResponseSchema**](../Model/DiningOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

