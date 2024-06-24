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

import { FlightBookingPassengerSchema } from './flight-booking-passenger-schema';
import { FlightCreateBookingCustomerSchema } from './flight-create-booking-customer-schema';
import { FlightCreateBookingPaymentSchema } from './flight-create-booking-payment-schema';
 /**
 * 
 *
 * @export
 * @interface FlightCreateBookingRequestSchema
 */
export interface FlightCreateBookingRequestSchema {

    /**
     * Identifier of the offer for which booking is initiated.
     *
     * @type {string}
     * @memberof FlightCreateBookingRequestSchema
     */
    offerId?: string;

    /**
     * Array of FlightBookingPassengerSchema detailing passenger information.
     *
     * @type {Array<FlightBookingPassengerSchema>}
     * @memberof FlightCreateBookingRequestSchema
     */
    passengers?: Array<FlightBookingPassengerSchema>;

    /**
     * @type {any}
     * @memberof FlightCreateBookingRequestSchema
     */
    customer?: any;

    /**
     * @type {any}
     * @memberof FlightCreateBookingRequestSchema
     */
    payment?: any;
}