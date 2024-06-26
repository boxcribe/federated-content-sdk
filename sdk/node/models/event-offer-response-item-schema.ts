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
 * @interface EventOfferResponseItemSchema
 */
export interface EventOfferResponseItemSchema {

    /**
     * Unique identifier for the offer.
     *
     * @type {string}
     * @memberof EventOfferResponseItemSchema
     */
    offerId?: string;

    /**
     * Unique identifier for the supplier’s offer.
     *
     * @type {string}
     * @memberof EventOfferResponseItemSchema
     */
    supplierOfferId?: string;

    /**
     * Index of the offer for sorting purposes.
     *
     * @type {number}
     * @memberof EventOfferResponseItemSchema
     */
    offerIndex?: number;

    /**
     * Tax applied to the offer.
     *
     * @type {number}
     * @memberof EventOfferResponseItemSchema
     */
    offerTax?: number;

    /**
     * Price of the offer.
     *
     * @type {number}
     * @memberof EventOfferResponseItemSchema
     */
    offerPrice?: number;

    /**
     * Currency of the offer price.
     *
     * @type {string}
     * @memberof EventOfferResponseItemSchema
     */
    offerCurrency?: string;

    /**
     * Cancellation policies applicable to the offer.
     *
     * @type {string}
     * @memberof EventOfferResponseItemSchema
     */
    offerCancelationPolicies?: string;

    /**
     * Date of the event.
     *
     * @type {string}
     * @memberof EventOfferResponseItemSchema
     */
    date?: string;

    /**
     * Number of adults involved in the event.
     *
     * @type {number}
     * @memberof EventOfferResponseItemSchema
     */
    adults?: number;

    /**
     * Number of children involved in the event.
     *
     * @type {number}
     * @memberof EventOfferResponseItemSchema
     */
    children?: number;

    /**
     * Name of the event.
     *
     * @type {string}
     * @memberof EventOfferResponseItemSchema
     */
    eventName?: string;

    /**
     * Description of the event.
     *
     * @type {string}
     * @memberof EventOfferResponseItemSchema
     */
    eventDescription?: string;

    /**
     * Address where the event will take place.
     *
     * @type {string}
     * @memberof EventOfferResponseItemSchema
     */
    eventAddress?: string;

    /**
     * Latitude of the event location.
     *
     * @type {number}
     * @memberof EventOfferResponseItemSchema
     */
    eventLatitude?: number;

    /**
     * Longitude of the event location.
     *
     * @type {number}
     * @memberof EventOfferResponseItemSchema
     */
    eventLongitude?: number;

    /**
     * Distance to the event from a reference point.
     *
     * @type {number}
     * @memberof EventOfferResponseItemSchema
     */
    eventDistance?: number;

    /**
     * Metric used to measure the distance to the event.
     *
     * @type {string}
     * @memberof EventOfferResponseItemSchema
     */
    eventDistanceMetric?: string;

    /**
     * Images of the event.
     *
     * @type {Array<string>}
     * @memberof EventOfferResponseItemSchema
     */
    eventImages?: Array<string>;

    /**
     * Rating of the event.
     *
     * @type {number}
     * @memberof EventOfferResponseItemSchema
     */
    eventRating?: number;

    /**
     * Reviews of the event.
     *
     * @type {Array<string>}
     * @memberof EventOfferResponseItemSchema
     */
    eventReviews?: Array<string>;

    /**
     * Venue where the event will take place.
     *
     * @type {string}
     * @memberof EventOfferResponseItemSchema
     */
    eventVenue?: string;

    /**
     * Capacity of the venue.
     *
     * @type {number}
     * @memberof EventOfferResponseItemSchema
     */
    eventVenueCapacity?: number;

    /**
     * Performers at the event.
     *
     * @type {Array<string>}
     * @memberof EventOfferResponseItemSchema
     */
    eventPerformers?: Array<string>;

    /**
     * Subcategories of the event.
     *
     * @type {Array<string>}
     * @memberof EventOfferResponseItemSchema
     */
    eventSubcategories?: Array<string>;

    /**
     * Questions related to booking the event.
     *
     * @type {Array<string>}
     * @memberof EventOfferResponseItemSchema
     */
    bookingQuestions?: Array<string>;
}
