=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'date'

module SwaggerClient
  class ToursAndActivitiesOfferResponseItemSchema
    # Identifier of the individual offer.
    attr_accessor :offer_id

    # Identifier provided by the supplier for the offer.
    attr_accessor :supplier_offer_id

    # Index of the offer for ordering.
    attr_accessor :offer_index

    # Tax applied on the offer.
    attr_accessor :offer_tax

    # Price of the offer.
    attr_accessor :offer_price

    # Currency of the offer price.
    attr_accessor :offer_currency

    # Cancellation policies applicable to the offer.
    attr_accessor :offer_cancelation_policies

    # Date of the tour.
    attr_accessor :date

    # Number of adults attending.
    attr_accessor :adults

    # Number of children attending.
    attr_accessor :children

    # Name of the tour.
    attr_accessor :tour_name

    # Description of the tour.
    attr_accessor :tour_description

    # Address where the tour will take place.
    attr_accessor :tour_address

    # Latitude for the tour location.
    attr_accessor :tour_latitude

    # Longitude for the tour location.
    attr_accessor :tour_longitude

    # Distance covered by the tour.
    attr_accessor :tour_distance

    # Metric for measuring distance (miles or kilometers).
    attr_accessor :tour_distance_metric

    # Array of images related to the tour.
    attr_accessor :tour_images

    # Rating of the tour.
    attr_accessor :tour_rating

    # Array of reviews for the tour.
    attr_accessor :tour_reviews

    # Subcategories of the tour.
    attr_accessor :tour_subcategories

    # Questions related to booking the tour.
    attr_accessor :booking_questions

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'offer_id' => :'offer_id',
        :'supplier_offer_id' => :'supplier_offer_id',
        :'offer_index' => :'offer_index',
        :'offer_tax' => :'offer_tax',
        :'offer_price' => :'offer_price',
        :'offer_currency' => :'offer_currency',
        :'offer_cancelation_policies' => :'offer_cancelation_policies',
        :'date' => :'date',
        :'adults' => :'adults',
        :'children' => :'children',
        :'tour_name' => :'tour_name',
        :'tour_description' => :'tour_description',
        :'tour_address' => :'tour_address',
        :'tour_latitude' => :'tour_latitude',
        :'tour_longitude' => :'tour_longitude',
        :'tour_distance' => :'tour_distance',
        :'tour_distance_metric' => :'tour_distance_metric',
        :'tour_images' => :'tour_images',
        :'tour_rating' => :'tour_rating',
        :'tour_reviews' => :'tour_reviews',
        :'tour_subcategories' => :'tour_subcategories',
        :'booking_questions' => :'booking_questions'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'offer_id' => :'Object',
        :'supplier_offer_id' => :'Object',
        :'offer_index' => :'Object',
        :'offer_tax' => :'Object',
        :'offer_price' => :'Object',
        :'offer_currency' => :'Object',
        :'offer_cancelation_policies' => :'Object',
        :'date' => :'Object',
        :'adults' => :'Object',
        :'children' => :'Object',
        :'tour_name' => :'Object',
        :'tour_description' => :'Object',
        :'tour_address' => :'Object',
        :'tour_latitude' => :'Object',
        :'tour_longitude' => :'Object',
        :'tour_distance' => :'Object',
        :'tour_distance_metric' => :'Object',
        :'tour_images' => :'Object',
        :'tour_rating' => :'Object',
        :'tour_reviews' => :'Object',
        :'tour_subcategories' => :'Object',
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::ToursAndActivitiesOfferResponseItemSchema` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::ToursAndActivitiesOfferResponseItemSchema`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'offer_id')
        self.offer_id = attributes[:'offer_id']
      end

      if attributes.key?(:'supplier_offer_id')
        self.supplier_offer_id = attributes[:'supplier_offer_id']
      end

      if attributes.key?(:'offer_index')
        self.offer_index = attributes[:'offer_index']
      end

      if attributes.key?(:'offer_tax')
        self.offer_tax = attributes[:'offer_tax']
      end

      if attributes.key?(:'offer_price')
        self.offer_price = attributes[:'offer_price']
      end

      if attributes.key?(:'offer_currency')
        self.offer_currency = attributes[:'offer_currency']
      end

      if attributes.key?(:'offer_cancelation_policies')
        self.offer_cancelation_policies = attributes[:'offer_cancelation_policies']
      end

      if attributes.key?(:'date')
        self.date = attributes[:'date']
      end

      if attributes.key?(:'adults')
        self.adults = attributes[:'adults']
      end

      if attributes.key?(:'children')
        self.children = attributes[:'children']
      end

      if attributes.key?(:'tour_name')
        self.tour_name = attributes[:'tour_name']
      end

      if attributes.key?(:'tour_description')
        self.tour_description = attributes[:'tour_description']
      end

      if attributes.key?(:'tour_address')
        self.tour_address = attributes[:'tour_address']
      end

      if attributes.key?(:'tour_latitude')
        self.tour_latitude = attributes[:'tour_latitude']
      end

      if attributes.key?(:'tour_longitude')
        self.tour_longitude = attributes[:'tour_longitude']
      end

      if attributes.key?(:'tour_distance')
        self.tour_distance = attributes[:'tour_distance']
      end

      if attributes.key?(:'tour_distance_metric')
        self.tour_distance_metric = attributes[:'tour_distance_metric']
      end

      if attributes.key?(:'tour_images')
        if (value = attributes[:'tour_images']).is_a?(Array)
          self.tour_images = value
        end
      end

      if attributes.key?(:'tour_rating')
        self.tour_rating = attributes[:'tour_rating']
      end

      if attributes.key?(:'tour_reviews')
        if (value = attributes[:'tour_reviews']).is_a?(Array)
          self.tour_reviews = value
        end
      end

      if attributes.key?(:'tour_subcategories')
        if (value = attributes[:'tour_subcategories']).is_a?(Array)
          self.tour_subcategories = value
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
          offer_id == o.offer_id &&
          supplier_offer_id == o.supplier_offer_id &&
          offer_index == o.offer_index &&
          offer_tax == o.offer_tax &&
          offer_price == o.offer_price &&
          offer_currency == o.offer_currency &&
          offer_cancelation_policies == o.offer_cancelation_policies &&
          date == o.date &&
          adults == o.adults &&
          children == o.children &&
          tour_name == o.tour_name &&
          tour_description == o.tour_description &&
          tour_address == o.tour_address &&
          tour_latitude == o.tour_latitude &&
          tour_longitude == o.tour_longitude &&
          tour_distance == o.tour_distance &&
          tour_distance_metric == o.tour_distance_metric &&
          tour_images == o.tour_images &&
          tour_rating == o.tour_rating &&
          tour_reviews == o.tour_reviews &&
          tour_subcategories == o.tour_subcategories &&
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
      [offer_id, supplier_offer_id, offer_index, offer_tax, offer_price, offer_currency, offer_cancelation_policies, date, adults, children, tour_name, tour_description, tour_address, tour_latitude, tour_longitude, tour_distance, tour_distance_metric, tour_images, tour_rating, tour_reviews, tour_subcategories, booking_questions].hash
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