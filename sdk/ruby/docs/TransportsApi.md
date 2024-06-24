# SwaggerClient::TransportsApi

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
> TransportCancelBookingResponseSchema transports_bookings_booking_id_cancel_post(bodybooking_id)

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

api_instance = SwaggerClient::TransportsApi.new
body = SwaggerClient::TransportCancelBookingRequestSchema.new # TransportCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # String | 


begin
  #Cancel Booking
  result = api_instance.transports_bookings_booking_id_cancel_post(bodybooking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TransportsApi->transports_bookings_booking_id_cancel_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportCancelBookingRequestSchema**](TransportCancelBookingRequestSchema.md)|  | 
 **booking_id** | **String**|  | 

### Return type

[**TransportCancelBookingResponseSchema**](TransportCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **transports_bookings_booking_id_get**
> TransportBookingDetailsResponseSchema transports_bookings_booking_id_get(booking_id)

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

api_instance = SwaggerClient::TransportsApi.new
booking_id = 'booking_id_example' # String | 


begin
  #Get Booking Details
  result = api_instance.transports_bookings_booking_id_get(booking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TransportsApi->transports_bookings_booking_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **String**|  | 

### Return type

[**TransportBookingDetailsResponseSchema**](TransportBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **transports_bookings_post**
> TransportBookingResponseSchema transports_bookings_post(body)

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

api_instance = SwaggerClient::TransportsApi.new
body = SwaggerClient::TransportCreateBookingRequestSchema.new # TransportCreateBookingRequestSchema | 


begin
  #Create Booking
  result = api_instance.transports_bookings_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TransportsApi->transports_bookings_post: #{e}"
end
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



# **transports_offer_availability_offer_id_get**
> TransportGetOfferAvailabilityResponse transports_offer_availability_offer_id_get(bodyoffer_id)

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

api_instance = SwaggerClient::TransportsApi.new
body = SwaggerClient::TransportGetOfferAvailabilityRequest.new # TransportGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Availability
  result = api_instance.transports_offer_availability_offer_id_get(bodyoffer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TransportsApi->transports_offer_availability_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransportGetOfferAvailabilityRequest**](TransportGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **String**|  | 

### Return type

[**TransportGetOfferAvailabilityResponse**](TransportGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **transports_offers_offer_id_get**
> TransportOfferDetailsSchema transports_offers_offer_id_get(offer_id)

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

api_instance = SwaggerClient::TransportsApi.new
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Details
  result = api_instance.transports_offers_offer_id_get(offer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TransportsApi->transports_offers_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **String**|  | 

### Return type

[**TransportOfferDetailsSchema**](TransportOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **transports_offers_search_post**
> TransportOfferResponseSchema transports_offers_search_post(body)

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

api_instance = SwaggerClient::TransportsApi.new
body = SwaggerClient::TransportOfferRequestSchema.new # TransportOfferRequestSchema | 


begin
  #Search Offers
  result = api_instance.transports_offers_search_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling TransportsApi->transports_offers_search_post: #{e}"
end
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



