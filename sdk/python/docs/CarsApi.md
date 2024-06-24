# swagger_client.CarsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**cars_bookings_booking_id_cancel_post**](CarsApi.md#cars_bookings_booking_id_cancel_post) | **POST** /cars/bookings/{bookingId}/cancel | Cancel Booking
[**cars_bookings_booking_id_get**](CarsApi.md#cars_bookings_booking_id_get) | **GET** /cars/bookings/{bookingId} | Get Booking Details
[**cars_bookings_post**](CarsApi.md#cars_bookings_post) | **POST** /cars/bookings | Create Booking
[**cars_offer_availability_offer_id_get**](CarsApi.md#cars_offer_availability_offer_id_get) | **GET** /cars/offer_availability/{offerId} | Get Offer Availability
[**cars_offers_offer_id_get**](CarsApi.md#cars_offers_offer_id_get) | **GET** /cars/offers/{offerId} | Get Offer Details
[**cars_offers_search_post**](CarsApi.md#cars_offers_search_post) | **POST** /cars/offers/search | Search Offers

# **cars_bookings_booking_id_cancel_post**
> CarCancelBookingResponseSchema cars_bookings_booking_id_cancel_post(body, booking_id)

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
api_instance = swagger_client.CarsApi(swagger_client.ApiClient(configuration))
body = swagger_client.CarCancelBookingRequestSchema() # CarCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # str | 

try:
    # Cancel Booking
    api_response = api_instance.cars_bookings_booking_id_cancel_post(body, booking_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CarsApi->cars_bookings_booking_id_cancel_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarCancelBookingRequestSchema**](CarCancelBookingRequestSchema.md)|  | 
 **booking_id** | **str**|  | 

### Return type

[**CarCancelBookingResponseSchema**](CarCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **cars_bookings_booking_id_get**
> CarBookingDetailsResponseSchema cars_bookings_booking_id_get(booking_id)

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
api_instance = swagger_client.CarsApi(swagger_client.ApiClient(configuration))
booking_id = 'booking_id_example' # str | 

try:
    # Get Booking Details
    api_response = api_instance.cars_bookings_booking_id_get(booking_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CarsApi->cars_bookings_booking_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **str**|  | 

### Return type

[**CarBookingDetailsResponseSchema**](CarBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **cars_bookings_post**
> CarBookingResponseSchema cars_bookings_post(body)

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
api_instance = swagger_client.CarsApi(swagger_client.ApiClient(configuration))
body = swagger_client.CarCreateBookingRequestSchema() # CarCreateBookingRequestSchema | 

try:
    # Create Booking
    api_response = api_instance.cars_bookings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CarsApi->cars_bookings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarCreateBookingRequestSchema**](CarCreateBookingRequestSchema.md)|  | 

### Return type

[**CarBookingResponseSchema**](CarBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **cars_offer_availability_offer_id_get**
> CarGetOfferAvailabilityResponse cars_offer_availability_offer_id_get(body, offer_id)

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
api_instance = swagger_client.CarsApi(swagger_client.ApiClient(configuration))
body = swagger_client.CarGetOfferAvailabilityRequest() # CarGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # str | 

try:
    # Get Offer Availability
    api_response = api_instance.cars_offer_availability_offer_id_get(body, offer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CarsApi->cars_offer_availability_offer_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarGetOfferAvailabilityRequest**](CarGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **str**|  | 

### Return type

[**CarGetOfferAvailabilityResponse**](CarGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **cars_offers_offer_id_get**
> CarOfferDetailsSchema cars_offers_offer_id_get(offer_id)

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
api_instance = swagger_client.CarsApi(swagger_client.ApiClient(configuration))
offer_id = 'offer_id_example' # str | 

try:
    # Get Offer Details
    api_response = api_instance.cars_offers_offer_id_get(offer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CarsApi->cars_offers_offer_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **str**|  | 

### Return type

[**CarOfferDetailsSchema**](CarOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **cars_offers_search_post**
> CarOfferResponseSchema cars_offers_search_post(body)

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
api_instance = swagger_client.CarsApi(swagger_client.ApiClient(configuration))
body = swagger_client.CarOfferRequestSchema() # CarOfferRequestSchema | 

try:
    # Search Offers
    api_response = api_instance.cars_offers_search_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling CarsApi->cars_offers_search_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarOfferRequestSchema**](CarOfferRequestSchema.md)|  | 

### Return type

[**CarOfferResponseSchema**](CarOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

