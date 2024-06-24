<?php
/**
 * DiningBookingDetailsResponseSchema
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.57
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * DiningBookingDetailsResponseSchema Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class DiningBookingDetailsResponseSchema implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'DiningBookingDetailsResponseSchema';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'company_id' => 'string',
        'tenant_id' => 'string',
        'category_id' => 'string',
        'supplier_id' => 'string',
        'booking_id' => 'string',
        'supplier_booking_id' => 'string',
        'supplier_booking_reference' => 'string',
        'customer_reference' => 'string',
        'booking_reference' => 'string',
        'payment_reference' => 'string',
        'booking_status' => 'string',
        'booking_tax' => 'float',
        'booking_price' => 'float',
        'booking_currency' => 'string',
        'booking_cancellation_policies' => 'string',
        'customer' => '\Swagger\Client\Model\DiningBookingCustomerSchema',
        'offer_request' => '\Swagger\Client\Model\DiningOfferRequestSchema',
        'offer' => '\Swagger\Client\Model\DiningOfferResponseItemSchema',
        'availability' => '\Swagger\Client\Model\DiningAvailabilitySchema',
        'success' => 'bool',
        'error_message' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'company_id' => 'uuid',
        'tenant_id' => 'uuid',
        'category_id' => 'uuid',
        'supplier_id' => 'uuid',
        'booking_id' => 'uuid',
        'supplier_booking_id' => 'uuid',
        'supplier_booking_reference' => null,
        'customer_reference' => null,
        'booking_reference' => null,
        'payment_reference' => null,
        'booking_status' => null,
        'booking_tax' => 'decimal',
        'booking_price' => 'decimal',
        'booking_currency' => null,
        'booking_cancellation_policies' => null,
        'customer' => null,
        'offer_request' => null,
        'offer' => null,
        'availability' => null,
        'success' => null,
        'error_message' => null
    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'company_id' => 'company_id',
        'tenant_id' => 'tenant_id',
        'category_id' => 'category_id',
        'supplier_id' => 'supplier_id',
        'booking_id' => 'booking_id',
        'supplier_booking_id' => 'supplier_booking_id',
        'supplier_booking_reference' => 'supplier_booking_reference',
        'customer_reference' => 'customer_reference',
        'booking_reference' => 'booking_reference',
        'payment_reference' => 'payment_reference',
        'booking_status' => 'booking_status',
        'booking_tax' => 'booking_tax',
        'booking_price' => 'booking_price',
        'booking_currency' => 'booking_currency',
        'booking_cancellation_policies' => 'booking_cancellation_policies',
        'customer' => 'customer',
        'offer_request' => 'offer_request',
        'offer' => 'offer',
        'availability' => 'availability',
        'success' => 'success',
        'error_message' => 'error_message'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'company_id' => 'setCompanyId',
        'tenant_id' => 'setTenantId',
        'category_id' => 'setCategoryId',
        'supplier_id' => 'setSupplierId',
        'booking_id' => 'setBookingId',
        'supplier_booking_id' => 'setSupplierBookingId',
        'supplier_booking_reference' => 'setSupplierBookingReference',
        'customer_reference' => 'setCustomerReference',
        'booking_reference' => 'setBookingReference',
        'payment_reference' => 'setPaymentReference',
        'booking_status' => 'setBookingStatus',
        'booking_tax' => 'setBookingTax',
        'booking_price' => 'setBookingPrice',
        'booking_currency' => 'setBookingCurrency',
        'booking_cancellation_policies' => 'setBookingCancellationPolicies',
        'customer' => 'setCustomer',
        'offer_request' => 'setOfferRequest',
        'offer' => 'setOffer',
        'availability' => 'setAvailability',
        'success' => 'setSuccess',
        'error_message' => 'setErrorMessage'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'company_id' => 'getCompanyId',
        'tenant_id' => 'getTenantId',
        'category_id' => 'getCategoryId',
        'supplier_id' => 'getSupplierId',
        'booking_id' => 'getBookingId',
        'supplier_booking_id' => 'getSupplierBookingId',
        'supplier_booking_reference' => 'getSupplierBookingReference',
        'customer_reference' => 'getCustomerReference',
        'booking_reference' => 'getBookingReference',
        'payment_reference' => 'getPaymentReference',
        'booking_status' => 'getBookingStatus',
        'booking_tax' => 'getBookingTax',
        'booking_price' => 'getBookingPrice',
        'booking_currency' => 'getBookingCurrency',
        'booking_cancellation_policies' => 'getBookingCancellationPolicies',
        'customer' => 'getCustomer',
        'offer_request' => 'getOfferRequest',
        'offer' => 'getOffer',
        'availability' => 'getAvailability',
        'success' => 'getSuccess',
        'error_message' => 'getErrorMessage'
    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }



    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['company_id'] = isset($data['company_id']) ? $data['company_id'] : null;
        $this->container['tenant_id'] = isset($data['tenant_id']) ? $data['tenant_id'] : null;
        $this->container['category_id'] = isset($data['category_id']) ? $data['category_id'] : null;
        $this->container['supplier_id'] = isset($data['supplier_id']) ? $data['supplier_id'] : null;
        $this->container['booking_id'] = isset($data['booking_id']) ? $data['booking_id'] : null;
        $this->container['supplier_booking_id'] = isset($data['supplier_booking_id']) ? $data['supplier_booking_id'] : null;
        $this->container['supplier_booking_reference'] = isset($data['supplier_booking_reference']) ? $data['supplier_booking_reference'] : null;
        $this->container['customer_reference'] = isset($data['customer_reference']) ? $data['customer_reference'] : null;
        $this->container['booking_reference'] = isset($data['booking_reference']) ? $data['booking_reference'] : null;
        $this->container['payment_reference'] = isset($data['payment_reference']) ? $data['payment_reference'] : null;
        $this->container['booking_status'] = isset($data['booking_status']) ? $data['booking_status'] : null;
        $this->container['booking_tax'] = isset($data['booking_tax']) ? $data['booking_tax'] : null;
        $this->container['booking_price'] = isset($data['booking_price']) ? $data['booking_price'] : null;
        $this->container['booking_currency'] = isset($data['booking_currency']) ? $data['booking_currency'] : null;
        $this->container['booking_cancellation_policies'] = isset($data['booking_cancellation_policies']) ? $data['booking_cancellation_policies'] : null;
        $this->container['customer'] = isset($data['customer']) ? $data['customer'] : null;
        $this->container['offer_request'] = isset($data['offer_request']) ? $data['offer_request'] : null;
        $this->container['offer'] = isset($data['offer']) ? $data['offer'] : null;
        $this->container['availability'] = isset($data['availability']) ? $data['availability'] : null;
        $this->container['success'] = isset($data['success']) ? $data['success'] : null;
        $this->container['error_message'] = isset($data['error_message']) ? $data['error_message'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets company_id
     *
     * @return string
     */
    public function getCompanyId()
    {
        return $this->container['company_id'];
    }

    /**
     * Sets company_id
     *
     * @param string $company_id Identifier for the company associated with the booking.
     *
     * @return $this
     */
    public function setCompanyId($company_id)
    {
        $this->container['company_id'] = $company_id;

        return $this;
    }

    /**
     * Gets tenant_id
     *
     * @return string
     */
    public function getTenantId()
    {
        return $this->container['tenant_id'];
    }

    /**
     * Sets tenant_id
     *
     * @param string $tenant_id Identifier for the tenant associated with the booking.
     *
     * @return $this
     */
    public function setTenantId($tenant_id)
    {
        $this->container['tenant_id'] = $tenant_id;

        return $this;
    }

    /**
     * Gets category_id
     *
     * @return string
     */
    public function getCategoryId()
    {
        return $this->container['category_id'];
    }

    /**
     * Sets category_id
     *
     * @param string $category_id Identifier for the category of the booking.
     *
     * @return $this
     */
    public function setCategoryId($category_id)
    {
        $this->container['category_id'] = $category_id;

        return $this;
    }

    /**
     * Gets supplier_id
     *
     * @return string
     */
    public function getSupplierId()
    {
        return $this->container['supplier_id'];
    }

    /**
     * Sets supplier_id
     *
     * @param string $supplier_id Identifier for the supplier of the booking.
     *
     * @return $this
     */
    public function setSupplierId($supplier_id)
    {
        $this->container['supplier_id'] = $supplier_id;

        return $this;
    }

    /**
     * Gets booking_id
     *
     * @return string
     */
    public function getBookingId()
    {
        return $this->container['booking_id'];
    }

    /**
     * Sets booking_id
     *
     * @param string $booking_id Unique identifier for the booking.
     *
     * @return $this
     */
    public function setBookingId($booking_id)
    {
        $this->container['booking_id'] = $booking_id;

        return $this;
    }

    /**
     * Gets supplier_booking_id
     *
     * @return string
     */
    public function getSupplierBookingId()
    {
        return $this->container['supplier_booking_id'];
    }

    /**
     * Sets supplier_booking_id
     *
     * @param string $supplier_booking_id Supplier’s identifier for the booking.
     *
     * @return $this
     */
    public function setSupplierBookingId($supplier_booking_id)
    {
        $this->container['supplier_booking_id'] = $supplier_booking_id;

        return $this;
    }

    /**
     * Gets supplier_booking_reference
     *
     * @return string
     */
    public function getSupplierBookingReference()
    {
        return $this->container['supplier_booking_reference'];
    }

    /**
     * Sets supplier_booking_reference
     *
     * @param string $supplier_booking_reference Reference number provided by the supplier for the booking.
     *
     * @return $this
     */
    public function setSupplierBookingReference($supplier_booking_reference)
    {
        $this->container['supplier_booking_reference'] = $supplier_booking_reference;

        return $this;
    }

    /**
     * Gets customer_reference
     *
     * @return string
     */
    public function getCustomerReference()
    {
        return $this->container['customer_reference'];
    }

    /**
     * Sets customer_reference
     *
     * @param string $customer_reference Customer reference number associated with the booking.
     *
     * @return $this
     */
    public function setCustomerReference($customer_reference)
    {
        $this->container['customer_reference'] = $customer_reference;

        return $this;
    }

    /**
     * Gets booking_reference
     *
     * @return string
     */
    public function getBookingReference()
    {
        return $this->container['booking_reference'];
    }

    /**
     * Sets booking_reference
     *
     * @param string $booking_reference Internal reference number for the booking.
     *
     * @return $this
     */
    public function setBookingReference($booking_reference)
    {
        $this->container['booking_reference'] = $booking_reference;

        return $this;
    }

    /**
     * Gets payment_reference
     *
     * @return string
     */
    public function getPaymentReference()
    {
        return $this->container['payment_reference'];
    }

    /**
     * Sets payment_reference
     *
     * @param string $payment_reference Reference number for the payment associated with the booking.
     *
     * @return $this
     */
    public function setPaymentReference($payment_reference)
    {
        $this->container['payment_reference'] = $payment_reference;

        return $this;
    }

    /**
     * Gets booking_status
     *
     * @return string
     */
    public function getBookingStatus()
    {
        return $this->container['booking_status'];
    }

    /**
     * Sets booking_status
     *
     * @param string $booking_status Current status of the booking.
     *
     * @return $this
     */
    public function setBookingStatus($booking_status)
    {
        $this->container['booking_status'] = $booking_status;

        return $this;
    }

    /**
     * Gets booking_tax
     *
     * @return float
     */
    public function getBookingTax()
    {
        return $this->container['booking_tax'];
    }

    /**
     * Sets booking_tax
     *
     * @param float $booking_tax Tax applied to the booking.
     *
     * @return $this
     */
    public function setBookingTax($booking_tax)
    {
        $this->container['booking_tax'] = $booking_tax;

        return $this;
    }

    /**
     * Gets booking_price
     *
     * @return float
     */
    public function getBookingPrice()
    {
        return $this->container['booking_price'];
    }

    /**
     * Sets booking_price
     *
     * @param float $booking_price Total price of the booking.
     *
     * @return $this
     */
    public function setBookingPrice($booking_price)
    {
        $this->container['booking_price'] = $booking_price;

        return $this;
    }

    /**
     * Gets booking_currency
     *
     * @return string
     */
    public function getBookingCurrency()
    {
        return $this->container['booking_currency'];
    }

    /**
     * Sets booking_currency
     *
     * @param string $booking_currency Currency used for the booking pricing.
     *
     * @return $this
     */
    public function setBookingCurrency($booking_currency)
    {
        $this->container['booking_currency'] = $booking_currency;

        return $this;
    }

    /**
     * Gets booking_cancellation_policies
     *
     * @return string
     */
    public function getBookingCancellationPolicies()
    {
        return $this->container['booking_cancellation_policies'];
    }

    /**
     * Sets booking_cancellation_policies
     *
     * @param string $booking_cancellation_policies Cancellation policies applicable to the booking.
     *
     * @return $this
     */
    public function setBookingCancellationPolicies($booking_cancellation_policies)
    {
        $this->container['booking_cancellation_policies'] = $booking_cancellation_policies;

        return $this;
    }

    /**
     * Gets customer
     *
     * @return \Swagger\Client\Model\DiningBookingCustomerSchema
     */
    public function getCustomer()
    {
        return $this->container['customer'];
    }

    /**
     * Sets customer
     *
     * @param \Swagger\Client\Model\DiningBookingCustomerSchema $customer customer
     *
     * @return $this
     */
    public function setCustomer($customer)
    {
        $this->container['customer'] = $customer;

        return $this;
    }

    /**
     * Gets offer_request
     *
     * @return \Swagger\Client\Model\DiningOfferRequestSchema
     */
    public function getOfferRequest()
    {
        return $this->container['offer_request'];
    }

    /**
     * Sets offer_request
     *
     * @param \Swagger\Client\Model\DiningOfferRequestSchema $offer_request offer_request
     *
     * @return $this
     */
    public function setOfferRequest($offer_request)
    {
        $this->container['offer_request'] = $offer_request;

        return $this;
    }

    /**
     * Gets offer
     *
     * @return \Swagger\Client\Model\DiningOfferResponseItemSchema
     */
    public function getOffer()
    {
        return $this->container['offer'];
    }

    /**
     * Sets offer
     *
     * @param \Swagger\Client\Model\DiningOfferResponseItemSchema $offer offer
     *
     * @return $this
     */
    public function setOffer($offer)
    {
        $this->container['offer'] = $offer;

        return $this;
    }

    /**
     * Gets availability
     *
     * @return \Swagger\Client\Model\DiningAvailabilitySchema
     */
    public function getAvailability()
    {
        return $this->container['availability'];
    }

    /**
     * Sets availability
     *
     * @param \Swagger\Client\Model\DiningAvailabilitySchema $availability availability
     *
     * @return $this
     */
    public function setAvailability($availability)
    {
        $this->container['availability'] = $availability;

        return $this;
    }

    /**
     * Gets success
     *
     * @return bool
     */
    public function getSuccess()
    {
        return $this->container['success'];
    }

    /**
     * Sets success
     *
     * @param bool $success Indicates if the booking was successful.
     *
     * @return $this
     */
    public function setSuccess($success)
    {
        $this->container['success'] = $success;

        return $this;
    }

    /**
     * Gets error_message
     *
     * @return string
     */
    public function getErrorMessage()
    {
        return $this->container['error_message'];
    }

    /**
     * Sets error_message
     *
     * @param string $error_message Provides details on any error that occurred during the booking process.
     *
     * @return $this
     */
    public function setErrorMessage($error_message)
    {
        $this->container['error_message'] = $error_message;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    #[\ReturnTypeWillChange]
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    #[\ReturnTypeWillChange]
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    #[\ReturnTypeWillChange]
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    #[\ReturnTypeWillChange]
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}
