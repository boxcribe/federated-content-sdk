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

import io.swagger.client.model.CategoriesBody;
import io.swagger.client.model.CategoriesIdBody;
import io.swagger.client.model.Category;
import io.swagger.client.model.Error;
import io.swagger.client.model.InlineResponse2004;
import org.junit.Test;
import org.junit.Ignore;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


/**
 * API tests for CategoriesApi
 */
@Ignore
public class CategoriesApiTest {

    private final CategoriesApi api = new CategoriesApi();

    /**
     * Get categories
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void categoriesGetTest() throws Exception {
        String sort = null;
        Integer limit = null;
        Integer page = null;
        InlineResponse2004 response = api.categoriesGet(sort, limit, page);

        // TODO: test validations
    }
    /**
     * Delete category
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void categoriesIdDeleteTest() throws Exception {
        String id = null;
        api.categoriesIdDelete(id);

        // TODO: test validations
    }
    /**
     * Get category
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void categoriesIdGetTest() throws Exception {
        String id = null;
        Category response = api.categoriesIdGet(id);

        // TODO: test validations
    }
    /**
     * Update category
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void categoriesIdPatchTest() throws Exception {
        CategoriesIdBody body = null;
        String id = null;
        Category response = api.categoriesIdPatch(body, id);

        // TODO: test validations
    }
    /**
     * Create category
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void categoriesPostTest() throws Exception {
        CategoriesBody body = null;
        Category response = api.categoriesPost(body);

        // TODO: test validations
    }
}
