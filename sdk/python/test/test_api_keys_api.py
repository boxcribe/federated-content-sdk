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
from swagger_client.api.api_keys_api import ApiKeysApi  # noqa: E501
from swagger_client.rest import ApiException


class TestApiKeysApi(unittest.TestCase):
    """ApiKeysApi unit test stubs"""

    def setUp(self):
        self.api = ApiKeysApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_apikeys_get(self):
        """Test case for apikeys_get

        Get api keys  # noqa: E501
        """
        pass

    def test_apikeys_id_delete(self):
        """Test case for apikeys_id_delete

        Delete api key  # noqa: E501
        """
        pass

    def test_apikeys_id_get(self):
        """Test case for apikeys_id_get

        Get api key  # noqa: E501
        """
        pass

    def test_apikeys_id_patch(self):
        """Test case for apikeys_id_patch

        Update api key  # noqa: E501
        """
        pass

    def test_apikeys_post(self):
        """Test case for apikeys_post

        Create api key  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()