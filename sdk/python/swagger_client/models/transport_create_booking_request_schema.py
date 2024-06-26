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

class TransportCreateBookingRequestSchema(object):
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
        'customer': 'TransportCreateBookingCustomerSchema',
        'payment': 'TransportCreateBookingPaymentSchema',
        'currency': 'str',
        'customer_reference': 'str',
        'booking_reference': 'str',
        'payment_reference': 'str',
        'booking_questions': 'list[str]'
    }

    attribute_map = {
        'offer_id': 'offer_id',
        'customer': 'customer',
        'payment': 'payment',
        'currency': 'currency',
        'customer_reference': 'customer_reference',
        'booking_reference': 'booking_reference',
        'payment_reference': 'payment_reference',
        'booking_questions': 'booking_questions'
    }

    def __init__(self, offer_id=None, customer=None, payment=None, currency=None, customer_reference=None, booking_reference=None, payment_reference=None, booking_questions=None):  # noqa: E501
        """TransportCreateBookingRequestSchema - a model defined in Swagger"""  # noqa: E501
        self._offer_id = None
        self._customer = None
        self._payment = None
        self._currency = None
        self._customer_reference = None
        self._booking_reference = None
        self._payment_reference = None
        self._booking_questions = None
        self.discriminator = None
        if offer_id is not None:
            self.offer_id = offer_id
        if customer is not None:
            self.customer = customer
        if payment is not None:
            self.payment = payment
        if currency is not None:
            self.currency = currency
        if customer_reference is not None:
            self.customer_reference = customer_reference
        if booking_reference is not None:
            self.booking_reference = booking_reference
        if payment_reference is not None:
            self.payment_reference = payment_reference
        if booking_questions is not None:
            self.booking_questions = booking_questions

    @property
    def offer_id(self):
        """Gets the offer_id of this TransportCreateBookingRequestSchema.  # noqa: E501

        Unique identifier for the offer.  # noqa: E501

        :return: The offer_id of this TransportCreateBookingRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._offer_id

    @offer_id.setter
    def offer_id(self, offer_id):
        """Sets the offer_id of this TransportCreateBookingRequestSchema.

        Unique identifier for the offer.  # noqa: E501

        :param offer_id: The offer_id of this TransportCreateBookingRequestSchema.  # noqa: E501
        :type: str
        """

        self._offer_id = offer_id

    @property
    def customer(self):
        """Gets the customer of this TransportCreateBookingRequestSchema.  # noqa: E501


        :return: The customer of this TransportCreateBookingRequestSchema.  # noqa: E501
        :rtype: TransportCreateBookingCustomerSchema
        """
        return self._customer

    @customer.setter
    def customer(self, customer):
        """Sets the customer of this TransportCreateBookingRequestSchema.


        :param customer: The customer of this TransportCreateBookingRequestSchema.  # noqa: E501
        :type: TransportCreateBookingCustomerSchema
        """

        self._customer = customer

    @property
    def payment(self):
        """Gets the payment of this TransportCreateBookingRequestSchema.  # noqa: E501


        :return: The payment of this TransportCreateBookingRequestSchema.  # noqa: E501
        :rtype: TransportCreateBookingPaymentSchema
        """
        return self._payment

    @payment.setter
    def payment(self, payment):
        """Sets the payment of this TransportCreateBookingRequestSchema.


        :param payment: The payment of this TransportCreateBookingRequestSchema.  # noqa: E501
        :type: TransportCreateBookingPaymentSchema
        """

        self._payment = payment

    @property
    def currency(self):
        """Gets the currency of this TransportCreateBookingRequestSchema.  # noqa: E501

        Currency used for the booking.  # noqa: E501

        :return: The currency of this TransportCreateBookingRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._currency

    @currency.setter
    def currency(self, currency):
        """Sets the currency of this TransportCreateBookingRequestSchema.

        Currency used for the booking.  # noqa: E501

        :param currency: The currency of this TransportCreateBookingRequestSchema.  # noqa: E501
        :type: str
        """

        self._currency = currency

    @property
    def customer_reference(self):
        """Gets the customer_reference of this TransportCreateBookingRequestSchema.  # noqa: E501

        Customer reference identifier.  # noqa: E501

        :return: The customer_reference of this TransportCreateBookingRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._customer_reference

    @customer_reference.setter
    def customer_reference(self, customer_reference):
        """Sets the customer_reference of this TransportCreateBookingRequestSchema.

        Customer reference identifier.  # noqa: E501

        :param customer_reference: The customer_reference of this TransportCreateBookingRequestSchema.  # noqa: E501
        :type: str
        """

        self._customer_reference = customer_reference

    @property
    def booking_reference(self):
        """Gets the booking_reference of this TransportCreateBookingRequestSchema.  # noqa: E501

        Booking reference identifier.  # noqa: E501

        :return: The booking_reference of this TransportCreateBookingRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._booking_reference

    @booking_reference.setter
    def booking_reference(self, booking_reference):
        """Sets the booking_reference of this TransportCreateBookingRequestSchema.

        Booking reference identifier.  # noqa: E501

        :param booking_reference: The booking_reference of this TransportCreateBookingRequestSchema.  # noqa: E501
        :type: str
        """

        self._booking_reference = booking_reference

    @property
    def payment_reference(self):
        """Gets the payment_reference of this TransportCreateBookingRequestSchema.  # noqa: E501

        Payment transaction reference.  # noqa: E501

        :return: The payment_reference of this TransportCreateBookingRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._payment_reference

    @payment_reference.setter
    def payment_reference(self, payment_reference):
        """Sets the payment_reference of this TransportCreateBookingRequestSchema.

        Payment transaction reference.  # noqa: E501

        :param payment_reference: The payment_reference of this TransportCreateBookingRequestSchema.  # noqa: E501
        :type: str
        """

        self._payment_reference = payment_reference

    @property
    def booking_questions(self):
        """Gets the booking_questions of this TransportCreateBookingRequestSchema.  # noqa: E501

        Questions related to booking the transport.  # noqa: E501

        :return: The booking_questions of this TransportCreateBookingRequestSchema.  # noqa: E501
        :rtype: list[str]
        """
        return self._booking_questions

    @booking_questions.setter
    def booking_questions(self, booking_questions):
        """Sets the booking_questions of this TransportCreateBookingRequestSchema.

        Questions related to booking the transport.  # noqa: E501

        :param booking_questions: The booking_questions of this TransportCreateBookingRequestSchema.  # noqa: E501
        :type: list[str]
        """

        self._booking_questions = booking_questions

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
        if issubclass(TransportCreateBookingRequestSchema, dict):
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
        if not isinstance(other, TransportCreateBookingRequestSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
