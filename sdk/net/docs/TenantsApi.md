# IO.Swagger.Api.TenantsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TenantsGet**](TenantsApi.md#tenantsget) | **GET** /tenants | Get tenants
[**TenantsIdDelete**](TenantsApi.md#tenantsiddelete) | **DELETE** /tenants/{id} | Delete tenant
[**TenantsIdGet**](TenantsApi.md#tenantsidget) | **GET** /tenants/{id} | Get tenant
[**TenantsIdPatch**](TenantsApi.md#tenantsidpatch) | **PATCH** /tenants/{id} | Update tenant
[**TenantsPost**](TenantsApi.md#tenantspost) | **POST** /tenants | Create tenant

<a name="tenantsget"></a>
# **TenantsGet**
> InlineResponse20012 TenantsGet (string company, string sort, int? limit, int? page)

Get tenants

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TenantsGetExample
    {
        public void main()
        {


            var apiInstance = new TenantsApi();
            var company = company_example;  // string | Company ID (optional) 
            var sort = sort_example;  // string | sort by query in the form of field:desc/asc (ex. name:asc) (optional) 
            var limit = 56;  // int? | Maximum number of tenants (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get tenants
                InlineResponse20012 result = apiInstance.TenantsGet(company, sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.TenantsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **string**| Company ID | [optional] 
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int?**| Maximum number of tenants | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tenantsiddelete"></a>
# **TenantsIdDelete**
> void TenantsIdDelete (string id)

Delete tenant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TenantsIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new TenantsApi();
            var id = id_example;  // string | Tenant id

            try
            {
                // Delete tenant
                apiInstance.TenantsIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.TenantsIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tenant id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tenantsidget"></a>
# **TenantsIdGet**
> Tenant TenantsIdGet (string id)

Get tenant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TenantsIdGetExample
    {
        public void main()
        {


            var apiInstance = new TenantsApi();
            var id = id_example;  // string | Tenant id

            try
            {
                // Get tenant
                Tenant result = apiInstance.TenantsIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.TenantsIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Tenant id | 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tenantsidpatch"></a>
# **TenantsIdPatch**
> Tenant TenantsIdPatch (TenantsIdBody body, string id)

Update tenant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TenantsIdPatchExample
    {
        public void main()
        {


            var apiInstance = new TenantsApi();
            var body = new TenantsIdBody(); // TenantsIdBody | 
            var id = id_example;  // string | Tenant id

            try
            {
                // Update tenant
                Tenant result = apiInstance.TenantsIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.TenantsIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantsIdBody**](TenantsIdBody.md)|  | 
 **id** | **string**| Tenant id | 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="tenantspost"></a>
# **TenantsPost**
> Tenant TenantsPost (TenantsBody body)

Create tenant

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TenantsPostExample
    {
        public void main()
        {


            var apiInstance = new TenantsApi();
            var body = new TenantsBody(); // TenantsBody | 

            try
            {
                // Create tenant
                Tenant result = apiInstance.TenantsPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TenantsApi.TenantsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantsBody**](TenantsBody.md)|  | 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

