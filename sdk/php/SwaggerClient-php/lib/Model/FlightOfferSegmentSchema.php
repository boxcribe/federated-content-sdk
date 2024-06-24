<?php
/**
 * FlightOfferSegmentSchema
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
 * FlightOfferSegmentSchema Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class FlightOfferSegmentSchema implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'FlightOfferSegmentSchema';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'segment_id' => 'string',
        'duration' => 'int',
        'origin_name' => 'string',
        'origin_code' => 'string',
        'origin_latitude' => 'float',
        'origin_longitude' => 'float',
        'origin_terminal' => 'string',
        'destination_name' => 'string',
        'destination_code' => 'string',
        'destination_latitude' => 'float',
        'destination_longitude' => 'float',
        'destination_terminal' => 'string',
        'departure_date_time' => 'string',
        'arrival_date_time' => 'string',
        'operating_airline_name' => 'string',
        'operating_airline_code' => 'string',
        'operating_airline_logo' => 'string',
        'marketing_airline_name' => 'string',
        'marketing_airline_code' => 'string',
        'marketing_airline_logo' => 'string',
        'aircraft_name' => 'string',
        'aircraft_code' => 'string',
        'fare_brand_name' => 'string',
        'passengers' => '\Swagger\Client\Model\FlightOfferSegmentPassengerSchema[]'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'segment_id' => 'uuid',
        'duration' => null,
        'origin_name' => null,
        'origin_code' => null,
        'origin_latitude' => 'float',
        'origin_longitude' => 'float',
        'origin_terminal' => null,
        'destination_name' => null,
        'destination_code' => null,
        'destination_latitude' => 'float',
        'destination_longitude' => 'float',
        'destination_terminal' => null,
        'departure_date_time' => 'datetime',
        'arrival_date_time' => 'datetime',
        'operating_airline_name' => null,
        'operating_airline_code' => null,
        'operating_airline_logo' => null,
        'marketing_airline_name' => null,
        'marketing_airline_code' => null,
        'marketing_airline_logo' => null,
        'aircraft_name' => null,
        'aircraft_code' => null,
        'fare_brand_name' => null,
        'passengers' => null
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
        'segment_id' => 'segment_id',
        'duration' => 'duration',
        'origin_name' => 'origin_name',
        'origin_code' => 'origin_code',
        'origin_latitude' => 'origin_latitude',
        'origin_longitude' => 'origin_longitude',
        'origin_terminal' => 'origin_terminal',
        'destination_name' => 'destination_name',
        'destination_code' => 'destination_code',
        'destination_latitude' => 'destination_latitude',
        'destination_longitude' => 'destination_longitude',
        'destination_terminal' => 'destination_terminal',
        'departure_date_time' => 'departure_date_time',
        'arrival_date_time' => 'arrival_date_time',
        'operating_airline_name' => 'operating_airline_name',
        'operating_airline_code' => 'operating_airline_code',
        'operating_airline_logo' => 'operating_airline_logo',
        'marketing_airline_name' => 'marketing_airline_name',
        'marketing_airline_code' => 'marketing_airline_code',
        'marketing_airline_logo' => 'marketing_airline_logo',
        'aircraft_name' => 'aircraft_name',
        'aircraft_code' => 'aircraft_code',
        'fare_brand_name' => 'fare_brand_name',
        'passengers' => 'passengers'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'segment_id' => 'setSegmentId',
        'duration' => 'setDuration',
        'origin_name' => 'setOriginName',
        'origin_code' => 'setOriginCode',
        'origin_latitude' => 'setOriginLatitude',
        'origin_longitude' => 'setOriginLongitude',
        'origin_terminal' => 'setOriginTerminal',
        'destination_name' => 'setDestinationName',
        'destination_code' => 'setDestinationCode',
        'destination_latitude' => 'setDestinationLatitude',
        'destination_longitude' => 'setDestinationLongitude',
        'destination_terminal' => 'setDestinationTerminal',
        'departure_date_time' => 'setDepartureDateTime',
        'arrival_date_time' => 'setArrivalDateTime',
        'operating_airline_name' => 'setOperatingAirlineName',
        'operating_airline_code' => 'setOperatingAirlineCode',
        'operating_airline_logo' => 'setOperatingAirlineLogo',
        'marketing_airline_name' => 'setMarketingAirlineName',
        'marketing_airline_code' => 'setMarketingAirlineCode',
        'marketing_airline_logo' => 'setMarketingAirlineLogo',
        'aircraft_name' => 'setAircraftName',
        'aircraft_code' => 'setAircraftCode',
        'fare_brand_name' => 'setFareBrandName',
        'passengers' => 'setPassengers'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'segment_id' => 'getSegmentId',
        'duration' => 'getDuration',
        'origin_name' => 'getOriginName',
        'origin_code' => 'getOriginCode',
        'origin_latitude' => 'getOriginLatitude',
        'origin_longitude' => 'getOriginLongitude',
        'origin_terminal' => 'getOriginTerminal',
        'destination_name' => 'getDestinationName',
        'destination_code' => 'getDestinationCode',
        'destination_latitude' => 'getDestinationLatitude',
        'destination_longitude' => 'getDestinationLongitude',
        'destination_terminal' => 'getDestinationTerminal',
        'departure_date_time' => 'getDepartureDateTime',
        'arrival_date_time' => 'getArrivalDateTime',
        'operating_airline_name' => 'getOperatingAirlineName',
        'operating_airline_code' => 'getOperatingAirlineCode',
        'operating_airline_logo' => 'getOperatingAirlineLogo',
        'marketing_airline_name' => 'getMarketingAirlineName',
        'marketing_airline_code' => 'getMarketingAirlineCode',
        'marketing_airline_logo' => 'getMarketingAirlineLogo',
        'aircraft_name' => 'getAircraftName',
        'aircraft_code' => 'getAircraftCode',
        'fare_brand_name' => 'getFareBrandName',
        'passengers' => 'getPassengers'
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
        $this->container['segment_id'] = isset($data['segment_id']) ? $data['segment_id'] : null;
        $this->container['duration'] = isset($data['duration']) ? $data['duration'] : null;
        $this->container['origin_name'] = isset($data['origin_name']) ? $data['origin_name'] : null;
        $this->container['origin_code'] = isset($data['origin_code']) ? $data['origin_code'] : null;
        $this->container['origin_latitude'] = isset($data['origin_latitude']) ? $data['origin_latitude'] : null;
        $this->container['origin_longitude'] = isset($data['origin_longitude']) ? $data['origin_longitude'] : null;
        $this->container['origin_terminal'] = isset($data['origin_terminal']) ? $data['origin_terminal'] : null;
        $this->container['destination_name'] = isset($data['destination_name']) ? $data['destination_name'] : null;
        $this->container['destination_code'] = isset($data['destination_code']) ? $data['destination_code'] : null;
        $this->container['destination_latitude'] = isset($data['destination_latitude']) ? $data['destination_latitude'] : null;
        $this->container['destination_longitude'] = isset($data['destination_longitude']) ? $data['destination_longitude'] : null;
        $this->container['destination_terminal'] = isset($data['destination_terminal']) ? $data['destination_terminal'] : null;
        $this->container['departure_date_time'] = isset($data['departure_date_time']) ? $data['departure_date_time'] : null;
        $this->container['arrival_date_time'] = isset($data['arrival_date_time']) ? $data['arrival_date_time'] : null;
        $this->container['operating_airline_name'] = isset($data['operating_airline_name']) ? $data['operating_airline_name'] : null;
        $this->container['operating_airline_code'] = isset($data['operating_airline_code']) ? $data['operating_airline_code'] : null;
        $this->container['operating_airline_logo'] = isset($data['operating_airline_logo']) ? $data['operating_airline_logo'] : null;
        $this->container['marketing_airline_name'] = isset($data['marketing_airline_name']) ? $data['marketing_airline_name'] : null;
        $this->container['marketing_airline_code'] = isset($data['marketing_airline_code']) ? $data['marketing_airline_code'] : null;
        $this->container['marketing_airline_logo'] = isset($data['marketing_airline_logo']) ? $data['marketing_airline_logo'] : null;
        $this->container['aircraft_name'] = isset($data['aircraft_name']) ? $data['aircraft_name'] : null;
        $this->container['aircraft_code'] = isset($data['aircraft_code']) ? $data['aircraft_code'] : null;
        $this->container['fare_brand_name'] = isset($data['fare_brand_name']) ? $data['fare_brand_name'] : null;
        $this->container['passengers'] = isset($data['passengers']) ? $data['passengers'] : null;
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
     * Gets segment_id
     *
     * @return string
     */
    public function getSegmentId()
    {
        return $this->container['segment_id'];
    }

    /**
     * Sets segment_id
     *
     * @param string $segment_id Unique identifier for the flight segment.
     *
     * @return $this
     */
    public function setSegmentId($segment_id)
    {
        $this->container['segment_id'] = $segment_id;

        return $this;
    }

    /**
     * Gets duration
     *
     * @return int
     */
    public function getDuration()
    {
        return $this->container['duration'];
    }

    /**
     * Sets duration
     *
     * @param int $duration Total duration of the flight segment in minutes.
     *
     * @return $this
     */
    public function setDuration($duration)
    {
        $this->container['duration'] = $duration;

        return $this;
    }

    /**
     * Gets origin_name
     *
     * @return string
     */
    public function getOriginName()
    {
        return $this->container['origin_name'];
    }

    /**
     * Sets origin_name
     *
     * @param string $origin_name Name of the origin airport.
     *
     * @return $this
     */
    public function setOriginName($origin_name)
    {
        $this->container['origin_name'] = $origin_name;

        return $this;
    }

    /**
     * Gets origin_code
     *
     * @return string
     */
    public function getOriginCode()
    {
        return $this->container['origin_code'];
    }

    /**
     * Sets origin_code
     *
     * @param string $origin_code IATA code of the origin airport.
     *
     * @return $this
     */
    public function setOriginCode($origin_code)
    {
        $this->container['origin_code'] = $origin_code;

        return $this;
    }

    /**
     * Gets origin_latitude
     *
     * @return float
     */
    public function getOriginLatitude()
    {
        return $this->container['origin_latitude'];
    }

    /**
     * Sets origin_latitude
     *
     * @param float $origin_latitude Latitude of the origin airport.
     *
     * @return $this
     */
    public function setOriginLatitude($origin_latitude)
    {
        $this->container['origin_latitude'] = $origin_latitude;

        return $this;
    }

    /**
     * Gets origin_longitude
     *
     * @return float
     */
    public function getOriginLongitude()
    {
        return $this->container['origin_longitude'];
    }

    /**
     * Sets origin_longitude
     *
     * @param float $origin_longitude Longitude of the origin airport.
     *
     * @return $this
     */
    public function setOriginLongitude($origin_longitude)
    {
        $this->container['origin_longitude'] = $origin_longitude;

        return $this;
    }

    /**
     * Gets origin_terminal
     *
     * @return string
     */
    public function getOriginTerminal()
    {
        return $this->container['origin_terminal'];
    }

    /**
     * Sets origin_terminal
     *
     * @param string $origin_terminal Terminal at the origin airport.
     *
     * @return $this
     */
    public function setOriginTerminal($origin_terminal)
    {
        $this->container['origin_terminal'] = $origin_terminal;

        return $this;
    }

    /**
     * Gets destination_name
     *
     * @return string
     */
    public function getDestinationName()
    {
        return $this->container['destination_name'];
    }

    /**
     * Sets destination_name
     *
     * @param string $destination_name Name of the destination airport.
     *
     * @return $this
     */
    public function setDestinationName($destination_name)
    {
        $this->container['destination_name'] = $destination_name;

        return $this;
    }

    /**
     * Gets destination_code
     *
     * @return string
     */
    public function getDestinationCode()
    {
        return $this->container['destination_code'];
    }

    /**
     * Sets destination_code
     *
     * @param string $destination_code IATA code of the destination airport.
     *
     * @return $this
     */
    public function setDestinationCode($destination_code)
    {
        $this->container['destination_code'] = $destination_code;

        return $this;
    }

    /**
     * Gets destination_latitude
     *
     * @return float
     */
    public function getDestinationLatitude()
    {
        return $this->container['destination_latitude'];
    }

    /**
     * Sets destination_latitude
     *
     * @param float $destination_latitude Latitude of the destination airport.
     *
     * @return $this
     */
    public function setDestinationLatitude($destination_latitude)
    {
        $this->container['destination_latitude'] = $destination_latitude;

        return $this;
    }

    /**
     * Gets destination_longitude
     *
     * @return float
     */
    public function getDestinationLongitude()
    {
        return $this->container['destination_longitude'];
    }

    /**
     * Sets destination_longitude
     *
     * @param float $destination_longitude Longitude of the destination airport.
     *
     * @return $this
     */
    public function setDestinationLongitude($destination_longitude)
    {
        $this->container['destination_longitude'] = $destination_longitude;

        return $this;
    }

    /**
     * Gets destination_terminal
     *
     * @return string
     */
    public function getDestinationTerminal()
    {
        return $this->container['destination_terminal'];
    }

    /**
     * Sets destination_terminal
     *
     * @param string $destination_terminal Terminal at the destination airport.
     *
     * @return $this
     */
    public function setDestinationTerminal($destination_terminal)
    {
        $this->container['destination_terminal'] = $destination_terminal;

        return $this;
    }

    /**
     * Gets departure_date_time
     *
     * @return string
     */
    public function getDepartureDateTime()
    {
        return $this->container['departure_date_time'];
    }

    /**
     * Sets departure_date_time
     *
     * @param string $departure_date_time Scheduled departure date and time.
     *
     * @return $this
     */
    public function setDepartureDateTime($departure_date_time)
    {
        $this->container['departure_date_time'] = $departure_date_time;

        return $this;
    }

    /**
     * Gets arrival_date_time
     *
     * @return string
     */
    public function getArrivalDateTime()
    {
        return $this->container['arrival_date_time'];
    }

    /**
     * Sets arrival_date_time
     *
     * @param string $arrival_date_time Scheduled arrival date and time.
     *
     * @return $this
     */
    public function setArrivalDateTime($arrival_date_time)
    {
        $this->container['arrival_date_time'] = $arrival_date_time;

        return $this;
    }

    /**
     * Gets operating_airline_name
     *
     * @return string
     */
    public function getOperatingAirlineName()
    {
        return $this->container['operating_airline_name'];
    }

    /**
     * Sets operating_airline_name
     *
     * @param string $operating_airline_name Name of the operating airline.
     *
     * @return $this
     */
    public function setOperatingAirlineName($operating_airline_name)
    {
        $this->container['operating_airline_name'] = $operating_airline_name;

        return $this;
    }

    /**
     * Gets operating_airline_code
     *
     * @return string
     */
    public function getOperatingAirlineCode()
    {
        return $this->container['operating_airline_code'];
    }

    /**
     * Sets operating_airline_code
     *
     * @param string $operating_airline_code Code of the operating airline.
     *
     * @return $this
     */
    public function setOperatingAirlineCode($operating_airline_code)
    {
        $this->container['operating_airline_code'] = $operating_airline_code;

        return $this;
    }

    /**
     * Gets operating_airline_logo
     *
     * @return string
     */
    public function getOperatingAirlineLogo()
    {
        return $this->container['operating_airline_logo'];
    }

    /**
     * Sets operating_airline_logo
     *
     * @param string $operating_airline_logo Logo of the operating airline.
     *
     * @return $this
     */
    public function setOperatingAirlineLogo($operating_airline_logo)
    {
        $this->container['operating_airline_logo'] = $operating_airline_logo;

        return $this;
    }

    /**
     * Gets marketing_airline_name
     *
     * @return string
     */
    public function getMarketingAirlineName()
    {
        return $this->container['marketing_airline_name'];
    }

    /**
     * Sets marketing_airline_name
     *
     * @param string $marketing_airline_name Name of the marketing airline.
     *
     * @return $this
     */
    public function setMarketingAirlineName($marketing_airline_name)
    {
        $this->container['marketing_airline_name'] = $marketing_airline_name;

        return $this;
    }

    /**
     * Gets marketing_airline_code
     *
     * @return string
     */
    public function getMarketingAirlineCode()
    {
        return $this->container['marketing_airline_code'];
    }

    /**
     * Sets marketing_airline_code
     *
     * @param string $marketing_airline_code Code of the marketing airline.
     *
     * @return $this
     */
    public function setMarketingAirlineCode($marketing_airline_code)
    {
        $this->container['marketing_airline_code'] = $marketing_airline_code;

        return $this;
    }

    /**
     * Gets marketing_airline_logo
     *
     * @return string
     */
    public function getMarketingAirlineLogo()
    {
        return $this->container['marketing_airline_logo'];
    }

    /**
     * Sets marketing_airline_logo
     *
     * @param string $marketing_airline_logo Logo of the marketing airline.
     *
     * @return $this
     */
    public function setMarketingAirlineLogo($marketing_airline_logo)
    {
        $this->container['marketing_airline_logo'] = $marketing_airline_logo;

        return $this;
    }

    /**
     * Gets aircraft_name
     *
     * @return string
     */
    public function getAircraftName()
    {
        return $this->container['aircraft_name'];
    }

    /**
     * Sets aircraft_name
     *
     * @param string $aircraft_name Name of the aircraft.
     *
     * @return $this
     */
    public function setAircraftName($aircraft_name)
    {
        $this->container['aircraft_name'] = $aircraft_name;

        return $this;
    }

    /**
     * Gets aircraft_code
     *
     * @return string
     */
    public function getAircraftCode()
    {
        return $this->container['aircraft_code'];
    }

    /**
     * Sets aircraft_code
     *
     * @param string $aircraft_code Code of the aircraft.
     *
     * @return $this
     */
    public function setAircraftCode($aircraft_code)
    {
        $this->container['aircraft_code'] = $aircraft_code;

        return $this;
    }

    /**
     * Gets fare_brand_name
     *
     * @return string
     */
    public function getFareBrandName()
    {
        return $this->container['fare_brand_name'];
    }

    /**
     * Sets fare_brand_name
     *
     * @param string $fare_brand_name Name of the fare brand.
     *
     * @return $this
     */
    public function setFareBrandName($fare_brand_name)
    {
        $this->container['fare_brand_name'] = $fare_brand_name;

        return $this;
    }

    /**
     * Gets passengers
     *
     * @return \Swagger\Client\Model\FlightOfferSegmentPassengerSchema[]
     */
    public function getPassengers()
    {
        return $this->container['passengers'];
    }

    /**
     * Sets passengers
     *
     * @param \Swagger\Client\Model\FlightOfferSegmentPassengerSchema[] $passengers Array of FlightOfferSegmentPassengerSchema detailing passenger information.
     *
     * @return $this
     */
    public function setPassengers($passengers)
    {
        $this->container['passengers'] = $passengers;

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