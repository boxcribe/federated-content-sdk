# IO.Swagger.Api.MappingsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**MappingsGet**](MappingsApi.md#mappingsget) | **GET** /mappings | Get mappings
[**MappingsIdDelete**](MappingsApi.md#mappingsiddelete) | **DELETE** /mappings/{id} | Delete mapping
[**MappingsIdGet**](MappingsApi.md#mappingsidget) | **GET** /mappings/{id} | Get mapping
[**MappingsIdPatch**](MappingsApi.md#mappingsidpatch) | **PATCH** /mappings/{id} | Update mapping
[**MappingsPost**](MappingsApi.md#mappingspost) | **POST** /mappings | Create mapping

<a name="mappingsget"></a>
# **MappingsGet**
> InlineResponse2009 MappingsGet (Guid? tenant, Guid? schema, Guid? field, Guid? integration, string sort, int? limit, int? page)

Get mappings

Retrieve a list of mappings with the ability to filter by tenant, category, schema, integration, field, sort, limit or page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MappingsGetExample
    {
        public void main()
        {


            var apiInstance = new MappingsApi();
            var tenant = new Guid?(); // Guid? | Get all mappings for a Tenant ID (optional) 
            var schema = new Guid?(); // Guid? | Get all mappings for a Schema ID (optional) 
            var field = new Guid?(); // Guid? | Get all mappings for a Field ID (optional) 
            var integration = new Guid?(); // Guid? | Get all mappings for an Integration ID (optional) 
            var sort = sort_example;  // string | sort by query in the form of mapping:desc/asc (ex. name:asc) (optional) 
            var limit = 56;  // int? | Maximum number of mappings (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get mappings
                InlineResponse2009 result = apiInstance.MappingsGet(tenant, schema, field, integration, sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MappingsApi.MappingsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**Guid?**](.md)| Get all mappings for a Tenant ID | [optional] 
 **schema** | [**Guid?**](.md)| Get all mappings for a Schema ID | [optional] 
 **field** | [**Guid?**](.md)| Get all mappings for a Field ID | [optional] 
 **integration** | [**Guid?**](.md)| Get all mappings for an Integration ID | [optional] 
 **sort** | **string**| sort by query in the form of mapping:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int?**| Maximum number of mappings | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mappingsiddelete"></a>
# **MappingsIdDelete**
> void MappingsIdDelete (string id)

Delete mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MappingsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new MappingsApi();
            var id = id_example;  // string | Mapping id

            try
            {
                // Delete mapping
                apiInstance.MappingsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MappingsApi.MappingsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Mapping id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mappingsidget"></a>
# **MappingsIdGet**
> Mapping MappingsIdGet (string id)

Get mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MappingsIdGetExample
    {
        public void main()
        {


            var apiInstance = new MappingsApi();
            var id = id_example;  // string | Mapping id

            try
            {
                // Get mapping
                Mapping result = apiInstance.MappingsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MappingsApi.MappingsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Mapping id | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mappingsidpatch"></a>
# **MappingsIdPatch**
> Mapping MappingsIdPatch (MappingsIdBody body, string id)

Update mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MappingsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new MappingsApi();
            var body = new MappingsIdBody(); // MappingsIdBody | 
            var id = id_example;  // string | Mapping id

            try
            {
                // Update mapping
                Mapping result = apiInstance.MappingsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MappingsApi.MappingsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MappingsIdBody**](MappingsIdBody.md)|  | 
 **id** | **string**| Mapping id | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mappingspost"></a>
# **MappingsPost**
> Mapping MappingsPost (MappingsBody body)

Create mapping

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MappingsPostExample
    {
        public void main()
        {


            var apiInstance = new MappingsApi();
            var body = new MappingsBody(); // MappingsBody | 

            try
            {
                // Create mapping
                Mapping result = apiInstance.MappingsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MappingsApi.MappingsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MappingsBody**](MappingsBody.md)|  | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

