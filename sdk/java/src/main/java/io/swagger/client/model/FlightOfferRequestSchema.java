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
import java.util.List;
/**
 * FlightOfferRequestSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class FlightOfferRequestSchema {
  @SerializedName("cabin")
  private List cabin = null;

  @SerializedName("legs")
  private List legs = null;

  @SerializedName("passengers")
  private List passengers = null;

  @SerializedName("private_fare_codes")
  private List privateFareCodes = null;

  @SerializedName("filter_by_keyword")
  private String filterByKeyword = null;

  @SerializedName("filter_by_price_min")
  private Float filterByPriceMin = null;

  @SerializedName("filter_by_price_max")
  private Float filterByPriceMax = null;

  @SerializedName("filter_by_duration_min")
  private Integer filterByDurationMin = null;

  @SerializedName("filter_by_duration_max")
  private Integer filterByDurationMax = null;

  @SerializedName("filter_by_departure_time_min")
  private String filterByDepartureTimeMin = null;

  @SerializedName("filter_by_departure_time_max")
  private String filterByDepartureTimeMax = null;

  @SerializedName("filter_by_arrival_time_min")
  private String filterByArrivalTimeMin = null;

  @SerializedName("filter_by_arrival_time_max")
  private String filterByArrivalTimeMax = null;

  @SerializedName("filter_by_stops_min")
  private Integer filterByStopsMin = null;

  @SerializedName("filter_by_stops_max")
  private Integer filterByStopsMax = null;

  @SerializedName("filter_by_airlines")
  private List filterByAirlines = null;

  @SerializedName("filter_by_airports")
  private List filterByAirports = null;

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

  public FlightOfferRequestSchema cabin(List cabin) {
    this.cabin = cabin;
    return this;
  }

   /**
   * Class options: first, business, premium economy, economy.
   * @return cabin
  **/
  @Schema(description = "Class options: first, business, premium economy, economy.")
  public List getCabin() {
    return cabin;
  }

  public void setCabin(List cabin) {
    this.cabin = cabin;
  }

  public FlightOfferRequestSchema legs(List legs) {
    this.legs = legs;
    return this;
  }

   /**
   * Array of flight legs, each described in FlightLegOfferRequestSchema.
   * @return legs
  **/
  @Schema(description = "Array of flight legs, each described in FlightLegOfferRequestSchema.")
  public List getLegs() {
    return legs;
  }

  public void setLegs(List legs) {
    this.legs = legs;
  }

  public FlightOfferRequestSchema passengers(List passengers) {
    this.passengers = passengers;
    return this;
  }

   /**
   * Array of passengers, each described in FlightPassengerOfferRequestSchema.
   * @return passengers
  **/
  @Schema(description = "Array of passengers, each described in FlightPassengerOfferRequestSchema.")
  public List getPassengers() {
    return passengers;
  }

  public void setPassengers(List passengers) {
    this.passengers = passengers;
  }

  public FlightOfferRequestSchema privateFareCodes(List privateFareCodes) {
    this.privateFareCodes = privateFareCodes;
    return this;
  }

   /**
   * Array of codes for accessing special negotiated fares.
   * @return privateFareCodes
  **/
  @Schema(description = "Array of codes for accessing special negotiated fares.")
  public List getPrivateFareCodes() {
    return privateFareCodes;
  }

  public void setPrivateFareCodes(List privateFareCodes) {
    this.privateFareCodes = privateFareCodes;
  }

  public FlightOfferRequestSchema filterByKeyword(String filterByKeyword) {
    this.filterByKeyword = filterByKeyword;
    return this;
  }

   /**
   * Keyword to filter offers.
   * @return filterByKeyword
  **/
  @Schema(description = "Keyword to filter offers.")
  public String getFilterByKeyword() {
    return filterByKeyword;
  }

  public void setFilterByKeyword(String filterByKeyword) {
    this.filterByKeyword = filterByKeyword;
  }

  public FlightOfferRequestSchema filterByPriceMin(Float filterByPriceMin) {
    this.filterByPriceMin = filterByPriceMin;
    return this;
  }

   /**
   * Minimum price filter.
   * @return filterByPriceMin
  **/
  @Schema(description = "Minimum price filter.")
  public Float getFilterByPriceMin() {
    return filterByPriceMin;
  }

  public void setFilterByPriceMin(Float filterByPriceMin) {
    this.filterByPriceMin = filterByPriceMin;
  }

  public FlightOfferRequestSchema filterByPriceMax(Float filterByPriceMax) {
    this.filterByPriceMax = filterByPriceMax;
    return this;
  }

   /**
   * Maximum price filter.
   * @return filterByPriceMax
  **/
  @Schema(description = "Maximum price filter.")
  public Float getFilterByPriceMax() {
    return filterByPriceMax;
  }

  public void setFilterByPriceMax(Float filterByPriceMax) {
    this.filterByPriceMax = filterByPriceMax;
  }

  public FlightOfferRequestSchema filterByDurationMin(Integer filterByDurationMin) {
    this.filterByDurationMin = filterByDurationMin;
    return this;
  }

   /**
   * Minimum flight duration filter.
   * @return filterByDurationMin
  **/
  @Schema(description = "Minimum flight duration filter.")
  public Integer getFilterByDurationMin() {
    return filterByDurationMin;
  }

  public void setFilterByDurationMin(Integer filterByDurationMin) {
    this.filterByDurationMin = filterByDurationMin;
  }

  public FlightOfferRequestSchema filterByDurationMax(Integer filterByDurationMax) {
    this.filterByDurationMax = filterByDurationMax;
    return this;
  }

   /**
   * Maximum flight duration filter.
   * @return filterByDurationMax
  **/
  @Schema(description = "Maximum flight duration filter.")
  public Integer getFilterByDurationMax() {
    return filterByDurationMax;
  }

  public void setFilterByDurationMax(Integer filterByDurationMax) {
    this.filterByDurationMax = filterByDurationMax;
  }

  public FlightOfferRequestSchema filterByDepartureTimeMin(String filterByDepartureTimeMin) {
    this.filterByDepartureTimeMin = filterByDepartureTimeMin;
    return this;
  }

   /**
   * Earliest departure time filter.
   * @return filterByDepartureTimeMin
  **/
  @Schema(description = "Earliest departure time filter.")
  public String getFilterByDepartureTimeMin() {
    return filterByDepartureTimeMin;
  }

  public void setFilterByDepartureTimeMin(String filterByDepartureTimeMin) {
    this.filterByDepartureTimeMin = filterByDepartureTimeMin;
  }

  public FlightOfferRequestSchema filterByDepartureTimeMax(String filterByDepartureTimeMax) {
    this.filterByDepartureTimeMax = filterByDepartureTimeMax;
    return this;
  }

   /**
   * Latest departure time filter.
   * @return filterByDepartureTimeMax
  **/
  @Schema(description = "Latest departure time filter.")
  public String getFilterByDepartureTimeMax() {
    return filterByDepartureTimeMax;
  }

  public void setFilterByDepartureTimeMax(String filterByDepartureTimeMax) {
    this.filterByDepartureTimeMax = filterByDepartureTimeMax;
  }

  public FlightOfferRequestSchema filterByArrivalTimeMin(String filterByArrivalTimeMin) {
    this.filterByArrivalTimeMin = filterByArrivalTimeMin;
    return this;
  }

   /**
   * Earliest arrival time filter.
   * @return filterByArrivalTimeMin
  **/
  @Schema(description = "Earliest arrival time filter.")
  public String getFilterByArrivalTimeMin() {
    return filterByArrivalTimeMin;
  }

  public void setFilterByArrivalTimeMin(String filterByArrivalTimeMin) {
    this.filterByArrivalTimeMin = filterByArrivalTimeMin;
  }

  public FlightOfferRequestSchema filterByArrivalTimeMax(String filterByArrivalTimeMax) {
    this.filterByArrivalTimeMax = filterByArrivalTimeMax;
    return this;
  }

   /**
   * Latest arrival time filter.
   * @return filterByArrivalTimeMax
  **/
  @Schema(description = "Latest arrival time filter.")
  public String getFilterByArrivalTimeMax() {
    return filterByArrivalTimeMax;
  }

  public void setFilterByArrivalTimeMax(String filterByArrivalTimeMax) {
    this.filterByArrivalTimeMax = filterByArrivalTimeMax;
  }

  public FlightOfferRequestSchema filterByStopsMin(Integer filterByStopsMin) {
    this.filterByStopsMin = filterByStopsMin;
    return this;
  }

   /**
   * Minimum number of stops filter.
   * @return filterByStopsMin
  **/
  @Schema(description = "Minimum number of stops filter.")
  public Integer getFilterByStopsMin() {
    return filterByStopsMin;
  }

  public void setFilterByStopsMin(Integer filterByStopsMin) {
    this.filterByStopsMin = filterByStopsMin;
  }

  public FlightOfferRequestSchema filterByStopsMax(Integer filterByStopsMax) {
    this.filterByStopsMax = filterByStopsMax;
    return this;
  }

   /**
   * Maximum number of stops filter.
   * @return filterByStopsMax
  **/
  @Schema(description = "Maximum number of stops filter.")
  public Integer getFilterByStopsMax() {
    return filterByStopsMax;
  }

  public void setFilterByStopsMax(Integer filterByStopsMax) {
    this.filterByStopsMax = filterByStopsMax;
  }

  public FlightOfferRequestSchema filterByAirlines(List filterByAirlines) {
    this.filterByAirlines = filterByAirlines;
    return this;
  }

   /**
   * List of airline filters.
   * @return filterByAirlines
  **/
  @Schema(description = "List of airline filters.")
  public List getFilterByAirlines() {
    return filterByAirlines;
  }

  public void setFilterByAirlines(List filterByAirlines) {
    this.filterByAirlines = filterByAirlines;
  }

  public FlightOfferRequestSchema filterByAirports(List filterByAirports) {
    this.filterByAirports = filterByAirports;
    return this;
  }

   /**
   * List of airport filters.
   * @return filterByAirports
  **/
  @Schema(description = "List of airport filters.")
  public List getFilterByAirports() {
    return filterByAirports;
  }

  public void setFilterByAirports(List filterByAirports) {
    this.filterByAirports = filterByAirports;
  }

  public FlightOfferRequestSchema sortBy(String sortBy) {
    this.sortBy = sortBy;
    return this;
  }

   /**
   * Sorting criteria.
   * @return sortBy
  **/
  @Schema(description = "Sorting criteria.")
  public String getSortBy() {
    return sortBy;
  }

  public void setSortBy(String sortBy) {
    this.sortBy = sortBy;
  }

  public FlightOfferRequestSchema sortOrder(String sortOrder) {
    this.sortOrder = sortOrder;
    return this;
  }

   /**
   * Sorting order, asc or desc.
   * @return sortOrder
  **/
  @Schema(description = "Sorting order, asc or desc.")
  public String getSortOrder() {
    return sortOrder;
  }

  public void setSortOrder(String sortOrder) {
    this.sortOrder = sortOrder;
  }

  public FlightOfferRequestSchema page(Integer page) {
    this.page = page;
    return this;
  }

   /**
   * Pagination: page number.
   * @return page
  **/
  @Schema(description = "Pagination: page number.")
  public Integer getPage() {
    return page;
  }

  public void setPage(Integer page) {
    this.page = page;
  }

  public FlightOfferRequestSchema limit(Integer limit) {
    this.limit = limit;
    return this;
  }

   /**
   * Pagination: maximum items per page.
   * @return limit
  **/
  @Schema(description = "Pagination: maximum items per page.")
  public Integer getLimit() {
    return limit;
  }

  public void setLimit(Integer limit) {
    this.limit = limit;
  }

  public FlightOfferRequestSchema language(String language) {
    this.language = language;
    return this;
  }

   /**
   * Language selection for offer details.
   * @return language
  **/
  @Schema(description = "Language selection for offer details.")
  public String getLanguage() {
    return language;
  }

  public void setLanguage(String language) {
    this.language = language;
  }

  public FlightOfferRequestSchema currency(String currency) {
    this.currency = currency;
    return this;
  }

   /**
   * Currency in which prices should be provided.
   * @return currency
  **/
  @Schema(description = "Currency in which prices should be provided.")
  public String getCurrency() {
    return currency;
  }

  public void setCurrency(String currency) {
    this.currency = currency;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlightOfferRequestSchema flightOfferRequestSchema = (FlightOfferRequestSchema) o;
    return Objects.equals(this.cabin, flightOfferRequestSchema.cabin) &&
        Objects.equals(this.legs, flightOfferRequestSchema.legs) &&
        Objects.equals(this.passengers, flightOfferRequestSchema.passengers) &&
        Objects.equals(this.privateFareCodes, flightOfferRequestSchema.privateFareCodes) &&
        Objects.equals(this.filterByKeyword, flightOfferRequestSchema.filterByKeyword) &&
        Objects.equals(this.filterByPriceMin, flightOfferRequestSchema.filterByPriceMin) &&
        Objects.equals(this.filterByPriceMax, flightOfferRequestSchema.filterByPriceMax) &&
        Objects.equals(this.filterByDurationMin, flightOfferRequestSchema.filterByDurationMin) &&
        Objects.equals(this.filterByDurationMax, flightOfferRequestSchema.filterByDurationMax) &&
        Objects.equals(this.filterByDepartureTimeMin, flightOfferRequestSchema.filterByDepartureTimeMin) &&
        Objects.equals(this.filterByDepartureTimeMax, flightOfferRequestSchema.filterByDepartureTimeMax) &&
        Objects.equals(this.filterByArrivalTimeMin, flightOfferRequestSchema.filterByArrivalTimeMin) &&
        Objects.equals(this.filterByArrivalTimeMax, flightOfferRequestSchema.filterByArrivalTimeMax) &&
        Objects.equals(this.filterByStopsMin, flightOfferRequestSchema.filterByStopsMin) &&
        Objects.equals(this.filterByStopsMax, flightOfferRequestSchema.filterByStopsMax) &&
        Objects.equals(this.filterByAirlines, flightOfferRequestSchema.filterByAirlines) &&
        Objects.equals(this.filterByAirports, flightOfferRequestSchema.filterByAirports) &&
        Objects.equals(this.sortBy, flightOfferRequestSchema.sortBy) &&
        Objects.equals(this.sortOrder, flightOfferRequestSchema.sortOrder) &&
        Objects.equals(this.page, flightOfferRequestSchema.page) &&
        Objects.equals(this.limit, flightOfferRequestSchema.limit) &&
        Objects.equals(this.language, flightOfferRequestSchema.language) &&
        Objects.equals(this.currency, flightOfferRequestSchema.currency);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cabin, legs, passengers, privateFareCodes, filterByKeyword, filterByPriceMin, filterByPriceMax, filterByDurationMin, filterByDurationMax, filterByDepartureTimeMin, filterByDepartureTimeMax, filterByArrivalTimeMin, filterByArrivalTimeMax, filterByStopsMin, filterByStopsMax, filterByAirlines, filterByAirports, sortBy, sortOrder, page, limit, language, currency);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlightOfferRequestSchema {\n");
    
    sb.append("    cabin: ").append(toIndentedString(cabin)).append("\n");
    sb.append("    legs: ").append(toIndentedString(legs)).append("\n");
    sb.append("    passengers: ").append(toIndentedString(passengers)).append("\n");
    sb.append("    privateFareCodes: ").append(toIndentedString(privateFareCodes)).append("\n");
    sb.append("    filterByKeyword: ").append(toIndentedString(filterByKeyword)).append("\n");
    sb.append("    filterByPriceMin: ").append(toIndentedString(filterByPriceMin)).append("\n");
    sb.append("    filterByPriceMax: ").append(toIndentedString(filterByPriceMax)).append("\n");
    sb.append("    filterByDurationMin: ").append(toIndentedString(filterByDurationMin)).append("\n");
    sb.append("    filterByDurationMax: ").append(toIndentedString(filterByDurationMax)).append("\n");
    sb.append("    filterByDepartureTimeMin: ").append(toIndentedString(filterByDepartureTimeMin)).append("\n");
    sb.append("    filterByDepartureTimeMax: ").append(toIndentedString(filterByDepartureTimeMax)).append("\n");
    sb.append("    filterByArrivalTimeMin: ").append(toIndentedString(filterByArrivalTimeMin)).append("\n");
    sb.append("    filterByArrivalTimeMax: ").append(toIndentedString(filterByArrivalTimeMax)).append("\n");
    sb.append("    filterByStopsMin: ").append(toIndentedString(filterByStopsMin)).append("\n");
    sb.append("    filterByStopsMax: ").append(toIndentedString(filterByStopsMax)).append("\n");
    sb.append("    filterByAirlines: ").append(toIndentedString(filterByAirlines)).append("\n");
    sb.append("    filterByAirports: ").append(toIndentedString(filterByAirports)).append("\n");
    sb.append("    sortBy: ").append(toIndentedString(sortBy)).append("\n");
    sb.append("    sortOrder: ").append(toIndentedString(sortOrder)).append("\n");
    sb.append("    page: ").append(toIndentedString(page)).append("\n");
    sb.append("    limit: ").append(toIndentedString(limit)).append("\n");
    sb.append("    language: ").append(toIndentedString(language)).append("\n");
    sb.append("    currency: ").append(toIndentedString(currency)).append("\n");
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
