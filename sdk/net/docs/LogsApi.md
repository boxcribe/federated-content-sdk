# IO.Swagger.Api.LogsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LogsGet**](LogsApi.md#logsget) | **GET** /logs | Get logs
[**LogsIdDelete**](LogsApi.md#logsiddelete) | **DELETE** /logs/{id} | Delete log
[**LogsIdGet**](LogsApi.md#logsidget) | **GET** /logs/{id} | Get log
[**LogsIdPatch**](LogsApi.md#logsidpatch) | **PATCH** /logs/{id} | Update log
[**LogsPost**](LogsApi.md#logspost) | **POST** /logs | Create log

<a name="logsget"></a>
# **LogsGet**
> InlineResponse2008 LogsGet (string sort, int? limit, int? page)

Get logs

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogsGetExample
    {
        public void main()
        {


            var apiInstance = new LogsApi();
            var sort = sort_example;  // string | sort by query in the form of field:desc/asc (ex. name:asc) (optional) 
            var limit = 56;  // int? | Maximum number of logs (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get logs
                InlineResponse2008 result = apiInstance.LogsGet(sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.LogsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int?**| Maximum number of logs | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logsiddelete"></a>
# **LogsIdDelete**
> void LogsIdDelete (string id)

Delete log

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new LogsApi();
            var id = id_example;  // string | Log id

            try
            {
                // Delete log
                apiInstance.LogsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.LogsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Log id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logsidget"></a>
# **LogsIdGet**
> Log LogsIdGet (string id)

Get log

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogsIdGetExample
    {
        public void main()
        {


            var apiInstance = new LogsApi();
            var id = id_example;  // string | Log id

            try
            {
                // Get log
                Log result = apiInstance.LogsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.LogsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Log id | 

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logsidpatch"></a>
# **LogsIdPatch**
> Log LogsIdPatch (LogsIdBody body, string id)

Update log

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new LogsApi();
            var body = new LogsIdBody(); // LogsIdBody | 
            var id = id_example;  // string | Log id

            try
            {
                // Update log
                Log result = apiInstance.LogsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.LogsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LogsIdBody**](LogsIdBody.md)|  | 
 **id** | **string**| Log id | 

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="logspost"></a>
# **LogsPost**
> Log LogsPost (LogsBody body)

Create log

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LogsPostExample
    {
        public void main()
        {


            var apiInstance = new LogsApi();
            var body = new LogsBody(); // LogsBody | 

            try
            {
                // Create log
                Log result = apiInstance.LogsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LogsApi.LogsPost: " + e.Message );
            }
        }
    }
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

