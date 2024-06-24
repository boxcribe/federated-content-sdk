# swagger_client.MappingsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**mappings_get**](MappingsApi.md#mappings_get) | **GET** /mappings | Get mappings
[**mappings_id_delete**](MappingsApi.md#mappings_id_delete) | **DELETE** /mappings/{id} | Delete mapping
[**mappings_id_get**](MappingsApi.md#mappings_id_get) | **GET** /mappings/{id} | Get mapping
[**mappings_id_patch**](MappingsApi.md#mappings_id_patch) | **PATCH** /mappings/{id} | Update mapping
[**mappings_post**](MappingsApi.md#mappings_post) | **POST** /mappings | Create mapping

# **mappings_get**
> InlineResponse2009 mappings_get(tenant=tenant, schema=schema, field=field, integration=integration, sort=sort, limit=limit, page=page)

Get mappings

Retrieve a list of mappings with the ability to filter by tenant, category, schema, integration, field, sort, limit or page.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.MappingsApi(swagger_client.ApiClient(configuration))
tenant = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all mappings for a Tenant ID (optional)
schema = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all mappings for a Schema ID (optional)
field = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all mappings for a Field ID (optional)
integration = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all mappings for an Integration ID (optional)
sort = 'sort_example' # str | sort by query in the form of mapping:desc/asc (ex. name:asc) (optional)
limit = 56 # int | Maximum number of mappings (optional)
page = 1 # int | Page number (optional) (default to 1)

try:
    # Get mappings
    api_response = api_instance.mappings_get(tenant=tenant, schema=schema, field=field, integration=integration, sort=sort, limit=limit, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MappingsApi->mappings_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**str**](.md)| Get all mappings for a Tenant ID | [optional] 
 **schema** | [**str**](.md)| Get all mappings for a Schema ID | [optional] 
 **field** | [**str**](.md)| Get all mappings for a Field ID | [optional] 
 **integration** | [**str**](.md)| Get all mappings for an Integration ID | [optional] 
 **sort** | **str**| sort by query in the form of mapping:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int**| Maximum number of mappings | [optional] 
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2009**](InlineResponse2009.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mappings_id_delete**
> mappings_id_delete(id)

Delete mapping

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.MappingsApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Mapping id

try:
    # Delete mapping
    api_instance.mappings_id_delete(id)
except ApiException as e:
    print("Exception when calling MappingsApi->mappings_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Mapping id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mappings_id_get**
> Mapping mappings_id_get(id)

Get mapping

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.MappingsApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Mapping id

try:
    # Get mapping
    api_response = api_instance.mappings_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MappingsApi->mappings_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Mapping id | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mappings_id_patch**
> Mapping mappings_id_patch(body, id)

Update mapping

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.MappingsApi(swagger_client.ApiClient(configuration))
body = swagger_client.MappingsIdBody() # MappingsIdBody | 
id = 'id_example' # str | Mapping id

try:
    # Update mapping
    api_response = api_instance.mappings_id_patch(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MappingsApi->mappings_id_patch: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MappingsIdBody**](MappingsIdBody.md)|  | 
 **id** | **str**| Mapping id | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **mappings_post**
> Mapping mappings_post(body)

Create mapping

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.MappingsApi(swagger_client.ApiClient(configuration))
body = swagger_client.MappingsBody() # MappingsBody | 

try:
    # Create mapping
    api_response = api_instance.mappings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling MappingsApi->mappings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MappingsBody**](MappingsBody.md)|  | 

### Return type

[**Mapping**](Mapping.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

