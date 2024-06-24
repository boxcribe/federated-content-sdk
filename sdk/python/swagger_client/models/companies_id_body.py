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

class CompaniesIdBody(object):
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
        'name': 'str',
        'status': 'str',
        'address': 'str',
        'address2': 'str',
        'city': 'str',
        'state': 'str',
        'zip': 'str',
        'country': 'str',
        'phone': 'str',
        'mobile': 'str',
        'fax': 'str',
        'email': 'str',
        'website': 'str',
        'logo': 'str',
        'icon': 'str',
        'color1': 'str',
        'color2': 'str',
        'description': 'str'
    }

    attribute_map = {
        'name': 'name',
        'status': 'status',
        'address': 'address',
        'address2': 'address2',
        'city': 'city',
        'state': 'state',
        'zip': 'zip',
        'country': 'country',
        'phone': 'phone',
        'mobile': 'mobile',
        'fax': 'fax',
        'email': 'email',
        'website': 'website',
        'logo': 'logo',
        'icon': 'icon',
        'color1': 'color1',
        'color2': 'color2',
        'description': 'description'
    }

    def __init__(self, name=None, status=None, address=None, address2=None, city=None, state=None, zip=None, country=None, phone=None, mobile=None, fax=None, email=None, website=None, logo=None, icon=None, color1=None, color2=None, description=None):  # noqa: E501
        """CompaniesIdBody - a model defined in Swagger"""  # noqa: E501
        self._name = None
        self._status = None
        self._address = None
        self._address2 = None
        self._city = None
        self._state = None
        self._zip = None
        self._country = None
        self._phone = None
        self._mobile = None
        self._fax = None
        self._email = None
        self._website = None
        self._logo = None
        self._icon = None
        self._color1 = None
        self._color2 = None
        self._description = None
        self.discriminator = None
        if name is not None:
            self.name = name
        if status is not None:
            self.status = status
        if address is not None:
            self.address = address
        if address2 is not None:
            self.address2 = address2
        if city is not None:
            self.city = city
        if state is not None:
            self.state = state
        if zip is not None:
            self.zip = zip
        if country is not None:
            self.country = country
        if phone is not None:
            self.phone = phone
        if mobile is not None:
            self.mobile = mobile
        if fax is not None:
            self.fax = fax
        if email is not None:
            self.email = email
        if website is not None:
            self.website = website
        if logo is not None:
            self.logo = logo
        if icon is not None:
            self.icon = icon
        if color1 is not None:
            self.color1 = color1
        if color2 is not None:
            self.color2 = color2
        if description is not None:
            self.description = description

    @property
    def name(self):
        """Gets the name of this CompaniesIdBody.  # noqa: E501


        :return: The name of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this CompaniesIdBody.


        :param name: The name of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._name = name

    @property
    def status(self):
        """Gets the status of this CompaniesIdBody.  # noqa: E501


        :return: The status of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this CompaniesIdBody.


        :param status: The status of this CompaniesIdBody.  # noqa: E501
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
    def address(self):
        """Gets the address of this CompaniesIdBody.  # noqa: E501


        :return: The address of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._address

    @address.setter
    def address(self, address):
        """Sets the address of this CompaniesIdBody.


        :param address: The address of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._address = address

    @property
    def address2(self):
        """Gets the address2 of this CompaniesIdBody.  # noqa: E501


        :return: The address2 of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._address2

    @address2.setter
    def address2(self, address2):
        """Sets the address2 of this CompaniesIdBody.


        :param address2: The address2 of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._address2 = address2

    @property
    def city(self):
        """Gets the city of this CompaniesIdBody.  # noqa: E501


        :return: The city of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._city

    @city.setter
    def city(self, city):
        """Sets the city of this CompaniesIdBody.


        :param city: The city of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._city = city

    @property
    def state(self):
        """Gets the state of this CompaniesIdBody.  # noqa: E501


        :return: The state of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._state

    @state.setter
    def state(self, state):
        """Sets the state of this CompaniesIdBody.


        :param state: The state of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._state = state

    @property
    def zip(self):
        """Gets the zip of this CompaniesIdBody.  # noqa: E501


        :return: The zip of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._zip

    @zip.setter
    def zip(self, zip):
        """Sets the zip of this CompaniesIdBody.


        :param zip: The zip of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._zip = zip

    @property
    def country(self):
        """Gets the country of this CompaniesIdBody.  # noqa: E501


        :return: The country of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._country

    @country.setter
    def country(self, country):
        """Sets the country of this CompaniesIdBody.


        :param country: The country of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._country = country

    @property
    def phone(self):
        """Gets the phone of this CompaniesIdBody.  # noqa: E501


        :return: The phone of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._phone

    @phone.setter
    def phone(self, phone):
        """Sets the phone of this CompaniesIdBody.


        :param phone: The phone of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._phone = phone

    @property
    def mobile(self):
        """Gets the mobile of this CompaniesIdBody.  # noqa: E501


        :return: The mobile of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._mobile

    @mobile.setter
    def mobile(self, mobile):
        """Sets the mobile of this CompaniesIdBody.


        :param mobile: The mobile of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._mobile = mobile

    @property
    def fax(self):
        """Gets the fax of this CompaniesIdBody.  # noqa: E501


        :return: The fax of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._fax

    @fax.setter
    def fax(self, fax):
        """Sets the fax of this CompaniesIdBody.


        :param fax: The fax of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._fax = fax

    @property
    def email(self):
        """Gets the email of this CompaniesIdBody.  # noqa: E501


        :return: The email of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._email

    @email.setter
    def email(self, email):
        """Sets the email of this CompaniesIdBody.


        :param email: The email of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._email = email

    @property
    def website(self):
        """Gets the website of this CompaniesIdBody.  # noqa: E501


        :return: The website of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._website

    @website.setter
    def website(self, website):
        """Sets the website of this CompaniesIdBody.


        :param website: The website of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._website = website

    @property
    def logo(self):
        """Gets the logo of this CompaniesIdBody.  # noqa: E501


        :return: The logo of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._logo

    @logo.setter
    def logo(self, logo):
        """Sets the logo of this CompaniesIdBody.


        :param logo: The logo of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._logo = logo

    @property
    def icon(self):
        """Gets the icon of this CompaniesIdBody.  # noqa: E501


        :return: The icon of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._icon

    @icon.setter
    def icon(self, icon):
        """Sets the icon of this CompaniesIdBody.


        :param icon: The icon of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._icon = icon

    @property
    def color1(self):
        """Gets the color1 of this CompaniesIdBody.  # noqa: E501


        :return: The color1 of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._color1

    @color1.setter
    def color1(self, color1):
        """Sets the color1 of this CompaniesIdBody.


        :param color1: The color1 of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._color1 = color1

    @property
    def color2(self):
        """Gets the color2 of this CompaniesIdBody.  # noqa: E501


        :return: The color2 of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._color2

    @color2.setter
    def color2(self, color2):
        """Sets the color2 of this CompaniesIdBody.


        :param color2: The color2 of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._color2 = color2

    @property
    def description(self):
        """Gets the description of this CompaniesIdBody.  # noqa: E501


        :return: The description of this CompaniesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._description

    @description.setter
    def description(self, description):
        """Sets the description of this CompaniesIdBody.


        :param description: The description of this CompaniesIdBody.  # noqa: E501
        :type: str
        """

        self._description = description

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
        if issubclass(CompaniesIdBody, dict):
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
        if not isinstance(other, CompaniesIdBody):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
