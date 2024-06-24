# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ToursBookingsBookingIdCancelPost**](ToursAndActivitiesApi.md#ToursBookingsBookingIdCancelPost) | **Post** /tours/bookings/{bookingId}/cancel | Cancel Booking
[**ToursBookingsBookingIdGet**](ToursAndActivitiesApi.md#ToursBookingsBookingIdGet) | **Get** /tours/bookings/{bookingId} | Get Booking Details
[**ToursBookingsPost**](ToursAndActivitiesApi.md#ToursBookingsPost) | **Post** /tours/bookings | Create Booking
[**ToursOfferAvailabilityOfferIdPost**](ToursAndActivitiesApi.md#ToursOfferAvailabilityOfferIdPost) | **Post** /tours/offer_availability/{offerId} | Get Offer Availability
[**ToursOffersOfferIdGet**](ToursAndActivitiesApi.md#ToursOffersOfferIdGet) | **Get** /tours/offers/{offerId} | Get Offer Details
[**ToursOffersSearchPost**](ToursAndActivitiesApi.md#ToursOffersSearchPost) | **Post** /tours/offers/search | Search Offers

# **ToursBookingsBookingIdCancelPost**
> ToursAndActivitiesCancelBookingResponseSchema ToursBookingsBookingIdCancelPost(ctx, body, bookingId)
Cancel Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**ToursAndActivitiesCancelBookingRequestSchema**](ToursAndActivitiesCancelBookingRequestSchema.md)|  | 
  **bookingId** | **string**|  | 

### Return type

[**ToursAndActivitiesCancelBookingResponseSchema**](ToursAndActivitiesCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ToursBookingsBookingIdGet**
> ToursAndActivitiesBookingDetailsResponseSchema ToursBookingsBookingIdGet(ctx, bookingId)
Get Booking Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **bookingId** | **string**|  | 

### Return type

[**ToursAndActivitiesBookingDetailsResponseSchema**](ToursAndActivitiesBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ToursBookingsPost**
> ToursAndActivitiesBookingResponseSchema ToursBookingsPost(ctx, body)
Create Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**ToursAndActivitiesCreateBookingRequestSchema**](ToursAndActivitiesCreateBookingRequestSchema.md)|  | 

### Return type

[**ToursAndActivitiesBookingResponseSchema**](ToursAndActivitiesBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ToursOfferAvailabilityOfferIdPost**
> ToursAndActivitiesGetOfferAvailabilityResponse ToursOfferAvailabilityOfferIdPost(ctx, body, offerId)
Get Offer Availability

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**ToursAndActivitiesGetOfferAvailabilityRequest**](ToursAndActivitiesGetOfferAvailabilityRequest.md)|  | 
  **offerId** | **string**|  | 

### Return type

[**ToursAndActivitiesGetOfferAvailabilityResponse**](ToursAndActivitiesGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ToursOffersOfferIdGet**
> ToursAndActivitiesOfferDetailsSchema ToursOffersOfferIdGet(ctx, offerId)
Get Offer Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **offerId** | **string**|  | 

### Return type

[**ToursAndActivitiesOfferDetailsSchema**](ToursAndActivitiesOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **ToursOffersSearchPost**
> ToursAndActivitiesOfferResponseSchema ToursOffersSearchPost(ctx, body)
Search Offers

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**ToursAndActivitiesOfferRequestSchema**](ToursAndActivitiesOfferRequestSchema.md)|  | 

### Return type

[**ToursAndActivitiesOfferResponseSchema**](ToursAndActivitiesOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

