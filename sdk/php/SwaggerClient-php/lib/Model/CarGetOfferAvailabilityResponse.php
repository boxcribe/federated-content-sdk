<?php
/**
 * CarGetOfferAvailabilityResponse
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
 * CarGetOfferAvailabilityResponse Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class CarGetOfferAvailabilityResponse implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'CarGetOfferAvailabilityResponse';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'offer_id' => 'string',
        'supplier_offer_id' => 'string',
        'offer_index' => 'int',
        'offer_tax' => 'double',
        'offer_price' => 'double',
        'offer_currency' => 'string',
        'offer_cancelation_policies' => 'map[string,object]',
        'pickup_date' => '\DateTime',
        'pickup_time' => 'string',
        'dropoff_date' => '\DateTime',
        'dropoff_time' => 'string',
        'car_name' => 'string',
        'car_description' => 'string',
        'car_address' => 'string',
        'car_latitude' => 'float',
        'car_longitude' => 'float',
        'car_distance' => 'float',
        'car_distance_metric' => 'string',
        'car_images' => 'string[]',
        'car_rating' => 'double',
        'car_reviews' => 'int',
        'car_type' => 'string',
        'car_class' => 'string',
        'car_company' => 'string',
        'car_company_logo' => 'string',
        'car_passengers_number' => 'int',
        'car_bags_number' => 'int'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'offer_id' => 'uuid',
        'supplier_offer_id' => 'uuid',
        'offer_index' => null,
        'offer_tax' => 'double',
        'offer_price' => 'double',
        'offer_currency' => null,
        'offer_cancelation_policies' => null,
        'pickup_date' => 'date',
        'pickup_time' => 'time',
        'dropoff_date' => 'date',
        'dropoff_time' => 'time',
        'car_name' => null,
        'car_description' => null,
        'car_address' => null,
        'car_latitude' => 'float',
        'car_longitude' => 'float',
        'car_distance' => null,
        'car_distance_metric' => null,
        'car_images' => null,
        'car_rating' => 'double',
        'car_reviews' => null,
        'car_type' => null,
        'car_class' => null,
        'car_company' => null,
        'car_company_logo' => null,
        'car_passengers_number' => null,
        'car_bags_number' => null
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
        'supplier_offer_id' => 'supplier_offer_id',
        'offer_index' => 'offer_index',
        'offer_tax' => 'offer_tax',
        'offer_price' => 'offer_price',
        'offer_currency' => 'offer_currency',
        'offer_cancelation_policies' => 'offer_cancelation_policies',
        'pickup_date' => 'pickup_date',
        'pickup_time' => 'pickup_time',
        'dropoff_date' => 'dropoff_date',
        'dropoff_time' => 'dropoff_time',
        'car_name' => 'car_name',
        'car_description' => 'car_description',
        'car_address' => 'car_address',
        'car_latitude' => 'car_latitude',
        'car_longitude' => 'car_longitude',
        'car_distance' => 'car_distance',
        'car_distance_metric' => 'car_distance_metric',
        'car_images' => 'car_images',
        'car_rating' => 'car_rating',
        'car_reviews' => 'car_reviews',
        'car_type' => 'car_type',
        'car_class' => 'car_class',
        'car_company' => 'car_company',
        'car_company_logo' => 'car_company_logo',
        'car_passengers_number' => 'car_passengers_number',
        'car_bags_number' => 'car_bags_number'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'offer_id' => 'setOfferId',
        'supplier_offer_id' => 'setSupplierOfferId',
        'offer_index' => 'setOfferIndex',
        'offer_tax' => 'setOfferTax',
        'offer_price' => 'setOfferPrice',
        'offer_currency' => 'setOfferCurrency',
        'offer_cancelation_policies' => 'setOfferCancelationPolicies',
        'pickup_date' => 'setPickupDate',
        'pickup_time' => 'setPickupTime',
        'dropoff_date' => 'setDropoffDate',
        'dropoff_time' => 'setDropoffTime',
        'car_name' => 'setCarName',
        'car_description' => 'setCarDescription',
        'car_address' => 'setCarAddress',
        'car_latitude' => 'setCarLatitude',
        'car_longitude' => 'setCarLongitude',
        'car_distance' => 'setCarDistance',
        'car_distance_metric' => 'setCarDistanceMetric',
        'car_images' => 'setCarImages',
        'car_rating' => 'setCarRating',
        'car_reviews' => 'setCarReviews',
        'car_type' => 'setCarType',
        'car_class' => 'setCarClass',
        'car_company' => 'setCarCompany',
        'car_company_logo' => 'setCarCompanyLogo',
        'car_passengers_number' => 'setCarPassengersNumber',
        'car_bags_number' => 'setCarBagsNumber'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'offer_id' => 'getOfferId',
        'supplier_offer_id' => 'getSupplierOfferId',
        'offer_index' => 'getOfferIndex',
        'offer_tax' => 'getOfferTax',
        'offer_price' => 'getOfferPrice',
        'offer_currency' => 'getOfferCurrency',
        'offer_cancelation_policies' => 'getOfferCancelationPolicies',
        'pickup_date' => 'getPickupDate',
        'pickup_time' => 'getPickupTime',
        'dropoff_date' => 'getDropoffDate',
        'dropoff_time' => 'getDropoffTime',
        'car_name' => 'getCarName',
        'car_description' => 'getCarDescription',
        'car_address' => 'getCarAddress',
        'car_latitude' => 'getCarLatitude',
        'car_longitude' => 'getCarLongitude',
        'car_distance' => 'getCarDistance',
        'car_distance_metric' => 'getCarDistanceMetric',
        'car_images' => 'getCarImages',
        'car_rating' => 'getCarRating',
        'car_reviews' => 'getCarReviews',
        'car_type' => 'getCarType',
        'car_class' => 'getCarClass',
        'car_company' => 'getCarCompany',
        'car_company_logo' => 'getCarCompanyLogo',
        'car_passengers_number' => 'getCarPassengersNumber',
        'car_bags_number' => 'getCarBagsNumber'
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
        $this->container['supplier_offer_id'] = isset($data['supplier_offer_id']) ? $data['supplier_offer_id'] : null;
        $this->container['offer_index'] = isset($data['offer_index']) ? $data['offer_index'] : null;
        $this->container['offer_tax'] = isset($data['offer_tax']) ? $data['offer_tax'] : null;
        $this->container['offer_price'] = isset($data['offer_price']) ? $data['offer_price'] : null;
        $this->container['offer_currency'] = isset($data['offer_currency']) ? $data['offer_currency'] : null;
        $this->container['offer_cancelation_policies'] = isset($data['offer_cancelation_policies']) ? $data['offer_cancelation_policies'] : null;
        $this->container['pickup_date'] = isset($data['pickup_date']) ? $data['pickup_date'] : null;
        $this->container['pickup_time'] = isset($data['pickup_time']) ? $data['pickup_time'] : null;
        $this->container['dropoff_date'] = isset($data['dropoff_date']) ? $data['dropoff_date'] : null;
        $this->container['dropoff_time'] = isset($data['dropoff_time']) ? $data['dropoff_time'] : null;
        $this->container['car_name'] = isset($data['car_name']) ? $data['car_name'] : null;
        $this->container['car_description'] = isset($data['car_description']) ? $data['car_description'] : null;
        $this->container['car_address'] = isset($data['car_address']) ? $data['car_address'] : null;
        $this->container['car_latitude'] = isset($data['car_latitude']) ? $data['car_latitude'] : null;
        $this->container['car_longitude'] = isset($data['car_longitude']) ? $data['car_longitude'] : null;
        $this->container['car_distance'] = isset($data['car_distance']) ? $data['car_distance'] : null;
        $this->container['car_distance_metric'] = isset($data['car_distance_metric']) ? $data['car_distance_metric'] : null;
        $this->container['car_images'] = isset($data['car_images']) ? $data['car_images'] : null;
        $this->container['car_rating'] = isset($data['car_rating']) ? $data['car_rating'] : null;
        $this->container['car_reviews'] = isset($data['car_reviews']) ? $data['car_reviews'] : null;
        $this->container['car_type'] = isset($data['car_type']) ? $data['car_type'] : null;
        $this->container['car_class'] = isset($data['car_class']) ? $data['car_class'] : null;
        $this->container['car_company'] = isset($data['car_company']) ? $data['car_company'] : null;
        $this->container['car_company_logo'] = isset($data['car_company_logo']) ? $data['car_company_logo'] : null;
        $this->container['car_passengers_number'] = isset($data['car_passengers_number']) ? $data['car_passengers_number'] : null;
        $this->container['car_bags_number'] = isset($data['car_bags_number']) ? $data['car_bags_number'] : null;
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
     * @param string $offer_id Unique identifier for the car offer.
     *
     * @return $this
     */
    public function setOfferId($offer_id)
    {
        $this->container['offer_id'] = $offer_id;

        return $this;
    }

    /**
     * Gets supplier_offer_id
     *
     * @return string
     */
    public function getSupplierOfferId()
    {
        return $this->container['supplier_offer_id'];
    }

    /**
     * Sets supplier_offer_id
     *
     * @param string $supplier_offer_id Unique identifier for the supplier’s offer.
     *
     * @return $this
     */
    public function setSupplierOfferId($supplier_offer_id)
    {
        $this->container['supplier_offer_id'] = $supplier_offer_id;

        return $this;
    }

    /**
     * Gets offer_index
     *
     * @return int
     */
    public function getOfferIndex()
    {
        return $this->container['offer_index'];
    }

    /**
     * Sets offer_index
     *
     * @param int $offer_index Index of the offer for sorting purposes.
     *
     * @return $this
     */
    public function setOfferIndex($offer_index)
    {
        $this->container['offer_index'] = $offer_index;

        return $this;
    }

    /**
     * Gets offer_tax
     *
     * @return double
     */
    public function getOfferTax()
    {
        return $this->container['offer_tax'];
    }

    /**
     * Sets offer_tax
     *
     * @param double $offer_tax Tax applied to the offer.
     *
     * @return $this
     */
    public function setOfferTax($offer_tax)
    {
        $this->container['offer_tax'] = $offer_tax;

        return $this;
    }

    /**
     * Gets offer_price
     *
     * @return double
     */
    public function getOfferPrice()
    {
        return $this->container['offer_price'];
    }

    /**
     * Sets offer_price
     *
     * @param double $offer_price Price of the offer.
     *
     * @return $this
     */
    public function setOfferPrice($offer_price)
    {
        $this->container['offer_price'] = $offer_price;

        return $this;
    }

    /**
     * Gets offer_currency
     *
     * @return string
     */
    public function getOfferCurrency()
    {
        return $this->container['offer_currency'];
    }

    /**
     * Sets offer_currency
     *
     * @param string $offer_currency Currency of the offer price.
     *
     * @return $this
     */
    public function setOfferCurrency($offer_currency)
    {
        $this->container['offer_currency'] = $offer_currency;

        return $this;
    }

    /**
     * Gets offer_cancelation_policies
     *
     * @return map[string,object]
     */
    public function getOfferCancelationPolicies()
    {
        return $this->container['offer_cancelation_policies'];
    }

    /**
     * Sets offer_cancelation_policies
     *
     * @param map[string,object] $offer_cancelation_policies Cancellation policies applicable to the offer.
     *
     * @return $this
     */
    public function setOfferCancelationPolicies($offer_cancelation_policies)
    {
        $this->container['offer_cancelation_policies'] = $offer_cancelation_policies;

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
     * @param \DateTime $pickup_date Scheduled date for car pickup.
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
     * @param string $pickup_time Scheduled time for car pickup.
     *
     * @return $this
     */
    public function setPickupTime($pickup_time)
    {
        $this->container['pickup_time'] = $pickup_time;

        return $this;
    }

    /**
     * Gets dropoff_date
     *
     * @return \DateTime
     */
    public function getDropoffDate()
    {
        return $this->container['dropoff_date'];
    }

    /**
     * Sets dropoff_date
     *
     * @param \DateTime $dropoff_date Scheduled date for car dropoff.
     *
     * @return $this
     */
    public function setDropoffDate($dropoff_date)
    {
        $this->container['dropoff_date'] = $dropoff_date;

        return $this;
    }

    /**
     * Gets dropoff_time
     *
     * @return string
     */
    public function getDropoffTime()
    {
        return $this->container['dropoff_time'];
    }

    /**
     * Sets dropoff_time
     *
     * @param string $dropoff_time Scheduled time for car dropoff.
     *
     * @return $this
     */
    public function setDropoffTime($dropoff_time)
    {
        $this->container['dropoff_time'] = $dropoff_time;

        return $this;
    }

    /**
     * Gets car_name
     *
     * @return string
     */
    public function getCarName()
    {
        return $this->container['car_name'];
    }

    /**
     * Sets car_name
     *
     * @param string $car_name Name of the car model.
     *
     * @return $this
     */
    public function setCarName($car_name)
    {
        $this->container['car_name'] = $car_name;

        return $this;
    }

    /**
     * Gets car_description
     *
     * @return string
     */
    public function getCarDescription()
    {
        return $this->container['car_description'];
    }

    /**
     * Sets car_description
     *
     * @param string $car_description Description of the car.
     *
     * @return $this
     */
    public function setCarDescription($car_description)
    {
        $this->container['car_description'] = $car_description;

        return $this;
    }

    /**
     * Gets car_address
     *
     * @return string
     */
    public function getCarAddress()
    {
        return $this->container['car_address'];
    }

    /**
     * Sets car_address
     *
     * @param string $car_address Address where the car can be picked up.
     *
     * @return $this
     */
    public function setCarAddress($car_address)
    {
        $this->container['car_address'] = $car_address;

        return $this;
    }

    /**
     * Gets car_latitude
     *
     * @return float
     */
    public function getCarLatitude()
    {
        return $this->container['car_latitude'];
    }

    /**
     * Sets car_latitude
     *
     * @param float $car_latitude Latitude of the car pickup location.
     *
     * @return $this
     */
    public function setCarLatitude($car_latitude)
    {
        $this->container['car_latitude'] = $car_latitude;

        return $this;
    }

    /**
     * Gets car_longitude
     *
     * @return float
     */
    public function getCarLongitude()
    {
        return $this->container['car_longitude'];
    }

    /**
     * Sets car_longitude
     *
     * @param float $car_longitude Longitude of the car pickup location.
     *
     * @return $this
     */
    public function setCarLongitude($car_longitude)
    {
        $this->container['car_longitude'] = $car_longitude;

        return $this;
    }

    /**
     * Gets car_distance
     *
     * @return float
     */
    public function getCarDistance()
    {
        return $this->container['car_distance'];
    }

    /**
     * Sets car_distance
     *
     * @param float $car_distance Distance the car can be driven.
     *
     * @return $this
     */
    public function setCarDistance($car_distance)
    {
        $this->container['car_distance'] = $car_distance;

        return $this;
    }

    /**
     * Gets car_distance_metric
     *
     * @return string
     */
    public function getCarDistanceMetric()
    {
        return $this->container['car_distance_metric'];
    }

    /**
     * Sets car_distance_metric
     *
     * @param string $car_distance_metric Metric system used for car distance (miles/km).
     *
     * @return $this
     */
    public function setCarDistanceMetric($car_distance_metric)
    {
        $this->container['car_distance_metric'] = $car_distance_metric;

        return $this;
    }

    /**
     * Gets car_images
     *
     * @return string[]
     */
    public function getCarImages()
    {
        return $this->container['car_images'];
    }

    /**
     * Sets car_images
     *
     * @param string[] $car_images Array of images of the car.
     *
     * @return $this
     */
    public function setCarImages($car_images)
    {
        $this->container['car_images'] = $car_images;

        return $this;
    }

    /**
     * Gets car_rating
     *
     * @return double
     */
    public function getCarRating()
    {
        return $this->container['car_rating'];
    }

    /**
     * Sets car_rating
     *
     * @param double $car_rating Rating of the car based on user reviews.
     *
     * @return $this
     */
    public function setCarRating($car_rating)
    {
        $this->container['car_rating'] = $car_rating;

        return $this;
    }

    /**
     * Gets car_reviews
     *
     * @return int
     */
    public function getCarReviews()
    {
        return $this->container['car_reviews'];
    }

    /**
     * Sets car_reviews
     *
     * @param int $car_reviews Number of reviews for the car.
     *
     * @return $this
     */
    public function setCarReviews($car_reviews)
    {
        $this->container['car_reviews'] = $car_reviews;

        return $this;
    }

    /**
     * Gets car_type
     *
     * @return string
     */
    public function getCarType()
    {
        return $this->container['car_type'];
    }

    /**
     * Sets car_type
     *
     * @param string $car_type Type of the car (e.g., sedan, SUV).
     *
     * @return $this
     */
    public function setCarType($car_type)
    {
        $this->container['car_type'] = $car_type;

        return $this;
    }

    /**
     * Gets car_class
     *
     * @return string
     */
    public function getCarClass()
    {
        return $this->container['car_class'];
    }

    /**
     * Sets car_class
     *
     * @param string $car_class Class of the car (e.g., economy, luxury).
     *
     * @return $this
     */
    public function setCarClass($car_class)
    {
        $this->container['car_class'] = $car_class;

        return $this;
    }

    /**
     * Gets car_company
     *
     * @return string
     */
    public function getCarCompany()
    {
        return $this->container['car_company'];
    }

    /**
     * Sets car_company
     *
     * @param string $car_company Company owning the car or rental service.
     *
     * @return $this
     */
    public function setCarCompany($car_company)
    {
        $this->container['car_company'] = $car_company;

        return $this;
    }

    /**
     * Gets car_company_logo
     *
     * @return string
     */
    public function getCarCompanyLogo()
    {
        return $this->container['car_company_logo'];
    }

    /**
     * Sets car_company_logo
     *
     * @param string $car_company_logo Logo of the company owning the car.
     *
     * @return $this
     */
    public function setCarCompanyLogo($car_company_logo)
    {
        $this->container['car_company_logo'] = $car_company_logo;

        return $this;
    }

    /**
     * Gets car_passengers_number
     *
     * @return int
     */
    public function getCarPassengersNumber()
    {
        return $this->container['car_passengers_number'];
    }

    /**
     * Sets car_passengers_number
     *
     * @param int $car_passengers_number Number of passengers the car can hold.
     *
     * @return $this
     */
    public function setCarPassengersNumber($car_passengers_number)
    {
        $this->container['car_passengers_number'] = $car_passengers_number;

        return $this;
    }

    /**
     * Gets car_bags_number
     *
     * @return int
     */
    public function getCarBagsNumber()
    {
        return $this->container['car_bags_number'];
    }

    /**
     * Sets car_bags_number
     *
     * @param int $car_bags_number Number of bags the car can hold.
     *
     * @return $this
     */
    public function setCarBagsNumber($car_bags_number)
    {
        $this->container['car_bags_number'] = $car_bags_number;

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
