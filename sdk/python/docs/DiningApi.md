# swagger_client.DiningApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**dining_bookings_booking_id_cancel_post**](DiningApi.md#dining_bookings_booking_id_cancel_post) | **POST** /dining/bookings/{bookingId}/cancel | Cancel Booking
[**dining_bookings_booking_id_get**](DiningApi.md#dining_bookings_booking_id_get) | **GET** /dining/bookings/{bookingId} | Get Booking Details
[**dining_bookings_post**](DiningApi.md#dining_bookings_post) | **POST** /dining/bookings | Create Booking
[**dining_offer_availability_offer_id_get**](DiningApi.md#dining_offer_availability_offer_id_get) | **GET** /dining/offer_availability/{offerId} | Get Offer Availability
[**dining_offers_offer_id_get**](DiningApi.md#dining_offers_offer_id_get) | **GET** /dining/offers/{offerId} | Get Offer Details
[**dining_offers_search_post**](DiningApi.md#dining_offers_search_post) | **POST** /dining/offers/search | Search Offers

# **dining_bookings_booking_id_cancel_post**
> DiningCancelBookingResponseSchema dining_bookings_booking_id_cancel_post(body, booking_id)

Cancel Booking

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.DiningApi(swagger_client.ApiClient(configuration))
body = swagger_client.DiningCancelBookingRequestSchema() # DiningCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # str | 

try:
    # Cancel Booking
    api_response = api_instance.dining_bookings_booking_id_cancel_post(body, booking_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DiningApi->dining_bookings_booking_id_cancel_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningCancelBookingRequestSchema**](DiningCancelBookingRequestSchema.md)|  | 
 **booking_id** | **str**|  | 

### Return type

[**DiningCancelBookingResponseSchema**](DiningCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dining_bookings_booking_id_get**
> DiningBookingDetailsResponseSchema dining_bookings_booking_id_get(booking_id)

Get Booking Details

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.DiningApi(swagger_client.ApiClient(configuration))
booking_id = 'booking_id_example' # str | 

try:
    # Get Booking Details
    api_response = api_instance.dining_bookings_booking_id_get(booking_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DiningApi->dining_bookings_booking_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **str**|  | 

### Return type

[**DiningBookingDetailsResponseSchema**](DiningBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dining_bookings_post**
> DiningBookingResponseSchema dining_bookings_post(body)

Create Booking

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.DiningApi(swagger_client.ApiClient(configuration))
body = swagger_client.DiningCreateBookingRequestSchema() # DiningCreateBookingRequestSchema | 

try:
    # Create Booking
    api_response = api_instance.dining_bookings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DiningApi->dining_bookings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningCreateBookingRequestSchema**](DiningCreateBookingRequestSchema.md)|  | 

### Return type

[**DiningBookingResponseSchema**](DiningBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dining_offer_availability_offer_id_get**
> DiningGetOfferAvailabilityResponse dining_offer_availability_offer_id_get(body, offer_id)

Get Offer Availability

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.DiningApi(swagger_client.ApiClient(configuration))
body = swagger_client.DiningGetOfferAvailabilityRequest() # DiningGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # str | 

try:
    # Get Offer Availability
    api_response = api_instance.dining_offer_availability_offer_id_get(body, offer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DiningApi->dining_offer_availability_offer_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningGetOfferAvailabilityRequest**](DiningGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **str**|  | 

### Return type

[**DiningGetOfferAvailabilityResponse**](DiningGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dining_offers_offer_id_get**
> DiningOfferDetailsSchema dining_offers_offer_id_get(offer_id)

Get Offer Details

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.DiningApi(swagger_client.ApiClient(configuration))
offer_id = 'offer_id_example' # str | 

try:
    # Get Offer Details
    api_response = api_instance.dining_offers_offer_id_get(offer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DiningApi->dining_offers_offer_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **str**|  | 

### Return type

[**DiningOfferDetailsSchema**](DiningOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **dining_offers_search_post**
> DiningOfferResponseSchema dining_offers_search_post(body)

Search Offers

### Example
```python
from __future__ import print_function
import time
import swagger_client
from swagger_client.rest import ApiException
from pprint import pprint

# Configure API key authorization: apiKeyAuth
configuration = swagger_client.Configuration()
configuration.api_key['x-api-key'] = 'YOUR_API_KEY'
# Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
# configuration.api_key_prefix['x-api-key'] = 'Bearer'

# create an instance of the API class
api_instance = swagger_client.DiningApi(swagger_client.ApiClient(configuration))
body = swagger_client.DiningOfferRequestSchema() # DiningOfferRequestSchema | 

try:
    # Search Offers
    api_response = api_instance.dining_offers_search_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling DiningApi->dining_offers_search_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningOfferRequestSchema**](DiningOfferRequestSchema.md)|  | 

### Return type

[**DiningOfferResponseSchema**](DiningOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

