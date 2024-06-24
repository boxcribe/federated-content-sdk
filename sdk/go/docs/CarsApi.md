# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CarsBookingsBookingIdCancelPost**](CarsApi.md#CarsBookingsBookingIdCancelPost) | **Post** /cars/bookings/{bookingId}/cancel | Cancel Booking
[**CarsBookingsBookingIdGet**](CarsApi.md#CarsBookingsBookingIdGet) | **Get** /cars/bookings/{bookingId} | Get Booking Details
[**CarsBookingsPost**](CarsApi.md#CarsBookingsPost) | **Post** /cars/bookings | Create Booking
[**CarsOfferAvailabilityOfferIdGet**](CarsApi.md#CarsOfferAvailabilityOfferIdGet) | **Get** /cars/offer_availability/{offerId} | Get Offer Availability
[**CarsOffersOfferIdGet**](CarsApi.md#CarsOffersOfferIdGet) | **Get** /cars/offers/{offerId} | Get Offer Details
[**CarsOffersSearchPost**](CarsApi.md#CarsOffersSearchPost) | **Post** /cars/offers/search | Search Offers

# **CarsBookingsBookingIdCancelPost**
> CarCancelBookingResponseSchema CarsBookingsBookingIdCancelPost(ctx, body, bookingId)
Cancel Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**CarCancelBookingRequestSchema**](CarCancelBookingRequestSchema.md)|  | 
  **bookingId** | **string**|  | 

### Return type

[**CarCancelBookingResponseSchema**](CarCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **CarsBookingsBookingIdGet**
> CarBookingDetailsResponseSchema CarsBookingsBookingIdGet(ctx, bookingId)
Get Booking Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **bookingId** | **string**|  | 

### Return type

[**CarBookingDetailsResponseSchema**](CarBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **CarsBookingsPost**
> CarBookingResponseSchema CarsBookingsPost(ctx, body)
Create Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**CarCreateBookingRequestSchema**](CarCreateBookingRequestSchema.md)|  | 

### Return type

[**CarBookingResponseSchema**](CarBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **CarsOfferAvailabilityOfferIdGet**
> CarGetOfferAvailabilityResponse CarsOfferAvailabilityOfferIdGet(ctx, body, offerId)
Get Offer Availability

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**CarGetOfferAvailabilityRequest**](CarGetOfferAvailabilityRequest.md)|  | 
  **offerId** | **string**|  | 

### Return type

[**CarGetOfferAvailabilityResponse**](CarGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **CarsOffersOfferIdGet**
> CarOfferDetailsSchema CarsOffersOfferIdGet(ctx, offerId)
Get Offer Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **offerId** | **string**|  | 

### Return type

[**CarOfferDetailsSchema**](CarOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **CarsOffersSearchPost**
> CarOfferResponseSchema CarsOffersSearchPost(ctx, body)
Search Offers

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**CarOfferRequestSchema**](CarOfferRequestSchema.md)|  | 

### Return type

[**CarOfferResponseSchema**](CarOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

