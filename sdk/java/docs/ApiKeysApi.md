# ApiKeysApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apikeysGet**](ApiKeysApi.md#apikeysGet) | **GET** /apikeys | Get api keys
[**apikeysIdDelete**](ApiKeysApi.md#apikeysIdDelete) | **DELETE** /apikeys/{id} | Delete api key
[**apikeysIdGet**](ApiKeysApi.md#apikeysIdGet) | **GET** /apikeys/{id} | Get api key
[**apikeysIdPatch**](ApiKeysApi.md#apikeysIdPatch) | **PATCH** /apikeys/{id} | Update api key
[**apikeysPost**](ApiKeysApi.md#apikeysPost) | **POST** /apikeys | Create api key

<a name="apikeysGet"></a>
# **apikeysGet**
> InlineResponse2002 apikeysGet(tenant, environment, sort, limit, page)

Get api keys

Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ApiKeysApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


ApiKeysApi apiInstance = new ApiKeysApi();
String tenant = "tenant_example"; // String | Get all schemas for a Tenant ID
String environment = "environment_example"; // String | Get all schemas for an Environment (Sandbox or Production)
String sort = "sort_example"; // String | sort by query in the form of field:desc/asc (ex. name:asc)
Integer limit = 56; // Integer | Maximum number of apiKeys
Integer page = 1; // Integer | Page number
try {
    InlineResponse2002 result = apiInstance.apikeysGet(tenant, environment, sort, limit, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiKeysApi#apikeysGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | **String**| Get all schemas for a Tenant ID | [optional]
 **environment** | **String**| Get all schemas for an Environment (Sandbox or Production) | [optional]
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **Integer**| Maximum number of apiKeys | [optional] [enum: 1]
 **page** | **Integer**| Page number | [optional] [default to 1] [enum: 1]

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="apikeysIdDelete"></a>
# **apikeysIdDelete**
> apikeysIdDelete(id)

Delete api key

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ApiKeysApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


ApiKeysApi apiInstance = new ApiKeysApi();
String id = "id_example"; // String | Api Key ID
try {
    apiInstance.apikeysIdDelete(id);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiKeysApi#apikeysIdDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Api Key ID |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="apikeysIdGet"></a>
# **apikeysIdGet**
> ApiKey apikeysIdGet(id)

Get api key

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ApiKeysApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


ApiKeysApi apiInstance = new ApiKeysApi();
String id = "id_example"; // String | Api Key ID
try {
    ApiKey result = apiInstance.apikeysIdGet(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiKeysApi#apikeysIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Api Key ID |

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="apikeysIdPatch"></a>
# **apikeysIdPatch**
> ApiKey apikeysIdPatch(body, id)

Update api key

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ApiKeysApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


ApiKeysApi apiInstance = new ApiKeysApi();
ApikeysIdBody body = new ApikeysIdBody(); // ApikeysIdBody | 
String id = "id_example"; // String | Api Key ID
try {
    ApiKey result = apiInstance.apikeysIdPatch(body, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiKeysApi#apikeysIdPatch");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApikeysIdBody**](ApikeysIdBody.md)|  |
 **id** | **String**| Api Key ID |

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="apikeysPost"></a>
# **apikeysPost**
> ApiKey apikeysPost(body)

Create api key

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.ApiKeysApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


ApiKeysApi apiInstance = new ApiKeysApi();
ApikeysBody body = new ApikeysBody(); // ApikeysBody | 
try {
    ApiKey result = apiInstance.apikeysPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling ApiKeysApi#apikeysPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApikeysBody**](ApikeysBody.md)|  |

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

