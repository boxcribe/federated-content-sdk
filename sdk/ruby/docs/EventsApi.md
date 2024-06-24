# SwaggerClient::EventsApi

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**events_bookings_booking_id_cancel_post**](EventsApi.md#events_bookings_booking_id_cancel_post) | **POST** /events/bookings/{bookingId}/cancel | Cancel Booking
[**events_bookings_booking_id_get**](EventsApi.md#events_bookings_booking_id_get) | **GET** /events/bookings/{bookingId} | Get Booking Details
[**events_bookings_post**](EventsApi.md#events_bookings_post) | **POST** /events/bookings | Create Booking
[**events_offer_availability_offer_id_get**](EventsApi.md#events_offer_availability_offer_id_get) | **GET** /events/offer_availability/{offerId} | Get Offer Availability
[**events_offers_offer_id_get**](EventsApi.md#events_offers_offer_id_get) | **GET** /events/offers/{offerId} | Get Offer Details
[**events_offers_search_post**](EventsApi.md#events_offers_search_post) | **POST** /events/offers/search | Search Offers

# **events_bookings_booking_id_cancel_post**
> EventCancelBookingResponseSchema events_bookings_booking_id_cancel_post(bodybooking_id)

Cancel Booking

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::EventsApi.new
body = SwaggerClient::EventCancelBookingRequestSchema.new # EventCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # String | 


begin
  #Cancel Booking
  result = api_instance.events_bookings_booking_id_cancel_post(bodybooking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling EventsApi->events_bookings_booking_id_cancel_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventCancelBookingRequestSchema**](EventCancelBookingRequestSchema.md)|  | 
 **booking_id** | **String**|  | 

### Return type

[**EventCancelBookingResponseSchema**](EventCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **events_bookings_booking_id_get**
> EventBookingDetailsResponseSchema events_bookings_booking_id_get(booking_id)

Get Booking Details

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::EventsApi.new
booking_id = 'booking_id_example' # String | 


begin
  #Get Booking Details
  result = api_instance.events_bookings_booking_id_get(booking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling EventsApi->events_bookings_booking_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **String**|  | 

### Return type

[**EventBookingDetailsResponseSchema**](EventBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **events_bookings_post**
> EventBookingResponseSchema events_bookings_post(body)

Create Booking

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::EventsApi.new
body = SwaggerClient::EventCreateBookingRequestSchema.new # EventCreateBookingRequestSchema | 


begin
  #Create Booking
  result = api_instance.events_bookings_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling EventsApi->events_bookings_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventCreateBookingRequestSchema**](EventCreateBookingRequestSchema.md)|  | 

### Return type

[**EventBookingResponseSchema**](EventBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **events_offer_availability_offer_id_get**
> EventGetOfferAvailabilityResponse events_offer_availability_offer_id_get(bodyoffer_id)

Get Offer Availability

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::EventsApi.new
body = SwaggerClient::EventGetOfferAvailabilityRequest.new # EventGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Availability
  result = api_instance.events_offer_availability_offer_id_get(bodyoffer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling EventsApi->events_offer_availability_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventGetOfferAvailabilityRequest**](EventGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **String**|  | 

### Return type

[**EventGetOfferAvailabilityResponse**](EventGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **events_offers_offer_id_get**
> EventOfferDetailsSchema events_offers_offer_id_get(offer_id)

Get Offer Details

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::EventsApi.new
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Details
  result = api_instance.events_offers_offer_id_get(offer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling EventsApi->events_offers_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **String**|  | 

### Return type

[**EventOfferDetailsSchema**](EventOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **events_offers_search_post**
> EventOfferResponseSchema events_offers_search_post(body)

Search Offers

### Example
```ruby
# load the gem
require 'swagger_client'
# setup authorization
SwaggerClient.configure do |config|
  # Configure API key authorization: apiKeyAuth
  config.api_key['x-api-key'] = 'YOUR API KEY'
  # Uncomment the following line to set a prefix for the API key, e.g. 'Bearer' (defaults to nil)
  #config.api_key_prefix['x-api-key'] = 'Bearer'
end

api_instance = SwaggerClient::EventsApi.new
body = SwaggerClient::EventOfferRequestSchema.new # EventOfferRequestSchema | 


begin
  #Search Offers
  result = api_instance.events_offers_search_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling EventsApi->events_offers_search_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EventOfferRequestSchema**](EventOfferRequestSchema.md)|  | 

### Return type

[**EventOfferResponseSchema**](EventOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



