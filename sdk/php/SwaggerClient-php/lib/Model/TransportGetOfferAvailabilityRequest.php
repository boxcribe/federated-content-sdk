<?php
/**
 * TransportGetOfferAvailabilityRequest
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
 * TransportGetOfferAvailabilityRequest Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class TransportGetOfferAvailabilityRequest implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'TransportGetOfferAvailabilityRequest';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'offer_id' => 'string',
        'pickup_date' => '\DateTime',
        'pickup_time' => 'string',
        'adults' => 'int',
        'children' => 'int',
        'return_date' => '\DateTime',
        'return_time' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'offer_id' => 'uuid',
        'pickup_date' => 'date',
        'pickup_time' => 'time',
        'adults' => null,
        'children' => null,
        'return_date' => 'date',
        'return_time' => 'time'
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
        'offer_id' => 'offer_id',
        'pickup_date' => 'pickup_date',
        'pickup_time' => 'pickup_time',
        'adults' => 'adults',
        'children' => 'children',
        'return_date' => 'return_date',
        'return_time' => 'return_time'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'offer_id' => 'setOfferId',
        'pickup_date' => 'setPickupDate',
        'pickup_time' => 'setPickupTime',
        'adults' => 'setAdults',
        'children' => 'setChildren',
        'return_date' => 'setReturnDate',
        'return_time' => 'setReturnTime'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'offer_id' => 'getOfferId',
        'pickup_date' => 'getPickupDate',
        'pickup_time' => 'getPickupTime',
        'adults' => 'getAdults',
        'children' => 'getChildren',
        'return_date' => 'getReturnDate',
        'return_time' => 'getReturnTime'
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
        $this->container['offer_id'] = isset($data['offer_id']) ? $data['offer_id'] : null;
        $this->container['pickup_date'] = isset($data['pickup_date']) ? $data['pickup_date'] : null;
        $this->container['pickup_time'] = isset($data['pickup_time']) ? $data['pickup_time'] : null;
        $this->container['adults'] = isset($data['adults']) ? $data['adults'] : null;
        $this->container['children'] = isset($data['children']) ? $data['children'] : null;
        $this->container['return_date'] = isset($data['return_date']) ? $data['return_date'] : null;
        $this->container['return_time'] = isset($data['return_time']) ? $data['return_time'] : null;
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
     * Gets offer_id
     *
     * @return string
     */
    public function getOfferId()
    {
        return $this->container['offer_id'];
    }

    /**
     * Sets offer_id
     *
     * @param string $offer_id Unique identifier of the transport offer.
     *
     * @return $this
     */
    public function setOfferId($offer_id)
    {
        $this->container['offer_id'] = $offer_id;

        return $this;
    }

    /**
     * Gets pickup_date
     *
     * @return \DateTime
     */
    public function getPickupDate()
    {
        return $this->container['pickup_date'];
    }

    /**
     * Sets pickup_date
     *
     * @param \DateTime $pickup_date Date of the pickup.
     *
     * @return $this
     */
    public function setPickupDate($pickup_date)
    {
        $this->container['pickup_date'] = $pickup_date;

        return $this;
    }

    /**
     * Gets pickup_time
     *
     * @return string
     */
    public function getPickupTime()
    {
        return $this->container['pickup_time'];
    }

    /**
     * Sets pickup_time
     *
     * @param string $pickup_time Time of the pickup.
     *
     * @return $this
     */
    public function setPickupTime($pickup_time)
    {
        $this->container['pickup_time'] = $pickup_time;

        return $this;
    }

    /**
     * Gets adults
     *
     * @return int
     */
    public function getAdults()
    {
        return $this->container['adults'];
    }

    /**
     * Sets adults
     *
     * @param int $adults Number of adults.
     *
     * @return $this
     */
    public function setAdults($adults)
    {
        $this->container['adults'] = $adults;

        return $this;
    }

    /**
     * Gets children
     *
     * @return int
     */
    public function getChildren()
    {
        return $this->container['children'];
    }

    /**
     * Sets children
     *
     * @param int $children Number of children.
     *
     * @return $this
     */
    public function setChildren($children)
    {
        $this->container['children'] = $children;

        return $this;
    }

    /**
     * Gets return_date
     *
     * @return \DateTime
     */
    public function getReturnDate()
    {
        return $this->container['return_date'];
    }

    /**
     * Sets return_date
     *
     * @param \DateTime $return_date Date of the return.
     *
     * @return $this
     */
    public function setReturnDate($return_date)
    {
        $this->container['return_date'] = $return_date;

        return $this;
    }

    /**
     * Gets return_time
     *
     * @return string
     */
    public function getReturnTime()
    {
        return $this->container['return_time'];
    }

    /**
     * Sets return_time
     *
     * @param string $return_time Time of the return.
     *
     * @return $this
     */
    public function setReturnTime($return_time)
    {
        $this->container['return_time'] = $return_time;

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