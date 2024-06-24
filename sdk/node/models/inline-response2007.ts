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

import { Integration } from './integration';
 /**
 * 
 *
 * @export
 * @interface InlineResponse2007
 */
export interface InlineResponse2007 {

    /**
     * @type {Array<Integration>}
     * @memberof InlineResponse2007
     */
    results?: Array<Integration>;

    /**
     * @type {number}
     * @memberof InlineResponse2007
     * @example 1
     */
    page?: number;

    /**
     * @type {number}
     * @memberof InlineResponse2007
     * @example 10
     */
    limit?: number;

    /**
     * @type {number}
     * @memberof InlineResponse2007
     * @example 1
     */
    totalPages?: number;

    /**
     * @type {number}
     * @memberof InlineResponse2007
     * @example 1
     */
    totalResults?: number;
}
