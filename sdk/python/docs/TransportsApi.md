# swagger_client.TransportsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**transports_bookings_booking_id_cancel_post**](TransportsApi.md#transports_bookings_booking_id_cancel_post) | **POST** /transports/bookings/{bookingId}/cancel | Cancel Booking
[**transports_bookings_booking_id_get**](TransportsApi.md#transports_bookings_booking_id_get) | **GET** /transports/bookings/{bookingId} | Get Booking Details
[**transports_bookings_post**](TransportsApi.md#transports_bookings_post) | **POST** /transports/bookings | Create Booking
[**transports_offer_availability_offer_id_get**](TransportsApi.md#transports_offer_availability_offer_id_get) | **GET** /transports/offer_availability/{offerId} | Get Offer Availability
[**transports_offers_offer_id_get**](TransportsApi.md#transports_offers_offer_id_get) | **GET** /transports/offers/{offerId} | Get Offer Details
[**transports_offers_search_post**](TransportsApi.md#transports_offers_search_post) | **POST** /transports/offers/search | Search Offers

# **transports_bookings_booking_id_cancel_post**
> TransportCancelBookingResponseSchema transports_bookings_booking_id_cancel_post(body, booking_id)

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
api_instance = swagger_client.TransportsApi(swagger_client.ApiClient(configuration))
body = swagger_client.TransportCancelBookingRequestSchema() # TransportCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # str | 

try:
    # Cancel Booking
    api_response = api_instance.transports_bookings_booking_id_cancel_post(body, booking_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransportsApi->transports_bookings_booking_id_cancel_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportCancelBookingRequestSchema**](TransportCancelBookingRequestSchema.md)|  | 
 **booking_id** | **str**|  | 

### Return type

[**TransportCancelBookingResponseSchema**](TransportCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **transports_bookings_booking_id_get**
> TransportBookingDetailsResponseSchema transports_bookings_booking_id_get(booking_id)

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
api_instance = swagger_client.TransportsApi(swagger_client.ApiClient(configuration))
booking_id = 'booking_id_example' # str | 

try:
    # Get Booking Details
    api_response = api_instance.transports_bookings_booking_id_get(booking_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransportsApi->transports_bookings_booking_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **str**|  | 

### Return type

[**TransportBookingDetailsResponseSchema**](TransportBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **transports_bookings_post**
> TransportBookingResponseSchema transports_bookings_post(body)

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
api_instance = swagger_client.TransportsApi(swagger_client.ApiClient(configuration))
body = swagger_client.TransportCreateBookingRequestSchema() # TransportCreateBookingRequestSchema | 

try:
    # Create Booking
    api_response = api_instance.transports_bookings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransportsApi->transports_bookings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportCreateBookingRequestSchema**](TransportCreateBookingRequestSchema.md)|  | 

### Return type

[**TransportBookingResponseSchema**](TransportBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **transports_offer_availability_offer_id_get**
> TransportGetOfferAvailabilityResponse transports_offer_availability_offer_id_get(body, offer_id)

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
api_instance = swagger_client.TransportsApi(swagger_client.ApiClient(configuration))
body = swagger_client.TransportGetOfferAvailabilityRequest() # TransportGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # str | 

try:
    # Get Offer Availability
    api_response = api_instance.transports_offer_availability_offer_id_get(body, offer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransportsApi->transports_offer_availability_offer_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportGetOfferAvailabilityRequest**](TransportGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **str**|  | 

### Return type

[**TransportGetOfferAvailabilityResponse**](TransportGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **transports_offers_offer_id_get**
> TransportOfferDetailsSchema transports_offers_offer_id_get(offer_id)

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
api_instance = swagger_client.TransportsApi(swagger_client.ApiClient(configuration))
offer_id = 'offer_id_example' # str | 

try:
    # Get Offer Details
    api_response = api_instance.transports_offers_offer_id_get(offer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransportsApi->transports_offers_offer_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **str**|  | 

### Return type

[**TransportOfferDetailsSchema**](TransportOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **transports_offers_search_post**
> TransportOfferResponseSchema transports_offers_search_post(body)

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
api_instance = swagger_client.TransportsApi(swagger_client.ApiClient(configuration))
body = swagger_client.TransportOfferRequestSchema() # TransportOfferRequestSchema | 

try:
    # Search Offers
    api_response = api_instance.transports_offers_search_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling TransportsApi->transports_offers_search_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportOfferRequestSchema**](TransportOfferRequestSchema.md)|  | 

### Return type

[**TransportOfferResponseSchema**](TransportOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

