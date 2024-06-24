# SwaggerClient::ApiKeysApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apikeys_get**](ApiKeysApi.md#apikeys_get) | **GET** /apikeys | Get api keys
[**apikeys_id_delete**](ApiKeysApi.md#apikeys_id_delete) | **DELETE** /apikeys/{id} | Delete api key
[**apikeys_id_get**](ApiKeysApi.md#apikeys_id_get) | **GET** /apikeys/{id} | Get api key
[**apikeys_id_patch**](ApiKeysApi.md#apikeys_id_patch) | **PATCH** /apikeys/{id} | Update api key
[**apikeys_post**](ApiKeysApi.md#apikeys_post) | **POST** /apikeys | Create api key

# **apikeys_get**
> InlineResponse2002 apikeys_get(opts)

Get api keys

Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::ApiKeysApi.new
opts = { 
  tenant: 'tenant_example', # String | Get all schemas for a Tenant ID
  environment: 'environment_example', # String | Get all schemas for an Environment (Sandbox or Production)
  sort: 'sort_example', # String | sort by query in the form of field:desc/asc (ex. name:asc)
  limit: 56, # Integer | Maximum number of apiKeys
  page: 1 # Integer | Page number
}

begin
  #Get api keys
  result = api_instance.apikeys_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ApiKeysApi->apikeys_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | **String**| Get all schemas for a Tenant ID | [optional] 
 **environment** | **String**| Get all schemas for an Environment (Sandbox or Production) | [optional] 
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **Integer**| Maximum number of apiKeys | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **apikeys_id_delete**
> apikeys_id_delete(id)

Delete api key

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::ApiKeysApi.new
id = 'id_example' # String | Api Key ID


begin
  #Delete api key
  api_instance.apikeys_id_delete(id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ApiKeysApi->apikeys_id_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Api Key ID | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **apikeys_id_get**
> ApiKey apikeys_id_get(id)

Get api key

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::ApiKeysApi.new
id = 'id_example' # String | Api Key ID


begin
  #Get api key
  result = api_instance.apikeys_id_get(id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ApiKeysApi->apikeys_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Api Key ID | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **apikeys_id_patch**
> ApiKey apikeys_id_patch(bodyid)

Update api key

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::ApiKeysApi.new
body = SwaggerClient::ApikeysIdBody.new # ApikeysIdBody | 
id = 'id_example' # String | Api Key ID


begin
  #Update api key
  result = api_instance.apikeys_id_patch(bodyid)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ApiKeysApi->apikeys_id_patch: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApikeysIdBody**](ApikeysIdBody.md)|  | 
 **id** | **String**| Api Key ID | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **apikeys_post**
> ApiKey apikeys_post(body)

Create api key

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::ApiKeysApi.new
body = SwaggerClient::ApikeysBody.new # ApikeysBody | 


begin
  #Create api key
  result = api_instance.apikeys_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ApiKeysApi->apikeys_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApikeysBody**](ApikeysBody.md)|  | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



