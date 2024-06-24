# SwaggerClient::UsersApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**users_get**](UsersApi.md#users_get) | **GET** /users | Get users
[**users_post**](UsersApi.md#users_post) | **POST** /users | Create User
[**usersuser_id_delete**](UsersApi.md#usersuser_id_delete) | **DELETE** /users/:userId | Delete User
[**usersuser_id_get**](UsersApi.md#usersuser_id_get) | **GET** /users/:userId | Get Users
[**usersuser_id_patch**](UsersApi.md#usersuser_id_patch) | **PATCH** /users/:userId | Update User

# **users_get**
> InlineResponse20013 users_get(opts)

Get users

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::UsersApi.new
opts = { 
  sort: 'sort_example', # String | sort by query in the form of field:desc/asc (ex. name:asc)
  limit: 56, # Integer | Maximum number of admins
  page: 1 # Integer | Page number
}

begin
  #Get users
  result = api_instance.users_get(opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling UsersApi->users_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **String**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **Integer**| Maximum number of admins | [optional] 
 **page** | **Integer**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20013**](InlineResponse20013.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **users_post**
> InlineResponse201 users_post(body)

Create User

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::UsersApi.new
body = SwaggerClient::UsersBody.new # UsersBody | 


begin
  #Create User
  result = api_instance.users_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling UsersApi->users_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersBody**](UsersBody.md)|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **usersuser_id_delete**
> usersuser_id_delete

Delete User

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::UsersApi.new

begin
  #Delete User
  api_instance.usersuser_id_delete
rescue SwaggerClient::ApiError => e
  puts "Exception when calling UsersApi->usersuser_id_delete: #{e}"
end
```

### Parameters
This endpoint does not need any parameter.

### Return type

nil (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **usersuser_id_get**
> InlineResponse201 usersuser_id_get(id)

Get Users

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::UsersApi.new
id = 'id_example' # String | User id


begin
  #Get Users
  result = api_instance.usersuser_id_get(id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling UsersApi->usersuser_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **String**| User id | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **usersuser_id_patch**
> InlineResponse201 usersuser_id_patch(body)

Update User

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
end

api_instance = SwaggerClient::UsersApi.new
body = SwaggerClient::UsersUserIdBody.new # UsersUserIdBody | 


begin
  #Update User
  result = api_instance.usersuser_id_patch(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling UsersApi->usersuser_id_patch: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UsersUserIdBody**](UsersUserIdBody.md)|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



