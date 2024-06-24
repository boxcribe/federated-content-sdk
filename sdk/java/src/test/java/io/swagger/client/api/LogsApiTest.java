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
import io.swagger.client.model.InlineResponse2008;
import io.swagger.client.model.Log;
import io.swagger.client.model.LogsBody;
import io.swagger.client.model.LogsIdBody;
import org.junit.Test;
import org.junit.Ignore;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


/**
 * API tests for LogsApi
 */
@Ignore
public class LogsApiTest {

    private final LogsApi api = new LogsApi();

    /**
     * Get logs
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void logsGetTest() throws Exception {
        String sort = null;
        Integer limit = null;
        Integer page = null;
        InlineResponse2008 response = api.logsGet(sort, limit, page);

        // TODO: test validations
    }
    /**
     * Delete log
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void logsIdDeleteTest() throws Exception {
        String id = null;
        api.logsIdDelete(id);

        // TODO: test validations
    }
    /**
     * Get log
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void logsIdGetTest() throws Exception {
        String id = null;
        Log response = api.logsIdGet(id);

        // TODO: test validations
    }
    /**
     * Update log
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void logsIdPatchTest() throws Exception {
        LogsIdBody body = null;
        String id = null;
        Log response = api.logsIdPatch(body, id);

        // TODO: test validations
    }
    /**
     * Create log
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void logsPostTest() throws Exception {
        LogsBody body = null;
        Log response = api.logsPost(body);

        // TODO: test validations
    }
}