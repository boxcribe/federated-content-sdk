# SwaggerClient::HotelsApi

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
> HotelCancelBookingResponseSchema hotels_bookings_booking_id_cancel_post(bodybooking_id)

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

api_instance = SwaggerClient::HotelsApi.new
body = SwaggerClient::HotelCancelBookingRequestSchema.new # HotelCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # String | 


begin
  #Cancel Booking
  result = api_instance.hotels_bookings_booking_id_cancel_post(bodybooking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling HotelsApi->hotels_bookings_booking_id_cancel_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelCancelBookingRequestSchema**](HotelCancelBookingRequestSchema.md)|  | 
 **booking_id** | **String**|  | 

### Return type

[**HotelCancelBookingResponseSchema**](HotelCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **hotels_bookings_booking_id_get**
> HotelBookingDetailsResponseSchema hotels_bookings_booking_id_get(booking_id)

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

api_instance = SwaggerClient::HotelsApi.new
booking_id = 'booking_id_example' # String | 


begin
  #Get Booking Details
  result = api_instance.hotels_bookings_booking_id_get(booking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling HotelsApi->hotels_bookings_booking_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **String**|  | 

### Return type

[**HotelBookingDetailsResponseSchema**](HotelBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **hotels_bookings_post**
> HotelBookingResponseSchema hotels_bookings_post(body)

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

api_instance = SwaggerClient::HotelsApi.new
body = SwaggerClient::HotelCreateBookingRequestSchema.new # HotelCreateBookingRequestSchema | 


begin
  #Create Booking
  result = api_instance.hotels_bookings_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling HotelsApi->hotels_bookings_post: #{e}"
end
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



# **hotels_offer_availability_offer_id_get**
> HotelGetOfferAvailabilityResponse hotels_offer_availability_offer_id_get(bodyoffer_id)

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

api_instance = SwaggerClient::HotelsApi.new
body = SwaggerClient::HotelGetOfferAvailabilityRequest.new # HotelGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Availability
  result = api_instance.hotels_offer_availability_offer_id_get(bodyoffer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling HotelsApi->hotels_offer_availability_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**HotelGetOfferAvailabilityRequest**](HotelGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **String**|  | 

### Return type

[**HotelGetOfferAvailabilityResponse**](HotelGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **hotels_offers_offer_id_get**
> HotelOfferDetailsSchema hotels_offers_offer_id_get(offer_id)

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

api_instance = SwaggerClient::HotelsApi.new
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Details
  result = api_instance.hotels_offers_offer_id_get(offer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling HotelsApi->hotels_offers_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **String**|  | 

### Return type

[**HotelOfferDetailsSchema**](HotelOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **hotels_offers_search_post**
> HotelOfferResponseSchema hotels_offers_search_post(body)

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

api_instance = SwaggerClient::HotelsApi.new
body = SwaggerClient::HotelOfferRequestSchema.new # HotelOfferRequestSchema | 


begin
  #Search Offers
  result = api_instance.hotels_offers_search_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling HotelsApi->hotels_offers_search_post: #{e}"
end
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



