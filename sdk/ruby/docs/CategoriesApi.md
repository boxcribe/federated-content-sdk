# SwaggerClient::CategoriesApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**categories_get**](CategoriesApi.md#categories_get) | **GET** /categories | Get categories
[**categories_id_delete**](CategoriesApi.md#categories_id_delete) | **DELETE** /categories/{id} | Delete category
[**categories_id_get**](CategoriesApi.md#categories_id_get) | **GET** /categories/{id} | Get category
[**categories_id_patch**](CategoriesApi.md#categories_id_patch) | **PATCH** /categories/{id} | Update category
[**categories_post**](CategoriesApi.md#categories_post) | **POST** /categories | Create category

# **categories_get**
> InlineResponse2004 categories_get(opts)

Get categories

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::CategoriesApi.new
opts = { 
  sort: 'sort_example', # String | sort by query in the form of field:desc/asc (ex. name:asc)
  limit: 56, # Integer | Maximum number of categories
  page: 1 # Integer | Page number
}

begin
  #Get categories
  result = api_instance.categories_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CategoriesApi->categories_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **Integer**| Maximum number of categories | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **categories_id_delete**
> categories_id_delete(id)

Delete category

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::CategoriesApi.new
id = 'id_example' # String | Category id


begin
  #Delete category
  api_instance.categories_id_delete(id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CategoriesApi->categories_id_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Category id | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **categories_id_get**
> Category categories_id_get(id)

Get category

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::CategoriesApi.new
id = 'id_example' # String | Category id


begin
  #Get category
  result = api_instance.categories_id_get(id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CategoriesApi->categories_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Category id | 

### Return type

[**Category**](Category.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **categories_id_patch**
> Category categories_id_patch(bodyid)

Update category

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::CategoriesApi.new
body = SwaggerClient::CategoriesIdBody.new # CategoriesIdBody | 
id = 'id_example' # String | Category id


begin
  #Update category
  result = api_instance.categories_id_patch(bodyid)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CategoriesApi->categories_id_patch: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoriesIdBody**](CategoriesIdBody.md)|  | 
 **id** | **String**| Category id | 

### Return type

[**Category**](Category.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **categories_post**
> Category categories_post(body)

Create category

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::CategoriesApi.new
body = SwaggerClient::CategoriesBody.new # CategoriesBody | 


begin
  #Create category
  result = api_instance.categories_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CategoriesApi->categories_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoriesBody**](CategoriesBody.md)|  | 

### Return type

[**Category**](Category.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



