# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthForgotPasswordPost**](AuthenticationApi.md#AuthForgotPasswordPost) | **Post** /auth/forgot-password | Forgot password
[**AuthLoginPost**](AuthenticationApi.md#AuthLoginPost) | **Post** /auth/login | Login
[**AuthLogoutPost**](AuthenticationApi.md#AuthLogoutPost) | **Post** /auth/logout | Logout
[**AuthRefreshTokensPost**](AuthenticationApi.md#AuthRefreshTokensPost) | **Post** /auth/refresh-tokens | Refresh auth tokens
[**AuthRegisterPost**](AuthenticationApi.md#AuthRegisterPost) | **Post** /auth/register | Register
[**AuthResetPasswordPost**](AuthenticationApi.md#AuthResetPasswordPost) | **Post** /auth/reset-password | Reset password
[**AuthSendVerificationEmailPost**](AuthenticationApi.md#AuthSendVerificationEmailPost) | **Post** /auth/send-verification-email | Send verification email
[**AuthVerifyEmailPost**](AuthenticationApi.md#AuthVerifyEmailPost) | **Post** /auth/verify-email | verify email

# **AuthForgotPasswordPost**
> AuthForgotPasswordPost(ctx, body)
Forgot password

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**AuthForgotpasswordBody**](AuthForgotpasswordBody.md)|  | 

### Return type

 (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **AuthLoginPost**
> InlineResponse2003 AuthLoginPost(ctx, body)
Login

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**AuthLoginBody**](AuthLoginBody.md)|  | 

### Return type

[**InlineResponse2003**](inline_response_200_3.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **AuthLogoutPost**
> AuthLogoutPost(ctx, body)
Logout

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**AuthLogoutBody**](AuthLogoutBody.md)|  | 

### Return type

 (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **AuthRefreshTokensPost**
> AuthTokens AuthRefreshTokensPost(ctx, body)
Refresh auth tokens

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**AuthRefreshtokensBody**](AuthRefreshtokensBody.md)|  | 

### Return type

[**AuthTokens**](AuthTokens.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **AuthRegisterPost**
> InlineResponse201 AuthRegisterPost(ctx, body)
Register

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**AuthRegisterBody**](AuthRegisterBody.md)|  | 

### Return type

[**InlineResponse201**](inline_response_201.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **AuthResetPasswordPost**
> AuthResetPasswordPost(ctx, body, token)
Reset password

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**AuthResetpasswordBody**](AuthResetpasswordBody.md)|  | 
  **token** | **string**| The reset password token | 

### Return type

 (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **AuthSendVerificationEmailPost**
> AuthSendVerificationEmailPost(ctx, body)
Send verification email

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**AuthSendverificationemailBody**](AuthSendverificationemailBody.md)|  | 

### Return type

 (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **AuthVerifyEmailPost**
> AuthVerifyEmailPost(ctx, token)
verify email

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **token** | **string**| The verify email token | 

### Return type

 (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

