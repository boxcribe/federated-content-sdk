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
    public interface ITransportsApi
    {
        /// <summary>
        /// Cancel Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="bookingId"></param>
        /// <returns>TransportCancelBookingResponseSchema</returns>
        TransportCancelBookingResponseSchema TransportsBookingsBookingIdCancelPost (TransportCancelBookingRequestSchema body, string bookingId);
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns>TransportBookingDetailsResponseSchema</returns>
        TransportBookingDetailsResponseSchema TransportsBookingsBookingIdGet (string bookingId);
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>TransportBookingResponseSchema</returns>
        TransportBookingResponseSchema TransportsBookingsPost (TransportCreateBookingRequestSchema body);
        /// <summary>
        /// Get Offer Availability 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="offerId"></param>
        /// <returns>TransportGetOfferAvailabilityResponse</returns>
        TransportGetOfferAvailabilityResponse TransportsOfferAvailabilityOfferIdGet (TransportGetOfferAvailabilityRequest body, string offerId);
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="offerId"></param>
        /// <returns>TransportOfferDetailsSchema</returns>
        TransportOfferDetailsSchema TransportsOffersOfferIdGet (string offerId);
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>TransportOfferResponseSchema</returns>
        TransportOfferResponseSchema TransportsOffersSearchPost (TransportOfferRequestSchema body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class TransportsApi : ITransportsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public TransportsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TransportsApi(String basePath)
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
        /// <param name="bookingId"></param>
        /// <returns>TransportCancelBookingResponseSchema</returns>
        public TransportCancelBookingResponseSchema TransportsBookingsBookingIdCancelPost (TransportCancelBookingRequestSchema body, string bookingId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling TransportsBookingsBookingIdCancelPost");
            // verify the required parameter 'bookingId' is set
            if (bookingId == null) throw new ApiException(400, "Missing required parameter 'bookingId' when calling TransportsBookingsBookingIdCancelPost");
    
            var path = "/transports/bookings/{bookingId}/cancel";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "bookingId" + "}", ApiClient.ParameterToString(bookingId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsBookingsBookingIdCancelPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsBookingsBookingIdCancelPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransportCancelBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(TransportCancelBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns>TransportBookingDetailsResponseSchema</returns>
        public TransportBookingDetailsResponseSchema TransportsBookingsBookingIdGet (string bookingId)
        {
            // verify the required parameter 'bookingId' is set
            if (bookingId == null) throw new ApiException(400, "Missing required parameter 'bookingId' when calling TransportsBookingsBookingIdGet");
    
            var path = "/transports/bookings/{bookingId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "bookingId" + "}", ApiClient.ParameterToString(bookingId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKeyAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsBookingsBookingIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsBookingsBookingIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransportBookingDetailsResponseSchema) ApiClient.Deserialize(response.Content, typeof(TransportBookingDetailsResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>TransportBookingResponseSchema</returns>
        public TransportBookingResponseSchema TransportsBookingsPost (TransportCreateBookingRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling TransportsBookingsPost");
    
            var path = "/transports/bookings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsBookingsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsBookingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransportBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(TransportBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Availability 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="offerId"></param>
        /// <returns>TransportGetOfferAvailabilityResponse</returns>
        public TransportGetOfferAvailabilityResponse TransportsOfferAvailabilityOfferIdGet (TransportGetOfferAvailabilityRequest body, string offerId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling TransportsOfferAvailabilityOfferIdGet");
            // verify the required parameter 'offerId' is set
            if (offerId == null) throw new ApiException(400, "Missing required parameter 'offerId' when calling TransportsOfferAvailabilityOfferIdGet");
    
            var path = "/transports/offer_availability/{offerId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "offerId" + "}", ApiClient.ParameterToString(offerId));
    
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
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsOfferAvailabilityOfferIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsOfferAvailabilityOfferIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransportGetOfferAvailabilityResponse) ApiClient.Deserialize(response.Content, typeof(TransportGetOfferAvailabilityResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="offerId"></param>
        /// <returns>TransportOfferDetailsSchema</returns>
        public TransportOfferDetailsSchema TransportsOffersOfferIdGet (string offerId)
        {
            // verify the required parameter 'offerId' is set
            if (offerId == null) throw new ApiException(400, "Missing required parameter 'offerId' when calling TransportsOffersOfferIdGet");
    
            var path = "/transports/offers/{offerId}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "offerId" + "}", ApiClient.ParameterToString(offerId));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                    
            // authentication setting, if any
            String[] authSettings = new String[] { "apiKeyAuth" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsOffersOfferIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsOffersOfferIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransportOfferDetailsSchema) ApiClient.Deserialize(response.Content, typeof(TransportOfferDetailsSchema), response.Headers);
        }
    
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>TransportOfferResponseSchema</returns>
        public TransportOfferResponseSchema TransportsOffersSearchPost (TransportOfferRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling TransportsOffersSearchPost");
    
            var path = "/transports/offers/search";
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
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsOffersSearchPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling TransportsOffersSearchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (TransportOfferResponseSchema) ApiClient.Deserialize(response.Content, typeof(TransportOfferResponseSchema), response.Headers);
        }
    
    }
}
