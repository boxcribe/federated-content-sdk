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


class CarsApi(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    Ref: https://github.com/swagger-api/swagger-codegen
    """

    def __init__(self, api_client=None):
        if api_client is None:
            api_client = ApiClient()
        self.api_client = api_client

    def cars_bookings_booking_id_cancel_post(self, body, booking_id, **kwargs):  # noqa: E501
        """Cancel Booking  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_bookings_booking_id_cancel_post(body, booking_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CarCancelBookingRequestSchema body: (required)
        :param str booking_id: (required)
        :return: CarCancelBookingResponseSchema
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.cars_bookings_booking_id_cancel_post_with_http_info(body, booking_id, **kwargs)  # noqa: E501
        else:
            (data) = self.cars_bookings_booking_id_cancel_post_with_http_info(body, booking_id, **kwargs)  # noqa: E501
            return data

    def cars_bookings_booking_id_cancel_post_with_http_info(self, body, booking_id, **kwargs):  # noqa: E501
        """Cancel Booking  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_bookings_booking_id_cancel_post_with_http_info(body, booking_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CarCancelBookingRequestSchema body: (required)
        :param str booking_id: (required)
        :return: CarCancelBookingResponseSchema
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['body', 'booking_id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method cars_bookings_booking_id_cancel_post" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'body' is set
        if ('body' not in params or
                params['body'] is None):
            raise ValueError("Missing the required parameter `body` when calling `cars_bookings_booking_id_cancel_post`")  # noqa: E501
        # verify the required parameter 'booking_id' is set
        if ('booking_id' not in params or
                params['booking_id'] is None):
            raise ValueError("Missing the required parameter `booking_id` when calling `cars_bookings_booking_id_cancel_post`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'booking_id' in params:
            path_params['bookingId'] = params['booking_id']  # noqa: E501

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
        auth_settings = ['apiKeyAuth']  # noqa: E501

        return self.api_client.call_api(
            '/cars/bookings/{bookingId}/cancel', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='CarCancelBookingResponseSchema',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def cars_bookings_booking_id_get(self, booking_id, **kwargs):  # noqa: E501
        """Get Booking Details  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_bookings_booking_id_get(booking_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str booking_id: (required)
        :return: CarBookingDetailsResponseSchema
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.cars_bookings_booking_id_get_with_http_info(booking_id, **kwargs)  # noqa: E501
        else:
            (data) = self.cars_bookings_booking_id_get_with_http_info(booking_id, **kwargs)  # noqa: E501
            return data

    def cars_bookings_booking_id_get_with_http_info(self, booking_id, **kwargs):  # noqa: E501
        """Get Booking Details  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_bookings_booking_id_get_with_http_info(booking_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str booking_id: (required)
        :return: CarBookingDetailsResponseSchema
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['booking_id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method cars_bookings_booking_id_get" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'booking_id' is set
        if ('booking_id' not in params or
                params['booking_id'] is None):
            raise ValueError("Missing the required parameter `booking_id` when calling `cars_bookings_booking_id_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'booking_id' in params:
            path_params['bookingId'] = params['booking_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['apiKeyAuth']  # noqa: E501

        return self.api_client.call_api(
            '/cars/bookings/{bookingId}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='CarBookingDetailsResponseSchema',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def cars_bookings_post(self, body, **kwargs):  # noqa: E501
        """Create Booking  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_bookings_post(body, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CarCreateBookingRequestSchema body: (required)
        :return: CarBookingResponseSchema
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.cars_bookings_post_with_http_info(body, **kwargs)  # noqa: E501
        else:
            (data) = self.cars_bookings_post_with_http_info(body, **kwargs)  # noqa: E501
            return data

    def cars_bookings_post_with_http_info(self, body, **kwargs):  # noqa: E501
        """Create Booking  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_bookings_post_with_http_info(body, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CarCreateBookingRequestSchema body: (required)
        :return: CarBookingResponseSchema
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
                    " to method cars_bookings_post" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'body' is set
        if ('body' not in params or
                params['body'] is None):
            raise ValueError("Missing the required parameter `body` when calling `cars_bookings_post`")  # noqa: E501

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
        auth_settings = ['apiKeyAuth']  # noqa: E501

        return self.api_client.call_api(
            '/cars/bookings', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='CarBookingResponseSchema',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def cars_offer_availability_offer_id_get(self, body, offer_id, **kwargs):  # noqa: E501
        """Get Offer Availability  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_offer_availability_offer_id_get(body, offer_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CarGetOfferAvailabilityRequest body: (required)
        :param str offer_id: (required)
        :return: CarGetOfferAvailabilityResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.cars_offer_availability_offer_id_get_with_http_info(body, offer_id, **kwargs)  # noqa: E501
        else:
            (data) = self.cars_offer_availability_offer_id_get_with_http_info(body, offer_id, **kwargs)  # noqa: E501
            return data

    def cars_offer_availability_offer_id_get_with_http_info(self, body, offer_id, **kwargs):  # noqa: E501
        """Get Offer Availability  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_offer_availability_offer_id_get_with_http_info(body, offer_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CarGetOfferAvailabilityRequest body: (required)
        :param str offer_id: (required)
        :return: CarGetOfferAvailabilityResponse
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['body', 'offer_id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method cars_offer_availability_offer_id_get" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'body' is set
        if ('body' not in params or
                params['body'] is None):
            raise ValueError("Missing the required parameter `body` when calling `cars_offer_availability_offer_id_get`")  # noqa: E501
        # verify the required parameter 'offer_id' is set
        if ('offer_id' not in params or
                params['offer_id'] is None):
            raise ValueError("Missing the required parameter `offer_id` when calling `cars_offer_availability_offer_id_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'offer_id' in params:
            path_params['offerId'] = params['offer_id']  # noqa: E501

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
        auth_settings = ['apiKeyAuth']  # noqa: E501

        return self.api_client.call_api(
            '/cars/offer_availability/{offerId}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='CarGetOfferAvailabilityResponse',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def cars_offers_offer_id_get(self, offer_id, **kwargs):  # noqa: E501
        """Get Offer Details  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_offers_offer_id_get(offer_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str offer_id: (required)
        :return: CarOfferDetailsSchema
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.cars_offers_offer_id_get_with_http_info(offer_id, **kwargs)  # noqa: E501
        else:
            (data) = self.cars_offers_offer_id_get_with_http_info(offer_id, **kwargs)  # noqa: E501
            return data

    def cars_offers_offer_id_get_with_http_info(self, offer_id, **kwargs):  # noqa: E501
        """Get Offer Details  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_offers_offer_id_get_with_http_info(offer_id, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param str offer_id: (required)
        :return: CarOfferDetailsSchema
                 If the method is called asynchronously,
                 returns the request thread.
        """

        all_params = ['offer_id']  # noqa: E501
        all_params.append('async_req')
        all_params.append('_return_http_data_only')
        all_params.append('_preload_content')
        all_params.append('_request_timeout')

        params = locals()
        for key, val in six.iteritems(params['kwargs']):
            if key not in all_params:
                raise TypeError(
                    "Got an unexpected keyword argument '%s'"
                    " to method cars_offers_offer_id_get" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'offer_id' is set
        if ('offer_id' not in params or
                params['offer_id'] is None):
            raise ValueError("Missing the required parameter `offer_id` when calling `cars_offers_offer_id_get`")  # noqa: E501

        collection_formats = {}

        path_params = {}
        if 'offer_id' in params:
            path_params['offerId'] = params['offer_id']  # noqa: E501

        query_params = []

        header_params = {}

        form_params = []
        local_var_files = {}

        body_params = None
        # HTTP header `Accept`
        header_params['Accept'] = self.api_client.select_header_accept(
            ['application/json'])  # noqa: E501

        # Authentication setting
        auth_settings = ['apiKeyAuth']  # noqa: E501

        return self.api_client.call_api(
            '/cars/offers/{offerId}', 'GET',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='CarOfferDetailsSchema',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)

    def cars_offers_search_post(self, body, **kwargs):  # noqa: E501
        """Search Offers  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_offers_search_post(body, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CarOfferRequestSchema body: (required)
        :return: CarOfferResponseSchema
                 If the method is called asynchronously,
                 returns the request thread.
        """
        kwargs['_return_http_data_only'] = True
        if kwargs.get('async_req'):
            return self.cars_offers_search_post_with_http_info(body, **kwargs)  # noqa: E501
        else:
            (data) = self.cars_offers_search_post_with_http_info(body, **kwargs)  # noqa: E501
            return data

    def cars_offers_search_post_with_http_info(self, body, **kwargs):  # noqa: E501
        """Search Offers  # noqa: E501

        This method makes a synchronous HTTP request by default. To make an
        asynchronous HTTP request, please pass async_req=True
        >>> thread = api.cars_offers_search_post_with_http_info(body, async_req=True)
        >>> result = thread.get()

        :param async_req bool
        :param CarOfferRequestSchema body: (required)
        :return: CarOfferResponseSchema
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
                    " to method cars_offers_search_post" % key
                )
            params[key] = val
        del params['kwargs']
        # verify the required parameter 'body' is set
        if ('body' not in params or
                params['body'] is None):
            raise ValueError("Missing the required parameter `body` when calling `cars_offers_search_post`")  # noqa: E501

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
        auth_settings = ['apiKeyAuth']  # noqa: E501

        return self.api_client.call_api(
            '/cars/offers/search', 'POST',
            path_params,
            query_params,
            header_params,
            body=body_params,
            post_params=form_params,
            files=local_var_files,
            response_type='CarOfferResponseSchema',  # noqa: E501
            auth_settings=auth_settings,
            async_req=params.get('async_req'),
            _return_http_data_only=params.get('_return_http_data_only'),
            _preload_content=params.get('_preload_content', True),
            _request_timeout=params.get('_request_timeout'),
            collection_formats=collection_formats)
