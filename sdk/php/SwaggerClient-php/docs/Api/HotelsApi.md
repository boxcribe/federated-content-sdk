# Swagger\Client\HotelsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**hotelsBookingsBookingIdCancelPost**](HotelsApi.md#hotelsbookingsbookingidcancelpost) | **POST** /hotels/bookings/{bookingId}/cancel | Cancel Booking
[**hotelsBookingsBookingIdGet**](HotelsApi.md#hotelsbookingsbookingidget) | **GET** /hotels/bookings/{bookingId} | Get Booking Details
[**hotelsBookingsPost**](HotelsApi.md#hotelsbookingspost) | **POST** /hotels/bookings | Create Booking
[**hotelsOfferAvailabilityOfferIdGet**](HotelsApi.md#hotelsofferavailabilityofferidget) | **GET** /hotels/offer_availability/{offerId} | Get Offer Availability
[**hotelsOffersOfferIdGet**](HotelsApi.md#hotelsoffersofferidget) | **GET** /hotels/offers/{offerId} | Get Offer Details
[**hotelsOffersSearchPost**](HotelsApi.md#hotelsofferssearchpost) | **POST** /hotels/offers/search | Search Offers

# **hotelsBookingsBookingIdCancelPost**
> \Swagger\Client\Model\HotelCancelBookingResponseSchema hotelsBookingsBookingIdCancelPost($body, $booking_id)

Cancel Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\HotelsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\HotelCancelBookingRequestSchema(); // \Swagger\Client\Model\HotelCancelBookingRequestSchema | 
$booking_id = "booking_id_example"; // string | 

try {
    $result = $apiInstance->hotelsBookingsBookingIdCancelPost($body, $booking_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HotelsApi->hotelsBookingsBookingIdCancelPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\HotelCancelBookingRequestSchema**](../Model/HotelCancelBookingRequestSchema.md)|  |
 **booking_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\HotelCancelBookingResponseSchema**](../Model/HotelCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **hotelsBookingsBookingIdGet**
> \Swagger\Client\Model\HotelBookingDetailsResponseSchema hotelsBookingsBookingIdGet($booking_id)

Get Booking Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\HotelsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$booking_id = "booking_id_example"; // string | 

try {
    $result = $apiInstance->hotelsBookingsBookingIdGet($booking_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HotelsApi->hotelsBookingsBookingIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\HotelBookingDetailsResponseSchema**](../Model/HotelBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **hotelsBookingsPost**
> \Swagger\Client\Model\HotelBookingResponseSchema hotelsBookingsPost($body)

Create Booking

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\HotelsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\HotelCreateBookingRequestSchema(); // \Swagger\Client\Model\HotelCreateBookingRequestSchema | 

try {
    $result = $apiInstance->hotelsBookingsPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HotelsApi->hotelsBookingsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\HotelCreateBookingRequestSchema**](../Model/HotelCreateBookingRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\HotelBookingResponseSchema**](../Model/HotelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **hotelsOfferAvailabilityOfferIdGet**
> \Swagger\Client\Model\HotelGetOfferAvailabilityResponse hotelsOfferAvailabilityOfferIdGet($body, $offer_id)

Get Offer Availability

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\HotelsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\HotelGetOfferAvailabilityRequest(); // \Swagger\Client\Model\HotelGetOfferAvailabilityRequest | 
$offer_id = "offer_id_example"; // string | 

try {
    $result = $apiInstance->hotelsOfferAvailabilityOfferIdGet($body, $offer_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HotelsApi->hotelsOfferAvailabilityOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\HotelGetOfferAvailabilityRequest**](../Model/HotelGetOfferAvailabilityRequest.md)|  |
 **offer_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\HotelGetOfferAvailabilityResponse**](../Model/HotelGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **hotelsOffersOfferIdGet**
> \Swagger\Client\Model\HotelOfferDetailsSchema hotelsOffersOfferIdGet($offer_id)

Get Offer Details

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\HotelsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$offer_id = "offer_id_example"; // string | 

try {
    $result = $apiInstance->hotelsOffersOfferIdGet($offer_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HotelsApi->hotelsOffersOfferIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **string**|  |

### Return type

[**\Swagger\Client\Model\HotelOfferDetailsSchema**](../Model/HotelOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **hotelsOffersSearchPost**
> \Swagger\Client\Model\HotelOfferResponseSchema hotelsOffersSearchPost($body)

Search Offers

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
// Configure API key authorization: apiKeyAuth
$config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKey('x-api-key', 'YOUR_API_KEY');
// Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
// $config = Swagger\Client\Configuration::getDefaultConfiguration()->setApiKeyPrefix('x-api-key', 'Bearer');

$apiInstance = new Swagger\Client\Api\HotelsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\HotelOfferRequestSchema(); // \Swagger\Client\Model\HotelOfferRequestSchema | 

try {
    $result = $apiInstance->hotelsOffersSearchPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling HotelsApi->hotelsOffersSearchPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\HotelOfferRequestSchema**](../Model/HotelOfferRequestSchema.md)|  |

### Return type

[**\Swagger\Client\Model\HotelOfferResponseSchema**](../Model/HotelOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

