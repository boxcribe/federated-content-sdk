# {{classname}}

All URIs are relative to *https://api.cms.boxcribe.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FlightsBookingsBookingIdCancelPost**](FlightsApi.md#FlightsBookingsBookingIdCancelPost) | **Post** /flights/bookings/{bookingId}/cancel | Cancel Booking
[**FlightsBookingsBookingIdGet**](FlightsApi.md#FlightsBookingsBookingIdGet) | **Get** /flights/bookings/{bookingId} | Get Booking Details
[**FlightsBookingsPost**](FlightsApi.md#FlightsBookingsPost) | **Post** /flights/bookings | Create Booking
[**FlightsOffersOfferIdGet**](FlightsApi.md#FlightsOffersOfferIdGet) | **Get** /flights/offers/{offerId} | Get Offer Details
[**FlightsOffersOfferIdSeatmapsGet**](FlightsApi.md#FlightsOffersOfferIdSeatmapsGet) | **Get** /flights/offers/{offerId}/seatmaps | Get Offer Seatmaps
[**FlightsOffersSearchPost**](FlightsApi.md#FlightsOffersSearchPost) | **Post** /flights/offers/search | Search Offers

# **FlightsBookingsBookingIdCancelPost**
> FlightCancelBookingResponseSchema FlightsBookingsBookingIdCancelPost(ctx, body)
Cancel Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**FlightCancelBookingRequestSchema**](FlightCancelBookingRequestSchema.md)|  | 

### Return type

[**FlightCancelBookingResponseSchema**](FlightCancelBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **FlightsBookingsBookingIdGet**
> FlightGetBookingDetailsResponseSchema FlightsBookingsBookingIdGet(ctx, body)
Get Booking Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**FlightBookingDetailsRequestSchema**](FlightBookingDetailsRequestSchema.md)|  | 

### Return type

[**FlightGetBookingDetailsResponseSchema**](FlightGetBookingDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **FlightsBookingsPost**
> FlightBookingResponseSchema FlightsBookingsPost(ctx, body)
Create Booking

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**FlightCreateBookingRequestSchema**](FlightCreateBookingRequestSchema.md)|  | 

### Return type

[**FlightBookingResponseSchema**](FlightBookingResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **FlightsOffersOfferIdGet**
> FlightOfferDetailsResponseSchema FlightsOffersOfferIdGet(ctx, body)
Get Offer Details

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**FlightOfferDetailsRequestSchema**](FlightOfferDetailsRequestSchema.md)|  | 

### Return type

[**FlightOfferDetailsResponseSchema**](FlightOfferDetailsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **FlightsOffersOfferIdSeatmapsGet**
> FlightOfferSeatmapsResponseSchema FlightsOffersOfferIdSeatmapsGet(ctx, body)
Get Offer Seatmaps

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**FlightOfferSeatmapsRequestSchema**](FlightOfferSeatmapsRequestSchema.md)|  | 

### Return type

[**FlightOfferSeatmapsResponseSchema**](FlightOfferSeatmapsResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

# **FlightsOffersSearchPost**
> FlightOfferResponseSchema FlightsOffersSearchPost(ctx, body)
Search Offers

### Required Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ctx** | **context.Context** | context for authentication, logging, cancellation, deadlines, tracing, etc.
  **body** | [**FlightOfferRequestSchema**](FlightOfferRequestSchema.md)|  | 

### Return type

[**FlightOfferResponseSchema**](FlightOfferResponseSchema.md)

### Authorization

[apiKeyAuth](../README.md#apiKeyAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

