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

import { TransportOfferResponseItemSchema } from './transport-offer-response-item-schema';
 /**
 * 
 *
 * @export
 * @interface TransportOfferResponseSchema
 */
export interface TransportOfferResponseSchema {

    /**
     * Identifier of the company.
     *
     * @type {string}
     * @memberof TransportOfferResponseSchema
     */
    companyId?: string;

    /**
     * Identifier of the tenant.
     *
     * @type {string}
     * @memberof TransportOfferResponseSchema
     */
    tenantId?: string;

    /**
     * Category identifier.
     *
     * @type {string}
     * @memberof TransportOfferResponseSchema
     */
    categoryId?: string;

    /**
     * Supplier identifier.
     *
     * @type {string}
     * @memberof TransportOfferResponseSchema
     */
    supplierId?: string;

    /**
     * Current page of the response.
     *
     * @type {number}
     * @memberof TransportOfferResponseSchema
     */
    page?: number;

    /**
     * Limit of items per page in the response.
     *
     * @type {number}
     * @memberof TransportOfferResponseSchema
     */
    limit?: number;

    /**
     * Total number of items available.
     *
     * @type {number}
     * @memberof TransportOfferResponseSchema
     */
    total?: number;

    /**
     * Array of TransportOfferResponseItemSchema detailing individual offers.
     *
     * @type {Array<any>}
     * @memberof TransportOfferResponseSchema
     */
    offers?: Array<any>;
}