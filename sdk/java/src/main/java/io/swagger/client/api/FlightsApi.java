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
import io.swagger.client.model.FlightBookingDetailsRequestSchema;
import io.swagger.client.model.FlightBookingResponseSchema;
import io.swagger.client.model.FlightCancelBookingRequestSchema;
import io.swagger.client.model.FlightCancelBookingResponseSchema;
import io.swagger.client.model.FlightCreateBookingRequestSchema;
import io.swagger.client.model.FlightGetBookingDetailsResponseSchema;
import io.swagger.client.model.FlightOfferDetailsRequestSchema;
import io.swagger.client.model.FlightOfferDetailsResponseSchema;
import io.swagger.client.model.FlightOfferRequestSchema;
import io.swagger.client.model.FlightOfferResponseSchema;
import io.swagger.client.model.FlightOfferSeatmapsRequestSchema;
import io.swagger.client.model.FlightOfferSeatmapsResponseSchema;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class FlightsApi {
    private ApiClient apiClient;

    public FlightsApi() {
        this(Configuration.getDefaultApiClient());
    }

    public FlightsApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for flightsBookingsBookingIdCancelPost
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call flightsBookingsBookingIdCancelPostCall(FlightCancelBookingRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/flights/bookings/{bookingId}/cancel";

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
    private com.squareup.okhttp.Call flightsBookingsBookingIdCancelPostValidateBeforeCall(FlightCancelBookingRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling flightsBookingsBookingIdCancelPost(Async)");
        }
        
        com.squareup.okhttp.Call call = flightsBookingsBookingIdCancelPostCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Cancel Booking
     * 
     * @param body  (required)
     * @return FlightCancelBookingResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public FlightCancelBookingResponseSchema flightsBookingsBookingIdCancelPost(FlightCancelBookingRequestSchema body) throws ApiException {
        ApiResponse<FlightCancelBookingResponseSchema> resp = flightsBookingsBookingIdCancelPostWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Cancel Booking
     * 
     * @param body  (required)
     * @return ApiResponse&lt;FlightCancelBookingResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<FlightCancelBookingResponseSchema> flightsBookingsBookingIdCancelPostWithHttpInfo(FlightCancelBookingRequestSchema body) throws ApiException {
        com.squareup.okhttp.Call call = flightsBookingsBookingIdCancelPostValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<FlightCancelBookingResponseSchema>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Cancel Booking (asynchronously)
     * 
     * @param body  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call flightsBookingsBookingIdCancelPostAsync(FlightCancelBookingRequestSchema body, final ApiCallback<FlightCancelBookingResponseSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = flightsBookingsBookingIdCancelPostValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<FlightCancelBookingResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for flightsBookingsBookingIdGet
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call flightsBookingsBookingIdGetCall(FlightBookingDetailsRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/flights/bookings/{bookingId}";

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
    private com.squareup.okhttp.Call flightsBookingsBookingIdGetValidateBeforeCall(FlightBookingDetailsRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling flightsBookingsBookingIdGet(Async)");
        }
        
        com.squareup.okhttp.Call call = flightsBookingsBookingIdGetCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get Booking Details
     * 
     * @param body  (required)
     * @return FlightGetBookingDetailsResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public FlightGetBookingDetailsResponseSchema flightsBookingsBookingIdGet(FlightBookingDetailsRequestSchema body) throws ApiException {
        ApiResponse<FlightGetBookingDetailsResponseSchema> resp = flightsBookingsBookingIdGetWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Get Booking Details
     * 
     * @param body  (required)
     * @return ApiResponse&lt;FlightGetBookingDetailsResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<FlightGetBookingDetailsResponseSchema> flightsBookingsBookingIdGetWithHttpInfo(FlightBookingDetailsRequestSchema body) throws ApiException {
        com.squareup.okhttp.Call call = flightsBookingsBookingIdGetValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<FlightGetBookingDetailsResponseSchema>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Get Booking Details (asynchronously)
     * 
     * @param body  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call flightsBookingsBookingIdGetAsync(FlightBookingDetailsRequestSchema body, final ApiCallback<FlightGetBookingDetailsResponseSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = flightsBookingsBookingIdGetValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<FlightGetBookingDetailsResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for flightsBookingsPost
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call flightsBookingsPostCall(FlightCreateBookingRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/flights/bookings";

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
    private com.squareup.okhttp.Call flightsBookingsPostValidateBeforeCall(FlightCreateBookingRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling flightsBookingsPost(Async)");
        }
        
        com.squareup.okhttp.Call call = flightsBookingsPostCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Create Booking
     * 
     * @param body  (required)
     * @return FlightBookingResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public FlightBookingResponseSchema flightsBookingsPost(FlightCreateBookingRequestSchema body) throws ApiException {
        ApiResponse<FlightBookingResponseSchema> resp = flightsBookingsPostWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Create Booking
     * 
     * @param body  (required)
     * @return ApiResponse&lt;FlightBookingResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<FlightBookingResponseSchema> flightsBookingsPostWithHttpInfo(FlightCreateBookingRequestSchema body) throws ApiException {
        com.squareup.okhttp.Call call = flightsBookingsPostValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<FlightBookingResponseSchema>(){}.getType();
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
    public com.squareup.okhttp.Call flightsBookingsPostAsync(FlightCreateBookingRequestSchema body, final ApiCallback<FlightBookingResponseSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = flightsBookingsPostValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<FlightBookingResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for flightsOffersOfferIdGet
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call flightsOffersOfferIdGetCall(FlightOfferDetailsRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/flights/offers/{offerId}";

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
    private com.squareup.okhttp.Call flightsOffersOfferIdGetValidateBeforeCall(FlightOfferDetailsRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling flightsOffersOfferIdGet(Async)");
        }
        
        com.squareup.okhttp.Call call = flightsOffersOfferIdGetCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get Offer Details
     * 
     * @param body  (required)
     * @return FlightOfferDetailsResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public FlightOfferDetailsResponseSchema flightsOffersOfferIdGet(FlightOfferDetailsRequestSchema body) throws ApiException {
        ApiResponse<FlightOfferDetailsResponseSchema> resp = flightsOffersOfferIdGetWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Get Offer Details
     * 
     * @param body  (required)
     * @return ApiResponse&lt;FlightOfferDetailsResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<FlightOfferDetailsResponseSchema> flightsOffersOfferIdGetWithHttpInfo(FlightOfferDetailsRequestSchema body) throws ApiException {
        com.squareup.okhttp.Call call = flightsOffersOfferIdGetValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<FlightOfferDetailsResponseSchema>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Get Offer Details (asynchronously)
     * 
     * @param body  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call flightsOffersOfferIdGetAsync(FlightOfferDetailsRequestSchema body, final ApiCallback<FlightOfferDetailsResponseSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = flightsOffersOfferIdGetValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<FlightOfferDetailsResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for flightsOffersOfferIdSeatmapsGet
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call flightsOffersOfferIdSeatmapsGetCall(FlightOfferSeatmapsRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/flights/offers/{offerId}/seatmaps";

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
    private com.squareup.okhttp.Call flightsOffersOfferIdSeatmapsGetValidateBeforeCall(FlightOfferSeatmapsRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling flightsOffersOfferIdSeatmapsGet(Async)");
        }
        
        com.squareup.okhttp.Call call = flightsOffersOfferIdSeatmapsGetCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get Offer Seatmaps
     * 
     * @param body  (required)
     * @return FlightOfferSeatmapsResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public FlightOfferSeatmapsResponseSchema flightsOffersOfferIdSeatmapsGet(FlightOfferSeatmapsRequestSchema body) throws ApiException {
        ApiResponse<FlightOfferSeatmapsResponseSchema> resp = flightsOffersOfferIdSeatmapsGetWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Get Offer Seatmaps
     * 
     * @param body  (required)
     * @return ApiResponse&lt;FlightOfferSeatmapsResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<FlightOfferSeatmapsResponseSchema> flightsOffersOfferIdSeatmapsGetWithHttpInfo(FlightOfferSeatmapsRequestSchema body) throws ApiException {
        com.squareup.okhttp.Call call = flightsOffersOfferIdSeatmapsGetValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<FlightOfferSeatmapsResponseSchema>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Get Offer Seatmaps (asynchronously)
     * 
     * @param body  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call flightsOffersOfferIdSeatmapsGetAsync(FlightOfferSeatmapsRequestSchema body, final ApiCallback<FlightOfferSeatmapsResponseSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = flightsOffersOfferIdSeatmapsGetValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<FlightOfferSeatmapsResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for flightsOffersSearchPost
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call flightsOffersSearchPostCall(FlightOfferRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/flights/offers/search";

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
    private com.squareup.okhttp.Call flightsOffersSearchPostValidateBeforeCall(FlightOfferRequestSchema body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling flightsOffersSearchPost(Async)");
        }
        
        com.squareup.okhttp.Call call = flightsOffersSearchPostCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Search Offers
     * 
     * @param body  (required)
     * @return FlightOfferResponseSchema
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public FlightOfferResponseSchema flightsOffersSearchPost(FlightOfferRequestSchema body) throws ApiException {
        ApiResponse<FlightOfferResponseSchema> resp = flightsOffersSearchPostWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Search Offers
     * 
     * @param body  (required)
     * @return ApiResponse&lt;FlightOfferResponseSchema&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<FlightOfferResponseSchema> flightsOffersSearchPostWithHttpInfo(FlightOfferRequestSchema body) throws ApiException {
        com.squareup.okhttp.Call call = flightsOffersSearchPostValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<FlightOfferResponseSchema>(){}.getType();
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
    public com.squareup.okhttp.Call flightsOffersSearchPostAsync(FlightOfferRequestSchema body, final ApiCallback<FlightOfferResponseSchema> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = flightsOffersSearchPostValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<FlightOfferResponseSchema>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}