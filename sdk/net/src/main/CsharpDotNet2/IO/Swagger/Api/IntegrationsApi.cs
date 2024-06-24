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
    public interface IIntegrationsApi
    {
        /// <summary>
        /// Get integrations Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.
        /// </summary>
        /// <param name="tenant">Get all integrations for a Tenant ID</param>
        /// <param name="category">Get all integrations for a Category ID</param>
        /// <param name="sort">sort by query in the form of field:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of integrations</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 IntegrationsGet (Guid? tenant, Guid? category, string sort, int? limit, int? page);
        /// <summary>
        /// Delete integration 
        /// </summary>
        /// <param name="id">Integration id</param>
        /// <returns></returns>
        void IntegrationsIdDelete (string id);
        /// <summary>
        /// Get integration 
        /// </summary>
        /// <param name="id">Integration id</param>
        /// <returns>Integration</returns>
        Integration IntegrationsIdGet (string id);
        /// <summary>
        /// Update integration 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Integration id</param>
        /// <returns>Integration</returns>
        Integration IntegrationsIdPatch (IntegrationsIdBody body, string id);
        /// <summary>
        /// Create integration 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Integration</returns>
        Integration IntegrationsPost (IntegrationsBody body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class IntegrationsApi : IIntegrationsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public IntegrationsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public IntegrationsApi(String basePath)
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
        /// Get integrations Retrieve a list of integrations with the ability to filter by tenant, category, sort, limit or page.
        /// </summary>
        /// <param name="tenant">Get all integrations for a Tenant ID</param>
        /// <param name="category">Get all integrations for a Category ID</param>
        /// <param name="sort">sort by query in the form of field:desc/asc (ex. name:asc)</param>
        /// <param name="limit">Maximum number of integrations</param>
        /// <param name="page">Page number</param>
        /// <returns>InlineResponse2007</returns>
        public InlineResponse2007 IntegrationsGet (Guid? tenant, Guid? category, string sort, int? limit, int? page)
        {
    
            var path = "/integrations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IntegrationsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IntegrationsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (InlineResponse2007) ApiClient.Deserialize(response.Content, typeof(InlineResponse2007), response.Headers);
        }
    
        /// <summary>
        /// Delete integration 
        /// </summary>
        /// <param name="id">Integration id</param>
        /// <returns></returns>
        public void IntegrationsIdDelete (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IntegrationsIdDelete");
    
            var path = "/integrations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IntegrationsIdDelete: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IntegrationsIdDelete: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        /// Get integration 
        /// </summary>
        /// <param name="id">Integration id</param>
        /// <returns>Integration</returns>
        public Integration IntegrationsIdGet (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IntegrationsIdGet");
    
            var path = "/integrations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IntegrationsIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IntegrationsIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Integration) ApiClient.Deserialize(response.Content, typeof(Integration), response.Headers);
        }
    
        /// <summary>
        /// Update integration 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="id">Integration id</param>
        /// <returns>Integration</returns>
        public Integration IntegrationsIdPatch (IntegrationsIdBody body, string id)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsIdPatch");
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling IntegrationsIdPatch");
    
            var path = "/integrations/{id}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IntegrationsIdPatch: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IntegrationsIdPatch: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Integration) ApiClient.Deserialize(response.Content, typeof(Integration), response.Headers);
        }
    
        /// <summary>
        /// Create integration 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>Integration</returns>
        public Integration IntegrationsPost (IntegrationsBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling IntegrationsPost");
    
            var path = "/integrations";
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
                throw new ApiException ((int)response.StatusCode, "Error calling IntegrationsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling IntegrationsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Integration) ApiClient.Deserialize(response.Content, typeof(Integration), response.Headers);
        }
    
    }
}
