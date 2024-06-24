# IO.Swagger.Api.IntegrationsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**IntegrationsGet**](IntegrationsApi.md#integrationsget) | **GET** /integrations | Get integrations
[**IntegrationsIdDelete**](IntegrationsApi.md#integrationsiddelete) | **DELETE** /integrations/{id} | Delete integration
[**IntegrationsIdGet**](IntegrationsApi.md#integrationsidget) | **GET** /integrations/{id} | Get integration
[**IntegrationsIdPatch**](IntegrationsApi.md#integrationsidpatch) | **PATCH** /integrations/{id} | Update integration
[**IntegrationsPost**](IntegrationsApi.md#integrationspost) | **POST** /integrations | Create integration

<a name="integrationsget"></a>
# **IntegrationsGet**
> InlineResponse2007 IntegrationsGet (Guid? tenant, Guid? category, string sort, int? limit, int? page)

Get integrations

Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IntegrationsGetExample
    {
        public void main()
        {


            var apiInstance = new IntegrationsApi();
            var tenant = new Guid?(); // Guid? | Get all integrations for a Tenant ID (optional) 
            var category = new Guid?(); // Guid? | Get all integrations for a Category ID (optional) 
            var sort = sort_example;  // string | sort by query in the form of field:desc/asc (ex. name:asc) (optional) 
            var limit = 56;  // int? | Maximum number of integrations (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get integrations
                InlineResponse2007 result = apiInstance.IntegrationsGet(tenant, category, sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.IntegrationsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**Guid?**](.md)| Get all integrations for a Tenant ID | [optional] 
 **category** | [**Guid?**](.md)| Get all integrations for a Category ID | [optional] 
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int?**| Maximum number of integrations | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationsiddelete"></a>
# **IntegrationsIdDelete**
> void IntegrationsIdDelete (string id)

Delete integration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IntegrationsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new IntegrationsApi();
            var id = id_example;  // string | Integration id

            try
            {
                // Delete integration
                apiInstance.IntegrationsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.IntegrationsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Integration id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationsidget"></a>
# **IntegrationsIdGet**
> Integration IntegrationsIdGet (string id)

Get integration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IntegrationsIdGetExample
    {
        public void main()
        {


            var apiInstance = new IntegrationsApi();
            var id = id_example;  // string | Integration id

            try
            {
                // Get integration
                Integration result = apiInstance.IntegrationsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.IntegrationsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Integration id | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationsidpatch"></a>
# **IntegrationsIdPatch**
> Integration IntegrationsIdPatch (IntegrationsIdBody body, string id)

Update integration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IntegrationsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new IntegrationsApi();
            var body = new IntegrationsIdBody(); // IntegrationsIdBody | 
            var id = id_example;  // string | Integration id

            try
            {
                // Update integration
                Integration result = apiInstance.IntegrationsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.IntegrationsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IntegrationsIdBody**](IntegrationsIdBody.md)|  | 
 **id** | **string**| Integration id | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="integrationspost"></a>
# **IntegrationsPost**
> Integration IntegrationsPost (IntegrationsBody body)

Create integration

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class IntegrationsPostExample
    {
        public void main()
        {


            var apiInstance = new IntegrationsApi();
            var body = new IntegrationsBody(); // IntegrationsBody | 

            try
            {
                // Create integration
                Integration result = apiInstance.IntegrationsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IntegrationsApi.IntegrationsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IntegrationsBody**](IntegrationsBody.md)|  | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

