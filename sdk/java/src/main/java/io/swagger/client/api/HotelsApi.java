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
import io.swagger.client.model.HotelBookingDetailsResponseSchema;
import io.swagger.client.model.HotelBookingResponseSchema;
import io.swagger.client.model.HotelCancelBookingRequestSchema;
import io.swagger.client.model.HotelCancelBookingResponseSchema;
import io.swagger.client.model.HotelCreateBookingRequestSchema;
import io.swagger.client.model.HotelGetOfferAvailabilityRequest;
import io.swagger.client.model.HotelGetOfferAvailabilityResponse;
import io.swagger.client.model.HotelOfferDetailsSchema;
import io.swagger.client.model.HotelOfferRequestSchema;
import io.swagger.client.model.HotelOfferResponseSchema;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class HotelsApi {
    private ApiClient apiClient;

    public HotelsApi() {
        this(Configuration.getDefaultApiClient());
    }

    public HotelsApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for hotelsBookingsBookingIdCancelPost
     * @param body  (required)
     * @param bookingId  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call hotelsBookingsBookingIdCancelPostCall(HotelCancelBookingRequestSchema body, String bookingId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/hotels/bookings/{bookingId}/cancel"
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
    private com.squareup.okhttp.Call hotelsBookingsBookingIdCancelPostValidateBeforeCall(HotelCancelBookingRequestSchema body, String bookingId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling hotelsBookingsBookingIdCancelPost(Async)");
        }
        // verify the required parameter 'bookingId' is set
        if (bookingId == null) {
            throw new ApiException("Missing the required parameter 'bookingId' when calling hotelsBookingsBookingIdCancelPost(Async)");
        }
        
        com.squareup.okhttp.Call call = hotelsBookingsBookingIdCancelPostCall(body, bookingId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Cancel Booking
     * 
     * @param body  (required)
     * @param bookingId  (required)
     * @return HotelCancelBookingResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public HotelCancelBookingResponseSchema hotelsBookingsBookingIdCancelPost(HotelCancelBookingRequestSchema body, String bookingId) throws ApiException {
        ApiResponse<HotelCancelBookingResponseSchema> resp = hotelsBookingsBookingIdCancelPostWithHttpInfo(body, bookingId);
        return resp.getData();
    }

    /**
     * Cancel Booking
     * 
     * @param body  (required)
     * @param bookingId  (required)
     * @return ApiResponse&lt;HotelCancelBookingResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<HotelCancelBookingResponseSchema> hotelsBookingsBookingIdCancelPostWithHttpInfo(HotelCancelBookingRequestSchema body, String bookingId) throws ApiException {
        com.squareup.okhttp.Call call = hotelsBookingsBookingIdCancelPostValidateBeforeCall(body, bookingId, null, null);
        Type localVarReturnType = new TypeToken<HotelCancelBookingResponseSchema>(){}.getType();
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
    public com.squareup.okhttp.Call hotelsBookingsBookingIdCancelPostAsync(HotelCancelBookingRequestSchema body, String bookingId, final ApiCallback<HotelCancelBookingResponseSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = hotelsBookingsBookingIdCancelPostValidateBeforeCall(body, bookingId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<HotelCancelBookingResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for hotelsBookingsBookingIdGet
     * @param bookingId  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call hotelsBookingsBookingIdGetCall(String bookingId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/hotels/bookings/{bookingId}"
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
    private com.squareup.okhttp.Call hotelsBookingsBookingIdGetValidateBeforeCall(String bookingId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'bookingId' is set
        if (bookingId == null) {
            throw new ApiException("Missing the required parameter 'bookingId' when calling hotelsBookingsBookingIdGet(Async)");
        }
        
        com.squareup.okhttp.Call call = hotelsBookingsBookingIdGetCall(bookingId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get Booking Details
     * 
     * @param bookingId  (required)
     * @return HotelBookingDetailsResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public HotelBookingDetailsResponseSchema hotelsBookingsBookingIdGet(String bookingId) throws ApiException {
        ApiResponse<HotelBookingDetailsResponseSchema> resp = hotelsBookingsBookingIdGetWithHttpInfo(bookingId);
        return resp.getData();
    }

    /**
     * Get Booking Details
     * 
     * @param bookingId  (required)
     * @return ApiResponse&lt;HotelBookingDetailsResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<HotelBookingDetailsResponseSchema> hotelsBookingsBookingIdGetWithHttpInfo(String bookingId) throws ApiException {
        com.squareup.okhttp.Call call = hotelsBookingsBookingIdGetValidateBeforeCall(bookingId, null, null);
        Type localVarReturnType = new TypeToken<HotelBookingDetailsResponseSchema>(){}.getType();
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
    public com.squareup.okhttp.Call hotelsBookingsBookingIdGetAsync(String bookingId, final ApiCallback<HotelBookingDetailsResponseSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = hotelsBookingsBookingIdGetValidateBeforeCall(bookingId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<HotelBookingDetailsResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for hotelsBookingsPost
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call hotelsBookingsPostCall(HotelCreateBookingRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/hotels/bookings";

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
    private com.squareup.okhttp.Call hotelsBookingsPostValidateBeforeCall(HotelCreateBookingRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling hotelsBookingsPost(Async)");
        }
        
        com.squareup.okhttp.Call call = hotelsBookingsPostCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Create Booking
     * 
     * @param body  (required)
     * @return HotelBookingResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public HotelBookingResponseSchema hotelsBookingsPost(HotelCreateBookingRequestSchema body) throws ApiException {
        ApiResponse<HotelBookingResponseSchema> resp = hotelsBookingsPostWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Create Booking
     * 
     * @param body  (required)
     * @return ApiResponse&lt;HotelBookingResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<HotelBookingResponseSchema> hotelsBookingsPostWithHttpInfo(HotelCreateBookingRequestSchema body) throws ApiException {
        com.squareup.okhttp.Call call = hotelsBookingsPostValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<HotelBookingResponseSchema>(){}.getType();
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
    public com.squareup.okhttp.Call hotelsBookingsPostAsync(HotelCreateBookingRequestSchema body, final ApiCallback<HotelBookingResponseSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = hotelsBookingsPostValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<HotelBookingResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for hotelsOfferAvailabilityOfferIdGet
     * @param body  (required)
     * @param offerId  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call hotelsOfferAvailabilityOfferIdGetCall(HotelGetOfferAvailabilityRequest body, String offerId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/hotels/offer_availability/{offerId}"
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
    private com.squareup.okhttp.Call hotelsOfferAvailabilityOfferIdGetValidateBeforeCall(HotelGetOfferAvailabilityRequest body, String offerId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling hotelsOfferAvailabilityOfferIdGet(Async)");
        }
        // verify the required parameter 'offerId' is set
        if (offerId == null) {
            throw new ApiException("Missing the required parameter 'offerId' when calling hotelsOfferAvailabilityOfferIdGet(Async)");
        }
        
        com.squareup.okhttp.Call call = hotelsOfferAvailabilityOfferIdGetCall(body, offerId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get Offer Availability
     * 
     * @param body  (required)
     * @param offerId  (required)
     * @return HotelGetOfferAvailabilityResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public HotelGetOfferAvailabilityResponse hotelsOfferAvailabilityOfferIdGet(HotelGetOfferAvailabilityRequest body, String offerId) throws ApiException {
        ApiResponse<HotelGetOfferAvailabilityResponse> resp = hotelsOfferAvailabilityOfferIdGetWithHttpInfo(body, offerId);
        return resp.getData();
    }

    /**
     * Get Offer Availability
     * 
     * @param body  (required)
     * @param offerId  (required)
     * @return ApiResponse&lt;HotelGetOfferAvailabilityResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<HotelGetOfferAvailabilityResponse> hotelsOfferAvailabilityOfferIdGetWithHttpInfo(HotelGetOfferAvailabilityRequest body, String offerId) throws ApiException {
        com.squareup.okhttp.Call call = hotelsOfferAvailabilityOfferIdGetValidateBeforeCall(body, offerId, null, null);
        Type localVarReturnType = new TypeToken<HotelGetOfferAvailabilityResponse>(){}.getType();
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
    public com.squareup.okhttp.Call hotelsOfferAvailabilityOfferIdGetAsync(HotelGetOfferAvailabilityRequest body, String offerId, final ApiCallback<HotelGetOfferAvailabilityResponse> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = hotelsOfferAvailabilityOfferIdGetValidateBeforeCall(body, offerId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<HotelGetOfferAvailabilityResponse>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for hotelsOffersOfferIdGet
     * @param offerId  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call hotelsOffersOfferIdGetCall(String offerId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/hotels/offers/{offerId}"
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
    private com.squareup.okhttp.Call hotelsOffersOfferIdGetValidateBeforeCall(String offerId, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'offerId' is set
        if (offerId == null) {
            throw new ApiException("Missing the required parameter 'offerId' when calling hotelsOffersOfferIdGet(Async)");
        }
        
        com.squareup.okhttp.Call call = hotelsOffersOfferIdGetCall(offerId, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get Offer Details
     * 
     * @param offerId  (required)
     * @return HotelOfferDetailsSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public HotelOfferDetailsSchema hotelsOffersOfferIdGet(String offerId) throws ApiException {
        ApiResponse<HotelOfferDetailsSchema> resp = hotelsOffersOfferIdGetWithHttpInfo(offerId);
        return resp.getData();
    }

    /**
     * Get Offer Details
     * 
     * @param offerId  (required)
     * @return ApiResponse&lt;HotelOfferDetailsSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<HotelOfferDetailsSchema> hotelsOffersOfferIdGetWithHttpInfo(String offerId) throws ApiException {
        com.squareup.okhttp.Call call = hotelsOffersOfferIdGetValidateBeforeCall(offerId, null, null);
        Type localVarReturnType = new TypeToken<HotelOfferDetailsSchema>(){}.getType();
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
    public com.squareup.okhttp.Call hotelsOffersOfferIdGetAsync(String offerId, final ApiCallback<HotelOfferDetailsSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = hotelsOffersOfferIdGetValidateBeforeCall(offerId, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<HotelOfferDetailsSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for hotelsOffersSearchPost
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call hotelsOffersSearchPostCall(HotelOfferRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/hotels/offers/search";

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
    private com.squareup.okhttp.Call hotelsOffersSearchPostValidateBeforeCall(HotelOfferRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling hotelsOffersSearchPost(Async)");
        }
        
        com.squareup.okhttp.Call call = hotelsOffersSearchPostCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Search Offers
     * 
     * @param body  (required)
     * @return HotelOfferResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public HotelOfferResponseSchema hotelsOffersSearchPost(HotelOfferRequestSchema body) throws ApiException {
        ApiResponse<HotelOfferResponseSchema> resp = hotelsOffersSearchPostWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Search Offers
     * 
     * @param body  (required)
     * @return ApiResponse&lt;HotelOfferResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<HotelOfferResponseSchema> hotelsOffersSearchPostWithHttpInfo(HotelOfferRequestSchema body) throws ApiException {
        com.squareup.okhttp.Call call = hotelsOffersSearchPostValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<HotelOfferResponseSchema>(){}.getType();
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
    public com.squareup.okhttp.Call hotelsOffersSearchPostAsync(HotelOfferRequestSchema body, final ApiCallback<HotelOfferResponseSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = hotelsOffersSearchPostValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<HotelOfferResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}
