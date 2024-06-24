# SwaggerClient::HealthCheckApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**help_get**](HealthCheckApi.md#help_get) | **GET** /help | Help

# **help_get**
> InlineResponse2001 help_get

Help

Returns a message indicating that the API is up and running.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::HealthCheckApi.new

begin
  #Help
  result = api_instance.help_get
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling HealthCheckApi->help_get: #{e}"
end
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



