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

import { ToursAndActivitiesVariantSchema } from './tours-and-activities-variant-schema';
 /**
 * 
 *
 * @export
 * @interface ToursAndActivitiesGetOfferAvailabilityResponse
 */
export interface ToursAndActivitiesGetOfferAvailabilityResponse {

    /**
     * Identifier of the individual offer.
     *
     * @type {string}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    offerId?: string;

    /**
     * Identifier provided by the supplier for the offer.
     *
     * @type {string}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    supplierOfferId?: string;

    /**
     * Index of the offer for ordering.
     *
     * @type {number}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    offerIndex?: number;

    /**
     * Tax applied on the offer.
     *
     * @type {number}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    offerTax?: number;

    /**
     * Price of the offer.
     *
     * @type {number}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    offerPrice?: number;

    /**
     * Currency of the offer price.
     *
     * @type {string}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    offerCurrency?: string;

    /**
     * Cancellation policies applicable to the offer.
     *
     * @type {string}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    offerCancelationPolicies?: string;

    /**
     * Date of the tour.
     *
     * @type {string}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    date?: string;

    /**
     * Number of adults attending.
     *
     * @type {number}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    adults?: number;

    /**
     * Number of children attending.
     *
     * @type {number}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    children?: number;

    /**
     * Name of the tour.
     *
     * @type {string}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourName?: string;

    /**
     * Description of the tour.
     *
     * @type {string}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourDescription?: string;

    /**
     * Address where the tour will take place.
     *
     * @type {string}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourAddress?: string;

    /**
     * Latitude for the tour location.
     *
     * @type {number}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourLatitude?: number;

    /**
     * Longitude for the tour location.
     *
     * @type {number}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourLongitude?: number;

    /**
     * Distance covered by the tour.
     *
     * @type {number}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourDistance?: number;

    /**
     * Metric for measuring distance (miles or kilometers).
     *
     * @type {string}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourDistanceMetric?: string;

    /**
     * Array of images related to the tour.
     *
     * @type {Array<string>}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourImages?: Array<string>;

    /**
     * Rating of the tour.
     *
     * @type {number}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourRating?: number;

    /**
     * Array of reviews for the tour.
     *
     * @type {Array<string>}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourReviews?: Array<string>;

    /**
     * Subcategories of the tour.
     *
     * @type {Array<string>}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    tourSubcategories?: Array<string>;

    /**
     * Questions related to booking the tour.
     *
     * @type {Array<string>}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    bookingQuestions?: Array<string>;

    /**
     * Array of ToursAndActivitiesVariantSchema.
     *
     * @type {Array<any>}
     * @memberof ToursAndActivitiesGetOfferAvailabilityResponse
     */
    variants?: Array<any>;
}
