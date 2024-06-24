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
    public interface IMappingsApi
    {
        /// <summary>
        /// Get mappings Retrieve a list of mappings with the ability to filter by tenant, category, schema, integration, field, sort, limit or page.
        /// </summary>
        /// <param name="tenant">Get all mappings for a Tenant ID</param>
        /// <param name="schema">Get all mappings for a Schema ID</param>
        /// <param name="field">Get all mappings for a Field ID</param>
        /// <param name="integration">Get all mappings for an Integration ID</param>
        /// <param name="sort">sort by query in the form of mapping:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of mappings</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse2009</returns>
        InlineResponse2009 MappingsGet (Guid? tenant, Guid? schema, Guid? field, Guid? integration, string sort, int? limit, int? page);
        /// <summary>
        /// Delete mapping 
        /// </summary>
        /// <param name="id">Mapping id</param>
        /// <returns></returns>
        void MappingsIdDelete (string id);
        /// <summary>
        /// Get mapping 
        /// </summary>
        /// <param name="id">Mapping id</param>
        /// <returns>Mapping</returns>
        Mapping MappingsIdGet (string id);
        /// <summary>
        /// Update mapping 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Mapping id</param>
        /// <returns>Mapping</returns>
        Mapping MappingsIdPatch (MappingsIdBody body, string id);
        /// <summary>
        /// Create mapping 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Mapping</returns>
        Mapping MappingsPost (MappingsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class MappingsApi : IMappingsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public MappingsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MappingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MappingsApi(String basePath)
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
        /// Get mappings Retrieve a list of mappings with the ability to filter by tenant, category, schema, integration, field, sort, limit or page.
        /// </summary>
        /// <param name="tenant">Get all mappings for a Tenant ID</param>
        /// <param name="schema">Get all mappings for a Schema ID</param>
        /// <param name="field">Get all mappings for a Field ID</param>
        /// <param name="integration">Get all mappings for an Integration ID</param>
        /// <param name="sort">sort by query in the form of mapping:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of mappings</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse2009</returns>
        public InlineResponse2009 MappingsGet (Guid? tenant, Guid? schema, Guid? field, Guid? integration, string sort, int? limit, int? page)
        {
    
            var path = "/mappings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (tenant != null) queryParams.Add("tenant", ApiClient.ParameterToString(tenant)); // query parameter
 if (schema != null) queryParams.Add("schema", ApiClient.ParameterToString(schema)); // query parameter
 if (field != null) queryParams.Add("field", ApiClient.ParameterToString(field)); // query parameter
 if (integration != null) queryParams.Add("integration", ApiClient.ParameterToString(integration)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling MappingsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MappingsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2009) ApiClient.Deserialize(response.Content, typeof(InlineResponse2009), response.Headers);
        }
    
        /// <summary>
        /// Delete mapping 
        /// </summary>
        /// <param name="id">Mapping id</param>
        /// <returns></returns>
        public void MappingsIdDelete (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MappingsIdDelete");
    
            var path = "/mappings/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MappingsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MappingsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get mapping 
        /// </summary>
        /// <param name="id">Mapping id</param>
        /// <returns>Mapping</returns>
        public Mapping MappingsIdGet (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MappingsIdGet");
    
            var path = "/mappings/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MappingsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MappingsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Mapping) ApiClient.Deserialize(response.Content, typeof(Mapping), response.Headers);
        }
    
        /// <summary>
        /// Update mapping 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Mapping id</param>
        /// <returns>Mapping</returns>
        public Mapping MappingsIdPatch (MappingsIdBody body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling MappingsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling MappingsIdPatch");
    
            var path = "/mappings/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MappingsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MappingsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Mapping) ApiClient.Deserialize(response.Content, typeof(Mapping), response.Headers);
        }
    
        /// <summary>
        /// Create mapping 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Mapping</returns>
        public Mapping MappingsPost (MappingsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling MappingsPost");
    
            var path = "/mappings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling MappingsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling MappingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Mapping) ApiClient.Deserialize(response.Content, typeof(Mapping), response.Headers);
        }
    
    }
}
