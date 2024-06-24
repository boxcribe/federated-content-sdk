# SwaggerClient::FlightsApi

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

api_instance = SwaggerClient::FlightsApi.new
body = SwaggerClient::FlightCancelBookingRequestSchema.new # FlightCancelBookingRequestSchema | 


begin
  #Cancel Booking
  result = api_instance.flights_bookings_booking_id_cancel_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FlightsApi->flights_bookings_booking_id_cancel_post: #{e}"
end
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



# **flights_bookings_booking_id_get**
> FlightGetBookingDetailsResponseSchema flights_bookings_booking_id_get(body)

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

api_instance = SwaggerClient::FlightsApi.new
body = SwaggerClient::FlightBookingDetailsRequestSchema.new # FlightBookingDetailsRequestSchema | 


begin
  #Get Booking Details
  result = api_instance.flights_bookings_booking_id_get(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FlightsApi->flights_bookings_booking_id_get: #{e}"
end
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



# **flights_bookings_post**
> FlightBookingResponseSchema flights_bookings_post(body)

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

api_instance = SwaggerClient::FlightsApi.new
body = SwaggerClient::FlightCreateBookingRequestSchema.new # FlightCreateBookingRequestSchema | 


begin
  #Create Booking
  result = api_instance.flights_bookings_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FlightsApi->flights_bookings_post: #{e}"
end
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



# **flights_offers_offer_id_get**
> FlightOfferDetailsResponseSchema flights_offers_offer_id_get(body)

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

api_instance = SwaggerClient::FlightsApi.new
body = SwaggerClient::FlightOfferDetailsRequestSchema.new # FlightOfferDetailsRequestSchema | 


begin
  #Get Offer Details
  result = api_instance.flights_offers_offer_id_get(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FlightsApi->flights_offers_offer_id_get: #{e}"
end
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



# **flights_offers_offer_id_seatmaps_get**
> FlightOfferSeatmapsResponseSchema flights_offers_offer_id_seatmaps_get(body)

Get Offer Seatmaps

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

api_instance = SwaggerClient::FlightsApi.new
body = SwaggerClient::FlightOfferSeatmapsRequestSchema.new # FlightOfferSeatmapsRequestSchema | 


begin
  #Get Offer Seatmaps
  result = api_instance.flights_offers_offer_id_seatmaps_get(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FlightsApi->flights_offers_offer_id_seatmaps_get: #{e}"
end
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



# **flights_offers_search_post**
> FlightOfferResponseSchema flights_offers_search_post(body)

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

api_instance = SwaggerClient::FlightsApi.new
body = SwaggerClient::FlightOfferRequestSchema.new # FlightOfferRequestSchema | 


begin
  #Search Offers
  result = api_instance.flights_offers_search_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling FlightsApi->flights_offers_search_post: #{e}"
end
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



