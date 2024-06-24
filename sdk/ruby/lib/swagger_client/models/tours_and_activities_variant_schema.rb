=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'date'

module SwaggerClient
  class ToursAndActivitiesVariantSchema
    # Unique identifier for the tour variant.
    attr_accessor :variant_id

    # Identifier given by the supplier for the variant.
    attr_accessor :supplier_variant_id

    # Index of the variant for ordering.
    attr_accessor :variant_index

    # Tax applied to the variant price.
    attr_accessor :variant_tax

    # Price of the tour variant.
    attr_accessor :variant_price

    # Currency of the variant price.
    attr_accessor :variant_currency

    # Cancellation policies applicable to the tour variant.
    attr_accessor :variant_cancellation_policies

    # Date of the tour.
    attr_accessor :date

    # Start time of the tour.
    attr_accessor :start_time

    # Number of adults for the tour.
    attr_accessor :adults

    # Number of children for the tour.
    attr_accessor :children

    # Name of the tour variant.
    attr_accessor :variant_name

    # Description of the tour variant.
    attr_accessor :variant_description

    # Address where the tour variant takes place.
    attr_accessor :variant_address

    # Latitude coordinate of the tour location.
    attr_accessor :variant_latitude

    # Longitude coordinate of the tour location.
    attr_accessor :variant_longitude

    # Distance covered during the tour.
    attr_accessor :variant_distance

    # Metric used for distance measurement (miles or kilometers).
    attr_accessor :variant_distance_metric

    # Array of images related to the tour variant.
    attr_accessor :variant_images

    # Rating of the tour variant.
    attr_accessor :variant_rating

    # Collection of reviews for the tour variant.
    attr_accessor :variant_reviews

    # Subcategories of the tour variant.
    attr_accessor :variant_subcategories

    # Questions related to booking the tour variant.
    attr_accessor :booking_questions

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'variant_id' => :'variant_id',
        :'supplier_variant_id' => :'supplier_variant_id',
        :'variant_index' => :'variant_index',
        :'variant_tax' => :'variant_tax',
        :'variant_price' => :'variant_price',
        :'variant_currency' => :'variant_currency',
        :'variant_cancellation_policies' => :'variant_cancellation_policies',
        :'date' => :'date',
        :'start_time' => :'startTime',
        :'adults' => :'adults',
        :'children' => :'children',
        :'variant_name' => :'variant_name',
        :'variant_description' => :'variant_description',
        :'variant_address' => :'variant_address',
        :'variant_latitude' => :'variant_latitude',
        :'variant_longitude' => :'variant_longitude',
        :'variant_distance' => :'variant_distance',
        :'variant_distance_metric' => :'variant_distance_metric',
        :'variant_images' => :'variant_images',
        :'variant_rating' => :'variant_rating',
        :'variant_reviews' => :'variant_reviews',
        :'variant_subcategories' => :'variant_subcategories',
        :'booking_questions' => :'booking_questions'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'variant_id' => :'Object',
        :'supplier_variant_id' => :'Object',
        :'variant_index' => :'Object',
        :'variant_tax' => :'Object',
        :'variant_price' => :'Object',
        :'variant_currency' => :'Object',
        :'variant_cancellation_policies' => :'Object',
        :'date' => :'Object',
        :'start_time' => :'Object',
        :'adults' => :'Object',
        :'children' => :'Object',
        :'variant_name' => :'Object',
        :'variant_description' => :'Object',
        :'variant_address' => :'Object',
        :'variant_latitude' => :'Object',
        :'variant_longitude' => :'Object',
        :'variant_distance' => :'Object',
        :'variant_distance_metric' => :'Object',
        :'variant_images' => :'Object',
        :'variant_rating' => :'Object',
        :'variant_reviews' => :'Object',
        :'variant_subcategories' => :'Object',
        :'booking_questions' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::ToursAndActivitiesVariantSchema` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::ToursAndActivitiesVariantSchema`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'variant_id')
        self.variant_id = attributes[:'variant_id']
      end

      if attributes.key?(:'supplier_variant_id')
        self.supplier_variant_id = attributes[:'supplier_variant_id']
      end

      if attributes.key?(:'variant_index')
        self.variant_index = attributes[:'variant_index']
      end

      if attributes.key?(:'variant_tax')
        self.variant_tax = attributes[:'variant_tax']
      end

      if attributes.key?(:'variant_price')
        self.variant_price = attributes[:'variant_price']
      end

      if attributes.key?(:'variant_currency')
        self.variant_currency = attributes[:'variant_currency']
      end

      if attributes.key?(:'variant_cancellation_policies')
        self.variant_cancellation_policies = attributes[:'variant_cancellation_policies']
      end

      if attributes.key?(:'date')
        self.date = attributes[:'date']
      end

      if attributes.key?(:'start_time')
        self.start_time = attributes[:'start_time']
      end

      if attributes.key?(:'adults')
        self.adults = attributes[:'adults']
      end

      if attributes.key?(:'children')
        self.children = attributes[:'children']
      end

      if attributes.key?(:'variant_name')
        self.variant_name = attributes[:'variant_name']
      end

      if attributes.key?(:'variant_description')
        self.variant_description = attributes[:'variant_description']
      end

      if attributes.key?(:'variant_address')
        self.variant_address = attributes[:'variant_address']
      end

      if attributes.key?(:'variant_latitude')
        self.variant_latitude = attributes[:'variant_latitude']
      end

      if attributes.key?(:'variant_longitude')
        self.variant_longitude = attributes[:'variant_longitude']
      end

      if attributes.key?(:'variant_distance')
        self.variant_distance = attributes[:'variant_distance']
      end

      if attributes.key?(:'variant_distance_metric')
        self.variant_distance_metric = attributes[:'variant_distance_metric']
      end

      if attributes.key?(:'variant_images')
        if (value = attributes[:'variant_images']).is_a?(Array)
          self.variant_images = value
        end
      end

      if attributes.key?(:'variant_rating')
        self.variant_rating = attributes[:'variant_rating']
      end

      if attributes.key?(:'variant_reviews')
        if (value = attributes[:'variant_reviews']).is_a?(Array)
          self.variant_reviews = value
        end
      end

      if attributes.key?(:'variant_subcategories')
        if (value = attributes[:'variant_subcategories']).is_a?(Array)
          self.variant_subcategories = value
        end
      end

      if attributes.key?(:'booking_questions')
        if (value = attributes[:'booking_questions']).is_a?(Array)
          self.booking_questions = value
        end
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
          variant_id == o.variant_id &&
          supplier_variant_id == o.supplier_variant_id &&
          variant_index == o.variant_index &&
          variant_tax == o.variant_tax &&
          variant_price == o.variant_price &&
          variant_currency == o.variant_currency &&
          variant_cancellation_policies == o.variant_cancellation_policies &&
          date == o.date &&
          start_time == o.start_time &&
          adults == o.adults &&
          children == o.children &&
          variant_name == o.variant_name &&
          variant_description == o.variant_description &&
          variant_address == o.variant_address &&
          variant_latitude == o.variant_latitude &&
          variant_longitude == o.variant_longitude &&
          variant_distance == o.variant_distance &&
          variant_distance_metric == o.variant_distance_metric &&
          variant_images == o.variant_images &&
          variant_rating == o.variant_rating &&
          variant_reviews == o.variant_reviews &&
          variant_subcategories == o.variant_subcategories &&
          booking_questions == o.booking_questions
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [variant_id, supplier_variant_id, variant_index, variant_tax, variant_price, variant_currency, variant_cancellation_policies, date, start_time, adults, children, variant_name, variant_description, variant_address, variant_latitude, variant_longitude, variant_distance, variant_distance_metric, variant_images, variant_rating, variant_reviews, variant_subcategories, booking_questions].hash
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