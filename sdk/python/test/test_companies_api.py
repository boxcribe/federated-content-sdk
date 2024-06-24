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
from swagger_client.api.companies_api import CompaniesApi  # noqa: E501
from swagger_client.rest import ApiException


class TestCompaniesApi(unittest.TestCase):
    """CompaniesApi unit test stubs"""

    def setUp(self):
        self.api = CompaniesApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_companies_get(self):
        """Test case for companies_get

        Get companies  # noqa: E501
        """
        pass

    def test_companies_id_delete(self):
        """Test case for companies_id_delete

        Delete company  # noqa: E501
        """
        pass

    def test_companies_id_get(self):
        """Test case for companies_id_get

        Get company  # noqa: E501
        """
        pass

    def test_companies_id_patch(self):
        """Test case for companies_id_patch

        Update company  # noqa: E501
        """
        pass

    def test_companies_post(self):
        """Test case for companies_post

        Create company  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()
