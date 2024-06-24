# SwaggerClient::MappingsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mappings_get**](MappingsApi.md#mappings_get) | **GET** /mappings | Get mappings
[**mappings_id_delete**](MappingsApi.md#mappings_id_delete) | **DELETE** /mappings/{id} | Delete mapping
[**mappings_id_get**](MappingsApi.md#mappings_id_get) | **GET** /mappings/{id} | Get mapping
[**mappings_id_patch**](MappingsApi.md#mappings_id_patch) | **PATCH** /mappings/{id} | Update mapping
[**mappings_post**](MappingsApi.md#mappings_post) | **POST** /mappings | Create mapping

# **mappings_get**
> InlineResponse2009 mappings_get(opts)

Get mappings

Retrieve a list of mappings with the ability to filter by tenant, category, schema, integration, field, sort, limit or page.

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::MappingsApi.new
opts = { 
  tenant: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all mappings for a Tenant ID
  schema: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all mappings for a Schema ID
  field: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all mappings for a Field ID
  integration: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all mappings for an Integration ID
  sort: 'sort_example', # String | sort by query in the form of mapping:desc/asc (ex. name:asc)
  limit: 56, # Integer | Maximum number of mappings
  page: 1 # Integer | Page number
}

begin
  #Get mappings
  result = api_instance.mappings_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling MappingsApi->mappings_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**String**](.md)| Get all mappings for a Tenant ID | [optional] 
 **schema** | [**String**](.md)| Get all mappings for a Schema ID | [optional] 
 **field** | [**String**](.md)| Get all mappings for a Field ID | [optional] 
 **integration** | [**String**](.md)| Get all mappings for an Integration ID | [optional] 
 **sort** | **String**| sort by query in the form of mapping:desc/asc (ex. name:asc) | [optional] 
 **limit** | **Integer**| Maximum number of mappings | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **mappings_id_delete**
> mappings_id_delete(id)

Delete mapping

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::MappingsApi.new
id = 'id_example' # String | Mapping id


begin
  #Delete mapping
  api_instance.mappings_id_delete(id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling MappingsApi->mappings_id_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Mapping id | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **mappings_id_get**
> Mapping mappings_id_get(id)

Get mapping

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::MappingsApi.new
id = 'id_example' # String | Mapping id


begin
  #Get mapping
  result = api_instance.mappings_id_get(id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling MappingsApi->mappings_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Mapping id | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **mappings_id_patch**
> Mapping mappings_id_patch(bodyid)

Update mapping

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::MappingsApi.new
body = SwaggerClient::MappingsIdBody.new # MappingsIdBody | 
id = 'id_example' # String | Mapping id


begin
  #Update mapping
  result = api_instance.mappings_id_patch(bodyid)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling MappingsApi->mappings_id_patch: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MappingsIdBody**](MappingsIdBody.md)|  | 
 **id** | **String**| Mapping id | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **mappings_post**
> Mapping mappings_post(body)

Create mapping

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::MappingsApi.new
body = SwaggerClient::MappingsBody.new # MappingsBody | 


begin
  #Create mapping
  result = api_instance.mappings_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling MappingsApi->mappings_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MappingsBody**](MappingsBody.md)|  | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



