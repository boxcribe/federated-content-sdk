# IO.Swagger.Api.HealthCheckApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HelpGet**](HealthCheckApi.md#helpget) | **GET** /help | Help

<a name="helpget"></a>
# **HelpGet**
> InlineResponse2001 HelpGet ()

Help

Returns a message indicating that the API is up and running.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class HelpGetExample
    {
        public void main()
        {

            var apiInstance = new HealthCheckApi();

            try
            {
                // Help
                InlineResponse2001 result = apiInstance.HelpGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling HealthCheckApi.HelpGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

