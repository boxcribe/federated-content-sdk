=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::LogsApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'LogsApi' do
  before do
    # run before each test
    @instance = SwaggerClient::LogsApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of LogsApi' do
    it 'should create an instance of LogsApi' do
      expect(@instance).to be_instance_of(SwaggerClient::LogsApi)
    end
  end

  # unit tests for logs_get
  # Get logs
  # @param [Hash] opts the optional parameters
  # @option opts [String] :sort sort by query in the form of field:desc/asc (ex. name:asc)
  # @option opts [Integer] :limit Maximum number of logs
  # @option opts [Integer] :page Page number
  # @return [InlineResponse2008]
  describe 'logs_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for logs_id_delete
  # Delete log
  # @param id Log id
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'logs_id_delete test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for logs_id_get
  # Get log
  # @param id Log id
  # @param [Hash] opts the optional parameters
  # @return [Log]
  describe 'logs_id_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for logs_id_patch
  # Update log
  # @param body 
  # @param id Log id
  # @param [Hash] opts the optional parameters
  # @return [Log]
  describe 'logs_id_patch test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for logs_post
  # Create log
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [Log]
  describe 'logs_post test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
