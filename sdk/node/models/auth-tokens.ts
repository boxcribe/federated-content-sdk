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

import { Token } from './token';
 /**
 * 
 *
 * @export
 * @interface AuthTokens
 */
export interface AuthTokens {

    /**
     * @type {Token}
     * @memberof AuthTokens
     */
    access?: Token;

    /**
     * @type {Token}
     * @memberof AuthTokens
     */
    refresh?: Token;
}
