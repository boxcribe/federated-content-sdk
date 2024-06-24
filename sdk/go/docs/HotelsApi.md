# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**HotelsBookingsBookingIdCancelPost**](HotelsApi.md#HotelsBookingsBookingIdCancelPost) | **Post** /hotels/bookings/{bookingId}/cancel | Cancel Booking
[**HotelsBookingsBookingIdGet**](HotelsApi.md#HotelsBookingsBookingIdGet) | **Get** /hotels/bookings/{bookingId} | Get Booking Details
[**HotelsBookingsPost**](HotelsApi.md#HotelsBookingsPost) | **Post** /hotels/bookings | Create Booking
[**HotelsOfferAvailabilityOfferIdGet**](HotelsApi.md#HotelsOfferAvailabilityOfferIdGet) | **Get** /hotels/offer_availability/{offerId} | Get Offer Availability
[**HotelsOffersOfferIdGet**](HotelsApi.md#HotelsOffersOfferIdGet) | **Get** /hotels/offers/{offerId} | Get Offer Details
[**HotelsOffersSearchPost**](HotelsApi.md#HotelsOffersSearchPost) | **Post** /hotels/offers/search | Search Offers

# **HotelsBookingsBookingIdCancelPost**
> HotelCancelBookingResponseSchema HotelsBookingsBookingIdCancelPost(ctx, body, bookingId)
Cancel Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**HotelCancelBookingRequestSchema**](HotelCancelBookingRequestSchema.md)|  | 
  **bookingId** | **string**|  | 

### Return type

[**HotelCancelBookingResponseSchema**](HotelCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **HotelsBookingsBookingIdGet**
> HotelBookingDetailsResponseSchema HotelsBookingsBookingIdGet(ctx, bookingId)
Get Booking Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **bookingId** | **string**|  | 

### Return type

[**HotelBookingDetailsResponseSchema**](HotelBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **HotelsBookingsPost**
> HotelBookingResponseSchema HotelsBookingsPost(ctx, body)
Create Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**HotelCreateBookingRequestSchema**](HotelCreateBookingRequestSchema.md)|  | 

### Return type

[**HotelBookingResponseSchema**](HotelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **HotelsOfferAvailabilityOfferIdGet**
> HotelGetOfferAvailabilityResponse HotelsOfferAvailabilityOfferIdGet(ctx, body, offerId)
Get Offer Availability

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**HotelGetOfferAvailabilityRequest**](HotelGetOfferAvailabilityRequest.md)|  | 
  **offerId** | **string**|  | 

### Return type

[**HotelGetOfferAvailabilityResponse**](HotelGetOfferAvailabilityResponse.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **HotelsOffersOfferIdGet**
> HotelOfferDetailsSchema HotelsOffersOfferIdGet(ctx, offerId)
Get Offer Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **offerId** | **string**|  | 

### Return type

[**HotelOfferDetailsSchema**](HotelOfferDetailsSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **HotelsOffersSearchPost**
> HotelOfferResponseSchema HotelsOffersSearchPost(ctx, body)
Search Offers

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**HotelOfferRequestSchema**](HotelOfferRequestSchema.md)|  | 

### Return type

[**HotelOfferResponseSchema**](HotelOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

