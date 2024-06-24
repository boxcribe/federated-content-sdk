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
import { InlineResponse20010 } from '../models';
import { InlineResponse20011 } from '../models';
import { Schema } from '../models';
import { SchemasBody } from '../models';
import { SchemasIdBody } from '../models';
/**
 * SchemasApi - axios parameter creator
 * @export
 */
export const SchemasApiAxiosParamCreator = function (configuration?: Configuration) {
    return {
        /**
         * Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.
         * @summary Get schemas
         * @param {string} [tenant] Get all schemas for a Tenant ID
         * @param {string} [category] Get all schemas for a Category ID
         * @param {string} [sort] Sort by query in the form of field:desc/asc (ex. name:asc)
         * @param {number} [limit] Maximum number of schemas
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        schemasGet: async (tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/schemas`;
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

            if (category !== undefined) {
                localVarQueryParameter['category'] = category;
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
         * Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.
         * @summary Get schemas grouped by endpoint
         * @param {string} [tenant] Get all schemas for a Tenant ID
         * @param {string} [category] Get all schemas for a Category ID
         * @param {string} [sort] Sort by query in the form of field:desc/asc (ex. endpoint:asc)
         * @param {number} [limit] Maximum number of schemas
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        schemasGroupedByEndpointGet: async (tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            const localVarPath = `/schemas/groupedByEndpoint`;
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

            if (category !== undefined) {
                localVarQueryParameter['category'] = category;
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
         * @summary Delete schema
         * @param {string} id Schema id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        schemasIdDelete: async (id: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'id' is not null or undefined
            if (id === null || id === undefined) {
                throw new RequiredError('id','Required parameter id was null or undefined when calling schemasIdDelete.');
            }
            const localVarPath = `/schemas/{id}`
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
         * @summary Get schema
         * @param {string} id Schema id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        schemasIdGet: async (id: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'id' is not null or undefined
            if (id === null || id === undefined) {
                throw new RequiredError('id','Required parameter id was null or undefined when calling schemasIdGet.');
            }
            const localVarPath = `/schemas/{id}`
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
         * @summary Update schema
         * @param {SchemasIdBody} body 
         * @param {string} id Schema id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        schemasIdPatch: async (body: SchemasIdBody, id: string, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'body' is not null or undefined
            if (body === null || body === undefined) {
                throw new RequiredError('body','Required parameter body was null or undefined when calling schemasIdPatch.');
            }
            // verify required parameter 'id' is not null or undefined
            if (id === null || id === undefined) {
                throw new RequiredError('id','Required parameter id was null or undefined when calling schemasIdPatch.');
            }
            const localVarPath = `/schemas/{id}`
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
         * @summary Create schema
         * @param {SchemasBody} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        schemasPost: async (body: SchemasBody, options: AxiosRequestConfig = {}): Promise<RequestArgs> => {
            // verify required parameter 'body' is not null or undefined
            if (body === null || body === undefined) {
                throw new RequiredError('body','Required parameter body was null or undefined when calling schemasPost.');
            }
            const localVarPath = `/schemas`;
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
 * SchemasApi - functional programming interface
 * @export
 */
export const SchemasApiFp = function(configuration?: Configuration) {
    return {
        /**
         * Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.
         * @summary Get schemas
         * @param {string} [tenant] Get all schemas for a Tenant ID
         * @param {string} [category] Get all schemas for a Category ID
         * @param {string} [sort] Sort by query in the form of field:desc/asc (ex. name:asc)
         * @param {number} [limit] Maximum number of schemas
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasGet(tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<InlineResponse20010>>> {
            const localVarAxiosArgs = await SchemasApiAxiosParamCreator(configuration).schemasGet(tenant, category, sort, limit, page, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.
         * @summary Get schemas grouped by endpoint
         * @param {string} [tenant] Get all schemas for a Tenant ID
         * @param {string} [category] Get all schemas for a Category ID
         * @param {string} [sort] Sort by query in the form of field:desc/asc (ex. endpoint:asc)
         * @param {number} [limit] Maximum number of schemas
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasGroupedByEndpointGet(tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<InlineResponse20011>>> {
            const localVarAxiosArgs = await SchemasApiAxiosParamCreator(configuration).schemasGroupedByEndpointGet(tenant, category, sort, limit, page, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Delete schema
         * @param {string} id Schema id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasIdDelete(id: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<void>>> {
            const localVarAxiosArgs = await SchemasApiAxiosParamCreator(configuration).schemasIdDelete(id, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Get schema
         * @param {string} id Schema id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasIdGet(id: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<Schema>>> {
            const localVarAxiosArgs = await SchemasApiAxiosParamCreator(configuration).schemasIdGet(id, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Update schema
         * @param {SchemasIdBody} body 
         * @param {string} id Schema id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasIdPatch(body: SchemasIdBody, id: string, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<Schema>>> {
            const localVarAxiosArgs = await SchemasApiAxiosParamCreator(configuration).schemasIdPatch(body, id, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
        /**
         * 
         * @summary Create schema
         * @param {SchemasBody} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasPost(body: SchemasBody, options?: AxiosRequestConfig): Promise<(axios?: AxiosInstance, basePath?: string) => Promise<AxiosResponse<Schema>>> {
            const localVarAxiosArgs = await SchemasApiAxiosParamCreator(configuration).schemasPost(body, options);
            return (axios: AxiosInstance = globalAxios, basePath: string = BASE_PATH) => {
                const axiosRequestArgs :AxiosRequestConfig = {...localVarAxiosArgs.options, url: basePath + localVarAxiosArgs.url};
                return axios.request(axiosRequestArgs);
            };
        },
    }
};

/**
 * SchemasApi - factory interface
 * @export
 */
export const SchemasApiFactory = function (configuration?: Configuration, basePath?: string, axios?: AxiosInstance) {
    return {
        /**
         * Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.
         * @summary Get schemas
         * @param {string} [tenant] Get all schemas for a Tenant ID
         * @param {string} [category] Get all schemas for a Category ID
         * @param {string} [sort] Sort by query in the form of field:desc/asc (ex. name:asc)
         * @param {number} [limit] Maximum number of schemas
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasGet(tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig): Promise<AxiosResponse<InlineResponse20010>> {
            return SchemasApiFp(configuration).schemasGet(tenant, category, sort, limit, page, options).then((request) => request(axios, basePath));
        },
        /**
         * Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.
         * @summary Get schemas grouped by endpoint
         * @param {string} [tenant] Get all schemas for a Tenant ID
         * @param {string} [category] Get all schemas for a Category ID
         * @param {string} [sort] Sort by query in the form of field:desc/asc (ex. endpoint:asc)
         * @param {number} [limit] Maximum number of schemas
         * @param {number} [page] Page number
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasGroupedByEndpointGet(tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig): Promise<AxiosResponse<InlineResponse20011>> {
            return SchemasApiFp(configuration).schemasGroupedByEndpointGet(tenant, category, sort, limit, page, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Delete schema
         * @param {string} id Schema id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasIdDelete(id: string, options?: AxiosRequestConfig): Promise<AxiosResponse<void>> {
            return SchemasApiFp(configuration).schemasIdDelete(id, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Get schema
         * @param {string} id Schema id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasIdGet(id: string, options?: AxiosRequestConfig): Promise<AxiosResponse<Schema>> {
            return SchemasApiFp(configuration).schemasIdGet(id, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Update schema
         * @param {SchemasIdBody} body 
         * @param {string} id Schema id
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasIdPatch(body: SchemasIdBody, id: string, options?: AxiosRequestConfig): Promise<AxiosResponse<Schema>> {
            return SchemasApiFp(configuration).schemasIdPatch(body, id, options).then((request) => request(axios, basePath));
        },
        /**
         * 
         * @summary Create schema
         * @param {SchemasBody} body 
         * @param {*} [options] Override http request option.
         * @throws {RequiredError}
         */
        async schemasPost(body: SchemasBody, options?: AxiosRequestConfig): Promise<AxiosResponse<Schema>> {
            return SchemasApiFp(configuration).schemasPost(body, options).then((request) => request(axios, basePath));
        },
    };
};

/**
 * SchemasApi - object-oriented interface
 * @export
 * @class SchemasApi
 * @extends {BaseAPI}
 */
export class SchemasApi extends BaseAPI {
    /**
     * Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.
     * @summary Get schemas
     * @param {string} [tenant] Get all schemas for a Tenant ID
     * @param {string} [category] Get all schemas for a Category ID
     * @param {string} [sort] Sort by query in the form of field:desc/asc (ex. name:asc)
     * @param {number} [limit] Maximum number of schemas
     * @param {number} [page] Page number
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SchemasApi
     */
    public async schemasGet(tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig) : Promise<AxiosResponse<InlineResponse20010>> {
        return SchemasApiFp(this.configuration).schemasGet(tenant, category, sort, limit, page, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.
     * @summary Get schemas grouped by endpoint
     * @param {string} [tenant] Get all schemas for a Tenant ID
     * @param {string} [category] Get all schemas for a Category ID
     * @param {string} [sort] Sort by query in the form of field:desc/asc (ex. endpoint:asc)
     * @param {number} [limit] Maximum number of schemas
     * @param {number} [page] Page number
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SchemasApi
     */
    public async schemasGroupedByEndpointGet(tenant?: string, category?: string, sort?: string, limit?: number, page?: number, options?: AxiosRequestConfig) : Promise<AxiosResponse<InlineResponse20011>> {
        return SchemasApiFp(this.configuration).schemasGroupedByEndpointGet(tenant, category, sort, limit, page, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Delete schema
     * @param {string} id Schema id
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SchemasApi
     */
    public async schemasIdDelete(id: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<void>> {
        return SchemasApiFp(this.configuration).schemasIdDelete(id, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Get schema
     * @param {string} id Schema id
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SchemasApi
     */
    public async schemasIdGet(id: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<Schema>> {
        return SchemasApiFp(this.configuration).schemasIdGet(id, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Update schema
     * @param {SchemasIdBody} body 
     * @param {string} id Schema id
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SchemasApi
     */
    public async schemasIdPatch(body: SchemasIdBody, id: string, options?: AxiosRequestConfig) : Promise<AxiosResponse<Schema>> {
        return SchemasApiFp(this.configuration).schemasIdPatch(body, id, options).then((request) => request(this.axios, this.basePath));
    }
    /**
     * 
     * @summary Create schema
     * @param {SchemasBody} body 
     * @param {*} [options] Override http request option.
     * @throws {RequiredError}
     * @memberof SchemasApi
     */
    public async schemasPost(body: SchemasBody, options?: AxiosRequestConfig) : Promise<AxiosResponse<Schema>> {
        return SchemasApiFp(this.configuration).schemasPost(body, options).then((request) => request(this.axios, this.basePath));
    }
}