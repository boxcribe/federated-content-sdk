# MappingsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mappingsGet**](MappingsApi.md#mappingsGet) | **GET** /mappings | Get mappings
[**mappingsIdDelete**](MappingsApi.md#mappingsIdDelete) | **DELETE** /mappings/{id} | Delete mapping
[**mappingsIdGet**](MappingsApi.md#mappingsIdGet) | **GET** /mappings/{id} | Get mapping
[**mappingsIdPatch**](MappingsApi.md#mappingsIdPatch) | **PATCH** /mappings/{id} | Update mapping
[**mappingsPost**](MappingsApi.md#mappingsPost) | **POST** /mappings | Create mapping

<a name="mappingsGet"></a>
# **mappingsGet**
> InlineResponse2009 mappingsGet(tenant, schema, field, integration, sort, limit, page)

Get mappings

Retrieve a list of mappings with the ability to filter by tenant, category, schema, integration, field, sort, limit or page.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.MappingsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


MappingsApi apiInstance = new MappingsApi();
UUID tenant = new UUID(); // UUID | Get all mappings for a Tenant ID
UUID schema = new UUID(); // UUID | Get all mappings for a Schema ID
UUID field = new UUID(); // UUID | Get all mappings for a Field ID
UUID integration = new UUID(); // UUID | Get all mappings for an Integration ID
String sort = "sort_example"; // String | sort by query in the form of mapping:desc/asc (ex. name:asc)
Integer limit = 56; // Integer | Maximum number of mappings
Integer page = 1; // Integer | Page number
try {
    InlineResponse2009 result = apiInstance.mappingsGet(tenant, schema, field, integration, sort, limit, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling MappingsApi#mappingsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**UUID**](.md)| Get all mappings for a Tenant ID | [optional]
 **schema** | [**UUID**](.md)| Get all mappings for a Schema ID | [optional]
 **field** | [**UUID**](.md)| Get all mappings for a Field ID | [optional]
 **integration** | [**UUID**](.md)| Get all mappings for an Integration ID | [optional]
 **sort** | **String**| sort by query in the form of mapping:desc/asc (ex. name:asc) | [optional]
 **limit** | **Integer**| Maximum number of mappings | [optional] [enum: 1]
 **page** | **Integer**| Page number | [optional] [default to 1] [enum: 1]

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="mappingsIdDelete"></a>
# **mappingsIdDelete**
> mappingsIdDelete(id)

Delete mapping

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.MappingsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


MappingsApi apiInstance = new MappingsApi();
String id = "id_example"; // String | Mapping id
try {
    apiInstance.mappingsIdDelete(id);
} catch (ApiException e) {
    System.err.println("Exception when calling MappingsApi#mappingsIdDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Mapping id |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="mappingsIdGet"></a>
# **mappingsIdGet**
> Mapping mappingsIdGet(id)

Get mapping

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.MappingsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


MappingsApi apiInstance = new MappingsApi();
String id = "id_example"; // String | Mapping id
try {
    Mapping result = apiInstance.mappingsIdGet(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling MappingsApi#mappingsIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Mapping id |

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="mappingsIdPatch"></a>
# **mappingsIdPatch**
> Mapping mappingsIdPatch(body, id)

Update mapping

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.MappingsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


MappingsApi apiInstance = new MappingsApi();
MappingsIdBody body = new MappingsIdBody(); // MappingsIdBody | 
String id = "id_example"; // String | Mapping id
try {
    Mapping result = apiInstance.mappingsIdPatch(body, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling MappingsApi#mappingsIdPatch");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MappingsIdBody**](MappingsIdBody.md)|  |
 **id** | **String**| Mapping id |

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="mappingsPost"></a>
# **mappingsPost**
> Mapping mappingsPost(body)

Create mapping

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.MappingsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


MappingsApi apiInstance = new MappingsApi();
MappingsBody body = new MappingsBody(); // MappingsBody | 
try {
    Mapping result = apiInstance.mappingsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling MappingsApi#mappingsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MappingsBody**](MappingsBody.md)|  |

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

