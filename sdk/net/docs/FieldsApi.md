# IO.Swagger.Api.FieldsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FieldsGet**](FieldsApi.md#fieldsget) | **GET** /fields | Get fields
[**FieldsIdDelete**](FieldsApi.md#fieldsiddelete) | **DELETE** /fields/{id} | Delete field
[**FieldsIdGet**](FieldsApi.md#fieldsidget) | **GET** /fields/{id} | Get field
[**FieldsIdPatch**](FieldsApi.md#fieldsidpatch) | **PATCH** /fields/{id} | Update field
[**FieldsPost**](FieldsApi.md#fieldspost) | **POST** /fields | Create field

<a name="fieldsget"></a>
# **FieldsGet**
> InlineResponse2006 FieldsGet (Guid? tenant, Guid? schema, string sort, int? limit, int? page)

Get fields

Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldsGetExample
    {
        public void main()
        {


            var apiInstance = new FieldsApi();
            var tenant = new Guid?(); // Guid? | Get all fields for a Tenant ID (optional) 
            var schema = new Guid?(); // Guid? | Get all fields for a Schema ID (optional) 
            var sort = sort_example;  // string | sort by query in the form of field:desc/asc (ex. name:asc) (optional) 
            var limit = 56;  // int? | Maximum number of fields (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get fields
                InlineResponse2006 result = apiInstance.FieldsGet(tenant, schema, sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**Guid?**](.md)| Get all fields for a Tenant ID | [optional] 
 **schema** | [**Guid?**](.md)| Get all fields for a Schema ID | [optional] 
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int?**| Maximum number of fields | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldsiddelete"></a>
# **FieldsIdDelete**
> void FieldsIdDelete (string id)

Delete field

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new FieldsApi();
            var id = id_example;  // string | Field id

            try
            {
                // Delete field
                apiInstance.FieldsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Field id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldsidget"></a>
# **FieldsIdGet**
> Field FieldsIdGet (string id)

Get field

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldsIdGetExample
    {
        public void main()
        {


            var apiInstance = new FieldsApi();
            var id = id_example;  // string | Field id

            try
            {
                // Get field
                Field result = apiInstance.FieldsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Field id | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldsidpatch"></a>
# **FieldsIdPatch**
> Field FieldsIdPatch (FieldsIdBody body, string id)

Update field

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new FieldsApi();
            var body = new FieldsIdBody(); // FieldsIdBody | 
            var id = id_example;  // string | Field id

            try
            {
                // Update field
                Field result = apiInstance.FieldsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FieldsIdBody**](FieldsIdBody.md)|  | 
 **id** | **string**| Field id | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fieldspost"></a>
# **FieldsPost**
> Field FieldsPost (FieldsBody body)

Create field

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FieldsPostExample
    {
        public void main()
        {


            var apiInstance = new FieldsApi();
            var body = new FieldsBody(); // FieldsBody | 

            try
            {
                // Create field
                Field result = apiInstance.FieldsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FieldsApi.FieldsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FieldsBody**](FieldsBody.md)|  | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

