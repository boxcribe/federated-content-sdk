# IO.Swagger.Api.ApiKeysApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApikeysGet**](ApiKeysApi.md#apikeysget) | **GET** /apikeys | Get api keys
[**ApikeysIdDelete**](ApiKeysApi.md#apikeysiddelete) | **DELETE** /apikeys/{id} | Delete api key
[**ApikeysIdGet**](ApiKeysApi.md#apikeysidget) | **GET** /apikeys/{id} | Get api key
[**ApikeysIdPatch**](ApiKeysApi.md#apikeysidpatch) | **PATCH** /apikeys/{id} | Update api key
[**ApikeysPost**](ApiKeysApi.md#apikeyspost) | **POST** /apikeys | Create api key

<a name="apikeysget"></a>
# **ApikeysGet**
> InlineResponse2002 ApikeysGet (string tenant, string environment, string sort, int? limit, int? page)

Get api keys

Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApikeysGetExample
    {
        public void main()
        {


            var apiInstance = new ApiKeysApi();
            var tenant = tenant_example;  // string | Get all schemas for a Tenant ID (optional) 
            var environment = environment_example;  // string | Get all schemas for an Environment (Sandbox or Production) (optional) 
            var sort = sort_example;  // string | sort by query in the form of field:desc/asc (ex. name:asc) (optional) 
            var limit = 56;  // int? | Maximum number of apiKeys (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get api keys
                InlineResponse2002 result = apiInstance.ApikeysGet(tenant, environment, sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ApikeysGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | **string**| Get all schemas for a Tenant ID | [optional] 
 **environment** | **string**| Get all schemas for an Environment (Sandbox or Production) | [optional] 
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int?**| Maximum number of apiKeys | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apikeysiddelete"></a>
# **ApikeysIdDelete**
> void ApikeysIdDelete (string id)

Delete api key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApikeysIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new ApiKeysApi();
            var id = id_example;  // string | Api Key ID

            try
            {
                // Delete api key
                apiInstance.ApikeysIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ApikeysIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Api Key ID | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apikeysidget"></a>
# **ApikeysIdGet**
> ApiKey ApikeysIdGet (string id)

Get api key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApikeysIdGetExample
    {
        public void main()
        {


            var apiInstance = new ApiKeysApi();
            var id = id_example;  // string | Api Key ID

            try
            {
                // Get api key
                ApiKey result = apiInstance.ApikeysIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ApikeysIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Api Key ID | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apikeysidpatch"></a>
# **ApikeysIdPatch**
> ApiKey ApikeysIdPatch (ApikeysIdBody body, string id)

Update api key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApikeysIdPatchExample
    {
        public void main()
        {


            var apiInstance = new ApiKeysApi();
            var body = new ApikeysIdBody(); // ApikeysIdBody | 
            var id = id_example;  // string | Api Key ID

            try
            {
                // Update api key
                ApiKey result = apiInstance.ApikeysIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ApikeysIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApikeysIdBody**](ApikeysIdBody.md)|  | 
 **id** | **string**| Api Key ID | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="apikeyspost"></a>
# **ApikeysPost**
> ApiKey ApikeysPost (ApikeysBody body)

Create api key

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ApikeysPostExample
    {
        public void main()
        {


            var apiInstance = new ApiKeysApi();
            var body = new ApikeysBody(); // ApikeysBody | 

            try
            {
                // Create api key
                ApiKey result = apiInstance.ApikeysPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApiKeysApi.ApikeysPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApikeysBody**](ApikeysBody.md)|  | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

