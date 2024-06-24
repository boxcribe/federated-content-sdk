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
from swagger_client.api.schemas_api import SchemasApi  # noqa: E501
from swagger_client.rest import ApiException


class TestSchemasApi(unittest.TestCase):
    """SchemasApi unit test stubs"""

    def setUp(self):
        self.api = SchemasApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_schemas_get(self):
        """Test case for schemas_get

        Get schemas  # noqa: E501
        """
        pass

    def test_schemas_grouped_by_endpoint_get(self):
        """Test case for schemas_grouped_by_endpoint_get

        Get schemas grouped by endpoint  # noqa: E501
        """
        pass

    def test_schemas_id_delete(self):
        """Test case for schemas_id_delete

        Delete schema  # noqa: E501
        """
        pass

    def test_schemas_id_get(self):
        """Test case for schemas_id_get

        Get schema  # noqa: E501
        """
        pass

    def test_schemas_id_patch(self):
        """Test case for schemas_id_patch

        Update schema  # noqa: E501
        """
        pass

    def test_schemas_post(self):
        """Test case for schemas_post

        Create schema  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()