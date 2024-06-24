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
    public interface ICarsApi
    {
        /// <summary>
        /// Cancel Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="bookingId"></param>
        /// <returns>CarCancelBookingResponseSchema</returns>
        CarCancelBookingResponseSchema CarsBookingsBookingIdCancelPost (CarCancelBookingRequestSchema body, string bookingId);
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns>CarBookingDetailsResponseSchema</returns>
        CarBookingDetailsResponseSchema CarsBookingsBookingIdGet (string bookingId);
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>CarBookingResponseSchema</returns>
        CarBookingResponseSchema CarsBookingsPost (CarCreateBookingRequestSchema body);
        /// <summary>
        /// Get Offer Availability 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="offerId"></param>
        /// <returns>CarGetOfferAvailabilityResponse</returns>
        CarGetOfferAvailabilityResponse CarsOfferAvailabilityOfferIdGet (CarGetOfferAvailabilityRequest body, string offerId);
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="offerId"></param>
        /// <returns>CarOfferDetailsSchema</returns>
        CarOfferDetailsSchema CarsOffersOfferIdGet (string offerId);
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>CarOfferResponseSchema</returns>
        CarOfferResponseSchema CarsOffersSearchPost (CarOfferRequestSchema body);
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class CarsApi : ICarsApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CarsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public CarsApi(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CarsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CarsApi(String basePath)
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
        /// <returns>CarCancelBookingResponseSchema</returns>
        public CarCancelBookingResponseSchema CarsBookingsBookingIdCancelPost (CarCancelBookingRequestSchema body, string bookingId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CarsBookingsBookingIdCancelPost");
            // verify the required parameter 'bookingId' is set
            if (bookingId == null) throw new ApiException(400, "Missing required parameter 'bookingId' when calling CarsBookingsBookingIdCancelPost");
    
            var path = "/cars/bookings/{bookingId}/cancel";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarsBookingsBookingIdCancelPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarsBookingsBookingIdCancelPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CarCancelBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(CarCancelBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Booking Details 
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns>CarBookingDetailsResponseSchema</returns>
        public CarBookingDetailsResponseSchema CarsBookingsBookingIdGet (string bookingId)
        {
            // verify the required parameter 'bookingId' is set
            if (bookingId == null) throw new ApiException(400, "Missing required parameter 'bookingId' when calling CarsBookingsBookingIdGet");
    
            var path = "/cars/bookings/{bookingId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarsBookingsBookingIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarsBookingsBookingIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CarBookingDetailsResponseSchema) ApiClient.Deserialize(response.Content, typeof(CarBookingDetailsResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Create Booking 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>CarBookingResponseSchema</returns>
        public CarBookingResponseSchema CarsBookingsPost (CarCreateBookingRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CarsBookingsPost");
    
            var path = "/cars/bookings";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarsBookingsPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarsBookingsPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CarBookingResponseSchema) ApiClient.Deserialize(response.Content, typeof(CarBookingResponseSchema), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Availability 
        /// </summary>
        /// <param name="body"></param>
        /// <param name="offerId"></param>
        /// <returns>CarGetOfferAvailabilityResponse</returns>
        public CarGetOfferAvailabilityResponse CarsOfferAvailabilityOfferIdGet (CarGetOfferAvailabilityRequest body, string offerId)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CarsOfferAvailabilityOfferIdGet");
            // verify the required parameter 'offerId' is set
            if (offerId == null) throw new ApiException(400, "Missing required parameter 'offerId' when calling CarsOfferAvailabilityOfferIdGet");
    
            var path = "/cars/offer_availability/{offerId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarsOfferAvailabilityOfferIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarsOfferAvailabilityOfferIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CarGetOfferAvailabilityResponse) ApiClient.Deserialize(response.Content, typeof(CarGetOfferAvailabilityResponse), response.Headers);
        }
    
        /// <summary>
        /// Get Offer Details 
        /// </summary>
        /// <param name="offerId"></param>
        /// <returns>CarOfferDetailsSchema</returns>
        public CarOfferDetailsSchema CarsOffersOfferIdGet (string offerId)
        {
            // verify the required parameter 'offerId' is set
            if (offerId == null) throw new ApiException(400, "Missing required parameter 'offerId' when calling CarsOffersOfferIdGet");
    
            var path = "/cars/offers/{offerId}";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarsOffersOfferIdGet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarsOffersOfferIdGet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CarOfferDetailsSchema) ApiClient.Deserialize(response.Content, typeof(CarOfferDetailsSchema), response.Headers);
        }
    
        /// <summary>
        /// Search Offers 
        /// </summary>
        /// <param name="body"></param>
        /// <returns>CarOfferResponseSchema</returns>
        public CarOfferResponseSchema CarsOffersSearchPost (CarOfferRequestSchema body)
        {
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling CarsOffersSearchPost");
    
            var path = "/cars/offers/search";
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
                throw new ApiException ((int)response.StatusCode, "Error calling CarsOffersSearchPost: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling CarsOffersSearchPost: " + response.ErrorMessage, response.ErrorMessage);
    
            return (CarOfferResponseSchema) ApiClient.Deserialize(response.Content, typeof(CarOfferResponseSchema), response.Headers);
        }
    
    }
}
