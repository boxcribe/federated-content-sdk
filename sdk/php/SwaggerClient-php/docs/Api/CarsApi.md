# Swagger\Client\CarsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**carsBookingsBookingIdCancelPost**](CarsApi.md#carsbookingsbookingidcancelpost) | **POST** /cars/bookings/{bookingId}/cancel | Cancel Booking
[**carsBookingsBookingIdGet**](CarsApi.md#carsbookingsbookingidget) | **GET** /cars/bookings/{bookingId} | Get Booking Details
[**carsBookingsPost**](CarsApi.md#carsbookingspost) | **POST** /cars/bookings | Create Booking
[**carsOfferAvailabilityOfferIdGet**](CarsApi.md#carsofferavailabilityofferidget) | **GET** /cars/offer_availability/{offerId} | Get Offer Availability
[**carsOffersOfferIdGet**](CarsApi.md#carsoffersofferidget) | **GET** /cars/offers/{offerId} | Get Offer Details
[**carsOffersSearchPost**](CarsApi.md#carsofferssearchpost) | **POST** /cars/offers/search | Search Offers

# **carsBookingsBookingIdCancelPost**
> \Swagger\Client\Model\CarCancelBookingResponseSchema carsBookingsBookingIdCancelPost($body, $booking_id)

Cancel Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\CarsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\CarCancelBookingRequestSchema(); // \Swagger\Client\Model\CarCancelBookingRequestSchema | 
$booking_id = "booking_id_example"; // string | 

try {
    $result = $apiInstance->carsBookingsBookingIdCancelPost($body, $booking_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CarsApi->carsBookingsBookingIdCancelPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\CarCancelBookingRequestSchema**](../Model/CarCancelBookingRequestSchema.md)|  |
 **booking_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\CarCancelBookingResponseSchema**](../Model/CarCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **carsBookingsBookingIdGet**
> \Swagger\Client\Model\CarBookingDetailsResponseSchema carsBookingsBookingIdGet($booking_id)

Get Booking Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\CarsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$booking_id = "booking_id_example"; // string | 

try {
    $result = $apiInstance->carsBookingsBookingIdGet($booking_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CarsApi->carsBookingsBookingIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\CarBookingDetailsResponseSchema**](../Model/CarBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **carsBookingsPost**
> \Swagger\Client\Model\CarBookingResponseSchema carsBookingsPost($body)

Create Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\CarsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\CarCreateBookingRequestSchema(); // \Swagger\Client\Model\CarCreateBookingRequestSchema | 

try {
    $result = $apiInstance->carsBookingsPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CarsApi->carsBookingsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\CarCreateBookingRequestSchema**](../Model/CarCreateBookingRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\CarBookingResponseSchema**](../Model/CarBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **carsOfferAvailabilityOfferIdGet**
> \Swagger\Client\Model\CarGetOfferAvailabilityResponse carsOfferAvailabilityOfferIdGet($body, $offer_id)

Get Offer Availability

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\CarsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\CarGetOfferAvailabilityRequest(); // \Swagger\Client\Model\CarGetOfferAvailabilityRequest | 
$offer_id = "offer_id_example"; // string | 

try {
    $result = $apiInstance->carsOfferAvailabilityOfferIdGet($body, $offer_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CarsApi->carsOfferAvailabilityOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\CarGetOfferAvailabilityRequest**](../Model/CarGetOfferAvailabilityRequest.md)|  |
 **offer_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\CarGetOfferAvailabilityResponse**](../Model/CarGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **carsOffersOfferIdGet**
> \Swagger\Client\Model\CarOfferDetailsSchema carsOffersOfferIdGet($offer_id)

Get Offer Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\CarsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$offer_id = "offer_id_example"; // string | 

try {
    $result = $apiInstance->carsOffersOfferIdGet($offer_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CarsApi->carsOffersOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\CarOfferDetailsSchema**](../Model/CarOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **carsOffersSearchPost**
> \Swagger\Client\Model\CarOfferResponseSchema carsOffersSearchPost($body)

Search Offers

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\CarsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\CarOfferRequestSchema(); // \Swagger\Client\Model\CarOfferRequestSchema | 

try {
    $result = $apiInstance->carsOffersSearchPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CarsApi->carsOffersSearchPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\CarOfferRequestSchema**](../Model/CarOfferRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\CarOfferResponseSchema**](../Model/CarOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

