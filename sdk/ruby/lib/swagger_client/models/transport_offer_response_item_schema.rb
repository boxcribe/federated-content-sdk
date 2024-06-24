=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'date'

module SwaggerClient
  class TransportOfferResponseItemSchema
    # Unique identifier of the offer.
    attr_accessor :offer_id

    # Unique identifier for the supplier’s offer.
    attr_accessor :supplier_offer_id

    # Index number of the offer.
    attr_accessor :offer_index

    # Applicable taxes on the offer.
    attr_accessor :offer_tax

    # Total price of the offer.
    attr_accessor :offer_price

    # Currency of the offer.
    attr_accessor :offer_currency

    # Cancellation policies of the offer.
    attr_accessor :offer_cancelation_policies

    # Date when the transport is scheduled to be picked up.
    attr_accessor :pickup_date

    # Time when the transport is scheduled to be picked up.
    attr_accessor :pickup_time

    # Number of adults included in the transport offer.
    attr_accessor :adults

    # Number of children included in the transport offer.
    attr_accessor :children

    # Date when the transport is scheduled to be returned.
    attr_accessor :return_date

    # Time when the transport is scheduled to be returned.
    attr_accessor :return_time

    # Name of the transport provider or vehicle.
    attr_accessor :transport_name

    # Description of the transport.
    attr_accessor :transport_description

    # Address where the transport is located or where it operates.
    attr_accessor :transport_address

    # Latitude coordinate of the transport location.
    attr_accessor :transport_latitude

    # Longitude coordinate of the transport location.
    attr_accessor :transport_longitude

    # Distance covered by the transport offer.
    attr_accessor :transport_distance

    # Metric unit for transport distance (e.g., kilometers, miles).
    attr_accessor :transport_distance_metric

    # Collection of images of the transport.
    attr_accessor :transport_images

    # Rating of the transport.
    attr_accessor :transport_rating

    # Reviews for the transport.
    attr_accessor :transport_reviews

    # Type of transport (e.g., car, van, scooter).
    attr_accessor :transport_type

    # Class of the transport (e.g., economy, luxury).
    attr_accessor :transport_class

    # Company providing the transport.
    attr_accessor :transport_company

    # Logo of the company providing the transport.
    attr_accessor :transport_company_logo

    # Number of passengers the transport can accommodate.
    attr_accessor :transport_passengers_number

    # Number of bags the transport can accommodate.
    attr_accessor :transport_bags_number

    # List of amenities provided with the transport.
    attr_accessor :transport_amenities

    # Questions related to booking the transport.
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
        :'pickup_date' => :'pickup_date',
        :'pickup_time' => :'pickup_time',
        :'adults' => :'adults',
        :'children' => :'children',
        :'return_date' => :'return_date',
        :'return_time' => :'return_time',
        :'transport_name' => :'transport_name',
        :'transport_description' => :'transport_description',
        :'transport_address' => :'transport_address',
        :'transport_latitude' => :'transport_latitude',
        :'transport_longitude' => :'transport_longitude',
        :'transport_distance' => :'transport_distance',
        :'transport_distance_metric' => :'transport_distance_metric',
        :'transport_images' => :'transport_images',
        :'transport_rating' => :'transport_rating',
        :'transport_reviews' => :'transport_reviews',
        :'transport_type' => :'transport_type',
        :'transport_class' => :'transport_class',
        :'transport_company' => :'transport_company',
        :'transport_company_logo' => :'transport_company_logo',
        :'transport_passengers_number' => :'transport_passengers_number',
        :'transport_bags_number' => :'transport_bags_number',
        :'transport_amenities' => :'transport_amenities',
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
        :'pickup_date' => :'Object',
        :'pickup_time' => :'Object',
        :'adults' => :'Object',
        :'children' => :'Object',
        :'return_date' => :'Object',
        :'return_time' => :'Object',
        :'transport_name' => :'Object',
        :'transport_description' => :'Object',
        :'transport_address' => :'Object',
        :'transport_latitude' => :'Object',
        :'transport_longitude' => :'Object',
        :'transport_distance' => :'Object',
        :'transport_distance_metric' => :'Object',
        :'transport_images' => :'Object',
        :'transport_rating' => :'Object',
        :'transport_reviews' => :'Object',
        :'transport_type' => :'Object',
        :'transport_class' => :'Object',
        :'transport_company' => :'Object',
        :'transport_company_logo' => :'Object',
        :'transport_passengers_number' => :'Object',
        :'transport_bags_number' => :'Object',
        :'transport_amenities' => :'Object',
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::TransportOfferResponseItemSchema` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::TransportOfferResponseItemSchema`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
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

      if attributes.key?(:'pickup_date')
        self.pickup_date = attributes[:'pickup_date']
      end

      if attributes.key?(:'pickup_time')
        self.pickup_time = attributes[:'pickup_time']
      end

      if attributes.key?(:'adults')
        self.adults = attributes[:'adults']
      end

      if attributes.key?(:'children')
        self.children = attributes[:'children']
      end

      if attributes.key?(:'return_date')
        self.return_date = attributes[:'return_date']
      end

      if attributes.key?(:'return_time')
        self.return_time = attributes[:'return_time']
      end

      if attributes.key?(:'transport_name')
        self.transport_name = attributes[:'transport_name']
      end

      if attributes.key?(:'transport_description')
        self.transport_description = attributes[:'transport_description']
      end

      if attributes.key?(:'transport_address')
        self.transport_address = attributes[:'transport_address']
      end

      if attributes.key?(:'transport_latitude')
        self.transport_latitude = attributes[:'transport_latitude']
      end

      if attributes.key?(:'transport_longitude')
        self.transport_longitude = attributes[:'transport_longitude']
      end

      if attributes.key?(:'transport_distance')
        self.transport_distance = attributes[:'transport_distance']
      end

      if attributes.key?(:'transport_distance_metric')
        self.transport_distance_metric = attributes[:'transport_distance_metric']
      end

      if attributes.key?(:'transport_images')
        if (value = attributes[:'transport_images']).is_a?(Array)
          self.transport_images = value
        end
      end

      if attributes.key?(:'transport_rating')
        self.transport_rating = attributes[:'transport_rating']
      end

      if attributes.key?(:'transport_reviews')
        if (value = attributes[:'transport_reviews']).is_a?(Array)
          self.transport_reviews = value
        end
      end

      if attributes.key?(:'transport_type')
        self.transport_type = attributes[:'transport_type']
      end

      if attributes.key?(:'transport_class')
        self.transport_class = attributes[:'transport_class']
      end

      if attributes.key?(:'transport_company')
        self.transport_company = attributes[:'transport_company']
      end

      if attributes.key?(:'transport_company_logo')
        self.transport_company_logo = attributes[:'transport_company_logo']
      end

      if attributes.key?(:'transport_passengers_number')
        self.transport_passengers_number = attributes[:'transport_passengers_number']
      end

      if attributes.key?(:'transport_bags_number')
        self.transport_bags_number = attributes[:'transport_bags_number']
      end

      if attributes.key?(:'transport_amenities')
        if (value = attributes[:'transport_amenities']).is_a?(Array)
          self.transport_amenities = value
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
          pickup_date == o.pickup_date &&
          pickup_time == o.pickup_time &&
          adults == o.adults &&
          children == o.children &&
          return_date == o.return_date &&
          return_time == o.return_time &&
          transport_name == o.transport_name &&
          transport_description == o.transport_description &&
          transport_address == o.transport_address &&
          transport_latitude == o.transport_latitude &&
          transport_longitude == o.transport_longitude &&
          transport_distance == o.transport_distance &&
          transport_distance_metric == o.transport_distance_metric &&
          transport_images == o.transport_images &&
          transport_rating == o.transport_rating &&
          transport_reviews == o.transport_reviews &&
          transport_type == o.transport_type &&
          transport_class == o.transport_class &&
          transport_company == o.transport_company &&
          transport_company_logo == o.transport_company_logo &&
          transport_passengers_number == o.transport_passengers_number &&
          transport_bags_number == o.transport_bags_number &&
          transport_amenities == o.transport_amenities &&
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
      [offer_id, supplier_offer_id, offer_index, offer_tax, offer_price, offer_currency, offer_cancelation_policies, pickup_date, pickup_time, adults, children, return_date, return_time, transport_name, transport_description, transport_address, transport_latitude, transport_longitude, transport_distance, transport_distance_metric, transport_images, transport_rating, transport_reviews, transport_type, transport_class, transport_company, transport_company_logo, transport_passengers_number, transport_bags_number, transport_amenities, booking_questions].hash
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
