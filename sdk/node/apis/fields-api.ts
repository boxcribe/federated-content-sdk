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

import globalAxios, { AxiosResponse, AxiosInstance, AxiosRequestConfig } from 'axios';
import { Configuration } from '../configuration';
// Some imports not used depending on template conditions
// @ts-ignore
import { BASE_PATH, COLLECTION_FORMATS, RequestArgs, BaseAPI, RequiredError } from '../base';
import { Field } from '../models';
import { FieldsBody } from '../models';
import { FieldsIdBody } from '../models';
import { InlineResponse2006 } from '../models';
/**
 * FieldsApi - axios parameter creator
 * @export
 */
export const FieldsApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.
         * @summary Get fields
         * @param {string} [tenant] Get all fields for a Tenant ID
         * @param {string} [schema] Get all fields for a Schema ID
         * @param {string} [sort] sort by query in the form of field:desc/asc (ex. name:asc)
         * @param {number} [limit] Maximum number of fields
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        fieldsGet: async (tenant?: string, schema?: string, sort?: string, limit?: number, page?: number, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/fields`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication bearerAuth required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            if (tenant !== undefined) {
                localVarQueryParameter['tenant'] = tenant;
            }

            if (schema !== undefined) {
                localVarQueryParameter['schema'] = schema;
            }

            if (sort !== undefined) {
                localVarQueryParameter['sort'] = sort;
            }

            if (limit !== undefined) {
                localVarQueryParameter['limit'] = limit;
            }

            if (page !== undefined) {
                localVarQueryParameter['page'] = page;
            }

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Delete field
         * @param {string} id Field id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        fieldsIdDelete: async (id: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'id' is not null or undefined
            if (id === null || id === undefined) {
                throw new RequiredError('id','Required parameter id was null or undefined when calling fieldsIdDelete.');
            }
            const localVarPath = `/fields/{id}`
                .replace(`{${"id"}}`, encodeURIComponent(String(id)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'DELETE', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication bearerAuth required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Get field
         * @param {string} id Field id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        fieldsIdGet: async (id: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'id' is not null or undefined
            if (id === null || id === undefined) {
                throw new RequiredError('id','Required parameter id was null or undefined when calling fieldsIdGet.');
            }
            const localVarPath = `/fields/{id}`
                .replace(`{${"id"}}`, encodeURIComponent(String(id)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'GET', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication bearerAuth required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Update field
         * @param {FieldsIdBody} body 
         * @param {string} id Field id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        fieldsIdPatch: async (body: FieldsIdBody, id: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'body' is not null or undefined
            if (body === null || body === undefined) {
                throw new RequiredError('body','Required parameter body was null or undefined when calling fieldsIdPatch.');
            }
            // verify required parameter 'id' is not null or undefined
            if (id === null || id === undefined) {
                throw new RequiredError('id','Required parameter id was null or undefined when calling fieldsIdPatch.');
            }
            const localVarPath = `/fields/{id}`
                .replace(`{${"id"}}`, encodeURIComponent(String(id)));
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'PATCH', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication bearerAuth required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            localVarHeaderParameter['Content-Type'] = 'application/json';

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            const needsSerialization = (typeof body !== "string") || localVarRequestOptions.headers['Content-Type'] === 'application/json';
            localVarRequestOptions.data =  needsSerialization ? JSON.stringify(body !== undefined ? body : {}) : (body || "");

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
        /**
         * 
         * @summary Create field
         * @param {FieldsBody} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        fieldsPost: async (body: FieldsBody, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'body' is not null or undefined
            if (body === null || body === undefined) {
                throw new RequiredError('body','Required parameter body was null or undefined when calling fieldsPost.');
            }
            const localVarPath = `/fields`;
            // use dummy base URL string because the URL constructor only accepts absolute URLs.
            const localVarUrlObj = new URL(localVarPath, 'https://example.com');
            let baseOptions;
            if (configuration) {
                baseOptions = configuration.baseOptions;
            }
            const localVarRequestOptions :AxiosRequestConfig = { method: 'POST', ...baseOptions, ...options};
            const localVarHeaderParameter = {} as any;
            const localVarQueryParameter = {} as any;

            // authentication bearerAuth required
            // http bearer authentication required
            if (configuration && configuration.accessToken) {
                const accessToken = typeof configuration.accessToken === 'function'
                    ? await configuration.accessToken()
                    : await configuration.accessToken;
                localVarHeaderParameter["Authorization"] = "Bearer " + accessToken;
            }

            localVarHeaderParameter['Content-Type'] = 'application/json';

            const query = new URLSearchParams(localVarUrlObj.search);
            for (const key in localVarQueryParameter) {
                query.set(key, localVarQueryParameter[key]);
            }
            for (const key in options.params) {
                query.set(key, options.params[key]);
            }
            localVarUrlObj.search = (new URLSearchParams(query)).toString();
            let headersFromBaseOptions = baseOptions && baseOptions.headers ? baseOptions.headers : {};
            localVarRequestOptions.headers = {...localVarHeaderParameter, ...headersFromBaseOptions, ...options.headers};
            const needsSerialization = (typeof body !== "string") || localVarRequestOptions.headers['Content-Type'] === 'application/json';
            localVarRequestOptions.data =  needsSerialization ? JSON.stringify(body !== undefined ? body : {}) : (body || "");

            return {
                url: localVarUrlObj.pathname + localVarUrlObj.search + localVarUrlObj.hash,
                options: localVarRequestOptions,
            };
        },
    }
};

/**
 * FieldsApi - functional programming interface
 * @export
 */
export const FieldsApiFp = function(configuration?: Configuration) {
    return {
        /**
         * Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.
         * @summary Get fields
         * @param {string} [tenant] Get all fields for a Tenant ID
         * @param {string} [schema] Get all fields for a Schema ID
         * @param {string} [sort] sort by query in the form of field:desc/asc (ex. name:asc)
         * @param {number} [limit] Maximum number of fields
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async fieldsGet(tenant?: string, schema?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<InlineResponse2006>>> {
            const localVarAxiosArgs = await FieldsApiAxiosParamCreator(configuration).fieldsGet(tenant, schema, sort, limit, page, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Delete field
         * @param {string} id Field id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async fieldsIdDelete(id: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<void>>> {
            const localVarAxiosArgs = await FieldsApiAxiosParamCreator(configuration).fieldsIdDelete(id, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Get field
         * @param {string} id Field id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async fieldsIdGet(id: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<Field>>> {
            const localVarAxiosArgs = await FieldsApiAxiosParamCreator(configuration).fieldsIdGet(id, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Update field
         * @param {FieldsIdBody} body 
         * @param {string} id Field id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async fieldsIdPatch(body: FieldsIdBody, id: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<Field>>> {
            const localVarAxiosArgs = await FieldsApiAxiosParamCreator(configuration).fieldsIdPatch(body, id, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Create field
         * @param {FieldsBody} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async fieldsPost(body: FieldsBody, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<Field>>> {
            const localVarAxiosArgs = await FieldsApiAxiosParamCreator(configuration).fieldsPost(body, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
    }
};

/**
 * FieldsApi - factory interface
 * @export
 */
export const FieldsApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    return {
        /**
         * Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.
         * @summary Get fields
         * @param {string} [tenant] Get all fields for a Tenant ID
         * @param {string} [schema] Get all fields for a Schema ID
         * @param {string} [sort] sort by query in the form of field:desc/asc (ex. name:asc)
         * @param {number} [limit] Maximum number of fields
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async fieldsGet(tenant?: string, schema?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig): Promise<AxiosResponse<InlineResponse2006>> {
            return FieldsApiFp(configuration).fieldsGet(tenant, schema, sort, limit, page, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Delete field
         * @param {string} id Field id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async fieldsIdDelete(id: string, options?: AxiosRequestConfig): Promise<AxiosResponse<void>> {
            return FieldsApiFp(configuration).fieldsIdDelete(id, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Get field
         * @param {string} id Field id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async fieldsIdGet(id: string, options?: AxiosRequestConfig): Promise<AxiosResponse<Field>> {
            return FieldsApiFp(configuration).fieldsIdGet(id, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Update field
         * @param {FieldsIdBody} body 
         * @param {string} id Field id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async fieldsIdPatch(body: FieldsIdBody, id: string, options?: AxiosRequestConfig): Promise<AxiosResponse<Field>> {
            return FieldsApiFp(configuration).fieldsIdPatch(body, id, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Create field
         * @param {FieldsBody} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async fieldsPost(body: FieldsBody, options?: AxiosRequestConfig): Promise<AxiosResponse<Field>> {
            return FieldsApiFp(configuration).fieldsPost(body, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * FieldsApi - object-oriented interface
 * @export
 * @class FieldsApi
 * @extends {BaseAPI}
 */
export class FieldsApi extends BaseAPI {
    /**
     * Retrieve a list of fields with the ability to filter by tenant, schema, sort, limit or page.
     * @summary Get fields
     * @param {string} [tenant] Get all fields for a Tenant ID
     * @param {string} [schema] Get all fields for a Schema ID
     * @param {string} [sort] sort by query in the form of field:desc/asc (ex. name:asc)
     * @param {number} [limit] Maximum number of fields
     * @param {number} [page] Page number
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof FieldsApi
     */
    public async fieldsGet(tenant?: string, schema?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig) : Promise<AxiosResponse<InlineResponse2006>> {
        return FieldsApiFp(this.configuration).fieldsGet(tenant, schema, sort, limit, page, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Delete field
     * @param {string} id Field id
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof FieldsApi
     */
    public async fieldsIdDelete(id: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<void>> {
        return FieldsApiFp(this.configuration).fieldsIdDelete(id, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Get field
     * @param {string} id Field id
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof FieldsApi
     */
    public async fieldsIdGet(id: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<Field>> {
        return FieldsApiFp(this.configuration).fieldsIdGet(id, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Update field
     * @param {FieldsIdBody} body 
     * @param {string} id Field id
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof FieldsApi
     */
    public async fieldsIdPatch(body: FieldsIdBody, id: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<Field>> {
        return FieldsApiFp(this.configuration).fieldsIdPatch(body, id, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Create field
     * @param {FieldsBody} body 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof FieldsApi
     */
    public async fieldsPost(body: FieldsBody, options?: AxiosRequestConfig) : Promise<AxiosResponse<Field>> {
        return FieldsApiFp(this.configuration).fieldsPost(body, options).then((request) => request(this.axios, this.basePath));
    }
}