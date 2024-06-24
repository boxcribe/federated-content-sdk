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

import io.swagger.client.model.CompaniesBody;
import io.swagger.client.model.CompaniesIdBody;
import io.swagger.client.model.Company;
import io.swagger.client.model.Error;
import io.swagger.client.model.InlineResponse2005;
import org.junit.Test;
import org.junit.Ignore;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


/**
 * API tests for CompaniesApi
 */
@Ignore
public class CompaniesApiTest {

    private final CompaniesApi api = new CompaniesApi();

    /**
     * Get companies
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void companiesGetTest() throws Exception {
        String sort = null;
        Integer limit = null;
        Integer page = null;
        InlineResponse2005 response = api.companiesGet(sort, limit, page);

        // TODO: test validations
    }
    /**
     * Delete company
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void companiesIdDeleteTest() throws Exception {
        String id = null;
        api.companiesIdDelete(id);

        // TODO: test validations
    }
    /**
     * Get company
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void companiesIdGetTest() throws Exception {
        String id = null;
        Company response = api.companiesIdGet(id);

        // TODO: test validations
    }
    /**
     * Update company
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void companiesIdPatchTest() throws Exception {
        CompaniesIdBody body = null;
        String id = null;
        Company response = api.companiesIdPatch(body, id);

        // TODO: test validations
    }
    /**
     * Create company
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void companiesPostTest() throws Exception {
        CompaniesBody body = null;
        Company response = api.companiesPost(body);

        // TODO: test validations
    }
}