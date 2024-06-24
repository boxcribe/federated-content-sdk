# SwaggerClient::SchemasApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**schemas_get**](SchemasApi.md#schemas_get) | **GET** /schemas | Get schemas
[**schemas_grouped_by_endpoint_get**](SchemasApi.md#schemas_grouped_by_endpoint_get) | **GET** /schemas/groupedByEndpoint | Get schemas grouped by endpoint
[**schemas_id_delete**](SchemasApi.md#schemas_id_delete) | **DELETE** /schemas/{id} | Delete schema
[**schemas_id_get**](SchemasApi.md#schemas_id_get) | **GET** /schemas/{id} | Get schema
[**schemas_id_patch**](SchemasApi.md#schemas_id_patch) | **PATCH** /schemas/{id} | Update schema
[**schemas_post**](SchemasApi.md#schemas_post) | **POST** /schemas | Create schema

# **schemas_get**
> InlineResponse20010 schemas_get(opts)

Get schemas

Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::SchemasApi.new
opts = { 
  tenant: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all schemas for a Tenant ID
  category: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all schemas for a Category ID
  sort: 'sort_example', # String | Sort by query in the form of field:desc/asc (ex. name:asc)
  limit: 56, # Integer | Maximum number of schemas
  page: 1 # Integer | Page number
}

begin
  #Get schemas
  result = api_instance.schemas_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling SchemasApi->schemas_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**String**](.md)| Get all schemas for a Tenant ID | [optional] 
 **category** | [**String**](.md)| Get all schemas for a Category ID | [optional] 
 **sort** | **String**| Sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **Integer**| Maximum number of schemas | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **schemas_grouped_by_endpoint_get**
> InlineResponse20011 schemas_grouped_by_endpoint_get(opts)

Get schemas grouped by endpoint

Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::SchemasApi.new
opts = { 
  tenant: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all schemas for a Tenant ID
  category: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all schemas for a Category ID
  sort: 'sort_example', # String | Sort by query in the form of field:desc/asc (ex. endpoint:asc)
  limit: 56, # Integer | Maximum number of schemas
  page: 1 # Integer | Page number
}

begin
  #Get schemas grouped by endpoint
  result = api_instance.schemas_grouped_by_endpoint_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling SchemasApi->schemas_grouped_by_endpoint_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**String**](.md)| Get all schemas for a Tenant ID | [optional] 
 **category** | [**String**](.md)| Get all schemas for a Category ID | [optional] 
 **sort** | **String**| Sort by query in the form of field:desc/asc (ex. endpoint:asc) | [optional] 
 **limit** | **Integer**| Maximum number of schemas | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **schemas_id_delete**
> schemas_id_delete(id)

Delete schema

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::SchemasApi.new
id = 'id_example' # String | Schema id


begin
  #Delete schema
  api_instance.schemas_id_delete(id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling SchemasApi->schemas_id_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Schema id | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **schemas_id_get**
> Schema schemas_id_get(id)

Get schema

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::SchemasApi.new
id = 'id_example' # String | Schema id


begin
  #Get schema
  result = api_instance.schemas_id_get(id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling SchemasApi->schemas_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Schema id | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **schemas_id_patch**
> Schema schemas_id_patch(bodyid)

Update schema

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::SchemasApi.new
body = SwaggerClient::SchemasIdBody.new # SchemasIdBody | 
id = 'id_example' # String | Schema id


begin
  #Update schema
  result = api_instance.schemas_id_patch(bodyid)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling SchemasApi->schemas_id_patch: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SchemasIdBody**](SchemasIdBody.md)|  | 
 **id** | **String**| Schema id | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **schemas_post**
> Schema schemas_post(body)

Create schema

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::SchemasApi.new
body = SwaggerClient::SchemasBody.new # SchemasBody | 


begin
  #Create schema
  result = api_instance.schemas_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling SchemasApi->schemas_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SchemasBody**](SchemasBody.md)|  | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



