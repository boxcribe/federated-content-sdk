# swagger_client.CategoriesApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**categories_get**](CategoriesApi.md#categories_get) | **GET** /categories | Get categories
[**categories_id_delete**](CategoriesApi.md#categories_id_delete) | **DELETE** /categories/{id} | Delete category
[**categories_id_get**](CategoriesApi.md#categories_id_get) | **GET** /categories/{id} | Get category
[**categories_id_patch**](CategoriesApi.md#categories_id_patch) | **PATCH** /categories/{id} | Update category
[**categories_post**](CategoriesApi.md#categories_post) | **POST** /categories | Create category

# **categories_get**
> InlineResponse2004 categories_get(sort=sort, limit=limit, page=page)

Get categories

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.CategoriesApi(swagger_client.ApiClient(configuration))
sort = 'sort_example' # str | sort by query in the form of field:desc/asc (ex. name:asc) (optional)
limit = 56 # int | Maximum number of categories (optional)
page = 1 # int | Page number (optional) (default to 1)

try:
    # Get categories
    api_response = api_instance.categories_get(sort=sort, limit=limit, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CategoriesApi->categories_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **str**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int**| Maximum number of categories | [optional] 
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **categories_id_delete**
> categories_id_delete(id)

Delete category

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.CategoriesApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Category id

try:
    # Delete category
    api_instance.categories_id_delete(id)
except ApiException as e:
    print("Exception when calling CategoriesApi->categories_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Category id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **categories_id_get**
> Category categories_id_get(id)

Get category

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.CategoriesApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Category id

try:
    # Get category
    api_response = api_instance.categories_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CategoriesApi->categories_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Category id | 

### Return type

[**Category**](Category.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **categories_id_patch**
> Category categories_id_patch(body, id)

Update category

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.CategoriesApi(swagger_client.ApiClient(configuration))
body = swagger_client.CategoriesIdBody() # CategoriesIdBody | 
id = 'id_example' # str | Category id

try:
    # Update category
    api_response = api_instance.categories_id_patch(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CategoriesApi->categories_id_patch: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoriesIdBody**](CategoriesIdBody.md)|  | 
 **id** | **str**| Category id | 

### Return type

[**Category**](Category.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **categories_post**
> Category categories_post(body)

Create category

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.CategoriesApi(swagger_client.ApiClient(configuration))
body = swagger_client.CategoriesBody() # CategoriesBody | 

try:
    # Create category
    api_response = api_instance.categories_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CategoriesApi->categories_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CategoriesBody**](CategoriesBody.md)|  | 

### Return type

[**Category**](Category.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

