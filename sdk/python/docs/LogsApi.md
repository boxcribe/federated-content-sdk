# swagger_client.LogsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**logs_get**](LogsApi.md#logs_get) | **GET** /logs | Get logs
[**logs_id_delete**](LogsApi.md#logs_id_delete) | **DELETE** /logs/{id} | Delete log
[**logs_id_get**](LogsApi.md#logs_id_get) | **GET** /logs/{id} | Get log
[**logs_id_patch**](LogsApi.md#logs_id_patch) | **PATCH** /logs/{id} | Update log
[**logs_post**](LogsApi.md#logs_post) | **POST** /logs | Create log

# **logs_get**
> InlineResponse2008 logs_get(sort=sort, limit=limit, page=page)

Get logs

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.LogsApi(swagger_client.ApiClient(configuration))
sort = 'sort_example' # str | sort by query in the form of field:desc/asc (ex. name:asc) (optional)
limit = 56 # int | Maximum number of logs (optional)
page = 1 # int | Page number (optional) (default to 1)

try:
    # Get logs
    api_response = api_instance.logs_get(sort=sort, limit=limit, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LogsApi->logs_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **str**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int**| Maximum number of logs | [optional] 
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **logs_id_delete**
> logs_id_delete(id)

Delete log

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.LogsApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Log id

try:
    # Delete log
    api_instance.logs_id_delete(id)
except ApiException as e:
    print("Exception when calling LogsApi->logs_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Log id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **logs_id_get**
> Log logs_id_get(id)

Get log

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.LogsApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Log id

try:
    # Get log
    api_response = api_instance.logs_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LogsApi->logs_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Log id | 

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **logs_id_patch**
> Log logs_id_patch(body, id)

Update log

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.LogsApi(swagger_client.ApiClient(configuration))
body = swagger_client.LogsIdBody() # LogsIdBody | 
id = 'id_example' # str | Log id

try:
    # Update log
    api_response = api_instance.logs_id_patch(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LogsApi->logs_id_patch: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LogsIdBody**](LogsIdBody.md)|  | 
 **id** | **str**| Log id | 

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **logs_post**
> Log logs_post(body)

Create log

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.LogsApi(swagger_client.ApiClient(configuration))
body = swagger_client.LogsBody() # LogsBody | 

try:
    # Create log
    api_response = api_instance.logs_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling LogsApi->logs_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LogsBody**](LogsBody.md)|  | 

### Return type

[**Log**](Log.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

