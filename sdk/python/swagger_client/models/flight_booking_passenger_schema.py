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

class FlightBookingPassengerSchema(object):
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
        'passenger_id': 'str',
        'type': 'str',
        'title': 'str',
        'first_name': 'str',
        'last_name': 'str',
        'gender': 'str',
        'date_of_birth': 'date',
        'country': 'str',
        'phone_prefix': 'str',
        'phone_number': 'str',
        'passport_type': 'str',
        'passport_number': 'str',
        'passport_expiration_date': 'date',
        'passport_country': 'str',
        'loyalty_airline': 'str',
        'loyalty_number': 'str',
        'known_traveler_number': 'str',
        'passenger_redress_number': 'str',
        'associated_infant_passenger_id': 'str',
        'seats': 'list[BookingPassengerSelectedSeatSchema]',
        'bags': 'list[BookingPassengerExtraBagSchema]'
    }

    attribute_map = {
        'passenger_id': 'passenger_id',
        'type': 'type',
        'title': 'title',
        'first_name': 'first_name',
        'last_name': 'last_name',
        'gender': 'gender',
        'date_of_birth': 'date_of_birth',
        'country': 'country',
        'phone_prefix': 'phone_prefix',
        'phone_number': 'phone_number',
        'passport_type': 'passport_type',
        'passport_number': 'passport_number',
        'passport_expiration_date': 'passport_expiration_date',
        'passport_country': 'passport_country',
        'loyalty_airline': 'loyalty_airline',
        'loyalty_number': 'loyalty_number',
        'known_traveler_number': 'known_traveler_number',
        'passenger_redress_number': 'passenger_redress_number',
        'associated_infant_passenger_id': 'associated_infant_passenger_id',
        'seats': 'seats',
        'bags': 'bags'
    }

    def __init__(self, passenger_id=None, type=None, title=None, first_name=None, last_name=None, gender=None, date_of_birth=None, country=None, phone_prefix=None, phone_number=None, passport_type=None, passport_number=None, passport_expiration_date=None, passport_country=None, loyalty_airline=None, loyalty_number=None, known_traveler_number=None, passenger_redress_number=None, associated_infant_passenger_id=None, seats=None, bags=None):  # noqa: E501
        """FlightBookingPassengerSchema - a model defined in Swagger"""  # noqa: E501
        self._passenger_id = None
        self._type = None
        self._title = None
        self._first_name = None
        self._last_name = None
        self._gender = None
        self._date_of_birth = None
        self._country = None
        self._phone_prefix = None
        self._phone_number = None
        self._passport_type = None
        self._passport_number = None
        self._passport_expiration_date = None
        self._passport_country = None
        self._loyalty_airline = None
        self._loyalty_number = None
        self._known_traveler_number = None
        self._passenger_redress_number = None
        self._associated_infant_passenger_id = None
        self._seats = None
        self._bags = None
        self.discriminator = None
        if passenger_id is not None:
            self.passenger_id = passenger_id
        if type is not None:
            self.type = type
        if title is not None:
            self.title = title
        if first_name is not None:
            self.first_name = first_name
        if last_name is not None:
            self.last_name = last_name
        if gender is not None:
            self.gender = gender
        if date_of_birth is not None:
            self.date_of_birth = date_of_birth
        if country is not None:
            self.country = country
        if phone_prefix is not None:
            self.phone_prefix = phone_prefix
        if phone_number is not None:
            self.phone_number = phone_number
        if passport_type is not None:
            self.passport_type = passport_type
        if passport_number is not None:
            self.passport_number = passport_number
        if passport_expiration_date is not None:
            self.passport_expiration_date = passport_expiration_date
        if passport_country is not None:
            self.passport_country = passport_country
        if loyalty_airline is not None:
            self.loyalty_airline = loyalty_airline
        if loyalty_number is not None:
            self.loyalty_number = loyalty_number
        if known_traveler_number is not None:
            self.known_traveler_number = known_traveler_number
        if passenger_redress_number is not None:
            self.passenger_redress_number = passenger_redress_number
        if associated_infant_passenger_id is not None:
            self.associated_infant_passenger_id = associated_infant_passenger_id
        if seats is not None:
            self.seats = seats
        if bags is not None:
            self.bags = bags

    @property
    def passenger_id(self):
        """Gets the passenger_id of this FlightBookingPassengerSchema.  # noqa: E501

        Unique identifier for the passenger.  # noqa: E501

        :return: The passenger_id of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._passenger_id

    @passenger_id.setter
    def passenger_id(self, passenger_id):
        """Sets the passenger_id of this FlightBookingPassengerSchema.

        Unique identifier for the passenger.  # noqa: E501

        :param passenger_id: The passenger_id of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._passenger_id = passenger_id

    @property
    def type(self):
        """Gets the type of this FlightBookingPassengerSchema.  # noqa: E501

        Type of passenger (adult, child, infant, infant with seat).  # noqa: E501

        :return: The type of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._type

    @type.setter
    def type(self, type):
        """Sets the type of this FlightBookingPassengerSchema.

        Type of passenger (adult, child, infant, infant with seat).  # noqa: E501

        :param type: The type of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._type = type

    @property
    def title(self):
        """Gets the title of this FlightBookingPassengerSchema.  # noqa: E501

        Title of the passenger (e.g., Mr., Mrs.).  # noqa: E501

        :return: The title of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._title

    @title.setter
    def title(self, title):
        """Sets the title of this FlightBookingPassengerSchema.

        Title of the passenger (e.g., Mr., Mrs.).  # noqa: E501

        :param title: The title of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._title = title

    @property
    def first_name(self):
        """Gets the first_name of this FlightBookingPassengerSchema.  # noqa: E501

        First name of the passenger.  # noqa: E501

        :return: The first_name of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._first_name

    @first_name.setter
    def first_name(self, first_name):
        """Sets the first_name of this FlightBookingPassengerSchema.

        First name of the passenger.  # noqa: E501

        :param first_name: The first_name of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._first_name = first_name

    @property
    def last_name(self):
        """Gets the last_name of this FlightBookingPassengerSchema.  # noqa: E501

        Last name of the passenger.  # noqa: E501

        :return: The last_name of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._last_name

    @last_name.setter
    def last_name(self, last_name):
        """Sets the last_name of this FlightBookingPassengerSchema.

        Last name of the passenger.  # noqa: E501

        :param last_name: The last_name of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._last_name = last_name

    @property
    def gender(self):
        """Gets the gender of this FlightBookingPassengerSchema.  # noqa: E501

        Gender of the passenger.  # noqa: E501

        :return: The gender of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._gender

    @gender.setter
    def gender(self, gender):
        """Sets the gender of this FlightBookingPassengerSchema.

        Gender of the passenger.  # noqa: E501

        :param gender: The gender of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._gender = gender

    @property
    def date_of_birth(self):
        """Gets the date_of_birth of this FlightBookingPassengerSchema.  # noqa: E501

        Date of birth of the passenger.  # noqa: E501

        :return: The date_of_birth of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: date
        """
        return self._date_of_birth

    @date_of_birth.setter
    def date_of_birth(self, date_of_birth):
        """Sets the date_of_birth of this FlightBookingPassengerSchema.

        Date of birth of the passenger.  # noqa: E501

        :param date_of_birth: The date_of_birth of this FlightBookingPassengerSchema.  # noqa: E501
        :type: date
        """

        self._date_of_birth = date_of_birth

    @property
    def country(self):
        """Gets the country of this FlightBookingPassengerSchema.  # noqa: E501

        Country of the passenger.  # noqa: E501

        :return: The country of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._country

    @country.setter
    def country(self, country):
        """Sets the country of this FlightBookingPassengerSchema.

        Country of the passenger.  # noqa: E501

        :param country: The country of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._country = country

    @property
    def phone_prefix(self):
        """Gets the phone_prefix of this FlightBookingPassengerSchema.  # noqa: E501

        International dialing prefix for phone number.  # noqa: E501

        :return: The phone_prefix of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._phone_prefix

    @phone_prefix.setter
    def phone_prefix(self, phone_prefix):
        """Sets the phone_prefix of this FlightBookingPassengerSchema.

        International dialing prefix for phone number.  # noqa: E501

        :param phone_prefix: The phone_prefix of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._phone_prefix = phone_prefix

    @property
    def phone_number(self):
        """Gets the phone_number of this FlightBookingPassengerSchema.  # noqa: E501

        Phone number of the passenger.  # noqa: E501

        :return: The phone_number of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._phone_number

    @phone_number.setter
    def phone_number(self, phone_number):
        """Sets the phone_number of this FlightBookingPassengerSchema.

        Phone number of the passenger.  # noqa: E501

        :param phone_number: The phone_number of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._phone_number = phone_number

    @property
    def passport_type(self):
        """Gets the passport_type of this FlightBookingPassengerSchema.  # noqa: E501

        Type of passport.  # noqa: E501

        :return: The passport_type of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._passport_type

    @passport_type.setter
    def passport_type(self, passport_type):
        """Sets the passport_type of this FlightBookingPassengerSchema.

        Type of passport.  # noqa: E501

        :param passport_type: The passport_type of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._passport_type = passport_type

    @property
    def passport_number(self):
        """Gets the passport_number of this FlightBookingPassengerSchema.  # noqa: E501

        Passport number of the passenger.  # noqa: E501

        :return: The passport_number of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._passport_number

    @passport_number.setter
    def passport_number(self, passport_number):
        """Sets the passport_number of this FlightBookingPassengerSchema.

        Passport number of the passenger.  # noqa: E501

        :param passport_number: The passport_number of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._passport_number = passport_number

    @property
    def passport_expiration_date(self):
        """Gets the passport_expiration_date of this FlightBookingPassengerSchema.  # noqa: E501

        Expiration date of the passport.  # noqa: E501

        :return: The passport_expiration_date of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: date
        """
        return self._passport_expiration_date

    @passport_expiration_date.setter
    def passport_expiration_date(self, passport_expiration_date):
        """Sets the passport_expiration_date of this FlightBookingPassengerSchema.

        Expiration date of the passport.  # noqa: E501

        :param passport_expiration_date: The passport_expiration_date of this FlightBookingPassengerSchema.  # noqa: E501
        :type: date
        """

        self._passport_expiration_date = passport_expiration_date

    @property
    def passport_country(self):
        """Gets the passport_country of this FlightBookingPassengerSchema.  # noqa: E501

        Country of issue of the passport.  # noqa: E501

        :return: The passport_country of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._passport_country

    @passport_country.setter
    def passport_country(self, passport_country):
        """Sets the passport_country of this FlightBookingPassengerSchema.

        Country of issue of the passport.  # noqa: E501

        :param passport_country: The passport_country of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._passport_country = passport_country

    @property
    def loyalty_airline(self):
        """Gets the loyalty_airline of this FlightBookingPassengerSchema.  # noqa: E501

        Airline with which the passenger has loyalty membership.  # noqa: E501

        :return: The loyalty_airline of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._loyalty_airline

    @loyalty_airline.setter
    def loyalty_airline(self, loyalty_airline):
        """Sets the loyalty_airline of this FlightBookingPassengerSchema.

        Airline with which the passenger has loyalty membership.  # noqa: E501

        :param loyalty_airline: The loyalty_airline of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._loyalty_airline = loyalty_airline

    @property
    def loyalty_number(self):
        """Gets the loyalty_number of this FlightBookingPassengerSchema.  # noqa: E501

        Loyalty membership number.  # noqa: E501

        :return: The loyalty_number of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._loyalty_number

    @loyalty_number.setter
    def loyalty_number(self, loyalty_number):
        """Sets the loyalty_number of this FlightBookingPassengerSchema.

        Loyalty membership number.  # noqa: E501

        :param loyalty_number: The loyalty_number of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._loyalty_number = loyalty_number

    @property
    def known_traveler_number(self):
        """Gets the known_traveler_number of this FlightBookingPassengerSchema.  # noqa: E501

        Known traveler number.  # noqa: E501

        :return: The known_traveler_number of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._known_traveler_number

    @known_traveler_number.setter
    def known_traveler_number(self, known_traveler_number):
        """Sets the known_traveler_number of this FlightBookingPassengerSchema.

        Known traveler number.  # noqa: E501

        :param known_traveler_number: The known_traveler_number of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._known_traveler_number = known_traveler_number

    @property
    def passenger_redress_number(self):
        """Gets the passenger_redress_number of this FlightBookingPassengerSchema.  # noqa: E501

        Redress number of the passenger.  # noqa: E501

        :return: The passenger_redress_number of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._passenger_redress_number

    @passenger_redress_number.setter
    def passenger_redress_number(self, passenger_redress_number):
        """Sets the passenger_redress_number of this FlightBookingPassengerSchema.

        Redress number of the passenger.  # noqa: E501

        :param passenger_redress_number: The passenger_redress_number of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._passenger_redress_number = passenger_redress_number

    @property
    def associated_infant_passenger_id(self):
        """Gets the associated_infant_passenger_id of this FlightBookingPassengerSchema.  # noqa: E501

        Identifier for any associated infant passenger.  # noqa: E501

        :return: The associated_infant_passenger_id of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: str
        """
        return self._associated_infant_passenger_id

    @associated_infant_passenger_id.setter
    def associated_infant_passenger_id(self, associated_infant_passenger_id):
        """Sets the associated_infant_passenger_id of this FlightBookingPassengerSchema.

        Identifier for any associated infant passenger.  # noqa: E501

        :param associated_infant_passenger_id: The associated_infant_passenger_id of this FlightBookingPassengerSchema.  # noqa: E501
        :type: str
        """

        self._associated_infant_passenger_id = associated_infant_passenger_id

    @property
    def seats(self):
        """Gets the seats of this FlightBookingPassengerSchema.  # noqa: E501

        Array of selected seats, each defined in BookingPassengerSelectedSeatSchema.  # noqa: E501

        :return: The seats of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: list[BookingPassengerSelectedSeatSchema]
        """
        return self._seats

    @seats.setter
    def seats(self, seats):
        """Sets the seats of this FlightBookingPassengerSchema.

        Array of selected seats, each defined in BookingPassengerSelectedSeatSchema.  # noqa: E501

        :param seats: The seats of this FlightBookingPassengerSchema.  # noqa: E501
        :type: list[BookingPassengerSelectedSeatSchema]
        """

        self._seats = seats

    @property
    def bags(self):
        """Gets the bags of this FlightBookingPassengerSchema.  # noqa: E501

        Array of extra bags, each defined in BookingPassengerExtraBagSchema.  # noqa: E501

        :return: The bags of this FlightBookingPassengerSchema.  # noqa: E501
        :rtype: list[BookingPassengerExtraBagSchema]
        """
        return self._bags

    @bags.setter
    def bags(self, bags):
        """Sets the bags of this FlightBookingPassengerSchema.

        Array of extra bags, each defined in BookingPassengerExtraBagSchema.  # noqa: E501

        :param bags: The bags of this FlightBookingPassengerSchema.  # noqa: E501
        :type: list[BookingPassengerExtraBagSchema]
        """

        self._bags = bags

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
        if issubclass(FlightBookingPassengerSchema, dict):
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
        if not isinstance(other, FlightBookingPassengerSchema):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
