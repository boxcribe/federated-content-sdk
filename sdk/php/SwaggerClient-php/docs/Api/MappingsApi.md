# Swagger\Client\MappingsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mappingsGet**](MappingsApi.md#mappingsget) | **GET** /mappings | Get mappings
[**mappingsIdDelete**](MappingsApi.md#mappingsiddelete) | **DELETE** /mappings/{id} | Delete mapping
[**mappingsIdGet**](MappingsApi.md#mappingsidget) | **GET** /mappings/{id} | Get mapping
[**mappingsIdPatch**](MappingsApi.md#mappingsidpatch) | **PATCH** /mappings/{id} | Update mapping
[**mappingsPost**](MappingsApi.md#mappingspost) | **POST** /mappings | Create mapping

# **mappingsGet**
> \Swagger\Client\Model\InlineResponse2009 mappingsGet($tenant, $schema, $field, $integration, $sort, $limit, $page)

Get mappings

Retrieve a list of mappings with the ability to filter by tenant, category, schema, integration, field, sort, limit or page.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\MappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$tenant = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all mappings for a Tenant ID
$schema = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all mappings for a Schema ID
$field = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all mappings for a Field ID
$integration = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all mappings for an Integration ID
$sort = "sort_example"; // string | sort by query in the form of mapping:desc/asc (ex. name:asc)
$limit = 56; // int | Maximum number of mappings
$page = 1; // int | Page number

try {
    $result = $apiInstance->mappingsGet($tenant, $schema, $field, $integration, $sort, $limit, $page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MappingsApi->mappingsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**string**](../Model/.md)| Get all mappings for a Tenant ID | [optional]
 **schema** | [**string**](../Model/.md)| Get all mappings for a Schema ID | [optional]
 **field** | [**string**](../Model/.md)| Get all mappings for a Field ID | [optional]
 **integration** | [**string**](../Model/.md)| Get all mappings for an Integration ID | [optional]
 **sort** | **string**| sort by query in the form of mapping:desc/asc (ex. name:asc) | [optional]
 **limit** | **int**| Maximum number of mappings | [optional]
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**\Swagger\Client\Model\InlineResponse2009**](../Model/InlineResponse2009.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **mappingsIdDelete**
> mappingsIdDelete($id)

Delete mapping

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\MappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | Mapping id

try {
    $apiInstance->mappingsIdDelete($id);
} catch (Exception $e) {
    echo 'Exception when calling MappingsApi->mappingsIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Mapping id |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **mappingsIdGet**
> \Swagger\Client\Model\Mapping mappingsIdGet($id)

Get mapping

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\MappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | Mapping id

try {
    $result = $apiInstance->mappingsIdGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MappingsApi->mappingsIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Mapping id |

### Return type

[**\Swagger\Client\Model\Mapping**](../Model/Mapping.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **mappingsIdPatch**
> \Swagger\Client\Model\Mapping mappingsIdPatch($body, $id)

Update mapping

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\MappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\MappingsIdBody(); // \Swagger\Client\Model\MappingsIdBody | 
$id = "id_example"; // string | Mapping id

try {
    $result = $apiInstance->mappingsIdPatch($body, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MappingsApi->mappingsIdPatch: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\MappingsIdBody**](../Model/MappingsIdBody.md)|  |
 **id** | **string**| Mapping id |

### Return type

[**\Swagger\Client\Model\Mapping**](../Model/Mapping.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **mappingsPost**
> \Swagger\Client\Model\Mapping mappingsPost($body)

Create mapping

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\MappingsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\MappingsBody(); // \Swagger\Client\Model\MappingsBody | 

try {
    $result = $apiInstance->mappingsPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling MappingsApi->mappingsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\MappingsBody**](../Model/MappingsBody.md)|  |

### Return type

[**\Swagger\Client\Model\Mapping**](../Model/Mapping.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

