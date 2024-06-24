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
import io.swagger.client.model.HotelOfferResponseItemSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;
/**
 * HotelOfferResponseSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class HotelOfferResponseSchema {
  @SerializedName("company_id")
  private UUID companyId = null;

  @SerializedName("tenant_id")
  private UUID tenantId = null;

  @SerializedName("category_id")
  private UUID categoryId = null;

  @SerializedName("supplier_id")
  private UUID supplierId = null;

  @SerializedName("offer_tax")
  private Double offerTax = null;

  @SerializedName("offers")
  private List<HotelOfferResponseItemSchema> offers = null;

  @SerializedName("page")
  private Integer page = null;

  @SerializedName("limit")
  private Integer limit = null;

  @SerializedName("total")
  private Integer total = null;

  public HotelOfferResponseSchema companyId(UUID companyId) {
    this.companyId = companyId;
    return this;
  }

   /**
   * Identifier for the company making the offer.
   * @return companyId
  **/
  @Schema(description = "Identifier for the company making the offer.")
  public UUID getCompanyId() {
    return companyId;
  }

  public void setCompanyId(UUID companyId) {
    this.companyId = companyId;
  }

  public HotelOfferResponseSchema tenantId(UUID tenantId) {
    this.tenantId = tenantId;
    return this;
  }

   /**
   * Identifier for the tenant involved in the offer.
   * @return tenantId
  **/
  @Schema(description = "Identifier for the tenant involved in the offer.")
  public UUID getTenantId() {
    return tenantId;
  }

  public void setTenantId(UUID tenantId) {
    this.tenantId = tenantId;
  }

  public HotelOfferResponseSchema categoryId(UUID categoryId) {
    this.categoryId = categoryId;
    return this;
  }

   /**
   * Category identifier for the offer.
   * @return categoryId
  **/
  @Schema(description = "Category identifier for the offer.")
  public UUID getCategoryId() {
    return categoryId;
  }

  public void setCategoryId(UUID categoryId) {
    this.categoryId = categoryId;
  }

  public HotelOfferResponseSchema supplierId(UUID supplierId) {
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

  public HotelOfferResponseSchema offerTax(Double offerTax) {
    this.offerTax = offerTax;
    return this;
  }

   /**
   * Tax applied to the offer price.
   * @return offerTax
  **/
  @Schema(description = "Tax applied to the offer price.")
  public Double getOfferTax() {
    return offerTax;
  }

  public void setOfferTax(Double offerTax) {
    this.offerTax = offerTax;
  }

  public HotelOfferResponseSchema offers(List<HotelOfferResponseItemSchema> offers) {
    this.offers = offers;
    return this;
  }

  public HotelOfferResponseSchema addOffersItem(HotelOfferResponseItemSchema offersItem) {
    if (this.offers == null) {
      this.offers = new ArrayList<HotelOfferResponseItemSchema>();
    }
    this.offers.add(offersItem);
    return this;
  }

   /**
   * Array of offers detailed in the HotelOfferResponseItemSchema.
   * @return offers
  **/
  @Schema(description = "Array of offers detailed in the HotelOfferResponseItemSchema.")
  public List<HotelOfferResponseItemSchema> getOffers() {
    return offers;
  }

  public void setOffers(List<HotelOfferResponseItemSchema> offers) {
    this.offers = offers;
  }

  public HotelOfferResponseSchema page(Integer page) {
    this.page = page;
    return this;
  }

   /**
   * Current page in the pagination of offers.
   * @return page
  **/
  @Schema(description = "Current page in the pagination of offers.")
  public Integer getPage() {
    return page;
  }

  public void setPage(Integer page) {
    this.page = page;
  }

  public HotelOfferResponseSchema limit(Integer limit) {
    this.limit = limit;
    return this;
  }

   /**
   * Number of items per page in the offer list.
   * @return limit
  **/
  @Schema(description = "Number of items per page in the offer list.")
  public Integer getLimit() {
    return limit;
  }

  public void setLimit(Integer limit) {
    this.limit = limit;
  }

  public HotelOfferResponseSchema total(Integer total) {
    this.total = total;
    return this;
  }

   /**
   * Total number of offers available.
   * @return total
  **/
  @Schema(description = "Total number of offers available.")
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
    HotelOfferResponseSchema hotelOfferResponseSchema = (HotelOfferResponseSchema) o;
    return Objects.equals(this.companyId, hotelOfferResponseSchema.companyId) &&
        Objects.equals(this.tenantId, hotelOfferResponseSchema.tenantId) &&
        Objects.equals(this.categoryId, hotelOfferResponseSchema.categoryId) &&
        Objects.equals(this.supplierId, hotelOfferResponseSchema.supplierId) &&
        Objects.equals(this.offerTax, hotelOfferResponseSchema.offerTax) &&
        Objects.equals(this.offers, hotelOfferResponseSchema.offers) &&
        Objects.equals(this.page, hotelOfferResponseSchema.page) &&
        Objects.equals(this.limit, hotelOfferResponseSchema.limit) &&
        Objects.equals(this.total, hotelOfferResponseSchema.total);
  }

  @Override
  public int hashCode() {
    return Objects.hash(companyId, tenantId, categoryId, supplierId, offerTax, offers, page, limit, total);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class HotelOfferResponseSchema {\n");
    
    sb.append("    companyId: ").append(toIndentedString(companyId)).append("\n");
    sb.append("    tenantId: ").append(toIndentedString(tenantId)).append("\n");
    sb.append("    categoryId: ").append(toIndentedString(categoryId)).append("\n");
    sb.append("    supplierId: ").append(toIndentedString(supplierId)).append("\n");
    sb.append("    offerTax: ").append(toIndentedString(offerTax)).append("\n");
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
