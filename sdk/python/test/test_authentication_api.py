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
from swagger_client.api.authentication_api import AuthenticationApi  # noqa: E501
from swagger_client.rest import ApiException


class TestAuthenticationApi(unittest.TestCase):
    """AuthenticationApi unit test stubs"""

    def setUp(self):
        self.api = AuthenticationApi()  # noqa: E501

    def tearDown(self):
        pass

    def test_auth_forgot_password_post(self):
        """Test case for auth_forgot_password_post

        Forgot password  # noqa: E501
        """
        pass

    def test_auth_login_post(self):
        """Test case for auth_login_post

        Login  # noqa: E501
        """
        pass

    def test_auth_logout_post(self):
        """Test case for auth_logout_post

        Logout  # noqa: E501
        """
        pass

    def test_auth_refresh_tokens_post(self):
        """Test case for auth_refresh_tokens_post

        Refresh auth tokens  # noqa: E501
        """
        pass

    def test_auth_register_post(self):
        """Test case for auth_register_post

        Register  # noqa: E501
        """
        pass

    def test_auth_reset_password_post(self):
        """Test case for auth_reset_password_post

        Reset password  # noqa: E501
        """
        pass

    def test_auth_send_verification_email_post(self):
        """Test case for auth_send_verification_email_post

        Send verification email  # noqa: E501
        """
        pass

    def test_auth_verify_email_post(self):
        """Test case for auth_verify_email_post

        verify email  # noqa: E501
        """
        pass


if __name__ == '__main__':
    unittest.main()