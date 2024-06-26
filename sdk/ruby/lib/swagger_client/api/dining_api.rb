=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

module SwaggerClient
  class DiningApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Cancel Booking
    # @param body 
    # @param booking_id 
    # @param [Hash] opts the optional parameters
    # @return [DiningCancelBookingResponseSchema]
    def dining_bookings_booking_id_cancel_post(body, booking_id, opts = {})
      data, _status_code, _headers = dining_bookings_booking_id_cancel_post_with_http_info(body, booking_id, opts)
      data
    end

    # Cancel Booking
    # @param body 
    # @param booking_id 
    # @param [Hash] opts the optional parameters
    # @return [Array<(DiningCancelBookingResponseSchema, Integer, Hash)>] DiningCancelBookingResponseSchema data, response status code and response headers
    def dining_bookings_booking_id_cancel_post_with_http_info(body, booking_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: DiningApi.dining_bookings_booking_id_cancel_post ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling DiningApi.dining_bookings_booking_id_cancel_post"
      end
      # verify the required parameter 'booking_id' is set
      if @api_client.config.client_side_validation && booking_id.nil?
        fail ArgumentError, "Missing the required parameter 'booking_id' when calling DiningApi.dining_bookings_booking_id_cancel_post"
      end
      # resource path
      local_var_path = '/dining/bookings/{bookingId}/cancel'.sub('{' + 'bookingId' + '}', booking_id.to_s)

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

      return_type = opts[:return_type] || 'DiningCancelBookingResponseSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: DiningApi#dining_bookings_booking_id_cancel_post\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get Booking Details
    # @param booking_id 
    # @param [Hash] opts the optional parameters
    # @return [DiningBookingDetailsResponseSchema]
    def dining_bookings_booking_id_get(booking_id, opts = {})
      data, _status_code, _headers = dining_bookings_booking_id_get_with_http_info(booking_id, opts)
      data
    end

    # Get Booking Details
    # @param booking_id 
    # @param [Hash] opts the optional parameters
    # @return [Array<(DiningBookingDetailsResponseSchema, Integer, Hash)>] DiningBookingDetailsResponseSchema data, response status code and response headers
    def dining_bookings_booking_id_get_with_http_info(booking_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: DiningApi.dining_bookings_booking_id_get ...'
      end
      # verify the required parameter 'booking_id' is set
      if @api_client.config.client_side_validation && booking_id.nil?
        fail ArgumentError, "Missing the required parameter 'booking_id' when calling DiningApi.dining_bookings_booking_id_get"
      end
      # resource path
      local_var_path = '/dining/bookings/{bookingId}'.sub('{' + 'bookingId' + '}', booking_id.to_s)

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      return_type = opts[:return_type] || 'DiningBookingDetailsResponseSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: DiningApi#dining_bookings_booking_id_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Create Booking
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [DiningBookingResponseSchema]
    def dining_bookings_post(body, opts = {})
      data, _status_code, _headers = dining_bookings_post_with_http_info(body, opts)
      data
    end

    # Create Booking
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Array<(DiningBookingResponseSchema, Integer, Hash)>] DiningBookingResponseSchema data, response status code and response headers
    def dining_bookings_post_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: DiningApi.dining_bookings_post ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling DiningApi.dining_bookings_post"
      end
      # resource path
      local_var_path = '/dining/bookings'

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

      return_type = opts[:return_type] || 'DiningBookingResponseSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: DiningApi#dining_bookings_post\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get Offer Availability
    # @param body 
    # @param offer_id 
    # @param [Hash] opts the optional parameters
    # @return [DiningGetOfferAvailabilityResponse]
    def dining_offer_availability_offer_id_get(body, offer_id, opts = {})
      data, _status_code, _headers = dining_offer_availability_offer_id_get_with_http_info(body, offer_id, opts)
      data
    end

    # Get Offer Availability
    # @param body 
    # @param offer_id 
    # @param [Hash] opts the optional parameters
    # @return [Array<(DiningGetOfferAvailabilityResponse, Integer, Hash)>] DiningGetOfferAvailabilityResponse data, response status code and response headers
    def dining_offer_availability_offer_id_get_with_http_info(body, offer_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: DiningApi.dining_offer_availability_offer_id_get ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling DiningApi.dining_offer_availability_offer_id_get"
      end
      # verify the required parameter 'offer_id' is set
      if @api_client.config.client_side_validation && offer_id.nil?
        fail ArgumentError, "Missing the required parameter 'offer_id' when calling DiningApi.dining_offer_availability_offer_id_get"
      end
      # resource path
      local_var_path = '/dining/offer_availability/{offerId}'.sub('{' + 'offerId' + '}', offer_id.to_s)

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

      return_type = opts[:return_type] || 'DiningGetOfferAvailabilityResponse' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: DiningApi#dining_offer_availability_offer_id_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get Offer Details
    # @param offer_id 
    # @param [Hash] opts the optional parameters
    # @return [DiningOfferDetailsSchema]
    def dining_offers_offer_id_get(offer_id, opts = {})
      data, _status_code, _headers = dining_offers_offer_id_get_with_http_info(offer_id, opts)
      data
    end

    # Get Offer Details
    # @param offer_id 
    # @param [Hash] opts the optional parameters
    # @return [Array<(DiningOfferDetailsSchema, Integer, Hash)>] DiningOfferDetailsSchema data, response status code and response headers
    def dining_offers_offer_id_get_with_http_info(offer_id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: DiningApi.dining_offers_offer_id_get ...'
      end
      # verify the required parameter 'offer_id' is set
      if @api_client.config.client_side_validation && offer_id.nil?
        fail ArgumentError, "Missing the required parameter 'offer_id' when calling DiningApi.dining_offers_offer_id_get"
      end
      # resource path
      local_var_path = '/dining/offers/{offerId}'.sub('{' + 'offerId' + '}', offer_id.to_s)

      # query parameters
      query_params = opts[:query_params] || {}

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      return_type = opts[:return_type] || 'DiningOfferDetailsSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: DiningApi#dining_offers_offer_id_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Search Offers
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [DiningOfferResponseSchema]
    def dining_offers_search_post(body, opts = {})
      data, _status_code, _headers = dining_offers_search_post_with_http_info(body, opts)
      data
    end

    # Search Offers
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Array<(DiningOfferResponseSchema, Integer, Hash)>] DiningOfferResponseSchema data, response status code and response headers
    def dining_offers_search_post_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: DiningApi.dining_offers_search_post ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling DiningApi.dining_offers_search_post"
      end
      # resource path
      local_var_path = '/dining/offers/search'

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

      return_type = opts[:return_type] || 'DiningOfferResponseSchema' 

      auth_names = opts[:auth_names] || ['apiKeyAuth']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: DiningApi#dining_offers_search_post\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
