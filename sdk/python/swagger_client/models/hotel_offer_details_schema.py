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

class HotelOfferDetailsSchema(object):
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
        'offer_id': 'str',
        'supplier_offer_id': 'str',
        'offer_index': 'int',
        'offer_tax': 'float',
        'offer_price': 'float',
        'offer_currency': 'str',
        'offer_cancellation_policies': 'object',
        'checkin_date': 'date',
        'checkout_date': 'date',
        'hotel_name': 'str',
        'hotel_description': 'str',
        'hotel_address': 'str',
        'hotel_latitude': 'float',
        'hotel_longitude': 'float',
        'hotel_distance': 'float',
        'hotel_distance_metric': 'str',
        'hotel_images': 'list[str]',
        'hotel_rating': 'float',
        'hotel_reviews': 'object',
        'hotel_stars': 'int',
        'hotel_checkin_time': 'str',
        'hotel_checkout_time': 'str',
        'hotel_facilities': 'list[str]',
        'hotel_amenities': 'list[str]',
        'hotel_policies': 'list[str]',
        'rooms': 'list[HotelRoomSchema]'
    }

    attribute_map = {
        'offer_id': 'offer_id',
        'supplier_offer_id': 'supplier_offer_id',
        'offer_index': 'offer_index',
        'offer_tax': 'offer_tax',
        'offer_price': 'offer_price',
        'offer_currency': 'offer_currency',
        'offer_cancellation_policies': 'offer_cancellation_policies',
        'checkin_date': 'checkin_date',
        'checkout_date': 'checkout_date',
        'hotel_name': 'hotel_name',
        'hotel_description': 'hotel_description',
        'hotel_address': 'hotel_address',
        'hotel_latitude': 'hotel_latitude',
        'hotel_longitude': 'hotel_longitude',
        'hotel_distance': 'hotel_distance',
        'hotel_distance_metric': 'hotel_distance_metric',
        'hotel_images': 'hotel_images',
        'hotel_rating': 'hotel_rating',
        'hotel_reviews': 'hotel_reviews',
        'hotel_stars': 'hotel_stars',
        'hotel_checkin_time': 'hotel_checkin_time',
        'hotel_checkout_time': 'hotel_checkout_time',
        'hotel_facilities': 'hotel_facilities',
        'hotel_amenities': 'hotel_amenities',
        'hotel_policies': 'hotel_policies',
        'rooms': 'rooms'
    }

    def __init__(self, offer_id=None, supplier_offer_id=None, offer_index=None, offer_tax=None, offer_price=None, offer_currency=None, offer_cancellation_policies=None, checkin_date=None, checkout_date=None, hotel_name=None, hotel_description=None, hotel_address=None, hotel_latitude=None, hotel_longitude=None, hotel_distance=None, hotel_distance_metric=None, hotel_images=None, hotel_rating=None, hotel_reviews=None, hotel_stars=None, hotel_checkin_time=None, hotel_checkout_time=None, hotel_facilities=None, hotel_amenities=None, hotel_policies=None, rooms=None):  # noqa: E501
        """HotelOfferDetailsSchema - a model defined in Swagger"""  # noqa: E501
        self._offer_id = None
        self._supplier_offer_id = None
        self._offer_index = None
        self._offer_tax = None
        self._offer_price = None
        self._offer_currency = None
        self._offer_cancellation_policies = None
        self._checkin_date = None
        self._checkout_date = None
        self._hotel_name = None
        self._hotel_description = None
        self._hotel_address = None
        self._hotel_latitude = None
        self._hotel_longitude = None
        self._hotel_distance = None
        self._hotel_distance_metric = None
        self._hotel_images = None
        self._hotel_rating = None
        self._hotel_reviews = None
        self._hotel_stars = None
        self._hotel_checkin_time = None
        self._hotel_checkout_time = None
        self._hotel_facilities = None
        self._hotel_amenities = None
        self._hotel_policies = None
        self._rooms = None
        self.discriminator = None
        if offer_id is not None:
            self.offer_id = offer_id
        if supplier_offer_id is not None:
            self.supplier_offer_id = supplier_offer_id
        if offer_index is not None:
            self.offer_index = offer_index
        if offer_tax is not None:
            self.offer_tax = offer_tax
        if offer_price is not None:
            self.offer_price = offer_price
        if offer_currency is not None:
            self.offer_currency = offer_currency
        if offer_cancellation_policies is not None:
            self.offer_cancellation_policies = offer_cancellation_policies
        if checkin_date is not None:
            self.checkin_date = checkin_date
        if checkout_date is not None:
            self.checkout_date = checkout_date
        if hotel_name is not None:
            self.hotel_name = hotel_name
        if hotel_description is not None:
            self.hotel_description = hotel_description
        if hotel_address is not None:
            self.hotel_address = hotel_address
        if hotel_latitude is not None:
            self.hotel_latitude = hotel_latitude
        if hotel_longitude is not None:
            self.hotel_longitude = hotel_longitude
        if hotel_distance is not None:
            self.hotel_distance = hotel_distance
        if hotel_distance_metric is not None:
            self.hotel_distance_metric = hotel_distance_metric
        if hotel_images is not None:
            self.hotel_images = hotel_images
        if hotel_rating is not None:
            self.hotel_rating = hotel_rating
        if hotel_reviews is not None:
            self.hotel_reviews = hotel_reviews
        if hotel_stars is not None:
            self.hotel_stars = hotel_stars
        if hotel_checkin_time is not None:
            self.hotel_checkin_time = hotel_checkin_time
        if hotel_checkout_time is not None:
            self.hotel_checkout_time = hotel_checkout_time
        if hotel_facilities is not None:
            self.hotel_facilities = hotel_facilities
        if hotel_amenities is not None:
            self.hotel_amenities = hotel_amenities
        if hotel_policies is not None:
            self.hotel_policies = hotel_policies
        if rooms is not None:
            self.rooms = rooms

    @property
    def offer_id(self):
        """Gets the offer_id of this HotelOfferDetailsSchema.  # noqa: E501

        Unique identifier for the hotel offer.  # noqa: E501

        :return: The offer_id of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: str
        """
        return self._offer_id

    @offer_id.setter
    def offer_id(self, offer_id):
        """Sets the offer_id of this HotelOfferDetailsSchema.

        Unique identifier for the hotel offer.  # noqa: E501

        :param offer_id: The offer_id of this HotelOfferDetailsSchema.  # noqa: E501
        :type: str
        """

        self._offer_id = offer_id

    @property
    def supplier_offer_id(self):
        """Gets the supplier_offer_id of this HotelOfferDetailsSchema.  # noqa: E501

        Unique identifier given by the supplier for the hotel offer.  # noqa: E501

        :return: The supplier_offer_id of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: str
        """
        return self._supplier_offer_id

    @supplier_offer_id.setter
    def supplier_offer_id(self, supplier_offer_id):
        """Sets the supplier_offer_id of this HotelOfferDetailsSchema.

        Unique identifier given by the supplier for the hotel offer.  # noqa: E501

        :param supplier_offer_id: The supplier_offer_id of this HotelOfferDetailsSchema.  # noqa: E501
        :type: str
        """

        self._supplier_offer_id = supplier_offer_id

    @property
    def offer_index(self):
        """Gets the offer_index of this HotelOfferDetailsSchema.  # noqa: E501

        Index number of the offer for sorting and referencing purposes.  # noqa: E501

        :return: The offer_index of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: int
        """
        return self._offer_index

    @offer_index.setter
    def offer_index(self, offer_index):
        """Sets the offer_index of this HotelOfferDetailsSchema.

        Index number of the offer for sorting and referencing purposes.  # noqa: E501

        :param offer_index: The offer_index of this HotelOfferDetailsSchema.  # noqa: E501
        :type: int
        """

        self._offer_index = offer_index

    @property
    def offer_tax(self):
        """Gets the offer_tax of this HotelOfferDetailsSchema.  # noqa: E501

        Applicable tax amount for the offer.  # noqa: E501

        :return: The offer_tax of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: float
        """
        return self._offer_tax

    @offer_tax.setter
    def offer_tax(self, offer_tax):
        """Sets the offer_tax of this HotelOfferDetailsSchema.

        Applicable tax amount for the offer.  # noqa: E501

        :param offer_tax: The offer_tax of this HotelOfferDetailsSchema.  # noqa: E501
        :type: float
        """

        self._offer_tax = offer_tax

    @property
    def offer_price(self):
        """Gets the offer_price of this HotelOfferDetailsSchema.  # noqa: E501

        Total price of the hotel offer.  # noqa: E501

        :return: The offer_price of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: float
        """
        return self._offer_price

    @offer_price.setter
    def offer_price(self, offer_price):
        """Sets the offer_price of this HotelOfferDetailsSchema.

        Total price of the hotel offer.  # noqa: E501

        :param offer_price: The offer_price of this HotelOfferDetailsSchema.  # noqa: E501
        :type: float
        """

        self._offer_price = offer_price

    @property
    def offer_currency(self):
        """Gets the offer_currency of this HotelOfferDetailsSchema.  # noqa: E501

        Currency in which the offer price is denominated.  # noqa: E501

        :return: The offer_currency of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: str
        """
        return self._offer_currency

    @offer_currency.setter
    def offer_currency(self, offer_currency):
        """Sets the offer_currency of this HotelOfferDetailsSchema.

        Currency in which the offer price is denominated.  # noqa: E501

        :param offer_currency: The offer_currency of this HotelOfferDetailsSchema.  # noqa: E501
        :type: str
        """

        self._offer_currency = offer_currency

    @property
    def offer_cancellation_policies(self):
        """Gets the offer_cancellation_policies of this HotelOfferDetailsSchema.  # noqa: E501

        Details of the cancellation policies applicable to the offer.  # noqa: E501

        :return: The offer_cancellation_policies of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: object
        """
        return self._offer_cancellation_policies

    @offer_cancellation_policies.setter
    def offer_cancellation_policies(self, offer_cancellation_policies):
        """Sets the offer_cancellation_policies of this HotelOfferDetailsSchema.

        Details of the cancellation policies applicable to the offer.  # noqa: E501

        :param offer_cancellation_policies: The offer_cancellation_policies of this HotelOfferDetailsSchema.  # noqa: E501
        :type: object
        """

        self._offer_cancellation_policies = offer_cancellation_policies

    @property
    def checkin_date(self):
        """Gets the checkin_date of this HotelOfferDetailsSchema.  # noqa: E501

        Scheduled check-in date for the hotel stay.  # noqa: E501

        :return: The checkin_date of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: date
        """
        return self._checkin_date

    @checkin_date.setter
    def checkin_date(self, checkin_date):
        """Sets the checkin_date of this HotelOfferDetailsSchema.

        Scheduled check-in date for the hotel stay.  # noqa: E501

        :param checkin_date: The checkin_date of this HotelOfferDetailsSchema.  # noqa: E501
        :type: date
        """

        self._checkin_date = checkin_date

    @property
    def checkout_date(self):
        """Gets the checkout_date of this HotelOfferDetailsSchema.  # noqa: E501

        Scheduled check-out date for the hotel stay.  # noqa: E501

        :return: The checkout_date of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: date
        """
        return self._checkout_date

    @checkout_date.setter
    def checkout_date(self, checkout_date):
        """Sets the checkout_date of this HotelOfferDetailsSchema.

        Scheduled check-out date for the hotel stay.  # noqa: E501

        :param checkout_date: The checkout_date of this HotelOfferDetailsSchema.  # noqa: E501
        :type: date
        """

        self._checkout_date = checkout_date

    @property
    def hotel_name(self):
        """Gets the hotel_name of this HotelOfferDetailsSchema.  # noqa: E501

        Name of the hotel.  # noqa: E501

        :return: The hotel_name of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: str
        """
        return self._hotel_name

    @hotel_name.setter
    def hotel_name(self, hotel_name):
        """Sets the hotel_name of this HotelOfferDetailsSchema.

        Name of the hotel.  # noqa: E501

        :param hotel_name: The hotel_name of this HotelOfferDetailsSchema.  # noqa: E501
        :type: str
        """

        self._hotel_name = hotel_name

    @property
    def hotel_description(self):
        """Gets the hotel_description of this HotelOfferDetailsSchema.  # noqa: E501

        Description of the hotel.  # noqa: E501

        :return: The hotel_description of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: str
        """
        return self._hotel_description

    @hotel_description.setter
    def hotel_description(self, hotel_description):
        """Sets the hotel_description of this HotelOfferDetailsSchema.

        Description of the hotel.  # noqa: E501

        :param hotel_description: The hotel_description of this HotelOfferDetailsSchema.  # noqa: E501
        :type: str
        """

        self._hotel_description = hotel_description

    @property
    def hotel_address(self):
        """Gets the hotel_address of this HotelOfferDetailsSchema.  # noqa: E501

        Physical address of the hotel.  # noqa: E501

        :return: The hotel_address of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: str
        """
        return self._hotel_address

    @hotel_address.setter
    def hotel_address(self, hotel_address):
        """Sets the hotel_address of this HotelOfferDetailsSchema.

        Physical address of the hotel.  # noqa: E501

        :param hotel_address: The hotel_address of this HotelOfferDetailsSchema.  # noqa: E501
        :type: str
        """

        self._hotel_address = hotel_address

    @property
    def hotel_latitude(self):
        """Gets the hotel_latitude of this HotelOfferDetailsSchema.  # noqa: E501

        Geographic latitude of the hotel.  # noqa: E501

        :return: The hotel_latitude of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: float
        """
        return self._hotel_latitude

    @hotel_latitude.setter
    def hotel_latitude(self, hotel_latitude):
        """Sets the hotel_latitude of this HotelOfferDetailsSchema.

        Geographic latitude of the hotel.  # noqa: E501

        :param hotel_latitude: The hotel_latitude of this HotelOfferDetailsSchema.  # noqa: E501
        :type: float
        """

        self._hotel_latitude = hotel_latitude

    @property
    def hotel_longitude(self):
        """Gets the hotel_longitude of this HotelOfferDetailsSchema.  # noqa: E501

        Geographic longitude of the hotel.  # noqa: E501

        :return: The hotel_longitude of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: float
        """
        return self._hotel_longitude

    @hotel_longitude.setter
    def hotel_longitude(self, hotel_longitude):
        """Sets the hotel_longitude of this HotelOfferDetailsSchema.

        Geographic longitude of the hotel.  # noqa: E501

        :param hotel_longitude: The hotel_longitude of this HotelOfferDetailsSchema.  # noqa: E501
        :type: float
        """

        self._hotel_longitude = hotel_longitude

    @property
    def hotel_distance(self):
        """Gets the hotel_distance of this HotelOfferDetailsSchema.  # noqa: E501

        Distance of the hotel from a central point of interest, if applicable.  # noqa: E501

        :return: The hotel_distance of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: float
        """
        return self._hotel_distance

    @hotel_distance.setter
    def hotel_distance(self, hotel_distance):
        """Sets the hotel_distance of this HotelOfferDetailsSchema.

        Distance of the hotel from a central point of interest, if applicable.  # noqa: E501

        :param hotel_distance: The hotel_distance of this HotelOfferDetailsSchema.  # noqa: E501
        :type: float
        """

        self._hotel_distance = hotel_distance

    @property
    def hotel_distance_metric(self):
        """Gets the hotel_distance_metric of this HotelOfferDetailsSchema.  # noqa: E501

        Unit of measurement for the distance (e.g., km, miles).  # noqa: E501

        :return: The hotel_distance_metric of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: str
        """
        return self._hotel_distance_metric

    @hotel_distance_metric.setter
    def hotel_distance_metric(self, hotel_distance_metric):
        """Sets the hotel_distance_metric of this HotelOfferDetailsSchema.

        Unit of measurement for the distance (e.g., km, miles).  # noqa: E501

        :param hotel_distance_metric: The hotel_distance_metric of this HotelOfferDetailsSchema.  # noqa: E501
        :type: str
        """

        self._hotel_distance_metric = hotel_distance_metric

    @property
    def hotel_images(self):
        """Gets the hotel_images of this HotelOfferDetailsSchema.  # noqa: E501

        Array of images associated with the hotel.  # noqa: E501

        :return: The hotel_images of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: list[str]
        """
        return self._hotel_images

    @hotel_images.setter
    def hotel_images(self, hotel_images):
        """Sets the hotel_images of this HotelOfferDetailsSchema.

        Array of images associated with the hotel.  # noqa: E501

        :param hotel_images: The hotel_images of this HotelOfferDetailsSchema.  # noqa: E501
        :type: list[str]
        """

        self._hotel_images = hotel_images

    @property
    def hotel_rating(self):
        """Gets the hotel_rating of this HotelOfferDetailsSchema.  # noqa: E501

        Overall rating of the hotel.  # noqa: E501

        :return: The hotel_rating of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: float
        """
        return self._hotel_rating

    @hotel_rating.setter
    def hotel_rating(self, hotel_rating):
        """Sets the hotel_rating of this HotelOfferDetailsSchema.

        Overall rating of the hotel.  # noqa: E501

        :param hotel_rating: The hotel_rating of this HotelOfferDetailsSchema.  # noqa: E501
        :type: float
        """

        self._hotel_rating = hotel_rating

    @property
    def hotel_reviews(self):
        """Gets the hotel_reviews of this HotelOfferDetailsSchema.  # noqa: E501

        Collection of reviews for the hotel.  # noqa: E501

        :return: The hotel_reviews of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: object
        """
        return self._hotel_reviews

    @hotel_reviews.setter
    def hotel_reviews(self, hotel_reviews):
        """Sets the hotel_reviews of this HotelOfferDetailsSchema.

        Collection of reviews for the hotel.  # noqa: E501

        :param hotel_reviews: The hotel_reviews of this HotelOfferDetailsSchema.  # noqa: E501
        :type: object
        """

        self._hotel_reviews = hotel_reviews

    @property
    def hotel_stars(self):
        """Gets the hotel_stars of this HotelOfferDetailsSchema.  # noqa: E501

        Star rating of the hotel.  # noqa: E501

        :return: The hotel_stars of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: int
        """
        return self._hotel_stars

    @hotel_stars.setter
    def hotel_stars(self, hotel_stars):
        """Sets the hotel_stars of this HotelOfferDetailsSchema.

        Star rating of the hotel.  # noqa: E501

        :param hotel_stars: The hotel_stars of this HotelOfferDetailsSchema.  # noqa: E501
        :type: int
        """

        self._hotel_stars = hotel_stars

    @property
    def hotel_checkin_time(self):
        """Gets the hotel_checkin_time of this HotelOfferDetailsSchema.  # noqa: E501

        Standard check-in time at the hotel.  # noqa: E501

        :return: The hotel_checkin_time of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: str
        """
        return self._hotel_checkin_time

    @hotel_checkin_time.setter
    def hotel_checkin_time(self, hotel_checkin_time):
        """Sets the hotel_checkin_time of this HotelOfferDetailsSchema.

        Standard check-in time at the hotel.  # noqa: E501

        :param hotel_checkin_time: The hotel_checkin_time of this HotelOfferDetailsSchema.  # noqa: E501
        :type: str
        """

        self._hotel_checkin_time = hotel_checkin_time

    @property
    def hotel_checkout_time(self):
        """Gets the hotel_checkout_time of this HotelOfferDetailsSchema.  # noqa: E501

        Standard check-out time at the hotel.  # noqa: E501

        :return: The hotel_checkout_time of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: str
        """
        return self._hotel_checkout_time

    @hotel_checkout_time.setter
    def hotel_checkout_time(self, hotel_checkout_time):
        """Sets the hotel_checkout_time of this HotelOfferDetailsSchema.

        Standard check-out time at the hotel.  # noqa: E501

        :param hotel_checkout_time: The hotel_checkout_time of this HotelOfferDetailsSchema.  # noqa: E501
        :type: str
        """

        self._hotel_checkout_time = hotel_checkout_time

    @property
    def hotel_facilities(self):
        """Gets the hotel_facilities of this HotelOfferDetailsSchema.  # noqa: E501

        List of facilities available at the hotel.  # noqa: E501

        :return: The hotel_facilities of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: list[str]
        """
        return self._hotel_facilities

    @hotel_facilities.setter
    def hotel_facilities(self, hotel_facilities):
        """Sets the hotel_facilities of this HotelOfferDetailsSchema.

        List of facilities available at the hotel.  # noqa: E501

        :param hotel_facilities: The hotel_facilities of this HotelOfferDetailsSchema.  # noqa: E501
        :type: list[str]
        """

        self._hotel_facilities = hotel_facilities

    @property
    def hotel_amenities(self):
        """Gets the hotel_amenities of this HotelOfferDetailsSchema.  # noqa: E501

        List of amenities offered by the hotel.  # noqa: E501

        :return: The hotel_amenities of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: list[str]
        """
        return self._hotel_amenities

    @hotel_amenities.setter
    def hotel_amenities(self, hotel_amenities):
        """Sets the hotel_amenities of this HotelOfferDetailsSchema.

        List of amenities offered by the hotel.  # noqa: E501

        :param hotel_amenities: The hotel_amenities of this HotelOfferDetailsSchema.  # noqa: E501
        :type: list[str]
        """

        self._hotel_amenities = hotel_amenities

    @property
    def hotel_policies(self):
        """Gets the hotel_policies of this HotelOfferDetailsSchema.  # noqa: E501

        General policies of the hotel.  # noqa: E501

        :return: The hotel_policies of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: list[str]
        """
        return self._hotel_policies

    @hotel_policies.setter
    def hotel_policies(self, hotel_policies):
        """Sets the hotel_policies of this HotelOfferDetailsSchema.

        General policies of the hotel.  # noqa: E501

        :param hotel_policies: The hotel_policies of this HotelOfferDetailsSchema.  # noqa: E501
        :type: list[str]
        """

        self._hotel_policies = hotel_policies

    @property
    def rooms(self):
        """Gets the rooms of this HotelOfferDetailsSchema.  # noqa: E501

        Array of HotelRoomSchema.  # noqa: E501

        :return: The rooms of this HotelOfferDetailsSchema.  # noqa: E501
        :rtype: list[HotelRoomSchema]
        """
        return self._rooms

    @rooms.setter
    def rooms(self, rooms):
        """Sets the rooms of this HotelOfferDetailsSchema.

        Array of HotelRoomSchema.  # noqa: E501

        :param rooms: The rooms of this HotelOfferDetailsSchema.  # noqa: E501
        :type: list[HotelRoomSchema]
        """

        self._rooms = rooms

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
        if issubclass(HotelOfferDetailsSchema, dict):
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
        if not isinstance(other, HotelOfferDetailsSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
