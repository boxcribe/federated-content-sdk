# SwaggerClient::UploadsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**upload_post**](UploadsApi.md#upload_post) | **POST** /upload | Upload a file to AWS S3

# **upload_post**
> InlineResponse200 upload_post(file)

Upload a file to AWS S3

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::UploadsApi.new
file = 'file_example' # String | 


begin
  #Upload a file to AWS S3
  result = api_instance.upload_post(file)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling UploadsApi->upload_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **file** | **String**|  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json



