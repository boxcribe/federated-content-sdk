# SwaggerClient::TenantsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tenants_get**](TenantsApi.md#tenants_get) | **GET** /tenants | Get tenants
[**tenants_id_delete**](TenantsApi.md#tenants_id_delete) | **DELETE** /tenants/{id} | Delete tenant
[**tenants_id_get**](TenantsApi.md#tenants_id_get) | **GET** /tenants/{id} | Get tenant
[**tenants_id_patch**](TenantsApi.md#tenants_id_patch) | **PATCH** /tenants/{id} | Update tenant
[**tenants_post**](TenantsApi.md#tenants_post) | **POST** /tenants | Create tenant

# **tenants_get**
> InlineResponse20012 tenants_get(opts)

Get tenants

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::TenantsApi.new
opts = { 
  company: 'company_example', # String | Company ID
  sort: 'sort_example', # String | sort by query in the form of field:desc/asc (ex. name:asc)
  limit: 56, # Integer | Maximum number of tenants
  page: 1 # Integer | Page number
}

begin
  #Get tenants
  result = api_instance.tenants_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TenantsApi->tenants_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **String**| Company ID | [optional] 
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **Integer**| Maximum number of tenants | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **tenants_id_delete**
> tenants_id_delete(id)

Delete tenant

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::TenantsApi.new
id = 'id_example' # String | Tenant id


begin
  #Delete tenant
  api_instance.tenants_id_delete(id)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TenantsApi->tenants_id_delete: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Tenant id | 

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **tenants_id_get**
> Tenant tenants_id_get(id)

Get tenant

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::TenantsApi.new
id = 'id_example' # String | Tenant id


begin
  #Get tenant
  result = api_instance.tenants_id_get(id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TenantsApi->tenants_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| Tenant id | 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **tenants_id_patch**
> Tenant tenants_id_patch(bodyid)

Update tenant

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::TenantsApi.new
body = SwaggerClient::TenantsIdBody.new # TenantsIdBody | 
id = 'id_example' # String | Tenant id


begin
  #Update tenant
  result = api_instance.tenants_id_patch(bodyid)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TenantsApi->tenants_id_patch: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantsIdBody**](TenantsIdBody.md)|  | 
 **id** | **String**| Tenant id | 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **tenants_post**
> Tenant tenants_post(body)

Create tenant

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::TenantsApi.new
body = SwaggerClient::TenantsBody.new # TenantsBody | 


begin
  #Create tenant
  result = api_instance.tenants_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TenantsApi->tenants_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantsBody**](TenantsBody.md)|  | 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



