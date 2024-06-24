# coding: utf-8

"""
    Federated Content API

    Welcome to the Federated Content API following Open API Specification (Version 3.0.0)  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class Mapping(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'id': 'str',
        'tenant_id': 'str',
        'schema_id': 'str',
        'field_id': 'str',
        'integration_id': 'str',
        'status': 'str',
        'mapping': 'object'
    }

    attribute_map = {
        'id': 'id',
        'tenant_id': 'tenant_id',
        'schema_id': 'schema_id',
        'field_id': 'field_id',
        'integration_id': 'integration_id',
        'status': 'status',
        'mapping': 'mapping'
    }

    def __init__(self, id=None, tenant_id=None, schema_id=None, field_id=None, integration_id=None, status='Active', mapping=None):  # noqa: E501
        """Mapping - a model defined in Swagger"""  # noqa: E501
        self._id = None
        self._tenant_id = None
        self._schema_id = None
        self._field_id = None
        self._integration_id = None
        self._status = None
        self._mapping = None
        self.discriminator = None
        if id is not None:
            self.id = id
        if tenant_id is not None:
            self.tenant_id = tenant_id
        if schema_id is not None:
            self.schema_id = schema_id
        if field_id is not None:
            self.field_id = field_id
        if integration_id is not None:
            self.integration_id = integration_id
        if status is not None:
            self.status = status
        if mapping is not None:
            self.mapping = mapping

    @property
    def id(self):
        """Gets the id of this Mapping.  # noqa: E501


        :return: The id of this Mapping.  # noqa: E501
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this Mapping.


        :param id: The id of this Mapping.  # noqa: E501
        :type: str
        """

        self._id = id

    @property
    def tenant_id(self):
        """Gets the tenant_id of this Mapping.  # noqa: E501


        :return: The tenant_id of this Mapping.  # noqa: E501
        :rtype: str
        """
        return self._tenant_id

    @tenant_id.setter
    def tenant_id(self, tenant_id):
        """Sets the tenant_id of this Mapping.


        :param tenant_id: The tenant_id of this Mapping.  # noqa: E501
        :type: str
        """

        self._tenant_id = tenant_id

    @property
    def schema_id(self):
        """Gets the schema_id of this Mapping.  # noqa: E501


        :return: The schema_id of this Mapping.  # noqa: E501
        :rtype: str
        """
        return self._schema_id

    @schema_id.setter
    def schema_id(self, schema_id):
        """Sets the schema_id of this Mapping.


        :param schema_id: The schema_id of this Mapping.  # noqa: E501
        :type: str
        """

        self._schema_id = schema_id

    @property
    def field_id(self):
        """Gets the field_id of this Mapping.  # noqa: E501


        :return: The field_id of this Mapping.  # noqa: E501
        :rtype: str
        """
        return self._field_id

    @field_id.setter
    def field_id(self, field_id):
        """Sets the field_id of this Mapping.


        :param field_id: The field_id of this Mapping.  # noqa: E501
        :type: str
        """

        self._field_id = field_id

    @property
    def integration_id(self):
        """Gets the integration_id of this Mapping.  # noqa: E501


        :return: The integration_id of this Mapping.  # noqa: E501
        :rtype: str
        """
        return self._integration_id

    @integration_id.setter
    def integration_id(self, integration_id):
        """Sets the integration_id of this Mapping.


        :param integration_id: The integration_id of this Mapping.  # noqa: E501
        :type: str
        """

        self._integration_id = integration_id

    @property
    def status(self):
        """Gets the status of this Mapping.  # noqa: E501


        :return: The status of this Mapping.  # noqa: E501
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this Mapping.


        :param status: The status of this Mapping.  # noqa: E501
        :type: str
        """
        allowed_values = ["Active", "Inactive"]  # noqa: E501
        if status not in allowed_values:
            raise ValueError(
                "Invalid value for `status` ({0}), must be one of {1}"  # noqa: E501
                .format(status, allowed_values)
            )

        self._status = status

    @property
    def mapping(self):
        """Gets the mapping of this Mapping.  # noqa: E501

        Equivalent mapping path/formula for field_id into the integration_id response item schema  # noqa: E501

        :return: The mapping of this Mapping.  # noqa: E501
        :rtype: object
        """
        return self._mapping

    @mapping.setter
    def mapping(self, mapping):
        """Sets the mapping of this Mapping.

        Equivalent mapping path/formula for field_id into the integration_id response item schema  # noqa: E501

        :param mapping: The mapping of this Mapping.  # noqa: E501
        :type: object
        """

        self._mapping = mapping

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(Mapping, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, Mapping):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other