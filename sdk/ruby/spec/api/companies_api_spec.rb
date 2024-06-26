=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::CompaniesApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'CompaniesApi' do
  before do
    # run before each test
    @instance = SwaggerClient::CompaniesApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of CompaniesApi' do
    it 'should create an instance of CompaniesApi' do
      expect(@instance).to be_instance_of(SwaggerClient::CompaniesApi)
    end
  end

  # unit tests for companies_get
  # Get companies
  # @param [Hash] opts the optional parameters
  # @option opts [String] :sort sort by query in the form of field:desc/asc (ex. name:asc)
  # @option opts [Integer] :limit Maximum number of companies
  # @option opts [Integer] :page Page number
  # @return [InlineResponse2005]
  describe 'companies_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for companies_id_delete
  # Delete company
  # @param id Company id
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'companies_id_delete test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for companies_id_get
  # Get company
  # @param id Company id
  # @param [Hash] opts the optional parameters
  # @return [Company]
  describe 'companies_id_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for companies_id_patch
  # Update company
  # @param body 
  # @param id Company id
  # @param [Hash] opts the optional parameters
  # @return [Company]
  describe 'companies_id_patch test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for companies_post
  # Create company
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [Company]
  describe 'companies_post test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end
