# swagger_client.ApiKeysApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**apikeys_get**](ApiKeysApi.md#apikeys_get) | **GET** /apikeys | Get api keys
[**apikeys_id_delete**](ApiKeysApi.md#apikeys_id_delete) | **DELETE** /apikeys/{id} | Delete api key
[**apikeys_id_get**](ApiKeysApi.md#apikeys_id_get) | **GET** /apikeys/{id} | Get api key
[**apikeys_id_patch**](ApiKeysApi.md#apikeys_id_patch) | **PATCH** /apikeys/{id} | Update api key
[**apikeys_post**](ApiKeysApi.md#apikeys_post) | **POST** /apikeys | Create api key

# **apikeys_get**
> InlineResponse2002 apikeys_get(tenant=tenant, environment=environment, sort=sort, limit=limit, page=page)

Get api keys

Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.ApiKeysApi(swagger_client.ApiClient(configuration))
tenant = 'tenant_example' # str | Get all schemas for a Tenant ID (optional)
environment = 'environment_example' # str | Get all schemas for an Environment (Sandbox or Production) (optional)
sort = 'sort_example' # str | sort by query in the form of field:desc/asc (ex. name:asc) (optional)
limit = 56 # int | Maximum number of apiKeys (optional)
page = 1 # int | Page number (optional) (default to 1)

try:
    # Get api keys
    api_response = api_instance.apikeys_get(tenant=tenant, environment=environment, sort=sort, limit=limit, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeysApi->apikeys_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | **str**| Get all schemas for a Tenant ID | [optional] 
 **environment** | **str**| Get all schemas for an Environment (Sandbox or Production) | [optional] 
 **sort** | **str**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int**| Maximum number of apiKeys | [optional] 
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeys_id_delete**
> apikeys_id_delete(id)

Delete api key

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.ApiKeysApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Api Key ID

try:
    # Delete api key
    api_instance.apikeys_id_delete(id)
except ApiException as e:
    print("Exception when calling ApiKeysApi->apikeys_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Api Key ID | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeys_id_get**
> ApiKey apikeys_id_get(id)

Get api key

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.ApiKeysApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Api Key ID

try:
    # Get api key
    api_response = api_instance.apikeys_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeysApi->apikeys_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Api Key ID | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeys_id_patch**
> ApiKey apikeys_id_patch(body, id)

Update api key

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.ApiKeysApi(swagger_client.ApiClient(configuration))
body = swagger_client.ApikeysIdBody() # ApikeysIdBody | 
id = 'id_example' # str | Api Key ID

try:
    # Update api key
    api_response = api_instance.apikeys_id_patch(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeysApi->apikeys_id_patch: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApikeysIdBody**](ApikeysIdBody.md)|  | 
 **id** | **str**| Api Key ID | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **apikeys_post**
> ApiKey apikeys_post(body)

Create api key

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.ApiKeysApi(swagger_client.ApiClient(configuration))
body = swagger_client.ApikeysBody() # ApikeysBody | 

try:
    # Create api key
    api_response = api_instance.apikeys_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ApiKeysApi->apikeys_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ApikeysBody**](ApikeysBody.md)|  | 

### Return type

[**ApiKey**](ApiKey.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

