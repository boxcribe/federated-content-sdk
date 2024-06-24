# swagger_client.IntegrationsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**integrations_get**](IntegrationsApi.md#integrations_get) | **GET** /integrations | Get integrations
[**integrations_id_delete**](IntegrationsApi.md#integrations_id_delete) | **DELETE** /integrations/{id} | Delete integration
[**integrations_id_get**](IntegrationsApi.md#integrations_id_get) | **GET** /integrations/{id} | Get integration
[**integrations_id_patch**](IntegrationsApi.md#integrations_id_patch) | **PATCH** /integrations/{id} | Update integration
[**integrations_post**](IntegrationsApi.md#integrations_post) | **POST** /integrations | Create integration

# **integrations_get**
> InlineResponse2007 integrations_get(tenant=tenant, category=category, sort=sort, limit=limit, page=page)

Get integrations

Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.IntegrationsApi(swagger_client.ApiClient(configuration))
tenant = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all integrations for a Tenant ID (optional)
category = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all integrations for a Category ID (optional)
sort = 'sort_example' # str | sort by query in the form of field:desc/asc (ex. name:asc) (optional)
limit = 56 # int | Maximum number of integrations (optional)
page = 1 # int | Page number (optional) (default to 1)

try:
    # Get integrations
    api_response = api_instance.integrations_get(tenant=tenant, category=category, sort=sort, limit=limit, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling IntegrationsApi->integrations_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**str**](.md)| Get all integrations for a Tenant ID | [optional] 
 **category** | [**str**](.md)| Get all integrations for a Category ID | [optional] 
 **sort** | **str**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int**| Maximum number of integrations | [optional] 
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **integrations_id_delete**
> integrations_id_delete(id)

Delete integration

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.IntegrationsApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Integration id

try:
    # Delete integration
    api_instance.integrations_id_delete(id)
except ApiException as e:
    print("Exception when calling IntegrationsApi->integrations_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Integration id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **integrations_id_get**
> Integration integrations_id_get(id)

Get integration

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.IntegrationsApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Integration id

try:
    # Get integration
    api_response = api_instance.integrations_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling IntegrationsApi->integrations_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Integration id | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **integrations_id_patch**
> Integration integrations_id_patch(body, id)

Update integration

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.IntegrationsApi(swagger_client.ApiClient(configuration))
body = swagger_client.IntegrationsIdBody() # IntegrationsIdBody | 
id = 'id_example' # str | Integration id

try:
    # Update integration
    api_response = api_instance.integrations_id_patch(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling IntegrationsApi->integrations_id_patch: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IntegrationsIdBody**](IntegrationsIdBody.md)|  | 
 **id** | **str**| Integration id | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **integrations_post**
> Integration integrations_post(body)

Create integration

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.IntegrationsApi(swagger_client.ApiClient(configuration))
body = swagger_client.IntegrationsBody() # IntegrationsBody | 

try:
    # Create integration
    api_response = api_instance.integrations_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling IntegrationsApi->integrations_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**IntegrationsBody**](IntegrationsBody.md)|  | 

### Return type

[**Integration**](Integration.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

