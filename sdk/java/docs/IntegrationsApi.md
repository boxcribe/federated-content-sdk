# IntegrationsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**integrationsGet**](IntegrationsApi.md#integrationsGet) | **GET** /integrations | Get integrations
[**integrationsIdDelete**](IntegrationsApi.md#integrationsIdDelete) | **DELETE** /integrations/{id} | Delete integration
[**integrationsIdGet**](IntegrationsApi.md#integrationsIdGet) | **GET** /integrations/{id} | Get integration
[**integrationsIdPatch**](IntegrationsApi.md#integrationsIdPatch) | **PATCH** /integrations/{id} | Update integration
[**integrationsPost**](IntegrationsApi.md#integrationsPost) | **POST** /integrations | Create integration

<a name="integrationsGet"></a>
# **integrationsGet**
> InlineResponse2007 integrationsGet(tenant, category, sort, limit, page)

Get integrations

Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.IntegrationsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


IntegrationsApi apiInstance = new IntegrationsApi();
UUID tenant = new UUID(); // UUID | Get all integrations for a Tenant ID
UUID category = new UUID(); // UUID | Get all integrations for a Category ID
String sort = "sort_example"; // String | sort by query in the form of field:desc/asc (ex. name:asc)
Integer limit = 56; // Integer | Maximum number of integrations
Integer page = 1; // Integer | Page number
try {
    InlineResponse2007 result = apiInstance.integrationsGet(tenant, category, sort, limit, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling IntegrationsApi#integrationsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**UUID**](.md)| Get all integrations for a Tenant ID | [optional]
 **category** | [**UUID**](.md)| Get all integrations for a Category ID | [optional]
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **Integer**| Maximum number of integrations | [optional] [enum: 1]
 **page** | **Integer**| Page number | [optional] [default to 1] [enum: 1]

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="integrationsIdDelete"></a>
# **integrationsIdDelete**
> integrationsIdDelete(id)

Delete integration

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.IntegrationsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


IntegrationsApi apiInstance = new IntegrationsApi();
String id = "id_example"; // String | Integration id
try {
    apiInstance.integrationsIdDelete(id);
} catch (ApiException e) {
    System.err.println("Exception when calling IntegrationsApi#integrationsIdDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Integration id |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="integrationsIdGet"></a>
# **integrationsIdGet**
> Integration integrationsIdGet(id)

Get integration

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.IntegrationsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


IntegrationsApi apiInstance = new IntegrationsApi();
String id = "id_example"; // String | Integration id
try {
    Integration result = apiInstance.integrationsIdGet(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling IntegrationsApi#integrationsIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Integration id |

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="integrationsIdPatch"></a>
# **integrationsIdPatch**
> Integration integrationsIdPatch(body, id)

Update integration

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.IntegrationsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


IntegrationsApi apiInstance = new IntegrationsApi();
IntegrationsIdBody body = new IntegrationsIdBody(); // IntegrationsIdBody | 
String id = "id_example"; // String | Integration id
try {
    Integration result = apiInstance.integrationsIdPatch(body, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling IntegrationsApi#integrationsIdPatch");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IntegrationsIdBody**](IntegrationsIdBody.md)|  |
 **id** | **String**| Integration id |

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="integrationsPost"></a>
# **integrationsPost**
> Integration integrationsPost(body)

Create integration

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.IntegrationsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


IntegrationsApi apiInstance = new IntegrationsApi();
IntegrationsBody body = new IntegrationsBody(); // IntegrationsBody | 
try {
    Integration result = apiInstance.integrationsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling IntegrationsApi#integrationsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IntegrationsBody**](IntegrationsBody.md)|  |

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

