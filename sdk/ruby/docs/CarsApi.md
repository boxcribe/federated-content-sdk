# SwaggerClient::CarsApi

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
> CarCancelBookingResponseSchema cars_bookings_booking_id_cancel_post(bodybooking_id)

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

api_instance = SwaggerClient::CarsApi.new
body = SwaggerClient::CarCancelBookingRequestSchema.new # CarCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # String | 


begin
  #Cancel Booking
  result = api_instance.cars_bookings_booking_id_cancel_post(bodybooking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CarsApi->cars_bookings_booking_id_cancel_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarCancelBookingRequestSchema**](CarCancelBookingRequestSchema.md)|  | 
 **booking_id** | **String**|  | 

### Return type

[**CarCancelBookingResponseSchema**](CarCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **cars_bookings_booking_id_get**
> CarBookingDetailsResponseSchema cars_bookings_booking_id_get(booking_id)

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

api_instance = SwaggerClient::CarsApi.new
booking_id = 'booking_id_example' # String | 


begin
  #Get Booking Details
  result = api_instance.cars_bookings_booking_id_get(booking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CarsApi->cars_bookings_booking_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **String**|  | 

### Return type

[**CarBookingDetailsResponseSchema**](CarBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **cars_bookings_post**
> CarBookingResponseSchema cars_bookings_post(body)

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

api_instance = SwaggerClient::CarsApi.new
body = SwaggerClient::CarCreateBookingRequestSchema.new # CarCreateBookingRequestSchema | 


begin
  #Create Booking
  result = api_instance.cars_bookings_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CarsApi->cars_bookings_post: #{e}"
end
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



# **cars_offer_availability_offer_id_get**
> CarGetOfferAvailabilityResponse cars_offer_availability_offer_id_get(bodyoffer_id)

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

api_instance = SwaggerClient::CarsApi.new
body = SwaggerClient::CarGetOfferAvailabilityRequest.new # CarGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Availability
  result = api_instance.cars_offer_availability_offer_id_get(bodyoffer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CarsApi->cars_offer_availability_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CarGetOfferAvailabilityRequest**](CarGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **String**|  | 

### Return type

[**CarGetOfferAvailabilityResponse**](CarGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **cars_offers_offer_id_get**
> CarOfferDetailsSchema cars_offers_offer_id_get(offer_id)

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

api_instance = SwaggerClient::CarsApi.new
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Details
  result = api_instance.cars_offers_offer_id_get(offer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CarsApi->cars_offers_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **String**|  | 

### Return type

[**CarOfferDetailsSchema**](CarOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **cars_offers_search_post**
> CarOfferResponseSchema cars_offers_search_post(body)

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

api_instance = SwaggerClient::CarsApi.new
body = SwaggerClient::CarOfferRequestSchema.new # CarOfferRequestSchema | 


begin
  #Search Offers
  result = api_instance.cars_offers_search_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling CarsApi->cars_offers_search_post: #{e}"
end
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



