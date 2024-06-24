# SwaggerClient::DiningApi

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
> DiningCancelBookingResponseSchema dining_bookings_booking_id_cancel_post(bodybooking_id)

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

api_instance = SwaggerClient::DiningApi.new
body = SwaggerClient::DiningCancelBookingRequestSchema.new # DiningCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # String | 


begin
  #Cancel Booking
  result = api_instance.dining_bookings_booking_id_cancel_post(bodybooking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DiningApi->dining_bookings_booking_id_cancel_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningCancelBookingRequestSchema**](DiningCancelBookingRequestSchema.md)|  | 
 **booking_id** | **String**|  | 

### Return type

[**DiningCancelBookingResponseSchema**](DiningCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **dining_bookings_booking_id_get**
> DiningBookingDetailsResponseSchema dining_bookings_booking_id_get(booking_id)

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

api_instance = SwaggerClient::DiningApi.new
booking_id = 'booking_id_example' # String | 


begin
  #Get Booking Details
  result = api_instance.dining_bookings_booking_id_get(booking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DiningApi->dining_bookings_booking_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **String**|  | 

### Return type

[**DiningBookingDetailsResponseSchema**](DiningBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **dining_bookings_post**
> DiningBookingResponseSchema dining_bookings_post(body)

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

api_instance = SwaggerClient::DiningApi.new
body = SwaggerClient::DiningCreateBookingRequestSchema.new # DiningCreateBookingRequestSchema | 


begin
  #Create Booking
  result = api_instance.dining_bookings_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DiningApi->dining_bookings_post: #{e}"
end
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



# **dining_offer_availability_offer_id_get**
> DiningGetOfferAvailabilityResponse dining_offer_availability_offer_id_get(bodyoffer_id)

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

api_instance = SwaggerClient::DiningApi.new
body = SwaggerClient::DiningGetOfferAvailabilityRequest.new # DiningGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Availability
  result = api_instance.dining_offer_availability_offer_id_get(bodyoffer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DiningApi->dining_offer_availability_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**DiningGetOfferAvailabilityRequest**](DiningGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **String**|  | 

### Return type

[**DiningGetOfferAvailabilityResponse**](DiningGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **dining_offers_offer_id_get**
> DiningOfferDetailsSchema dining_offers_offer_id_get(offer_id)

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

api_instance = SwaggerClient::DiningApi.new
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Details
  result = api_instance.dining_offers_offer_id_get(offer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DiningApi->dining_offers_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **String**|  | 

### Return type

[**DiningOfferDetailsSchema**](DiningOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **dining_offers_search_post**
> DiningOfferResponseSchema dining_offers_search_post(body)

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

api_instance = SwaggerClient::DiningApi.new
body = SwaggerClient::DiningOfferRequestSchema.new # DiningOfferRequestSchema | 


begin
  #Search Offers
  result = api_instance.dining_offers_search_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DiningApi->dining_offers_search_post: #{e}"
end
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



