=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'spec_helper'
require 'json'
require 'date'

# Unit tests for SwaggerClient::EventGetOfferAvailabilityResponse
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'EventGetOfferAvailabilityResponse' do
  before do
    # run before each test
    @instance = SwaggerClient::EventGetOfferAvailabilityResponse.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of EventGetOfferAvailabilityResponse' do
    it 'should create an instance of EventGetOfferAvailabilityResponse' do
      expect(@instance).to be_instance_of(SwaggerClient::EventGetOfferAvailabilityResponse)
    end
  end
  describe 'test attribute "tickets"' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
