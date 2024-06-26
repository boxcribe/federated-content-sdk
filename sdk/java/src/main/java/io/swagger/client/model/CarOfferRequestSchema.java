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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import org.threeten.bp.LocalDate;
/**
 * CarOfferRequestSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class CarOfferRequestSchema {
  @SerializedName("pickup_location_latitude")
  private Float pickupLocationLatitude = null;

  @SerializedName("pickup_location_longitude")
  private Float pickupLocationLongitude = null;

  @SerializedName("pickup_date")
  private LocalDate pickupDate = null;

  @SerializedName("pickup_time")
  private String pickupTime = null;

  @SerializedName("dropoff_location_latitude")
  private Float dropoffLocationLatitude = null;

  @SerializedName("dropoff_location_longitude")
  private Float dropoffLocationLongitude = null;

  @SerializedName("dropoff_date")
  private LocalDate dropoffDate = null;

  @SerializedName("dropoff_time")
  private String dropoffTime = null;

  @SerializedName("filter_by_keyword")
  private String filterByKeyword = null;

  @SerializedName("filter_by_price_min")
  private BigDecimal filterByPriceMin = null;

  @SerializedName("filter_by_price_max")
  private BigDecimal filterByPriceMax = null;

  @SerializedName("filter_by_distance_min")
  private Integer filterByDistanceMin = null;

  @SerializedName("filter_by_distance_max")
  private Integer filterByDistanceMax = null;

  @SerializedName("filter_by_rating_min")
  private Integer filterByRatingMin = null;

  @SerializedName("filter_by_rating_max")
  private Integer filterByRatingMax = null;

  @SerializedName("filter_by_passengers_min")
  private Integer filterByPassengersMin = null;

  @SerializedName("filter_by_passengers_max")
  private Integer filterByPassengersMax = null;

  @SerializedName("filter_by_type")
  private List<String> filterByType = null;

  @SerializedName("filter_by_company")
  private List<String> filterByCompany = null;

  @SerializedName("sort_by")
  private String sortBy = null;

  @SerializedName("sort_order")
  private String sortOrder = null;

  @SerializedName("page")
  private Integer page = null;

  @SerializedName("limit")
  private Integer limit = null;

  @SerializedName("language")
  private String language = null;

  @SerializedName("currency")
  private String currency = null;

  @SerializedName("metric")
  private String metric = null;

  public CarOfferRequestSchema pickupLocationLatitude(Float pickupLocationLatitude) {
    this.pickupLocationLatitude = pickupLocationLatitude;
    return this;
  }

   /**
   * Latitude for car pickup location.
   * @return pickupLocationLatitude
  **/
  @Schema(description = "Latitude for car pickup location.")
  public Float getPickupLocationLatitude() {
    return pickupLocationLatitude;
  }

  public void setPickupLocationLatitude(Float pickupLocationLatitude) {
    this.pickupLocationLatitude = pickupLocationLatitude;
  }

  public CarOfferRequestSchema pickupLocationLongitude(Float pickupLocationLongitude) {
    this.pickupLocationLongitude = pickupLocationLongitude;
    return this;
  }

   /**
   * Longitude for car pickup location.
   * @return pickupLocationLongitude
  **/
  @Schema(description = "Longitude for car pickup location.")
  public Float getPickupLocationLongitude() {
    return pickupLocationLongitude;
  }

  public void setPickupLocationLongitude(Float pickupLocationLongitude) {
    this.pickupLocationLongitude = pickupLocationLongitude;
  }

  public CarOfferRequestSchema pickupDate(LocalDate pickupDate) {
    this.pickupDate = pickupDate;
    return this;
  }

   /**
   * Scheduled date for car pickup.
   * @return pickupDate
  **/
  @Schema(description = "Scheduled date for car pickup.")
  public LocalDate getPickupDate() {
    return pickupDate;
  }

  public void setPickupDate(LocalDate pickupDate) {
    this.pickupDate = pickupDate;
  }

  public CarOfferRequestSchema pickupTime(String pickupTime) {
    this.pickupTime = pickupTime;
    return this;
  }

   /**
   * Scheduled time for car pickup.
   * @return pickupTime
  **/
  @Schema(description = "Scheduled time for car pickup.")
  public String getPickupTime() {
    return pickupTime;
  }

  public void setPickupTime(String pickupTime) {
    this.pickupTime = pickupTime;
  }

  public CarOfferRequestSchema dropoffLocationLatitude(Float dropoffLocationLatitude) {
    this.dropoffLocationLatitude = dropoffLocationLatitude;
    return this;
  }

   /**
   * Latitude for car dropoff location.
   * @return dropoffLocationLatitude
  **/
  @Schema(description = "Latitude for car dropoff location.")
  public Float getDropoffLocationLatitude() {
    return dropoffLocationLatitude;
  }

  public void setDropoffLocationLatitude(Float dropoffLocationLatitude) {
    this.dropoffLocationLatitude = dropoffLocationLatitude;
  }

  public CarOfferRequestSchema dropoffLocationLongitude(Float dropoffLocationLongitude) {
    this.dropoffLocationLongitude = dropoffLocationLongitude;
    return this;
  }

   /**
   * Longitude for car dropoff location.
   * @return dropoffLocationLongitude
  **/
  @Schema(description = "Longitude for car dropoff location.")
  public Float getDropoffLocationLongitude() {
    return dropoffLocationLongitude;
  }

  public void setDropoffLocationLongitude(Float dropoffLocationLongitude) {
    this.dropoffLocationLongitude = dropoffLocationLongitude;
  }

  public CarOfferRequestSchema dropoffDate(LocalDate dropoffDate) {
    this.dropoffDate = dropoffDate;
    return this;
  }

   /**
   * Scheduled date for car dropoff.
   * @return dropoffDate
  **/
  @Schema(description = "Scheduled date for car dropoff.")
  public LocalDate getDropoffDate() {
    return dropoffDate;
  }

  public void setDropoffDate(LocalDate dropoffDate) {
    this.dropoffDate = dropoffDate;
  }

  public CarOfferRequestSchema dropoffTime(String dropoffTime) {
    this.dropoffTime = dropoffTime;
    return this;
  }

   /**
   * Scheduled time for car dropoff.
   * @return dropoffTime
  **/
  @Schema(description = "Scheduled time for car dropoff.")
  public String getDropoffTime() {
    return dropoffTime;
  }

  public void setDropoffTime(String dropoffTime) {
    this.dropoffTime = dropoffTime;
  }

  public CarOfferRequestSchema filterByKeyword(String filterByKeyword) {
    this.filterByKeyword = filterByKeyword;
    return this;
  }

   /**
   * Keyword to filter car offers.
   * @return filterByKeyword
  **/
  @Schema(description = "Keyword to filter car offers.")
  public String getFilterByKeyword() {
    return filterByKeyword;
  }

  public void setFilterByKeyword(String filterByKeyword) {
    this.filterByKeyword = filterByKeyword;
  }

  public CarOfferRequestSchema filterByPriceMin(BigDecimal filterByPriceMin) {
    this.filterByPriceMin = filterByPriceMin;
    return this;
  }

   /**
   * Minimum price to filter car offers.
   * @return filterByPriceMin
  **/
  @Schema(description = "Minimum price to filter car offers.")
  public BigDecimal getFilterByPriceMin() {
    return filterByPriceMin;
  }

  public void setFilterByPriceMin(BigDecimal filterByPriceMin) {
    this.filterByPriceMin = filterByPriceMin;
  }

  public CarOfferRequestSchema filterByPriceMax(BigDecimal filterByPriceMax) {
    this.filterByPriceMax = filterByPriceMax;
    return this;
  }

   /**
   * Maximum price to filter car offers.
   * @return filterByPriceMax
  **/
  @Schema(description = "Maximum price to filter car offers.")
  public BigDecimal getFilterByPriceMax() {
    return filterByPriceMax;
  }

  public void setFilterByPriceMax(BigDecimal filterByPriceMax) {
    this.filterByPriceMax = filterByPriceMax;
  }

  public CarOfferRequestSchema filterByDistanceMin(Integer filterByDistanceMin) {
    this.filterByDistanceMin = filterByDistanceMin;
    return this;
  }

   /**
   * Minimum distance filter for car offers.
   * @return filterByDistanceMin
  **/
  @Schema(description = "Minimum distance filter for car offers.")
  public Integer getFilterByDistanceMin() {
    return filterByDistanceMin;
  }

  public void setFilterByDistanceMin(Integer filterByDistanceMin) {
    this.filterByDistanceMin = filterByDistanceMin;
  }

  public CarOfferRequestSchema filterByDistanceMax(Integer filterByDistanceMax) {
    this.filterByDistanceMax = filterByDistanceMax;
    return this;
  }

   /**
   * Maximum distance filter for car offers.
   * @return filterByDistanceMax
  **/
  @Schema(description = "Maximum distance filter for car offers.")
  public Integer getFilterByDistanceMax() {
    return filterByDistanceMax;
  }

  public void setFilterByDistanceMax(Integer filterByDistanceMax) {
    this.filterByDistanceMax = filterByDistanceMax;
  }

  public CarOfferRequestSchema filterByRatingMin(Integer filterByRatingMin) {
    this.filterByRatingMin = filterByRatingMin;
    return this;
  }

   /**
   * Minimum rating filter for car offers.
   * @return filterByRatingMin
  **/
  @Schema(description = "Minimum rating filter for car offers.")
  public Integer getFilterByRatingMin() {
    return filterByRatingMin;
  }

  public void setFilterByRatingMin(Integer filterByRatingMin) {
    this.filterByRatingMin = filterByRatingMin;
  }

  public CarOfferRequestSchema filterByRatingMax(Integer filterByRatingMax) {
    this.filterByRatingMax = filterByRatingMax;
    return this;
  }

   /**
   * Maximum rating filter for car offers.
   * @return filterByRatingMax
  **/
  @Schema(description = "Maximum rating filter for car offers.")
  public Integer getFilterByRatingMax() {
    return filterByRatingMax;
  }

  public void setFilterByRatingMax(Integer filterByRatingMax) {
    this.filterByRatingMax = filterByRatingMax;
  }

  public CarOfferRequestSchema filterByPassengersMin(Integer filterByPassengersMin) {
    this.filterByPassengersMin = filterByPassengersMin;
    return this;
  }

   /**
   * Minimum passengers capacity filter for car offers.
   * @return filterByPassengersMin
  **/
  @Schema(description = "Minimum passengers capacity filter for car offers.")
  public Integer getFilterByPassengersMin() {
    return filterByPassengersMin;
  }

  public void setFilterByPassengersMin(Integer filterByPassengersMin) {
    this.filterByPassengersMin = filterByPassengersMin;
  }

  public CarOfferRequestSchema filterByPassengersMax(Integer filterByPassengersMax) {
    this.filterByPassengersMax = filterByPassengersMax;
    return this;
  }

   /**
   * Maximum passengers capacity filter for car offers.
   * @return filterByPassengersMax
  **/
  @Schema(description = "Maximum passengers capacity filter for car offers.")
  public Integer getFilterByPassengersMax() {
    return filterByPassengersMax;
  }

  public void setFilterByPassengersMax(Integer filterByPassengersMax) {
    this.filterByPassengersMax = filterByPassengersMax;
  }

  public CarOfferRequestSchema filterByType(List<String> filterByType) {
    this.filterByType = filterByType;
    return this;
  }

  public CarOfferRequestSchema addFilterByTypeItem(String filterByTypeItem) {
    if (this.filterByType == null) {
      this.filterByType = new ArrayList<String>();
    }
    this.filterByType.add(filterByTypeItem);
    return this;
  }

   /**
   * Types of cars to filter by.
   * @return filterByType
  **/
  @Schema(description = "Types of cars to filter by.")
  public List<String> getFilterByType() {
    return filterByType;
  }

  public void setFilterByType(List<String> filterByType) {
    this.filterByType = filterByType;
  }

  public CarOfferRequestSchema filterByCompany(List<String> filterByCompany) {
    this.filterByCompany = filterByCompany;
    return this;
  }

  public CarOfferRequestSchema addFilterByCompanyItem(String filterByCompanyItem) {
    if (this.filterByCompany == null) {
      this.filterByCompany = new ArrayList<String>();
    }
    this.filterByCompany.add(filterByCompanyItem);
    return this;
  }

   /**
   * Car rental companies to filter by.
   * @return filterByCompany
  **/
  @Schema(description = "Car rental companies to filter by.")
  public List<String> getFilterByCompany() {
    return filterByCompany;
  }

  public void setFilterByCompany(List<String> filterByCompany) {
    this.filterByCompany = filterByCompany;
  }

  public CarOfferRequestSchema sortBy(String sortBy) {
    this.sortBy = sortBy;
    return this;
  }

   /**
   * Field to sort car offers by.
   * @return sortBy
  **/
  @Schema(description = "Field to sort car offers by.")
  public String getSortBy() {
    return sortBy;
  }

  public void setSortBy(String sortBy) {
    this.sortBy = sortBy;
  }

  public CarOfferRequestSchema sortOrder(String sortOrder) {
    this.sortOrder = sortOrder;
    return this;
  }

   /**
   * Order to sort car offers (asc, desc).
   * @return sortOrder
  **/
  @Schema(description = "Order to sort car offers (asc, desc).")
  public String getSortOrder() {
    return sortOrder;
  }

  public void setSortOrder(String sortOrder) {
    this.sortOrder = sortOrder;
  }

  public CarOfferRequestSchema page(Integer page) {
    this.page = page;
    return this;
  }

   /**
   * Page number for pagination.
   * @return page
  **/
  @Schema(description = "Page number for pagination.")
  public Integer getPage() {
    return page;
  }

  public void setPage(Integer page) {
    this.page = page;
  }

  public CarOfferRequestSchema limit(Integer limit) {
    this.limit = limit;
    return this;
  }

   /**
   * Number of offers per page.
   * @return limit
  **/
  @Schema(description = "Number of offers per page.")
  public Integer getLimit() {
    return limit;
  }

  public void setLimit(Integer limit) {
    this.limit = limit;
  }

  public CarOfferRequestSchema language(String language) {
    this.language = language;
    return this;
  }

   /**
   * Language for the offers.
   * @return language
  **/
  @Schema(description = "Language for the offers.")
  public String getLanguage() {
    return language;
  }

  public void setLanguage(String language) {
    this.language = language;
  }

  public CarOfferRequestSchema currency(String currency) {
    this.currency = currency;
    return this;
  }

   /**
   * Currency for the offers.
   * @return currency
  **/
  @Schema(description = "Currency for the offers.")
  public String getCurrency() {
    return currency;
  }

  public void setCurrency(String currency) {
    this.currency = currency;
  }

  public CarOfferRequestSchema metric(String metric) {
    this.metric = metric;
    return this;
  }

   /**
   * Distance metric (mi/km) used in filters.
   * @return metric
  **/
  @Schema(description = "Distance metric (mi/km) used in filters.")
  public String getMetric() {
    return metric;
  }

  public void setMetric(String metric) {
    this.metric = metric;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CarOfferRequestSchema carOfferRequestSchema = (CarOfferRequestSchema) o;
    return Objects.equals(this.pickupLocationLatitude, carOfferRequestSchema.pickupLocationLatitude) &&
        Objects.equals(this.pickupLocationLongitude, carOfferRequestSchema.pickupLocationLongitude) &&
        Objects.equals(this.pickupDate, carOfferRequestSchema.pickupDate) &&
        Objects.equals(this.pickupTime, carOfferRequestSchema.pickupTime) &&
        Objects.equals(this.dropoffLocationLatitude, carOfferRequestSchema.dropoffLocationLatitude) &&
        Objects.equals(this.dropoffLocationLongitude, carOfferRequestSchema.dropoffLocationLongitude) &&
        Objects.equals(this.dropoffDate, carOfferRequestSchema.dropoffDate) &&
        Objects.equals(this.dropoffTime, carOfferRequestSchema.dropoffTime) &&
        Objects.equals(this.filterByKeyword, carOfferRequestSchema.filterByKeyword) &&
        Objects.equals(this.filterByPriceMin, carOfferRequestSchema.filterByPriceMin) &&
        Objects.equals(this.filterByPriceMax, carOfferRequestSchema.filterByPriceMax) &&
        Objects.equals(this.filterByDistanceMin, carOfferRequestSchema.filterByDistanceMin) &&
        Objects.equals(this.filterByDistanceMax, carOfferRequestSchema.filterByDistanceMax) &&
        Objects.equals(this.filterByRatingMin, carOfferRequestSchema.filterByRatingMin) &&
        Objects.equals(this.filterByRatingMax, carOfferRequestSchema.filterByRatingMax) &&
        Objects.equals(this.filterByPassengersMin, carOfferRequestSchema.filterByPassengersMin) &&
        Objects.equals(this.filterByPassengersMax, carOfferRequestSchema.filterByPassengersMax) &&
        Objects.equals(this.filterByType, carOfferRequestSchema.filterByType) &&
        Objects.equals(this.filterByCompany, carOfferRequestSchema.filterByCompany) &&
        Objects.equals(this.sortBy, carOfferRequestSchema.sortBy) &&
        Objects.equals(this.sortOrder, carOfferRequestSchema.sortOrder) &&
        Objects.equals(this.page, carOfferRequestSchema.page) &&
        Objects.equals(this.limit, carOfferRequestSchema.limit) &&
        Objects.equals(this.language, carOfferRequestSchema.language) &&
        Objects.equals(this.currency, carOfferRequestSchema.currency) &&
        Objects.equals(this.metric, carOfferRequestSchema.metric);
  }

  @Override
  public int hashCode() {
    return Objects.hash(pickupLocationLatitude, pickupLocationLongitude, pickupDate, pickupTime, dropoffLocationLatitude, dropoffLocationLongitude, dropoffDate, dropoffTime, filterByKeyword, filterByPriceMin, filterByPriceMax, filterByDistanceMin, filterByDistanceMax, filterByRatingMin, filterByRatingMax, filterByPassengersMin, filterByPassengersMax, filterByType, filterByCompany, sortBy, sortOrder, page, limit, language, currency, metric);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CarOfferRequestSchema {\n");
    
    sb.append("    pickupLocationLatitude: ").append(toIndentedString(pickupLocationLatitude)).append("\n");
    sb.append("    pickupLocationLongitude: ").append(toIndentedString(pickupLocationLongitude)).append("\n");
    sb.append("    pickupDate: ").append(toIndentedString(pickupDate)).append("\n");
    sb.append("    pickupTime: ").append(toIndentedString(pickupTime)).append("\n");
    sb.append("    dropoffLocationLatitude: ").append(toIndentedString(dropoffLocationLatitude)).append("\n");
    sb.append("    dropoffLocationLongitude: ").append(toIndentedString(dropoffLocationLongitude)).append("\n");
    sb.append("    dropoffDate: ").append(toIndentedString(dropoffDate)).append("\n");
    sb.append("    dropoffTime: ").append(toIndentedString(dropoffTime)).append("\n");
    sb.append("    filterByKeyword: ").append(toIndentedString(filterByKeyword)).append("\n");
    sb.append("    filterByPriceMin: ").append(toIndentedString(filterByPriceMin)).append("\n");
    sb.append("    filterByPriceMax: ").append(toIndentedString(filterByPriceMax)).append("\n");
    sb.append("    filterByDistanceMin: ").append(toIndentedString(filterByDistanceMin)).append("\n");
    sb.append("    filterByDistanceMax: ").append(toIndentedString(filterByDistanceMax)).append("\n");
    sb.append("    filterByRatingMin: ").append(toIndentedString(filterByRatingMin)).append("\n");
    sb.append("    filterByRatingMax: ").append(toIndentedString(filterByRatingMax)).append("\n");
    sb.append("    filterByPassengersMin: ").append(toIndentedString(filterByPassengersMin)).append("\n");
    sb.append("    filterByPassengersMax: ").append(toIndentedString(filterByPassengersMax)).append("\n");
    sb.append("    filterByType: ").append(toIndentedString(filterByType)).append("\n");
    sb.append("    filterByCompany: ").append(toIndentedString(filterByCompany)).append("\n");
    sb.append("    sortBy: ").append(toIndentedString(sortBy)).append("\n");
    sb.append("    sortOrder: ").append(toIndentedString(sortOrder)).append("\n");
    sb.append("    page: ").append(toIndentedString(page)).append("\n");
    sb.append("    limit: ").append(toIndentedString(limit)).append("\n");
    sb.append("    language: ").append(toIndentedString(language)).append("\n");
    sb.append("    currency: ").append(toIndentedString(currency)).append("\n");
    sb.append("    metric: ").append(toIndentedString(metric)).append("\n");
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
