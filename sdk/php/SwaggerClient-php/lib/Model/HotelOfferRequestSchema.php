<?php
/**
 * HotelOfferRequestSchema
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
 * HotelOfferRequestSchema Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class HotelOfferRequestSchema implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'HotelOfferRequestSchema';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'location_latitude' => 'float',
        'location_longitude' => 'float',
        'location_radius' => 'float',
        'checkin_date' => '\DateTime',
        'checkout_date' => '\DateTime',
        'rooms' => '\Swagger\Client\Model\HotelOfferRequestSchemaRooms[]',
        'filter_by_keyword' => 'string',
        'filter_by_price_min' => 'double',
        'filter_by_price_max' => 'double',
        'filter_by_distance_min' => 'float',
        'filter_by_distance_max' => 'float',
        'filter_by_rating_min' => 'float',
        'filter_by_rating_max' => 'float',
        'filter_by_stars' => 'int[]',
        'filter_by_facilities' => 'string[]',
        'filter_by_amenities' => 'string[]',
        'sort_by' => 'string',
        'sort_order' => 'string',
        'page' => 'int',
        'limit' => 'int',
        'language' => 'string',
        'currency' => 'string',
        'metric' => 'string'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'location_latitude' => 'float',
        'location_longitude' => 'float',
        'location_radius' => 'float',
        'checkin_date' => 'date',
        'checkout_date' => 'date',
        'rooms' => null,
        'filter_by_keyword' => null,
        'filter_by_price_min' => 'double',
        'filter_by_price_max' => 'double',
        'filter_by_distance_min' => 'float',
        'filter_by_distance_max' => 'float',
        'filter_by_rating_min' => 'float',
        'filter_by_rating_max' => 'float',
        'filter_by_stars' => null,
        'filter_by_facilities' => null,
        'filter_by_amenities' => null,
        'sort_by' => null,
        'sort_order' => null,
        'page' => null,
        'limit' => null,
        'language' => null,
        'currency' => null,
        'metric' => null
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
        'location_latitude' => 'location_latitude',
        'location_longitude' => 'location_longitude',
        'location_radius' => 'location_radius',
        'checkin_date' => 'checkin_date',
        'checkout_date' => 'checkout_date',
        'rooms' => 'rooms',
        'filter_by_keyword' => 'filter_by_keyword',
        'filter_by_price_min' => 'filter_by_price_min',
        'filter_by_price_max' => 'filter_by_price_max',
        'filter_by_distance_min' => 'filter_by_distance_min',
        'filter_by_distance_max' => 'filter_by_distance_max',
        'filter_by_rating_min' => 'filter_by_rating_min',
        'filter_by_rating_max' => 'filter_by_rating_max',
        'filter_by_stars' => 'filter_by_stars',
        'filter_by_facilities' => 'filter_by_facilities',
        'filter_by_amenities' => 'filter_by_amenities',
        'sort_by' => 'sort_by',
        'sort_order' => 'sort_order',
        'page' => 'page',
        'limit' => 'limit',
        'language' => 'language',
        'currency' => 'currency',
        'metric' => 'metric'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'location_latitude' => 'setLocationLatitude',
        'location_longitude' => 'setLocationLongitude',
        'location_radius' => 'setLocationRadius',
        'checkin_date' => 'setCheckinDate',
        'checkout_date' => 'setCheckoutDate',
        'rooms' => 'setRooms',
        'filter_by_keyword' => 'setFilterByKeyword',
        'filter_by_price_min' => 'setFilterByPriceMin',
        'filter_by_price_max' => 'setFilterByPriceMax',
        'filter_by_distance_min' => 'setFilterByDistanceMin',
        'filter_by_distance_max' => 'setFilterByDistanceMax',
        'filter_by_rating_min' => 'setFilterByRatingMin',
        'filter_by_rating_max' => 'setFilterByRatingMax',
        'filter_by_stars' => 'setFilterByStars',
        'filter_by_facilities' => 'setFilterByFacilities',
        'filter_by_amenities' => 'setFilterByAmenities',
        'sort_by' => 'setSortBy',
        'sort_order' => 'setSortOrder',
        'page' => 'setPage',
        'limit' => 'setLimit',
        'language' => 'setLanguage',
        'currency' => 'setCurrency',
        'metric' => 'setMetric'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'location_latitude' => 'getLocationLatitude',
        'location_longitude' => 'getLocationLongitude',
        'location_radius' => 'getLocationRadius',
        'checkin_date' => 'getCheckinDate',
        'checkout_date' => 'getCheckoutDate',
        'rooms' => 'getRooms',
        'filter_by_keyword' => 'getFilterByKeyword',
        'filter_by_price_min' => 'getFilterByPriceMin',
        'filter_by_price_max' => 'getFilterByPriceMax',
        'filter_by_distance_min' => 'getFilterByDistanceMin',
        'filter_by_distance_max' => 'getFilterByDistanceMax',
        'filter_by_rating_min' => 'getFilterByRatingMin',
        'filter_by_rating_max' => 'getFilterByRatingMax',
        'filter_by_stars' => 'getFilterByStars',
        'filter_by_facilities' => 'getFilterByFacilities',
        'filter_by_amenities' => 'getFilterByAmenities',
        'sort_by' => 'getSortBy',
        'sort_order' => 'getSortOrder',
        'page' => 'getPage',
        'limit' => 'getLimit',
        'language' => 'getLanguage',
        'currency' => 'getCurrency',
        'metric' => 'getMetric'
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
        $this->container['location_latitude'] = isset($data['location_latitude']) ? $data['location_latitude'] : null;
        $this->container['location_longitude'] = isset($data['location_longitude']) ? $data['location_longitude'] : null;
        $this->container['location_radius'] = isset($data['location_radius']) ? $data['location_radius'] : null;
        $this->container['checkin_date'] = isset($data['checkin_date']) ? $data['checkin_date'] : null;
        $this->container['checkout_date'] = isset($data['checkout_date']) ? $data['checkout_date'] : null;
        $this->container['rooms'] = isset($data['rooms']) ? $data['rooms'] : null;
        $this->container['filter_by_keyword'] = isset($data['filter_by_keyword']) ? $data['filter_by_keyword'] : null;
        $this->container['filter_by_price_min'] = isset($data['filter_by_price_min']) ? $data['filter_by_price_min'] : null;
        $this->container['filter_by_price_max'] = isset($data['filter_by_price_max']) ? $data['filter_by_price_max'] : null;
        $this->container['filter_by_distance_min'] = isset($data['filter_by_distance_min']) ? $data['filter_by_distance_min'] : null;
        $this->container['filter_by_distance_max'] = isset($data['filter_by_distance_max']) ? $data['filter_by_distance_max'] : null;
        $this->container['filter_by_rating_min'] = isset($data['filter_by_rating_min']) ? $data['filter_by_rating_min'] : null;
        $this->container['filter_by_rating_max'] = isset($data['filter_by_rating_max']) ? $data['filter_by_rating_max'] : null;
        $this->container['filter_by_stars'] = isset($data['filter_by_stars']) ? $data['filter_by_stars'] : null;
        $this->container['filter_by_facilities'] = isset($data['filter_by_facilities']) ? $data['filter_by_facilities'] : null;
        $this->container['filter_by_amenities'] = isset($data['filter_by_amenities']) ? $data['filter_by_amenities'] : null;
        $this->container['sort_by'] = isset($data['sort_by']) ? $data['sort_by'] : null;
        $this->container['sort_order'] = isset($data['sort_order']) ? $data['sort_order'] : null;
        $this->container['page'] = isset($data['page']) ? $data['page'] : null;
        $this->container['limit'] = isset($data['limit']) ? $data['limit'] : null;
        $this->container['language'] = isset($data['language']) ? $data['language'] : null;
        $this->container['currency'] = isset($data['currency']) ? $data['currency'] : null;
        $this->container['metric'] = isset($data['metric']) ? $data['metric'] : null;
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
     * Gets location_latitude
     *
     * @return float
     */
    public function getLocationLatitude()
    {
        return $this->container['location_latitude'];
    }

    /**
     * Sets location_latitude
     *
     * @param float $location_latitude Latitude of the hotel location.
     *
     * @return $this
     */
    public function setLocationLatitude($location_latitude)
    {
        $this->container['location_latitude'] = $location_latitude;

        return $this;
    }

    /**
     * Gets location_longitude
     *
     * @return float
     */
    public function getLocationLongitude()
    {
        return $this->container['location_longitude'];
    }

    /**
     * Sets location_longitude
     *
     * @param float $location_longitude Longitude of the hotel location.
     *
     * @return $this
     */
    public function setLocationLongitude($location_longitude)
    {
        $this->container['location_longitude'] = $location_longitude;

        return $this;
    }

    /**
     * Gets location_radius
     *
     * @return float
     */
    public function getLocationRadius()
    {
        return $this->container['location_radius'];
    }

    /**
     * Sets location_radius
     *
     * @param float $location_radius Search radius from the specified location.
     *
     * @return $this
     */
    public function setLocationRadius($location_radius)
    {
        $this->container['location_radius'] = $location_radius;

        return $this;
    }

    /**
     * Gets checkin_date
     *
     * @return \DateTime
     */
    public function getCheckinDate()
    {
        return $this->container['checkin_date'];
    }

    /**
     * Sets checkin_date
     *
     * @param \DateTime $checkin_date Check-in date for the hotel booking.
     *
     * @return $this
     */
    public function setCheckinDate($checkin_date)
    {
        $this->container['checkin_date'] = $checkin_date;

        return $this;
    }

    /**
     * Gets checkout_date
     *
     * @return \DateTime
     */
    public function getCheckoutDate()
    {
        return $this->container['checkout_date'];
    }

    /**
     * Sets checkout_date
     *
     * @param \DateTime $checkout_date Check-out date for the hotel booking.
     *
     * @return $this
     */
    public function setCheckoutDate($checkout_date)
    {
        $this->container['checkout_date'] = $checkout_date;

        return $this;
    }

    /**
     * Gets rooms
     *
     * @return \Swagger\Client\Model\HotelOfferRequestSchemaRooms[]
     */
    public function getRooms()
    {
        return $this->container['rooms'];
    }

    /**
     * Sets rooms
     *
     * @param \Swagger\Client\Model\HotelOfferRequestSchemaRooms[] $rooms Details of rooms including number of adults and children per room.
     *
     * @return $this
     */
    public function setRooms($rooms)
    {
        $this->container['rooms'] = $rooms;

        return $this;
    }

    /**
     * Gets filter_by_keyword
     *
     * @return string
     */
    public function getFilterByKeyword()
    {
        return $this->container['filter_by_keyword'];
    }

    /**
     * Sets filter_by_keyword
     *
     * @param string $filter_by_keyword Keyword to filter hotel offers.
     *
     * @return $this
     */
    public function setFilterByKeyword($filter_by_keyword)
    {
        $this->container['filter_by_keyword'] = $filter_by_keyword;

        return $this;
    }

    /**
     * Gets filter_by_price_min
     *
     * @return double
     */
    public function getFilterByPriceMin()
    {
        return $this->container['filter_by_price_min'];
    }

    /**
     * Sets filter_by_price_min
     *
     * @param double $filter_by_price_min Minimum price filter for hotel offers.
     *
     * @return $this
     */
    public function setFilterByPriceMin($filter_by_price_min)
    {
        $this->container['filter_by_price_min'] = $filter_by_price_min;

        return $this;
    }

    /**
     * Gets filter_by_price_max
     *
     * @return double
     */
    public function getFilterByPriceMax()
    {
        return $this->container['filter_by_price_max'];
    }

    /**
     * Sets filter_by_price_max
     *
     * @param double $filter_by_price_max Maximum price filter for hotel offers.
     *
     * @return $this
     */
    public function setFilterByPriceMax($filter_by_price_max)
    {
        $this->container['filter_by_price_max'] = $filter_by_price_max;

        return $this;
    }

    /**
     * Gets filter_by_distance_min
     *
     * @return float
     */
    public function getFilterByDistanceMin()
    {
        return $this->container['filter_by_distance_min'];
    }

    /**
     * Sets filter_by_distance_min
     *
     * @param float $filter_by_distance_min Minimum distance filter for hotel location.
     *
     * @return $this
     */
    public function setFilterByDistanceMin($filter_by_distance_min)
    {
        $this->container['filter_by_distance_min'] = $filter_by_distance_min;

        return $this;
    }

    /**
     * Gets filter_by_distance_max
     *
     * @return float
     */
    public function getFilterByDistanceMax()
    {
        return $this->container['filter_by_distance_max'];
    }

    /**
     * Sets filter_by_distance_max
     *
     * @param float $filter_by_distance_max Maximum distance filter for hotel location.
     *
     * @return $this
     */
    public function setFilterByDistanceMax($filter_by_distance_max)
    {
        $this->container['filter_by_distance_max'] = $filter_by_distance_max;

        return $this;
    }

    /**
     * Gets filter_by_rating_min
     *
     * @return float
     */
    public function getFilterByRatingMin()
    {
        return $this->container['filter_by_rating_min'];
    }

    /**
     * Sets filter_by_rating_min
     *
     * @param float $filter_by_rating_min Minimum rating filter for hotels.
     *
     * @return $this
     */
    public function setFilterByRatingMin($filter_by_rating_min)
    {
        $this->container['filter_by_rating_min'] = $filter_by_rating_min;

        return $this;
    }

    /**
     * Gets filter_by_rating_max
     *
     * @return float
     */
    public function getFilterByRatingMax()
    {
        return $this->container['filter_by_rating_max'];
    }

    /**
     * Sets filter_by_rating_max
     *
     * @param float $filter_by_rating_max Maximum rating filter for hotels.
     *
     * @return $this
     */
    public function setFilterByRatingMax($filter_by_rating_max)
    {
        $this->container['filter_by_rating_max'] = $filter_by_rating_max;

        return $this;
    }

    /**
     * Gets filter_by_stars
     *
     * @return int[]
     */
    public function getFilterByStars()
    {
        return $this->container['filter_by_stars'];
    }

    /**
     * Sets filter_by_stars
     *
     * @param int[] $filter_by_stars Filter hotels by star ratings.
     *
     * @return $this
     */
    public function setFilterByStars($filter_by_stars)
    {
        $this->container['filter_by_stars'] = $filter_by_stars;

        return $this;
    }

    /**
     * Gets filter_by_facilities
     *
     * @return string[]
     */
    public function getFilterByFacilities()
    {
        return $this->container['filter_by_facilities'];
    }

    /**
     * Sets filter_by_facilities
     *
     * @param string[] $filter_by_facilities Filter hotels by available facilities.
     *
     * @return $this
     */
    public function setFilterByFacilities($filter_by_facilities)
    {
        $this->container['filter_by_facilities'] = $filter_by_facilities;

        return $this;
    }

    /**
     * Gets filter_by_amenities
     *
     * @return string[]
     */
    public function getFilterByAmenities()
    {
        return $this->container['filter_by_amenities'];
    }

    /**
     * Sets filter_by_amenities
     *
     * @param string[] $filter_by_amenities Filter hotels by available amenities.
     *
     * @return $this
     */
    public function setFilterByAmenities($filter_by_amenities)
    {
        $this->container['filter_by_amenities'] = $filter_by_amenities;

        return $this;
    }

    /**
     * Gets sort_by
     *
     * @return string
     */
    public function getSortBy()
    {
        return $this->container['sort_by'];
    }

    /**
     * Sets sort_by
     *
     * @param string $sort_by Field to sort the results by.
     *
     * @return $this
     */
    public function setSortBy($sort_by)
    {
        $this->container['sort_by'] = $sort_by;

        return $this;
    }

    /**
     * Gets sort_order
     *
     * @return string
     */
    public function getSortOrder()
    {
        return $this->container['sort_order'];
    }

    /**
     * Sets sort_order
     *
     * @param string $sort_order Order to sort the results, either asc or desc.
     *
     * @return $this
     */
    public function setSortOrder($sort_order)
    {
        $this->container['sort_order'] = $sort_order;

        return $this;
    }

    /**
     * Gets page
     *
     * @return int
     */
    public function getPage()
    {
        return $this->container['page'];
    }

    /**
     * Sets page
     *
     * @param int $page Page number for pagination.
     *
     * @return $this
     */
    public function setPage($page)
    {
        $this->container['page'] = $page;

        return $this;
    }

    /**
     * Gets limit
     *
     * @return int
     */
    public function getLimit()
    {
        return $this->container['limit'];
    }

    /**
     * Sets limit
     *
     * @param int $limit Number of items per page for pagination.
     *
     * @return $this
     */
    public function setLimit($limit)
    {
        $this->container['limit'] = $limit;

        return $this;
    }

    /**
     * Gets language
     *
     * @return string
     */
    public function getLanguage()
    {
        return $this->container['language'];
    }

    /**
     * Sets language
     *
     * @param string $language Preferred language of the hotel information.
     *
     * @return $this
     */
    public function setLanguage($language)
    {
        $this->container['language'] = $language;

        return $this;
    }

    /**
     * Gets currency
     *
     * @return string
     */
    public function getCurrency()
    {
        return $this->container['currency'];
    }

    /**
     * Sets currency
     *
     * @param string $currency Currency in which prices should be displayed.
     *
     * @return $this
     */
    public function setCurrency($currency)
    {
        $this->container['currency'] = $currency;

        return $this;
    }

    /**
     * Gets metric
     *
     * @return string
     */
    public function getMetric()
    {
        return $this->container['metric'];
    }

    /**
     * Sets metric
     *
     * @param string $metric Unit of measure for distance, either miles (mi) or kilometers (km).
     *
     * @return $this
     */
    public function setMetric($metric)
    {
        $this->container['metric'] = $metric;

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
