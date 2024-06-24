# HealthCheckApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**helpGet**](HealthCheckApi.md#helpGet) | **GET** /help | Help

<a name="helpGet"></a>
# **helpGet**
> InlineResponse2001 helpGet()

Help

Returns a message indicating that the API is up and running.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.HealthCheckApi;


HealthCheckApi apiInstance = new HealthCheckApi();
try {
    InlineResponse2001 result = apiInstance.helpGet();
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling HealthCheckApi#helpGet");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

