=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'date'

module SwaggerClient
  class CarOfferDetailsSchema
    # Unique identifier for the car offer.
    attr_accessor :offer_id

    # Unique identifier for the supplier’s offer.
    attr_accessor :supplier_offer_id

    # Index of the offer for sorting purposes.
    attr_accessor :offer_index

    # Tax applied to the offer.
    attr_accessor :offer_tax

    # Price of the offer.
    attr_accessor :offer_price

    # Currency of the offer price.
    attr_accessor :offer_currency

    # Cancellation policies applicable to the offer.
    attr_accessor :offer_cancelation_policies

    # Scheduled date for car pickup.
    attr_accessor :pickup_date

    # Scheduled time for car pickup.
    attr_accessor :pickup_time

    # Scheduled date for car dropoff.
    attr_accessor :dropoff_date

    # Scheduled time for car dropoff.
    attr_accessor :dropoff_time

    # Name of the car model.
    attr_accessor :car_name

    # Description of the car.
    attr_accessor :car_description

    # Address where the car can be picked up.
    attr_accessor :car_address

    # Latitude of the car pickup location.
    attr_accessor :car_latitude

    # Longitude of the car pickup location.
    attr_accessor :car_longitude

    # Distance the car can be driven.
    attr_accessor :car_distance

    # Metric system used for car distance (miles/km).
    attr_accessor :car_distance_metric

    # Array of images of the car.
    attr_accessor :car_images

    # Rating of the car based on user reviews.
    attr_accessor :car_rating

    # Number of reviews for the car.
    attr_accessor :car_reviews

    # Type of the car (e.g., sedan, SUV).
    attr_accessor :car_type

    # Class of the car (e.g., economy, luxury).
    attr_accessor :car_class

    # Company owning the car or rental service.
    attr_accessor :car_company

    # Logo of the company owning the car.
    attr_accessor :car_company_logo

    # Number of passengers the car can hold.
    attr_accessor :car_passengers_number

    # Number of bags the car can hold.
    attr_accessor :car_bags_number

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
        :'dropoff_date' => :'dropoff_date',
        :'dropoff_time' => :'dropoff_time',
        :'car_name' => :'car_name',
        :'car_description' => :'car_description',
        :'car_address' => :'car_address',
        :'car_latitude' => :'car_latitude',
        :'car_longitude' => :'car_longitude',
        :'car_distance' => :'car_distance',
        :'car_distance_metric' => :'car_distance_metric',
        :'car_images' => :'car_images',
        :'car_rating' => :'car_rating',
        :'car_reviews' => :'car_reviews',
        :'car_type' => :'car_type',
        :'car_class' => :'car_class',
        :'car_company' => :'car_company',
        :'car_company_logo' => :'car_company_logo',
        :'car_passengers_number' => :'car_passengers_number',
        :'car_bags_number' => :'car_bags_number'
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
        :'dropoff_date' => :'Object',
        :'dropoff_time' => :'Object',
        :'car_name' => :'Object',
        :'car_description' => :'Object',
        :'car_address' => :'Object',
        :'car_latitude' => :'Object',
        :'car_longitude' => :'Object',
        :'car_distance' => :'Object',
        :'car_distance_metric' => :'Object',
        :'car_images' => :'Object',
        :'car_rating' => :'Object',
        :'car_reviews' => :'Object',
        :'car_type' => :'Object',
        :'car_class' => :'Object',
        :'car_company' => :'Object',
        :'car_company_logo' => :'Object',
        :'car_passengers_number' => :'Object',
        :'car_bags_number' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::CarOfferDetailsSchema` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::CarOfferDetailsSchema`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
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

      if attributes.key?(:'dropoff_date')
        self.dropoff_date = attributes[:'dropoff_date']
      end

      if attributes.key?(:'dropoff_time')
        self.dropoff_time = attributes[:'dropoff_time']
      end

      if attributes.key?(:'car_name')
        self.car_name = attributes[:'car_name']
      end

      if attributes.key?(:'car_description')
        self.car_description = attributes[:'car_description']
      end

      if attributes.key?(:'car_address')
        self.car_address = attributes[:'car_address']
      end

      if attributes.key?(:'car_latitude')
        self.car_latitude = attributes[:'car_latitude']
      end

      if attributes.key?(:'car_longitude')
        self.car_longitude = attributes[:'car_longitude']
      end

      if attributes.key?(:'car_distance')
        self.car_distance = attributes[:'car_distance']
      end

      if attributes.key?(:'car_distance_metric')
        self.car_distance_metric = attributes[:'car_distance_metric']
      end

      if attributes.key?(:'car_images')
        if (value = attributes[:'car_images']).is_a?(Array)
          self.car_images = value
        end
      end

      if attributes.key?(:'car_rating')
        self.car_rating = attributes[:'car_rating']
      end

      if attributes.key?(:'car_reviews')
        self.car_reviews = attributes[:'car_reviews']
      end

      if attributes.key?(:'car_type')
        self.car_type = attributes[:'car_type']
      end

      if attributes.key?(:'car_class')
        self.car_class = attributes[:'car_class']
      end

      if attributes.key?(:'car_company')
        self.car_company = attributes[:'car_company']
      end

      if attributes.key?(:'car_company_logo')
        self.car_company_logo = attributes[:'car_company_logo']
      end

      if attributes.key?(:'car_passengers_number')
        self.car_passengers_number = attributes[:'car_passengers_number']
      end

      if attributes.key?(:'car_bags_number')
        self.car_bags_number = attributes[:'car_bags_number']
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
          dropoff_date == o.dropoff_date &&
          dropoff_time == o.dropoff_time &&
          car_name == o.car_name &&
          car_description == o.car_description &&
          car_address == o.car_address &&
          car_latitude == o.car_latitude &&
          car_longitude == o.car_longitude &&
          car_distance == o.car_distance &&
          car_distance_metric == o.car_distance_metric &&
          car_images == o.car_images &&
          car_rating == o.car_rating &&
          car_reviews == o.car_reviews &&
          car_type == o.car_type &&
          car_class == o.car_class &&
          car_company == o.car_company &&
          car_company_logo == o.car_company_logo &&
          car_passengers_number == o.car_passengers_number &&
          car_bags_number == o.car_bags_number
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [offer_id, supplier_offer_id, offer_index, offer_tax, offer_price, offer_currency, offer_cancelation_policies, pickup_date, pickup_time, dropoff_date, dropoff_time, car_name, car_description, car_address, car_latitude, car_longitude, car_distance, car_distance_metric, car_images, car_rating, car_reviews, car_type, car_class, car_company, car_company_logo, car_passengers_number, car_bags_number].hash
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
