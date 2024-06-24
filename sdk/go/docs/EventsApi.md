# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EventsBookingsBookingIdCancelPost**](EventsApi.md#EventsBookingsBookingIdCancelPost) | **Post** /events/bookings/{bookingId}/cancel | Cancel Booking
[**EventsBookingsBookingIdGet**](EventsApi.md#EventsBookingsBookingIdGet) | **Get** /events/bookings/{bookingId} | Get Booking Details
[**EventsBookingsPost**](EventsApi.md#EventsBookingsPost) | **Post** /events/bookings | Create Booking
[**EventsOfferAvailabilityOfferIdGet**](EventsApi.md#EventsOfferAvailabilityOfferIdGet) | **Get** /events/offer_availability/{offerId} | Get Offer Availability
[**EventsOffersOfferIdGet**](EventsApi.md#EventsOffersOfferIdGet) | **Get** /events/offers/{offerId} | Get Offer Details
[**EventsOffersSearchPost**](EventsApi.md#EventsOffersSearchPost) | **Post** /events/offers/search | Search Offers

# **EventsBookingsBookingIdCancelPost**
> EventCancelBookingResponseSchema EventsBookingsBookingIdCancelPost(ctx, body, bookingId)
Cancel Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**EventCancelBookingRequestSchema**](EventCancelBookingRequestSchema.md)|  | 
  **bookingId** | **string**|  | 

### Return type

[**EventCancelBookingResponseSchema**](EventCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **EventsBookingsBookingIdGet**
> EventBookingDetailsResponseSchema EventsBookingsBookingIdGet(ctx, bookingId)
Get Booking Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **bookingId** | **string**|  | 

### Return type

[**EventBookingDetailsResponseSchema**](EventBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **EventsBookingsPost**
> EventBookingResponseSchema EventsBookingsPost(ctx, body)
Create Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**EventCreateBookingRequestSchema**](EventCreateBookingRequestSchema.md)|  | 

### Return type

[**EventBookingResponseSchema**](EventBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **EventsOfferAvailabilityOfferIdGet**
> EventGetOfferAvailabilityResponse EventsOfferAvailabilityOfferIdGet(ctx, body, offerId)
Get Offer Availability

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**EventGetOfferAvailabilityRequest**](EventGetOfferAvailabilityRequest.md)|  | 
  **offerId** | **string**|  | 

### Return type

[**EventGetOfferAvailabilityResponse**](EventGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **EventsOffersOfferIdGet**
> EventOfferDetailsSchema EventsOffersOfferIdGet(ctx, offerId)
Get Offer Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **offerId** | **string**|  | 

### Return type

[**EventOfferDetailsSchema**](EventOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **EventsOffersSearchPost**
> EventOfferResponseSchema EventsOffersSearchPost(ctx, body)
Search Offers

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**EventOfferRequestSchema**](EventOfferRequestSchema.md)|  | 

### Return type

[**EventOfferResponseSchema**](EventOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

