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

class CategoriesIdBody(object):
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
        'slug': 'str',
        'icon': 'str',
        'sort': 'int'
    }

    attribute_map = {
        'name': 'name',
        'slug': 'slug',
        'icon': 'icon',
        'sort': 'sort'
    }

    def __init__(self, name=None, slug=None, icon=None, sort=None):  # noqa: E501
        """CategoriesIdBody - a model defined in Swagger"""  # noqa: E501
        self._name = None
        self._slug = None
        self._icon = None
        self._sort = None
        self.discriminator = None
        if name is not None:
            self.name = name
        if slug is not None:
            self.slug = slug
        if icon is not None:
            self.icon = icon
        if sort is not None:
            self.sort = sort

    @property
    def name(self):
        """Gets the name of this CategoriesIdBody.  # noqa: E501


        :return: The name of this CategoriesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this CategoriesIdBody.


        :param name: The name of this CategoriesIdBody.  # noqa: E501
        :type: str
        """

        self._name = name

    @property
    def slug(self):
        """Gets the slug of this CategoriesIdBody.  # noqa: E501


        :return: The slug of this CategoriesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._slug

    @slug.setter
    def slug(self, slug):
        """Sets the slug of this CategoriesIdBody.


        :param slug: The slug of this CategoriesIdBody.  # noqa: E501
        :type: str
        """

        self._slug = slug

    @property
    def icon(self):
        """Gets the icon of this CategoriesIdBody.  # noqa: E501


        :return: The icon of this CategoriesIdBody.  # noqa: E501
        :rtype: str
        """
        return self._icon

    @icon.setter
    def icon(self, icon):
        """Sets the icon of this CategoriesIdBody.


        :param icon: The icon of this CategoriesIdBody.  # noqa: E501
        :type: str
        """

        self._icon = icon

    @property
    def sort(self):
        """Gets the sort of this CategoriesIdBody.  # noqa: E501


        :return: The sort of this CategoriesIdBody.  # noqa: E501
        :rtype: int
        """
        return self._sort

    @sort.setter
    def sort(self, sort):
        """Sets the sort of this CategoriesIdBody.


        :param sort: The sort of this CategoriesIdBody.  # noqa: E501
        :type: int
        """

        self._sort = sort

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
        if issubclass(CategoriesIdBody, dict):
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
        if not isinstance(other, CategoriesIdBody):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other