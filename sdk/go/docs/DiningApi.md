# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DiningBookingsBookingIdCancelPost**](DiningApi.md#DiningBookingsBookingIdCancelPost) | **Post** /dining/bookings/{bookingId}/cancel | Cancel Booking
[**DiningBookingsBookingIdGet**](DiningApi.md#DiningBookingsBookingIdGet) | **Get** /dining/bookings/{bookingId} | Get Booking Details
[**DiningBookingsPost**](DiningApi.md#DiningBookingsPost) | **Post** /dining/bookings | Create Booking
[**DiningOfferAvailabilityOfferIdGet**](DiningApi.md#DiningOfferAvailabilityOfferIdGet) | **Get** /dining/offer_availability/{offerId} | Get Offer Availability
[**DiningOffersOfferIdGet**](DiningApi.md#DiningOffersOfferIdGet) | **Get** /dining/offers/{offerId} | Get Offer Details
[**DiningOffersSearchPost**](DiningApi.md#DiningOffersSearchPost) | **Post** /dining/offers/search | Search Offers

# **DiningBookingsBookingIdCancelPost**
> DiningCancelBookingResponseSchema DiningBookingsBookingIdCancelPost(ctx, body, bookingId)
Cancel Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**DiningCancelBookingRequestSchema**](DiningCancelBookingRequestSchema.md)|  | 
  **bookingId** | **string**|  | 

### Return type

[**DiningCancelBookingResponseSchema**](DiningCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DiningBookingsBookingIdGet**
> DiningBookingDetailsResponseSchema DiningBookingsBookingIdGet(ctx, bookingId)
Get Booking Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **bookingId** | **string**|  | 

### Return type

[**DiningBookingDetailsResponseSchema**](DiningBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DiningBookingsPost**
> DiningBookingResponseSchema DiningBookingsPost(ctx, body)
Create Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**DiningCreateBookingRequestSchema**](DiningCreateBookingRequestSchema.md)|  | 

### Return type

[**DiningBookingResponseSchema**](DiningBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DiningOfferAvailabilityOfferIdGet**
> DiningGetOfferAvailabilityResponse DiningOfferAvailabilityOfferIdGet(ctx, body, offerId)
Get Offer Availability

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**DiningGetOfferAvailabilityRequest**](DiningGetOfferAvailabilityRequest.md)|  | 
  **offerId** | **string**|  | 

### Return type

[**DiningGetOfferAvailabilityResponse**](DiningGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DiningOffersOfferIdGet**
> DiningOfferDetailsSchema DiningOffersOfferIdGet(ctx, offerId)
Get Offer Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **offerId** | **string**|  | 

### Return type

[**DiningOfferDetailsSchema**](DiningOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **DiningOffersSearchPost**
> DiningOfferResponseSchema DiningOffersSearchPost(ctx, body)
Search Offers

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**DiningOfferRequestSchema**](DiningOfferRequestSchema.md)|  | 

### Return type

[**DiningOfferResponseSchema**](DiningOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

