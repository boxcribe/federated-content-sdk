=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'date'

module SwaggerClient
  class ToursAndActivitiesOfferRequestSchema
    # Latitude for the location.
    attr_accessor :location_latitude

    # Longitude for the location.
    attr_accessor :location_longitude

    # Radius to search for tours and activities from the specified location.
    attr_accessor :location_radius

    # Starting date for tours and activities.
    attr_accessor :start_date

    # Ending date for tours and activities.
    attr_accessor :end_date

    # Number of adults participating.
    attr_accessor :adults

    # Number of children participating.
    attr_accessor :children

    # Keyword to filter tours and activities.
    attr_accessor :filter_by_keyword

    # Minimum price filter.
    attr_accessor :filter_by_price_min

    # Maximum price filter.
    attr_accessor :filter_by_price_max

    # Minimum distance filter.
    attr_accessor :filter_by_distance_min

    # Maximum distance filter.
    attr_accessor :filter_by_distance_max

    # Minimum rating filter.
    attr_accessor :filter_by_rating_min

    # Maximum rating filter.
    attr_accessor :filter_by_rating_max

    # Subcategories to filter tours and activities.
    attr_accessor :filter_by_subcategories

    # Criteria to sort the search results.
    attr_accessor :sort_by

    # Order to sort the results (ascending or descending).
    attr_accessor :sort_order

    # Page number for pagination.
    attr_accessor :page

    # Number of items per page.
    attr_accessor :limit

    # Language of the tour offers.
    attr_accessor :language

    # Currency in which prices are displayed.
    attr_accessor :currency

    # Unit for distance measurement (mi/km) used in filters.
    attr_accessor :metric

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'location_latitude' => :'location_latitude',
        :'location_longitude' => :'location_longitude',
        :'location_radius' => :'location_radius',
        :'start_date' => :'start_date',
        :'end_date' => :'end_date',
        :'adults' => :'adults',
        :'children' => :'children',
        :'filter_by_keyword' => :'filter_by_keyword',
        :'filter_by_price_min' => :'filter_by_price_min',
        :'filter_by_price_max' => :'filter_by_price_max',
        :'filter_by_distance_min' => :'filter_by_distance_min',
        :'filter_by_distance_max' => :'filter_by_distance_max',
        :'filter_by_rating_min' => :'filter_by_rating_min',
        :'filter_by_rating_max' => :'filter_by_rating_max',
        :'filter_by_subcategories' => :'filter_by_subcategories',
        :'sort_by' => :'sort_by',
        :'sort_order' => :'sort_order',
        :'page' => :'page',
        :'limit' => :'limit',
        :'language' => :'language',
        :'currency' => :'currency',
        :'metric' => :'metric'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'location_latitude' => :'Object',
        :'location_longitude' => :'Object',
        :'location_radius' => :'Object',
        :'start_date' => :'Object',
        :'end_date' => :'Object',
        :'adults' => :'Object',
        :'children' => :'Object',
        :'filter_by_keyword' => :'Object',
        :'filter_by_price_min' => :'Object',
        :'filter_by_price_max' => :'Object',
        :'filter_by_distance_min' => :'Object',
        :'filter_by_distance_max' => :'Object',
        :'filter_by_rating_min' => :'Object',
        :'filter_by_rating_max' => :'Object',
        :'filter_by_subcategories' => :'Object',
        :'sort_by' => :'Object',
        :'sort_order' => :'Object',
        :'page' => :'Object',
        :'limit' => :'Object',
        :'language' => :'Object',
        :'currency' => :'Object',
        :'metric' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::ToursAndActivitiesOfferRequestSchema` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::ToursAndActivitiesOfferRequestSchema`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'location_latitude')
        self.location_latitude = attributes[:'location_latitude']
      end

      if attributes.key?(:'location_longitude')
        self.location_longitude = attributes[:'location_longitude']
      end

      if attributes.key?(:'location_radius')
        self.location_radius = attributes[:'location_radius']
      end

      if attributes.key?(:'start_date')
        self.start_date = attributes[:'start_date']
      end

      if attributes.key?(:'end_date')
        self.end_date = attributes[:'end_date']
      end

      if attributes.key?(:'adults')
        self.adults = attributes[:'adults']
      end

      if attributes.key?(:'children')
        self.children = attributes[:'children']
      end

      if attributes.key?(:'filter_by_keyword')
        self.filter_by_keyword = attributes[:'filter_by_keyword']
      end

      if attributes.key?(:'filter_by_price_min')
        self.filter_by_price_min = attributes[:'filter_by_price_min']
      end

      if attributes.key?(:'filter_by_price_max')
        self.filter_by_price_max = attributes[:'filter_by_price_max']
      end

      if attributes.key?(:'filter_by_distance_min')
        self.filter_by_distance_min = attributes[:'filter_by_distance_min']
      end

      if attributes.key?(:'filter_by_distance_max')
        self.filter_by_distance_max = attributes[:'filter_by_distance_max']
      end

      if attributes.key?(:'filter_by_rating_min')
        self.filter_by_rating_min = attributes[:'filter_by_rating_min']
      end

      if attributes.key?(:'filter_by_rating_max')
        self.filter_by_rating_max = attributes[:'filter_by_rating_max']
      end

      if attributes.key?(:'filter_by_subcategories')
        if (value = attributes[:'filter_by_subcategories']).is_a?(Array)
          self.filter_by_subcategories = value
        end
      end

      if attributes.key?(:'sort_by')
        self.sort_by = attributes[:'sort_by']
      end

      if attributes.key?(:'sort_order')
        self.sort_order = attributes[:'sort_order']
      end

      if attributes.key?(:'page')
        self.page = attributes[:'page']
      end

      if attributes.key?(:'limit')
        self.limit = attributes[:'limit']
      end

      if attributes.key?(:'language')
        self.language = attributes[:'language']
      end

      if attributes.key?(:'currency')
        self.currency = attributes[:'currency']
      end

      if attributes.key?(:'metric')
        self.metric = attributes[:'metric']
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
          location_latitude == o.location_latitude &&
          location_longitude == o.location_longitude &&
          location_radius == o.location_radius &&
          start_date == o.start_date &&
          end_date == o.end_date &&
          adults == o.adults &&
          children == o.children &&
          filter_by_keyword == o.filter_by_keyword &&
          filter_by_price_min == o.filter_by_price_min &&
          filter_by_price_max == o.filter_by_price_max &&
          filter_by_distance_min == o.filter_by_distance_min &&
          filter_by_distance_max == o.filter_by_distance_max &&
          filter_by_rating_min == o.filter_by_rating_min &&
          filter_by_rating_max == o.filter_by_rating_max &&
          filter_by_subcategories == o.filter_by_subcategories &&
          sort_by == o.sort_by &&
          sort_order == o.sort_order &&
          page == o.page &&
          limit == o.limit &&
          language == o.language &&
          currency == o.currency &&
          metric == o.metric
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [location_latitude, location_longitude, location_radius, start_date, end_date, adults, children, filter_by_keyword, filter_by_price_min, filter_by_price_max, filter_by_distance_min, filter_by_distance_max, filter_by_rating_min, filter_by_rating_max, filter_by_subcategories, sort_by, sort_order, page, limit, language, currency, metric].hash
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
