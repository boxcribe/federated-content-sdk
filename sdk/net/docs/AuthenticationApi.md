# IO.Swagger.Api.AuthenticationApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuthForgotPasswordPost**](AuthenticationApi.md#authforgotpasswordpost) | **POST** /auth/forgot-password | Forgot password
[**AuthLoginPost**](AuthenticationApi.md#authloginpost) | **POST** /auth/login | Login
[**AuthLogoutPost**](AuthenticationApi.md#authlogoutpost) | **POST** /auth/logout | Logout
[**AuthRefreshTokensPost**](AuthenticationApi.md#authrefreshtokenspost) | **POST** /auth/refresh-tokens | Refresh auth tokens
[**AuthRegisterPost**](AuthenticationApi.md#authregisterpost) | **POST** /auth/register | Register
[**AuthResetPasswordPost**](AuthenticationApi.md#authresetpasswordpost) | **POST** /auth/reset-password | Reset password
[**AuthSendVerificationEmailPost**](AuthenticationApi.md#authsendverificationemailpost) | **POST** /auth/send-verification-email | Send verification email
[**AuthVerifyEmailPost**](AuthenticationApi.md#authverifyemailpost) | **POST** /auth/verify-email | verify email

<a name="authforgotpasswordpost"></a>
# **AuthForgotPasswordPost**
> void AuthForgotPasswordPost (AuthForgotpasswordBody body)

Forgot password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthForgotPasswordPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new AuthenticationApi();
            var body = new AuthForgotpasswordBody(); // AuthForgotpasswordBody | 

            try
            {
                // Forgot password
                apiInstance.AuthForgotPasswordPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthForgotPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthForgotpasswordBody**](AuthForgotpasswordBody.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authloginpost"></a>
# **AuthLoginPost**
> InlineResponse2003 AuthLoginPost (AuthLoginBody body)

Login

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthLoginPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new AuthenticationApi();
            var body = new AuthLoginBody(); // AuthLoginBody | 

            try
            {
                // Login
                InlineResponse2003 result = apiInstance.AuthLoginPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthLoginPost: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authlogoutpost"></a>
# **AuthLogoutPost**
> void AuthLogoutPost (AuthLogoutBody body)

Logout

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthLogoutPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new AuthenticationApi();
            var body = new AuthLogoutBody(); // AuthLogoutBody | 

            try
            {
                // Logout
                apiInstance.AuthLogoutPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthLogoutPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthLogoutBody**](AuthLogoutBody.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authrefreshtokenspost"></a>
# **AuthRefreshTokensPost**
> AuthTokens AuthRefreshTokensPost (AuthRefreshtokensBody body)

Refresh auth tokens

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthRefreshTokensPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new AuthenticationApi();
            var body = new AuthRefreshtokensBody(); // AuthRefreshtokensBody | 

            try
            {
                // Refresh auth tokens
                AuthTokens result = apiInstance.AuthRefreshTokensPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthRefreshTokensPost: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authregisterpost"></a>
# **AuthRegisterPost**
> InlineResponse201 AuthRegisterPost (AuthRegisterBody body)

Register

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthRegisterPostExample
    {
        public void main()
        {

            var apiInstance = new AuthenticationApi();
            var body = new AuthRegisterBody(); // AuthRegisterBody | 

            try
            {
                // Register
                InlineResponse201 result = apiInstance.AuthRegisterPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthRegisterPost: " + e.Message );
            }
        }
    }
}
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authresetpasswordpost"></a>
# **AuthResetPasswordPost**
> void AuthResetPasswordPost (AuthResetpasswordBody body, string token)

Reset password

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthResetPasswordPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new AuthenticationApi();
            var body = new AuthResetpasswordBody(); // AuthResetpasswordBody | 
            var token = token_example;  // string | The reset password token

            try
            {
                // Reset password
                apiInstance.AuthResetPasswordPost(body, token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthResetPasswordPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthResetpasswordBody**](AuthResetpasswordBody.md)|  | 
 **token** | **string**| The reset password token | 

### Return type

void (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authsendverificationemailpost"></a>
# **AuthSendVerificationEmailPost**
> void AuthSendVerificationEmailPost (AuthSendverificationemailBody body)

Send verification email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthSendVerificationEmailPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new AuthenticationApi();
            var body = new AuthSendverificationemailBody(); // AuthSendverificationemailBody | 

            try
            {
                // Send verification email
                apiInstance.AuthSendVerificationEmailPost(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthSendVerificationEmailPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthSendverificationemailBody**](AuthSendverificationemailBody.md)|  | 

### Return type

void (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authverifyemailpost"></a>
# **AuthVerifyEmailPost**
> void AuthVerifyEmailPost (string token)

verify email

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AuthVerifyEmailPostExample
    {
        public void main()
        {

            // Configure API key authorization: apiKeyAuth
            Configuration.Default.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("x-api-key", "Bearer");

            var apiInstance = new AuthenticationApi();
            var token = token_example;  // string | The verify email token

            try
            {
                // verify email
                apiInstance.AuthVerifyEmailPost(token);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthVerifyEmailPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **string**| The verify email token | 

### Return type

void (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

