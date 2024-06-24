# swagger_client.ToursAndActivitiesApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**tours_bookings_booking_id_cancel_post**](ToursAndActivitiesApi.md#tours_bookings_booking_id_cancel_post) | **POST** /tours/bookings/{bookingId}/cancel | Cancel Booking
[**tours_bookings_booking_id_get**](ToursAndActivitiesApi.md#tours_bookings_booking_id_get) | **GET** /tours/bookings/{bookingId} | Get Booking Details
[**tours_bookings_post**](ToursAndActivitiesApi.md#tours_bookings_post) | **POST** /tours/bookings | Create Booking
[**tours_offer_availability_offer_id_post**](ToursAndActivitiesApi.md#tours_offer_availability_offer_id_post) | **POST** /tours/offer_availability/{offerId} | Get Offer Availability
[**tours_offers_offer_id_get**](ToursAndActivitiesApi.md#tours_offers_offer_id_get) | **GET** /tours/offers/{offerId} | Get Offer Details
[**tours_offers_search_post**](ToursAndActivitiesApi.md#tours_offers_search_post) | **POST** /tours/offers/search | Search Offers

# **tours_bookings_booking_id_cancel_post**
> ToursAndActivitiesCancelBookingResponseSchema tours_bookings_booking_id_cancel_post(body, booking_id)

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
api_instance = swagger_client.ToursAndActivitiesApi(swagger_client.ApiClient(configuration))
body = swagger_client.ToursAndActivitiesCancelBookingRequestSchema() # ToursAndActivitiesCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # str | 

try:
    # Cancel Booking
    api_response = api_instance.tours_bookings_booking_id_cancel_post(body, booking_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ToursAndActivitiesApi->tours_bookings_booking_id_cancel_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesCancelBookingRequestSchema**](ToursAndActivitiesCancelBookingRequestSchema.md)|  | 
 **booking_id** | **str**|  | 

### Return type

[**ToursAndActivitiesCancelBookingResponseSchema**](ToursAndActivitiesCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tours_bookings_booking_id_get**
> ToursAndActivitiesBookingDetailsResponseSchema tours_bookings_booking_id_get(booking_id)

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
api_instance = swagger_client.ToursAndActivitiesApi(swagger_client.ApiClient(configuration))
booking_id = 'booking_id_example' # str | 

try:
    # Get Booking Details
    api_response = api_instance.tours_bookings_booking_id_get(booking_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ToursAndActivitiesApi->tours_bookings_booking_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **str**|  | 

### Return type

[**ToursAndActivitiesBookingDetailsResponseSchema**](ToursAndActivitiesBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tours_bookings_post**
> ToursAndActivitiesBookingResponseSchema tours_bookings_post(body)

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
api_instance = swagger_client.ToursAndActivitiesApi(swagger_client.ApiClient(configuration))
body = swagger_client.ToursAndActivitiesCreateBookingRequestSchema() # ToursAndActivitiesCreateBookingRequestSchema | 

try:
    # Create Booking
    api_response = api_instance.tours_bookings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ToursAndActivitiesApi->tours_bookings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesCreateBookingRequestSchema**](ToursAndActivitiesCreateBookingRequestSchema.md)|  | 

### Return type

[**ToursAndActivitiesBookingResponseSchema**](ToursAndActivitiesBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tours_offer_availability_offer_id_post**
> ToursAndActivitiesGetOfferAvailabilityResponse tours_offer_availability_offer_id_post(body, offer_id)

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
api_instance = swagger_client.ToursAndActivitiesApi(swagger_client.ApiClient(configuration))
body = swagger_client.ToursAndActivitiesGetOfferAvailabilityRequest() # ToursAndActivitiesGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # str | 

try:
    # Get Offer Availability
    api_response = api_instance.tours_offer_availability_offer_id_post(body, offer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ToursAndActivitiesApi->tours_offer_availability_offer_id_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesGetOfferAvailabilityRequest**](ToursAndActivitiesGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **str**|  | 

### Return type

[**ToursAndActivitiesGetOfferAvailabilityResponse**](ToursAndActivitiesGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tours_offers_offer_id_get**
> ToursAndActivitiesOfferDetailsSchema tours_offers_offer_id_get(offer_id)

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
api_instance = swagger_client.ToursAndActivitiesApi(swagger_client.ApiClient(configuration))
offer_id = 'offer_id_example' # str | 

try:
    # Get Offer Details
    api_response = api_instance.tours_offers_offer_id_get(offer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ToursAndActivitiesApi->tours_offers_offer_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **str**|  | 

### Return type

[**ToursAndActivitiesOfferDetailsSchema**](ToursAndActivitiesOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **tours_offers_search_post**
> ToursAndActivitiesOfferResponseSchema tours_offers_search_post(body)

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
api_instance = swagger_client.ToursAndActivitiesApi(swagger_client.ApiClient(configuration))
body = swagger_client.ToursAndActivitiesOfferRequestSchema() # ToursAndActivitiesOfferRequestSchema | 

try:
    # Search Offers
    api_response = api_instance.tours_offers_search_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling ToursAndActivitiesApi->tours_offers_search_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesOfferRequestSchema**](ToursAndActivitiesOfferRequestSchema.md)|  | 

### Return type

[**ToursAndActivitiesOfferResponseSchema**](ToursAndActivitiesOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

