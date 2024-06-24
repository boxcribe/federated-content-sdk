using System;
using System.Collections.Generic;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IApiKeysApi
    {
        /// <summary>
        /// Get api keys Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.
        /// </summary>
        /// <param name="tenant">Get all schemas for a Tenant ID</param>
        /// <param name="environment">Get all schemas for an Environment (Sandbox or Production)</param>
        /// <param name="sort">sort by query in the form of field:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of apiKeys</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 ApikeysGet (string tenant, string environment, string sort, int? limit, int? page);
        /// <summary>
        /// Delete api key 
        /// </summary>
        /// <param name="id">Api Key ID</param>
        /// <returns></returns>
        void ApikeysIdDelete (string id);
        /// <summary>
        /// Get api key 
        /// </summary>
        /// <param name="id">Api Key ID</param>
        /// <returns>ApiKey</returns>
        ApiKey ApikeysIdGet (string id);
        /// <summary>
        /// Update api key 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Api Key ID</param>
        /// <returns>ApiKey</returns>
        ApiKey ApikeysIdPatch (ApikeysIdBody body, string id);
        /// <summary>
        /// Create api key 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>ApiKey</returns>
        ApiKey ApikeysPost (ApikeysBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ApiKeysApi : IApiKeysApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ApiKeysApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKeysApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ApiKeysApi(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Get api keys Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.
        /// </summary>
        /// <param name="tenant">Get all schemas for a Tenant ID</param>
        /// <param name="environment">Get all schemas for an Environment (Sandbox or Production)</param>
        /// <param name="sort">sort by query in the form of field:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of apiKeys</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 ApikeysGet (string tenant, string environment, string sort, int? limit, int? page)
        {
    
            var path = "/apikeys";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (tenant != null) queryParams.Add("tenant", ApiClient.ParameterToString(tenant)); // query parameter
 if (environment != null) queryParams.Add("environment", ApiClient.ParameterToString(environment)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApikeysGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApikeysGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2002) ApiClient.Deserialize(response.Content, typeof(InlineResponse2002), response.Headers);
        }
    
        /// <summary>
        /// Delete api key 
        /// </summary>
        /// <param name="id">Api Key ID</param>
        /// <returns></returns>
        public void ApikeysIdDelete (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApikeysIdDelete");
    
            var path = "/apikeys/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApikeysIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApikeysIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get api key 
        /// </summary>
        /// <param name="id">Api Key ID</param>
        /// <returns>ApiKey</returns>
        public ApiKey ApikeysIdGet (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApikeysIdGet");
    
            var path = "/apikeys/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApikeysIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApikeysIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiKey) ApiClient.Deserialize(response.Content, typeof(ApiKey), response.Headers);
        }
    
        /// <summary>
        /// Update api key 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Api Key ID</param>
        /// <returns>ApiKey</returns>
        public ApiKey ApikeysIdPatch (ApikeysIdBody body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ApikeysIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling ApikeysIdPatch");
    
            var path = "/apikeys/{id}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "id" + "}", ApiClient.ParameterToString(id));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApikeysIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApikeysIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiKey) ApiClient.Deserialize(response.Content, typeof(ApiKey), response.Headers);
        }
    
        /// <summary>
        /// Create api key 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>ApiKey</returns>
        public ApiKey ApikeysPost (ApikeysBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ApikeysPost");
    
            var path = "/apikeys";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ApikeysPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ApikeysPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ApiKey) ApiClient.Deserialize(response.Content, typeof(ApiKey), response.Headers);
        }
    
    }
}
