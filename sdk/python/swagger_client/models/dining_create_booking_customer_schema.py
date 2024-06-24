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

class DiningCreateBookingCustomerSchema(object):
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
        'first_name': 'str',
        'last_name': 'str',
        'email': 'str',
        'phone_prefix': 'str',
        'phone_number': 'str',
        'country': 'str'
    }

    attribute_map = {
        'first_name': 'first_name',
        'last_name': 'last_name',
        'email': 'email',
        'phone_prefix': 'phone_prefix',
        'phone_number': 'phone_number',
        'country': 'country'
    }

    def __init__(self, first_name=None, last_name=None, email=None, phone_prefix=None, phone_number=None, country=None):  # noqa: E501
        """DiningCreateBookingCustomerSchema - a model defined in Swagger"""  # noqa: E501
        self._first_name = None
        self._last_name = None
        self._email = None
        self._phone_prefix = None
        self._phone_number = None
        self._country = None
        self.discriminator = None
        if first_name is not None:
            self.first_name = first_name
        if last_name is not None:
            self.last_name = last_name
        if email is not None:
            self.email = email
        if phone_prefix is not None:
            self.phone_prefix = phone_prefix
        if phone_number is not None:
            self.phone_number = phone_number
        if country is not None:
            self.country = country

    @property
    def first_name(self):
        """Gets the first_name of this DiningCreateBookingCustomerSchema.  # noqa: E501

        First name of the customer.  # noqa: E501

        :return: The first_name of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :rtype: str
        """
        return self._first_name

    @first_name.setter
    def first_name(self, first_name):
        """Sets the first_name of this DiningCreateBookingCustomerSchema.

        First name of the customer.  # noqa: E501

        :param first_name: The first_name of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :type: str
        """

        self._first_name = first_name

    @property
    def last_name(self):
        """Gets the last_name of this DiningCreateBookingCustomerSchema.  # noqa: E501

        Last name of the customer.  # noqa: E501

        :return: The last_name of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :rtype: str
        """
        return self._last_name

    @last_name.setter
    def last_name(self, last_name):
        """Sets the last_name of this DiningCreateBookingCustomerSchema.

        Last name of the customer.  # noqa: E501

        :param last_name: The last_name of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :type: str
        """

        self._last_name = last_name

    @property
    def email(self):
        """Gets the email of this DiningCreateBookingCustomerSchema.  # noqa: E501

        Email address of the customer.  # noqa: E501

        :return: The email of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :rtype: str
        """
        return self._email

    @email.setter
    def email(self, email):
        """Sets the email of this DiningCreateBookingCustomerSchema.

        Email address of the customer.  # noqa: E501

        :param email: The email of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :type: str
        """

        self._email = email

    @property
    def phone_prefix(self):
        """Gets the phone_prefix of this DiningCreateBookingCustomerSchema.  # noqa: E501

        Phone number prefix for international calls.  # noqa: E501

        :return: The phone_prefix of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :rtype: str
        """
        return self._phone_prefix

    @phone_prefix.setter
    def phone_prefix(self, phone_prefix):
        """Sets the phone_prefix of this DiningCreateBookingCustomerSchema.

        Phone number prefix for international calls.  # noqa: E501

        :param phone_prefix: The phone_prefix of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :type: str
        """

        self._phone_prefix = phone_prefix

    @property
    def phone_number(self):
        """Gets the phone_number of this DiningCreateBookingCustomerSchema.  # noqa: E501

        Phone number of the customer.  # noqa: E501

        :return: The phone_number of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :rtype: str
        """
        return self._phone_number

    @phone_number.setter
    def phone_number(self, phone_number):
        """Sets the phone_number of this DiningCreateBookingCustomerSchema.

        Phone number of the customer.  # noqa: E501

        :param phone_number: The phone_number of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :type: str
        """

        self._phone_number = phone_number

    @property
    def country(self):
        """Gets the country of this DiningCreateBookingCustomerSchema.  # noqa: E501

        Country of the customer.  # noqa: E501

        :return: The country of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :rtype: str
        """
        return self._country

    @country.setter
    def country(self, country):
        """Sets the country of this DiningCreateBookingCustomerSchema.

        Country of the customer.  # noqa: E501

        :param country: The country of this DiningCreateBookingCustomerSchema.  # noqa: E501
        :type: str
        """

        self._country = country

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
        if issubclass(DiningCreateBookingCustomerSchema, dict):
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
        if not isinstance(other, DiningCreateBookingCustomerSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
