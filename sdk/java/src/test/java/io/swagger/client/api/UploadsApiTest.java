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

import java.io.File;
import io.swagger.client.model.InlineResponse200;
import org.junit.Test;
import org.junit.Ignore;


import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;


/**
 * API tests for UploadsApi
 */
@Ignore
public class UploadsApiTest {

    private final UploadsApi api = new UploadsApi();

    /**
     * Upload a file to AWS S3
     *
     * 
     *
     * @throws Exception
     *          if the Api call fails
     */
    @Test
    public void uploadPostTest() throws Exception {
        File file = null;
        InlineResponse200 response = api.uploadPost(file);

        // TODO: test validations
    }
}
