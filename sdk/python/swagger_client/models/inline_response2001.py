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

class InlineResponse2001(object):
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
        'message': 'str',
        'status': 'str',
        'timestamp': 'datetime'
    }

    attribute_map = {
        'message': 'message',
        'status': 'status',
        'timestamp': 'timestamp'
    }

    def __init__(self, message=None, status=None, timestamp=None):  # noqa: E501
        """InlineResponse2001 - a model defined in Swagger"""  # noqa: E501
        self._message = None
        self._status = None
        self._timestamp = None
        self.discriminator = None
        if message is not None:
            self.message = message
        if status is not None:
            self.status = status
        if timestamp is not None:
            self.timestamp = timestamp

    @property
    def message(self):
        """Gets the message of this InlineResponse2001.  # noqa: E501


        :return: The message of this InlineResponse2001.  # noqa: E501
        :rtype: str
        """
        return self._message

    @message.setter
    def message(self, message):
        """Sets the message of this InlineResponse2001.


        :param message: The message of this InlineResponse2001.  # noqa: E501
        :type: str
        """

        self._message = message

    @property
    def status(self):
        """Gets the status of this InlineResponse2001.  # noqa: E501


        :return: The status of this InlineResponse2001.  # noqa: E501
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this InlineResponse2001.


        :param status: The status of this InlineResponse2001.  # noqa: E501
        :type: str
        """

        self._status = status

    @property
    def timestamp(self):
        """Gets the timestamp of this InlineResponse2001.  # noqa: E501


        :return: The timestamp of this InlineResponse2001.  # noqa: E501
        :rtype: datetime
        """
        return self._timestamp

    @timestamp.setter
    def timestamp(self, timestamp):
        """Sets the timestamp of this InlineResponse2001.


        :param timestamp: The timestamp of this InlineResponse2001.  # noqa: E501
        :type: datetime
        """

        self._timestamp = timestamp

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
        if issubclass(InlineResponse2001, dict):
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
        if not isinstance(other, InlineResponse2001):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
