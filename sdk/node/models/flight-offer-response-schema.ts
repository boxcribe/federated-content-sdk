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

import { FlightOfferResponseItemSchema } from './flight-offer-response-item-schema';
 /**
 * 
 *
 * @export
 * @interface FlightOfferResponseSchema
 */
export interface FlightOfferResponseSchema {

    /**
     * Identifier for the company making the offer.
     *
     * @type {string}
     * @memberof FlightOfferResponseSchema
     */
    companyId?: string;

    /**
     * Identifier for the tenant.
     *
     * @type {string}
     * @memberof FlightOfferResponseSchema
     */
    tenantId?: string;

    /**
     * Identifier for the category of the offer.
     *
     * @type {string}
     * @memberof FlightOfferResponseSchema
     */
    categoryId?: string;

    /**
     * Identifier for the supplier of the offer.
     *
     * @type {string}
     * @memberof FlightOfferResponseSchema
     */
    supplierId?: string;

    /**
     * Tax applied to the offer.
     *
     * @type {number}
     * @memberof FlightOfferResponseSchema
     */
    offerTax?: number;

    /**
     * Array of FlightOfferResponseItemSchema detailing individual offers.
     *
     * @type {Array<FlightOfferResponseItemSchema>}
     * @memberof FlightOfferResponseSchema
     */
    offers?: Array<FlightOfferResponseItemSchema>;

    /**
     * Current page in pagination.
     *
     * @type {number}
     * @memberof FlightOfferResponseSchema
     */
    page?: number;

    /**
     * Page size in pagination.
     *
     * @type {number}
     * @memberof FlightOfferResponseSchema
     */
    limit?: number;

    /**
     * Total number of records available.
     *
     * @type {number}
     * @memberof FlightOfferResponseSchema
     */
    total?: number;
}
