=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'date'

module SwaggerClient
  class HotelOfferResponseItemSchema
    # Unique identifier for the hotel offer.
    attr_accessor :offer_id

    # Unique identifier given by the supplier for the hotel offer.
    attr_accessor :supplier_offer_id

    # Index number of the offer for sorting and referencing purposes.
    attr_accessor :offer_index

    # Applicable tax amount for the offer.
    attr_accessor :offer_tax

    # Total price of the hotel offer.
    attr_accessor :offer_price

    # Currency in which the offer price is denominated.
    attr_accessor :offer_currency

    # Details of the cancellation policies applicable to the offer.
    attr_accessor :offer_cancellation_policies

    # Scheduled check-in date for the hotel stay.
    attr_accessor :checkin_date

    # Scheduled check-out date for the hotel stay.
    attr_accessor :checkout_date

    # Name of the hotel.
    attr_accessor :hotel_name

    # Description of the hotel.
    attr_accessor :hotel_description

    # Physical address of the hotel.
    attr_accessor :hotel_address

    # Geographic latitude of the hotel.
    attr_accessor :hotel_latitude

    # Geographic longitude of the hotel.
    attr_accessor :hotel_longitude

    # Distance of the hotel from a central point of interest, if applicable.
    attr_accessor :hotel_distance

    # Unit of measurement for the distance (e.g., km, miles).
    attr_accessor :hotel_distance_metric

    # Array of images associated with the hotel.
    attr_accessor :hotel_images

    # Overall rating of the hotel.
    attr_accessor :hotel_rating

    # Collection of reviews for the hotel.
    attr_accessor :hotel_reviews

    # Star rating of the hotel.
    attr_accessor :hotel_stars

    # Standard check-in time at the hotel.
    attr_accessor :hotel_checkin_time

    # Standard check-out time at the hotel.
    attr_accessor :hotel_checkout_time

    # List of facilities available at the hotel.
    attr_accessor :hotel_facilities

    # List of amenities offered by the hotel.
    attr_accessor :hotel_amenities

    # General policies of the hotel.
    attr_accessor :hotel_policies

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'offer_id' => :'offerId',
        :'supplier_offer_id' => :'supplierOfferId',
        :'offer_index' => :'offerIndex',
        :'offer_tax' => :'offerTax',
        :'offer_price' => :'offerPrice',
        :'offer_currency' => :'offerCurrency',
        :'offer_cancellation_policies' => :'offerCancellationPolicies',
        :'checkin_date' => :'checkinDate',
        :'checkout_date' => :'checkoutDate',
        :'hotel_name' => :'hotelName',
        :'hotel_description' => :'hotelDescription',
        :'hotel_address' => :'hotelAddress',
        :'hotel_latitude' => :'hotelLatitude',
        :'hotel_longitude' => :'hotelLongitude',
        :'hotel_distance' => :'hotelDistance',
        :'hotel_distance_metric' => :'hotelDistanceMetric',
        :'hotel_images' => :'hotelImages',
        :'hotel_rating' => :'hotelRating',
        :'hotel_reviews' => :'hotelReviews',
        :'hotel_stars' => :'hotelStars',
        :'hotel_checkin_time' => :'hotelCheckinTime',
        :'hotel_checkout_time' => :'hotelCheckoutTime',
        :'hotel_facilities' => :'hotelFacilities',
        :'hotel_amenities' => :'hotelAmenities',
        :'hotel_policies' => :'hotelPolicies'
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
        :'offer_cancellation_policies' => :'Object',
        :'checkin_date' => :'Object',
        :'checkout_date' => :'Object',
        :'hotel_name' => :'Object',
        :'hotel_description' => :'Object',
        :'hotel_address' => :'Object',
        :'hotel_latitude' => :'Object',
        :'hotel_longitude' => :'Object',
        :'hotel_distance' => :'Object',
        :'hotel_distance_metric' => :'Object',
        :'hotel_images' => :'Object',
        :'hotel_rating' => :'Object',
        :'hotel_reviews' => :'Object',
        :'hotel_stars' => :'Object',
        :'hotel_checkin_time' => :'Object',
        :'hotel_checkout_time' => :'Object',
        :'hotel_facilities' => :'Object',
        :'hotel_amenities' => :'Object',
        :'hotel_policies' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::HotelOfferResponseItemSchema` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::HotelOfferResponseItemSchema`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
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

      if attributes.key?(:'offer_cancellation_policies')
        self.offer_cancellation_policies = attributes[:'offer_cancellation_policies']
      end

      if attributes.key?(:'checkin_date')
        self.checkin_date = attributes[:'checkin_date']
      end

      if attributes.key?(:'checkout_date')
        self.checkout_date = attributes[:'checkout_date']
      end

      if attributes.key?(:'hotel_name')
        self.hotel_name = attributes[:'hotel_name']
      end

      if attributes.key?(:'hotel_description')
        self.hotel_description = attributes[:'hotel_description']
      end

      if attributes.key?(:'hotel_address')
        self.hotel_address = attributes[:'hotel_address']
      end

      if attributes.key?(:'hotel_latitude')
        self.hotel_latitude = attributes[:'hotel_latitude']
      end

      if attributes.key?(:'hotel_longitude')
        self.hotel_longitude = attributes[:'hotel_longitude']
      end

      if attributes.key?(:'hotel_distance')
        self.hotel_distance = attributes[:'hotel_distance']
      end

      if attributes.key?(:'hotel_distance_metric')
        self.hotel_distance_metric = attributes[:'hotel_distance_metric']
      end

      if attributes.key?(:'hotel_images')
        if (value = attributes[:'hotel_images']).is_a?(Array)
          self.hotel_images = value
        end
      end

      if attributes.key?(:'hotel_rating')
        self.hotel_rating = attributes[:'hotel_rating']
      end

      if attributes.key?(:'hotel_reviews')
        if (value = attributes[:'hotel_reviews']).is_a?(Hash)
          self.hotel_reviews = value
        end
      end

      if attributes.key?(:'hotel_stars')
        self.hotel_stars = attributes[:'hotel_stars']
      end

      if attributes.key?(:'hotel_checkin_time')
        self.hotel_checkin_time = attributes[:'hotel_checkin_time']
      end

      if attributes.key?(:'hotel_checkout_time')
        self.hotel_checkout_time = attributes[:'hotel_checkout_time']
      end

      if attributes.key?(:'hotel_facilities')
        if (value = attributes[:'hotel_facilities']).is_a?(Array)
          self.hotel_facilities = value
        end
      end

      if attributes.key?(:'hotel_amenities')
        if (value = attributes[:'hotel_amenities']).is_a?(Array)
          self.hotel_amenities = value
        end
      end

      if attributes.key?(:'hotel_policies')
        if (value = attributes[:'hotel_policies']).is_a?(Array)
          self.hotel_policies = value
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
          offer_cancellation_policies == o.offer_cancellation_policies &&
          checkin_date == o.checkin_date &&
          checkout_date == o.checkout_date &&
          hotel_name == o.hotel_name &&
          hotel_description == o.hotel_description &&
          hotel_address == o.hotel_address &&
          hotel_latitude == o.hotel_latitude &&
          hotel_longitude == o.hotel_longitude &&
          hotel_distance == o.hotel_distance &&
          hotel_distance_metric == o.hotel_distance_metric &&
          hotel_images == o.hotel_images &&
          hotel_rating == o.hotel_rating &&
          hotel_reviews == o.hotel_reviews &&
          hotel_stars == o.hotel_stars &&
          hotel_checkin_time == o.hotel_checkin_time &&
          hotel_checkout_time == o.hotel_checkout_time &&
          hotel_facilities == o.hotel_facilities &&
          hotel_amenities == o.hotel_amenities &&
          hotel_policies == o.hotel_policies
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [offer_id, supplier_offer_id, offer_index, offer_tax, offer_price, offer_currency, offer_cancellation_policies, checkin_date, checkout_date, hotel_name, hotel_description, hotel_address, hotel_latitude, hotel_longitude, hotel_distance, hotel_distance_metric, hotel_images, hotel_rating, hotel_reviews, hotel_stars, hotel_checkin_time, hotel_checkout_time, hotel_facilities, hotel_amenities, hotel_policies].hash
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
