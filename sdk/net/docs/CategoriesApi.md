# IO.Swagger.Api.CategoriesApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CategoriesGet**](CategoriesApi.md#categoriesget) | **GET** /categories | Get categories
[**CategoriesIdDelete**](CategoriesApi.md#categoriesiddelete) | **DELETE** /categories/{id} | Delete category
[**CategoriesIdGet**](CategoriesApi.md#categoriesidget) | **GET** /categories/{id} | Get category
[**CategoriesIdPatch**](CategoriesApi.md#categoriesidpatch) | **PATCH** /categories/{id} | Update category
[**CategoriesPost**](CategoriesApi.md#categoriespost) | **POST** /categories | Create category

<a name="categoriesget"></a>
# **CategoriesGet**
> InlineResponse2004 CategoriesGet (string sort, int? limit, int? page)

Get categories

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoriesGetExample
    {
        public void main()
        {


            var apiInstance = new CategoriesApi();
            var sort = sort_example;  // string | sort by query in the form of field:desc/asc (ex. name:asc) (optional) 
            var limit = 56;  // int? | Maximum number of categories (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get categories
                InlineResponse2004 result = apiInstance.CategoriesGet(sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CategoriesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int?**| Maximum number of categories | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoriesiddelete"></a>
# **CategoriesIdDelete**
> void CategoriesIdDelete (string id)

Delete category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoriesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | Category id

            try
            {
                // Delete category
                apiInstance.CategoriesIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CategoriesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Category id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoriesidget"></a>
# **CategoriesIdGet**
> Category CategoriesIdGet (string id)

Get category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoriesIdGetExample
    {
        public void main()
        {


            var apiInstance = new CategoriesApi();
            var id = id_example;  // string | Category id

            try
            {
                // Get category
                Category result = apiInstance.CategoriesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CategoriesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Category id | 

### Return type

[**Category**](Category.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoriesidpatch"></a>
# **CategoriesIdPatch**
> Category CategoriesIdPatch (CategoriesIdBody body, string id)

Update category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoriesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new CategoriesApi();
            var body = new CategoriesIdBody(); // CategoriesIdBody | 
            var id = id_example;  // string | Category id

            try
            {
                // Update category
                Category result = apiInstance.CategoriesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CategoriesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoriesIdBody**](CategoriesIdBody.md)|  | 
 **id** | **string**| Category id | 

### Return type

[**Category**](Category.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="categoriespost"></a>
# **CategoriesPost**
> Category CategoriesPost (CategoriesBody body)

Create category

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CategoriesPostExample
    {
        public void main()
        {


            var apiInstance = new CategoriesApi();
            var body = new CategoriesBody(); // CategoriesBody | 

            try
            {
                // Create category
                Category result = apiInstance.CategoriesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoriesApi.CategoriesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoriesBody**](CategoriesBody.md)|  | 

### Return type

[**Category**](Category.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

