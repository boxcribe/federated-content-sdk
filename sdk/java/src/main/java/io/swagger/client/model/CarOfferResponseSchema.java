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
import io.swagger.client.model.CarOfferResponseItemSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;
/**
 * CarOfferResponseSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class CarOfferResponseSchema {
  @SerializedName("company_id")
  private UUID companyId = null;

  @SerializedName("tenant_id")
  private UUID tenantId = null;

  @SerializedName("category_id")
  private UUID categoryId = null;

  @SerializedName("supplier_id")
  private UUID supplierId = null;

  @SerializedName("offers")
  private List<CarOfferResponseItemSchema> offers = null;

  @SerializedName("page")
  private Integer page = null;

  @SerializedName("limit")
  private Integer limit = null;

  @SerializedName("total")
  private Integer total = null;

  public CarOfferResponseSchema companyId(UUID companyId) {
    this.companyId = companyId;
    return this;
  }

   /**
   * Identifier for the company offering the rental.
   * @return companyId
  **/
  @Schema(description = "Identifier for the company offering the rental.")
  public UUID getCompanyId() {
    return companyId;
  }

  public void setCompanyId(UUID companyId) {
    this.companyId = companyId;
  }

  public CarOfferResponseSchema tenantId(UUID tenantId) {
    this.tenantId = tenantId;
    return this;
  }

   /**
   * Identifier for the tenant.
   * @return tenantId
  **/
  @Schema(description = "Identifier for the tenant.")
  public UUID getTenantId() {
    return tenantId;
  }

  public void setTenantId(UUID tenantId) {
    this.tenantId = tenantId;
  }

  public CarOfferResponseSchema categoryId(UUID categoryId) {
    this.categoryId = categoryId;
    return this;
  }

   /**
   * Identifier for the category of the offer.
   * @return categoryId
  **/
  @Schema(description = "Identifier for the category of the offer.")
  public UUID getCategoryId() {
    return categoryId;
  }

  public void setCategoryId(UUID categoryId) {
    this.categoryId = categoryId;
  }

  public CarOfferResponseSchema supplierId(UUID supplierId) {
    this.supplierId = supplierId;
    return this;
  }

   /**
   * Identifier for the supplier of the offer.
   * @return supplierId
  **/
  @Schema(description = "Identifier for the supplier of the offer.")
  public UUID getSupplierId() {
    return supplierId;
  }

  public void setSupplierId(UUID supplierId) {
    this.supplierId = supplierId;
  }

  public CarOfferResponseSchema offers(List<CarOfferResponseItemSchema> offers) {
    this.offers = offers;
    return this;
  }

  public CarOfferResponseSchema addOffersItem(CarOfferResponseItemSchema offersItem) {
    if (this.offers == null) {
      this.offers = new ArrayList<CarOfferResponseItemSchema>();
    }
    this.offers.add(offersItem);
    return this;
  }

   /**
   * Array of CarOfferResponseItemSchema detailing individual car offers.
   * @return offers
  **/
  @Schema(description = "Array of CarOfferResponseItemSchema detailing individual car offers.")
  public List<CarOfferResponseItemSchema> getOffers() {
    return offers;
  }

  public void setOffers(List<CarOfferResponseItemSchema> offers) {
    this.offers = offers;
  }

  public CarOfferResponseSchema page(Integer page) {
    this.page = page;
    return this;
  }

   /**
   * Current page in pagination.
   * @return page
  **/
  @Schema(description = "Current page in pagination.")
  public Integer getPage() {
    return page;
  }

  public void setPage(Integer page) {
    this.page = page;
  }

  public CarOfferResponseSchema limit(Integer limit) {
    this.limit = limit;
    return this;
  }

   /**
   * Page size in pagination.
   * @return limit
  **/
  @Schema(description = "Page size in pagination.")
  public Integer getLimit() {
    return limit;
  }

  public void setLimit(Integer limit) {
    this.limit = limit;
  }

  public CarOfferResponseSchema total(Integer total) {
    this.total = total;
    return this;
  }

   /**
   * Total number of records available.
   * @return total
  **/
  @Schema(description = "Total number of records available.")
  public Integer getTotal() {
    return total;
  }

  public void setTotal(Integer total) {
    this.total = total;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CarOfferResponseSchema carOfferResponseSchema = (CarOfferResponseSchema) o;
    return Objects.equals(this.companyId, carOfferResponseSchema.companyId) &&
        Objects.equals(this.tenantId, carOfferResponseSchema.tenantId) &&
        Objects.equals(this.categoryId, carOfferResponseSchema.categoryId) &&
        Objects.equals(this.supplierId, carOfferResponseSchema.supplierId) &&
        Objects.equals(this.offers, carOfferResponseSchema.offers) &&
        Objects.equals(this.page, carOfferResponseSchema.page) &&
        Objects.equals(this.limit, carOfferResponseSchema.limit) &&
        Objects.equals(this.total, carOfferResponseSchema.total);
  }

  @Override
  public int hashCode() {
    return Objects.hash(companyId, tenantId, categoryId, supplierId, offers, page, limit, total);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CarOfferResponseSchema {\n");
    
    sb.append("    companyId: ").append(toIndentedString(companyId)).append("\n");
    sb.append("    tenantId: ").append(toIndentedString(tenantId)).append("\n");
    sb.append("    categoryId: ").append(toIndentedString(categoryId)).append("\n");
    sb.append("    supplierId: ").append(toIndentedString(supplierId)).append("\n");
    sb.append("    offers: ").append(toIndentedString(offers)).append("\n");
    sb.append("    page: ").append(toIndentedString(page)).append("\n");
    sb.append("    limit: ").append(toIndentedString(limit)).append("\n");
    sb.append("    total: ").append(toIndentedString(total)).append("\n");
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