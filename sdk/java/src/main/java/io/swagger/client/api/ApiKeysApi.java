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


import io.swagger.client.model.ApiKey;
import io.swagger.client.model.ApikeysBody;
import io.swagger.client.model.ApikeysIdBody;
import io.swagger.client.model.Error;
import io.swagger.client.model.InlineResponse2002;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class ApiKeysApi {
    private ApiClient apiClient;

    public ApiKeysApi() {
        this(Configuration.getDefaultApiClient());
    }

    public ApiKeysApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for apikeysGet
     * @param tenant Get all schemas for a Tenant ID (optional)
     * @param environment Get all schemas for an Environment (Sandbox or Production) (optional)
     * @param sort sort by query in the form of field:desc/asc (ex. name:asc) (optional)
     * @param limit Maximum number of apiKeys (optional)
     * @param page Page number (optional, default to 1)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call apikeysGetCall(String tenant, String environment, String sort, Integer limit, Integer page, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/apikeys";

        List<Pair> localVarQueryParams = new ArrayList<Pair>();
        List<Pair> localVarCollectionQueryParams = new ArrayList<Pair>();
        if (tenant != null)
        localVarQueryParams.addAll(apiClient.parameterToPair("tenant", tenant));
        if (environment != null)
        localVarQueryParams.addAll(apiClient.parameterToPair("environment", environment));
        if (sort != null)
        localVarQueryParams.addAll(apiClient.parameterToPair("sort", sort));
        if (limit != null)
        localVarQueryParams.addAll(apiClient.parameterToPair("limit", limit));
        if (page != null)
        localVarQueryParams.addAll(apiClient.parameterToPair("page", page));

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

        String[] localVarAuthNames = new String[] { "bearerAuth" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call apikeysGetValidateBeforeCall(String tenant, String environment, String sort, Integer limit, Integer page, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        com.squareup.okhttp.Call call = apikeysGetCall(tenant, environment, sort, limit, page, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get api keys
     * Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.
     * @param tenant Get all schemas for a Tenant ID (optional)
     * @param environment Get all schemas for an Environment (Sandbox or Production) (optional)
     * @param sort sort by query in the form of field:desc/asc (ex. name:asc) (optional)
     * @param limit Maximum number of apiKeys (optional)
     * @param page Page number (optional, default to 1)
     * @return InlineResponse2002
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public InlineResponse2002 apikeysGet(String tenant, String environment, String sort, Integer limit, Integer page) throws ApiException {
        ApiResponse<InlineResponse2002> resp = apikeysGetWithHttpInfo(tenant, environment, sort, limit, page);
        return resp.getData();
    }

    /**
     * Get api keys
     * Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.
     * @param tenant Get all schemas for a Tenant ID (optional)
     * @param environment Get all schemas for an Environment (Sandbox or Production) (optional)
     * @param sort sort by query in the form of field:desc/asc (ex. name:asc) (optional)
     * @param limit Maximum number of apiKeys (optional)
     * @param page Page number (optional, default to 1)
     * @return ApiResponse&lt;InlineResponse2002&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<InlineResponse2002> apikeysGetWithHttpInfo(String tenant, String environment, String sort, Integer limit, Integer page) throws ApiException {
        com.squareup.okhttp.Call call = apikeysGetValidateBeforeCall(tenant, environment, sort, limit, page, null, null);
        Type localVarReturnType = new TypeToken<InlineResponse2002>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Get api keys (asynchronously)
     * Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.
     * @param tenant Get all schemas for a Tenant ID (optional)
     * @param environment Get all schemas for an Environment (Sandbox or Production) (optional)
     * @param sort sort by query in the form of field:desc/asc (ex. name:asc) (optional)
     * @param limit Maximum number of apiKeys (optional)
     * @param page Page number (optional, default to 1)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call apikeysGetAsync(String tenant, String environment, String sort, Integer limit, Integer page, final ApiCallback<InlineResponse2002> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = apikeysGetValidateBeforeCall(tenant, environment, sort, limit, page, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<InlineResponse2002>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for apikeysIdDelete
     * @param id Api Key ID (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call apikeysIdDeleteCall(String id, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/apikeys/{id}"
            .replaceAll("\\{" + "id" + "\\}", apiClient.escapeString(id.toString()));

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

        String[] localVarAuthNames = new String[] { "bearerAuth" };
        return apiClient.buildCall(localVarPath, "DELETE", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call apikeysIdDeleteValidateBeforeCall(String id, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'id' is set
        if (id == null) {
            throw new ApiException("Missing the required parameter 'id' when calling apikeysIdDelete(Async)");
        }
        
        com.squareup.okhttp.Call call = apikeysIdDeleteCall(id, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Delete api key
     * 
     * @param id Api Key ID (required)
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public void apikeysIdDelete(String id) throws ApiException {
        apikeysIdDeleteWithHttpInfo(id);
    }

    /**
     * Delete api key
     * 
     * @param id Api Key ID (required)
     * @return ApiResponse&lt;Void&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<Void> apikeysIdDeleteWithHttpInfo(String id) throws ApiException {
        com.squareup.okhttp.Call call = apikeysIdDeleteValidateBeforeCall(id, null, null);
        return apiClient.execute(call);
    }

    /**
     * Delete api key (asynchronously)
     * 
     * @param id Api Key ID (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call apikeysIdDeleteAsync(String id, final ApiCallback<Void> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = apikeysIdDeleteValidateBeforeCall(id, progressListener, progressRequestListener);
        apiClient.executeAsync(call, callback);
        return call;
    }
    /**
     * Build call for apikeysIdGet
     * @param id Api Key ID (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call apikeysIdGetCall(String id, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/apikeys/{id}"
            .replaceAll("\\{" + "id" + "\\}", apiClient.escapeString(id.toString()));

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

        String[] localVarAuthNames = new String[] { "bearerAuth" };
        return apiClient.buildCall(localVarPath, "GET", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call apikeysIdGetValidateBeforeCall(String id, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'id' is set
        if (id == null) {
            throw new ApiException("Missing the required parameter 'id' when calling apikeysIdGet(Async)");
        }
        
        com.squareup.okhttp.Call call = apikeysIdGetCall(id, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Get api key
     * 
     * @param id Api Key ID (required)
     * @return ApiKey
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiKey apikeysIdGet(String id) throws ApiException {
        ApiResponse<ApiKey> resp = apikeysIdGetWithHttpInfo(id);
        return resp.getData();
    }

    /**
     * Get api key
     * 
     * @param id Api Key ID (required)
     * @return ApiResponse&lt;ApiKey&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<ApiKey> apikeysIdGetWithHttpInfo(String id) throws ApiException {
        com.squareup.okhttp.Call call = apikeysIdGetValidateBeforeCall(id, null, null);
        Type localVarReturnType = new TypeToken<ApiKey>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Get api key (asynchronously)
     * 
     * @param id Api Key ID (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call apikeysIdGetAsync(String id, final ApiCallback<ApiKey> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = apikeysIdGetValidateBeforeCall(id, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<ApiKey>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for apikeysIdPatch
     * @param body  (required)
     * @param id Api Key ID (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call apikeysIdPatchCall(ApikeysIdBody body, String id, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/apikeys/{id}"
            .replaceAll("\\{" + "id" + "\\}", apiClient.escapeString(id.toString()));

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

        String[] localVarAuthNames = new String[] { "bearerAuth" };
        return apiClient.buildCall(localVarPath, "PATCH", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call apikeysIdPatchValidateBeforeCall(ApikeysIdBody body, String id, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling apikeysIdPatch(Async)");
        }
        // verify the required parameter 'id' is set
        if (id == null) {
            throw new ApiException("Missing the required parameter 'id' when calling apikeysIdPatch(Async)");
        }
        
        com.squareup.okhttp.Call call = apikeysIdPatchCall(body, id, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Update api key
     * 
     * @param body  (required)
     * @param id Api Key ID (required)
     * @return ApiKey
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiKey apikeysIdPatch(ApikeysIdBody body, String id) throws ApiException {
        ApiResponse<ApiKey> resp = apikeysIdPatchWithHttpInfo(body, id);
        return resp.getData();
    }

    /**
     * Update api key
     * 
     * @param body  (required)
     * @param id Api Key ID (required)
     * @return ApiResponse&lt;ApiKey&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<ApiKey> apikeysIdPatchWithHttpInfo(ApikeysIdBody body, String id) throws ApiException {
        com.squareup.okhttp.Call call = apikeysIdPatchValidateBeforeCall(body, id, null, null);
        Type localVarReturnType = new TypeToken<ApiKey>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Update api key (asynchronously)
     * 
     * @param body  (required)
     * @param id Api Key ID (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call apikeysIdPatchAsync(ApikeysIdBody body, String id, final ApiCallback<ApiKey> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = apikeysIdPatchValidateBeforeCall(body, id, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<ApiKey>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for apikeysPost
     * @param body  (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call apikeysPostCall(ApikeysBody body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = body;
        
        // create path and map variables
        String localVarPath = "/apikeys";

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

        String[] localVarAuthNames = new String[] { "bearerAuth" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarCollectionQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call apikeysPostValidateBeforeCall(ApikeysBody body, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        // verify the required parameter 'body' is set
        if (body == null) {
            throw new ApiException("Missing the required parameter 'body' when calling apikeysPost(Async)");
        }
        
        com.squareup.okhttp.Call call = apikeysPostCall(body, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Create api key
     * 
     * @param body  (required)
     * @return ApiKey
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiKey apikeysPost(ApikeysBody body) throws ApiException {
        ApiResponse<ApiKey> resp = apikeysPostWithHttpInfo(body);
        return resp.getData();
    }

    /**
     * Create api key
     * 
     * @param body  (required)
     * @return ApiResponse&lt;ApiKey&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<ApiKey> apikeysPostWithHttpInfo(ApikeysBody body) throws ApiException {
        com.squareup.okhttp.Call call = apikeysPostValidateBeforeCall(body, null, null);
        Type localVarReturnType = new TypeToken<ApiKey>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Create api key (asynchronously)
     * 
     * @param body  (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call apikeysPostAsync(ApikeysBody body, final ApiCallback<ApiKey> callback) throws ApiException {

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

        com.squareup.okhttp.Call call = apikeysPostValidateBeforeCall(body, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<ApiKey>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}