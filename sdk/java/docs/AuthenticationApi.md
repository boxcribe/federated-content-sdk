# AuthenticationApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**authForgotPasswordPost**](AuthenticationApi.md#authForgotPasswordPost) | **POST** /auth/forgot-password | Forgot password
[**authLoginPost**](AuthenticationApi.md#authLoginPost) | **POST** /auth/login | Login
[**authLogoutPost**](AuthenticationApi.md#authLogoutPost) | **POST** /auth/logout | Logout
[**authRefreshTokensPost**](AuthenticationApi.md#authRefreshTokensPost) | **POST** /auth/refresh-tokens | Refresh auth tokens
[**authRegisterPost**](AuthenticationApi.md#authRegisterPost) | **POST** /auth/register | Register
[**authResetPasswordPost**](AuthenticationApi.md#authResetPasswordPost) | **POST** /auth/reset-password | Reset password
[**authSendVerificationEmailPost**](AuthenticationApi.md#authSendVerificationEmailPost) | **POST** /auth/send-verification-email | Send verification email
[**authVerifyEmailPost**](AuthenticationApi.md#authVerifyEmailPost) | **POST** /auth/verify-email | verify email

<a name="authForgotPasswordPost"></a>
# **authForgotPasswordPost**
> authForgotPasswordPost(body)

Forgot password

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.AuthenticationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

AuthenticationApi apiInstance = new AuthenticationApi();
AuthForgotpasswordBody body = new AuthForgotpasswordBody(); // AuthForgotpasswordBody | 
try {
    apiInstance.authForgotPasswordPost(body);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#authForgotPasswordPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthForgotpasswordBody**](AuthForgotpasswordBody.md)|  |

### Return type

null (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="authLoginPost"></a>
# **authLoginPost**
> InlineResponse2003 authLoginPost(body)

Login

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.AuthenticationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

AuthenticationApi apiInstance = new AuthenticationApi();
AuthLoginBody body = new AuthLoginBody(); // AuthLoginBody | 
try {
    InlineResponse2003 result = apiInstance.authLoginPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#authLoginPost");
    e.printStackTrace();
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

<a name="authLogoutPost"></a>
# **authLogoutPost**
> authLogoutPost(body)

Logout

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.AuthenticationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

AuthenticationApi apiInstance = new AuthenticationApi();
AuthLogoutBody body = new AuthLogoutBody(); // AuthLogoutBody | 
try {
    apiInstance.authLogoutPost(body);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#authLogoutPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthLogoutBody**](AuthLogoutBody.md)|  |

### Return type

null (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="authRefreshTokensPost"></a>
# **authRefreshTokensPost**
> AuthTokens authRefreshTokensPost(body)

Refresh auth tokens

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.AuthenticationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

AuthenticationApi apiInstance = new AuthenticationApi();
AuthRefreshtokensBody body = new AuthRefreshtokensBody(); // AuthRefreshtokensBody | 
try {
    AuthTokens result = apiInstance.authRefreshTokensPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#authRefreshTokensPost");
    e.printStackTrace();
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

<a name="authRegisterPost"></a>
# **authRegisterPost**
> InlineResponse201 authRegisterPost(body)

Register

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AuthenticationApi;


AuthenticationApi apiInstance = new AuthenticationApi();
AuthRegisterBody body = new AuthRegisterBody(); // AuthRegisterBody | 
try {
    InlineResponse201 result = apiInstance.authRegisterPost(body);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#authRegisterPost");
    e.printStackTrace();
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

<a name="authResetPasswordPost"></a>
# **authResetPasswordPost**
> authResetPasswordPost(body, token)

Reset password

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.AuthenticationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

AuthenticationApi apiInstance = new AuthenticationApi();
AuthResetpasswordBody body = new AuthResetpasswordBody(); // AuthResetpasswordBody | 
String token = "token_example"; // String | The reset password token
try {
    apiInstance.authResetPasswordPost(body, token);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#authResetPasswordPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthResetpasswordBody**](AuthResetpasswordBody.md)|  |
 **token** | **String**| The reset password token |

### Return type

null (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="authSendVerificationEmailPost"></a>
# **authSendVerificationEmailPost**
> authSendVerificationEmailPost(body)

Send verification email

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.AuthenticationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

AuthenticationApi apiInstance = new AuthenticationApi();
AuthSendverificationemailBody body = new AuthSendverificationemailBody(); // AuthSendverificationemailBody | 
try {
    apiInstance.authSendVerificationEmailPost(body);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#authSendVerificationEmailPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthSendverificationemailBody**](AuthSendverificationemailBody.md)|  |

### Return type

null (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="authVerifyEmailPost"></a>
# **authVerifyEmailPost**
> authVerifyEmailPost(token)

verify email

### Example
```java
// Import classes:
//import io.swagger.client.ApiClient;
//import io.swagger.client.ApiException;
//import io.swagger.client.Configuration;
//import io.swagger.client.auth.*;
//import io.swagger.client.api.AuthenticationApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure API key authorization: apiKeyAuth
ApiKeyAuth apiKeyAuth = (ApiKeyAuth) defaultClient.getAuthentication("apiKeyAuth");
apiKeyAuth.setApiKey("YOUR API KEY");
// Uncomment the following line to set a prefix for the API key, e.g. "Token" (defaults to null)
//apiKeyAuth.setApiKeyPrefix("Token");

AuthenticationApi apiInstance = new AuthenticationApi();
String token = "token_example"; // String | The verify email token
try {
    apiInstance.authVerifyEmailPost(token);
} catch (ApiException e) {
    System.err.println("Exception when calling AuthenticationApi#authVerifyEmailPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **String**| The verify email token |

### Return type

null (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

