=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'date'

module SwaggerClient
  class Integration
    attr_accessor :id

    attr_accessor :tenant_id

    attr_accessor :category_id

    attr_accessor :name

    attr_accessor :slug

    attr_accessor :logo

    attr_accessor :status

    # Production Credentials
    attr_accessor :credentials_production

    # Sandbox Credentials
    attr_accessor :credentials_sandbox

    attr_accessor :env_production

    attr_accessor :env_sandbox

    # Production Settings
    attr_accessor :settings_production

    # Sandbox Settings
    attr_accessor :settings_sandbox

    class EnumAttributeValidator
      attr_reader :datatype
      attr_reader :allowable_values

      def initialize(datatype, allowable_values)
        @allowable_values = allowable_values.map do |value|
          case datatype.to_s
          when /Integer/i
            value.to_i
          when /Float/i
            value.to_f
          else
            value
          end
        end
      end

      def valid?(value)
        !value || allowable_values.include?(value)
      end
    end

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'id' => :'id',
        :'tenant_id' => :'tenant_id',
        :'category_id' => :'category_id',
        :'name' => :'name',
        :'slug' => :'slug',
        :'logo' => :'logo',
        :'status' => :'status',
        :'credentials_production' => :'credentials_production',
        :'credentials_sandbox' => :'credentials_sandbox',
        :'env_production' => :'env_production',
        :'env_sandbox' => :'env_sandbox',
        :'settings_production' => :'settings_production',
        :'settings_sandbox' => :'settings_sandbox'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'id' => :'Object',
        :'tenant_id' => :'Object',
        :'category_id' => :'Object',
        :'name' => :'Object',
        :'slug' => :'Object',
        :'logo' => :'Object',
        :'status' => :'Object',
        :'credentials_production' => :'Object',
        :'credentials_sandbox' => :'Object',
        :'env_production' => :'Object',
        :'env_sandbox' => :'Object',
        :'settings_production' => :'Object',
        :'settings_sandbox' => :'Object'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
        :'tenant_id',
        :'logo',
      ])
    end
  
    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::Integration` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::Integration`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'id')
        self.id = attributes[:'id']
      end

      if attributes.key?(:'tenant_id')
        self.tenant_id = attributes[:'tenant_id']
      end

      if attributes.key?(:'category_id')
        self.category_id = attributes[:'category_id']
      end

      if attributes.key?(:'name')
        self.name = attributes[:'name']
      end

      if attributes.key?(:'slug')
        self.slug = attributes[:'slug']
      end

      if attributes.key?(:'logo')
        self.logo = attributes[:'logo']
      end

      if attributes.key?(:'status')
        self.status = attributes[:'status']
      else
        self.status = 'Active'
      end

      if attributes.key?(:'credentials_production')
        self.credentials_production = attributes[:'credentials_production']
      end

      if attributes.key?(:'credentials_sandbox')
        self.credentials_sandbox = attributes[:'credentials_sandbox']
      end

      if attributes.key?(:'env_production')
        self.env_production = attributes[:'env_production']
      else
        self.env_production = 'Production'
      end

      if attributes.key?(:'env_sandbox')
        self.env_sandbox = attributes[:'env_sandbox']
      else
        self.env_sandbox = 'Sandbox'
      end

      if attributes.key?(:'settings_production')
        self.settings_production = attributes[:'settings_production']
      end

      if attributes.key?(:'settings_sandbox')
        self.settings_sandbox = attributes[:'settings_sandbox']
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
      status_validator = EnumAttributeValidator.new('Object', ['Active', 'Inactive'])
      return false unless status_validator.valid?(@status)
      env_production_validator = EnumAttributeValidator.new('Object', ['Production', 'Sandbox'])
      return false unless env_production_validator.valid?(@env_production)
      env_sandbox_validator = EnumAttributeValidator.new('Object', ['Production', 'Sandbox'])
      return false unless env_sandbox_validator.valid?(@env_sandbox)
      true
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] status Object to be assigned
    def status=(status)
      validator = EnumAttributeValidator.new('Object', ['Active', 'Inactive'])
      unless validator.valid?(status)
        fail ArgumentError, "invalid value for \"status\", must be one of #{validator.allowable_values}."
      end
      @status = status
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] env_production Object to be assigned
    def env_production=(env_production)
      validator = EnumAttributeValidator.new('Object', ['Production', 'Sandbox'])
      unless validator.valid?(env_production)
        fail ArgumentError, "invalid value for \"env_production\", must be one of #{validator.allowable_values}."
      end
      @env_production = env_production
    end

    # Custom attribute writer method checking allowed values (enum).
    # @param [Object] env_sandbox Object to be assigned
    def env_sandbox=(env_sandbox)
      validator = EnumAttributeValidator.new('Object', ['Production', 'Sandbox'])
      unless validator.valid?(env_sandbox)
        fail ArgumentError, "invalid value for \"env_sandbox\", must be one of #{validator.allowable_values}."
      end
      @env_sandbox = env_sandbox
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          id == o.id &&
          tenant_id == o.tenant_id &&
          category_id == o.category_id &&
          name == o.name &&
          slug == o.slug &&
          logo == o.logo &&
          status == o.status &&
          credentials_production == o.credentials_production &&
          credentials_sandbox == o.credentials_sandbox &&
          env_production == o.env_production &&
          env_sandbox == o.env_sandbox &&
          settings_production == o.settings_production &&
          settings_sandbox == o.settings_sandbox
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [id, tenant_id, category_id, name, slug, logo, status, credentials_production, credentials_sandbox, env_production, env_sandbox, settings_production, settings_sandbox].hash
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