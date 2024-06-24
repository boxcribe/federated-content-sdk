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

class BookingPassengerExtraBagSchema(object):
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
        'passenger_id': 'str',
        'leg_id': 'str',
        'segment_id': 'str',
        'bag_type': 'str',
        'bag_quantity': 'int'
    }

    attribute_map = {
        'passenger_id': 'passenger_id',
        'leg_id': 'leg_id',
        'segment_id': 'segment_id',
        'bag_type': 'bag_type',
        'bag_quantity': 'bag_quantity'
    }

    def __init__(self, passenger_id=None, leg_id=None, segment_id=None, bag_type=None, bag_quantity=None):  # noqa: E501
        """BookingPassengerExtraBagSchema - a model defined in Swagger"""  # noqa: E501
        self._passenger_id = None
        self._leg_id = None
        self._segment_id = None
        self._bag_type = None
        self._bag_quantity = None
        self.discriminator = None
        if passenger_id is not None:
            self.passenger_id = passenger_id
        if leg_id is not None:
            self.leg_id = leg_id
        if segment_id is not None:
            self.segment_id = segment_id
        if bag_type is not None:
            self.bag_type = bag_type
        if bag_quantity is not None:
            self.bag_quantity = bag_quantity

    @property
    def passenger_id(self):
        """Gets the passenger_id of this BookingPassengerExtraBagSchema.  # noqa: E501

        Identifier of the passenger with extra baggage.  # noqa: E501

        :return: The passenger_id of this BookingPassengerExtraBagSchema.  # noqa: E501
        :rtype: str
        """
        return self._passenger_id

    @passenger_id.setter
    def passenger_id(self, passenger_id):
        """Sets the passenger_id of this BookingPassengerExtraBagSchema.

        Identifier of the passenger with extra baggage.  # noqa: E501

        :param passenger_id: The passenger_id of this BookingPassengerExtraBagSchema.  # noqa: E501
        :type: str
        """

        self._passenger_id = passenger_id

    @property
    def leg_id(self):
        """Gets the leg_id of this BookingPassengerExtraBagSchema.  # noqa: E501

        Identifier of the flight leg associated with the extra baggage.  # noqa: E501

        :return: The leg_id of this BookingPassengerExtraBagSchema.  # noqa: E501
        :rtype: str
        """
        return self._leg_id

    @leg_id.setter
    def leg_id(self, leg_id):
        """Sets the leg_id of this BookingPassengerExtraBagSchema.

        Identifier of the flight leg associated with the extra baggage.  # noqa: E501

        :param leg_id: The leg_id of this BookingPassengerExtraBagSchema.  # noqa: E501
        :type: str
        """

        self._leg_id = leg_id

    @property
    def segment_id(self):
        """Gets the segment_id of this BookingPassengerExtraBagSchema.  # noqa: E501

        Identifier of the flight segment associated with the extra baggage.  # noqa: E501

        :return: The segment_id of this BookingPassengerExtraBagSchema.  # noqa: E501
        :rtype: str
        """
        return self._segment_id

    @segment_id.setter
    def segment_id(self, segment_id):
        """Sets the segment_id of this BookingPassengerExtraBagSchema.

        Identifier of the flight segment associated with the extra baggage.  # noqa: E501

        :param segment_id: The segment_id of this BookingPassengerExtraBagSchema.  # noqa: E501
        :type: str
        """

        self._segment_id = segment_id

    @property
    def bag_type(self):
        """Gets the bag_type of this BookingPassengerExtraBagSchema.  # noqa: E501

        Type of bag added as extra baggage.  # noqa: E501

        :return: The bag_type of this BookingPassengerExtraBagSchema.  # noqa: E501
        :rtype: str
        """
        return self._bag_type

    @bag_type.setter
    def bag_type(self, bag_type):
        """Sets the bag_type of this BookingPassengerExtraBagSchema.

        Type of bag added as extra baggage.  # noqa: E501

        :param bag_type: The bag_type of this BookingPassengerExtraBagSchema.  # noqa: E501
        :type: str
        """

        self._bag_type = bag_type

    @property
    def bag_quantity(self):
        """Gets the bag_quantity of this BookingPassengerExtraBagSchema.  # noqa: E501

        Quantity of the extra bags.  # noqa: E501

        :return: The bag_quantity of this BookingPassengerExtraBagSchema.  # noqa: E501
        :rtype: int
        """
        return self._bag_quantity

    @bag_quantity.setter
    def bag_quantity(self, bag_quantity):
        """Sets the bag_quantity of this BookingPassengerExtraBagSchema.

        Quantity of the extra bags.  # noqa: E501

        :param bag_quantity: The bag_quantity of this BookingPassengerExtraBagSchema.  # noqa: E501
        :type: int
        """

        self._bag_quantity = bag_quantity

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
        if issubclass(BookingPassengerExtraBagSchema, dict):
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
        if not isinstance(other, BookingPassengerExtraBagSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other