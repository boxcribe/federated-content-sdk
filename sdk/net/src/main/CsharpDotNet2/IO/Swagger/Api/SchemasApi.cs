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
    public interface ISchemasApi
    {
        /// <summary>
        /// Get schemas Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.
        /// </summary>
        /// <param name="tenant">Get all schemas for a Tenant ID</param>
        /// <param name="category">Get all schemas for a Category ID</param>
        /// <param name="sort">Sort by query in the form of field:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of schemas</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 SchemasGet (Guid? tenant, Guid? category, string sort, int? limit, int? page);
        /// <summary>
        /// Get schemas grouped by endpoint Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.
        /// </summary>
        /// <param name="tenant">Get all schemas for a Tenant ID</param>
        /// <param name="category">Get all schemas for a Category ID</param>
        /// <param name="sort">Sort by query in the form of field:desc/asc (ex. endpoint:asc)</param>
        /// <param name="limit">Maximum number of schemas</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse20011</returns>
        InlineResponse20011 SchemasGroupedByEndpointGet (Guid? tenant, Guid? category, string sort, int? limit, int? page);
        /// <summary>
        /// Delete schema 
        /// </summary>
        /// <param name="id">Schema id</param>
        /// <returns></returns>
        void SchemasIdDelete (string id);
        /// <summary>
        /// Get schema 
        /// </summary>
        /// <param name="id">Schema id</param>
        /// <returns>Schema</returns>
        Schema SchemasIdGet (string id);
        /// <summary>
        /// Update schema 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Schema id</param>
        /// <returns>Schema</returns>
        Schema SchemasIdPatch (SchemasIdBody body, string id);
        /// <summary>
        /// Create schema 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Schema</returns>
        Schema SchemasPost (SchemasBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SchemasApi : ISchemasApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public SchemasApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SchemasApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SchemasApi(String basePath)
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
        /// Get schemas Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.
        /// </summary>
        /// <param name="tenant">Get all schemas for a Tenant ID</param>
        /// <param name="category">Get all schemas for a Category ID</param>
        /// <param name="sort">Sort by query in the form of field:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of schemas</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse20010</returns>
        public InlineResponse20010 SchemasGet (Guid? tenant, Guid? category, string sort, int? limit, int? page)
        {
    
            var path = "/schemas";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (tenant != null) queryParams.Add("tenant", ApiClient.ParameterToString(tenant)); // query parameter
 if (category != null) queryParams.Add("category", ApiClient.ParameterToString(category)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20010) ApiClient.Deserialize(response.Content, typeof(InlineResponse20010), response.Headers);
        }
    
        /// <summary>
        /// Get schemas grouped by endpoint Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.
        /// </summary>
        /// <param name="tenant">Get all schemas for a Tenant ID</param>
        /// <param name="category">Get all schemas for a Category ID</param>
        /// <param name="sort">Sort by query in the form of field:desc/asc (ex. endpoint:asc)</param>
        /// <param name="limit">Maximum number of schemas</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse20011</returns>
        public InlineResponse20011 SchemasGroupedByEndpointGet (Guid? tenant, Guid? category, string sort, int? limit, int? page)
        {
    
            var path = "/schemas/groupedByEndpoint";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (tenant != null) queryParams.Add("tenant", ApiClient.ParameterToString(tenant)); // query parameter
 if (category != null) queryParams.Add("category", ApiClient.ParameterToString(category)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasGroupedByEndpointGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasGroupedByEndpointGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse20011) ApiClient.Deserialize(response.Content, typeof(InlineResponse20011), response.Headers);
        }
    
        /// <summary>
        /// Delete schema 
        /// </summary>
        /// <param name="id">Schema id</param>
        /// <returns></returns>
        public void SchemasIdDelete (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SchemasIdDelete");
    
            var path = "/schemas/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get schema 
        /// </summary>
        /// <param name="id">Schema id</param>
        /// <returns>Schema</returns>
        public Schema SchemasIdGet (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SchemasIdGet");
    
            var path = "/schemas/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Schema) ApiClient.Deserialize(response.Content, typeof(Schema), response.Headers);
        }
    
        /// <summary>
        /// Update schema 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Schema id</param>
        /// <returns>Schema</returns>
        public Schema SchemasIdPatch (SchemasIdBody body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SchemasIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling SchemasIdPatch");
    
            var path = "/schemas/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Schema) ApiClient.Deserialize(response.Content, typeof(Schema), response.Headers);
        }
    
        /// <summary>
        /// Create schema 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Schema</returns>
        public Schema SchemasPost (SchemasBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling SchemasPost");
    
            var path = "/schemas";
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
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling SchemasPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Schema) ApiClient.Deserialize(response.Content, typeof(Schema), response.Headers);
        }
    
    }
}
