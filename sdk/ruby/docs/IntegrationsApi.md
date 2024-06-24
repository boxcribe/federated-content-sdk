# SwaggerClient::IntegrationsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**integrations_get**](IntegrationsApi.md#integrations_get) | **GET** /integrations | Get integrations
[**integrations_id_delete**](IntegrationsApi.md#integrations_id_delete) | **DELETE** /integrations/{id} | Delete integration
[**integrations_id_get**](IntegrationsApi.md#integrations_id_get) | **GET** /integrations/{id} | Get integration
[**integrations_id_patch**](IntegrationsApi.md#integrations_id_patch) | **PATCH** /integrations/{id} | Update integration
[**integrations_post**](IntegrationsApi.md#integrations_post) | **POST** /integrations | Create integration

# **integrations_get**
> InlineResponse2007 integrations_get(opts)

Get integrations

Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::IntegrationsApi.new
opts = { 
  tenant: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all integrations for a Tenant ID
  category: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all integrations for a Category ID
  sort: 'sort_example', # String | sort by query in the form of field:desc/asc (ex. name:asc)
  limit: 56, # Integer | Maximum number of integrations
  page: 1 # Integer | Page number
}

begin
  #Get integrations
  result = api_instance.integrations_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling IntegrationsApi->integrations_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**String**](.md)| Get all integrations for a Tenant ID | [optional] 
 **category** | [**String**](.md)| Get all integrations for a Category ID | [optional] 
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **Integer**| Maximum number of integrations | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **integrations_id_delete**
> integrations_id_delete(id)

Delete integration

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::IntegrationsApi.new
id = 'id_example' # String | Integration id


begin
  #Delete integration
  api_instance.integrations_id_delete(id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling IntegrationsApi->integrations_id_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Integration id | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **integrations_id_get**
> Integration integrations_id_get(id)

Get integration

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::IntegrationsApi.new
id = 'id_example' # String | Integration id


begin
  #Get integration
  result = api_instance.integrations_id_get(id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling IntegrationsApi->integrations_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Integration id | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **integrations_id_patch**
> Integration integrations_id_patch(bodyid)

Update integration

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::IntegrationsApi.new
body = SwaggerClient::IntegrationsIdBody.new # IntegrationsIdBody | 
id = 'id_example' # String | Integration id


begin
  #Update integration
  result = api_instance.integrations_id_patch(bodyid)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling IntegrationsApi->integrations_id_patch: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IntegrationsIdBody**](IntegrationsIdBody.md)|  | 
 **id** | **String**| Integration id | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **integrations_post**
> Integration integrations_post(body)

Create integration

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::IntegrationsApi.new
body = SwaggerClient::IntegrationsBody.new # IntegrationsBody | 


begin
  #Create integration
  result = api_instance.integrations_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling IntegrationsApi->integrations_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IntegrationsBody**](IntegrationsBody.md)|  | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



