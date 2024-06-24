# swagger_client.TenantsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tenants_get**](TenantsApi.md#tenants_get) | **GET** /tenants | Get tenants
[**tenants_id_delete**](TenantsApi.md#tenants_id_delete) | **DELETE** /tenants/{id} | Delete tenant
[**tenants_id_get**](TenantsApi.md#tenants_id_get) | **GET** /tenants/{id} | Get tenant
[**tenants_id_patch**](TenantsApi.md#tenants_id_patch) | **PATCH** /tenants/{id} | Update tenant
[**tenants_post**](TenantsApi.md#tenants_post) | **POST** /tenants | Create tenant

# **tenants_get**
> InlineResponse20012 tenants_get(company=company, sort=sort, limit=limit, page=page)

Get tenants

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.TenantsApi(swagger_client.ApiClient(configuration))
company = 'company_example' # str | Company ID (optional)
sort = 'sort_example' # str | sort by query in the form of field:desc/asc (ex. name:asc) (optional)
limit = 56 # int | Maximum number of tenants (optional)
page = 1 # int | Page number (optional) (default to 1)

try:
    # Get tenants
    api_response = api_instance.tenants_get(company=company, sort=sort, limit=limit, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TenantsApi->tenants_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **company** | **str**| Company ID | [optional] 
 **sort** | **str**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int**| Maximum number of tenants | [optional] 
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse20012**](InlineResponse20012.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tenants_id_delete**
> tenants_id_delete(id)

Delete tenant

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.TenantsApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Tenant id

try:
    # Delete tenant
    api_instance.tenants_id_delete(id)
except ApiException as e:
    print("Exception when calling TenantsApi->tenants_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Tenant id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tenants_id_get**
> Tenant tenants_id_get(id)

Get tenant

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.TenantsApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Tenant id

try:
    # Get tenant
    api_response = api_instance.tenants_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TenantsApi->tenants_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Tenant id | 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tenants_id_patch**
> Tenant tenants_id_patch(body, id)

Update tenant

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.TenantsApi(swagger_client.ApiClient(configuration))
body = swagger_client.TenantsIdBody() # TenantsIdBody | 
id = 'id_example' # str | Tenant id

try:
    # Update tenant
    api_response = api_instance.tenants_id_patch(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TenantsApi->tenants_id_patch: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantsIdBody**](TenantsIdBody.md)|  | 
 **id** | **str**| Tenant id | 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tenants_post**
> Tenant tenants_post(body)

Create tenant

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.TenantsApi(swagger_client.ApiClient(configuration))
body = swagger_client.TenantsBody() # TenantsBody | 

try:
    # Create tenant
    api_response = api_instance.tenants_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TenantsApi->tenants_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TenantsBody**](TenantsBody.md)|  | 

### Return type

[**Tenant**](Tenant.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

