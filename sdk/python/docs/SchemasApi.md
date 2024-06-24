# swagger_client.SchemasApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**schemas_get**](SchemasApi.md#schemas_get) | **GET** /schemas | Get schemas
[**schemas_grouped_by_endpoint_get**](SchemasApi.md#schemas_grouped_by_endpoint_get) | **GET** /schemas/groupedByEndpoint | Get schemas grouped by endpoint
[**schemas_id_delete**](SchemasApi.md#schemas_id_delete) | **DELETE** /schemas/{id} | Delete schema
[**schemas_id_get**](SchemasApi.md#schemas_id_get) | **GET** /schemas/{id} | Get schema
[**schemas_id_patch**](SchemasApi.md#schemas_id_patch) | **PATCH** /schemas/{id} | Update schema
[**schemas_post**](SchemasApi.md#schemas_post) | **POST** /schemas | Create schema

# **schemas_get**
> InlineResponse20010 schemas_get(tenant=tenant, category=category, sort=sort, limit=limit, page=page)

Get schemas

Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.SchemasApi(swagger_client.ApiClient(configuration))
tenant = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all schemas for a Tenant ID (optional)
category = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all schemas for a Category ID (optional)
sort = 'sort_example' # str | Sort by query in the form of field:desc/asc (ex. name:asc) (optional)
limit = 56 # int | Maximum number of schemas (optional)
page = 1 # int | Page number (optional) (default to 1)

try:
    # Get schemas
    api_response = api_instance.schemas_get(tenant=tenant, category=category, sort=sort, limit=limit, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SchemasApi->schemas_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**str**](.md)| Get all schemas for a Tenant ID | [optional] 
 **category** | [**str**](.md)| Get all schemas for a Category ID | [optional] 
 **sort** | **str**| Sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int**| Maximum number of schemas | [optional] 
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20010**](InlineResponse20010.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schemas_grouped_by_endpoint_get**
> InlineResponse20011 schemas_grouped_by_endpoint_get(tenant=tenant, category=category, sort=sort, limit=limit, page=page)

Get schemas grouped by endpoint

Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.SchemasApi(swagger_client.ApiClient(configuration))
tenant = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all schemas for a Tenant ID (optional)
category = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all schemas for a Category ID (optional)
sort = 'sort_example' # str | Sort by query in the form of field:desc/asc (ex. endpoint:asc) (optional)
limit = 56 # int | Maximum number of schemas (optional)
page = 1 # int | Page number (optional) (default to 1)

try:
    # Get schemas grouped by endpoint
    api_response = api_instance.schemas_grouped_by_endpoint_get(tenant=tenant, category=category, sort=sort, limit=limit, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SchemasApi->schemas_grouped_by_endpoint_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**str**](.md)| Get all schemas for a Tenant ID | [optional] 
 **category** | [**str**](.md)| Get all schemas for a Category ID | [optional] 
 **sort** | **str**| Sort by query in the form of field:desc/asc (ex. endpoint:asc) | [optional] 
 **limit** | **int**| Maximum number of schemas | [optional] 
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20011**](InlineResponse20011.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schemas_id_delete**
> schemas_id_delete(id)

Delete schema

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.SchemasApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Schema id

try:
    # Delete schema
    api_instance.schemas_id_delete(id)
except ApiException as e:
    print("Exception when calling SchemasApi->schemas_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Schema id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schemas_id_get**
> Schema schemas_id_get(id)

Get schema

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.SchemasApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Schema id

try:
    # Get schema
    api_response = api_instance.schemas_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SchemasApi->schemas_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Schema id | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schemas_id_patch**
> Schema schemas_id_patch(body, id)

Update schema

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.SchemasApi(swagger_client.ApiClient(configuration))
body = swagger_client.SchemasIdBody() # SchemasIdBody | 
id = 'id_example' # str | Schema id

try:
    # Update schema
    api_response = api_instance.schemas_id_patch(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SchemasApi->schemas_id_patch: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SchemasIdBody**](SchemasIdBody.md)|  | 
 **id** | **str**| Schema id | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **schemas_post**
> Schema schemas_post(body)

Create schema

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.SchemasApi(swagger_client.ApiClient(configuration))
body = swagger_client.SchemasBody() # SchemasBody | 

try:
    # Create schema
    api_response = api_instance.schemas_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling SchemasApi->schemas_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SchemasBody**](SchemasBody.md)|  | 

### Return type

[**Schema**](Schema.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

