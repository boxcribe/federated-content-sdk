# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TransportsBookingsBookingIdCancelPost**](TransportsApi.md#TransportsBookingsBookingIdCancelPost) | **Post** /transports/bookings/{bookingId}/cancel | Cancel Booking
[**TransportsBookingsBookingIdGet**](TransportsApi.md#TransportsBookingsBookingIdGet) | **Get** /transports/bookings/{bookingId} | Get Booking Details
[**TransportsBookingsPost**](TransportsApi.md#TransportsBookingsPost) | **Post** /transports/bookings | Create Booking
[**TransportsOfferAvailabilityOfferIdGet**](TransportsApi.md#TransportsOfferAvailabilityOfferIdGet) | **Get** /transports/offer_availability/{offerId} | Get Offer Availability
[**TransportsOffersOfferIdGet**](TransportsApi.md#TransportsOffersOfferIdGet) | **Get** /transports/offers/{offerId} | Get Offer Details
[**TransportsOffersSearchPost**](TransportsApi.md#TransportsOffersSearchPost) | **Post** /transports/offers/search | Search Offers

# **TransportsBookingsBookingIdCancelPost**
> TransportCancelBookingResponseSchema TransportsBookingsBookingIdCancelPost(ctx, body, bookingId)
Cancel Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**TransportCancelBookingRequestSchema**](TransportCancelBookingRequestSchema.md)|  | 
  **bookingId** | **string**|  | 

### Return type

[**TransportCancelBookingResponseSchema**](TransportCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TransportsBookingsBookingIdGet**
> TransportBookingDetailsResponseSchema TransportsBookingsBookingIdGet(ctx, bookingId)
Get Booking Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **bookingId** | **string**|  | 

### Return type

[**TransportBookingDetailsResponseSchema**](TransportBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TransportsBookingsPost**
> TransportBookingResponseSchema TransportsBookingsPost(ctx, body)
Create Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**TransportCreateBookingRequestSchema**](TransportCreateBookingRequestSchema.md)|  | 

### Return type

[**TransportBookingResponseSchema**](TransportBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TransportsOfferAvailabilityOfferIdGet**
> TransportGetOfferAvailabilityResponse TransportsOfferAvailabilityOfferIdGet(ctx, body, offerId)
Get Offer Availability

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**TransportGetOfferAvailabilityRequest**](TransportGetOfferAvailabilityRequest.md)|  | 
  **offerId** | **string**|  | 

### Return type

[**TransportGetOfferAvailabilityResponse**](TransportGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TransportsOffersOfferIdGet**
> TransportOfferDetailsSchema TransportsOffersOfferIdGet(ctx, offerId)
Get Offer Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **offerId** | **string**|  | 

### Return type

[**TransportOfferDetailsSchema**](TransportOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **TransportsOffersSearchPost**
> TransportOfferResponseSchema TransportsOffersSearchPost(ctx, body)
Search Offers

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**TransportOfferRequestSchema**](TransportOfferRequestSchema.md)|  | 

### Return type

[**TransportOfferResponseSchema**](TransportOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

