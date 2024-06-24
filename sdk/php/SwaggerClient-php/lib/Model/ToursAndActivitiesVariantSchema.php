<?php
/**
 * ToursAndActivitiesVariantSchema
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
 * ToursAndActivitiesVariantSchema Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ToursAndActivitiesVariantSchema implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ToursAndActivitiesVariantSchema';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'variant_id' => 'string',
        'supplier_variant_id' => 'string',
        'variant_index' => 'int',
        'variant_tax' => 'float',
        'variant_price' => 'float',
        'variant_currency' => 'string',
        'variant_cancellation_policies' => 'string',
        'date' => '\DateTime',
        'start_time' => 'string',
        'adults' => 'int',
        'children' => 'int',
        'variant_name' => 'string',
        'variant_description' => 'string',
        'variant_address' => 'string',
        'variant_latitude' => 'float',
        'variant_longitude' => 'float',
        'variant_distance' => 'float',
        'variant_distance_metric' => 'string',
        'variant_images' => 'string[]',
        'variant_rating' => 'float',
        'variant_reviews' => 'string[]',
        'variant_subcategories' => 'string[]',
        'booking_questions' => 'string[]'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'variant_id' => 'uuid',
        'supplier_variant_id' => 'uuid',
        'variant_index' => null,
        'variant_tax' => 'decimal',
        'variant_price' => 'decimal',
        'variant_currency' => null,
        'variant_cancellation_policies' => null,
        'date' => 'date',
        'start_time' => 'time',
        'adults' => null,
        'children' => null,
        'variant_name' => null,
        'variant_description' => null,
        'variant_address' => null,
        'variant_latitude' => 'float',
        'variant_longitude' => 'float',
        'variant_distance' => 'decimal',
        'variant_distance_metric' => null,
        'variant_images' => null,
        'variant_rating' => 'decimal',
        'variant_reviews' => null,
        'variant_subcategories' => null,
        'booking_questions' => null
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
        'variant_id' => 'variant_id',
        'supplier_variant_id' => 'supplier_variant_id',
        'variant_index' => 'variant_index',
        'variant_tax' => 'variant_tax',
        'variant_price' => 'variant_price',
        'variant_currency' => 'variant_currency',
        'variant_cancellation_policies' => 'variant_cancellation_policies',
        'date' => 'date',
        'start_time' => 'startTime',
        'adults' => 'adults',
        'children' => 'children',
        'variant_name' => 'variant_name',
        'variant_description' => 'variant_description',
        'variant_address' => 'variant_address',
        'variant_latitude' => 'variant_latitude',
        'variant_longitude' => 'variant_longitude',
        'variant_distance' => 'variant_distance',
        'variant_distance_metric' => 'variant_distance_metric',
        'variant_images' => 'variant_images',
        'variant_rating' => 'variant_rating',
        'variant_reviews' => 'variant_reviews',
        'variant_subcategories' => 'variant_subcategories',
        'booking_questions' => 'booking_questions'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'variant_id' => 'setVariantId',
        'supplier_variant_id' => 'setSupplierVariantId',
        'variant_index' => 'setVariantIndex',
        'variant_tax' => 'setVariantTax',
        'variant_price' => 'setVariantPrice',
        'variant_currency' => 'setVariantCurrency',
        'variant_cancellation_policies' => 'setVariantCancellationPolicies',
        'date' => 'setDate',
        'start_time' => 'setStartTime',
        'adults' => 'setAdults',
        'children' => 'setChildren',
        'variant_name' => 'setVariantName',
        'variant_description' => 'setVariantDescription',
        'variant_address' => 'setVariantAddress',
        'variant_latitude' => 'setVariantLatitude',
        'variant_longitude' => 'setVariantLongitude',
        'variant_distance' => 'setVariantDistance',
        'variant_distance_metric' => 'setVariantDistanceMetric',
        'variant_images' => 'setVariantImages',
        'variant_rating' => 'setVariantRating',
        'variant_reviews' => 'setVariantReviews',
        'variant_subcategories' => 'setVariantSubcategories',
        'booking_questions' => 'setBookingQuestions'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'variant_id' => 'getVariantId',
        'supplier_variant_id' => 'getSupplierVariantId',
        'variant_index' => 'getVariantIndex',
        'variant_tax' => 'getVariantTax',
        'variant_price' => 'getVariantPrice',
        'variant_currency' => 'getVariantCurrency',
        'variant_cancellation_policies' => 'getVariantCancellationPolicies',
        'date' => 'getDate',
        'start_time' => 'getStartTime',
        'adults' => 'getAdults',
        'children' => 'getChildren',
        'variant_name' => 'getVariantName',
        'variant_description' => 'getVariantDescription',
        'variant_address' => 'getVariantAddress',
        'variant_latitude' => 'getVariantLatitude',
        'variant_longitude' => 'getVariantLongitude',
        'variant_distance' => 'getVariantDistance',
        'variant_distance_metric' => 'getVariantDistanceMetric',
        'variant_images' => 'getVariantImages',
        'variant_rating' => 'getVariantRating',
        'variant_reviews' => 'getVariantReviews',
        'variant_subcategories' => 'getVariantSubcategories',
        'booking_questions' => 'getBookingQuestions'
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
        $this->container['variant_id'] = isset($data['variant_id']) ? $data['variant_id'] : null;
        $this->container['supplier_variant_id'] = isset($data['supplier_variant_id']) ? $data['supplier_variant_id'] : null;
        $this->container['variant_index'] = isset($data['variant_index']) ? $data['variant_index'] : null;
        $this->container['variant_tax'] = isset($data['variant_tax']) ? $data['variant_tax'] : null;
        $this->container['variant_price'] = isset($data['variant_price']) ? $data['variant_price'] : null;
        $this->container['variant_currency'] = isset($data['variant_currency']) ? $data['variant_currency'] : null;
        $this->container['variant_cancellation_policies'] = isset($data['variant_cancellation_policies']) ? $data['variant_cancellation_policies'] : null;
        $this->container['date'] = isset($data['date']) ? $data['date'] : null;
        $this->container['start_time'] = isset($data['start_time']) ? $data['start_time'] : null;
        $this->container['adults'] = isset($data['adults']) ? $data['adults'] : null;
        $this->container['children'] = isset($data['children']) ? $data['children'] : null;
        $this->container['variant_name'] = isset($data['variant_name']) ? $data['variant_name'] : null;
        $this->container['variant_description'] = isset($data['variant_description']) ? $data['variant_description'] : null;
        $this->container['variant_address'] = isset($data['variant_address']) ? $data['variant_address'] : null;
        $this->container['variant_latitude'] = isset($data['variant_latitude']) ? $data['variant_latitude'] : null;
        $this->container['variant_longitude'] = isset($data['variant_longitude']) ? $data['variant_longitude'] : null;
        $this->container['variant_distance'] = isset($data['variant_distance']) ? $data['variant_distance'] : null;
        $this->container['variant_distance_metric'] = isset($data['variant_distance_metric']) ? $data['variant_distance_metric'] : null;
        $this->container['variant_images'] = isset($data['variant_images']) ? $data['variant_images'] : null;
        $this->container['variant_rating'] = isset($data['variant_rating']) ? $data['variant_rating'] : null;
        $this->container['variant_reviews'] = isset($data['variant_reviews']) ? $data['variant_reviews'] : null;
        $this->container['variant_subcategories'] = isset($data['variant_subcategories']) ? $data['variant_subcategories'] : null;
        $this->container['booking_questions'] = isset($data['booking_questions']) ? $data['booking_questions'] : null;
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
     * Gets variant_id
     *
     * @return string
     */
    public function getVariantId()
    {
        return $this->container['variant_id'];
    }

    /**
     * Sets variant_id
     *
     * @param string $variant_id Unique identifier for the tour variant.
     *
     * @return $this
     */
    public function setVariantId($variant_id)
    {
        $this->container['variant_id'] = $variant_id;

        return $this;
    }

    /**
     * Gets supplier_variant_id
     *
     * @return string
     */
    public function getSupplierVariantId()
    {
        return $this->container['supplier_variant_id'];
    }

    /**
     * Sets supplier_variant_id
     *
     * @param string $supplier_variant_id Identifier given by the supplier for the variant.
     *
     * @return $this
     */
    public function setSupplierVariantId($supplier_variant_id)
    {
        $this->container['supplier_variant_id'] = $supplier_variant_id;

        return $this;
    }

    /**
     * Gets variant_index
     *
     * @return int
     */
    public function getVariantIndex()
    {
        return $this->container['variant_index'];
    }

    /**
     * Sets variant_index
     *
     * @param int $variant_index Index of the variant for ordering.
     *
     * @return $this
     */
    public function setVariantIndex($variant_index)
    {
        $this->container['variant_index'] = $variant_index;

        return $this;
    }

    /**
     * Gets variant_tax
     *
     * @return float
     */
    public function getVariantTax()
    {
        return $this->container['variant_tax'];
    }

    /**
     * Sets variant_tax
     *
     * @param float $variant_tax Tax applied to the variant price.
     *
     * @return $this
     */
    public function setVariantTax($variant_tax)
    {
        $this->container['variant_tax'] = $variant_tax;

        return $this;
    }

    /**
     * Gets variant_price
     *
     * @return float
     */
    public function getVariantPrice()
    {
        return $this->container['variant_price'];
    }

    /**
     * Sets variant_price
     *
     * @param float $variant_price Price of the tour variant.
     *
     * @return $this
     */
    public function setVariantPrice($variant_price)
    {
        $this->container['variant_price'] = $variant_price;

        return $this;
    }

    /**
     * Gets variant_currency
     *
     * @return string
     */
    public function getVariantCurrency()
    {
        return $this->container['variant_currency'];
    }

    /**
     * Sets variant_currency
     *
     * @param string $variant_currency Currency of the variant price.
     *
     * @return $this
     */
    public function setVariantCurrency($variant_currency)
    {
        $this->container['variant_currency'] = $variant_currency;

        return $this;
    }

    /**
     * Gets variant_cancellation_policies
     *
     * @return string
     */
    public function getVariantCancellationPolicies()
    {
        return $this->container['variant_cancellation_policies'];
    }

    /**
     * Sets variant_cancellation_policies
     *
     * @param string $variant_cancellation_policies Cancellation policies applicable to the tour variant.
     *
     * @return $this
     */
    public function setVariantCancellationPolicies($variant_cancellation_policies)
    {
        $this->container['variant_cancellation_policies'] = $variant_cancellation_policies;

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
     * @param \DateTime $date Date of the tour.
     *
     * @return $this
     */
    public function setDate($date)
    {
        $this->container['date'] = $date;

        return $this;
    }

    /**
     * Gets start_time
     *
     * @return string
     */
    public function getStartTime()
    {
        return $this->container['start_time'];
    }

    /**
     * Sets start_time
     *
     * @param string $start_time Start time of the tour.
     *
     * @return $this
     */
    public function setStartTime($start_time)
    {
        $this->container['start_time'] = $start_time;

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
     * @param int $adults Number of adults for the tour.
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
     * @param int $children Number of children for the tour.
     *
     * @return $this
     */
    public function setChildren($children)
    {
        $this->container['children'] = $children;

        return $this;
    }

    /**
     * Gets variant_name
     *
     * @return string
     */
    public function getVariantName()
    {
        return $this->container['variant_name'];
    }

    /**
     * Sets variant_name
     *
     * @param string $variant_name Name of the tour variant.
     *
     * @return $this
     */
    public function setVariantName($variant_name)
    {
        $this->container['variant_name'] = $variant_name;

        return $this;
    }

    /**
     * Gets variant_description
     *
     * @return string
     */
    public function getVariantDescription()
    {
        return $this->container['variant_description'];
    }

    /**
     * Sets variant_description
     *
     * @param string $variant_description Description of the tour variant.
     *
     * @return $this
     */
    public function setVariantDescription($variant_description)
    {
        $this->container['variant_description'] = $variant_description;

        return $this;
    }

    /**
     * Gets variant_address
     *
     * @return string
     */
    public function getVariantAddress()
    {
        return $this->container['variant_address'];
    }

    /**
     * Sets variant_address
     *
     * @param string $variant_address Address where the tour variant takes place.
     *
     * @return $this
     */
    public function setVariantAddress($variant_address)
    {
        $this->container['variant_address'] = $variant_address;

        return $this;
    }

    /**
     * Gets variant_latitude
     *
     * @return float
     */
    public function getVariantLatitude()
    {
        return $this->container['variant_latitude'];
    }

    /**
     * Sets variant_latitude
     *
     * @param float $variant_latitude Latitude coordinate of the tour location.
     *
     * @return $this
     */
    public function setVariantLatitude($variant_latitude)
    {
        $this->container['variant_latitude'] = $variant_latitude;

        return $this;
    }

    /**
     * Gets variant_longitude
     *
     * @return float
     */
    public function getVariantLongitude()
    {
        return $this->container['variant_longitude'];
    }

    /**
     * Sets variant_longitude
     *
     * @param float $variant_longitude Longitude coordinate of the tour location.
     *
     * @return $this
     */
    public function setVariantLongitude($variant_longitude)
    {
        $this->container['variant_longitude'] = $variant_longitude;

        return $this;
    }

    /**
     * Gets variant_distance
     *
     * @return float
     */
    public function getVariantDistance()
    {
        return $this->container['variant_distance'];
    }

    /**
     * Sets variant_distance
     *
     * @param float $variant_distance Distance covered during the tour.
     *
     * @return $this
     */
    public function setVariantDistance($variant_distance)
    {
        $this->container['variant_distance'] = $variant_distance;

        return $this;
    }

    /**
     * Gets variant_distance_metric
     *
     * @return string
     */
    public function getVariantDistanceMetric()
    {
        return $this->container['variant_distance_metric'];
    }

    /**
     * Sets variant_distance_metric
     *
     * @param string $variant_distance_metric Metric used for distance measurement (miles or kilometers).
     *
     * @return $this
     */
    public function setVariantDistanceMetric($variant_distance_metric)
    {
        $this->container['variant_distance_metric'] = $variant_distance_metric;

        return $this;
    }

    /**
     * Gets variant_images
     *
     * @return string[]
     */
    public function getVariantImages()
    {
        return $this->container['variant_images'];
    }

    /**
     * Sets variant_images
     *
     * @param string[] $variant_images Array of images related to the tour variant.
     *
     * @return $this
     */
    public function setVariantImages($variant_images)
    {
        $this->container['variant_images'] = $variant_images;

        return $this;
    }

    /**
     * Gets variant_rating
     *
     * @return float
     */
    public function getVariantRating()
    {
        return $this->container['variant_rating'];
    }

    /**
     * Sets variant_rating
     *
     * @param float $variant_rating Rating of the tour variant.
     *
     * @return $this
     */
    public function setVariantRating($variant_rating)
    {
        $this->container['variant_rating'] = $variant_rating;

        return $this;
    }

    /**
     * Gets variant_reviews
     *
     * @return string[]
     */
    public function getVariantReviews()
    {
        return $this->container['variant_reviews'];
    }

    /**
     * Sets variant_reviews
     *
     * @param string[] $variant_reviews Collection of reviews for the tour variant.
     *
     * @return $this
     */
    public function setVariantReviews($variant_reviews)
    {
        $this->container['variant_reviews'] = $variant_reviews;

        return $this;
    }

    /**
     * Gets variant_subcategories
     *
     * @return string[]
     */
    public function getVariantSubcategories()
    {
        return $this->container['variant_subcategories'];
    }

    /**
     * Sets variant_subcategories
     *
     * @param string[] $variant_subcategories Subcategories of the tour variant.
     *
     * @return $this
     */
    public function setVariantSubcategories($variant_subcategories)
    {
        $this->container['variant_subcategories'] = $variant_subcategories;

        return $this;
    }

    /**
     * Gets booking_questions
     *
     * @return string[]
     */
    public function getBookingQuestions()
    {
        return $this->container['booking_questions'];
    }

    /**
     * Sets booking_questions
     *
     * @param string[] $booking_questions Questions related to booking the tour variant.
     *
     * @return $this
     */
    public function setBookingQuestions($booking_questions)
    {
        $this->container['booking_questions'] = $booking_questions;

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
