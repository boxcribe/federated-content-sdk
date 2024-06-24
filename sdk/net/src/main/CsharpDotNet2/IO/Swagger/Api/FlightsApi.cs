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
    public interface IFlightsApi
    {
        /// <summary>
        /// Cancel Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightCancelBookingResponseSchema</returns>
        FlightCancelBookingResponseSchema FlightsBookingsBookingIdCancelPost (FlightCancelBookingRequestSchema body);
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightGetBookingDetailsResponseSchema</returns>
        FlightGetBookingDetailsResponseSchema FlightsBookingsBookingIdGet (FlightBookingDetailsRequestSchema body);
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightBookingResponseSchema</returns>
        FlightBookingResponseSchema FlightsBookingsPost (FlightCreateBookingRequestSchema body);
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightOfferDetailsResponseSchema</returns>
        FlightOfferDetailsResponseSchema FlightsOffersOfferIdGet (FlightOfferDetailsRequestSchema body);
        /// <summary>
        /// Get Offer Seatmaps 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightOfferSeatmapsResponseSchema</returns>
        FlightOfferSeatmapsResponseSchema FlightsOffersOfferIdSeatmapsGet (FlightOfferSeatmapsRequestSchema body);
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightOfferResponseSchema</returns>
        FlightOfferResponseSchema FlightsOffersSearchPost (FlightOfferRequestSchema body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class FlightsApi : IFlightsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public FlightsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FlightsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FlightsApi(String basePath)
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
        /// Cancel Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightCancelBookingResponseSchema</returns>
        public FlightCancelBookingResponseSchema FlightsBookingsBookingIdCancelPost (FlightCancelBookingRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling FlightsBookingsBookingIdCancelPost");
    
            var path = "/flights/bookings/{bookingId}/cancel";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "apiKeyAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsBookingsBookingIdCancelPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsBookingsBookingIdCancelPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FlightCancelBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(FlightCancelBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightGetBookingDetailsResponseSchema</returns>
        public FlightGetBookingDetailsResponseSchema FlightsBookingsBookingIdGet (FlightBookingDetailsRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling FlightsBookingsBookingIdGet");
    
            var path = "/flights/bookings/{bookingId}";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "apiKeyAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsBookingsBookingIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsBookingsBookingIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FlightGetBookingDetailsResponseSchema) ApiClient.Deserialize(response.Content, typeof(FlightGetBookingDetailsResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightBookingResponseSchema</returns>
        public FlightBookingResponseSchema FlightsBookingsPost (FlightCreateBookingRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling FlightsBookingsPost");
    
            var path = "/flights/bookings";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "apiKeyAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsBookingsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsBookingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FlightBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(FlightBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightOfferDetailsResponseSchema</returns>
        public FlightOfferDetailsResponseSchema FlightsOffersOfferIdGet (FlightOfferDetailsRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling FlightsOffersOfferIdGet");
    
            var path = "/flights/offers/{offerId}";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "apiKeyAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsOffersOfferIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsOffersOfferIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FlightOfferDetailsResponseSchema) ApiClient.Deserialize(response.Content, typeof(FlightOfferDetailsResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Seatmaps 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightOfferSeatmapsResponseSchema</returns>
        public FlightOfferSeatmapsResponseSchema FlightsOffersOfferIdSeatmapsGet (FlightOfferSeatmapsRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling FlightsOffersOfferIdSeatmapsGet");
    
            var path = "/flights/offers/{offerId}/seatmaps";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "apiKeyAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsOffersOfferIdSeatmapsGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsOffersOfferIdSeatmapsGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FlightOfferSeatmapsResponseSchema) ApiClient.Deserialize(response.Content, typeof(FlightOfferSeatmapsResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>FlightOfferResponseSchema</returns>
        public FlightOfferResponseSchema FlightsOffersSearchPost (FlightOfferRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling FlightsOffersSearchPost");
    
            var path = "/flights/offers/search";
            path = path.Replace("{format}", "json");
                
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            // authentication setting, if any
            String[] authSettings = new String[] { "apiKeyAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsOffersSearchPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FlightsOffersSearchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (FlightOfferResponseSchema) ApiClient.Deserialize(response.Content, typeof(FlightOfferResponseSchema), response.Headers);
        }
    
    }
}
