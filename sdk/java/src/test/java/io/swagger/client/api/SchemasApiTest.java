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

import io.swagger.client.model.Error;
import io.swagger.client.model.InlineResponse20010;
import io.swagger.client.model.InlineResponse20011;
import io.swagger.client.model.SchemasBody;
import io.swagger.client.model.SchemasIdBody;
import java.util.UUID;
import org.junit.Test;
import org.junit.Ignore;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


/**
 * API tests for SchemasApi
 */
@Ignore
public class SchemasApiTest {

    private final SchemasApi api = new SchemasApi();

    /**
     * Get schemas
     *
     * Retrieve a list of schemas with the ability to filter by tenant, category, sort, limit, or page.
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void schemasGetTest() throws Exception {
        UUID tenant = null;
        UUID category = null;
        String sort = null;
        Integer limit = null;
        Integer page = null;
        InlineResponse20010 response = api.schemasGet(tenant, category, sort, limit, page);

        // TODO: test validations
    }
    /**
     * Get schemas grouped by endpoint
     *
     * Retrieve a list of schemas grouped by their endpoint with the ability to filter by tenant, category, sort, limit, or page.
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void schemasGroupedByEndpointGetTest() throws Exception {
        UUID tenant = null;
        UUID category = null;
        String sort = null;
        Integer limit = null;
        Integer page = null;
        InlineResponse20011 response = api.schemasGroupedByEndpointGet(tenant, category, sort, limit, page);

        // TODO: test validations
    }
    /**
     * Delete schema
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void schemasIdDeleteTest() throws Exception {
        String id = null;
        api.schemasIdDelete(id);

        // TODO: test validations
    }
    /**
     * Get schema
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void schemasIdGetTest() throws Exception {
        String id = null;
        io.swagger.v3.oas.annotations.media.Schema response = api.schemasIdGet(id);

        // TODO: test validations
    }
    /**
     * Update schema
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void schemasIdPatchTest() throws Exception {
        SchemasIdBody body = null;
        String id = null;
        io.swagger.v3.oas.annotations.media.Schema response = api.schemasIdPatch(body, id);

        // TODO: test validations
    }
    /**
     * Create schema
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void schemasPostTest() throws Exception {
        SchemasBody body = null;
        io.swagger.v3.oas.annotations.media.Schema response = api.schemasPost(body);

        // TODO: test validations
    }
}
