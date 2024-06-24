=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'date'

module SwaggerClient
  # Offer Request Normalized Boxcribe API Response
  class OfferResultNormalizedResponse
    attr_accessor :ids

    attr_accessor :category

    attr_accessor :index

    attr_accessor :name

    attr_accessor :description

    attr_accessor :address

    attr_accessor :latitude

    attr_accessor :longitude

    attr_accessor :distance

    attr_accessor :distance_unit_of_measure

    attr_accessor :pictures

    attr_accessor :tax

    attr_accessor :price

    attr_accessor :currency

    attr_accessor :price_description

    attr_accessor :free_cancellation

    attr_accessor :rating

    attr_accessor :status

    attr_accessor :ohter_attributes

    attr_accessor :offer_rooms

    attr_accessor :offer_variants

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'ids' => :'ids',
        :'category' => :'category',
        :'index' => :'index',
        :'name' => :'name',
        :'description' => :'description',
        :'address' => :'address',
        :'latitude' => :'latitude',
        :'longitude' => :'longitude',
        :'distance' => :'distance',
        :'distance_unit_of_measure' => :'distanceUnitOfMeasure',
        :'pictures' => :'pictures',
        :'tax' => :'tax',
        :'price' => :'price',
        :'currency' => :'currency',
        :'price_description' => :'priceDescription',
        :'free_cancellation' => :'freeCancellation',
        :'rating' => :'rating',
        :'status' => :'status',
        :'ohter_attributes' => :'ohter_attributes',
        :'offer_rooms' => :'offer_rooms',
        :'offer_variants' => :'offer_variants'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'ids' => :'Object',
        :'category' => :'Object',
        :'index' => :'Object',
        :'name' => :'Object',
        :'description' => :'Object',
        :'address' => :'Object',
        :'latitude' => :'Object',
        :'longitude' => :'Object',
        :'distance' => :'Object',
        :'distance_unit_of_measure' => :'Object',
        :'pictures' => :'Object',
        :'tax' => :'Object',
        :'price' => :'Object',
        :'currency' => :'Object',
        :'price_description' => :'Object',
        :'free_cancellation' => :'Object',
        :'rating' => :'Object',
        :'status' => :'Object',
        :'ohter_attributes' => :'Object',
        :'offer_rooms' => :'Object',
        :'offer_variants' => :'Object'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
      ])
    end
  
    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::OfferResultNormalizedResponse` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::OfferResultNormalizedResponse`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'ids')
        self.ids = attributes[:'ids']
      end

      if attributes.key?(:'category')
        self.category = attributes[:'category']
      end

      if attributes.key?(:'index')
        self.index = attributes[:'index']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'description')
        self.description = attributes[:'description']
      end

      if attributes.key?(:'address')
        self.address = attributes[:'address']
      end

      if attributes.key?(:'latitude')
        self.latitude = attributes[:'latitude']
      end

      if attributes.key?(:'longitude')
        self.longitude = attributes[:'longitude']
      end

      if attributes.key?(:'distance')
        self.distance = attributes[:'distance']
      end

      if attributes.key?(:'distance_unit_of_measure')
        self.distance_unit_of_measure = attributes[:'distance_unit_of_measure']
      end

      if attributes.key?(:'pictures')
        if (value = attributes[:'pictures']).is_a?(Array)
          self.pictures = value
        end
      end

      if attributes.key?(:'tax')
        self.tax = attributes[:'tax']
      end

      if attributes.key?(:'price')
        self.price = attributes[:'price']
      end

      if attributes.key?(:'currency')
        self.currency = attributes[:'currency']
      end

      if attributes.key?(:'price_description')
        self.price_description = attributes[:'price_description']
      end

      if attributes.key?(:'free_cancellation')
        self.free_cancellation = attributes[:'free_cancellation']
      end

      if attributes.key?(:'rating')
        self.rating = attributes[:'rating']
      end

      if attributes.key?(:'status')
        self.status = attributes[:'status']
      end

      if attributes.key?(:'ohter_attributes')
        self.ohter_attributes = attributes[:'ohter_attributes']
      end

      if attributes.key?(:'offer_rooms')
        self.offer_rooms = attributes[:'offer_rooms']
      end

      if attributes.key?(:'offer_variants')
        self.offer_variants = attributes[:'offer_variants']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          ids == o.ids &&
          category == o.category &&
          index == o.index &&
          name == o.name &&
          description == o.description &&
          address == o.address &&
          latitude == o.latitude &&
          longitude == o.longitude &&
          distance == o.distance &&
          distance_unit_of_measure == o.distance_unit_of_measure &&
          pictures == o.pictures &&
          tax == o.tax &&
          price == o.price &&
          currency == o.currency &&
          price_description == o.price_description &&
          free_cancellation == o.free_cancellation &&
          rating == o.rating &&
          status == o.status &&
          ohter_attributes == o.ohter_attributes &&
          offer_rooms == o.offer_rooms &&
          offer_variants == o.offer_variants
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [ids, category, index, name, description, address, latitude, longitude, distance, distance_unit_of_measure, pictures, tax, price, currency, price_description, free_cancellation, rating, status, ohter_attributes, offer_rooms, offer_variants].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def self.build_from_hash(attributes)
      new.build_from_hash(attributes)
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      self.class.openapi_types.each_pair do |key, type|
        if type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the attribute
          # is documented as an array but the input is not
          if attributes[self.class.attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[self.class.attribute_map[key]].map { |v| _deserialize($1, v) })
          end
        elsif !attributes[self.class.attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[self.class.attribute_map[key]]))
        elsif attributes[self.class.attribute_map[key]].nil? && self.class.openapi_nullable.include?(key)
          self.send("#{key}=", nil)
        end
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :DateTime
        DateTime.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :Boolean
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        SwaggerClient.const_get(type).build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash
      hash = {}
      self.class.attribute_map.each_pair do |attr, param|
        value = self.send(attr)
        if value.nil?
          is_nullable = self.class.openapi_nullable.include?(attr)
          next if !is_nullable || (is_nullable && !instance_variable_defined?(:"@#{attr}"))
        end

        hash[param] = _to_hash(value)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value)
      if value.is_a?(Array)
        value.compact.map { |v| _to_hash(v) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash
      else
        value
      end
    end  end
end
