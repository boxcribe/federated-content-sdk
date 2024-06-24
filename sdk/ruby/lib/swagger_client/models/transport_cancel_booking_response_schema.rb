=begin
#Federated Content API

#Welcome to the Federated Content API following Open API Specification (Version 3.0.0)

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.57
=end

require 'date'

module SwaggerClient
  class TransportCancelBookingResponseSchema
    # Identifier for the company associated with the booking.
    attr_accessor :company_id

    # Identifier for the tenant associated with the booking.
    attr_accessor :tenant_id

    # Identifier for the category of the booking.
    attr_accessor :category_id

    # Identifier for the supplier of the booking.
    attr_accessor :supplier_id

    # Unique identifier for the booking.
    attr_accessor :booking_id

    # Supplier’s identifier for the booking.
    attr_accessor :supplier_booking_id

    # Reference number provided by the supplier for the booking.
    attr_accessor :supplier_booking_reference

    # Customer reference number associated with the booking.
    attr_accessor :customer_reference

    # Internal reference number for the booking.
    attr_accessor :booking_reference

    # Reference number for the payment associated with the booking.
    attr_accessor :payment_reference

    # Current status of the booking.
    attr_accessor :booking_status

    # Tax applied to the booking.
    attr_accessor :booking_tax

    # Total price of the booking.
    attr_accessor :booking_price

    # Currency used for the booking pricing.
    attr_accessor :booking_currency

    # Cancellation policies applicable to the booking.
    attr_accessor :booking_cancelation_policies

    attr_accessor :customer

    attr_accessor :offer_request

    attr_accessor :offer

    # Indicates if the booking was successful.
    attr_accessor :success

    # Provides details on any error that occurred during the booking process.
    attr_accessor :error_message

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'company_id' => :'company_id',
        :'tenant_id' => :'tenant_id',
        :'category_id' => :'category_id',
        :'supplier_id' => :'supplier_id',
        :'booking_id' => :'booking_id',
        :'supplier_booking_id' => :'supplier_booking_id',
        :'supplier_booking_reference' => :'supplier_booking_reference',
        :'customer_reference' => :'customer_reference',
        :'booking_reference' => :'booking_reference',
        :'payment_reference' => :'payment_reference',
        :'booking_status' => :'booking_status',
        :'booking_tax' => :'booking_tax',
        :'booking_price' => :'booking_price',
        :'booking_currency' => :'booking_currency',
        :'booking_cancelation_policies' => :'booking_cancelation_policies',
        :'customer' => :'customer',
        :'offer_request' => :'offer_request',
        :'offer' => :'offer',
        :'success' => :'success',
        :'error_message' => :'error_message'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'company_id' => :'Object',
        :'tenant_id' => :'Object',
        :'category_id' => :'Object',
        :'supplier_id' => :'Object',
        :'booking_id' => :'Object',
        :'supplier_booking_id' => :'Object',
        :'supplier_booking_reference' => :'Object',
        :'customer_reference' => :'Object',
        :'booking_reference' => :'Object',
        :'payment_reference' => :'Object',
        :'booking_status' => :'Object',
        :'booking_tax' => :'Object',
        :'booking_price' => :'Object',
        :'booking_currency' => :'Object',
        :'booking_cancelation_policies' => :'Object',
        :'customer' => :'Object',
        :'offer_request' => :'Object',
        :'offer' => :'Object',
        :'success' => :'Object',
        :'error_message' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::TransportCancelBookingResponseSchema` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::TransportCancelBookingResponseSchema`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'company_id')
        self.company_id = attributes[:'company_id']
      end

      if attributes.key?(:'tenant_id')
        self.tenant_id = attributes[:'tenant_id']
      end

      if attributes.key?(:'category_id')
        self.category_id = attributes[:'category_id']
      end

      if attributes.key?(:'supplier_id')
        self.supplier_id = attributes[:'supplier_id']
      end

      if attributes.key?(:'booking_id')
        self.booking_id = attributes[:'booking_id']
      end

      if attributes.key?(:'supplier_booking_id')
        self.supplier_booking_id = attributes[:'supplier_booking_id']
      end

      if attributes.key?(:'supplier_booking_reference')
        self.supplier_booking_reference = attributes[:'supplier_booking_reference']
      end

      if attributes.key?(:'customer_reference')
        self.customer_reference = attributes[:'customer_reference']
      end

      if attributes.key?(:'booking_reference')
        self.booking_reference = attributes[:'booking_reference']
      end

      if attributes.key?(:'payment_reference')
        self.payment_reference = attributes[:'payment_reference']
      end

      if attributes.key?(:'booking_status')
        self.booking_status = attributes[:'booking_status']
      end

      if attributes.key?(:'booking_tax')
        self.booking_tax = attributes[:'booking_tax']
      end

      if attributes.key?(:'booking_price')
        self.booking_price = attributes[:'booking_price']
      end

      if attributes.key?(:'booking_currency')
        self.booking_currency = attributes[:'booking_currency']
      end

      if attributes.key?(:'booking_cancelation_policies')
        self.booking_cancelation_policies = attributes[:'booking_cancelation_policies']
      end

      if attributes.key?(:'customer')
        self.customer = attributes[:'customer']
      end

      if attributes.key?(:'offer_request')
        self.offer_request = attributes[:'offer_request']
      end

      if attributes.key?(:'offer')
        self.offer = attributes[:'offer']
      end

      if attributes.key?(:'success')
        self.success = attributes[:'success']
      end

      if attributes.key?(:'error_message')
        self.error_message = attributes[:'error_message']
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
          company_id == o.company_id &&
          tenant_id == o.tenant_id &&
          category_id == o.category_id &&
          supplier_id == o.supplier_id &&
          booking_id == o.booking_id &&
          supplier_booking_id == o.supplier_booking_id &&
          supplier_booking_reference == o.supplier_booking_reference &&
          customer_reference == o.customer_reference &&
          booking_reference == o.booking_reference &&
          payment_reference == o.payment_reference &&
          booking_status == o.booking_status &&
          booking_tax == o.booking_tax &&
          booking_price == o.booking_price &&
          booking_currency == o.booking_currency &&
          booking_cancelation_policies == o.booking_cancelation_policies &&
          customer == o.customer &&
          offer_request == o.offer_request &&
          offer == o.offer &&
          success == o.success &&
          error_message == o.error_message
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [company_id, tenant_id, category_id, supplier_id, booking_id, supplier_booking_id, supplier_booking_reference, customer_reference, booking_reference, payment_reference, booking_status, booking_tax, booking_price, booking_currency, booking_cancelation_policies, customer, offer_request, offer, success, error_message].hash
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
