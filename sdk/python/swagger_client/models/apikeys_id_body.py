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

class ApikeysIdBody(object):
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
        'tenant_id': 'str',
        'name': 'str',
        'status': 'str',
        'usage_limit': 'float',
        'env_name': 'str'
    }

    attribute_map = {
        'tenant_id': 'tenant_id',
        'name': 'name',
        'status': 'status',
        'usage_limit': 'usage_limit',
        'env_name': 'env_name'
    }

    def __init__(self, tenant_id=None, name=None, status=None, usage_limit=None, env_name=None):  # noqa: E501
        """ApikeysIdBody - a model defined in Swagger"""  # noqa: E501
        self._tenant_id = None
        self._name = None
        self._status = None
        self._usage_limit = None
        self._env_name = None
        self.discriminator = None
        if tenant_id is not None:
            self.tenant_id = tenant_id
        if name is not None:
            self.name = name
        if status is not None:
            self.status = status
        if usage_limit is not None:
            self.usage_limit = usage_limit
        if env_name is not None:
            self.env_name = env_name

    @property
    def tenant_id(self):
        """Gets the tenant_id of this ApikeysIdBody.  # noqa: E501


        :return: The tenant_id of this ApikeysIdBody.  # noqa: E501
        :rtype: str
        """
        return self._tenant_id

    @tenant_id.setter
    def tenant_id(self, tenant_id):
        """Sets the tenant_id of this ApikeysIdBody.


        :param tenant_id: The tenant_id of this ApikeysIdBody.  # noqa: E501
        :type: str
        """

        self._tenant_id = tenant_id

    @property
    def name(self):
        """Gets the name of this ApikeysIdBody.  # noqa: E501


        :return: The name of this ApikeysIdBody.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this ApikeysIdBody.


        :param name: The name of this ApikeysIdBody.  # noqa: E501
        :type: str
        """

        self._name = name

    @property
    def status(self):
        """Gets the status of this ApikeysIdBody.  # noqa: E501


        :return: The status of this ApikeysIdBody.  # noqa: E501
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this ApikeysIdBody.


        :param status: The status of this ApikeysIdBody.  # noqa: E501
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
    def usage_limit(self):
        """Gets the usage_limit of this ApikeysIdBody.  # noqa: E501


        :return: The usage_limit of this ApikeysIdBody.  # noqa: E501
        :rtype: float
        """
        return self._usage_limit

    @usage_limit.setter
    def usage_limit(self, usage_limit):
        """Sets the usage_limit of this ApikeysIdBody.


        :param usage_limit: The usage_limit of this ApikeysIdBody.  # noqa: E501
        :type: float
        """

        self._usage_limit = usage_limit

    @property
    def env_name(self):
        """Gets the env_name of this ApikeysIdBody.  # noqa: E501


        :return: The env_name of this ApikeysIdBody.  # noqa: E501
        :rtype: str
        """
        return self._env_name

    @env_name.setter
    def env_name(self, env_name):
        """Sets the env_name of this ApikeysIdBody.


        :param env_name: The env_name of this ApikeysIdBody.  # noqa: E501
        :type: str
        """
        allowed_values = ["Production", "Sandbox"]  # noqa: E501
        if env_name not in allowed_values:
            raise ValueError(
                "Invalid value for `env_name` ({0}), must be one of {1}"  # noqa: E501
                .format(env_name, allowed_values)
            )

        self._env_name = env_name

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
        if issubclass(ApikeysIdBody, dict):
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
        if not isinstance(other, ApikeysIdBody):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
