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
 * @interface ToursAndActivitiesOfferRequestSchema
 */
export interface ToursAndActivitiesOfferRequestSchema {

    /**
     * Latitude for the location.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    locationLatitude?: number;

    /**
     * Longitude for the location.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    locationLongitude?: number;

    /**
     * Radius to search for tours and activities from the specified location.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    locationRadius?: number;

    /**
     * Starting date for tours and activities.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    startDate?: string;

    /**
     * Ending date for tours and activities.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    endDate?: string;

    /**
     * Number of adults participating.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    adults?: number;

    /**
     * Number of children participating.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    children?: number;

    /**
     * Keyword to filter tours and activities.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    filterByKeyword?: string;

    /**
     * Minimum price filter.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    filterByPriceMin?: number;

    /**
     * Maximum price filter.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    filterByPriceMax?: number;

    /**
     * Minimum distance filter.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    filterByDistanceMin?: number;

    /**
     * Maximum distance filter.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    filterByDistanceMax?: number;

    /**
     * Minimum rating filter.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    filterByRatingMin?: number;

    /**
     * Maximum rating filter.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    filterByRatingMax?: number;

    /**
     * Subcategories to filter tours and activities.
     *
     * @type {Array<string>}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    filterBySubcategories?: Array<string>;

    /**
     * Criteria to sort the search results.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    sortBy?: string;

    /**
     * Order to sort the results (ascending or descending).
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    sortOrder?: string;

    /**
     * Page number for pagination.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    page?: number;

    /**
     * Number of items per page.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    limit?: number;

    /**
     * Language of the tour offers.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    language?: string;

    /**
     * Currency in which prices are displayed.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    currency?: string;

    /**
     * Unit for distance measurement (mi/km) used in filters.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferRequestSchema
     */
    metric?: string;
}
