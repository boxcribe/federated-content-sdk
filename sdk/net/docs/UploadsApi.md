# IO.Swagger.Api.UploadsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UploadPost**](UploadsApi.md#uploadpost) | **POST** /upload | Upload a file to AWS S3

<a name="uploadpost"></a>
# **UploadPost**
> InlineResponse200 UploadPost (byte[] file)

Upload a file to AWS S3

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UploadPostExample
    {
        public void main()
        {

            var apiInstance = new UploadsApi();
            var file = file_example;  // byte[] | 

            try
            {
                // Upload a file to AWS S3
                InlineResponse200 result = apiInstance.UploadPost(file);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UploadsApi.UploadPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **byte[]****byte[]**|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

