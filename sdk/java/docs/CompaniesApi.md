# CompaniesApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companiesGet**](CompaniesApi.md#companiesGet) | **GET** /companies | Get companies
[**companiesIdDelete**](CompaniesApi.md#companiesIdDelete) | **DELETE** /companies/{id} | Delete company
[**companiesIdGet**](CompaniesApi.md#companiesIdGet) | **GET** /companies/{id} | Get company
[**companiesIdPatch**](CompaniesApi.md#companiesIdPatch) | **PATCH** /companies/{id} | Update company
[**companiesPost**](CompaniesApi.md#companiesPost) | **POST** /companies | Create company

<a name="companiesGet"></a>
# **companiesGet**
> InlineResponse2005 companiesGet(sort, limit, page)

Get companies

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CompaniesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


CompaniesApi apiInstance = new CompaniesApi();
String sort = "sort_example"; // String | sort by query in the form of field:desc/asc (ex. name:asc)
Integer limit = 56; // Integer | Maximum number of companies
Integer page = 1; // Integer | Page number
try {
    InlineResponse2005 result = apiInstance.companiesGet(sort, limit, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CompaniesApi#companiesGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **Integer**| Maximum number of companies | [optional] [enum: 1]
 **page** | **Integer**| Page number | [optional] [default to 1] [enum: 1]

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="companiesIdDelete"></a>
# **companiesIdDelete**
> companiesIdDelete(id)

Delete company

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CompaniesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


CompaniesApi apiInstance = new CompaniesApi();
String id = "id_example"; // String | Company id
try {
    apiInstance.companiesIdDelete(id);
} catch (ApiException e) {
    System.err.println("Exception when calling CompaniesApi#companiesIdDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Company id |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="companiesIdGet"></a>
# **companiesIdGet**
> Company companiesIdGet(id)

Get company

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CompaniesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


CompaniesApi apiInstance = new CompaniesApi();
String id = "id_example"; // String | Company id
try {
    Company result = apiInstance.companiesIdGet(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CompaniesApi#companiesIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Company id |

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="companiesIdPatch"></a>
# **companiesIdPatch**
> Company companiesIdPatch(body, id)

Update company

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CompaniesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


CompaniesApi apiInstance = new CompaniesApi();
CompaniesIdBody body = new CompaniesIdBody(); // CompaniesIdBody | 
String id = "id_example"; // String | Company id
try {
    Company result = apiInstance.companiesIdPatch(body, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CompaniesApi#companiesIdPatch");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompaniesIdBody**](CompaniesIdBody.md)|  |
 **id** | **String**| Company id |

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="companiesPost"></a>
# **companiesPost**
> Company companiesPost(body)

Create company

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.CompaniesApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


CompaniesApi apiInstance = new CompaniesApi();
CompaniesBody body = new CompaniesBody(); // CompaniesBody | 
try {
    Company result = apiInstance.companiesPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CompaniesApi#companiesPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompaniesBody**](CompaniesBody.md)|  |

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

