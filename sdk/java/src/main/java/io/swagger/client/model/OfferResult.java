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

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.client.model.OfferResultNormalizedResponse;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.UUID;
/**
 * OfferResult
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class OfferResult {
  @SerializedName("id")
  private UUID id = null;

  @SerializedName("offer_request_id")
  private UUID offerRequestId = null;

  @SerializedName("normalized_response")
  private OfferResultNormalizedResponse normalizedResponse = null;

  @SerializedName("supplier_response")
  private Object supplierResponse = null;

  public OfferResult id(UUID id) {
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @Schema(description = "")
  public UUID getId() {
    return id;
  }

  public void setId(UUID id) {
    this.id = id;
  }

  public OfferResult offerRequestId(UUID offerRequestId) {
    this.offerRequestId = offerRequestId;
    return this;
  }

   /**
   * Get offerRequestId
   * @return offerRequestId
  **/
  @Schema(description = "")
  public UUID getOfferRequestId() {
    return offerRequestId;
  }

  public void setOfferRequestId(UUID offerRequestId) {
    this.offerRequestId = offerRequestId;
  }

  public OfferResult normalizedResponse(OfferResultNormalizedResponse normalizedResponse) {
    this.normalizedResponse = normalizedResponse;
    return this;
  }

   /**
   * Get normalizedResponse
   * @return normalizedResponse
  **/
  @Schema(description = "")
  public OfferResultNormalizedResponse getNormalizedResponse() {
    return normalizedResponse;
  }

  public void setNormalizedResponse(OfferResultNormalizedResponse normalizedResponse) {
    this.normalizedResponse = normalizedResponse;
  }

  public OfferResult supplierResponse(Object supplierResponse) {
    this.supplierResponse = supplierResponse;
    return this;
  }

   /**
   * Offer Request Raw Supplier Boxcribe API Response
   * @return supplierResponse
  **/
  @Schema(description = "Offer Request Raw Supplier Boxcribe API Response")
  public Object getSupplierResponse() {
    return supplierResponse;
  }

  public void setSupplierResponse(Object supplierResponse) {
    this.supplierResponse = supplierResponse;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OfferResult offerResult = (OfferResult) o;
    return Objects.equals(this.id, offerResult.id) &&
        Objects.equals(this.offerRequestId, offerResult.offerRequestId) &&
        Objects.equals(this.normalizedResponse, offerResult.normalizedResponse) &&
        Objects.equals(this.supplierResponse, offerResult.supplierResponse);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, offerRequestId, normalizedResponse, supplierResponse);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OfferResult {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    offerRequestId: ").append(toIndentedString(offerRequestId)).append("\n");
    sb.append("    normalizedResponse: ").append(toIndentedString(normalizedResponse)).append("\n");
    sb.append("    supplierResponse: ").append(toIndentedString(supplierResponse)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
