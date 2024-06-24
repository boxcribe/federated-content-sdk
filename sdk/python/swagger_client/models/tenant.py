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

class Tenant(object):
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
        'company_id': 'str',
        'name': 'str',
        'status': 'str'
    }

    attribute_map = {
        'id': 'id',
        'company_id': 'company_id',
        'name': 'name',
        'status': 'status'
    }

    def __init__(self, id=None, company_id=None, name=None, status='Active'):  # noqa: E501
        """Tenant - a model defined in Swagger"""  # noqa: E501
        self._id = None
        self._company_id = None
        self._name = None
        self._status = None
        self.discriminator = None
        if id is not None:
            self.id = id
        if company_id is not None:
            self.company_id = company_id
        if name is not None:
            self.name = name
        if status is not None:
            self.status = status

    @property
    def id(self):
        """Gets the id of this Tenant.  # noqa: E501


        :return: The id of this Tenant.  # noqa: E501
        :rtype: str
        """
        return self._id

    @id.setter
    def id(self, id):
        """Sets the id of this Tenant.


        :param id: The id of this Tenant.  # noqa: E501
        :type: str
        """

        self._id = id

    @property
    def company_id(self):
        """Gets the company_id of this Tenant.  # noqa: E501


        :return: The company_id of this Tenant.  # noqa: E501
        :rtype: str
        """
        return self._company_id

    @company_id.setter
    def company_id(self, company_id):
        """Sets the company_id of this Tenant.


        :param company_id: The company_id of this Tenant.  # noqa: E501
        :type: str
        """

        self._company_id = company_id

    @property
    def name(self):
        """Gets the name of this Tenant.  # noqa: E501


        :return: The name of this Tenant.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this Tenant.


        :param name: The name of this Tenant.  # noqa: E501
        :type: str
        """

        self._name = name

    @property
    def status(self):
        """Gets the status of this Tenant.  # noqa: E501


        :return: The status of this Tenant.  # noqa: E501
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this Tenant.


        :param status: The status of this Tenant.  # noqa: E501
        :type: str
        """
        allowed_values = ["Active", "Inactive"]  # noqa: E501
        if status not in allowed_values:
            raise ValueError(
                "Invalid value for `status` ({0}), must be one of {1}"  # noqa: E501
                .format(status, allowed_values)
            )

        self._status = status

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
        if issubclass(Tenant, dict):
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
        if not isinstance(other, Tenant):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
