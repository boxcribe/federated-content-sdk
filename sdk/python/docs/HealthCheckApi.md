# swagger_client.HealthCheckApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**help_get**](HealthCheckApi.md#help_get) | **GET** /help | Help

# **help_get**
> InlineResponse2001 help_get()

Help

Returns a message indicating that the API is up and running.

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# create an instance of the API class
api_instance = swagger_client.HealthCheckApi()

try:
    # Help
    api_response = api_instance.help_get()
    pprint(api_response)
except ApiException as e:
    print("Exception when calling HealthCheckApi->help_get: %s\n" % e)
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

