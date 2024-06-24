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

class MappingsMapping(object):
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
        'jsonpath': 'object',
        'type': 'str',
        'field': 'str'
    }

    attribute_map = {
        'jsonpath': 'jsonpath',
        'type': 'type',
        'field': 'field'
    }

    def __init__(self, jsonpath=None, type=None, field=None):  # noqa: E501
        """MappingsMapping - a model defined in Swagger"""  # noqa: E501
        self._jsonpath = None
        self._type = None
        self._field = None
        self.discriminator = None
        if jsonpath is not None:
            self.jsonpath = jsonpath
        if type is not None:
            self.type = type
        if field is not None:
            self.field = field

    @property
    def jsonpath(self):
        """Gets the jsonpath of this MappingsMapping.  # noqa: E501


        :return: The jsonpath of this MappingsMapping.  # noqa: E501
        :rtype: object
        """
        return self._jsonpath

    @jsonpath.setter
    def jsonpath(self, jsonpath):
        """Sets the jsonpath of this MappingsMapping.


        :param jsonpath: The jsonpath of this MappingsMapping.  # noqa: E501
        :type: object
        """

        self._jsonpath = jsonpath

    @property
    def type(self):
        """Gets the type of this MappingsMapping.  # noqa: E501


        :return: The type of this MappingsMapping.  # noqa: E501
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this MappingsMapping.


        :param type: The type of this MappingsMapping.  # noqa: E501
        :type: str
        """

        self._type = type

    @property
    def field(self):
        """Gets the field of this MappingsMapping.  # noqa: E501


        :return: The field of this MappingsMapping.  # noqa: E501
        :rtype: str
        """
        return self._field

    @field.setter
    def field(self, field):
        """Sets the field of this MappingsMapping.


        :param field: The field of this MappingsMapping.  # noqa: E501
        :type: str
        """

        self._field = field

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
        if issubclass(MappingsMapping, dict):
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
        if not isinstance(other, MappingsMapping):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other