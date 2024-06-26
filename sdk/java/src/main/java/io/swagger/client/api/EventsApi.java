/*
 * Federated Content API
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.api;

import io.swagger.client.ApiCallback;
import io.swagger.client.ApiClient;
import io.swagger.client.ApiException;
import io.swagger.client.ApiResponse;
import io.swagger.client.Configuration;
import io.swagger.client.Pair;
import io.swagger.client.ProgressRequestBody;
import io.swagger.client.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import io.swagger.client.model.Error;
import io.swagger.client.model.EventBookingDetailsResponseSchema;
import io.swagger.client.model.EventBookingResponseSchema;
import io.swagger.client.model.EventCancelBookingRequestSchema;
import io.swagger.client.model.EventCancelBookingResponseSchema;
import io.swagger.client.model.EventCreateBookingRequestSchema;
import io.swagger.client.model.EventGetOfferAvailabilityRequest;
import io.swagger.client.model.EventGetOfferAvailabilityResponse;
import io.swagger.client.model.EventOfferDetailsSchema;
import io.swagger.client.model.EventOfferRequestSchema;
import io.swagger.client.model.EventOfferResponseSchema;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class EventsApi {
    private ApiClient apiClient;

    public EventsApi() {
        this(Configuration.getDefaultApiClient());
    }

    public EventsApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for eventsBookingsBookingIdCancelPost
     * @param body  (required)
     * @param bookingId  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call eventsBookingsBookingIdCancelPostCall(EventCancelBookingRequestSchema body, String bookingId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/events/bookings/{bookingId}/cancel"
            .replaceAll("\\{" + "bookingId" + "\\}", apiClient.escapeString(bookingId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "apiKeyAuth" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call eventsBookingsBookingIdCancelPostValidateBeforeCall(EventCancelBookingRequestSchema body, String bookingId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling eventsBookingsBookingIdCancelPost(Async)");
        }
        // verify the required parameter 'bookingId' is set
        if (bookingId == null) {
            throw new ApiException("Missing the required parameter 'bookingId' when calling eventsBookingsBookingIdCancelPost(Async)");
        }
        
        com.squareup.okhttp.Call call = eventsBookingsBookingIdCancelPostCall(body, bookingId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Cancel Booking
     * 
     * @param body  (required)
     * @param bookingId  (required)
     * @return EventCancelBookingResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public EventCancelBookingResponseSchema eventsBookingsBookingIdCancelPost(EventCancelBookingRequestSchema body, String bookingId) throws ApiException {
        ApiResponse<EventCancelBookingResponseSchema> resp = eventsBookingsBookingIdCancelPostWithHttpInfo(body, bookingId);
        return resp.getData();
    }

    /**
     * Cancel Booking
     * 
     * @param body  (required)
     * @param bookingId  (required)
     * @return ApiResponse&lt;EventCancelBookingResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<EventCancelBookingResponseSchema> eventsBookingsBookingIdCancelPostWithHttpInfo(EventCancelBookingRequestSchema body, String bookingId) throws ApiException {
        com.squareup.okhttp.Call call = eventsBookingsBookingIdCancelPostValidateBeforeCall(body, bookingId, null, null);
        Type localVarReturnType = new TypeToken<EventCancelBookingResponseSchema>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Cancel Booking (asynchronously)
     * 
     * @param body  (required)
     * @param bookingId  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call eventsBookingsBookingIdCancelPostAsync(EventCancelBookingRequestSchema body, String bookingId, final ApiCallback<EventCancelBookingResponseSchema> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = eventsBookingsBookingIdCancelPostValidateBeforeCall(body, bookingId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<EventCancelBookingResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for eventsBookingsBookingIdGet
     * @param bookingId  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call eventsBookingsBookingIdGetCall(String bookingId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/events/bookings/{bookingId}"
            .replaceAll("\\{" + "bookingId" + "\\}", apiClient.escapeString(bookingId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "apiKeyAuth" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call eventsBookingsBookingIdGetValidateBeforeCall(String bookingId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'bookingId' is set
        if (bookingId == null) {
            throw new ApiException("Missing the required parameter 'bookingId' when calling eventsBookingsBookingIdGet(Async)");
        }
        
        com.squareup.okhttp.Call call = eventsBookingsBookingIdGetCall(bookingId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get Booking Details
     * 
     * @param bookingId  (required)
     * @return EventBookingDetailsResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public EventBookingDetailsResponseSchema eventsBookingsBookingIdGet(String bookingId) throws ApiException {
        ApiResponse<EventBookingDetailsResponseSchema> resp = eventsBookingsBookingIdGetWithHttpInfo(bookingId);
        return resp.getData();
    }

    /**
     * Get Booking Details
     * 
     * @param bookingId  (required)
     * @return ApiResponse&lt;EventBookingDetailsResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<EventBookingDetailsResponseSchema> eventsBookingsBookingIdGetWithHttpInfo(String bookingId) throws ApiException {
        com.squareup.okhttp.Call call = eventsBookingsBookingIdGetValidateBeforeCall(bookingId, null, null);
        Type localVarReturnType = new TypeToken<EventBookingDetailsResponseSchema>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Get Booking Details (asynchronously)
     * 
     * @param bookingId  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call eventsBookingsBookingIdGetAsync(String bookingId, final ApiCallback<EventBookingDetailsResponseSchema> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = eventsBookingsBookingIdGetValidateBeforeCall(bookingId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<EventBookingDetailsResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for eventsBookingsPost
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call eventsBookingsPostCall(EventCreateBookingRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/events/bookings";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "apiKeyAuth" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call eventsBookingsPostValidateBeforeCall(EventCreateBookingRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling eventsBookingsPost(Async)");
        }
        
        com.squareup.okhttp.Call call = eventsBookingsPostCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Create Booking
     * 
     * @param body  (required)
     * @return EventBookingResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public EventBookingResponseSchema eventsBookingsPost(EventCreateBookingRequestSchema body) throws ApiException {
        ApiResponse<EventBookingResponseSchema> resp = eventsBookingsPostWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Create Booking
     * 
     * @param body  (required)
     * @return ApiResponse&lt;EventBookingResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<EventBookingResponseSchema> eventsBookingsPostWithHttpInfo(EventCreateBookingRequestSchema body) throws ApiException {
        com.squareup.okhttp.Call call = eventsBookingsPostValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<EventBookingResponseSchema>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Create Booking (asynchronously)
     * 
     * @param body  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call eventsBookingsPostAsync(EventCreateBookingRequestSchema body, final ApiCallback<EventBookingResponseSchema> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = eventsBookingsPostValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<EventBookingResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for eventsOfferAvailabilityOfferIdGet
     * @param body  (required)
     * @param offerId  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call eventsOfferAvailabilityOfferIdGetCall(EventGetOfferAvailabilityRequest body, String offerId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/events/offer_availability/{offerId}"
            .replaceAll("\\{" + "offerId" + "\\}", apiClient.escapeString(offerId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "apiKeyAuth" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call eventsOfferAvailabilityOfferIdGetValidateBeforeCall(EventGetOfferAvailabilityRequest body, String offerId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling eventsOfferAvailabilityOfferIdGet(Async)");
        }
        // verify the required parameter 'offerId' is set
        if (offerId == null) {
            throw new ApiException("Missing the required parameter 'offerId' when calling eventsOfferAvailabilityOfferIdGet(Async)");
        }
        
        com.squareup.okhttp.Call call = eventsOfferAvailabilityOfferIdGetCall(body, offerId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get Offer Availability
     * 
     * @param body  (required)
     * @param offerId  (required)
     * @return EventGetOfferAvailabilityResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public EventGetOfferAvailabilityResponse eventsOfferAvailabilityOfferIdGet(EventGetOfferAvailabilityRequest body, String offerId) throws ApiException {
        ApiResponse<EventGetOfferAvailabilityResponse> resp = eventsOfferAvailabilityOfferIdGetWithHttpInfo(body, offerId);
        return resp.getData();
    }

    /**
     * Get Offer Availability
     * 
     * @param body  (required)
     * @param offerId  (required)
     * @return ApiResponse&lt;EventGetOfferAvailabilityResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<EventGetOfferAvailabilityResponse> eventsOfferAvailabilityOfferIdGetWithHttpInfo(EventGetOfferAvailabilityRequest body, String offerId) throws ApiException {
        com.squareup.okhttp.Call call = eventsOfferAvailabilityOfferIdGetValidateBeforeCall(body, offerId, null, null);
        Type localVarReturnType = new TypeToken<EventGetOfferAvailabilityResponse>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Get Offer Availability (asynchronously)
     * 
     * @param body  (required)
     * @param offerId  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call eventsOfferAvailabilityOfferIdGetAsync(EventGetOfferAvailabilityRequest body, String offerId, final ApiCallback<EventGetOfferAvailabilityResponse> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = eventsOfferAvailabilityOfferIdGetValidateBeforeCall(body, offerId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<EventGetOfferAvailabilityResponse>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for eventsOffersOfferIdGet
     * @param offerId  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call eventsOffersOfferIdGetCall(String offerId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/events/offers/{offerId}"
            .replaceAll("\\{" + "offerId" + "\\}", apiClient.escapeString(offerId.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "apiKeyAuth" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call eventsOffersOfferIdGetValidateBeforeCall(String offerId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'offerId' is set
        if (offerId == null) {
            throw new ApiException("Missing the required parameter 'offerId' when calling eventsOffersOfferIdGet(Async)");
        }
        
        com.squareup.okhttp.Call call = eventsOffersOfferIdGetCall(offerId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get Offer Details
     * 
     * @param offerId  (required)
     * @return EventOfferDetailsSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public EventOfferDetailsSchema eventsOffersOfferIdGet(String offerId) throws ApiException {
        ApiResponse<EventOfferDetailsSchema> resp = eventsOffersOfferIdGetWithHttpInfo(offerId);
        return resp.getData();
    }

    /**
     * Get Offer Details
     * 
     * @param offerId  (required)
     * @return ApiResponse&lt;EventOfferDetailsSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<EventOfferDetailsSchema> eventsOffersOfferIdGetWithHttpInfo(String offerId) throws ApiException {
        com.squareup.okhttp.Call call = eventsOffersOfferIdGetValidateBeforeCall(offerId, null, null);
        Type localVarReturnType = new TypeToken<EventOfferDetailsSchema>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Get Offer Details (asynchronously)
     * 
     * @param offerId  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call eventsOffersOfferIdGetAsync(String offerId, final ApiCallback<EventOfferDetailsSchema> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = eventsOffersOfferIdGetValidateBeforeCall(offerId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<EventOfferDetailsSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for eventsOffersSearchPost
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call eventsOffersSearchPostCall(EventOfferRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/events/offers/search";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "apiKeyAuth" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call eventsOffersSearchPostValidateBeforeCall(EventOfferRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling eventsOffersSearchPost(Async)");
        }
        
        com.squareup.okhttp.Call call = eventsOffersSearchPostCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Search Offers
     * 
     * @param body  (required)
     * @return EventOfferResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public EventOfferResponseSchema eventsOffersSearchPost(EventOfferRequestSchema body) throws ApiException {
        ApiResponse<EventOfferResponseSchema> resp = eventsOffersSearchPostWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Search Offers
     * 
     * @param body  (required)
     * @return ApiResponse&lt;EventOfferResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<EventOfferResponseSchema> eventsOffersSearchPostWithHttpInfo(EventOfferRequestSchema body) throws ApiException {
        com.squareup.okhttp.Call call = eventsOffersSearchPostValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<EventOfferResponseSchema>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Search Offers (asynchronously)
     * 
     * @param body  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call eventsOffersSearchPostAsync(EventOfferRequestSchema body, final ApiCallback<EventOfferResponseSchema> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = eventsOffersSearchPostValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<EventOfferResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}
