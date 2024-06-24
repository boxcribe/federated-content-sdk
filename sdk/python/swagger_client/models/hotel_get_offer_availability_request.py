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

class HotelGetOfferAvailabilityRequest(object):
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
        'offer_id': 'str',
        'checkin_date': 'date',
        'checkout_date': 'date'
    }

    attribute_map = {
        'offer_id': 'offer_id',
        'checkin_date': 'checkin_date',
        'checkout_date': 'checkout_date'
    }

    def __init__(self, offer_id=None, checkin_date=None, checkout_date=None):  # noqa: E501
        """HotelGetOfferAvailabilityRequest - a model defined in Swagger"""  # noqa: E501
        self._offer_id = None
        self._checkin_date = None
        self._checkout_date = None
        self.discriminator = None
        if offer_id is not None:
            self.offer_id = offer_id
        if checkin_date is not None:
            self.checkin_date = checkin_date
        if checkout_date is not None:
            self.checkout_date = checkout_date

    @property
    def offer_id(self):
        """Gets the offer_id of this HotelGetOfferAvailabilityRequest.  # noqa: E501

        Unique identifier of the hotel offer.  # noqa: E501

        :return: The offer_id of this HotelGetOfferAvailabilityRequest.  # noqa: E501
        :rtype: str
        """
        return self._offer_id

    @offer_id.setter
    def offer_id(self, offer_id):
        """Sets the offer_id of this HotelGetOfferAvailabilityRequest.

        Unique identifier of the hotel offer.  # noqa: E501

        :param offer_id: The offer_id of this HotelGetOfferAvailabilityRequest.  # noqa: E501
        :type: str
        """

        self._offer_id = offer_id

    @property
    def checkin_date(self):
        """Gets the checkin_date of this HotelGetOfferAvailabilityRequest.  # noqa: E501

        Scheduled check-in date for the hotel stay.  # noqa: E501

        :return: The checkin_date of this HotelGetOfferAvailabilityRequest.  # noqa: E501
        :rtype: date
        """
        return self._checkin_date

    @checkin_date.setter
    def checkin_date(self, checkin_date):
        """Sets the checkin_date of this HotelGetOfferAvailabilityRequest.

        Scheduled check-in date for the hotel stay.  # noqa: E501

        :param checkin_date: The checkin_date of this HotelGetOfferAvailabilityRequest.  # noqa: E501
        :type: date
        """

        self._checkin_date = checkin_date

    @property
    def checkout_date(self):
        """Gets the checkout_date of this HotelGetOfferAvailabilityRequest.  # noqa: E501

        Scheduled check-out date for the hotel stay.  # noqa: E501

        :return: The checkout_date of this HotelGetOfferAvailabilityRequest.  # noqa: E501
        :rtype: date
        """
        return self._checkout_date

    @checkout_date.setter
    def checkout_date(self, checkout_date):
        """Sets the checkout_date of this HotelGetOfferAvailabilityRequest.

        Scheduled check-out date for the hotel stay.  # noqa: E501

        :param checkout_date: The checkout_date of this HotelGetOfferAvailabilityRequest.  # noqa: E501
        :type: date
        """

        self._checkout_date = checkout_date

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
        if issubclass(HotelGetOfferAvailabilityRequest, dict):
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
        if not isinstance(other, HotelGetOfferAvailabilityRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
