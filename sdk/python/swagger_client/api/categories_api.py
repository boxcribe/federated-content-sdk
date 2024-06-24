# coding: utf-8

"""
    Federated Content API

    Welcome to the Federated Content API following Open API Specification (Version 3.0.0)  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import re  # noqa: F401

# python 2 and python 3 compatibility library
import six

from swagger_client.api_client import ApiClient


class CategoriesApi(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def categories_get(self, **kwargs):  # noqa: E501
        """Get categories  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.categories_get(async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str sort: sort by query in the form of field:desc/asc (ex. name:asc)
        :param int limit: Maximum number of categories
        :param int page: Page number
        :return: InlineResponse2004
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.categories_get_with_http_info(**kwargs)  # noqa: E501
        else:
            (data) = self.categories_get_with_http_info(**kwargs)  # noqa: E501
            return data

    def categories_get_with_http_info(self, **kwargs):  # noqa: E501
        """Get categories  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.categories_get_with_http_info(async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str sort: sort by query in the form of field:desc/asc (ex. name:asc)
        :param int limit: Maximum number of categories
        :param int page: Page number
        :return: InlineResponse2004
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['sort', 'limit', 'page']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method categories_get" % key
                )
            params[key] = val
        del params['kwargs']

        collection_formats = {}

        path_params = {}

        query_params = []
        if 'sort' in params:
            query_params.append(('sort', params['sort']))  # noqa: E501
        if 'limit' in params:
            query_params.append(('limit', params['limit']))  # noqa: E501
        if 'page' in params:
            query_params.append(('page', params['page']))  # noqa: E501

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/categories', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='InlineResponse2004',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def categories_id_delete(self, id, **kwargs):  # noqa: E501
        """Delete category  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.categories_id_delete(id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str id: Category id (required)
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.categories_id_delete_with_http_info(id, **kwargs)  # noqa: E501
        else:
            (data) = self.categories_id_delete_with_http_info(id, **kwargs)  # noqa: E501
            return data

    def categories_id_delete_with_http_info(self, id, **kwargs):  # noqa: E501
        """Delete category  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.categories_id_delete_with_http_info(id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str id: Category id (required)
        :return: None
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method categories_id_delete" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'id' is set
        if ('id' not in params or
                params['id'] is None):
            raise ValueError("Missing the required parameter `id` when calling `categories_id_delete`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'id' in params:
            path_params['id'] = params['id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/categories/{id}', 'DELETE',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type=None,  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def categories_id_get(self, id, **kwargs):  # noqa: E501
        """Get category  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.categories_id_get(id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str id: Category id (required)
        :return: Category
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.categories_id_get_with_http_info(id, **kwargs)  # noqa: E501
        else:
            (data) = self.categories_id_get_with_http_info(id, **kwargs)  # noqa: E501
            return data

    def categories_id_get_with_http_info(self, id, **kwargs):  # noqa: E501
        """Get category  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.categories_id_get_with_http_info(id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str id: Category id (required)
        :return: Category
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method categories_id_get" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'id' is set
        if ('id' not in params or
                params['id'] is None):
            raise ValueError("Missing the required parameter `id` when calling `categories_id_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'id' in params:
            path_params['id'] = params['id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/categories/{id}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Category',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def categories_id_patch(self, body, id, **kwargs):  # noqa: E501
        """Update category  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.categories_id_patch(body, id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CategoriesIdBody body: (required)
        :param str id: Category id (required)
        :return: Category
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.categories_id_patch_with_http_info(body, id, **kwargs)  # noqa: E501
        else:
            (data) = self.categories_id_patch_with_http_info(body, id, **kwargs)  # noqa: E501
            return data

    def categories_id_patch_with_http_info(self, body, id, **kwargs):  # noqa: E501
        """Update category  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.categories_id_patch_with_http_info(body, id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CategoriesIdBody body: (required)
        :param str id: Category id (required)
        :return: Category
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['body', 'id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method categories_id_patch" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'body' is set
        if ('body' not in params or
                params['body'] is None):
            raise ValueError("Missing the required parameter `body` when calling `categories_id_patch`")  # noqa: E501
        # verify the required parameter 'id' is set
        if ('id' not in params or
                params['id'] is None):
            raise ValueError("Missing the required parameter `id` when calling `categories_id_patch`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'id' in params:
            path_params['id'] = params['id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'body' in params:
            body_params = params['body']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.select_header_content_type(  # noqa: E501
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/categories/{id}', 'PATCH',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Category',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def categories_post(self, body, **kwargs):  # noqa: E501
        """Create category  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.categories_post(body, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CategoriesBody body: (required)
        :return: Category
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.categories_post_with_http_info(body, **kwargs)  # noqa: E501
        else:
            (data) = self.categories_post_with_http_info(body, **kwargs)  # noqa: E501
            return data

    def categories_post_with_http_info(self, body, **kwargs):  # noqa: E501
        """Create category  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.categories_post_with_http_info(body, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CategoriesBody body: (required)
        :return: Category
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['body']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method categories_post" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'body' is set
        if ('body' not in params or
                params['body'] is None):
            raise ValueError("Missing the required parameter `body` when calling `categories_post`")  # noqa: E501

        collection_formats = {}

        path_params = {}

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        if 'body' in params:
            body_params = params['body']
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # HTTP header `Content-Type`
        header_params['Content-Type'] = self.api_client.select_header_content_type(  # noqa: E501
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['bearerAuth']  # noqa: E501

        return self.api_client.call_api(
            '/categories', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='Category',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)
