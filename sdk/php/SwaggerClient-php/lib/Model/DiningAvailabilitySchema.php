<?php
/**
 * DiningAvailabilitySchema
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
 * DiningAvailabilitySchema Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class DiningAvailabilitySchema implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'DiningAvailabilitySchema';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'availability_id' => 'string',
        'supplier_availability_id' => 'string',
        'availability_index' => 'float',
        'date' => '\DateTime',
        'time' => 'string',
        'adults' => 'float'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'availability_id' => 'uuid',
        'supplier_availability_id' => 'uuid',
        'availability_index' => 'integer',
        'date' => 'date',
        'time' => 'time',
        'adults' => 'integer'
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
        'availability_id' => 'availability_id',
        'supplier_availability_id' => 'supplier_availability_id',
        'availability_index' => 'availability_index',
        'date' => 'date',
        'time' => 'time',
        'adults' => 'adults'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'availability_id' => 'setAvailabilityId',
        'supplier_availability_id' => 'setSupplierAvailabilityId',
        'availability_index' => 'setAvailabilityIndex',
        'date' => 'setDate',
        'time' => 'setTime',
        'adults' => 'setAdults'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'availability_id' => 'getAvailabilityId',
        'supplier_availability_id' => 'getSupplierAvailabilityId',
        'availability_index' => 'getAvailabilityIndex',
        'date' => 'getDate',
        'time' => 'getTime',
        'adults' => 'getAdults'
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
        $this->container['availability_id'] = isset($data['availability_id']) ? $data['availability_id'] : null;
        $this->container['supplier_availability_id'] = isset($data['supplier_availability_id']) ? $data['supplier_availability_id'] : null;
        $this->container['availability_index'] = isset($data['availability_index']) ? $data['availability_index'] : null;
        $this->container['date'] = isset($data['date']) ? $data['date'] : null;
        $this->container['time'] = isset($data['time']) ? $data['time'] : null;
        $this->container['adults'] = isset($data['adults']) ? $data['adults'] : null;
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
     * Gets availability_id
     *
     * @return string
     */
    public function getAvailabilityId()
    {
        return $this->container['availability_id'];
    }

    /**
     * Sets availability_id
     *
     * @param string $availability_id Unique identifier for the dining availability.
     *
     * @return $this
     */
    public function setAvailabilityId($availability_id)
    {
        $this->container['availability_id'] = $availability_id;

        return $this;
    }

    /**
     * Gets supplier_availability_id
     *
     * @return string
     */
    public function getSupplierAvailabilityId()
    {
        return $this->container['supplier_availability_id'];
    }

    /**
     * Sets supplier_availability_id
     *
     * @param string $supplier_availability_id Identifier for the availability provided by the supplier.
     *
     * @return $this
     */
    public function setSupplierAvailabilityId($supplier_availability_id)
    {
        $this->container['supplier_availability_id'] = $supplier_availability_id;

        return $this;
    }

    /**
     * Gets availability_index
     *
     * @return float
     */
    public function getAvailabilityIndex()
    {
        return $this->container['availability_index'];
    }

    /**
     * Sets availability_index
     *
     * @param float $availability_index Index of the availability for sorting and reference.
     *
     * @return $this
     */
    public function setAvailabilityIndex($availability_index)
    {
        $this->container['availability_index'] = $availability_index;

        return $this;
    }

    /**
     * Gets date
     *
     * @return \DateTime
     */
    public function getDate()
    {
        return $this->container['date'];
    }

    /**
     * Sets date
     *
     * @param \DateTime $date Date of availability for dining.
     *
     * @return $this
     */
    public function setDate($date)
    {
        $this->container['date'] = $date;

        return $this;
    }

    /**
     * Gets time
     *
     * @return string
     */
    public function getTime()
    {
        return $this->container['time'];
    }

    /**
     * Sets time
     *
     * @param string $time Time of availability for dining.
     *
     * @return $this
     */
    public function setTime($time)
    {
        $this->container['time'] = $time;

        return $this;
    }

    /**
     * Gets adults
     *
     * @return float
     */
    public function getAdults()
    {
        return $this->container['adults'];
    }

    /**
     * Sets adults
     *
     * @param float $adults Number of adults for the dining reservation.
     *
     * @return $this
     */
    public function setAdults($adults)
    {
        $this->container['adults'] = $adults;

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
