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
    public interface IFieldsApi
    {
        /// <summary>
        /// Get fields Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.
        /// </summary>
        /// <param name="tenant">Get all fields for a Tenant ID</param>
        /// <param name="schema">Get all fields for a Schema ID</param>
        /// <param name="sort">sort by query in the form of field:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of fields</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 FieldsGet (Guid? tenant, Guid? schema, string sort, int? limit, int? page);
        /// <summary>
        /// Delete field 
        /// </summary>
        /// <param name="id">Field id</param>
        /// <returns></returns>
        void FieldsIdDelete (string id);
        /// <summary>
        /// Get field 
        /// </summary>
        /// <param name="id">Field id</param>
        /// <returns>Field</returns>
        Field FieldsIdGet (string id);
        /// <summary>
        /// Update field 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Field id</param>
        /// <returns>Field</returns>
        Field FieldsIdPatch (FieldsIdBody body, string id);
        /// <summary>
        /// Create field 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Field</returns>
        Field FieldsPost (FieldsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FieldsApi : IFieldsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FieldsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FieldsApi(String basePath)
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
        /// Get fields Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.
        /// </summary>
        /// <param name="tenant">Get all fields for a Tenant ID</param>
        /// <param name="schema">Get all fields for a Schema ID</param>
        /// <param name="sort">sort by query in the form of field:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of fields</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 FieldsGet (Guid? tenant, Guid? schema, string sort, int? limit, int? page)
        {
    
            var path = "/fields";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (tenant != null) queryParams.Add("tenant", ApiClient.ParameterToString(tenant)); // query parameter
 if (schema != null) queryParams.Add("schema", ApiClient.ParameterToString(schema)); // query parameter
 if (sort != null) queryParams.Add("sort", ApiClient.ParameterToString(sort)); // query parameter
 if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
 if (page != null) queryParams.Add("page", ApiClient.ParameterToString(page)); // query parameter
                        
            // authentication setting, if any
            String[] authSettings = new String[] { "bearerAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FieldsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FieldsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2006) ApiClient.Deserialize(response.Content, typeof(InlineResponse2006), response.Headers);
        }
    
        /// <summary>
        /// Delete field 
        /// </summary>
        /// <param name="id">Field id</param>
        /// <returns></returns>
        public void FieldsIdDelete (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling FieldsIdDelete");
    
            var path = "/fields/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FieldsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FieldsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get field 
        /// </summary>
        /// <param name="id">Field id</param>
        /// <returns>Field</returns>
        public Field FieldsIdGet (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling FieldsIdGet");
    
            var path = "/fields/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FieldsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FieldsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Field) ApiClient.Deserialize(response.Content, typeof(Field), response.Headers);
        }
    
        /// <summary>
        /// Update field 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Field id</param>
        /// <returns>Field</returns>
        public Field FieldsIdPatch (FieldsIdBody body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling FieldsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling FieldsIdPatch");
    
            var path = "/fields/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FieldsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FieldsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Field) ApiClient.Deserialize(response.Content, typeof(Field), response.Headers);
        }
    
        /// <summary>
        /// Create field 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Field</returns>
        public Field FieldsPost (FieldsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling FieldsPost");
    
            var path = "/fields";
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
                throw new ApiException ((int)response.StatusCode, "Error calling FieldsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FieldsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Field) ApiClient.Deserialize(response.Content, typeof(Field), response.Headers);
        }
    
    }
}
