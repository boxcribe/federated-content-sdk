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
    public interface ITenantsApi
    {
        /// <summary>
        /// Get tenants 
        /// </summary>
        /// <param name="company">Company ID</param>
        /// <param name="sort">sort by query in the form of field:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of tenants</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse20012</returns>
        InlineResponse20012 TenantsGet (string company, string sort, int? limit, int? page);
        /// <summary>
        /// Delete tenant 
        /// </summary>
        /// <param name="id">Tenant id</param>
        /// <returns></returns>
        void TenantsIdDelete (string id);
        /// <summary>
        /// Get tenant 
        /// </summary>
        /// <param name="id">Tenant id</param>
        /// <returns>Tenant</returns>
        Tenant TenantsIdGet (string id);
        /// <summary>
        /// Update tenant 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Tenant id</param>
        /// <returns>Tenant</returns>
        Tenant TenantsIdPatch (TenantsIdBody body, string id);
        /// <summary>
        /// Create tenant 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Tenant</returns>
        Tenant TenantsPost (TenantsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TenantsApi : ITenantsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TenantsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TenantsApi(String basePath)
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
        /// Get tenants 
        /// </summary>
        /// <param name="company">Company ID</param>
        /// <param name="sort">sort by query in the form of field:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of tenants</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse20012</returns>
        public InlineResponse20012 TenantsGet (string company, string sort, int? limit, int? page)
        {
    
            var path = "/tenants";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (company != null) queryParams.Add("company", ApiClient.ParameterToString(company)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TenantsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TenantsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20012) ApiClient.Deserialize(response.Content, typeof(InlineResponse20012), response.Headers);
        }
    
        /// <summary>
        /// Delete tenant 
        /// </summary>
        /// <param name="id">Tenant id</param>
        /// <returns></returns>
        public void TenantsIdDelete (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TenantsIdDelete");
    
            var path = "/tenants/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TenantsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TenantsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get tenant 
        /// </summary>
        /// <param name="id">Tenant id</param>
        /// <returns>Tenant</returns>
        public Tenant TenantsIdGet (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TenantsIdGet");
    
            var path = "/tenants/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TenantsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TenantsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Tenant) ApiClient.Deserialize(response.Content, typeof(Tenant), response.Headers);
        }
    
        /// <summary>
        /// Update tenant 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Tenant id</param>
        /// <returns>Tenant</returns>
        public Tenant TenantsIdPatch (TenantsIdBody body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling TenantsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling TenantsIdPatch");
    
            var path = "/tenants/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TenantsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TenantsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Tenant) ApiClient.Deserialize(response.Content, typeof(Tenant), response.Headers);
        }
    
        /// <summary>
        /// Create tenant 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Tenant</returns>
        public Tenant TenantsPost (TenantsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling TenantsPost");
    
            var path = "/tenants";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TenantsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TenantsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Tenant) ApiClient.Deserialize(response.Content, typeof(Tenant), response.Headers);
        }
    
    }
}
