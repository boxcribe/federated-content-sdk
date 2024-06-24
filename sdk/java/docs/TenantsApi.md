# TenantsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tenantsGet**](TenantsApi.md#tenantsGet) | **GET** /tenants | Get tenants
[**tenantsIdDelete**](TenantsApi.md#tenantsIdDelete) | **DELETE** /tenants/{id} | Delete tenant
[**tenantsIdGet**](TenantsApi.md#tenantsIdGet) | **GET** /tenants/{id} | Get tenant
[**tenantsIdPatch**](TenantsApi.md#tenantsIdPatch) | **PATCH** /tenants/{id} | Update tenant
[**tenantsPost**](TenantsApi.md#tenantsPost) | **POST** /tenants | Create tenant

<a name="tenantsGet"></a>
# **tenantsGet**
> InlineResponse20012 tenantsGet(company, sort, limit, page)

Get tenants

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TenantsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


TenantsApi apiInstance = new TenantsApi();
String company = "company_example"; // String | Company ID
String sort = "sort_example"; // String | sort by query in the form of field:desc/asc (ex. name:asc)
Integer limit = 56; // Integer | Maximum number of tenants
Integer page = 1; // Integer | Page number
try {
    InlineResponse20012 result = apiInstance.tenantsGet(company, sort, limit, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TenantsApi#tenantsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **String**| Company ID | [optional]
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **Integer**| Maximum number of tenants | [optional] [enum: 1]
 **page** | **Integer**| Page number | [optional] [default to 1] [enum: 1]

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="tenantsIdDelete"></a>
# **tenantsIdDelete**
> tenantsIdDelete(id)

Delete tenant

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TenantsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


TenantsApi apiInstance = new TenantsApi();
String id = "id_example"; // String | Tenant id
try {
    apiInstance.tenantsIdDelete(id);
} catch (ApiException e) {
    System.err.println("Exception when calling TenantsApi#tenantsIdDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Tenant id |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="tenantsIdGet"></a>
# **tenantsIdGet**
> Tenant tenantsIdGet(id)

Get tenant

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TenantsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


TenantsApi apiInstance = new TenantsApi();
String id = "id_example"; // String | Tenant id
try {
    Tenant result = apiInstance.tenantsIdGet(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TenantsApi#tenantsIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Tenant id |

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="tenantsIdPatch"></a>
# **tenantsIdPatch**
> Tenant tenantsIdPatch(body, id)

Update tenant

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TenantsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


TenantsApi apiInstance = new TenantsApi();
TenantsIdBody body = new TenantsIdBody(); // TenantsIdBody | 
String id = "id_example"; // String | Tenant id
try {
    Tenant result = apiInstance.tenantsIdPatch(body, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TenantsApi#tenantsIdPatch");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantsIdBody**](TenantsIdBody.md)|  |
 **id** | **String**| Tenant id |

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="tenantsPost"></a>
# **tenantsPost**
> Tenant tenantsPost(body)

Create tenant

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.TenantsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


TenantsApi apiInstance = new TenantsApi();
TenantsBody body = new TenantsBody(); // TenantsBody | 
try {
    Tenant result = apiInstance.tenantsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling TenantsApi#tenantsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantsBody**](TenantsBody.md)|  |

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

