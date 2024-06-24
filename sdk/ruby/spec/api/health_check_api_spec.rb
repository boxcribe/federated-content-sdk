=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::HealthCheckApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'HealthCheckApi' do
  before do
    # run before each test
    @instance = SwaggerClient::HealthCheckApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of HealthCheckApi' do
    it 'should create an instance of HealthCheckApi' do
      expect(@instance).to be_instance_of(SwaggerClient::HealthCheckApi)
    end
  end

  # unit tests for help_get
  # Help
  # Returns a message indicating that the API is up and running.
  # @param [Hash] opts the optional parameters
  # @return [InlineResponse2001]
  describe 'help_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end