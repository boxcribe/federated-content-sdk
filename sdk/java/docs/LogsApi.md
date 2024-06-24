# LogsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**logsGet**](LogsApi.md#logsGet) | **GET** /logs | Get logs
[**logsIdDelete**](LogsApi.md#logsIdDelete) | **DELETE** /logs/{id} | Delete log
[**logsIdGet**](LogsApi.md#logsIdGet) | **GET** /logs/{id} | Get log
[**logsIdPatch**](LogsApi.md#logsIdPatch) | **PATCH** /logs/{id} | Update log
[**logsPost**](LogsApi.md#logsPost) | **POST** /logs | Create log

<a name="logsGet"></a>
# **logsGet**
> InlineResponse2008 logsGet(sort, limit, page)

Get logs

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.LogsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


LogsApi apiInstance = new LogsApi();
String sort = "sort_example"; // String | sort by query in the form of field:desc/asc (ex. name:asc)
Integer limit = 56; // Integer | Maximum number of logs
Integer page = 1; // Integer | Page number
try {
    InlineResponse2008 result = apiInstance.logsGet(sort, limit, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling LogsApi#logsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **Integer**| Maximum number of logs | [optional] [enum: 1]
 **page** | **Integer**| Page number | [optional] [default to 1] [enum: 1]

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="logsIdDelete"></a>
# **logsIdDelete**
> logsIdDelete(id)

Delete log

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.LogsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


LogsApi apiInstance = new LogsApi();
String id = "id_example"; // String | Log id
try {
    apiInstance.logsIdDelete(id);
} catch (ApiException e) {
    System.err.println("Exception when calling LogsApi#logsIdDelete");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Log id |

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="logsIdGet"></a>
# **logsIdGet**
> Log logsIdGet(id)

Get log

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.LogsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


LogsApi apiInstance = new LogsApi();
String id = "id_example"; // String | Log id
try {
    Log result = apiInstance.logsIdGet(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling LogsApi#logsIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Log id |

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="logsIdPatch"></a>
# **logsIdPatch**
> Log logsIdPatch(body, id)

Update log

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.LogsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


LogsApi apiInstance = new LogsApi();
LogsIdBody body = new LogsIdBody(); // LogsIdBody | 
String id = "id_example"; // String | Log id
try {
    Log result = apiInstance.logsIdPatch(body, id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling LogsApi#logsIdPatch");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LogsIdBody**](LogsIdBody.md)|  |
 **id** | **String**| Log id |

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="logsPost"></a>
# **logsPost**
> Log logsPost(body)

Create log

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.LogsApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


LogsApi apiInstance = new LogsApi();
LogsBody body = new LogsBody(); // LogsBody | 
try {
    Log result = apiInstance.logsPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling LogsApi#logsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LogsBody**](LogsBody.md)|  |

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

