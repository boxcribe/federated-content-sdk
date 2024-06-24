# Swagger\Client\ApiKeysApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apikeysGet**](ApiKeysApi.md#apikeysget) | **GET** /apikeys | Get api keys
[**apikeysIdDelete**](ApiKeysApi.md#apikeysiddelete) | **DELETE** /apikeys/{id} | Delete api key
[**apikeysIdGet**](ApiKeysApi.md#apikeysidget) | **GET** /apikeys/{id} | Get api key
[**apikeysIdPatch**](ApiKeysApi.md#apikeysidpatch) | **PATCH** /apikeys/{id} | Update api key
[**apikeysPost**](ApiKeysApi.md#apikeyspost) | **POST** /apikeys | Create api key

# **apikeysGet**
> \Swagger\Client\Model\InlineResponse2002 apikeysGet($tenant, $environment, $sort, $limit, $page)

Get api keys

Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\ApiKeysApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$tenant = "tenant_example"; // string | Get all schemas for a Tenant ID
$environment = "environment_example"; // string | Get all schemas for an Environment (Sandbox or Production)
$sort = "sort_example"; // string | sort by query in the form of field:desc/asc (ex. name:asc)
$limit = 56; // int | Maximum number of apiKeys
$page = 1; // int | Page number

try {
    $result = $apiInstance->apikeysGet($tenant, $environment, $sort, $limit, $page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiKeysApi->apikeysGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | **string**| Get all schemas for a Tenant ID | [optional]
 **environment** | **string**| Get all schemas for an Environment (Sandbox or Production) | [optional]
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **int**| Maximum number of apiKeys | [optional]
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**\Swagger\Client\Model\InlineResponse2002**](../Model/InlineResponse2002.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apikeysIdDelete**
> apikeysIdDelete($id)

Delete api key

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\ApiKeysApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | Api Key ID

try {
    $apiInstance->apikeysIdDelete($id);
} catch (Exception $e) {
    echo 'Exception when calling ApiKeysApi->apikeysIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Api Key ID |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apikeysIdGet**
> \Swagger\Client\Model\ApiKey apikeysIdGet($id)

Get api key

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\ApiKeysApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | Api Key ID

try {
    $result = $apiInstance->apikeysIdGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiKeysApi->apikeysIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Api Key ID |

### Return type

[**\Swagger\Client\Model\ApiKey**](../Model/ApiKey.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apikeysIdPatch**
> \Swagger\Client\Model\ApiKey apikeysIdPatch($body, $id)

Update api key

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\ApiKeysApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\ApikeysIdBody(); // \Swagger\Client\Model\ApikeysIdBody | 
$id = "id_example"; // string | Api Key ID

try {
    $result = $apiInstance->apikeysIdPatch($body, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiKeysApi->apikeysIdPatch: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ApikeysIdBody**](../Model/ApikeysIdBody.md)|  |
 **id** | **string**| Api Key ID |

### Return type

[**\Swagger\Client\Model\ApiKey**](../Model/ApiKey.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **apikeysPost**
> \Swagger\Client\Model\ApiKey apikeysPost($body)

Create api key

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\ApiKeysApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\ApikeysBody(); // \Swagger\Client\Model\ApikeysBody | 

try {
    $result = $apiInstance->apikeysPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling ApiKeysApi->apikeysPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ApikeysBody**](../Model/ApikeysBody.md)|  |

### Return type

[**\Swagger\Client\Model\ApiKey**](../Model/ApiKey.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

