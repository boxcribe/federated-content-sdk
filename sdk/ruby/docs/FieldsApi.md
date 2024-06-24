# SwaggerClient::FieldsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**fields_get**](FieldsApi.md#fields_get) | **GET** /fields | Get fields
[**fields_id_delete**](FieldsApi.md#fields_id_delete) | **DELETE** /fields/{id} | Delete field
[**fields_id_get**](FieldsApi.md#fields_id_get) | **GET** /fields/{id} | Get field
[**fields_id_patch**](FieldsApi.md#fields_id_patch) | **PATCH** /fields/{id} | Update field
[**fields_post**](FieldsApi.md#fields_post) | **POST** /fields | Create field

# **fields_get**
> InlineResponse2006 fields_get(opts)

Get fields

Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::FieldsApi.new
opts = { 
  tenant: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all fields for a Tenant ID
  schema: '38400000-8cf0-11bd-b23e-10b96e4ef00d', # String | Get all fields for a Schema ID
  sort: 'sort_example', # String | sort by query in the form of field:desc/asc (ex. name:asc)
  limit: 56, # Integer | Maximum number of fields
  page: 1 # Integer | Page number
}

begin
  #Get fields
  result = api_instance.fields_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FieldsApi->fields_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**String**](.md)| Get all fields for a Tenant ID | [optional] 
 **schema** | [**String**](.md)| Get all fields for a Schema ID | [optional] 
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **Integer**| Maximum number of fields | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **fields_id_delete**
> fields_id_delete(id)

Delete field

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::FieldsApi.new
id = 'id_example' # String | Field id


begin
  #Delete field
  api_instance.fields_id_delete(id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FieldsApi->fields_id_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Field id | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **fields_id_get**
> Field fields_id_get(id)

Get field

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::FieldsApi.new
id = 'id_example' # String | Field id


begin
  #Get field
  result = api_instance.fields_id_get(id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FieldsApi->fields_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Field id | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **fields_id_patch**
> Field fields_id_patch(bodyid)

Update field

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::FieldsApi.new
body = SwaggerClient::FieldsIdBody.new # FieldsIdBody | 
id = 'id_example' # String | Field id


begin
  #Update field
  result = api_instance.fields_id_patch(bodyid)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FieldsApi->fields_id_patch: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FieldsIdBody**](FieldsIdBody.md)|  | 
 **id** | **String**| Field id | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **fields_post**
> Field fields_post(body)

Create field

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::FieldsApi.new
body = SwaggerClient::FieldsBody.new # FieldsBody | 


begin
  #Create field
  result = api_instance.fields_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FieldsApi->fields_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FieldsBody**](FieldsBody.md)|  | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



