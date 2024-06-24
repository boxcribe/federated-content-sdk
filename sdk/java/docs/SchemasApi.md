# SchemasApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**schemasGet**](SchemasApi.md#schemasGet) | **GET** /schemas | Get schemas
[**schemasGroupedByEndpointGet**](SchemasApi.md#schemasGroupedByEndpointGet) | **GET** /schemas/groupedByEndpoint | Get schemas grouped by endpoint
[**schemasIdDelete**](SchemasApi.md#schemasIdDelete) | **DELETE** /schemas/{id} | Delete schema
[**schemasIdGet**](SchemasApi.md#schemasIdGet) | **GET** /schemas/{id} | Get schema
[**schemasIdPatch**](SchemasApi.md#schemasIdPatch) | **PATCH** /schemas/{id} | Update schema
[**schemasPost**](SchemasApi.md#schemasPost) | **POST** /schemas | Create schema

<a name="schemasGet"></a>
# **schemasGet**
> InlineResponse20010 schemasGet(tenant, category, sort, limit, page)

Get schemas

Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.SchemasApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


SchemasApi apiInstance = new SchemasApi();
UUID tenant = new UUID(); // UUID | Get all schemas for a Tenant ID
UUID category = new UUID(); // UUID | Get all schemas for a Category ID
String sort = "sort_example"; // String | Sort by query in the form of field:desc/asc (ex. name:asc)
Integer limit = 56; // Integer | Maximum number of schemas
Integer page = 1; // Integer | Page number
try {
    InlineResponse20010 result = apiInstance.schemasGet(tenant, category, sort, limit, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling SchemasApi#schemasGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**UUID**](.md)| Get all schemas for a Tenant ID | [optional]
 **category** | [**UUID**](.md)| Get all schemas for a Category ID | [optional]
 **sort** | **String**| Sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **Integer**| Maximum number of schemas | [optional] [enum: 1]
 **page** | **Integer**| Page number | [optional] [default to 1] [enum: 1]

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="schemasGroupedByEndpointGet"></a>
# **schemasGroupedByEndpointGet**
> InlineResponse20011 schemasGroupedByEndpointGet(tenant, category, sort, limit, page)

Get schemas grouped by endpoint

Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.SchemasApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


SchemasApi apiInstance = new SchemasApi();
UUID tenant = new UUID(); // UUID | Get all schemas for a Tenant ID
UUID category = new UUID(); // UUID | Get all schemas for a Category ID
String sort = "sort_example"; // String | Sort by query in the form of field:desc/asc (ex. endpoint:asc)
Integer limit = 56; // Integer | Maximum number of schemas
Integer page = 1; // Integer | Page number
try {
    InlineResponse20011 result = apiInstance.schemasGroupedByEndpointGet(tenant, category, sort, limit, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling SchemasApi#schemasGroupedByEndpointGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**UUID**](.md)| Get all schemas for a Tenant ID | [optional]
 **category** | [**UUID**](.md)| Get all schemas for a Category ID | [optional]
 **sort** | **String**| Sort by query in the form of field:desc/asc (ex. endpoint:asc) | [optional]
 **limit** | **Integer**| Maximum number of schemas | [optional] [enum: 1]
 **page** | **Integer**| Page number | [optional] [default to 1] [enum: 1]

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="schemasIdDelete"></a>
# **schemasIdDelete**
> schemasIdDelete(id)

Delete schema

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.SchemasApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


SchemasApi apiInstance = new SchemasApi();
String id = "id_example"; // String | Schema id
try {
    apiInstance.schemasIdDelete(id);
} catch (ApiException e) {
    System.err.println("Exception when calling SchemasApi#schemasIdDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Schema id |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="schemasIdGet"></a>
# **schemasIdGet**
> io.swagger.v3.oas.annotations.media.Schema schemasIdGet(id)

Get schema

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.SchemasApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


SchemasApi apiInstance = new SchemasApi();
String id = "id_example"; // String | Schema id
try {
    io.swagger.v3.oas.annotations.media.Schema result = apiInstance.schemasIdGet(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling SchemasApi#schemasIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Schema id |

### Return type

[**io.swagger.v3.oas.annotations.media.Schema**](io.swagger.v3.oas.annotations.media.Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="schemasIdPatch"></a>
# **schemasIdPatch**
> io.swagger.v3.oas.annotations.media.Schema schemasIdPatch(body, id)

Update schema

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.SchemasApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


SchemasApi apiInstance = new SchemasApi();
SchemasIdBody body = new SchemasIdBody(); // SchemasIdBody | 
String id = "id_example"; // String | Schema id
try {
    io.swagger.v3.oas.annotations.media.Schema result = apiInstance.schemasIdPatch(body, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling SchemasApi#schemasIdPatch");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SchemasIdBody**](SchemasIdBody.md)|  |
 **id** | **String**| Schema id |

### Return type

[**io.swagger.v3.oas.annotations.media.Schema**](io.swagger.v3.oas.annotations.media.Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="schemasPost"></a>
# **schemasPost**
> io.swagger.v3.oas.annotations.media.Schema schemasPost(body)

Create schema

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.SchemasApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


SchemasApi apiInstance = new SchemasApi();
SchemasBody body = new SchemasBody(); // SchemasBody | 
try {
    io.swagger.v3.oas.annotations.media.Schema result = apiInstance.schemasPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling SchemasApi#schemasPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SchemasBody**](SchemasBody.md)|  |

### Return type

[**io.swagger.v3.oas.annotations.media.Schema**](io.swagger.v3.oas.annotations.media.Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

