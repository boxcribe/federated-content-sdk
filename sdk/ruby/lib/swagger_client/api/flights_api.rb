=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

module SwaggerClient
  class FlightsApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Cancel Booking
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [FlightCancelBookingResponseSchema]
    def flights_bookings_booking_id_cancel_post(body, opts = {})
      data, _status_code, _headers = flights_bookings_booking_id_cancel_post_with_http_info(body, opts)
      data
    end

    # Cancel Booking
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Array<(FlightCancelBookingResponseSchema, Integer, Hash)>] FlightCancelBookingResponseSchema data, response status code and response headers
    def flights_bookings_booking_id_cancel_post_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: FlightsApi.flights_bookings_booking_id_cancel_post ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling FlightsApi.flights_bookings_booking_id_cancel_post"
      end
      # resource path
      local_var_path = '/flights/bookings/{bookingId}/cancel'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(body) 

      return_type = opts[:return_type] || 'FlightCancelBookingResponseSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: FlightsApi#flights_bookings_booking_id_cancel_post\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get Booking Details
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [FlightGetBookingDetailsResponseSchema]
    def flights_bookings_booking_id_get(body, opts = {})
      data, _status_code, _headers = flights_bookings_booking_id_get_with_http_info(body, opts)
      data
    end

    # Get Booking Details
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Array<(FlightGetBookingDetailsResponseSchema, Integer, Hash)>] FlightGetBookingDetailsResponseSchema data, response status code and response headers
    def flights_bookings_booking_id_get_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: FlightsApi.flights_bookings_booking_id_get ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling FlightsApi.flights_bookings_booking_id_get"
      end
      # resource path
      local_var_path = '/flights/bookings/{bookingId}'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(body) 

      return_type = opts[:return_type] || 'FlightGetBookingDetailsResponseSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: FlightsApi#flights_bookings_booking_id_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Create Booking
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [FlightBookingResponseSchema]
    def flights_bookings_post(body, opts = {})
      data, _status_code, _headers = flights_bookings_post_with_http_info(body, opts)
      data
    end

    # Create Booking
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Array<(FlightBookingResponseSchema, Integer, Hash)>] FlightBookingResponseSchema data, response status code and response headers
    def flights_bookings_post_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: FlightsApi.flights_bookings_post ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling FlightsApi.flights_bookings_post"
      end
      # resource path
      local_var_path = '/flights/bookings'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(body) 

      return_type = opts[:return_type] || 'FlightBookingResponseSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: FlightsApi#flights_bookings_post\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get Offer Details
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [FlightOfferDetailsResponseSchema]
    def flights_offers_offer_id_get(body, opts = {})
      data, _status_code, _headers = flights_offers_offer_id_get_with_http_info(body, opts)
      data
    end

    # Get Offer Details
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Array<(FlightOfferDetailsResponseSchema, Integer, Hash)>] FlightOfferDetailsResponseSchema data, response status code and response headers
    def flights_offers_offer_id_get_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: FlightsApi.flights_offers_offer_id_get ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling FlightsApi.flights_offers_offer_id_get"
      end
      # resource path
      local_var_path = '/flights/offers/{offerId}'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(body) 

      return_type = opts[:return_type] || 'FlightOfferDetailsResponseSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: FlightsApi#flights_offers_offer_id_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get Offer Seatmaps
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [FlightOfferSeatmapsResponseSchema]
    def flights_offers_offer_id_seatmaps_get(body, opts = {})
      data, _status_code, _headers = flights_offers_offer_id_seatmaps_get_with_http_info(body, opts)
      data
    end

    # Get Offer Seatmaps
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Array<(FlightOfferSeatmapsResponseSchema, Integer, Hash)>] FlightOfferSeatmapsResponseSchema data, response status code and response headers
    def flights_offers_offer_id_seatmaps_get_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: FlightsApi.flights_offers_offer_id_seatmaps_get ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling FlightsApi.flights_offers_offer_id_seatmaps_get"
      end
      # resource path
      local_var_path = '/flights/offers/{offerId}/seatmaps'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(body) 

      return_type = opts[:return_type] || 'FlightOfferSeatmapsResponseSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: FlightsApi#flights_offers_offer_id_seatmaps_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Search Offers
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [FlightOfferResponseSchema]
    def flights_offers_search_post(body, opts = {})
      data, _status_code, _headers = flights_offers_search_post_with_http_info(body, opts)
      data
    end

    # Search Offers
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Array<(FlightOfferResponseSchema, Integer, Hash)>] FlightOfferResponseSchema data, response status code and response headers
    def flights_offers_search_post_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: FlightsApi.flights_offers_search_post ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling FlightsApi.flights_offers_search_post"
      end
      # resource path
      local_var_path = '/flights/offers/search'

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])
      # HTTP header 'Content-Type'
      header_params['Content-Type'] = @api_client.select_header_content_type(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] || @api_client.object_to_http_body(body) 

      return_type = opts[:return_type] || 'FlightOfferResponseSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: FlightsApi#flights_offers_search_post\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end