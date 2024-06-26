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

class FlightOfferSegmentPassengerSchemaBags(object):
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
        'type': 'str',
        'qty': 'int'
    }

    attribute_map = {
        'type': 'type',
        'qty': 'qty'
    }

    def __init__(self, type=None, qty=None):  # noqa: E501
        """FlightOfferSegmentPassengerSchemaBags - a model defined in Swagger"""  # noqa: E501
        self._type = None
        self._qty = None
        self.discriminator = None
        if type is not None:
            self.type = type
        if qty is not None:
            self.qty = qty

    @property
    def type(self):
        """Gets the type of this FlightOfferSegmentPassengerSchemaBags.  # noqa: E501

        Type of bag.  # noqa: E501

        :return: The type of this FlightOfferSegmentPassengerSchemaBags.  # noqa: E501
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this FlightOfferSegmentPassengerSchemaBags.

        Type of bag.  # noqa: E501

        :param type: The type of this FlightOfferSegmentPassengerSchemaBags.  # noqa: E501
        :type: str
        """

        self._type = type

    @property
    def qty(self):
        """Gets the qty of this FlightOfferSegmentPassengerSchemaBags.  # noqa: E501

        Quantity of the specified bag type.  # noqa: E501

        :return: The qty of this FlightOfferSegmentPassengerSchemaBags.  # noqa: E501
        :rtype: int
        """
        return self._qty

    @qty.setter
    def qty(self, qty):
        """Sets the qty of this FlightOfferSegmentPassengerSchemaBags.

        Quantity of the specified bag type.  # noqa: E501

        :param qty: The qty of this FlightOfferSegmentPassengerSchemaBags.  # noqa: E501
        :type: int
        """

        self._qty = qty

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
        if issubclass(FlightOfferSegmentPassengerSchemaBags, dict):
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
        if not isinstance(other, FlightOfferSegmentPassengerSchemaBags):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
