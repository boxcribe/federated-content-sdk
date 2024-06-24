# Swagger\Client\FieldsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**fieldsGet**](FieldsApi.md#fieldsget) | **GET** /fields | Get fields
[**fieldsIdDelete**](FieldsApi.md#fieldsiddelete) | **DELETE** /fields/{id} | Delete field
[**fieldsIdGet**](FieldsApi.md#fieldsidget) | **GET** /fields/{id} | Get field
[**fieldsIdPatch**](FieldsApi.md#fieldsidpatch) | **PATCH** /fields/{id} | Update field
[**fieldsPost**](FieldsApi.md#fieldspost) | **POST** /fields | Create field

# **fieldsGet**
> \Swagger\Client\Model\InlineResponse2006 fieldsGet($tenant, $schema, $sort, $limit, $page)

Get fields

Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\FieldsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$tenant = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all fields for a Tenant ID
$schema = "38400000-8cf0-11bd-b23e-10b96e4ef00d"; // string | Get all fields for a Schema ID
$sort = "sort_example"; // string | sort by query in the form of field:desc/asc (ex. name:asc)
$limit = 56; // int | Maximum number of fields
$page = 1; // int | Page number

try {
    $result = $apiInstance->fieldsGet($tenant, $schema, $sort, $limit, $page);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FieldsApi->fieldsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**string**](../Model/.md)| Get all fields for a Tenant ID | [optional]
 **schema** | [**string**](../Model/.md)| Get all fields for a Schema ID | [optional]
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **int**| Maximum number of fields | [optional]
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**\Swagger\Client\Model\InlineResponse2006**](../Model/InlineResponse2006.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **fieldsIdDelete**
> fieldsIdDelete($id)

Delete field

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\FieldsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | Field id

try {
    $apiInstance->fieldsIdDelete($id);
} catch (Exception $e) {
    echo 'Exception when calling FieldsApi->fieldsIdDelete: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Field id |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **fieldsIdGet**
> \Swagger\Client\Model\Field fieldsIdGet($id)

Get field

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\FieldsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$id = "id_example"; // string | Field id

try {
    $result = $apiInstance->fieldsIdGet($id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FieldsApi->fieldsIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Field id |

### Return type

[**\Swagger\Client\Model\Field**](../Model/Field.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **fieldsIdPatch**
> \Swagger\Client\Model\Field fieldsIdPatch($body, $id)

Update field

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\FieldsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\FieldsIdBody(); // \Swagger\Client\Model\FieldsIdBody | 
$id = "id_example"; // string | Field id

try {
    $result = $apiInstance->fieldsIdPatch($body, $id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FieldsApi->fieldsIdPatch: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\FieldsIdBody**](../Model/FieldsIdBody.md)|  |
 **id** | **string**| Field id |

### Return type

[**\Swagger\Client\Model\Field**](../Model/Field.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **fieldsPost**
> \Swagger\Client\Model\Field fieldsPost($body)

Create field

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');
    // Configure HTTP bearer authorization: bearerAuth
    $config = Swagger\Client\Configuration::getDefaultConfiguration()
    ->setAccessToken('YOUR_ACCESS_TOKEN');


$apiInstance = new Swagger\Client\Api\FieldsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client(),
    $config
);
$body = new \Swagger\Client\Model\FieldsBody(); // \Swagger\Client\Model\FieldsBody | 

try {
    $result = $apiInstance->fieldsPost($body);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling FieldsApi->fieldsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\FieldsBody**](../Model/FieldsBody.md)|  |

### Return type

[**\Swagger\Client\Model\Field**](../Model/Field.md)

### Authorization

[bearerAuth](../../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

