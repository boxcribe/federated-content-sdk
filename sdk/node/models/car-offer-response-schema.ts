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

import { CarOfferResponseItemSchema } from './car-offer-response-item-schema';
 /**
 * 
 *
 * @export
 * @interface CarOfferResponseSchema
 */
export interface CarOfferResponseSchema {

    /**
     * Identifier for the company offering the rental.
     *
     * @type {string}
     * @memberof CarOfferResponseSchema
     */
    companyId?: string;

    /**
     * Identifier for the tenant.
     *
     * @type {string}
     * @memberof CarOfferResponseSchema
     */
    tenantId?: string;

    /**
     * Identifier for the category of the offer.
     *
     * @type {string}
     * @memberof CarOfferResponseSchema
     */
    categoryId?: string;

    /**
     * Identifier for the supplier of the offer.
     *
     * @type {string}
     * @memberof CarOfferResponseSchema
     */
    supplierId?: string;

    /**
     * Array of CarOfferResponseItemSchema detailing individual car offers.
     *
     * @type {Array<any>}
     * @memberof CarOfferResponseSchema
     */
    offers?: Array<any>;

    /**
     * Current page in pagination.
     *
     * @type {number}
     * @memberof CarOfferResponseSchema
     */
    page?: number;

    /**
     * Page size in pagination.
     *
     * @type {number}
     * @memberof CarOfferResponseSchema
     */
    limit?: number;

    /**
     * Total number of records available.
     *
     * @type {number}
     * @memberof CarOfferResponseSchema
     */
    total?: number;
}
