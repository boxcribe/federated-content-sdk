# swagger_client.AuthenticationApi

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
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.AuthenticationApi(swagger_client.ApiClient(configuration))
body = swagger_client.AuthForgotpasswordBody() # AuthForgotpasswordBody | 

try:
    # Forgot password
    api_instance.auth_forgot_password_post(body)
except ApiException as e:
    print("Exception when calling AuthenticationApi->auth_forgot_password_post: %s\n" % e)
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

# **auth_login_post**
> InlineResponse2003 auth_login_post(body)

Login

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.AuthenticationApi(swagger_client.ApiClient(configuration))
body = swagger_client.AuthLoginBody() # AuthLoginBody | 

try:
    # Login
    api_response = api_instance.auth_login_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AuthenticationApi->auth_login_post: %s\n" % e)
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

# **auth_logout_post**
> auth_logout_post(body)

Logout

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.AuthenticationApi(swagger_client.ApiClient(configuration))
body = swagger_client.AuthLogoutBody() # AuthLogoutBody | 

try:
    # Logout
    api_instance.auth_logout_post(body)
except ApiException as e:
    print("Exception when calling AuthenticationApi->auth_logout_post: %s\n" % e)
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

# **auth_refresh_tokens_post**
> AuthTokens auth_refresh_tokens_post(body)

Refresh auth tokens

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.AuthenticationApi(swagger_client.ApiClient(configuration))
body = swagger_client.AuthRefreshtokensBody() # AuthRefreshtokensBody | 

try:
    # Refresh auth tokens
    api_response = api_instance.auth_refresh_tokens_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AuthenticationApi->auth_refresh_tokens_post: %s\n" % e)
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

# **auth_register_post**
> InlineResponse201 auth_register_post(body)

Register

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.AuthenticationApi()
body = swagger_client.AuthRegisterBody() # AuthRegisterBody | 

try:
    # Register
    api_response = api_instance.auth_register_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling AuthenticationApi->auth_register_post: %s\n" % e)
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

# **auth_reset_password_post**
> auth_reset_password_post(body, token)

Reset password

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.AuthenticationApi(swagger_client.ApiClient(configuration))
body = swagger_client.AuthResetpasswordBody() # AuthResetpasswordBody | 
token = 'token_example' # str | The reset password token

try:
    # Reset password
    api_instance.auth_reset_password_post(body, token)
except ApiException as e:
    print("Exception when calling AuthenticationApi->auth_reset_password_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AuthResetpasswordBody**](AuthResetpasswordBody.md)|  | 
 **token** | **str**| The reset password token | 

### Return type

void (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **auth_send_verification_email_post**
> auth_send_verification_email_post(body)

Send verification email

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.AuthenticationApi(swagger_client.ApiClient(configuration))
body = swagger_client.AuthSendverificationemailBody() # AuthSendverificationemailBody | 

try:
    # Send verification email
    api_instance.auth_send_verification_email_post(body)
except ApiException as e:
    print("Exception when calling AuthenticationApi->auth_send_verification_email_post: %s\n" % e)
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

# **auth_verify_email_post**
> auth_verify_email_post(token)

verify email

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.AuthenticationApi(swagger_client.ApiClient(configuration))
token = 'token_example' # str | The verify email token

try:
    # verify email
    api_instance.auth_verify_email_post(token)
except ApiException as e:
    print("Exception when calling AuthenticationApi->auth_verify_email_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **token** | **str**| The verify email token | 

### Return type

void (empty response body)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

