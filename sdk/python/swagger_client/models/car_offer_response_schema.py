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

class CarOfferResponseSchema(object):
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
        'offers': 'list[CarOfferResponseItemSchema]',
        'page': 'int',
        'limit': 'int',
        'total': 'int'
    }

    attribute_map = {
        'company_id': 'company_id',
        'tenant_id': 'tenant_id',
        'category_id': 'category_id',
        'supplier_id': 'supplier_id',
        'offers': 'offers',
        'page': 'page',
        'limit': 'limit',
        'total': 'total'
    }

    def __init__(self, company_id=None, tenant_id=None, category_id=None, supplier_id=None, offers=None, page=None, limit=None, total=None):  # noqa: E501
        """CarOfferResponseSchema - a model defined in Swagger"""  # noqa: E501
        self._company_id = None
        self._tenant_id = None
        self._category_id = None
        self._supplier_id = None
        self._offers = None
        self._page = None
        self._limit = None
        self._total = None
        self.discriminator = None
        if company_id is not None:
            self.company_id = company_id
        if tenant_id is not None:
            self.tenant_id = tenant_id
        if category_id is not None:
            self.category_id = category_id
        if supplier_id is not None:
            self.supplier_id = supplier_id
        if offers is not None:
            self.offers = offers
        if page is not None:
            self.page = page
        if limit is not None:
            self.limit = limit
        if total is not None:
            self.total = total

    @property
    def company_id(self):
        """Gets the company_id of this CarOfferResponseSchema.  # noqa: E501

        Identifier for the company offering the rental.  # noqa: E501

        :return: The company_id of this CarOfferResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._company_id

    @company_id.setter
    def company_id(self, company_id):
        """Sets the company_id of this CarOfferResponseSchema.

        Identifier for the company offering the rental.  # noqa: E501

        :param company_id: The company_id of this CarOfferResponseSchema.  # noqa: E501
        :type: str
        """

        self._company_id = company_id

    @property
    def tenant_id(self):
        """Gets the tenant_id of this CarOfferResponseSchema.  # noqa: E501

        Identifier for the tenant.  # noqa: E501

        :return: The tenant_id of this CarOfferResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._tenant_id

    @tenant_id.setter
    def tenant_id(self, tenant_id):
        """Sets the tenant_id of this CarOfferResponseSchema.

        Identifier for the tenant.  # noqa: E501

        :param tenant_id: The tenant_id of this CarOfferResponseSchema.  # noqa: E501
        :type: str
        """

        self._tenant_id = tenant_id

    @property
    def category_id(self):
        """Gets the category_id of this CarOfferResponseSchema.  # noqa: E501

        Identifier for the category of the offer.  # noqa: E501

        :return: The category_id of this CarOfferResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._category_id

    @category_id.setter
    def category_id(self, category_id):
        """Sets the category_id of this CarOfferResponseSchema.

        Identifier for the category of the offer.  # noqa: E501

        :param category_id: The category_id of this CarOfferResponseSchema.  # noqa: E501
        :type: str
        """

        self._category_id = category_id

    @property
    def supplier_id(self):
        """Gets the supplier_id of this CarOfferResponseSchema.  # noqa: E501

        Identifier for the supplier of the offer.  # noqa: E501

        :return: The supplier_id of this CarOfferResponseSchema.  # noqa: E501
        :rtype: str
        """
        return self._supplier_id

    @supplier_id.setter
    def supplier_id(self, supplier_id):
        """Sets the supplier_id of this CarOfferResponseSchema.

        Identifier for the supplier of the offer.  # noqa: E501

        :param supplier_id: The supplier_id of this CarOfferResponseSchema.  # noqa: E501
        :type: str
        """

        self._supplier_id = supplier_id

    @property
    def offers(self):
        """Gets the offers of this CarOfferResponseSchema.  # noqa: E501

        Array of CarOfferResponseItemSchema detailing individual car offers.  # noqa: E501

        :return: The offers of this CarOfferResponseSchema.  # noqa: E501
        :rtype: list[CarOfferResponseItemSchema]
        """
        return self._offers

    @offers.setter
    def offers(self, offers):
        """Sets the offers of this CarOfferResponseSchema.

        Array of CarOfferResponseItemSchema detailing individual car offers.  # noqa: E501

        :param offers: The offers of this CarOfferResponseSchema.  # noqa: E501
        :type: list[CarOfferResponseItemSchema]
        """

        self._offers = offers

    @property
    def page(self):
        """Gets the page of this CarOfferResponseSchema.  # noqa: E501

        Current page in pagination.  # noqa: E501

        :return: The page of this CarOfferResponseSchema.  # noqa: E501
        :rtype: int
        """
        return self._page

    @page.setter
    def page(self, page):
        """Sets the page of this CarOfferResponseSchema.

        Current page in pagination.  # noqa: E501

        :param page: The page of this CarOfferResponseSchema.  # noqa: E501
        :type: int
        """

        self._page = page

    @property
    def limit(self):
        """Gets the limit of this CarOfferResponseSchema.  # noqa: E501

        Page size in pagination.  # noqa: E501

        :return: The limit of this CarOfferResponseSchema.  # noqa: E501
        :rtype: int
        """
        return self._limit

    @limit.setter
    def limit(self, limit):
        """Sets the limit of this CarOfferResponseSchema.

        Page size in pagination.  # noqa: E501

        :param limit: The limit of this CarOfferResponseSchema.  # noqa: E501
        :type: int
        """

        self._limit = limit

    @property
    def total(self):
        """Gets the total of this CarOfferResponseSchema.  # noqa: E501

        Total number of records available.  # noqa: E501

        :return: The total of this CarOfferResponseSchema.  # noqa: E501
        :rtype: int
        """
        return self._total

    @total.setter
    def total(self, total):
        """Sets the total of this CarOfferResponseSchema.

        Total number of records available.  # noqa: E501

        :param total: The total of this CarOfferResponseSchema.  # noqa: E501
        :type: int
        """

        self._total = total

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
        if issubclass(CarOfferResponseSchema, dict):
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
        if not isinstance(other, CarOfferResponseSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
