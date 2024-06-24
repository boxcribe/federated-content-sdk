# Swagger\Client\SchemasApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**schemasGet**](SchemasApi.md#schemasget) | **GET** /schemas | Get schemas
[**schemasGroupedByEndpointGet**](SchemasApi.md#schemasgroupedbyendpointget) | **GET** /schemas/groupedByEndpoint | Get schemas grouped by endpoint
[**schemasIdDelete**](SchemasApi.md#schemasiddelete) | **DELETE** /schemas/{id} | Delete schema
[**schemasIdGet**](SchemasApi.md#schemasidget) | **GET** /schemas/{id} | Get schema
[**schemasIdPatch**](SchemasApi.md#schemasidpatch) | **PATCH** /schemas/{id} | Update schema
[**schemasPost**](SchemasApi.md#schemaspost) | **POST** /schemas | Create schema

# **schemasGet**
> \Swagger\Client\Model\InlineResponse20010 schemasGet($tenant, $category, $sort, $limit, $page)

Get schemas

Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\SchemasApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$tenant = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all schemas for a Tenant ID
$category = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all schemas for a Category ID
$sort = "sort_example"; // string | Sort by query in the form of field:desc/asc (ex. name:asc)
$limit = 56; // int | Maximum number of schemas
$page = 1; // int | Page number

try {
    $result = $apiInstance->schemasGet($tenant, $category, $sort, $limit, $page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SchemasApi->schemasGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**string**](../Model/.md)| Get all schemas for a Tenant ID | [optional]
 **category** | [**string**](../Model/.md)| Get all schemas for a Category ID | [optional]
 **sort** | **string**| Sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **int**| Maximum number of schemas | [optional]
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**\Swagger\Client\Model\InlineResponse20010**](../Model/InlineResponse20010.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **schemasGroupedByEndpointGet**
> \Swagger\Client\Model\InlineResponse20011 schemasGroupedByEndpointGet($tenant, $category, $sort, $limit, $page)

Get schemas grouped by endpoint

Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\SchemasApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$tenant = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all schemas for a Tenant ID
$category = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all schemas for a Category ID
$sort = "sort_example"; // string | Sort by query in the form of field:desc/asc (ex. endpoint:asc)
$limit = 56; // int | Maximum number of schemas
$page = 1; // int | Page number

try {
    $result = $apiInstance->schemasGroupedByEndpointGet($tenant, $category, $sort, $limit, $page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SchemasApi->schemasGroupedByEndpointGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**string**](../Model/.md)| Get all schemas for a Tenant ID | [optional]
 **category** | [**string**](../Model/.md)| Get all schemas for a Category ID | [optional]
 **sort** | **string**| Sort by query in the form of field:desc/asc (ex. endpoint:asc) | [optional]
 **limit** | **int**| Maximum number of schemas | [optional]
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**\Swagger\Client\Model\InlineResponse20011**](../Model/InlineResponse20011.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **schemasIdDelete**
> schemasIdDelete($id)

Delete schema

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\SchemasApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | Schema id

try {
    $apiInstance->schemasIdDelete($id);
} catch (Exception $e) {
    echo 'Exception when calling SchemasApi->schemasIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Schema id |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **schemasIdGet**
> \Swagger\Client\Model\Schema schemasIdGet($id)

Get schema

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\SchemasApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | Schema id

try {
    $result = $apiInstance->schemasIdGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SchemasApi->schemasIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Schema id |

### Return type

[**\Swagger\Client\Model\Schema**](../Model/Schema.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **schemasIdPatch**
> \Swagger\Client\Model\Schema schemasIdPatch($body, $id)

Update schema

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\SchemasApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\SchemasIdBody(); // \Swagger\Client\Model\SchemasIdBody | 
$id = "id_example"; // string | Schema id

try {
    $result = $apiInstance->schemasIdPatch($body, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SchemasApi->schemasIdPatch: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\SchemasIdBody**](../Model/SchemasIdBody.md)|  |
 **id** | **string**| Schema id |

### Return type

[**\Swagger\Client\Model\Schema**](../Model/Schema.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **schemasPost**
> \Swagger\Client\Model\Schema schemasPost($body)

Create schema

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\SchemasApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\SchemasBody(); // \Swagger\Client\Model\SchemasBody | 

try {
    $result = $apiInstance->schemasPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling SchemasApi->schemasPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\SchemasBody**](../Model/SchemasBody.md)|  |

### Return type

[**\Swagger\Client\Model\Schema**](../Model/Schema.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

