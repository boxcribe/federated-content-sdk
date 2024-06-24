=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

module SwaggerClient
  class LogsApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Get logs
    # @param [Hash] opts the optional parameters
    # @option opts [String] :sort sort by query in the form of field:desc/asc (ex. name:asc)
    # @option opts [Integer] :limit Maximum number of logs
    # @option opts [Integer] :page Page number (default to 1)
    # @return [InlineResponse2008]
    def logs_get(opts = {})
      data, _status_code, _headers = logs_get_with_http_info(opts)
      data
    end

    # Get logs
    # @param [Hash] opts the optional parameters
    # @option opts [String] :sort sort by query in the form of field:desc/asc (ex. name:asc)
    # @option opts [Integer] :limit Maximum number of logs
    # @option opts [Integer] :page Page number
    # @return [Array<(InlineResponse2008, Integer, Hash)>] InlineResponse2008 data, response status code and response headers
    def logs_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LogsApi.logs_get ...'
      end
      # resource path
      local_var_path = '/logs'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'sort'] = opts[:'sort'] if !opts[:'sort'].nil?
      query_params[:'limit'] = opts[:'limit'] if !opts[:'limit'].nil?
      query_params[:'page'] = opts[:'page'] if !opts[:'page'].nil?

      # header parameters
      header_params = opts[:header_params] || {}
      # HTTP header 'Accept' (if needed)
      header_params['Accept'] = @api_client.select_header_accept(['application/json'])

      # form parameters
      form_params = opts[:form_params] || {}

      # http body (model)
      post_body = opts[:body] 

      return_type = opts[:return_type] || 'InlineResponse2008' 

      auth_names = opts[:auth_names] || ['bearerAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LogsApi#logs_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Delete log
    # @param id Log id
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def logs_id_delete(id, opts = {})
      logs_id_delete_with_http_info(id, opts)
      nil
    end

    # Delete log
    # @param id Log id
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def logs_id_delete_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LogsApi.logs_id_delete ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling LogsApi.logs_id_delete"
      end
      # resource path
      local_var_path = '/logs/{id}'.sub('{' + 'id' + '}', id.to_s)

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

      return_type = opts[:return_type] 

      auth_names = opts[:auth_names] || ['bearerAuth']
      data, status_code, headers = @api_client.call_api(:DELETE, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LogsApi#logs_id_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get log
    # @param id Log id
    # @param [Hash] opts the optional parameters
    # @return [Log]
    def logs_id_get(id, opts = {})
      data, _status_code, _headers = logs_id_get_with_http_info(id, opts)
      data
    end

    # Get log
    # @param id Log id
    # @param [Hash] opts the optional parameters
    # @return [Array<(Log, Integer, Hash)>] Log data, response status code and response headers
    def logs_id_get_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LogsApi.logs_id_get ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling LogsApi.logs_id_get"
      end
      # resource path
      local_var_path = '/logs/{id}'.sub('{' + 'id' + '}', id.to_s)

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

      return_type = opts[:return_type] || 'Log' 

      auth_names = opts[:auth_names] || ['bearerAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LogsApi#logs_id_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Update log
    # @param body 
    # @param id Log id
    # @param [Hash] opts the optional parameters
    # @return [Log]
    def logs_id_patch(body, id, opts = {})
      data, _status_code, _headers = logs_id_patch_with_http_info(body, id, opts)
      data
    end

    # Update log
    # @param body 
    # @param id Log id
    # @param [Hash] opts the optional parameters
    # @return [Array<(Log, Integer, Hash)>] Log data, response status code and response headers
    def logs_id_patch_with_http_info(body, id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LogsApi.logs_id_patch ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling LogsApi.logs_id_patch"
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling LogsApi.logs_id_patch"
      end
      # resource path
      local_var_path = '/logs/{id}'.sub('{' + 'id' + '}', id.to_s)

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

      return_type = opts[:return_type] || 'Log' 

      auth_names = opts[:auth_names] || ['bearerAuth']
      data, status_code, headers = @api_client.call_api(:PATCH, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LogsApi#logs_id_patch\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Create log
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Log]
    def logs_post(body, opts = {})
      data, _status_code, _headers = logs_post_with_http_info(body, opts)
      data
    end

    # Create log
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Log, Integer, Hash)>] Log data, response status code and response headers
    def logs_post_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: LogsApi.logs_post ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling LogsApi.logs_post"
      end
      # resource path
      local_var_path = '/logs'

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

      return_type = opts[:return_type] || 'Log' 

      auth_names = opts[:auth_names] || ['bearerAuth']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: LogsApi#logs_post\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
