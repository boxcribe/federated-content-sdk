# SwaggerClient::AuthenticationApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**auth_forgot_password_post**](AuthenticationApi.md#auth_forgot_password_post) | **POST** /auth/forgot-password | Forgot password
[**auth_login_post**](AuthenticationApi.md#auth_login_post) | **POST** /auth/login | Login
[**auth_logout_post**](AuthenticationApi.md#auth_logout_post) | **POST** /auth/logout | Logout
[**auth_refresh_tokens_post**](AuthenticationApi.md#auth_refresh_tokens_post) | **POST** /auth/refresh-tokens | Refresh auth tokens
[**auth_register_post**](AuthenticationApi.md#auth_register_post) | **POST** /auth/register | Register
[**auth_reset_password_post**](AuthenticationApi.md#auth_reset_password_post) | **POST** /auth/reset-password | Reset password
[**auth_send_verification_email_post**](AuthenticationApi.md#auth_send_verification_email_post) | **POST** /auth/send-verification-email | Send verification email
[**auth_verify_email_post**](AuthenticationApi.md#auth_verify_email_post) | **POST** /auth/verify-email | verify email

# **auth_forgot_password_post**
> auth_forgot_password_post(body)

Forgot password

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::AuthenticationApi.new
body = SwaggerClient::AuthForgotpasswordBody.new # AuthForgotpasswordBody | 


begin
  #Forgot password
  api_instance.auth_forgot_password_post(body)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling AuthenticationApi->auth_forgot_password_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthForgotpasswordBody**](AuthForgotpasswordBody.md)|  | 

### Return type

nil (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **auth_login_post**
> InlineResponse2003 auth_login_post(body)

Login

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::AuthenticationApi.new
body = SwaggerClient::AuthLoginBody.new # AuthLoginBody | 


begin
  #Login
  result = api_instance.auth_login_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling AuthenticationApi->auth_login_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthLoginBody**](AuthLoginBody.md)|  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **auth_logout_post**
> auth_logout_post(body)

Logout

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::AuthenticationApi.new
body = SwaggerClient::AuthLogoutBody.new # AuthLogoutBody | 


begin
  #Logout
  api_instance.auth_logout_post(body)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling AuthenticationApi->auth_logout_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthLogoutBody**](AuthLogoutBody.md)|  | 

### Return type

nil (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **auth_refresh_tokens_post**
> AuthTokens auth_refresh_tokens_post(body)

Refresh auth tokens

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::AuthenticationApi.new
body = SwaggerClient::AuthRefreshtokensBody.new # AuthRefreshtokensBody | 


begin
  #Refresh auth tokens
  result = api_instance.auth_refresh_tokens_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling AuthenticationApi->auth_refresh_tokens_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthRefreshtokensBody**](AuthRefreshtokensBody.md)|  | 

### Return type

[**AuthTokens**](AuthTokens.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **auth_register_post**
> InlineResponse201 auth_register_post(body)

Register

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::AuthenticationApi.new
body = SwaggerClient::AuthRegisterBody.new # AuthRegisterBody | 


begin
  #Register
  result = api_instance.auth_register_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling AuthenticationApi->auth_register_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthRegisterBody**](AuthRegisterBody.md)|  | 

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **auth_reset_password_post**
> auth_reset_password_post(bodytoken)

Reset password

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::AuthenticationApi.new
body = SwaggerClient::AuthResetpasswordBody.new # AuthResetpasswordBody | 
token = 'token_example' # String | The reset password token


begin
  #Reset password
  api_instance.auth_reset_password_post(bodytoken)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling AuthenticationApi->auth_reset_password_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthResetpasswordBody**](AuthResetpasswordBody.md)|  | 
 **token** | **String**| The reset password token | 

### Return type

nil (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **auth_send_verification_email_post**
> auth_send_verification_email_post(body)

Send verification email

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::AuthenticationApi.new
body = SwaggerClient::AuthSendverificationemailBody.new # AuthSendverificationemailBody | 


begin
  #Send verification email
  api_instance.auth_send_verification_email_post(body)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling AuthenticationApi->auth_send_verification_email_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthSendverificationemailBody**](AuthSendverificationemailBody.md)|  | 

### Return type

nil (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **auth_verify_email_post**
> auth_verify_email_post(token)

verify email

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::AuthenticationApi.new
token = 'token_example' # String | The verify email token


begin
  #verify email
  api_instance.auth_verify_email_post(token)
rescue SwaggerClient::ApiError => e
  puts "Exception when calling AuthenticationApi->auth_verify_email_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The verify email token | 

### Return type

nil (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



