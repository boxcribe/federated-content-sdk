# Swagger\Client\IntegrationsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**integrationsGet**](IntegrationsApi.md#integrationsget) | **GET** /integrations | Get integrations
[**integrationsIdDelete**](IntegrationsApi.md#integrationsiddelete) | **DELETE** /integrations/{id} | Delete integration
[**integrationsIdGet**](IntegrationsApi.md#integrationsidget) | **GET** /integrations/{id} | Get integration
[**integrationsIdPatch**](IntegrationsApi.md#integrationsidpatch) | **PATCH** /integrations/{id} | Update integration
[**integrationsPost**](IntegrationsApi.md#integrationspost) | **POST** /integrations | Create integration

# **integrationsGet**
> \Swagger\Client\Model\InlineResponse2007 integrationsGet($tenant, $category, $sort, $limit, $page)

Get integrations

Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\IntegrationsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$tenant = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all integrations for a Tenant ID
$category = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all integrations for a Category ID
$sort = "sort_example"; // string | sort by query in the form of field:desc/asc (ex. name:asc)
$limit = 56; // int | Maximum number of integrations
$page = 1; // int | Page number

try {
    $result = $apiInstance->integrationsGet($tenant, $category, $sort, $limit, $page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling IntegrationsApi->integrationsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**string**](../Model/.md)| Get all integrations for a Tenant ID | [optional]
 **category** | [**string**](../Model/.md)| Get all integrations for a Category ID | [optional]
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **int**| Maximum number of integrations | [optional]
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**\Swagger\Client\Model\InlineResponse2007**](../Model/InlineResponse2007.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **integrationsIdDelete**
> integrationsIdDelete($id)

Delete integration

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\IntegrationsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | Integration id

try {
    $apiInstance->integrationsIdDelete($id);
} catch (Exception $e) {
    echo 'Exception when calling IntegrationsApi->integrationsIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Integration id |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **integrationsIdGet**
> \Swagger\Client\Model\Integration integrationsIdGet($id)

Get integration

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\IntegrationsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | Integration id

try {
    $result = $apiInstance->integrationsIdGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling IntegrationsApi->integrationsIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Integration id |

### Return type

[**\Swagger\Client\Model\Integration**](../Model/Integration.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **integrationsIdPatch**
> \Swagger\Client\Model\Integration integrationsIdPatch($body, $id)

Update integration

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\IntegrationsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\IntegrationsIdBody(); // \Swagger\Client\Model\IntegrationsIdBody | 
$id = "id_example"; // string | Integration id

try {
    $result = $apiInstance->integrationsIdPatch($body, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling IntegrationsApi->integrationsIdPatch: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\IntegrationsIdBody**](../Model/IntegrationsIdBody.md)|  |
 **id** | **string**| Integration id |

### Return type

[**\Swagger\Client\Model\Integration**](../Model/Integration.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **integrationsPost**
> \Swagger\Client\Model\Integration integrationsPost($body)

Create integration

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\IntegrationsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\IntegrationsBody(); // \Swagger\Client\Model\IntegrationsBody | 

try {
    $result = $apiInstance->integrationsPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling IntegrationsApi->integrationsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\IntegrationsBody**](../Model/IntegrationsBody.md)|  |

### Return type

[**\Swagger\Client\Model\Integration**](../Model/Integration.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

