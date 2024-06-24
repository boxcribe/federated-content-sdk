<?php
/**
 * IntegrationsBody
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
 * IntegrationsBody Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class IntegrationsBody implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'integrations_body';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'tenant_id' => 'string',
        'category_id' => 'string',
        'name' => 'string',
        'type' => 'string',
        'slug' => 'string',
        'logo' => 'string',
        'status' => 'string',
        'credentials_production' => '\Swagger\Client\Model\IntegrationsCredentialsProduction',
        'credentials_sandbox' => '\Swagger\Client\Model\IntegrationsCredentialsProduction',
        'env_production' => 'string',
        'env_sandbox' => 'string',
        'settings_production' => '\Swagger\Client\Model\IntegrationsSettingsProduction',
        'settings_sandbox' => '\Swagger\Client\Model\IntegrationsSettingsProduction'
    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'tenant_id' => null,
        'category_id' => null,
        'name' => null,
        'type' => null,
        'slug' => null,
        'logo' => null,
        'status' => null,
        'credentials_production' => null,
        'credentials_sandbox' => null,
        'env_production' => null,
        'env_sandbox' => null,
        'settings_production' => null,
        'settings_sandbox' => null
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
        'tenant_id' => 'tenant_id',
        'category_id' => 'category_id',
        'name' => 'name',
        'type' => 'type',
        'slug' => 'slug',
        'logo' => 'logo',
        'status' => 'status',
        'credentials_production' => 'credentials_production',
        'credentials_sandbox' => 'credentials_sandbox',
        'env_production' => 'env_production',
        'env_sandbox' => 'env_sandbox',
        'settings_production' => 'settings_production',
        'settings_sandbox' => 'settings_sandbox'
    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'tenant_id' => 'setTenantId',
        'category_id' => 'setCategoryId',
        'name' => 'setName',
        'type' => 'setType',
        'slug' => 'setSlug',
        'logo' => 'setLogo',
        'status' => 'setStatus',
        'credentials_production' => 'setCredentialsProduction',
        'credentials_sandbox' => 'setCredentialsSandbox',
        'env_production' => 'setEnvProduction',
        'env_sandbox' => 'setEnvSandbox',
        'settings_production' => 'setSettingsProduction',
        'settings_sandbox' => 'setSettingsSandbox'
    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'tenant_id' => 'getTenantId',
        'category_id' => 'getCategoryId',
        'name' => 'getName',
        'type' => 'getType',
        'slug' => 'getSlug',
        'logo' => 'getLogo',
        'status' => 'getStatus',
        'credentials_production' => 'getCredentialsProduction',
        'credentials_sandbox' => 'getCredentialsSandbox',
        'env_production' => 'getEnvProduction',
        'env_sandbox' => 'getEnvSandbox',
        'settings_production' => 'getSettingsProduction',
        'settings_sandbox' => 'getSettingsSandbox'
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

    const STATUS_ACTIVE = 'Active';
    const STATUS_INACTIVE = 'Inactive';

    /**
     * Gets allowable values of the enum
     *
     * @return string[]
     */
    public function getStatusAllowableValues()
    {
        return [
            self::STATUS_ACTIVE,
            self::STATUS_INACTIVE,
        ];
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
        $this->container['tenant_id'] = isset($data['tenant_id']) ? $data['tenant_id'] : null;
        $this->container['category_id'] = isset($data['category_id']) ? $data['category_id'] : null;
        $this->container['name'] = isset($data['name']) ? $data['name'] : null;
        $this->container['type'] = isset($data['type']) ? $data['type'] : null;
        $this->container['slug'] = isset($data['slug']) ? $data['slug'] : null;
        $this->container['logo'] = isset($data['logo']) ? $data['logo'] : null;
        $this->container['status'] = isset($data['status']) ? $data['status'] : null;
        $this->container['credentials_production'] = isset($data['credentials_production']) ? $data['credentials_production'] : null;
        $this->container['credentials_sandbox'] = isset($data['credentials_sandbox']) ? $data['credentials_sandbox'] : null;
        $this->container['env_production'] = isset($data['env_production']) ? $data['env_production'] : null;
        $this->container['env_sandbox'] = isset($data['env_sandbox']) ? $data['env_sandbox'] : null;
        $this->container['settings_production'] = isset($data['settings_production']) ? $data['settings_production'] : null;
        $this->container['settings_sandbox'] = isset($data['settings_sandbox']) ? $data['settings_sandbox'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['category_id'] === null) {
            $invalidProperties[] = "'category_id' can't be null";
        }
        if ($this->container['name'] === null) {
            $invalidProperties[] = "'name' can't be null";
        }
        if ($this->container['slug'] === null) {
            $invalidProperties[] = "'slug' can't be null";
        }
        $allowedValues = $this->getStatusAllowableValues();
        if (!is_null($this->container['status']) && !in_array($this->container['status'], $allowedValues, true)) {
            $invalidProperties[] = sprintf(
                "invalid value for 'status', must be one of '%s'",
                implode("', '", $allowedValues)
            );
        }

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
     * @param string $tenant_id tenant_id
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
     * @param string $category_id category_id
     *
     * @return $this
     */
    public function setCategoryId($category_id)
    {
        $this->container['category_id'] = $category_id;

        return $this;
    }

    /**
     * Gets name
     *
     * @return string
     */
    public function getName()
    {
        return $this->container['name'];
    }

    /**
     * Sets name
     *
     * @param string $name name
     *
     * @return $this
     */
    public function setName($name)
    {
        $this->container['name'] = $name;

        return $this;
    }

    /**
     * Gets type
     *
     * @return string
     */
    public function getType()
    {
        return $this->container['type'];
    }

    /**
     * Sets type
     *
     * @param string $type type
     *
     * @return $this
     */
    public function setType($type)
    {
        $this->container['type'] = $type;

        return $this;
    }

    /**
     * Gets slug
     *
     * @return string
     */
    public function getSlug()
    {
        return $this->container['slug'];
    }

    /**
     * Sets slug
     *
     * @param string $slug slug
     *
     * @return $this
     */
    public function setSlug($slug)
    {
        $this->container['slug'] = $slug;

        return $this;
    }

    /**
     * Gets logo
     *
     * @return string
     */
    public function getLogo()
    {
        return $this->container['logo'];
    }

    /**
     * Sets logo
     *
     * @param string $logo logo
     *
     * @return $this
     */
    public function setLogo($logo)
    {
        $this->container['logo'] = $logo;

        return $this;
    }

    /**
     * Gets status
     *
     * @return string
     */
    public function getStatus()
    {
        return $this->container['status'];
    }

    /**
     * Sets status
     *
     * @param string $status status
     *
     * @return $this
     */
    public function setStatus($status)
    {
        $allowedValues = $this->getStatusAllowableValues();
        if (!is_null($status) && !in_array($status, $allowedValues, true)) {
            throw new \InvalidArgumentException(
                sprintf(
                    "Invalid value for 'status', must be one of '%s'",
                    implode("', '", $allowedValues)
                )
            );
        }
        $this->container['status'] = $status;

        return $this;
    }

    /**
     * Gets credentials_production
     *
     * @return \Swagger\Client\Model\IntegrationsCredentialsProduction
     */
    public function getCredentialsProduction()
    {
        return $this->container['credentials_production'];
    }

    /**
     * Sets credentials_production
     *
     * @param \Swagger\Client\Model\IntegrationsCredentialsProduction $credentials_production credentials_production
     *
     * @return $this
     */
    public function setCredentialsProduction($credentials_production)
    {
        $this->container['credentials_production'] = $credentials_production;

        return $this;
    }

    /**
     * Gets credentials_sandbox
     *
     * @return \Swagger\Client\Model\IntegrationsCredentialsProduction
     */
    public function getCredentialsSandbox()
    {
        return $this->container['credentials_sandbox'];
    }

    /**
     * Sets credentials_sandbox
     *
     * @param \Swagger\Client\Model\IntegrationsCredentialsProduction $credentials_sandbox credentials_sandbox
     *
     * @return $this
     */
    public function setCredentialsSandbox($credentials_sandbox)
    {
        $this->container['credentials_sandbox'] = $credentials_sandbox;

        return $this;
    }

    /**
     * Gets env_production
     *
     * @return string
     */
    public function getEnvProduction()
    {
        return $this->container['env_production'];
    }

    /**
     * Sets env_production
     *
     * @param string $env_production env_production
     *
     * @return $this
     */
    public function setEnvProduction($env_production)
    {
        $this->container['env_production'] = $env_production;

        return $this;
    }

    /**
     * Gets env_sandbox
     *
     * @return string
     */
    public function getEnvSandbox()
    {
        return $this->container['env_sandbox'];
    }

    /**
     * Sets env_sandbox
     *
     * @param string $env_sandbox env_sandbox
     *
     * @return $this
     */
    public function setEnvSandbox($env_sandbox)
    {
        $this->container['env_sandbox'] = $env_sandbox;

        return $this;
    }

    /**
     * Gets settings_production
     *
     * @return \Swagger\Client\Model\IntegrationsSettingsProduction
     */
    public function getSettingsProduction()
    {
        return $this->container['settings_production'];
    }

    /**
     * Sets settings_production
     *
     * @param \Swagger\Client\Model\IntegrationsSettingsProduction $settings_production settings_production
     *
     * @return $this
     */
    public function setSettingsProduction($settings_production)
    {
        $this->container['settings_production'] = $settings_production;

        return $this;
    }

    /**
     * Gets settings_sandbox
     *
     * @return \Swagger\Client\Model\IntegrationsSettingsProduction
     */
    public function getSettingsSandbox()
    {
        return $this->container['settings_sandbox'];
    }

    /**
     * Sets settings_sandbox
     *
     * @param \Swagger\Client\Model\IntegrationsSettingsProduction $settings_sandbox settings_sandbox
     *
     * @return $this
     */
    public function setSettingsSandbox($settings_sandbox)
    {
        $this->container['settings_sandbox'] = $settings_sandbox;

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