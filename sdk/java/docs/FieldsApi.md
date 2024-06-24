# FieldsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**fieldsGet**](FieldsApi.md#fieldsGet) | **GET** /fields | Get fields
[**fieldsIdDelete**](FieldsApi.md#fieldsIdDelete) | **DELETE** /fields/{id} | Delete field
[**fieldsIdGet**](FieldsApi.md#fieldsIdGet) | **GET** /fields/{id} | Get field
[**fieldsIdPatch**](FieldsApi.md#fieldsIdPatch) | **PATCH** /fields/{id} | Update field
[**fieldsPost**](FieldsApi.md#fieldsPost) | **POST** /fields | Create field

<a name="fieldsGet"></a>
# **fieldsGet**
> InlineResponse2006 fieldsGet(tenant, schema, sort, limit, page)

Get fields

Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FieldsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


FieldsApi apiInstance = new FieldsApi();
UUID tenant = new UUID(); // UUID | Get all fields for a Tenant ID
UUID schema = new UUID(); // UUID | Get all fields for a Schema ID
String sort = "sort_example"; // String | sort by query in the form of field:desc/asc (ex. name:asc)
Integer limit = 56; // Integer | Maximum number of fields
Integer page = 1; // Integer | Page number
try {
    InlineResponse2006 result = apiInstance.fieldsGet(tenant, schema, sort, limit, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling FieldsApi#fieldsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**UUID**](.md)| Get all fields for a Tenant ID | [optional]
 **schema** | [**UUID**](.md)| Get all fields for a Schema ID | [optional]
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **Integer**| Maximum number of fields | [optional] [enum: 1]
 **page** | **Integer**| Page number | [optional] [default to 1] [enum: 1]

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="fieldsIdDelete"></a>
# **fieldsIdDelete**
> fieldsIdDelete(id)

Delete field

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FieldsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


FieldsApi apiInstance = new FieldsApi();
String id = "id_example"; // String | Field id
try {
    apiInstance.fieldsIdDelete(id);
} catch (ApiException e) {
    System.err.println("Exception when calling FieldsApi#fieldsIdDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Field id |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="fieldsIdGet"></a>
# **fieldsIdGet**
> Field fieldsIdGet(id)

Get field

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FieldsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


FieldsApi apiInstance = new FieldsApi();
String id = "id_example"; // String | Field id
try {
    Field result = apiInstance.fieldsIdGet(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling FieldsApi#fieldsIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Field id |

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="fieldsIdPatch"></a>
# **fieldsIdPatch**
> Field fieldsIdPatch(body, id)

Update field

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FieldsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


FieldsApi apiInstance = new FieldsApi();
FieldsIdBody body = new FieldsIdBody(); // FieldsIdBody | 
String id = "id_example"; // String | Field id
try {
    Field result = apiInstance.fieldsIdPatch(body, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling FieldsApi#fieldsIdPatch");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FieldsIdBody**](FieldsIdBody.md)|  |
 **id** | **String**| Field id |

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="fieldsPost"></a>
# **fieldsPost**
> Field fieldsPost(body)

Create field

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.FieldsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


FieldsApi apiInstance = new FieldsApi();
FieldsBody body = new FieldsBody(); // FieldsBody | 
try {
    Field result = apiInstance.fieldsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling FieldsApi#fieldsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FieldsBody**](FieldsBody.md)|  |

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

