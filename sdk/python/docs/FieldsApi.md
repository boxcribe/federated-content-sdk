# swagger_client.FieldsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**fields_get**](FieldsApi.md#fields_get) | **GET** /fields | Get fields
[**fields_id_delete**](FieldsApi.md#fields_id_delete) | **DELETE** /fields/{id} | Delete field
[**fields_id_get**](FieldsApi.md#fields_id_get) | **GET** /fields/{id} | Get field
[**fields_id_patch**](FieldsApi.md#fields_id_patch) | **PATCH** /fields/{id} | Update field
[**fields_post**](FieldsApi.md#fields_post) | **POST** /fields | Create field

# **fields_get**
> InlineResponse2006 fields_get(tenant=tenant, schema=schema, sort=sort, limit=limit, page=page)

Get fields

Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.FieldsApi(swagger_client.ApiClient(configuration))
tenant = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all fields for a Tenant ID (optional)
schema = '38400000-8cf0-11bd-b23e-10b96e4ef00d' # str | Get all fields for a Schema ID (optional)
sort = 'sort_example' # str | sort by query in the form of field:desc/asc (ex. name:asc) (optional)
limit = 56 # int | Maximum number of fields (optional)
page = 1 # int | Page number (optional) (default to 1)

try:
    # Get fields
    api_response = api_instance.fields_get(tenant=tenant, schema=schema, sort=sort, limit=limit, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FieldsApi->fields_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tenant** | [**str**](.md)| Get all fields for a Tenant ID | [optional] 
 **schema** | [**str**](.md)| Get all fields for a Schema ID | [optional] 
 **sort** | **str**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int**| Maximum number of fields | [optional] 
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **fields_id_delete**
> fields_id_delete(id)

Delete field

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.FieldsApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Field id

try:
    # Delete field
    api_instance.fields_id_delete(id)
except ApiException as e:
    print("Exception when calling FieldsApi->fields_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Field id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **fields_id_get**
> Field fields_id_get(id)

Get field

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.FieldsApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Field id

try:
    # Get field
    api_response = api_instance.fields_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FieldsApi->fields_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Field id | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **fields_id_patch**
> Field fields_id_patch(body, id)

Update field

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.FieldsApi(swagger_client.ApiClient(configuration))
body = swagger_client.FieldsIdBody() # FieldsIdBody | 
id = 'id_example' # str | Field id

try:
    # Update field
    api_response = api_instance.fields_id_patch(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FieldsApi->fields_id_patch: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FieldsIdBody**](FieldsIdBody.md)|  | 
 **id** | **str**| Field id | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **fields_post**
> Field fields_post(body)

Create field

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.FieldsApi(swagger_client.ApiClient(configuration))
body = swagger_client.FieldsBody() # FieldsBody | 

try:
    # Create field
    api_response = api_instance.fields_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FieldsApi->fields_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FieldsBody**](FieldsBody.md)|  | 

### Return type

[**Field**](Field.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

