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
    public interface IDiningApi
    {
        /// <summary>
        /// Cancel Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="bookingId"></param>
        /// <returns>DiningCancelBookingResponseSchema</returns>
        DiningCancelBookingResponseSchema DiningBookingsBookingIdCancelPost (DiningCancelBookingRequestSchema body, string bookingId);
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns>DiningBookingDetailsResponseSchema</returns>
        DiningBookingDetailsResponseSchema DiningBookingsBookingIdGet (string bookingId);
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>DiningBookingResponseSchema</returns>
        DiningBookingResponseSchema DiningBookingsPost (DiningCreateBookingRequestSchema body);
        /// <summary>
        /// Get Offer Availability 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="offerId"></param>
        /// <returns>DiningGetOfferAvailabilityResponse</returns>
        DiningGetOfferAvailabilityResponse DiningOfferAvailabilityOfferIdGet (DiningGetOfferAvailabilityRequest body, string offerId);
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="offerId"></param>
        /// <returns>DiningOfferDetailsSchema</returns>
        DiningOfferDetailsSchema DiningOffersOfferIdGet (string offerId);
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>DiningOfferResponseSchema</returns>
        DiningOfferResponseSchema DiningOffersSearchPost (DiningOfferRequestSchema body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class DiningApi : IDiningApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiningApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DiningApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DiningApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DiningApi(String basePath)
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
        /// <returns>DiningCancelBookingResponseSchema</returns>
        public DiningCancelBookingResponseSchema DiningBookingsBookingIdCancelPost (DiningCancelBookingRequestSchema body, string bookingId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DiningBookingsBookingIdCancelPost");
            // verify the required parameter 'bookingId' is set
            if (bookingId == null) throw new ApiException(400, "Missing required parameter 'bookingId' when calling DiningBookingsBookingIdCancelPost");
    
            var path = "/dining/bookings/{bookingId}/cancel";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DiningBookingsBookingIdCancelPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DiningBookingsBookingIdCancelPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiningCancelBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(DiningCancelBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns>DiningBookingDetailsResponseSchema</returns>
        public DiningBookingDetailsResponseSchema DiningBookingsBookingIdGet (string bookingId)
        {
            // verify the required parameter 'bookingId' is set
            if (bookingId == null) throw new ApiException(400, "Missing required parameter 'bookingId' when calling DiningBookingsBookingIdGet");
    
            var path = "/dining/bookings/{bookingId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DiningBookingsBookingIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DiningBookingsBookingIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiningBookingDetailsResponseSchema) ApiClient.Deserialize(response.Content, typeof(DiningBookingDetailsResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>DiningBookingResponseSchema</returns>
        public DiningBookingResponseSchema DiningBookingsPost (DiningCreateBookingRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DiningBookingsPost");
    
            var path = "/dining/bookings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DiningBookingsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DiningBookingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiningBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(DiningBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Availability 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="offerId"></param>
        /// <returns>DiningGetOfferAvailabilityResponse</returns>
        public DiningGetOfferAvailabilityResponse DiningOfferAvailabilityOfferIdGet (DiningGetOfferAvailabilityRequest body, string offerId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DiningOfferAvailabilityOfferIdGet");
            // verify the required parameter 'offerId' is set
            if (offerId == null) throw new ApiException(400, "Missing required parameter 'offerId' when calling DiningOfferAvailabilityOfferIdGet");
    
            var path = "/dining/offer_availability/{offerId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DiningOfferAvailabilityOfferIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DiningOfferAvailabilityOfferIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiningGetOfferAvailabilityResponse) ApiClient.Deserialize(response.Content, typeof(DiningGetOfferAvailabilityResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="offerId"></param>
        /// <returns>DiningOfferDetailsSchema</returns>
        public DiningOfferDetailsSchema DiningOffersOfferIdGet (string offerId)
        {
            // verify the required parameter 'offerId' is set
            if (offerId == null) throw new ApiException(400, "Missing required parameter 'offerId' when calling DiningOffersOfferIdGet");
    
            var path = "/dining/offers/{offerId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DiningOffersOfferIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DiningOffersOfferIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiningOfferDetailsSchema) ApiClient.Deserialize(response.Content, typeof(DiningOfferDetailsSchema), response.Headers);
        }
    
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>DiningOfferResponseSchema</returns>
        public DiningOfferResponseSchema DiningOffersSearchPost (DiningOfferRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling DiningOffersSearchPost");
    
            var path = "/dining/offers/search";
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
                throw new ApiException ((int)response.StatusCode, "Error calling DiningOffersSearchPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DiningOffersSearchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (DiningOfferResponseSchema) ApiClient.Deserialize(response.Content, typeof(DiningOfferResponseSchema), response.Headers);
        }
    
    }
}
