/*
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

package io.swagger.client.api;

import io.swagger.client.model.ApiKey;
import io.swagger.client.model.ApikeysBody;
import io.swagger.client.model.ApikeysIdBody;
import io.swagger.client.model.Error;
import io.swagger.client.model.InlineResponse2002;
import org.junit.Test;
import org.junit.Ignore;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


/**
 * API tests for ApiKeysApi
 */
@Ignore
public class ApiKeysApiTest {

    private final ApiKeysApi api = new ApiKeysApi();

    /**
     * Get api keys
     *
     * Retrieve a list of api keys with the ability to filter by tenant, environment, sort, limit or page.
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void apikeysGetTest() throws Exception {
        String tenant = null;
        String environment = null;
        String sort = null;
        Integer limit = null;
        Integer page = null;
        InlineResponse2002 response = api.apikeysGet(tenant, environment, sort, limit, page);

        // TODO: test validations
    }
    /**
     * Delete api key
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void apikeysIdDeleteTest() throws Exception {
        String id = null;
        api.apikeysIdDelete(id);

        // TODO: test validations
    }
    /**
     * Get api key
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void apikeysIdGetTest() throws Exception {
        String id = null;
        ApiKey response = api.apikeysIdGet(id);

        // TODO: test validations
    }
    /**
     * Update api key
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void apikeysIdPatchTest() throws Exception {
        ApikeysIdBody body = null;
        String id = null;
        ApiKey response = api.apikeysIdPatch(body, id);

        // TODO: test validations
    }
    /**
     * Create api key
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void apikeysPostTest() throws Exception {
        ApikeysBody body = null;
        ApiKey response = api.apikeysPost(body);

        // TODO: test validations
    }
}
