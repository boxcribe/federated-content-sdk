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
 * @interface InlineResponse200
 */
export interface InlineResponse200 {

    /**
     * @type {string}
     * @memberof InlineResponse200
     * @example File uploaded successfully
     */
    message?: string;

    /**
     * @type {string}
     * @memberof InlineResponse200
     * @example https://your-bucket-name.s3.amazonaws.com/filename
     */
    filename?: string;
}