# IO.Swagger.Api.UsersApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UsersGet**](UsersApi.md#usersget) | **GET** /users | Get users
[**UsersPost**](UsersApi.md#userspost) | **POST** /users | Create User
[**UsersuserIdDelete**](UsersApi.md#usersuseriddelete) | **DELETE** /users/:userId | Delete User
[**UsersuserIdGet**](UsersApi.md#usersuseridget) | **GET** /users/:userId | Get Users
[**UsersuserIdPatch**](UsersApi.md#usersuseridpatch) | **PATCH** /users/:userId | Update User

<a name="usersget"></a>
# **UsersGet**
> InlineResponse20013 UsersGet (string sort, int? limit, int? page)

Get users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersGetExample
    {
        public void main()
        {


            var apiInstance = new UsersApi();
            var sort = sort_example;  // string | sort by query in the form of field:desc/asc (ex. name:asc) (optional) 
            var limit = 56;  // int? | Maximum number of admins (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get users
                InlineResponse20013 result = apiInstance.UsersGet(sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int?**| Maximum number of admins | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="userspost"></a>
# **UsersPost**
> InlineResponse201 UsersPost (UsersBody body)

Create User

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersPostExample
    {
        public void main()
        {


            var apiInstance = new UsersApi();
            var body = new UsersBody(); // UsersBody | 

            try
            {
                // Create User
                InlineResponse201 result = apiInstance.UsersPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersPost: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseriddelete"></a>
# **UsersuserIdDelete**
> void UsersuserIdDelete ()

Delete User

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersuserIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new UsersApi();

            try
            {
                // Delete User
                apiInstance.UsersuserIdDelete();
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersuserIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridget"></a>
# **UsersuserIdGet**
> InlineResponse201 UsersuserIdGet (string id)

Get Users

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersuserIdGetExample
    {
        public void main()
        {


            var apiInstance = new UsersApi();
            var id = id_example;  // string | User id

            try
            {
                // Get Users
                InlineResponse201 result = apiInstance.UsersuserIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersuserIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| User id | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="usersuseridpatch"></a>
# **UsersuserIdPatch**
> InlineResponse201 UsersuserIdPatch (UsersUserIdBody body)

Update User

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UsersuserIdPatchExample
    {
        public void main()
        {


            var apiInstance = new UsersApi();
            var body = new UsersUserIdBody(); // UsersUserIdBody | 

            try
            {
                // Update User
                InlineResponse201 result = apiInstance.UsersuserIdPatch(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.UsersuserIdPatch: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

