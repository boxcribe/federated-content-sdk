# SwaggerClient::LogsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**logs_get**](LogsApi.md#logs_get) | **GET** /logs | Get logs
[**logs_id_delete**](LogsApi.md#logs_id_delete) | **DELETE** /logs/{id} | Delete log
[**logs_id_get**](LogsApi.md#logs_id_get) | **GET** /logs/{id} | Get log
[**logs_id_patch**](LogsApi.md#logs_id_patch) | **PATCH** /logs/{id} | Update log
[**logs_post**](LogsApi.md#logs_post) | **POST** /logs | Create log

# **logs_get**
> InlineResponse2008 logs_get(opts)

Get logs

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::LogsApi.new
opts = { 
  sort: 'sort_example', # String | sort by query in the form of field:desc/asc (ex. name:asc)
  limit: 56, # Integer | Maximum number of logs
  page: 1 # Integer | Page number
}

begin
  #Get logs
  result = api_instance.logs_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling LogsApi->logs_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **Integer**| Maximum number of logs | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **logs_id_delete**
> logs_id_delete(id)

Delete log

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::LogsApi.new
id = 'id_example' # String | Log id


begin
  #Delete log
  api_instance.logs_id_delete(id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling LogsApi->logs_id_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Log id | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **logs_id_get**
> Log logs_id_get(id)

Get log

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::LogsApi.new
id = 'id_example' # String | Log id


begin
  #Get log
  result = api_instance.logs_id_get(id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling LogsApi->logs_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Log id | 

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **logs_id_patch**
> Log logs_id_patch(bodyid)

Update log

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::LogsApi.new
body = SwaggerClient::LogsIdBody.new # LogsIdBody | 
id = 'id_example' # String | Log id


begin
  #Update log
  result = api_instance.logs_id_patch(bodyid)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling LogsApi->logs_id_patch: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LogsIdBody**](LogsIdBody.md)|  | 
 **id** | **String**| Log id | 

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **logs_post**
> Log logs_post(body)

Create log

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::LogsApi.new
body = SwaggerClient::LogsBody.new # LogsBody | 


begin
  #Create log
  result = api_instance.logs_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling LogsApi->logs_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LogsBody**](LogsBody.md)|  | 

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



