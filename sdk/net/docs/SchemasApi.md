# IO.Swagger.Api.SchemasApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SchemasGet**](SchemasApi.md#schemasget) | **GET** /schemas | Get schemas
[**SchemasGroupedByEndpointGet**](SchemasApi.md#schemasgroupedbyendpointget) | **GET** /schemas/groupedByEndpoint | Get schemas grouped by endpoint
[**SchemasIdDelete**](SchemasApi.md#schemasiddelete) | **DELETE** /schemas/{id} | Delete schema
[**SchemasIdGet**](SchemasApi.md#schemasidget) | **GET** /schemas/{id} | Get schema
[**SchemasIdPatch**](SchemasApi.md#schemasidpatch) | **PATCH** /schemas/{id} | Update schema
[**SchemasPost**](SchemasApi.md#schemaspost) | **POST** /schemas | Create schema

<a name="schemasget"></a>
# **SchemasGet**
> InlineResponse20010 SchemasGet (Guid? tenant, Guid? category, string sort, int? limit, int? page)

Get schemas

Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SchemasGetExample
    {
        public void main()
        {


            var apiInstance = new SchemasApi();
            var tenant = new Guid?(); // Guid? | Get all schemas for a Tenant ID (optional) 
            var category = new Guid?(); // Guid? | Get all schemas for a Category ID (optional) 
            var sort = sort_example;  // string | Sort by query in the form of field:desc/asc (ex. name:asc) (optional) 
            var limit = 56;  // int? | Maximum number of schemas (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get schemas
                InlineResponse20010 result = apiInstance.SchemasGet(tenant, category, sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemasApi.SchemasGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**Guid?**](.md)| Get all schemas for a Tenant ID | [optional] 
 **category** | [**Guid?**](.md)| Get all schemas for a Category ID | [optional] 
 **sort** | **string**| Sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int?**| Maximum number of schemas | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schemasgroupedbyendpointget"></a>
# **SchemasGroupedByEndpointGet**
> InlineResponse20011 SchemasGroupedByEndpointGet (Guid? tenant, Guid? category, string sort, int? limit, int? page)

Get schemas grouped by endpoint

Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SchemasGroupedByEndpointGetExample
    {
        public void main()
        {


            var apiInstance = new SchemasApi();
            var tenant = new Guid?(); // Guid? | Get all schemas for a Tenant ID (optional) 
            var category = new Guid?(); // Guid? | Get all schemas for a Category ID (optional) 
            var sort = sort_example;  // string | Sort by query in the form of field:desc/asc (ex. endpoint:asc) (optional) 
            var limit = 56;  // int? | Maximum number of schemas (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get schemas grouped by endpoint
                InlineResponse20011 result = apiInstance.SchemasGroupedByEndpointGet(tenant, category, sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemasApi.SchemasGroupedByEndpointGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**Guid?**](.md)| Get all schemas for a Tenant ID | [optional] 
 **category** | [**Guid?**](.md)| Get all schemas for a Category ID | [optional] 
 **sort** | **string**| Sort by query in the form of field:desc/asc (ex. endpoint:asc) | [optional] 
 **limit** | **int?**| Maximum number of schemas | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schemasiddelete"></a>
# **SchemasIdDelete**
> void SchemasIdDelete (string id)

Delete schema

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SchemasIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new SchemasApi();
            var id = id_example;  // string | Schema id

            try
            {
                // Delete schema
                apiInstance.SchemasIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemasApi.SchemasIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Schema id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schemasidget"></a>
# **SchemasIdGet**
> Schema SchemasIdGet (string id)

Get schema

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SchemasIdGetExample
    {
        public void main()
        {


            var apiInstance = new SchemasApi();
            var id = id_example;  // string | Schema id

            try
            {
                // Get schema
                Schema result = apiInstance.SchemasIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemasApi.SchemasIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Schema id | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schemasidpatch"></a>
# **SchemasIdPatch**
> Schema SchemasIdPatch (SchemasIdBody body, string id)

Update schema

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SchemasIdPatchExample
    {
        public void main()
        {


            var apiInstance = new SchemasApi();
            var body = new SchemasIdBody(); // SchemasIdBody | 
            var id = id_example;  // string | Schema id

            try
            {
                // Update schema
                Schema result = apiInstance.SchemasIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemasApi.SchemasIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SchemasIdBody**](SchemasIdBody.md)|  | 
 **id** | **string**| Schema id | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schemaspost"></a>
# **SchemasPost**
> Schema SchemasPost (SchemasBody body)

Create schema

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SchemasPostExample
    {
        public void main()
        {


            var apiInstance = new SchemasApi();
            var body = new SchemasBody(); // SchemasBody | 

            try
            {
                // Create schema
                Schema result = apiInstance.SchemasPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchemasApi.SchemasPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SchemasBody**](SchemasBody.md)|  | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

