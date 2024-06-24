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

class IntegrationsIdBody(object):
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
        'category_id': 'str',
        'name': 'str',
        'type': 'str',
        'slug': 'str',
        'logo': 'str',
        'status': 'str',
        'credentials_production': 'IntegrationsCredentialsProduction',
        'credentials_sandbox': 'IntegrationsCredentialsProduction',
        'env_production': 'str',
        'env_sandbox': 'str',
        'settings_production': 'IntegrationsSettingsProduction',
        'settings_sandbox': 'IntegrationsSettingsProduction'
    }

    attribute_map = {
        'tenant_id': 'tenant_id',
        'category_id': 'category_id',
        'name': 'name',
        'type': 'type',
        'slug': 'slug',
        'logo': 'logo',
        'status': 'status',
        'credentials_production': 'credentials_production',
        'credentials_sandbox': 'credentials_sandbox',
        'env_production': 'env_production',
        'env_sandbox': 'env_sandbox',
        'settings_production': 'settings_production',
        'settings_sandbox': 'settings_sandbox'
    }

    def __init__(self, tenant_id=None, category_id=None, name=None, type=None, slug=None, logo=None, status=None, credentials_production=None, credentials_sandbox=None, env_production=None, env_sandbox=None, settings_production=None, settings_sandbox=None):  # noqa: E501
        """IntegrationsIdBody - a model defined in Swagger"""  # noqa: E501
        self._tenant_id = None
        self._category_id = None
        self._name = None
        self._type = None
        self._slug = None
        self._logo = None
        self._status = None
        self._credentials_production = None
        self._credentials_sandbox = None
        self._env_production = None
        self._env_sandbox = None
        self._settings_production = None
        self._settings_sandbox = None
        self.discriminator = None
        if tenant_id is not None:
            self.tenant_id = tenant_id
        if category_id is not None:
            self.category_id = category_id
        if name is not None:
            self.name = name
        if type is not None:
            self.type = type
        if slug is not None:
            self.slug = slug
        if logo is not None:
            self.logo = logo
        if status is not None:
            self.status = status
        if credentials_production is not None:
            self.credentials_production = credentials_production
        if credentials_sandbox is not None:
            self.credentials_sandbox = credentials_sandbox
        if env_production is not None:
            self.env_production = env_production
        if env_sandbox is not None:
            self.env_sandbox = env_sandbox
        if settings_production is not None:
            self.settings_production = settings_production
        if settings_sandbox is not None:
            self.settings_sandbox = settings_sandbox

    @property
    def tenant_id(self):
        """Gets the tenant_id of this IntegrationsIdBody.  # noqa: E501


        :return: The tenant_id of this IntegrationsIdBody.  # noqa: E501
        :rtype: str
        """
        return self._tenant_id

    @tenant_id.setter
    def tenant_id(self, tenant_id):
        """Sets the tenant_id of this IntegrationsIdBody.


        :param tenant_id: The tenant_id of this IntegrationsIdBody.  # noqa: E501
        :type: str
        """

        self._tenant_id = tenant_id

    @property
    def category_id(self):
        """Gets the category_id of this IntegrationsIdBody.  # noqa: E501


        :return: The category_id of this IntegrationsIdBody.  # noqa: E501
        :rtype: str
        """
        return self._category_id

    @category_id.setter
    def category_id(self, category_id):
        """Sets the category_id of this IntegrationsIdBody.


        :param category_id: The category_id of this IntegrationsIdBody.  # noqa: E501
        :type: str
        """

        self._category_id = category_id

    @property
    def name(self):
        """Gets the name of this IntegrationsIdBody.  # noqa: E501


        :return: The name of this IntegrationsIdBody.  # noqa: E501
        :rtype: str
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this IntegrationsIdBody.


        :param name: The name of this IntegrationsIdBody.  # noqa: E501
        :type: str
        """

        self._name = name

    @property
    def type(self):
        """Gets the type of this IntegrationsIdBody.  # noqa: E501


        :return: The type of this IntegrationsIdBody.  # noqa: E501
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this IntegrationsIdBody.


        :param type: The type of this IntegrationsIdBody.  # noqa: E501
        :type: str
        """

        self._type = type

    @property
    def slug(self):
        """Gets the slug of this IntegrationsIdBody.  # noqa: E501


        :return: The slug of this IntegrationsIdBody.  # noqa: E501
        :rtype: str
        """
        return self._slug

    @slug.setter
    def slug(self, slug):
        """Sets the slug of this IntegrationsIdBody.


        :param slug: The slug of this IntegrationsIdBody.  # noqa: E501
        :type: str
        """

        self._slug = slug

    @property
    def logo(self):
        """Gets the logo of this IntegrationsIdBody.  # noqa: E501


        :return: The logo of this IntegrationsIdBody.  # noqa: E501
        :rtype: str
        """
        return self._logo

    @logo.setter
    def logo(self, logo):
        """Sets the logo of this IntegrationsIdBody.


        :param logo: The logo of this IntegrationsIdBody.  # noqa: E501
        :type: str
        """

        self._logo = logo

    @property
    def status(self):
        """Gets the status of this IntegrationsIdBody.  # noqa: E501


        :return: The status of this IntegrationsIdBody.  # noqa: E501
        :rtype: str
        """
        return self._status

    @status.setter
    def status(self, status):
        """Sets the status of this IntegrationsIdBody.


        :param status: The status of this IntegrationsIdBody.  # noqa: E501
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
    def credentials_production(self):
        """Gets the credentials_production of this IntegrationsIdBody.  # noqa: E501


        :return: The credentials_production of this IntegrationsIdBody.  # noqa: E501
        :rtype: IntegrationsCredentialsProduction
        """
        return self._credentials_production

    @credentials_production.setter
    def credentials_production(self, credentials_production):
        """Sets the credentials_production of this IntegrationsIdBody.


        :param credentials_production: The credentials_production of this IntegrationsIdBody.  # noqa: E501
        :type: IntegrationsCredentialsProduction
        """

        self._credentials_production = credentials_production

    @property
    def credentials_sandbox(self):
        """Gets the credentials_sandbox of this IntegrationsIdBody.  # noqa: E501


        :return: The credentials_sandbox of this IntegrationsIdBody.  # noqa: E501
        :rtype: IntegrationsCredentialsProduction
        """
        return self._credentials_sandbox

    @credentials_sandbox.setter
    def credentials_sandbox(self, credentials_sandbox):
        """Sets the credentials_sandbox of this IntegrationsIdBody.


        :param credentials_sandbox: The credentials_sandbox of this IntegrationsIdBody.  # noqa: E501
        :type: IntegrationsCredentialsProduction
        """

        self._credentials_sandbox = credentials_sandbox

    @property
    def env_production(self):
        """Gets the env_production of this IntegrationsIdBody.  # noqa: E501


        :return: The env_production of this IntegrationsIdBody.  # noqa: E501
        :rtype: str
        """
        return self._env_production

    @env_production.setter
    def env_production(self, env_production):
        """Sets the env_production of this IntegrationsIdBody.


        :param env_production: The env_production of this IntegrationsIdBody.  # noqa: E501
        :type: str
        """

        self._env_production = env_production

    @property
    def env_sandbox(self):
        """Gets the env_sandbox of this IntegrationsIdBody.  # noqa: E501


        :return: The env_sandbox of this IntegrationsIdBody.  # noqa: E501
        :rtype: str
        """
        return self._env_sandbox

    @env_sandbox.setter
    def env_sandbox(self, env_sandbox):
        """Sets the env_sandbox of this IntegrationsIdBody.


        :param env_sandbox: The env_sandbox of this IntegrationsIdBody.  # noqa: E501
        :type: str
        """

        self._env_sandbox = env_sandbox

    @property
    def settings_production(self):
        """Gets the settings_production of this IntegrationsIdBody.  # noqa: E501


        :return: The settings_production of this IntegrationsIdBody.  # noqa: E501
        :rtype: IntegrationsSettingsProduction
        """
        return self._settings_production

    @settings_production.setter
    def settings_production(self, settings_production):
        """Sets the settings_production of this IntegrationsIdBody.


        :param settings_production: The settings_production of this IntegrationsIdBody.  # noqa: E501
        :type: IntegrationsSettingsProduction
        """

        self._settings_production = settings_production

    @property
    def settings_sandbox(self):
        """Gets the settings_sandbox of this IntegrationsIdBody.  # noqa: E501


        :return: The settings_sandbox of this IntegrationsIdBody.  # noqa: E501
        :rtype: IntegrationsSettingsProduction
        """
        return self._settings_sandbox

    @settings_sandbox.setter
    def settings_sandbox(self, settings_sandbox):
        """Sets the settings_sandbox of this IntegrationsIdBody.


        :param settings_sandbox: The settings_sandbox of this IntegrationsIdBody.  # noqa: E501
        :type: IntegrationsSettingsProduction
        """

        self._settings_sandbox = settings_sandbox

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
        if issubclass(IntegrationsIdBody, dict):
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
        if not isinstance(other, IntegrationsIdBody):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other