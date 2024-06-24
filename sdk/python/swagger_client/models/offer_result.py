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

class OfferResult(object):
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
        'id': 'str',
        'offer_request_id': 'str',
        'normalized_response': 'OfferResultNormalizedResponse',
        'supplier_response': 'object'
    }

    attribute_map = {
        'id': 'id',
        'offer_request_id': 'offer_request_id',
        'normalized_response': 'normalized_response',
        'supplier_response': 'supplier_response'
    }

    def __init__(self, id=None, offer_request_id=None, normalized_response=None, supplier_response=None):  # noqa: E501
        """OfferResult - a model defined in Swagger"""  # noqa: E501
        self._id = None
        self._offer_request_id = None
        self._normalized_response = None
        self._supplier_response = None
        self.discriminator = None
        if id is not None:
            self.id = id
        if offer_request_id is not None:
            self.offer_request_id = offer_request_id
        if normalized_response is not None:
            self.normalized_response = normalized_response
        if supplier_response is not None:
            self.supplier_response = supplier_response

    @property
    def id(self):
        """Gets the id of this OfferResult.  # noqa: E501


        :return: The id of this OfferResult.  # noqa: E501
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this OfferResult.


        :param id: The id of this OfferResult.  # noqa: E501
        :type: str
        """

        self._id = id

    @property
    def offer_request_id(self):
        """Gets the offer_request_id of this OfferResult.  # noqa: E501


        :return: The offer_request_id of this OfferResult.  # noqa: E501
        :rtype: str
        """
        return self._offer_request_id

    @offer_request_id.setter
    def offer_request_id(self, offer_request_id):
        """Sets the offer_request_id of this OfferResult.


        :param offer_request_id: The offer_request_id of this OfferResult.  # noqa: E501
        :type: str
        """

        self._offer_request_id = offer_request_id

    @property
    def normalized_response(self):
        """Gets the normalized_response of this OfferResult.  # noqa: E501


        :return: The normalized_response of this OfferResult.  # noqa: E501
        :rtype: OfferResultNormalizedResponse
        """
        return self._normalized_response

    @normalized_response.setter
    def normalized_response(self, normalized_response):
        """Sets the normalized_response of this OfferResult.


        :param normalized_response: The normalized_response of this OfferResult.  # noqa: E501
        :type: OfferResultNormalizedResponse
        """

        self._normalized_response = normalized_response

    @property
    def supplier_response(self):
        """Gets the supplier_response of this OfferResult.  # noqa: E501

        Offer Request Raw Supplier Boxcribe API Response  # noqa: E501

        :return: The supplier_response of this OfferResult.  # noqa: E501
        :rtype: object
        """
        return self._supplier_response

    @supplier_response.setter
    def supplier_response(self, supplier_response):
        """Sets the supplier_response of this OfferResult.

        Offer Request Raw Supplier Boxcribe API Response  # noqa: E501

        :param supplier_response: The supplier_response of this OfferResult.  # noqa: E501
        :type: object
        """

        self._supplier_response = supplier_response

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
        if issubclass(OfferResult, dict):
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
        if not isinstance(other, OfferResult):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
