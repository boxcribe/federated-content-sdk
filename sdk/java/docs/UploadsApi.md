# UploadsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**uploadPost**](UploadsApi.md#uploadPost) | **POST** /upload | Upload a file to AWS S3

<a name="uploadPost"></a>
# **uploadPost**
> InlineResponse200 uploadPost(file)

Upload a file to AWS S3

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UploadsApi;


UploadsApi apiInstance = new UploadsApi();
File file = new File("file_example"); // File | 
try {
    InlineResponse200 result = apiInstance.uploadPost(file);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UploadsApi#uploadPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **File**|  |

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

