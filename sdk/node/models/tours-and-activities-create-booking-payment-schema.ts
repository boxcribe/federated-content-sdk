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
 * @interface ToursAndActivitiesCreateBookingPaymentSchema
 */
export interface ToursAndActivitiesCreateBookingPaymentSchema {

    /**
     * Credit card number.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingPaymentSchema
     */
    cardNumber?: string;

    /**
     * Month of card expiration.
     *
     * @type {number}
     * @memberof ToursAndActivitiesCreateBookingPaymentSchema
     */
    cardExpirationMonth?: number;

    /**
     * Year of card expiration.
     *
     * @type {number}
     * @memberof ToursAndActivitiesCreateBookingPaymentSchema
     */
    cardExpirationYear?: number;

    /**
     * Card security code.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingPaymentSchema
     */
    cardCvv?: string;

    /**
     * Name on credit card.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingPaymentSchema
     */
    cardName?: string;

    /**
     * Billing address for the card.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingPaymentSchema
     */
    billingAddress?: string;

    /**
     * City of the billing address.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingPaymentSchema
     */
    billingCity?: string;

    /**
     * State of the billing address.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingPaymentSchema
     */
    billingState?: string;

    /**
     * Postal code of the billing address.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingPaymentSchema
     */
    billingZip?: string;

    /**
     * Country of the billing address.
     *
     * @type {string}
     * @memberof ToursAndActivitiesCreateBookingPaymentSchema
     */
    billingCountry?: string;
}