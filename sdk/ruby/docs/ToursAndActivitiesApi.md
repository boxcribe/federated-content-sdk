# SwaggerClient::ToursAndActivitiesApi

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
> ToursAndActivitiesCancelBookingResponseSchema tours_bookings_booking_id_cancel_post(bodybooking_id)

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

api_instance = SwaggerClient::ToursAndActivitiesApi.new
body = SwaggerClient::ToursAndActivitiesCancelBookingRequestSchema.new # ToursAndActivitiesCancelBookingRequestSchema | 
booking_id = 'booking_id_example' # String | 


begin
  #Cancel Booking
  result = api_instance.tours_bookings_booking_id_cancel_post(bodybooking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ToursAndActivitiesApi->tours_bookings_booking_id_cancel_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesCancelBookingRequestSchema**](ToursAndActivitiesCancelBookingRequestSchema.md)|  | 
 **booking_id** | **String**|  | 

### Return type

[**ToursAndActivitiesCancelBookingResponseSchema**](ToursAndActivitiesCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **tours_bookings_booking_id_get**
> ToursAndActivitiesBookingDetailsResponseSchema tours_bookings_booking_id_get(booking_id)

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

api_instance = SwaggerClient::ToursAndActivitiesApi.new
booking_id = 'booking_id_example' # String | 


begin
  #Get Booking Details
  result = api_instance.tours_bookings_booking_id_get(booking_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ToursAndActivitiesApi->tours_bookings_booking_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **booking_id** | **String**|  | 

### Return type

[**ToursAndActivitiesBookingDetailsResponseSchema**](ToursAndActivitiesBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **tours_bookings_post**
> ToursAndActivitiesBookingResponseSchema tours_bookings_post(body)

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

api_instance = SwaggerClient::ToursAndActivitiesApi.new
body = SwaggerClient::ToursAndActivitiesCreateBookingRequestSchema.new # ToursAndActivitiesCreateBookingRequestSchema | 


begin
  #Create Booking
  result = api_instance.tours_bookings_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ToursAndActivitiesApi->tours_bookings_post: #{e}"
end
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



# **tours_offer_availability_offer_id_post**
> ToursAndActivitiesGetOfferAvailabilityResponse tours_offer_availability_offer_id_post(bodyoffer_id)

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

api_instance = SwaggerClient::ToursAndActivitiesApi.new
body = SwaggerClient::ToursAndActivitiesGetOfferAvailabilityRequest.new # ToursAndActivitiesGetOfferAvailabilityRequest | 
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Availability
  result = api_instance.tours_offer_availability_offer_id_post(bodyoffer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ToursAndActivitiesApi->tours_offer_availability_offer_id_post: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ToursAndActivitiesGetOfferAvailabilityRequest**](ToursAndActivitiesGetOfferAvailabilityRequest.md)|  | 
 **offer_id** | **String**|  | 

### Return type

[**ToursAndActivitiesGetOfferAvailabilityResponse**](ToursAndActivitiesGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json



# **tours_offers_offer_id_get**
> ToursAndActivitiesOfferDetailsSchema tours_offers_offer_id_get(offer_id)

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

api_instance = SwaggerClient::ToursAndActivitiesApi.new
offer_id = 'offer_id_example' # String | 


begin
  #Get Offer Details
  result = api_instance.tours_offers_offer_id_get(offer_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ToursAndActivitiesApi->tours_offers_offer_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **offer_id** | **String**|  | 

### Return type

[**ToursAndActivitiesOfferDetailsSchema**](ToursAndActivitiesOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **tours_offers_search_post**
> ToursAndActivitiesOfferResponseSchema tours_offers_search_post(body)

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

api_instance = SwaggerClient::ToursAndActivitiesApi.new
body = SwaggerClient::ToursAndActivitiesOfferRequestSchema.new # ToursAndActivitiesOfferRequestSchema | 


begin
  #Search Offers
  result = api_instance.tours_offers_search_post(body)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling ToursAndActivitiesApi->tours_offers_search_post: #{e}"
end
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



