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
 * @interface BookingPassengerExtraBagSchema
 */
export interface BookingPassengerExtraBagSchema {

    /**
     * Identifier of the passenger with extra baggage.
     *
     * @type {string}
     * @memberof BookingPassengerExtraBagSchema
     */
    passengerId?: string;

    /**
     * Identifier of the flight leg associated with the extra baggage.
     *
     * @type {string}
     * @memberof BookingPassengerExtraBagSchema
     */
    legId?: string;

    /**
     * Identifier of the flight segment associated with the extra baggage.
     *
     * @type {string}
     * @memberof BookingPassengerExtraBagSchema
     */
    segmentId?: string;

    /**
     * Type of bag added as extra baggage.
     *
     * @type {string}
     * @memberof BookingPassengerExtraBagSchema
     */
    bagType?: string;

    /**
     * Quantity of the extra bags.
     *
     * @type {number}
     * @memberof BookingPassengerExtraBagSchema
     */
    bagQuantity?: number;
}
