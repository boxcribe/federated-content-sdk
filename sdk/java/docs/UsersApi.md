# UsersApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**usersGet**](UsersApi.md#usersGet) | **GET** /users | Get users
[**usersPost**](UsersApi.md#usersPost) | **POST** /users | Create User
[**usersuserIdDelete**](UsersApi.md#usersuserIdDelete) | **DELETE** /users/:userId | Delete User
[**usersuserIdGet**](UsersApi.md#usersuserIdGet) | **GET** /users/:userId | Get Users
[**usersuserIdPatch**](UsersApi.md#usersuserIdPatch) | **PATCH** /users/:userId | Update User

<a name="usersGet"></a>
# **usersGet**
> InlineResponse20013 usersGet(sort, limit, page)

Get users

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.UsersApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


UsersApi apiInstance = new UsersApi();
String sort = "sort_example"; // String | sort by query in the form of field:desc/asc (ex. name:asc)
Integer limit = 56; // Integer | Maximum number of admins
Integer page = 1; // Integer | Page number
try {
    InlineResponse20013 result = apiInstance.usersGet(sort, limit, page);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UsersApi#usersGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional]
 **limit** | **Integer**| Maximum number of admins | [optional] [enum: 1]
 **page** | **Integer**| Page number | [optional] [default to 1] [enum: 1]

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="usersPost"></a>
# **usersPost**
> InlineResponse201 usersPost(body)

Create User

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.UsersApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


UsersApi apiInstance = new UsersApi();
UsersBody body = new UsersBody(); // UsersBody | 
try {
    InlineResponse201 result = apiInstance.usersPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UsersApi#usersPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersBody**](UsersBody.md)|  |

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="usersuserIdDelete"></a>
# **usersuserIdDelete**
> usersuserIdDelete()

Delete User

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.UsersApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


UsersApi apiInstance = new UsersApi();
try {
    apiInstance.usersuserIdDelete();
} catch (ApiException e) {
    System.err.println("Exception when calling UsersApi#usersuserIdDelete");
    e.printStackTrace();
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

null (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="usersuserIdGet"></a>
# **usersuserIdGet**
> InlineResponse201 usersuserIdGet(id)

Get Users

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.UsersApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


UsersApi apiInstance = new UsersApi();
String id = "id_example"; // String | User id
try {
    InlineResponse201 result = apiInstance.usersuserIdGet(id);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UsersApi#usersuserIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| User id |

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="usersuserIdPatch"></a>
# **usersuserIdPatch**
> InlineResponse201 usersuserIdPatch(body)

Update User

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.UsersApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();


UsersApi apiInstance = new UsersApi();
UsersUserIdBody body = new UsersUserIdBody(); // UsersUserIdBody | 
try {
    InlineResponse201 result = apiInstance.usersuserIdPatch(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UsersApi#usersuserIdPatch");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersUserIdBody**](UsersUserIdBody.md)|  |

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

