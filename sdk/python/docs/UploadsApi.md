# swagger_client.UploadsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**upload_post**](UploadsApi.md#upload_post) | **POST** /upload | Upload a file to AWS S3

# **upload_post**
> InlineResponse200 upload_post(file)

Upload a file to AWS S3

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.UploadsApi()
file = 'file_example' # str | 

try:
    # Upload a file to AWS S3
    api_response = api_instance.upload_post(file)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling UploadsApi->upload_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **str**|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

