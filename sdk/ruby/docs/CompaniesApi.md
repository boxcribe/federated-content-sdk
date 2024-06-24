# SwaggerClient::CompaniesApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companies_get**](CompaniesApi.md#companies_get) | **GET** /companies | Get companies
[**companies_id_delete**](CompaniesApi.md#companies_id_delete) | **DELETE** /companies/{id} | Delete company
[**companies_id_get**](CompaniesApi.md#companies_id_get) | **GET** /companies/{id} | Get company
[**companies_id_patch**](CompaniesApi.md#companies_id_patch) | **PATCH** /companies/{id} | Update company
[**companies_post**](CompaniesApi.md#companies_post) | **POST** /companies | Create company

# **companies_get**
> InlineResponse2005 companies_get(opts)

Get companies

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::CompaniesApi.new
opts = { 
  sort: 'sort_example', # String | sort by query in the form of field:desc/asc (ex. name:asc)
  limit: 56, # Integer | Maximum number of companies
  page: 1 # Integer | Page number
}

begin
  #Get companies
  result = api_instance.companies_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CompaniesApi->companies_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **Integer**| Maximum number of companies | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **companies_id_delete**
> companies_id_delete(id)

Delete company

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::CompaniesApi.new
id = 'id_example' # String | Company id


begin
  #Delete company
  api_instance.companies_id_delete(id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CompaniesApi->companies_id_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Company id | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **companies_id_get**
> Company companies_id_get(id)

Get company

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::CompaniesApi.new
id = 'id_example' # String | Company id


begin
  #Get company
  result = api_instance.companies_id_get(id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CompaniesApi->companies_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Company id | 

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **companies_id_patch**
> Company companies_id_patch(bodyid)

Update company

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::CompaniesApi.new
body = SwaggerClient::CompaniesIdBody.new # CompaniesIdBody | 
id = 'id_example' # String | Company id


begin
  #Update company
  result = api_instance.companies_id_patch(bodyid)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CompaniesApi->companies_id_patch: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompaniesIdBody**](CompaniesIdBody.md)|  | 
 **id** | **String**| Company id | 

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **companies_post**
> Company companies_post(body)

Create company

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::CompaniesApi.new
body = SwaggerClient::CompaniesBody.new # CompaniesBody | 


begin
  #Create company
  result = api_instance.companies_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CompaniesApi->companies_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompaniesBody**](CompaniesBody.md)|  | 

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



