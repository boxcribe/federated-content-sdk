=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

module SwaggerClient
  class SchemasApi
    attr_accessor :api_client

    def initialize(api_client = ApiClient.default)
      @api_client = api_client
    end
    # Get schemas
    # Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :tenant Get all schemas for a Tenant ID
    # @option opts [String] :category Get all schemas for a Category ID
    # @option opts [String] :sort Sort by query in the form of field:desc/asc (ex. name:asc)
    # @option opts [Integer] :limit Maximum number of schemas
    # @option opts [Integer] :page Page number (default to 1)
    # @return [InlineResponse20010]
    def schemas_get(opts = {})
      data, _status_code, _headers = schemas_get_with_http_info(opts)
      data
    end

    # Get schemas
    # Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :tenant Get all schemas for a Tenant ID
    # @option opts [String] :category Get all schemas for a Category ID
    # @option opts [String] :sort Sort by query in the form of field:desc/asc (ex. name:asc)
    # @option opts [Integer] :limit Maximum number of schemas
    # @option opts [Integer] :page Page number
    # @return [Array<(InlineResponse20010, Integer, Hash)>] InlineResponse20010 data, response status code and response headers
    def schemas_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SchemasApi.schemas_get ...'
      end
      # resource path
      local_var_path = '/schemas'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'tenant'] = opts[:'tenant'] if !opts[:'tenant'].nil?
      query_params[:'category'] = opts[:'category'] if !opts[:'category'].nil?
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

      return_type = opts[:return_type] || 'InlineResponse20010' 

      auth_names = opts[:auth_names] || ['bearerAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: SchemasApi#schemas_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get schemas grouped by endpoint
    # Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :tenant Get all schemas for a Tenant ID
    # @option opts [String] :category Get all schemas for a Category ID
    # @option opts [String] :sort Sort by query in the form of field:desc/asc (ex. endpoint:asc)
    # @option opts [Integer] :limit Maximum number of schemas
    # @option opts [Integer] :page Page number (default to 1)
    # @return [InlineResponse20011]
    def schemas_grouped_by_endpoint_get(opts = {})
      data, _status_code, _headers = schemas_grouped_by_endpoint_get_with_http_info(opts)
      data
    end

    # Get schemas grouped by endpoint
    # Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.
    # @param [Hash] opts the optional parameters
    # @option opts [String] :tenant Get all schemas for a Tenant ID
    # @option opts [String] :category Get all schemas for a Category ID
    # @option opts [String] :sort Sort by query in the form of field:desc/asc (ex. endpoint:asc)
    # @option opts [Integer] :limit Maximum number of schemas
    # @option opts [Integer] :page Page number
    # @return [Array<(InlineResponse20011, Integer, Hash)>] InlineResponse20011 data, response status code and response headers
    def schemas_grouped_by_endpoint_get_with_http_info(opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SchemasApi.schemas_grouped_by_endpoint_get ...'
      end
      # resource path
      local_var_path = '/schemas/groupedByEndpoint'

      # query parameters
      query_params = opts[:query_params] || {}
      query_params[:'tenant'] = opts[:'tenant'] if !opts[:'tenant'].nil?
      query_params[:'category'] = opts[:'category'] if !opts[:'category'].nil?
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

      return_type = opts[:return_type] || 'InlineResponse20011' 

      auth_names = opts[:auth_names] || ['bearerAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: SchemasApi#schemas_grouped_by_endpoint_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Delete schema
    # @param id Schema id
    # @param [Hash] opts the optional parameters
    # @return [nil]
    def schemas_id_delete(id, opts = {})
      schemas_id_delete_with_http_info(id, opts)
      nil
    end

    # Delete schema
    # @param id Schema id
    # @param [Hash] opts the optional parameters
    # @return [Array<(nil, Integer, Hash)>] nil, response status code and response headers
    def schemas_id_delete_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SchemasApi.schemas_id_delete ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling SchemasApi.schemas_id_delete"
      end
      # resource path
      local_var_path = '/schemas/{id}'.sub('{' + 'id' + '}', id.to_s)

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
        @api_client.config.logger.debug "API called: SchemasApi#schemas_id_delete\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Get schema
    # @param id Schema id
    # @param [Hash] opts the optional parameters
    # @return [Schema]
    def schemas_id_get(id, opts = {})
      data, _status_code, _headers = schemas_id_get_with_http_info(id, opts)
      data
    end

    # Get schema
    # @param id Schema id
    # @param [Hash] opts the optional parameters
    # @return [Array<(Schema, Integer, Hash)>] Schema data, response status code and response headers
    def schemas_id_get_with_http_info(id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SchemasApi.schemas_id_get ...'
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling SchemasApi.schemas_id_get"
      end
      # resource path
      local_var_path = '/schemas/{id}'.sub('{' + 'id' + '}', id.to_s)

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

      return_type = opts[:return_type] || 'Schema' 

      auth_names = opts[:auth_names] || ['bearerAuth']
      data, status_code, headers = @api_client.call_api(:GET, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: SchemasApi#schemas_id_get\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Update schema
    # @param body 
    # @param id Schema id
    # @param [Hash] opts the optional parameters
    # @return [Schema]
    def schemas_id_patch(body, id, opts = {})
      data, _status_code, _headers = schemas_id_patch_with_http_info(body, id, opts)
      data
    end

    # Update schema
    # @param body 
    # @param id Schema id
    # @param [Hash] opts the optional parameters
    # @return [Array<(Schema, Integer, Hash)>] Schema data, response status code and response headers
    def schemas_id_patch_with_http_info(body, id, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SchemasApi.schemas_id_patch ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling SchemasApi.schemas_id_patch"
      end
      # verify the required parameter 'id' is set
      if @api_client.config.client_side_validation && id.nil?
        fail ArgumentError, "Missing the required parameter 'id' when calling SchemasApi.schemas_id_patch"
      end
      # resource path
      local_var_path = '/schemas/{id}'.sub('{' + 'id' + '}', id.to_s)

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

      return_type = opts[:return_type] || 'Schema' 

      auth_names = opts[:auth_names] || ['bearerAuth']
      data, status_code, headers = @api_client.call_api(:PATCH, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: SchemasApi#schemas_id_patch\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
    # Create schema
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Schema]
    def schemas_post(body, opts = {})
      data, _status_code, _headers = schemas_post_with_http_info(body, opts)
      data
    end

    # Create schema
    # @param body 
    # @param [Hash] opts the optional parameters
    # @return [Array<(Schema, Integer, Hash)>] Schema data, response status code and response headers
    def schemas_post_with_http_info(body, opts = {})
      if @api_client.config.debugging
        @api_client.config.logger.debug 'Calling API: SchemasApi.schemas_post ...'
      end
      # verify the required parameter 'body' is set
      if @api_client.config.client_side_validation && body.nil?
        fail ArgumentError, "Missing the required parameter 'body' when calling SchemasApi.schemas_post"
      end
      # resource path
      local_var_path = '/schemas'

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

      return_type = opts[:return_type] || 'Schema' 

      auth_names = opts[:auth_names] || ['bearerAuth']
      data, status_code, headers = @api_client.call_api(:POST, local_var_path,
        :header_params => header_params,
        :query_params => query_params,
        :form_params => form_params,
        :body => post_body,
        :auth_names => auth_names,
        :return_type => return_type)

      if @api_client.config.debugging
        @api_client.config.logger.debug "API called: SchemasApi#schemas_post\nData: #{data.inspect}\nStatus code: #{status_code}\nHeaders: #{headers}"
      end
      return data, status_code, headers
    end
  end
end
