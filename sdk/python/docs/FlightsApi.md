# swagger_client.FlightsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**flights_bookings_booking_id_cancel_post**](FlightsApi.md#flights_bookings_booking_id_cancel_post) | **POST** /flights/bookings/{bookingId}/cancel | Cancel Booking
[**flights_bookings_booking_id_get**](FlightsApi.md#flights_bookings_booking_id_get) | **GET** /flights/bookings/{bookingId} | Get Booking Details
[**flights_bookings_post**](FlightsApi.md#flights_bookings_post) | **POST** /flights/bookings | Create Booking
[**flights_offers_offer_id_get**](FlightsApi.md#flights_offers_offer_id_get) | **GET** /flights/offers/{offerId} | Get Offer Details
[**flights_offers_offer_id_seatmaps_get**](FlightsApi.md#flights_offers_offer_id_seatmaps_get) | **GET** /flights/offers/{offerId}/seatmaps | Get Offer Seatmaps
[**flights_offers_search_post**](FlightsApi.md#flights_offers_search_post) | **POST** /flights/offers/search | Search Offers

# **flights_bookings_booking_id_cancel_post**
> FlightCancelBookingResponseSchema flights_bookings_booking_id_cancel_post(body)

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
api_instance = swagger_client.FlightsApi(swagger_client.ApiClient(configuration))
body = swagger_client.FlightCancelBookingRequestSchema() # FlightCancelBookingRequestSchema | 

try:
    # Cancel Booking
    api_response = api_instance.flights_bookings_booking_id_cancel_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FlightsApi->flights_bookings_booking_id_cancel_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightCancelBookingRequestSchema**](FlightCancelBookingRequestSchema.md)|  | 

### Return type

[**FlightCancelBookingResponseSchema**](FlightCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **flights_bookings_booking_id_get**
> FlightGetBookingDetailsResponseSchema flights_bookings_booking_id_get(body)

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
api_instance = swagger_client.FlightsApi(swagger_client.ApiClient(configuration))
body = swagger_client.FlightBookingDetailsRequestSchema() # FlightBookingDetailsRequestSchema | 

try:
    # Get Booking Details
    api_response = api_instance.flights_bookings_booking_id_get(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FlightsApi->flights_bookings_booking_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightBookingDetailsRequestSchema**](FlightBookingDetailsRequestSchema.md)|  | 

### Return type

[**FlightGetBookingDetailsResponseSchema**](FlightGetBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **flights_bookings_post**
> FlightBookingResponseSchema flights_bookings_post(body)

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
api_instance = swagger_client.FlightsApi(swagger_client.ApiClient(configuration))
body = swagger_client.FlightCreateBookingRequestSchema() # FlightCreateBookingRequestSchema | 

try:
    # Create Booking
    api_response = api_instance.flights_bookings_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FlightsApi->flights_bookings_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightCreateBookingRequestSchema**](FlightCreateBookingRequestSchema.md)|  | 

### Return type

[**FlightBookingResponseSchema**](FlightBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **flights_offers_offer_id_get**
> FlightOfferDetailsResponseSchema flights_offers_offer_id_get(body)

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
api_instance = swagger_client.FlightsApi(swagger_client.ApiClient(configuration))
body = swagger_client.FlightOfferDetailsRequestSchema() # FlightOfferDetailsRequestSchema | 

try:
    # Get Offer Details
    api_response = api_instance.flights_offers_offer_id_get(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FlightsApi->flights_offers_offer_id_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightOfferDetailsRequestSchema**](FlightOfferDetailsRequestSchema.md)|  | 

### Return type

[**FlightOfferDetailsResponseSchema**](FlightOfferDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **flights_offers_offer_id_seatmaps_get**
> FlightOfferSeatmapsResponseSchema flights_offers_offer_id_seatmaps_get(body)

Get Offer Seatmaps

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
api_instance = swagger_client.FlightsApi(swagger_client.ApiClient(configuration))
body = swagger_client.FlightOfferSeatmapsRequestSchema() # FlightOfferSeatmapsRequestSchema | 

try:
    # Get Offer Seatmaps
    api_response = api_instance.flights_offers_offer_id_seatmaps_get(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FlightsApi->flights_offers_offer_id_seatmaps_get: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightOfferSeatmapsRequestSchema**](FlightOfferSeatmapsRequestSchema.md)|  | 

### Return type

[**FlightOfferSeatmapsResponseSchema**](FlightOfferSeatmapsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **flights_offers_search_post**
> FlightOfferResponseSchema flights_offers_search_post(body)

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
api_instance = swagger_client.FlightsApi(swagger_client.ApiClient(configuration))
body = swagger_client.FlightOfferRequestSchema() # FlightOfferRequestSchema | 

try:
    # Search Offers
    api_response = api_instance.flights_offers_search_post(body)
    pprint(api_response)
except ApiException as e:
    print("Exception when calling FlightsApi->flights_offers_search_post: %s\n" % e)
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**FlightOfferRequestSchema**](FlightOfferRequestSchema.md)|  | 

### Return type

[**FlightOfferResponseSchema**](FlightOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

