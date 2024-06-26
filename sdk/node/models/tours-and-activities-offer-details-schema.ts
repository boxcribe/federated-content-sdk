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
 * @interface ToursAndActivitiesOfferDetailsSchema
 */
export interface ToursAndActivitiesOfferDetailsSchema {

    /**
     * Identifier of the individual offer.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    offerId?: string;

    /**
     * Identifier provided by the supplier for the offer.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    supplierOfferId?: string;

    /**
     * Index of the offer for ordering.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    offerIndex?: number;

    /**
     * Tax applied on the offer.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    offerTax?: number;

    /**
     * Price of the offer.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    offerPrice?: number;

    /**
     * Currency of the offer price.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    offerCurrency?: string;

    /**
     * Cancellation policies applicable to the offer.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    offerCancelationPolicies?: string;

    /**
     * Date of the tour.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    date?: string;

    /**
     * Number of adults attending.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    adults?: number;

    /**
     * Number of children attending.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    children?: number;

    /**
     * Name of the tour.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourName?: string;

    /**
     * Description of the tour.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourDescription?: string;

    /**
     * Address where the tour will take place.
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourAddress?: string;

    /**
     * Latitude for the tour location.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourLatitude?: number;

    /**
     * Longitude for the tour location.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourLongitude?: number;

    /**
     * Distance covered by the tour.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourDistance?: number;

    /**
     * Metric for measuring distance (miles or kilometers).
     *
     * @type {string}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourDistanceMetric?: string;

    /**
     * Array of images related to the tour.
     *
     * @type {Array<string>}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourImages?: Array<string>;

    /**
     * Rating of the tour.
     *
     * @type {number}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourRating?: number;

    /**
     * Array of reviews for the tour.
     *
     * @type {Array<string>}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourReviews?: Array<string>;

    /**
     * Subcategories of the tour.
     *
     * @type {Array<string>}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    tourSubcategories?: Array<string>;

    /**
     * Questions related to booking the tour.
     *
     * @type {Array<string>}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    bookingQuestions?: Array<string>;

    /**
     * Array of ToursAndActivitiesVariantSchema.
     *
     * @type {Array<any>}
     * @memberof ToursAndActivitiesOfferDetailsSchema
     */
    variants?: Array<any>;
}
