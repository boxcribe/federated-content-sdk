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

class InlineResponse2007(object):
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
        'results': 'list[Integration]',
        'page': 'int',
        'limit': 'int',
        'total_pages': 'int',
        'total_results': 'int'
    }

    attribute_map = {
        'results': 'results',
        'page': 'page',
        'limit': 'limit',
        'total_pages': 'totalPages',
        'total_results': 'totalResults'
    }

    def __init__(self, results=None, page=None, limit=None, total_pages=None, total_results=None):  # noqa: E501
        """InlineResponse2007 - a model defined in Swagger"""  # noqa: E501
        self._results = None
        self._page = None
        self._limit = None
        self._total_pages = None
        self._total_results = None
        self.discriminator = None
        if results is not None:
            self.results = results
        if page is not None:
            self.page = page
        if limit is not None:
            self.limit = limit
        if total_pages is not None:
            self.total_pages = total_pages
        if total_results is not None:
            self.total_results = total_results

    @property
    def results(self):
        """Gets the results of this InlineResponse2007.  # noqa: E501


        :return: The results of this InlineResponse2007.  # noqa: E501
        :rtype: list[Integration]
        """
        return self._results

    @results.setter
    def results(self, results):
        """Sets the results of this InlineResponse2007.


        :param results: The results of this InlineResponse2007.  # noqa: E501
        :type: list[Integration]
        """

        self._results = results

    @property
    def page(self):
        """Gets the page of this InlineResponse2007.  # noqa: E501


        :return: The page of this InlineResponse2007.  # noqa: E501
        :rtype: int
        """
        return self._page

    @page.setter
    def page(self, page):
        """Sets the page of this InlineResponse2007.


        :param page: The page of this InlineResponse2007.  # noqa: E501
        :type: int
        """

        self._page = page

    @property
    def limit(self):
        """Gets the limit of this InlineResponse2007.  # noqa: E501


        :return: The limit of this InlineResponse2007.  # noqa: E501
        :rtype: int
        """
        return self._limit

    @limit.setter
    def limit(self, limit):
        """Sets the limit of this InlineResponse2007.


        :param limit: The limit of this InlineResponse2007.  # noqa: E501
        :type: int
        """

        self._limit = limit

    @property
    def total_pages(self):
        """Gets the total_pages of this InlineResponse2007.  # noqa: E501


        :return: The total_pages of this InlineResponse2007.  # noqa: E501
        :rtype: int
        """
        return self._total_pages

    @total_pages.setter
    def total_pages(self, total_pages):
        """Sets the total_pages of this InlineResponse2007.


        :param total_pages: The total_pages of this InlineResponse2007.  # noqa: E501
        :type: int
        """

        self._total_pages = total_pages

    @property
    def total_results(self):
        """Gets the total_results of this InlineResponse2007.  # noqa: E501


        :return: The total_results of this InlineResponse2007.  # noqa: E501
        :rtype: int
        """
        return self._total_results

    @total_results.setter
    def total_results(self, total_results):
        """Sets the total_results of this InlineResponse2007.


        :param total_results: The total_results of this InlineResponse2007.  # noqa: E501
        :type: int
        """

        self._total_results = total_results

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
        if issubclass(InlineResponse2007, dict):
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
        if not isinstance(other, InlineResponse2007):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
