# coding: utf-8

"""
    Federated Content API

    Welcome to the Federated Content API following Open API Specification (Version 3.0.0)  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.api.health_check_api import HealthCheckApi  # noqa: E501
from swagger_client.rest import ApiException


class TestHealthCheckApi(unittest.TestCase):
    """HealthCheckApi unit test stubs"""

    def setUp(self):
        self.api = HealthCheckApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_help_get(self):
        """Test case for help_get

        Help  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
