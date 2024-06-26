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
 * @interface TransportOfferRequestSchema
 */
export interface TransportOfferRequestSchema {

    /**
     * Latitude for the pickup location.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    pickupLocationLatitude?: number;

    /**
     * Longitude for the pickup location.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    pickupLocationLongitude?: number;

    /**
     * Date of the pickup.
     *
     * @type {string}
     * @memberof TransportOfferRequestSchema
     */
    pickupDate?: string;

    /**
     * Time of the pickup.
     *
     * @type {string}
     * @memberof TransportOfferRequestSchema
     */
    pickupTime?: string;

    /**
     * Number of adults.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    adults?: number;

    /**
     * Number of children.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    children?: number;

    /**
     * Latitude for the return location.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    returnLocationLatitude?: number;

    /**
     * Longitude for the return location.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    returnLocationLongitude?: number;

    /**
     * Date of the return.
     *
     * @type {string}
     * @memberof TransportOfferRequestSchema
     */
    returnDate?: string;

    /**
     * Time of the return.
     *
     * @type {string}
     * @memberof TransportOfferRequestSchema
     */
    returnTime?: string;

    /**
     * Keyword filter.
     *
     * @type {string}
     * @memberof TransportOfferRequestSchema
     */
    filterByKeyword?: string;

    /**
     * Minimum price filter.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    filterByPriceMin?: number;

    /**
     * Maximum price filter.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    filterByPriceMax?: number;

    /**
     * Minimum distance filter.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    filterByDistanceMin?: number;

    /**
     * Maximum distance filter.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    filterByDistanceMax?: number;

    /**
     * Minimum rating filter.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    filterByRatingMin?: number;

    /**
     * Maximum rating filter.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    filterByRatingMax?: number;

    /**
     * Filter by star rating.
     *
     * @type {Array<string>}
     * @memberof TransportOfferRequestSchema
     */
    filterByStars?: Array<string>;

    /**
     * Facilities filter.
     *
     * @type {Array<string>}
     * @memberof TransportOfferRequestSchema
     */
    filterByFacilities?: Array<string>;

    /**
     * Amenities filter.
     *
     * @type {Array<string>}
     * @memberof TransportOfferRequestSchema
     */
    filterByAmenities?: Array<string>;

    /**
     * Minimum passengers filter.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    filterByPassengersMin?: number;

    /**
     * Maximum passengers filter.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    filterByPassengersMax?: number;

    /**
     * Minimum bags filter.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    filterByBagsMin?: number;

    /**
     * Maximum bags filter.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    filterByBagsMax?: number;

    /**
     * Type filter.
     *
     * @type {Array<string>}
     * @memberof TransportOfferRequestSchema
     */
    filterByType?: Array<string>;

    /**
     * Company filter.
     *
     * @type {Array<string>}
     * @memberof TransportOfferRequestSchema
     */
    filterByCompany?: Array<string>;

    /**
     * Class filter.
     *
     * @type {Array<string>}
     * @memberof TransportOfferRequestSchema
     */
    filterByClass?: Array<string>;

    /**
     * Sorting parameter.
     *
     * @type {string}
     * @memberof TransportOfferRequestSchema
     */
    sortBy?: string;

    /**
     * Sort order (asc/desc).
     *
     * @type {string}
     * @memberof TransportOfferRequestSchema
     */
    sortOrder?: string;

    /**
     * Page number for pagination.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    page?: number;

    /**
     * Limit of results per page.
     *
     * @type {number}
     * @memberof TransportOfferRequestSchema
     */
    limit?: number;

    /**
     * Language for the results.
     *
     * @type {string}
     * @memberof TransportOfferRequestSchema
     */
    language?: string;

    /**
     * Currency for pricing.
     *
     * @type {string}
     * @memberof TransportOfferRequestSchema
     */
    currency?: string;

    /**
     * Unit of measurement for distances.
     *
     * @type {string}
     * @memberof TransportOfferRequestSchema
     */
    metric?: string;
}
