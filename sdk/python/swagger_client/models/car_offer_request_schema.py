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

class CarOfferRequestSchema(object):
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
        'pickup_location_latitude': 'float',
        'pickup_location_longitude': 'float',
        'pickup_date': 'date',
        'pickup_time': 'str',
        'dropoff_location_latitude': 'float',
        'dropoff_location_longitude': 'float',
        'dropoff_date': 'date',
        'dropoff_time': 'str',
        'filter_by_keyword': 'str',
        'filter_by_price_min': 'float',
        'filter_by_price_max': 'float',
        'filter_by_distance_min': 'int',
        'filter_by_distance_max': 'int',
        'filter_by_rating_min': 'int',
        'filter_by_rating_max': 'int',
        'filter_by_passengers_min': 'int',
        'filter_by_passengers_max': 'int',
        'filter_by_type': 'list[str]',
        'filter_by_company': 'list[str]',
        'sort_by': 'str',
        'sort_order': 'str',
        'page': 'int',
        'limit': 'int',
        'language': 'str',
        'currency': 'str',
        'metric': 'str'
    }

    attribute_map = {
        'pickup_location_latitude': 'pickup_location_latitude',
        'pickup_location_longitude': 'pickup_location_longitude',
        'pickup_date': 'pickup_date',
        'pickup_time': 'pickup_time',
        'dropoff_location_latitude': 'dropoff_location_latitude',
        'dropoff_location_longitude': 'dropoff_location_longitude',
        'dropoff_date': 'dropoff_date',
        'dropoff_time': 'dropoff_time',
        'filter_by_keyword': 'filter_by_keyword',
        'filter_by_price_min': 'filter_by_price_min',
        'filter_by_price_max': 'filter_by_price_max',
        'filter_by_distance_min': 'filter_by_distance_min',
        'filter_by_distance_max': 'filter_by_distance_max',
        'filter_by_rating_min': 'filter_by_rating_min',
        'filter_by_rating_max': 'filter_by_rating_max',
        'filter_by_passengers_min': 'filter_by_passengers_min',
        'filter_by_passengers_max': 'filter_by_passengers_max',
        'filter_by_type': 'filter_by_type',
        'filter_by_company': 'filter_by_company',
        'sort_by': 'sort_by',
        'sort_order': 'sort_order',
        'page': 'page',
        'limit': 'limit',
        'language': 'language',
        'currency': 'currency',
        'metric': 'metric'
    }

    def __init__(self, pickup_location_latitude=None, pickup_location_longitude=None, pickup_date=None, pickup_time=None, dropoff_location_latitude=None, dropoff_location_longitude=None, dropoff_date=None, dropoff_time=None, filter_by_keyword=None, filter_by_price_min=None, filter_by_price_max=None, filter_by_distance_min=None, filter_by_distance_max=None, filter_by_rating_min=None, filter_by_rating_max=None, filter_by_passengers_min=None, filter_by_passengers_max=None, filter_by_type=None, filter_by_company=None, sort_by=None, sort_order=None, page=None, limit=None, language=None, currency=None, metric=None):  # noqa: E501
        """CarOfferRequestSchema - a model defined in Swagger"""  # noqa: E501
        self._pickup_location_latitude = None
        self._pickup_location_longitude = None
        self._pickup_date = None
        self._pickup_time = None
        self._dropoff_location_latitude = None
        self._dropoff_location_longitude = None
        self._dropoff_date = None
        self._dropoff_time = None
        self._filter_by_keyword = None
        self._filter_by_price_min = None
        self._filter_by_price_max = None
        self._filter_by_distance_min = None
        self._filter_by_distance_max = None
        self._filter_by_rating_min = None
        self._filter_by_rating_max = None
        self._filter_by_passengers_min = None
        self._filter_by_passengers_max = None
        self._filter_by_type = None
        self._filter_by_company = None
        self._sort_by = None
        self._sort_order = None
        self._page = None
        self._limit = None
        self._language = None
        self._currency = None
        self._metric = None
        self.discriminator = None
        if pickup_location_latitude is not None:
            self.pickup_location_latitude = pickup_location_latitude
        if pickup_location_longitude is not None:
            self.pickup_location_longitude = pickup_location_longitude
        if pickup_date is not None:
            self.pickup_date = pickup_date
        if pickup_time is not None:
            self.pickup_time = pickup_time
        if dropoff_location_latitude is not None:
            self.dropoff_location_latitude = dropoff_location_latitude
        if dropoff_location_longitude is not None:
            self.dropoff_location_longitude = dropoff_location_longitude
        if dropoff_date is not None:
            self.dropoff_date = dropoff_date
        if dropoff_time is not None:
            self.dropoff_time = dropoff_time
        if filter_by_keyword is not None:
            self.filter_by_keyword = filter_by_keyword
        if filter_by_price_min is not None:
            self.filter_by_price_min = filter_by_price_min
        if filter_by_price_max is not None:
            self.filter_by_price_max = filter_by_price_max
        if filter_by_distance_min is not None:
            self.filter_by_distance_min = filter_by_distance_min
        if filter_by_distance_max is not None:
            self.filter_by_distance_max = filter_by_distance_max
        if filter_by_rating_min is not None:
            self.filter_by_rating_min = filter_by_rating_min
        if filter_by_rating_max is not None:
            self.filter_by_rating_max = filter_by_rating_max
        if filter_by_passengers_min is not None:
            self.filter_by_passengers_min = filter_by_passengers_min
        if filter_by_passengers_max is not None:
            self.filter_by_passengers_max = filter_by_passengers_max
        if filter_by_type is not None:
            self.filter_by_type = filter_by_type
        if filter_by_company is not None:
            self.filter_by_company = filter_by_company
        if sort_by is not None:
            self.sort_by = sort_by
        if sort_order is not None:
            self.sort_order = sort_order
        if page is not None:
            self.page = page
        if limit is not None:
            self.limit = limit
        if language is not None:
            self.language = language
        if currency is not None:
            self.currency = currency
        if metric is not None:
            self.metric = metric

    @property
    def pickup_location_latitude(self):
        """Gets the pickup_location_latitude of this CarOfferRequestSchema.  # noqa: E501

        Latitude for car pickup location.  # noqa: E501

        :return: The pickup_location_latitude of this CarOfferRequestSchema.  # noqa: E501
        :rtype: float
        """
        return self._pickup_location_latitude

    @pickup_location_latitude.setter
    def pickup_location_latitude(self, pickup_location_latitude):
        """Sets the pickup_location_latitude of this CarOfferRequestSchema.

        Latitude for car pickup location.  # noqa: E501

        :param pickup_location_latitude: The pickup_location_latitude of this CarOfferRequestSchema.  # noqa: E501
        :type: float
        """

        self._pickup_location_latitude = pickup_location_latitude

    @property
    def pickup_location_longitude(self):
        """Gets the pickup_location_longitude of this CarOfferRequestSchema.  # noqa: E501

        Longitude for car pickup location.  # noqa: E501

        :return: The pickup_location_longitude of this CarOfferRequestSchema.  # noqa: E501
        :rtype: float
        """
        return self._pickup_location_longitude

    @pickup_location_longitude.setter
    def pickup_location_longitude(self, pickup_location_longitude):
        """Sets the pickup_location_longitude of this CarOfferRequestSchema.

        Longitude for car pickup location.  # noqa: E501

        :param pickup_location_longitude: The pickup_location_longitude of this CarOfferRequestSchema.  # noqa: E501
        :type: float
        """

        self._pickup_location_longitude = pickup_location_longitude

    @property
    def pickup_date(self):
        """Gets the pickup_date of this CarOfferRequestSchema.  # noqa: E501

        Scheduled date for car pickup.  # noqa: E501

        :return: The pickup_date of this CarOfferRequestSchema.  # noqa: E501
        :rtype: date
        """
        return self._pickup_date

    @pickup_date.setter
    def pickup_date(self, pickup_date):
        """Sets the pickup_date of this CarOfferRequestSchema.

        Scheduled date for car pickup.  # noqa: E501

        :param pickup_date: The pickup_date of this CarOfferRequestSchema.  # noqa: E501
        :type: date
        """

        self._pickup_date = pickup_date

    @property
    def pickup_time(self):
        """Gets the pickup_time of this CarOfferRequestSchema.  # noqa: E501

        Scheduled time for car pickup.  # noqa: E501

        :return: The pickup_time of this CarOfferRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._pickup_time

    @pickup_time.setter
    def pickup_time(self, pickup_time):
        """Sets the pickup_time of this CarOfferRequestSchema.

        Scheduled time for car pickup.  # noqa: E501

        :param pickup_time: The pickup_time of this CarOfferRequestSchema.  # noqa: E501
        :type: str
        """

        self._pickup_time = pickup_time

    @property
    def dropoff_location_latitude(self):
        """Gets the dropoff_location_latitude of this CarOfferRequestSchema.  # noqa: E501

        Latitude for car dropoff location.  # noqa: E501

        :return: The dropoff_location_latitude of this CarOfferRequestSchema.  # noqa: E501
        :rtype: float
        """
        return self._dropoff_location_latitude

    @dropoff_location_latitude.setter
    def dropoff_location_latitude(self, dropoff_location_latitude):
        """Sets the dropoff_location_latitude of this CarOfferRequestSchema.

        Latitude for car dropoff location.  # noqa: E501

        :param dropoff_location_latitude: The dropoff_location_latitude of this CarOfferRequestSchema.  # noqa: E501
        :type: float
        """

        self._dropoff_location_latitude = dropoff_location_latitude

    @property
    def dropoff_location_longitude(self):
        """Gets the dropoff_location_longitude of this CarOfferRequestSchema.  # noqa: E501

        Longitude for car dropoff location.  # noqa: E501

        :return: The dropoff_location_longitude of this CarOfferRequestSchema.  # noqa: E501
        :rtype: float
        """
        return self._dropoff_location_longitude

    @dropoff_location_longitude.setter
    def dropoff_location_longitude(self, dropoff_location_longitude):
        """Sets the dropoff_location_longitude of this CarOfferRequestSchema.

        Longitude for car dropoff location.  # noqa: E501

        :param dropoff_location_longitude: The dropoff_location_longitude of this CarOfferRequestSchema.  # noqa: E501
        :type: float
        """

        self._dropoff_location_longitude = dropoff_location_longitude

    @property
    def dropoff_date(self):
        """Gets the dropoff_date of this CarOfferRequestSchema.  # noqa: E501

        Scheduled date for car dropoff.  # noqa: E501

        :return: The dropoff_date of this CarOfferRequestSchema.  # noqa: E501
        :rtype: date
        """
        return self._dropoff_date

    @dropoff_date.setter
    def dropoff_date(self, dropoff_date):
        """Sets the dropoff_date of this CarOfferRequestSchema.

        Scheduled date for car dropoff.  # noqa: E501

        :param dropoff_date: The dropoff_date of this CarOfferRequestSchema.  # noqa: E501
        :type: date
        """

        self._dropoff_date = dropoff_date

    @property
    def dropoff_time(self):
        """Gets the dropoff_time of this CarOfferRequestSchema.  # noqa: E501

        Scheduled time for car dropoff.  # noqa: E501

        :return: The dropoff_time of this CarOfferRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._dropoff_time

    @dropoff_time.setter
    def dropoff_time(self, dropoff_time):
        """Sets the dropoff_time of this CarOfferRequestSchema.

        Scheduled time for car dropoff.  # noqa: E501

        :param dropoff_time: The dropoff_time of this CarOfferRequestSchema.  # noqa: E501
        :type: str
        """

        self._dropoff_time = dropoff_time

    @property
    def filter_by_keyword(self):
        """Gets the filter_by_keyword of this CarOfferRequestSchema.  # noqa: E501

        Keyword to filter car offers.  # noqa: E501

        :return: The filter_by_keyword of this CarOfferRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._filter_by_keyword

    @filter_by_keyword.setter
    def filter_by_keyword(self, filter_by_keyword):
        """Sets the filter_by_keyword of this CarOfferRequestSchema.

        Keyword to filter car offers.  # noqa: E501

        :param filter_by_keyword: The filter_by_keyword of this CarOfferRequestSchema.  # noqa: E501
        :type: str
        """

        self._filter_by_keyword = filter_by_keyword

    @property
    def filter_by_price_min(self):
        """Gets the filter_by_price_min of this CarOfferRequestSchema.  # noqa: E501

        Minimum price to filter car offers.  # noqa: E501

        :return: The filter_by_price_min of this CarOfferRequestSchema.  # noqa: E501
        :rtype: float
        """
        return self._filter_by_price_min

    @filter_by_price_min.setter
    def filter_by_price_min(self, filter_by_price_min):
        """Sets the filter_by_price_min of this CarOfferRequestSchema.

        Minimum price to filter car offers.  # noqa: E501

        :param filter_by_price_min: The filter_by_price_min of this CarOfferRequestSchema.  # noqa: E501
        :type: float
        """

        self._filter_by_price_min = filter_by_price_min

    @property
    def filter_by_price_max(self):
        """Gets the filter_by_price_max of this CarOfferRequestSchema.  # noqa: E501

        Maximum price to filter car offers.  # noqa: E501

        :return: The filter_by_price_max of this CarOfferRequestSchema.  # noqa: E501
        :rtype: float
        """
        return self._filter_by_price_max

    @filter_by_price_max.setter
    def filter_by_price_max(self, filter_by_price_max):
        """Sets the filter_by_price_max of this CarOfferRequestSchema.

        Maximum price to filter car offers.  # noqa: E501

        :param filter_by_price_max: The filter_by_price_max of this CarOfferRequestSchema.  # noqa: E501
        :type: float
        """

        self._filter_by_price_max = filter_by_price_max

    @property
    def filter_by_distance_min(self):
        """Gets the filter_by_distance_min of this CarOfferRequestSchema.  # noqa: E501

        Minimum distance filter for car offers.  # noqa: E501

        :return: The filter_by_distance_min of this CarOfferRequestSchema.  # noqa: E501
        :rtype: int
        """
        return self._filter_by_distance_min

    @filter_by_distance_min.setter
    def filter_by_distance_min(self, filter_by_distance_min):
        """Sets the filter_by_distance_min of this CarOfferRequestSchema.

        Minimum distance filter for car offers.  # noqa: E501

        :param filter_by_distance_min: The filter_by_distance_min of this CarOfferRequestSchema.  # noqa: E501
        :type: int
        """

        self._filter_by_distance_min = filter_by_distance_min

    @property
    def filter_by_distance_max(self):
        """Gets the filter_by_distance_max of this CarOfferRequestSchema.  # noqa: E501

        Maximum distance filter for car offers.  # noqa: E501

        :return: The filter_by_distance_max of this CarOfferRequestSchema.  # noqa: E501
        :rtype: int
        """
        return self._filter_by_distance_max

    @filter_by_distance_max.setter
    def filter_by_distance_max(self, filter_by_distance_max):
        """Sets the filter_by_distance_max of this CarOfferRequestSchema.

        Maximum distance filter for car offers.  # noqa: E501

        :param filter_by_distance_max: The filter_by_distance_max of this CarOfferRequestSchema.  # noqa: E501
        :type: int
        """

        self._filter_by_distance_max = filter_by_distance_max

    @property
    def filter_by_rating_min(self):
        """Gets the filter_by_rating_min of this CarOfferRequestSchema.  # noqa: E501

        Minimum rating filter for car offers.  # noqa: E501

        :return: The filter_by_rating_min of this CarOfferRequestSchema.  # noqa: E501
        :rtype: int
        """
        return self._filter_by_rating_min

    @filter_by_rating_min.setter
    def filter_by_rating_min(self, filter_by_rating_min):
        """Sets the filter_by_rating_min of this CarOfferRequestSchema.

        Minimum rating filter for car offers.  # noqa: E501

        :param filter_by_rating_min: The filter_by_rating_min of this CarOfferRequestSchema.  # noqa: E501
        :type: int
        """

        self._filter_by_rating_min = filter_by_rating_min

    @property
    def filter_by_rating_max(self):
        """Gets the filter_by_rating_max of this CarOfferRequestSchema.  # noqa: E501

        Maximum rating filter for car offers.  # noqa: E501

        :return: The filter_by_rating_max of this CarOfferRequestSchema.  # noqa: E501
        :rtype: int
        """
        return self._filter_by_rating_max

    @filter_by_rating_max.setter
    def filter_by_rating_max(self, filter_by_rating_max):
        """Sets the filter_by_rating_max of this CarOfferRequestSchema.

        Maximum rating filter for car offers.  # noqa: E501

        :param filter_by_rating_max: The filter_by_rating_max of this CarOfferRequestSchema.  # noqa: E501
        :type: int
        """

        self._filter_by_rating_max = filter_by_rating_max

    @property
    def filter_by_passengers_min(self):
        """Gets the filter_by_passengers_min of this CarOfferRequestSchema.  # noqa: E501

        Minimum passengers capacity filter for car offers.  # noqa: E501

        :return: The filter_by_passengers_min of this CarOfferRequestSchema.  # noqa: E501
        :rtype: int
        """
        return self._filter_by_passengers_min

    @filter_by_passengers_min.setter
    def filter_by_passengers_min(self, filter_by_passengers_min):
        """Sets the filter_by_passengers_min of this CarOfferRequestSchema.

        Minimum passengers capacity filter for car offers.  # noqa: E501

        :param filter_by_passengers_min: The filter_by_passengers_min of this CarOfferRequestSchema.  # noqa: E501
        :type: int
        """

        self._filter_by_passengers_min = filter_by_passengers_min

    @property
    def filter_by_passengers_max(self):
        """Gets the filter_by_passengers_max of this CarOfferRequestSchema.  # noqa: E501

        Maximum passengers capacity filter for car offers.  # noqa: E501

        :return: The filter_by_passengers_max of this CarOfferRequestSchema.  # noqa: E501
        :rtype: int
        """
        return self._filter_by_passengers_max

    @filter_by_passengers_max.setter
    def filter_by_passengers_max(self, filter_by_passengers_max):
        """Sets the filter_by_passengers_max of this CarOfferRequestSchema.

        Maximum passengers capacity filter for car offers.  # noqa: E501

        :param filter_by_passengers_max: The filter_by_passengers_max of this CarOfferRequestSchema.  # noqa: E501
        :type: int
        """

        self._filter_by_passengers_max = filter_by_passengers_max

    @property
    def filter_by_type(self):
        """Gets the filter_by_type of this CarOfferRequestSchema.  # noqa: E501

        Types of cars to filter by.  # noqa: E501

        :return: The filter_by_type of this CarOfferRequestSchema.  # noqa: E501
        :rtype: list[str]
        """
        return self._filter_by_type

    @filter_by_type.setter
    def filter_by_type(self, filter_by_type):
        """Sets the filter_by_type of this CarOfferRequestSchema.

        Types of cars to filter by.  # noqa: E501

        :param filter_by_type: The filter_by_type of this CarOfferRequestSchema.  # noqa: E501
        :type: list[str]
        """

        self._filter_by_type = filter_by_type

    @property
    def filter_by_company(self):
        """Gets the filter_by_company of this CarOfferRequestSchema.  # noqa: E501

        Car rental companies to filter by.  # noqa: E501

        :return: The filter_by_company of this CarOfferRequestSchema.  # noqa: E501
        :rtype: list[str]
        """
        return self._filter_by_company

    @filter_by_company.setter
    def filter_by_company(self, filter_by_company):
        """Sets the filter_by_company of this CarOfferRequestSchema.

        Car rental companies to filter by.  # noqa: E501

        :param filter_by_company: The filter_by_company of this CarOfferRequestSchema.  # noqa: E501
        :type: list[str]
        """

        self._filter_by_company = filter_by_company

    @property
    def sort_by(self):
        """Gets the sort_by of this CarOfferRequestSchema.  # noqa: E501

        Field to sort car offers by.  # noqa: E501

        :return: The sort_by of this CarOfferRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._sort_by

    @sort_by.setter
    def sort_by(self, sort_by):
        """Sets the sort_by of this CarOfferRequestSchema.

        Field to sort car offers by.  # noqa: E501

        :param sort_by: The sort_by of this CarOfferRequestSchema.  # noqa: E501
        :type: str
        """

        self._sort_by = sort_by

    @property
    def sort_order(self):
        """Gets the sort_order of this CarOfferRequestSchema.  # noqa: E501

        Order to sort car offers (asc, desc).  # noqa: E501

        :return: The sort_order of this CarOfferRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._sort_order

    @sort_order.setter
    def sort_order(self, sort_order):
        """Sets the sort_order of this CarOfferRequestSchema.

        Order to sort car offers (asc, desc).  # noqa: E501

        :param sort_order: The sort_order of this CarOfferRequestSchema.  # noqa: E501
        :type: str
        """

        self._sort_order = sort_order

    @property
    def page(self):
        """Gets the page of this CarOfferRequestSchema.  # noqa: E501

        Page number for pagination.  # noqa: E501

        :return: The page of this CarOfferRequestSchema.  # noqa: E501
        :rtype: int
        """
        return self._page

    @page.setter
    def page(self, page):
        """Sets the page of this CarOfferRequestSchema.

        Page number for pagination.  # noqa: E501

        :param page: The page of this CarOfferRequestSchema.  # noqa: E501
        :type: int
        """

        self._page = page

    @property
    def limit(self):
        """Gets the limit of this CarOfferRequestSchema.  # noqa: E501

        Number of offers per page.  # noqa: E501

        :return: The limit of this CarOfferRequestSchema.  # noqa: E501
        :rtype: int
        """
        return self._limit

    @limit.setter
    def limit(self, limit):
        """Sets the limit of this CarOfferRequestSchema.

        Number of offers per page.  # noqa: E501

        :param limit: The limit of this CarOfferRequestSchema.  # noqa: E501
        :type: int
        """

        self._limit = limit

    @property
    def language(self):
        """Gets the language of this CarOfferRequestSchema.  # noqa: E501

        Language for the offers.  # noqa: E501

        :return: The language of this CarOfferRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._language

    @language.setter
    def language(self, language):
        """Sets the language of this CarOfferRequestSchema.

        Language for the offers.  # noqa: E501

        :param language: The language of this CarOfferRequestSchema.  # noqa: E501
        :type: str
        """

        self._language = language

    @property
    def currency(self):
        """Gets the currency of this CarOfferRequestSchema.  # noqa: E501

        Currency for the offers.  # noqa: E501

        :return: The currency of this CarOfferRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._currency

    @currency.setter
    def currency(self, currency):
        """Sets the currency of this CarOfferRequestSchema.

        Currency for the offers.  # noqa: E501

        :param currency: The currency of this CarOfferRequestSchema.  # noqa: E501
        :type: str
        """

        self._currency = currency

    @property
    def metric(self):
        """Gets the metric of this CarOfferRequestSchema.  # noqa: E501

        Distance metric (mi/km) used in filters.  # noqa: E501

        :return: The metric of this CarOfferRequestSchema.  # noqa: E501
        :rtype: str
        """
        return self._metric

    @metric.setter
    def metric(self, metric):
        """Sets the metric of this CarOfferRequestSchema.

        Distance metric (mi/km) used in filters.  # noqa: E501

        :param metric: The metric of this CarOfferRequestSchema.  # noqa: E501
        :type: str
        """

        self._metric = metric

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
        if issubclass(CarOfferRequestSchema, dict):
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
        if not isinstance(other, CarOfferRequestSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
