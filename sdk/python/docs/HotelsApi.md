# swagger_client.HotelsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**hotels_bookings_booking_id_cancel_post**](HotelsApi.md#hotels_bookings_booking_id_cancel_post) | **POST** /hotels/bookings/{bookingId}/cancel | Cancel Booking
[**hotels_bookings_booking_id_get**](HotelsApi.md#hotels_bookings_booking_id_get) | **GET** /hotels/bookings/{bookingId} | Get Booking Details
[**hotels_bookings_post**](HotelsApi.md#hotels_bookings_post) | **POST** /hotels/bookings | Create Booking
[**hotels_offer_availability_offer_id_get**](HotelsApi.md#hotels_offer_availability_offer_id_get) | **GET** /hotels/offer_availability/{offerId} | Get Offer Availability
[**hotels_offers_offer_id_get**](HotelsApi.md#hotels_offers_offer_id_get) | **GET** /hotels/offers/{offerId} | Get Offer Details
[**hotels_offers_search_post**](HotelsApi.md#hotels_offers_search_post) | **POST** /hotels/offers/search | Search Offers

# **hotels_bookings_booking_id_cancel_post**
> HotelCancelBookingResponseSchema hotels_bookings_booking_id_cancel_post(body, booking_id)

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
api_instance = swagger_client.HotelsApi(swagger_client.ApiClient(configuration))
body = swagger_client.HotelCancelBookingRequestSchema() # HotelCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # str | 

try:
    # Cancel Booking
    api_response = api_instance.hotels_bookings_booking_id_cancel_post(body, booking_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling HotelsApi->hotels_bookings_booking_id_cancel_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelCancelBookingRequestSchema**](HotelCancelBookingRequestSchema.md)|  | 
 **booking_id** | **str**|  | 

### Return type

[**HotelCancelBookingResponseSchema**](HotelCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **hotels_bookings_booking_id_get**
> HotelBookingDetailsResponseSchema hotels_bookings_booking_id_get(booking_id)

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
api_instance = swagger_client.HotelsApi(swagger_client.ApiClient(configuration))
booking_id = 'booking_id_example' # str | 

try:
    # Get Booking Details
    api_response = api_instance.hotels_bookings_booking_id_get(booking_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling HotelsApi->hotels_bookings_booking_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **str**|  | 

### Return type

[**HotelBookingDetailsResponseSchema**](HotelBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **hotels_bookings_post**
> HotelBookingResponseSchema hotels_bookings_post(body)

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
api_instance = swagger_client.HotelsApi(swagger_client.ApiClient(configuration))
body = swagger_client.HotelCreateBookingRequestSchema() # HotelCreateBookingRequestSchema | 

try:
    # Create Booking
    api_response = api_instance.hotels_bookings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling HotelsApi->hotels_bookings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelCreateBookingRequestSchema**](HotelCreateBookingRequestSchema.md)|  | 

### Return type

[**HotelBookingResponseSchema**](HotelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **hotels_offer_availability_offer_id_get**
> HotelGetOfferAvailabilityResponse hotels_offer_availability_offer_id_get(body, offer_id)

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
api_instance = swagger_client.HotelsApi(swagger_client.ApiClient(configuration))
body = swagger_client.HotelGetOfferAvailabilityRequest() # HotelGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # str | 

try:
    # Get Offer Availability
    api_response = api_instance.hotels_offer_availability_offer_id_get(body, offer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling HotelsApi->hotels_offer_availability_offer_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelGetOfferAvailabilityRequest**](HotelGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **str**|  | 

### Return type

[**HotelGetOfferAvailabilityResponse**](HotelGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **hotels_offers_offer_id_get**
> HotelOfferDetailsSchema hotels_offers_offer_id_get(offer_id)

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
api_instance = swagger_client.HotelsApi(swagger_client.ApiClient(configuration))
offer_id = 'offer_id_example' # str | 

try:
    # Get Offer Details
    api_response = api_instance.hotels_offers_offer_id_get(offer_id)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling HotelsApi->hotels_offers_offer_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **str**|  | 

### Return type

[**HotelOfferDetailsSchema**](HotelOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **hotels_offers_search_post**
> HotelOfferResponseSchema hotels_offers_search_post(body)

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
api_instance = swagger_client.HotelsApi(swagger_client.ApiClient(configuration))
body = swagger_client.HotelOfferRequestSchema() # HotelOfferRequestSchema | 

try:
    # Search Offers
    api_response = api_instance.hotels_offers_search_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling HotelsApi->hotels_offers_search_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelOfferRequestSchema**](HotelOfferRequestSchema.md)|  | 

### Return type

[**HotelOfferResponseSchema**](HotelOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

