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

class OfferRequest(object):
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
        'tenant_id': 'str',
        'category_id': 'str',
        'offer_request': 'object'
    }

    attribute_map = {
        'id': 'id',
        'tenant_id': 'tenant_id',
        'category_id': 'category_id',
        'offer_request': 'offer_request'
    }

    def __init__(self, id=None, tenant_id=None, category_id=None, offer_request=None):  # noqa: E501
        """OfferRequest - a model defined in Swagger"""  # noqa: E501
        self._id = None
        self._tenant_id = None
        self._category_id = None
        self._offer_request = None
        self.discriminator = None
        if id is not None:
            self.id = id
        if tenant_id is not None:
            self.tenant_id = tenant_id
        if category_id is not None:
            self.category_id = category_id
        if offer_request is not None:
            self.offer_request = offer_request

    @property
    def id(self):
        """Gets the id of this OfferRequest.  # noqa: E501


        :return: The id of this OfferRequest.  # noqa: E501
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this OfferRequest.


        :param id: The id of this OfferRequest.  # noqa: E501
        :type: str
        """

        self._id = id

    @property
    def tenant_id(self):
        """Gets the tenant_id of this OfferRequest.  # noqa: E501


        :return: The tenant_id of this OfferRequest.  # noqa: E501
        :rtype: str
        """
        return self._tenant_id

    @tenant_id.setter
    def tenant_id(self, tenant_id):
        """Sets the tenant_id of this OfferRequest.


        :param tenant_id: The tenant_id of this OfferRequest.  # noqa: E501
        :type: str
        """

        self._tenant_id = tenant_id

    @property
    def category_id(self):
        """Gets the category_id of this OfferRequest.  # noqa: E501


        :return: The category_id of this OfferRequest.  # noqa: E501
        :rtype: str
        """
        return self._category_id

    @category_id.setter
    def category_id(self, category_id):
        """Sets the category_id of this OfferRequest.


        :param category_id: The category_id of this OfferRequest.  # noqa: E501
        :type: str
        """

        self._category_id = category_id

    @property
    def offer_request(self):
        """Gets the offer_request of this OfferRequest.  # noqa: E501

        Offer Requests Fields For This Category  # noqa: E501

        :return: The offer_request of this OfferRequest.  # noqa: E501
        :rtype: object
        """
        return self._offer_request

    @offer_request.setter
    def offer_request(self, offer_request):
        """Sets the offer_request of this OfferRequest.

        Offer Requests Fields For This Category  # noqa: E501

        :param offer_request: The offer_request of this OfferRequest.  # noqa: E501
        :type: object
        """

        self._offer_request = offer_request

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
        if issubclass(OfferRequest, dict):
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
        if not isinstance(other, OfferRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
