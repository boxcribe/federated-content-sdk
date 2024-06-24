# IO.Swagger.Api.CompaniesApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompaniesGet**](CompaniesApi.md#companiesget) | **GET** /companies | Get companies
[**CompaniesIdDelete**](CompaniesApi.md#companiesiddelete) | **DELETE** /companies/{id} | Delete company
[**CompaniesIdGet**](CompaniesApi.md#companiesidget) | **GET** /companies/{id} | Get company
[**CompaniesIdPatch**](CompaniesApi.md#companiesidpatch) | **PATCH** /companies/{id} | Update company
[**CompaniesPost**](CompaniesApi.md#companiespost) | **POST** /companies | Create company

<a name="companiesget"></a>
# **CompaniesGet**
> InlineResponse2005 CompaniesGet (string sort, int? limit, int? page)

Get companies

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesGetExample
    {
        public void main()
        {


            var apiInstance = new CompaniesApi();
            var sort = sort_example;  // string | sort by query in the form of field:desc/asc (ex. name:asc) (optional) 
            var limit = 56;  // int? | Maximum number of companies (optional) 
            var page = 56;  // int? | Page number (optional)  (default to 1)

            try
            {
                // Get companies
                InlineResponse2005 result = apiInstance.CompaniesGet(sort, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **string**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int?**| Maximum number of companies | [optional] 
 **page** | **int?**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesiddelete"></a>
# **CompaniesIdDelete**
> void CompaniesIdDelete (string id)

Delete company

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesIdDeleteExample
    {
        public void main()
        {


            var apiInstance = new CompaniesApi();
            var id = id_example;  // string | Company id

            try
            {
                // Delete company
                apiInstance.CompaniesIdDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesIdDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Company id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesidget"></a>
# **CompaniesIdGet**
> Company CompaniesIdGet (string id)

Get company

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesIdGetExample
    {
        public void main()
        {


            var apiInstance = new CompaniesApi();
            var id = id_example;  // string | Company id

            try
            {
                // Get company
                Company result = apiInstance.CompaniesIdGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Company id | 

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesidpatch"></a>
# **CompaniesIdPatch**
> Company CompaniesIdPatch (CompaniesIdBody body, string id)

Update company

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesIdPatchExample
    {
        public void main()
        {


            var apiInstance = new CompaniesApi();
            var body = new CompaniesIdBody(); // CompaniesIdBody | 
            var id = id_example;  // string | Company id

            try
            {
                // Update company
                Company result = apiInstance.CompaniesIdPatch(body, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesIdPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompaniesIdBody**](CompaniesIdBody.md)|  | 
 **id** | **string**| Company id | 

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiespost"></a>
# **CompaniesPost**
> Company CompaniesPost (CompaniesBody body)

Create company

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesPostExample
    {
        public void main()
        {


            var apiInstance = new CompaniesApi();
            var body = new CompaniesBody(); // CompaniesBody | 

            try
            {
                // Create company
                Company result = apiInstance.CompaniesPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompaniesBody**](CompaniesBody.md)|  | 

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

