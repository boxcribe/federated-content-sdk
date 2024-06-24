/* tslint:disable */
/* eslint-disable */
/**
 * Federated Content API
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

 /**
 * 
 *
 * @export
 * @interface FlightOfferRequestSchema
 */
export interface FlightOfferRequestSchema {

    /**
     * Class options: first, business, premium economy, economy.
     *
     * @type {Array}
     * @memberof FlightOfferRequestSchema
     */
    cabin?: Array;

    /**
     * Array of flight legs, each described in FlightLegOfferRequestSchema.
     *
     * @type {Array}
     * @memberof FlightOfferRequestSchema
     */
    legs?: Array;

    /**
     * Array of passengers, each described in FlightPassengerOfferRequestSchema.
     *
     * @type {Array}
     * @memberof FlightOfferRequestSchema
     */
    passengers?: Array;

    /**
     * Array of codes for accessing special negotiated fares.
     *
     * @type {Array}
     * @memberof FlightOfferRequestSchema
     */
    privateFareCodes?: Array;

    /**
     * Keyword to filter offers.
     *
     * @type {string}
     * @memberof FlightOfferRequestSchema
     */
    filterByKeyword?: string;

    /**
     * Minimum price filter.
     *
     * @type {number}
     * @memberof FlightOfferRequestSchema
     */
    filterByPriceMin?: number;

    /**
     * Maximum price filter.
     *
     * @type {number}
     * @memberof FlightOfferRequestSchema
     */
    filterByPriceMax?: number;

    /**
     * Minimum flight duration filter.
     *
     * @type {number}
     * @memberof FlightOfferRequestSchema
     */
    filterByDurationMin?: number;

    /**
     * Maximum flight duration filter.
     *
     * @type {number}
     * @memberof FlightOfferRequestSchema
     */
    filterByDurationMax?: number;

    /**
     * Earliest departure time filter.
     *
     * @type {string}
     * @memberof FlightOfferRequestSchema
     */
    filterByDepartureTimeMin?: string;

    /**
     * Latest departure time filter.
     *
     * @type {string}
     * @memberof FlightOfferRequestSchema
     */
    filterByDepartureTimeMax?: string;

    /**
     * Earliest arrival time filter.
     *
     * @type {string}
     * @memberof FlightOfferRequestSchema
     */
    filterByArrivalTimeMin?: string;

    /**
     * Latest arrival time filter.
     *
     * @type {string}
     * @memberof FlightOfferRequestSchema
     */
    filterByArrivalTimeMax?: string;

    /**
     * Minimum number of stops filter.
     *
     * @type {number}
     * @memberof FlightOfferRequestSchema
     */
    filterByStopsMin?: number;

    /**
     * Maximum number of stops filter.
     *
     * @type {number}
     * @memberof FlightOfferRequestSchema
     */
    filterByStopsMax?: number;

    /**
     * List of airline filters.
     *
     * @type {Array}
     * @memberof FlightOfferRequestSchema
     */
    filterByAirlines?: Array;

    /**
     * List of airport filters.
     *
     * @type {Array}
     * @memberof FlightOfferRequestSchema
     */
    filterByAirports?: Array;

    /**
     * Sorting criteria.
     *
     * @type {string}
     * @memberof FlightOfferRequestSchema
     */
    sortBy?: string;

    /**
     * Sorting order, asc or desc.
     *
     * @type {string}
     * @memberof FlightOfferRequestSchema
     */
    sortOrder?: string;

    /**
     * Pagination: page number.
     *
     * @type {number}
     * @memberof FlightOfferRequestSchema
     */
    page?: number;

    /**
     * Pagination: maximum items per page.
     *
     * @type {number}
     * @memberof FlightOfferRequestSchema
     */
    limit?: number;

    /**
     * Language selection for offer details.
     *
     * @type {string}
     * @memberof FlightOfferRequestSchema
     */
    language?: string;

    /**
     * Currency in which prices should be provided.
     *
     * @type {string}
     * @memberof FlightOfferRequestSchema
     */
    currency?: string;
}
