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
    public interface IHotelsApi
    {
        /// <summary>
        /// Cancel Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="bookingId"></param>
        /// <returns>HotelCancelBookingResponseSchema</returns>
        HotelCancelBookingResponseSchema HotelsBookingsBookingIdCancelPost (HotelCancelBookingRequestSchema body, string bookingId);
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns>HotelBookingDetailsResponseSchema</returns>
        HotelBookingDetailsResponseSchema HotelsBookingsBookingIdGet (string bookingId);
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>HotelBookingResponseSchema</returns>
        HotelBookingResponseSchema HotelsBookingsPost (HotelCreateBookingRequestSchema body);
        /// <summary>
        /// Get Offer Availability 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="offerId"></param>
        /// <returns>HotelGetOfferAvailabilityResponse</returns>
        HotelGetOfferAvailabilityResponse HotelsOfferAvailabilityOfferIdGet (HotelGetOfferAvailabilityRequest body, string offerId);
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="offerId"></param>
        /// <returns>HotelOfferDetailsSchema</returns>
        HotelOfferDetailsSchema HotelsOffersOfferIdGet (string offerId);
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>HotelOfferResponseSchema</returns>
        HotelOfferResponseSchema HotelsOffersSearchPost (HotelOfferRequestSchema body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class HotelsApi : IHotelsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public HotelsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="HotelsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HotelsApi(String basePath)
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
        /// <returns>HotelCancelBookingResponseSchema</returns>
        public HotelCancelBookingResponseSchema HotelsBookingsBookingIdCancelPost (HotelCancelBookingRequestSchema body, string bookingId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling HotelsBookingsBookingIdCancelPost");
            // verify the required parameter 'bookingId' is set
            if (bookingId == null) throw new ApiException(400, "Missing required parameter 'bookingId' when calling HotelsBookingsBookingIdCancelPost");
    
            var path = "/hotels/bookings/{bookingId}/cancel";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsBookingsBookingIdCancelPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsBookingsBookingIdCancelPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HotelCancelBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(HotelCancelBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns>HotelBookingDetailsResponseSchema</returns>
        public HotelBookingDetailsResponseSchema HotelsBookingsBookingIdGet (string bookingId)
        {
            // verify the required parameter 'bookingId' is set
            if (bookingId == null) throw new ApiException(400, "Missing required parameter 'bookingId' when calling HotelsBookingsBookingIdGet");
    
            var path = "/hotels/bookings/{bookingId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsBookingsBookingIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsBookingsBookingIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HotelBookingDetailsResponseSchema) ApiClient.Deserialize(response.Content, typeof(HotelBookingDetailsResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>HotelBookingResponseSchema</returns>
        public HotelBookingResponseSchema HotelsBookingsPost (HotelCreateBookingRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling HotelsBookingsPost");
    
            var path = "/hotels/bookings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsBookingsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsBookingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HotelBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(HotelBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Availability 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="offerId"></param>
        /// <returns>HotelGetOfferAvailabilityResponse</returns>
        public HotelGetOfferAvailabilityResponse HotelsOfferAvailabilityOfferIdGet (HotelGetOfferAvailabilityRequest body, string offerId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling HotelsOfferAvailabilityOfferIdGet");
            // verify the required parameter 'offerId' is set
            if (offerId == null) throw new ApiException(400, "Missing required parameter 'offerId' when calling HotelsOfferAvailabilityOfferIdGet");
    
            var path = "/hotels/offer_availability/{offerId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsOfferAvailabilityOfferIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsOfferAvailabilityOfferIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HotelGetOfferAvailabilityResponse) ApiClient.Deserialize(response.Content, typeof(HotelGetOfferAvailabilityResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="offerId"></param>
        /// <returns>HotelOfferDetailsSchema</returns>
        public HotelOfferDetailsSchema HotelsOffersOfferIdGet (string offerId)
        {
            // verify the required parameter 'offerId' is set
            if (offerId == null) throw new ApiException(400, "Missing required parameter 'offerId' when calling HotelsOffersOfferIdGet");
    
            var path = "/hotels/offers/{offerId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsOffersOfferIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsOffersOfferIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HotelOfferDetailsSchema) ApiClient.Deserialize(response.Content, typeof(HotelOfferDetailsSchema), response.Headers);
        }
    
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>HotelOfferResponseSchema</returns>
        public HotelOfferResponseSchema HotelsOffersSearchPost (HotelOfferRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling HotelsOffersSearchPost");
    
            var path = "/hotels/offers/search";
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
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsOffersSearchPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling HotelsOffersSearchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (HotelOfferResponseSchema) ApiClient.Deserialize(response.Content, typeof(HotelOfferResponseSchema), response.Headers);
        }
    
    }
}
