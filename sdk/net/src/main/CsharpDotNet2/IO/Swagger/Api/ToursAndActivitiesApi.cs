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
    public interface IToursAndActivitiesApi
    {
        /// <summary>
        /// Cancel Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="bookingId"></param>
        /// <returns>ToursAndActivitiesCancelBookingResponseSchema</returns>
        ToursAndActivitiesCancelBookingResponseSchema ToursBookingsBookingIdCancelPost (ToursAndActivitiesCancelBookingRequestSchema body, string bookingId);
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns>ToursAndActivitiesBookingDetailsResponseSchema</returns>
        ToursAndActivitiesBookingDetailsResponseSchema ToursBookingsBookingIdGet (string bookingId);
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>ToursAndActivitiesBookingResponseSchema</returns>
        ToursAndActivitiesBookingResponseSchema ToursBookingsPost (ToursAndActivitiesCreateBookingRequestSchema body);
        /// <summary>
        /// Get Offer Availability 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="offerId"></param>
        /// <returns>ToursAndActivitiesGetOfferAvailabilityResponse</returns>
        ToursAndActivitiesGetOfferAvailabilityResponse ToursOfferAvailabilityOfferIdPost (ToursAndActivitiesGetOfferAvailabilityRequest body, string offerId);
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="offerId"></param>
        /// <returns>ToursAndActivitiesOfferDetailsSchema</returns>
        ToursAndActivitiesOfferDetailsSchema ToursOffersOfferIdGet (string offerId);
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>ToursAndActivitiesOfferResponseSchema</returns>
        ToursAndActivitiesOfferResponseSchema ToursOffersSearchPost (ToursAndActivitiesOfferRequestSchema body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class ToursAndActivitiesApi : IToursAndActivitiesApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToursAndActivitiesApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public ToursAndActivitiesApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ToursAndActivitiesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ToursAndActivitiesApi(String basePath)
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
        /// <returns>ToursAndActivitiesCancelBookingResponseSchema</returns>
        public ToursAndActivitiesCancelBookingResponseSchema ToursBookingsBookingIdCancelPost (ToursAndActivitiesCancelBookingRequestSchema body, string bookingId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ToursBookingsBookingIdCancelPost");
            // verify the required parameter 'bookingId' is set
            if (bookingId == null) throw new ApiException(400, "Missing required parameter 'bookingId' when calling ToursBookingsBookingIdCancelPost");
    
            var path = "/tours/bookings/{bookingId}/cancel";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ToursBookingsBookingIdCancelPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ToursBookingsBookingIdCancelPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ToursAndActivitiesCancelBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(ToursAndActivitiesCancelBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns>ToursAndActivitiesBookingDetailsResponseSchema</returns>
        public ToursAndActivitiesBookingDetailsResponseSchema ToursBookingsBookingIdGet (string bookingId)
        {
            // verify the required parameter 'bookingId' is set
            if (bookingId == null) throw new ApiException(400, "Missing required parameter 'bookingId' when calling ToursBookingsBookingIdGet");
    
            var path = "/tours/bookings/{bookingId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ToursBookingsBookingIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ToursBookingsBookingIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ToursAndActivitiesBookingDetailsResponseSchema) ApiClient.Deserialize(response.Content, typeof(ToursAndActivitiesBookingDetailsResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>ToursAndActivitiesBookingResponseSchema</returns>
        public ToursAndActivitiesBookingResponseSchema ToursBookingsPost (ToursAndActivitiesCreateBookingRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ToursBookingsPost");
    
            var path = "/tours/bookings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ToursBookingsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ToursBookingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ToursAndActivitiesBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(ToursAndActivitiesBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Availability 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="offerId"></param>
        /// <returns>ToursAndActivitiesGetOfferAvailabilityResponse</returns>
        public ToursAndActivitiesGetOfferAvailabilityResponse ToursOfferAvailabilityOfferIdPost (ToursAndActivitiesGetOfferAvailabilityRequest body, string offerId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ToursOfferAvailabilityOfferIdPost");
            // verify the required parameter 'offerId' is set
            if (offerId == null) throw new ApiException(400, "Missing required parameter 'offerId' when calling ToursOfferAvailabilityOfferIdPost");
    
            var path = "/tours/offer_availability/{offerId}";
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
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling ToursOfferAvailabilityOfferIdPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ToursOfferAvailabilityOfferIdPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ToursAndActivitiesGetOfferAvailabilityResponse) ApiClient.Deserialize(response.Content, typeof(ToursAndActivitiesGetOfferAvailabilityResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="offerId"></param>
        /// <returns>ToursAndActivitiesOfferDetailsSchema</returns>
        public ToursAndActivitiesOfferDetailsSchema ToursOffersOfferIdGet (string offerId)
        {
            // verify the required parameter 'offerId' is set
            if (offerId == null) throw new ApiException(400, "Missing required parameter 'offerId' when calling ToursOffersOfferIdGet");
    
            var path = "/tours/offers/{offerId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ToursOffersOfferIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ToursOffersOfferIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ToursAndActivitiesOfferDetailsSchema) ApiClient.Deserialize(response.Content, typeof(ToursAndActivitiesOfferDetailsSchema), response.Headers);
        }
    
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>ToursAndActivitiesOfferResponseSchema</returns>
        public ToursAndActivitiesOfferResponseSchema ToursOffersSearchPost (ToursAndActivitiesOfferRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling ToursOffersSearchPost");
    
            var path = "/tours/offers/search";
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
                throw new ApiException ((int)response.StatusCode, "Error calling ToursOffersSearchPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling ToursOffersSearchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (ToursAndActivitiesOfferResponseSchema) ApiClient.Deserialize(response.Content, typeof(ToursAndActivitiesOfferResponseSchema), response.Headers);
        }
    
    }
}
