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

class FlightOfferDetailsResponseSchema(object):
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
        'supplier_offer_id': 'str',
        'offer_index': 'int',
        'offer_price': 'float',
        'offer_currency': 'str',
        'offer_cancelation_policies': 'str',
        'offer_airline_name': 'str',
        'offer_airline_code': 'str',
        'offer_airline_logo': 'str'
    }

    attribute_map = {
        'offer_id': 'offer_id',
        'supplier_offer_id': 'supplier_offer_id',
        'offer_index': 'offer_index',
        'offer_price': 'offer_price',
        'offer_currency': 'offer_currency',
        'offer_cancelation_policies': 'offer_cancelation_policies',
        'offer_airline_name': 'offer_airline_name',
        'offer_airline_code': 'offer_airline_code',
        'offer_airline_logo': 'offer_airline_logo'
    }

    def __init__(self, offer_id=None, supplier_offer_id=None, offer_index=None, offer_price=None, offer_currency=None, offer_cancelation_policies=None, offer_airline_name=None, offer_airline_code=None, offer_airline_logo=None):  # noqa: E501
        """FlightOfferDetailsResponseSchema - a model defined in Swagger"""  # noqa: E501
        self._offer_id = None
        self._supplier_offer_id = None
        self._offer_index = None
        self._offer_price = None
        self._offer_currency = None
        self._offer_cancelation_policies = None
        self._offer_airline_name = None
        self._offer_airline_code = None
        self._offer_airline_logo = None
        self.discriminator = None
        if offer_id is not None:
            self.offer_id = offer_id
        if supplier_offer_id is not None:
            self.supplier_offer_id = supplier_offer_id
        if offer_index is not None:
            self.offer_index = offer_index
        if offer_price is not None:
            self.offer_price = offer_price
        if offer_currency is not None:
            self.offer_currency = offer_currency
        if offer_cancelation_policies is not None:
            self.offer_cancelation_policies = offer_cancelation_policies
        if offer_airline_name is not None:
            self.offer_airline_name = offer_airline_name
        if offer_airline_code is not None:
            self.offer_airline_code = offer_airline_code
        if offer_airline_logo is not None:
            self.offer_airline_logo = offer_airline_logo

    @property
    def offer_id(self):
        """Gets the offer_id of this FlightOfferDetailsResponseSchema.  # noqa: E501

        Unique identifier for the offer.  # noqa: E501

        :return: The offer_id of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._offer_id

    @offer_id.setter
    def offer_id(self, offer_id):
        """Sets the offer_id of this FlightOfferDetailsResponseSchema.

        Unique identifier for the offer.  # noqa: E501

        :param offer_id: The offer_id of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :type: str
        """

        self._offer_id = offer_id

    @property
    def supplier_offer_id(self):
        """Gets the supplier_offer_id of this FlightOfferDetailsResponseSchema.  # noqa: E501

        Unique identifier for the supplier’s offer.  # noqa: E501

        :return: The supplier_offer_id of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._supplier_offer_id

    @supplier_offer_id.setter
    def supplier_offer_id(self, supplier_offer_id):
        """Sets the supplier_offer_id of this FlightOfferDetailsResponseSchema.

        Unique identifier for the supplier’s offer.  # noqa: E501

        :param supplier_offer_id: The supplier_offer_id of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :type: str
        """

        self._supplier_offer_id = supplier_offer_id

    @property
    def offer_index(self):
        """Gets the offer_index of this FlightOfferDetailsResponseSchema.  # noqa: E501

        Index of the offer for sorting purposes.  # noqa: E501

        :return: The offer_index of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :rtype: int
        """
        return self._offer_index

    @offer_index.setter
    def offer_index(self, offer_index):
        """Sets the offer_index of this FlightOfferDetailsResponseSchema.

        Index of the offer for sorting purposes.  # noqa: E501

        :param offer_index: The offer_index of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :type: int
        """

        self._offer_index = offer_index

    @property
    def offer_price(self):
        """Gets the offer_price of this FlightOfferDetailsResponseSchema.  # noqa: E501

        Price of the offer.  # noqa: E501

        :return: The offer_price of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :rtype: float
        """
        return self._offer_price

    @offer_price.setter
    def offer_price(self, offer_price):
        """Sets the offer_price of this FlightOfferDetailsResponseSchema.

        Price of the offer.  # noqa: E501

        :param offer_price: The offer_price of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :type: float
        """

        self._offer_price = offer_price

    @property
    def offer_currency(self):
        """Gets the offer_currency of this FlightOfferDetailsResponseSchema.  # noqa: E501

        Currency of the offer price.  # noqa: E501

        :return: The offer_currency of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._offer_currency

    @offer_currency.setter
    def offer_currency(self, offer_currency):
        """Sets the offer_currency of this FlightOfferDetailsResponseSchema.

        Currency of the offer price.  # noqa: E501

        :param offer_currency: The offer_currency of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :type: str
        """

        self._offer_currency = offer_currency

    @property
    def offer_cancelation_policies(self):
        """Gets the offer_cancelation_policies of this FlightOfferDetailsResponseSchema.  # noqa: E501

        Cancellation policies applicable to the offer.  # noqa: E501

        :return: The offer_cancelation_policies of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._offer_cancelation_policies

    @offer_cancelation_policies.setter
    def offer_cancelation_policies(self, offer_cancelation_policies):
        """Sets the offer_cancelation_policies of this FlightOfferDetailsResponseSchema.

        Cancellation policies applicable to the offer.  # noqa: E501

        :param offer_cancelation_policies: The offer_cancelation_policies of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :type: str
        """

        self._offer_cancelation_policies = offer_cancelation_policies

    @property
    def offer_airline_name(self):
        """Gets the offer_airline_name of this FlightOfferDetailsResponseSchema.  # noqa: E501

        Name of the airline providing the offer.  # noqa: E501

        :return: The offer_airline_name of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._offer_airline_name

    @offer_airline_name.setter
    def offer_airline_name(self, offer_airline_name):
        """Sets the offer_airline_name of this FlightOfferDetailsResponseSchema.

        Name of the airline providing the offer.  # noqa: E501

        :param offer_airline_name: The offer_airline_name of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :type: str
        """

        self._offer_airline_name = offer_airline_name

    @property
    def offer_airline_code(self):
        """Gets the offer_airline_code of this FlightOfferDetailsResponseSchema.  # noqa: E501

        Code of the airline providing the offer.  # noqa: E501

        :return: The offer_airline_code of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._offer_airline_code

    @offer_airline_code.setter
    def offer_airline_code(self, offer_airline_code):
        """Sets the offer_airline_code of this FlightOfferDetailsResponseSchema.

        Code of the airline providing the offer.  # noqa: E501

        :param offer_airline_code: The offer_airline_code of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :type: str
        """

        self._offer_airline_code = offer_airline_code

    @property
    def offer_airline_logo(self):
        """Gets the offer_airline_logo of this FlightOfferDetailsResponseSchema.  # noqa: E501

        Logo URL of the airline.  # noqa: E501

        :return: The offer_airline_logo of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._offer_airline_logo

    @offer_airline_logo.setter
    def offer_airline_logo(self, offer_airline_logo):
        """Sets the offer_airline_logo of this FlightOfferDetailsResponseSchema.

        Logo URL of the airline.  # noqa: E501

        :param offer_airline_logo: The offer_airline_logo of this FlightOfferDetailsResponseSchema.  # noqa: E501
        :type: str
        """

        self._offer_airline_logo = offer_airline_logo

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
        if issubclass(FlightOfferDetailsResponseSchema, dict):
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
        if not isinstance(other, FlightOfferDetailsResponseSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
