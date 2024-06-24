# swagger_client.CompaniesApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companies_get**](CompaniesApi.md#companies_get) | **GET** /companies | Get companies
[**companies_id_delete**](CompaniesApi.md#companies_id_delete) | **DELETE** /companies/{id} | Delete company
[**companies_id_get**](CompaniesApi.md#companies_id_get) | **GET** /companies/{id} | Get company
[**companies_id_patch**](CompaniesApi.md#companies_id_patch) | **PATCH** /companies/{id} | Update company
[**companies_post**](CompaniesApi.md#companies_post) | **POST** /companies | Create company

# **companies_get**
> InlineResponse2005 companies_get(sort=sort, limit=limit, page=page)

Get companies

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.CompaniesApi(swagger_client.ApiClient(configuration))
sort = 'sort_example' # str | sort by query in the form of field:desc/asc (ex. name:asc) (optional)
limit = 56 # int | Maximum number of companies (optional)
page = 1 # int | Page number (optional) (default to 1)

try:
    # Get companies
    api_response = api_instance.companies_get(sort=sort, limit=limit, page=page)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompaniesApi->companies_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **sort** | **str**| sort by query in the form of field:desc/asc (ex. name:asc) | [optional] 
 **limit** | **int**| Maximum number of companies | [optional] 
 **page** | **int**| Page number | [optional] [default to 1]

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_id_delete**
> companies_id_delete(id)

Delete company

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.CompaniesApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Company id

try:
    # Delete company
    api_instance.companies_id_delete(id)
except ApiException as e:
    print("Exception when calling CompaniesApi->companies_id_delete: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Company id | 

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_id_get**
> Company companies_id_get(id)

Get company

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.CompaniesApi(swagger_client.ApiClient(configuration))
id = 'id_example' # str | Company id

try:
    # Get company
    api_response = api_instance.companies_id_get(id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompaniesApi->companies_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **str**| Company id | 

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_id_patch**
> Company companies_id_patch(body, id)

Update company

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.CompaniesApi(swagger_client.ApiClient(configuration))
body = swagger_client.CompaniesIdBody() # CompaniesIdBody | 
id = 'id_example' # str | Company id

try:
    # Update company
    api_response = api_instance.companies_id_patch(body, id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompaniesApi->companies_id_patch: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompaniesIdBody**](CompaniesIdBody.md)|  | 
 **id** | **str**| Company id | 

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **companies_post**
> Company companies_post(body)

Create company

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint


# create an instance of the API class
api_instance = swagger_client.CompaniesApi(swagger_client.ApiClient(configuration))
body = swagger_client.CompaniesBody() # CompaniesBody | 

try:
    # Create company
    api_response = api_instance.companies_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CompaniesApi->companies_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompaniesBody**](CompaniesBody.md)|  | 

### Return type

[**Company**](Company.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

