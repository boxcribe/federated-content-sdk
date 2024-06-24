# Swagger\Client\FlightsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**flightsBookingsBookingIdCancelPost**](FlightsApi.md#flightsbookingsbookingidcancelpost) | **POST** /flights/bookings/{bookingId}/cancel | Cancel Booking
[**flightsBookingsBookingIdGet**](FlightsApi.md#flightsbookingsbookingidget) | **GET** /flights/bookings/{bookingId} | Get Booking Details
[**flightsBookingsPost**](FlightsApi.md#flightsbookingspost) | **POST** /flights/bookings | Create Booking
[**flightsOffersOfferIdGet**](FlightsApi.md#flightsoffersofferidget) | **GET** /flights/offers/{offerId} | Get Offer Details
[**flightsOffersOfferIdSeatmapsGet**](FlightsApi.md#flightsoffersofferidseatmapsget) | **GET** /flights/offers/{offerId}/seatmaps | Get Offer Seatmaps
[**flightsOffersSearchPost**](FlightsApi.md#flightsofferssearchpost) | **POST** /flights/offers/search | Search Offers

# **flightsBookingsBookingIdCancelPost**
> \Swagger\Client\Model\FlightCancelBookingResponseSchema flightsBookingsBookingIdCancelPost($body)

Cancel Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\FlightsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\FlightCancelBookingRequestSchema(); // \Swagger\Client\Model\FlightCancelBookingRequestSchema | 

try {
    $result = $apiInstance->flightsBookingsBookingIdCancelPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlightsApi->flightsBookingsBookingIdCancelPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\FlightCancelBookingRequestSchema**](../Model/FlightCancelBookingRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\FlightCancelBookingResponseSchema**](../Model/FlightCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **flightsBookingsBookingIdGet**
> \Swagger\Client\Model\FlightGetBookingDetailsResponseSchema flightsBookingsBookingIdGet($body)

Get Booking Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\FlightsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\FlightBookingDetailsRequestSchema(); // \Swagger\Client\Model\FlightBookingDetailsRequestSchema | 

try {
    $result = $apiInstance->flightsBookingsBookingIdGet($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlightsApi->flightsBookingsBookingIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\FlightBookingDetailsRequestSchema**](../Model/FlightBookingDetailsRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\FlightGetBookingDetailsResponseSchema**](../Model/FlightGetBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **flightsBookingsPost**
> \Swagger\Client\Model\FlightBookingResponseSchema flightsBookingsPost($body)

Create Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\FlightsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\FlightCreateBookingRequestSchema(); // \Swagger\Client\Model\FlightCreateBookingRequestSchema | 

try {
    $result = $apiInstance->flightsBookingsPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlightsApi->flightsBookingsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\FlightCreateBookingRequestSchema**](../Model/FlightCreateBookingRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\FlightBookingResponseSchema**](../Model/FlightBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **flightsOffersOfferIdGet**
> \Swagger\Client\Model\FlightOfferDetailsResponseSchema flightsOffersOfferIdGet($body)

Get Offer Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\FlightsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\FlightOfferDetailsRequestSchema(); // \Swagger\Client\Model\FlightOfferDetailsRequestSchema | 

try {
    $result = $apiInstance->flightsOffersOfferIdGet($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlightsApi->flightsOffersOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\FlightOfferDetailsRequestSchema**](../Model/FlightOfferDetailsRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\FlightOfferDetailsResponseSchema**](../Model/FlightOfferDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **flightsOffersOfferIdSeatmapsGet**
> \Swagger\Client\Model\FlightOfferSeatmapsResponseSchema flightsOffersOfferIdSeatmapsGet($body)

Get Offer Seatmaps

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\FlightsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\FlightOfferSeatmapsRequestSchema(); // \Swagger\Client\Model\FlightOfferSeatmapsRequestSchema | 

try {
    $result = $apiInstance->flightsOffersOfferIdSeatmapsGet($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlightsApi->flightsOffersOfferIdSeatmapsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\FlightOfferSeatmapsRequestSchema**](../Model/FlightOfferSeatmapsRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\FlightOfferSeatmapsResponseSchema**](../Model/FlightOfferSeatmapsResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **flightsOffersSearchPost**
> \Swagger\Client\Model\FlightOfferResponseSchema flightsOffersSearchPost($body)

Search Offers

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\FlightsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\FlightOfferRequestSchema(); // \Swagger\Client\Model\FlightOfferRequestSchema | 

try {
    $result = $apiInstance->flightsOffersSearchPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FlightsApi->flightsOffersSearchPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\FlightOfferRequestSchema**](../Model/FlightOfferRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\FlightOfferResponseSchema**](../Model/FlightOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

