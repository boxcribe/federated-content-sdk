=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'spec_helper'
require 'json'

# Unit tests for SwaggerClient::UsersApi
# Automatically generated by swagger-codegen (github.com/swagger-api/swagger-codegen)
# Please update as you see appropriate
describe 'UsersApi' do
  before do
    # run before each test
    @instance = SwaggerClient::UsersApi.new
  end

  after do
    # run after each test
  end

  describe 'test an instance of UsersApi' do
    it 'should create an instance of UsersApi' do
      expect(@instance).to be_instance_of(SwaggerClient::UsersApi)
    end
  end

  # unit tests for users_get
  # Get users
  # @param [Hash] opts the optional parameters
  # @option opts [String] :sort sort by query in the form of field:desc/asc (ex. name:asc)
  # @option opts [Integer] :limit Maximum number of admins
  # @option opts [Integer] :page Page number
  # @return [InlineResponse20013]
  describe 'users_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for users_post
  # Create User
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [InlineResponse201]
  describe 'users_post test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for usersuser_id_delete
  # Delete User
  # @param [Hash] opts the optional parameters
  # @return [nil]
  describe 'usersuser_id_delete test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for usersuser_id_get
  # Get Users
  # @param id User id
  # @param [Hash] opts the optional parameters
  # @return [InlineResponse201]
  describe 'usersuser_id_get test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

  # unit tests for usersuser_id_patch
  # Update User
  # @param body 
  # @param [Hash] opts the optional parameters
  # @return [InlineResponse201]
  describe 'usersuser_id_patch test' do
    it 'should work' do
      # assertion here. ref: https://www.relishapp.com/rspec/rspec-expectations/docs/built-in-matchers
    end
  end

end