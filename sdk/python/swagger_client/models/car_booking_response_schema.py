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

class CarBookingResponseSchema(object):
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
        'company_id': 'str',
        'tenant_id': 'str',
        'category_id': 'str',
        'supplier_id': 'str',
        'booking_id': 'str',
        'supplier_booking_id': 'str',
        'supplier_booking_reference': 'str',
        'customer_reference': 'str',
        'booking_reference': 'str',
        'payment_reference': 'str',
        'booking_status': 'str',
        'booking_tax': 'float',
        'booking_price': 'float',
        'booking_currency': 'str',
        'booking_cancelation_policies': 'str',
        'customer': 'CarBookingCustomerSchema',
        'offer_request': 'CarOfferRequestSchema',
        'offer': 'CarOfferResponseItemSchema',
        'success': 'bool',
        'error_message': 'str'
    }

    attribute_map = {
        'company_id': 'company_id',
        'tenant_id': 'tenant_id',
        'category_id': 'category_id',
        'supplier_id': 'supplier_id',
        'booking_id': 'booking_id',
        'supplier_booking_id': 'supplier_booking_id',
        'supplier_booking_reference': 'supplier_booking_reference',
        'customer_reference': 'customer_reference',
        'booking_reference': 'booking_reference',
        'payment_reference': 'payment_reference',
        'booking_status': 'booking_status',
        'booking_tax': 'booking_tax',
        'booking_price': 'booking_price',
        'booking_currency': 'booking_currency',
        'booking_cancelation_policies': 'booking_cancelation_policies',
        'customer': 'customer',
        'offer_request': 'offer_request',
        'offer': 'offer',
        'success': 'success',
        'error_message': 'error_message'
    }

    def __init__(self, company_id=None, tenant_id=None, category_id=None, supplier_id=None, booking_id=None, supplier_booking_id=None, supplier_booking_reference=None, customer_reference=None, booking_reference=None, payment_reference=None, booking_status=None, booking_tax=None, booking_price=None, booking_currency=None, booking_cancelation_policies=None, customer=None, offer_request=None, offer=None, success=None, error_message=None):  # noqa: E501
        """CarBookingResponseSchema - a model defined in Swagger"""  # noqa: E501
        self._company_id = None
        self._tenant_id = None
        self._category_id = None
        self._supplier_id = None
        self._booking_id = None
        self._supplier_booking_id = None
        self._supplier_booking_reference = None
        self._customer_reference = None
        self._booking_reference = None
        self._payment_reference = None
        self._booking_status = None
        self._booking_tax = None
        self._booking_price = None
        self._booking_currency = None
        self._booking_cancelation_policies = None
        self._customer = None
        self._offer_request = None
        self._offer = None
        self._success = None
        self._error_message = None
        self.discriminator = None
        if company_id is not None:
            self.company_id = company_id
        if tenant_id is not None:
            self.tenant_id = tenant_id
        if category_id is not None:
            self.category_id = category_id
        if supplier_id is not None:
            self.supplier_id = supplier_id
        if booking_id is not None:
            self.booking_id = booking_id
        if supplier_booking_id is not None:
            self.supplier_booking_id = supplier_booking_id
        if supplier_booking_reference is not None:
            self.supplier_booking_reference = supplier_booking_reference
        if customer_reference is not None:
            self.customer_reference = customer_reference
        if booking_reference is not None:
            self.booking_reference = booking_reference
        if payment_reference is not None:
            self.payment_reference = payment_reference
        if booking_status is not None:
            self.booking_status = booking_status
        if booking_tax is not None:
            self.booking_tax = booking_tax
        if booking_price is not None:
            self.booking_price = booking_price
        if booking_currency is not None:
            self.booking_currency = booking_currency
        if booking_cancelation_policies is not None:
            self.booking_cancelation_policies = booking_cancelation_policies
        if customer is not None:
            self.customer = customer
        if offer_request is not None:
            self.offer_request = offer_request
        if offer is not None:
            self.offer = offer
        if success is not None:
            self.success = success
        if error_message is not None:
            self.error_message = error_message

    @property
    def company_id(self):
        """Gets the company_id of this CarBookingResponseSchema.  # noqa: E501

        Identifier for the company associated with the booking.  # noqa: E501

        :return: The company_id of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._company_id

    @company_id.setter
    def company_id(self, company_id):
        """Sets the company_id of this CarBookingResponseSchema.

        Identifier for the company associated with the booking.  # noqa: E501

        :param company_id: The company_id of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._company_id = company_id

    @property
    def tenant_id(self):
        """Gets the tenant_id of this CarBookingResponseSchema.  # noqa: E501

        Identifier for the tenant associated with the booking.  # noqa: E501

        :return: The tenant_id of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._tenant_id

    @tenant_id.setter
    def tenant_id(self, tenant_id):
        """Sets the tenant_id of this CarBookingResponseSchema.

        Identifier for the tenant associated with the booking.  # noqa: E501

        :param tenant_id: The tenant_id of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._tenant_id = tenant_id

    @property
    def category_id(self):
        """Gets the category_id of this CarBookingResponseSchema.  # noqa: E501

        Identifier for the category of the booking.  # noqa: E501

        :return: The category_id of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._category_id

    @category_id.setter
    def category_id(self, category_id):
        """Sets the category_id of this CarBookingResponseSchema.

        Identifier for the category of the booking.  # noqa: E501

        :param category_id: The category_id of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._category_id = category_id

    @property
    def supplier_id(self):
        """Gets the supplier_id of this CarBookingResponseSchema.  # noqa: E501

        Identifier for the supplier of the booking.  # noqa: E501

        :return: The supplier_id of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._supplier_id

    @supplier_id.setter
    def supplier_id(self, supplier_id):
        """Sets the supplier_id of this CarBookingResponseSchema.

        Identifier for the supplier of the booking.  # noqa: E501

        :param supplier_id: The supplier_id of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._supplier_id = supplier_id

    @property
    def booking_id(self):
        """Gets the booking_id of this CarBookingResponseSchema.  # noqa: E501

        Unique identifier for the booking.  # noqa: E501

        :return: The booking_id of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._booking_id

    @booking_id.setter
    def booking_id(self, booking_id):
        """Sets the booking_id of this CarBookingResponseSchema.

        Unique identifier for the booking.  # noqa: E501

        :param booking_id: The booking_id of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._booking_id = booking_id

    @property
    def supplier_booking_id(self):
        """Gets the supplier_booking_id of this CarBookingResponseSchema.  # noqa: E501

        Supplier’s identifier for the booking.  # noqa: E501

        :return: The supplier_booking_id of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._supplier_booking_id

    @supplier_booking_id.setter
    def supplier_booking_id(self, supplier_booking_id):
        """Sets the supplier_booking_id of this CarBookingResponseSchema.

        Supplier’s identifier for the booking.  # noqa: E501

        :param supplier_booking_id: The supplier_booking_id of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._supplier_booking_id = supplier_booking_id

    @property
    def supplier_booking_reference(self):
        """Gets the supplier_booking_reference of this CarBookingResponseSchema.  # noqa: E501

        Reference number provided by the supplier for the booking.  # noqa: E501

        :return: The supplier_booking_reference of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._supplier_booking_reference

    @supplier_booking_reference.setter
    def supplier_booking_reference(self, supplier_booking_reference):
        """Sets the supplier_booking_reference of this CarBookingResponseSchema.

        Reference number provided by the supplier for the booking.  # noqa: E501

        :param supplier_booking_reference: The supplier_booking_reference of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._supplier_booking_reference = supplier_booking_reference

    @property
    def customer_reference(self):
        """Gets the customer_reference of this CarBookingResponseSchema.  # noqa: E501

        Customer reference number associated with the booking.  # noqa: E501

        :return: The customer_reference of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._customer_reference

    @customer_reference.setter
    def customer_reference(self, customer_reference):
        """Sets the customer_reference of this CarBookingResponseSchema.

        Customer reference number associated with the booking.  # noqa: E501

        :param customer_reference: The customer_reference of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._customer_reference = customer_reference

    @property
    def booking_reference(self):
        """Gets the booking_reference of this CarBookingResponseSchema.  # noqa: E501

        Internal reference number for the booking.  # noqa: E501

        :return: The booking_reference of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._booking_reference

    @booking_reference.setter
    def booking_reference(self, booking_reference):
        """Sets the booking_reference of this CarBookingResponseSchema.

        Internal reference number for the booking.  # noqa: E501

        :param booking_reference: The booking_reference of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._booking_reference = booking_reference

    @property
    def payment_reference(self):
        """Gets the payment_reference of this CarBookingResponseSchema.  # noqa: E501

        Reference number for the payment associated with the booking.  # noqa: E501

        :return: The payment_reference of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._payment_reference

    @payment_reference.setter
    def payment_reference(self, payment_reference):
        """Sets the payment_reference of this CarBookingResponseSchema.

        Reference number for the payment associated with the booking.  # noqa: E501

        :param payment_reference: The payment_reference of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._payment_reference = payment_reference

    @property
    def booking_status(self):
        """Gets the booking_status of this CarBookingResponseSchema.  # noqa: E501

        Current status of the booking.  # noqa: E501

        :return: The booking_status of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._booking_status

    @booking_status.setter
    def booking_status(self, booking_status):
        """Sets the booking_status of this CarBookingResponseSchema.

        Current status of the booking.  # noqa: E501

        :param booking_status: The booking_status of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._booking_status = booking_status

    @property
    def booking_tax(self):
        """Gets the booking_tax of this CarBookingResponseSchema.  # noqa: E501

        Tax applied to the booking.  # noqa: E501

        :return: The booking_tax of this CarBookingResponseSchema.  # noqa: E501
        :rtype: float
        """
        return self._booking_tax

    @booking_tax.setter
    def booking_tax(self, booking_tax):
        """Sets the booking_tax of this CarBookingResponseSchema.

        Tax applied to the booking.  # noqa: E501

        :param booking_tax: The booking_tax of this CarBookingResponseSchema.  # noqa: E501
        :type: float
        """

        self._booking_tax = booking_tax

    @property
    def booking_price(self):
        """Gets the booking_price of this CarBookingResponseSchema.  # noqa: E501

        Total price of the booking.  # noqa: E501

        :return: The booking_price of this CarBookingResponseSchema.  # noqa: E501
        :rtype: float
        """
        return self._booking_price

    @booking_price.setter
    def booking_price(self, booking_price):
        """Sets the booking_price of this CarBookingResponseSchema.

        Total price of the booking.  # noqa: E501

        :param booking_price: The booking_price of this CarBookingResponseSchema.  # noqa: E501
        :type: float
        """

        self._booking_price = booking_price

    @property
    def booking_currency(self):
        """Gets the booking_currency of this CarBookingResponseSchema.  # noqa: E501

        Currency used for the booking pricing.  # noqa: E501

        :return: The booking_currency of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._booking_currency

    @booking_currency.setter
    def booking_currency(self, booking_currency):
        """Sets the booking_currency of this CarBookingResponseSchema.

        Currency used for the booking pricing.  # noqa: E501

        :param booking_currency: The booking_currency of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._booking_currency = booking_currency

    @property
    def booking_cancelation_policies(self):
        """Gets the booking_cancelation_policies of this CarBookingResponseSchema.  # noqa: E501

        Cancellation policies applicable to the booking.  # noqa: E501

        :return: The booking_cancelation_policies of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._booking_cancelation_policies

    @booking_cancelation_policies.setter
    def booking_cancelation_policies(self, booking_cancelation_policies):
        """Sets the booking_cancelation_policies of this CarBookingResponseSchema.

        Cancellation policies applicable to the booking.  # noqa: E501

        :param booking_cancelation_policies: The booking_cancelation_policies of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._booking_cancelation_policies = booking_cancelation_policies

    @property
    def customer(self):
        """Gets the customer of this CarBookingResponseSchema.  # noqa: E501


        :return: The customer of this CarBookingResponseSchema.  # noqa: E501
        :rtype: CarBookingCustomerSchema
        """
        return self._customer

    @customer.setter
    def customer(self, customer):
        """Sets the customer of this CarBookingResponseSchema.


        :param customer: The customer of this CarBookingResponseSchema.  # noqa: E501
        :type: CarBookingCustomerSchema
        """

        self._customer = customer

    @property
    def offer_request(self):
        """Gets the offer_request of this CarBookingResponseSchema.  # noqa: E501


        :return: The offer_request of this CarBookingResponseSchema.  # noqa: E501
        :rtype: CarOfferRequestSchema
        """
        return self._offer_request

    @offer_request.setter
    def offer_request(self, offer_request):
        """Sets the offer_request of this CarBookingResponseSchema.


        :param offer_request: The offer_request of this CarBookingResponseSchema.  # noqa: E501
        :type: CarOfferRequestSchema
        """

        self._offer_request = offer_request

    @property
    def offer(self):
        """Gets the offer of this CarBookingResponseSchema.  # noqa: E501


        :return: The offer of this CarBookingResponseSchema.  # noqa: E501
        :rtype: CarOfferResponseItemSchema
        """
        return self._offer

    @offer.setter
    def offer(self, offer):
        """Sets the offer of this CarBookingResponseSchema.


        :param offer: The offer of this CarBookingResponseSchema.  # noqa: E501
        :type: CarOfferResponseItemSchema
        """

        self._offer = offer

    @property
    def success(self):
        """Gets the success of this CarBookingResponseSchema.  # noqa: E501

        Indicates if the booking was successful.  # noqa: E501

        :return: The success of this CarBookingResponseSchema.  # noqa: E501
        :rtype: bool
        """
        return self._success

    @success.setter
    def success(self, success):
        """Sets the success of this CarBookingResponseSchema.

        Indicates if the booking was successful.  # noqa: E501

        :param success: The success of this CarBookingResponseSchema.  # noqa: E501
        :type: bool
        """

        self._success = success

    @property
    def error_message(self):
        """Gets the error_message of this CarBookingResponseSchema.  # noqa: E501

        Provides details on any error that occurred during the booking process.  # noqa: E501

        :return: The error_message of this CarBookingResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._error_message

    @error_message.setter
    def error_message(self, error_message):
        """Sets the error_message of this CarBookingResponseSchema.

        Provides details on any error that occurred during the booking process.  # noqa: E501

        :param error_message: The error_message of this CarBookingResponseSchema.  # noqa: E501
        :type: str
        """

        self._error_message = error_message

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
        if issubclass(CarBookingResponseSchema, dict):
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
        if not isinstance(other, CarBookingResponseSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
