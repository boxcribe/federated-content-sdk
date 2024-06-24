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
import java.util.UUID;
/**
 * DiningOfferResponseItemSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class DiningOfferResponseItemSchema {
  @SerializedName("offer_id")
  private UUID offerId = null;

  @SerializedName("supplier_offer_id")
  private UUID supplierOfferId = null;

  @SerializedName("offer_index")
  private BigDecimal offerIndex = null;

  @SerializedName("offer_tax")
  private BigDecimal offerTax = null;

  @SerializedName("offer_price")
  private BigDecimal offerPrice = null;

  @SerializedName("offer_currency")
  private String offerCurrency = null;

  @SerializedName("offer_cancellation_policies")
  private String offerCancellationPolicies = null;

  @SerializedName("dining_name")
  private String diningName = null;

  @SerializedName("dining_description")
  private String diningDescription = null;

  @SerializedName("dining_address")
  private String diningAddress = null;

  @SerializedName("dining_latitude")
  private Float diningLatitude = null;

  @SerializedName("dining_longitude")
  private Float diningLongitude = null;

  @SerializedName("dining_distance")
  private Float diningDistance = null;

  @SerializedName("dining_distance_metric")
  private String diningDistanceMetric = null;

  @SerializedName("dining_images")
  private List<String> diningImages = null;

  @SerializedName("dining_rating")
  private Float diningRating = null;

  @SerializedName("dining_reviews")
  private List<String> diningReviews = null;

  @SerializedName("dining_subcategories")
  private List<String> diningSubcategories = null;

  @SerializedName("dining_hours")
  private List<String> diningHours = null;

  public DiningOfferResponseItemSchema offerId(UUID offerId) {
    this.offerId = offerId;
    return this;
  }

   /**
   * Unique identifier for the dining offer.
   * @return offerId
  **/
  @Schema(description = "Unique identifier for the dining offer.")
  public UUID getOfferId() {
    return offerId;
  }

  public void setOfferId(UUID offerId) {
    this.offerId = offerId;
  }

  public DiningOfferResponseItemSchema supplierOfferId(UUID supplierOfferId) {
    this.supplierOfferId = supplierOfferId;
    return this;
  }

   /**
   * Identifier for the offer provided by the supplier.
   * @return supplierOfferId
  **/
  @Schema(description = "Identifier for the offer provided by the supplier.")
  public UUID getSupplierOfferId() {
    return supplierOfferId;
  }

  public void setSupplierOfferId(UUID supplierOfferId) {
    this.supplierOfferId = supplierOfferId;
  }

  public DiningOfferResponseItemSchema offerIndex(BigDecimal offerIndex) {
    this.offerIndex = offerIndex;
    return this;
  }

   /**
   * Index of the offer for sorting and reference.
   * @return offerIndex
  **/
  @Schema(description = "Index of the offer for sorting and reference.")
  public BigDecimal getOfferIndex() {
    return offerIndex;
  }

  public void setOfferIndex(BigDecimal offerIndex) {
    this.offerIndex = offerIndex;
  }

  public DiningOfferResponseItemSchema offerTax(BigDecimal offerTax) {
    this.offerTax = offerTax;
    return this;
  }

   /**
   * Tax applied to the dining offer.
   * @return offerTax
  **/
  @Schema(description = "Tax applied to the dining offer.")
  public BigDecimal getOfferTax() {
    return offerTax;
  }

  public void setOfferTax(BigDecimal offerTax) {
    this.offerTax = offerTax;
  }

  public DiningOfferResponseItemSchema offerPrice(BigDecimal offerPrice) {
    this.offerPrice = offerPrice;
    return this;
  }

   /**
   * Price of the dining experience.
   * @return offerPrice
  **/
  @Schema(description = "Price of the dining experience.")
  public BigDecimal getOfferPrice() {
    return offerPrice;
  }

  public void setOfferPrice(BigDecimal offerPrice) {
    this.offerPrice = offerPrice;
  }

  public DiningOfferResponseItemSchema offerCurrency(String offerCurrency) {
    this.offerCurrency = offerCurrency;
    return this;
  }

   /**
   * Currency in which the offer is priced.
   * @return offerCurrency
  **/
  @Schema(description = "Currency in which the offer is priced.")
  public String getOfferCurrency() {
    return offerCurrency;
  }

  public void setOfferCurrency(String offerCurrency) {
    this.offerCurrency = offerCurrency;
  }

  public DiningOfferResponseItemSchema offerCancellationPolicies(String offerCancellationPolicies) {
    this.offerCancellationPolicies = offerCancellationPolicies;
    return this;
  }

   /**
   * Cancellation policies applicable to the dining offer.
   * @return offerCancellationPolicies
  **/
  @Schema(description = "Cancellation policies applicable to the dining offer.")
  public String getOfferCancellationPolicies() {
    return offerCancellationPolicies;
  }

  public void setOfferCancellationPolicies(String offerCancellationPolicies) {
    this.offerCancellationPolicies = offerCancellationPolicies;
  }

  public DiningOfferResponseItemSchema diningName(String diningName) {
    this.diningName = diningName;
    return this;
  }

   /**
   * Name of the dining establishment.
   * @return diningName
  **/
  @Schema(description = "Name of the dining establishment.")
  public String getDiningName() {
    return diningName;
  }

  public void setDiningName(String diningName) {
    this.diningName = diningName;
  }

  public DiningOfferResponseItemSchema diningDescription(String diningDescription) {
    this.diningDescription = diningDescription;
    return this;
  }

   /**
   * Description of the dining establishment and the dining experience.
   * @return diningDescription
  **/
  @Schema(description = "Description of the dining establishment and the dining experience.")
  public String getDiningDescription() {
    return diningDescription;
  }

  public void setDiningDescription(String diningDescription) {
    this.diningDescription = diningDescription;
  }

  public DiningOfferResponseItemSchema diningAddress(String diningAddress) {
    this.diningAddress = diningAddress;
    return this;
  }

   /**
   * Physical address of the dining establishment.
   * @return diningAddress
  **/
  @Schema(description = "Physical address of the dining establishment.")
  public String getDiningAddress() {
    return diningAddress;
  }

  public void setDiningAddress(String diningAddress) {
    this.diningAddress = diningAddress;
  }

  public DiningOfferResponseItemSchema diningLatitude(Float diningLatitude) {
    this.diningLatitude = diningLatitude;
    return this;
  }

   /**
   * Latitude coordinate of the dining location.
   * @return diningLatitude
  **/
  @Schema(description = "Latitude coordinate of the dining location.")
  public Float getDiningLatitude() {
    return diningLatitude;
  }

  public void setDiningLatitude(Float diningLatitude) {
    this.diningLatitude = diningLatitude;
  }

  public DiningOfferResponseItemSchema diningLongitude(Float diningLongitude) {
    this.diningLongitude = diningLongitude;
    return this;
  }

   /**
   * Longitude coordinate of the dining location.
   * @return diningLongitude
  **/
  @Schema(description = "Longitude coordinate of the dining location.")
  public Float getDiningLongitude() {
    return diningLongitude;
  }

  public void setDiningLongitude(Float diningLongitude) {
    this.diningLongitude = diningLongitude;
  }

  public DiningOfferResponseItemSchema diningDistance(Float diningDistance) {
    this.diningDistance = diningDistance;
    return this;
  }

   /**
   * Distance to the dining location from a reference point, if applicable.
   * @return diningDistance
  **/
  @Schema(description = "Distance to the dining location from a reference point, if applicable.")
  public Float getDiningDistance() {
    return diningDistance;
  }

  public void setDiningDistance(Float diningDistance) {
    this.diningDistance = diningDistance;
  }

  public DiningOfferResponseItemSchema diningDistanceMetric(String diningDistanceMetric) {
    this.diningDistanceMetric = diningDistanceMetric;
    return this;
  }

   /**
   * Metric used to measure the distance (e.g., miles, kilometers).
   * @return diningDistanceMetric
  **/
  @Schema(description = "Metric used to measure the distance (e.g., miles, kilometers).")
  public String getDiningDistanceMetric() {
    return diningDistanceMetric;
  }

  public void setDiningDistanceMetric(String diningDistanceMetric) {
    this.diningDistanceMetric = diningDistanceMetric;
  }

  public DiningOfferResponseItemSchema diningImages(List<String> diningImages) {
    this.diningImages = diningImages;
    return this;
  }

  public DiningOfferResponseItemSchema addDiningImagesItem(String diningImagesItem) {
    if (this.diningImages == null) {
      this.diningImages = new ArrayList<String>();
    }
    this.diningImages.add(diningImagesItem);
    return this;
  }

   /**
   * Collection of images of the dining establishment and dishes.
   * @return diningImages
  **/
  @Schema(description = "Collection of images of the dining establishment and dishes.")
  public List<String> getDiningImages() {
    return diningImages;
  }

  public void setDiningImages(List<String> diningImages) {
    this.diningImages = diningImages;
  }

  public DiningOfferResponseItemSchema diningRating(Float diningRating) {
    this.diningRating = diningRating;
    return this;
  }

   /**
   * Rating of the dining establishment based on customer reviews.
   * @return diningRating
  **/
  @Schema(description = "Rating of the dining establishment based on customer reviews.")
  public Float getDiningRating() {
    return diningRating;
  }

  public void setDiningRating(Float diningRating) {
    this.diningRating = diningRating;
  }

  public DiningOfferResponseItemSchema diningReviews(List<String> diningReviews) {
    this.diningReviews = diningReviews;
    return this;
  }

  public DiningOfferResponseItemSchema addDiningReviewsItem(String diningReviewsItem) {
    if (this.diningReviews == null) {
      this.diningReviews = new ArrayList<String>();
    }
    this.diningReviews.add(diningReviewsItem);
    return this;
  }

   /**
   * Customer reviews for the dining establishment.
   * @return diningReviews
  **/
  @Schema(description = "Customer reviews for the dining establishment.")
  public List<String> getDiningReviews() {
    return diningReviews;
  }

  public void setDiningReviews(List<String> diningReviews) {
    this.diningReviews = diningReviews;
  }

  public DiningOfferResponseItemSchema diningSubcategories(List<String> diningSubcategories) {
    this.diningSubcategories = diningSubcategories;
    return this;
  }

  public DiningOfferResponseItemSchema addDiningSubcategoriesItem(String diningSubcategoriesItem) {
    if (this.diningSubcategories == null) {
      this.diningSubcategories = new ArrayList<String>();
    }
    this.diningSubcategories.add(diningSubcategoriesItem);
    return this;
  }

   /**
   * List of subcategories the dining offer belongs to (e.g., Italian, Seafood, Fine Dining).
   * @return diningSubcategories
  **/
  @Schema(description = "List of subcategories the dining offer belongs to (e.g., Italian, Seafood, Fine Dining).")
  public List<String> getDiningSubcategories() {
    return diningSubcategories;
  }

  public void setDiningSubcategories(List<String> diningSubcategories) {
    this.diningSubcategories = diningSubcategories;
  }

  public DiningOfferResponseItemSchema diningHours(List<String> diningHours) {
    this.diningHours = diningHours;
    return this;
  }

  public DiningOfferResponseItemSchema addDiningHoursItem(String diningHoursItem) {
    if (this.diningHours == null) {
      this.diningHours = new ArrayList<String>();
    }
    this.diningHours.add(diningHoursItem);
    return this;
  }

   /**
   * Operating hours of the dining establishment.
   * @return diningHours
  **/
  @Schema(description = "Operating hours of the dining establishment.")
  public List<String> getDiningHours() {
    return diningHours;
  }

  public void setDiningHours(List<String> diningHours) {
    this.diningHours = diningHours;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DiningOfferResponseItemSchema diningOfferResponseItemSchema = (DiningOfferResponseItemSchema) o;
    return Objects.equals(this.offerId, diningOfferResponseItemSchema.offerId) &&
        Objects.equals(this.supplierOfferId, diningOfferResponseItemSchema.supplierOfferId) &&
        Objects.equals(this.offerIndex, diningOfferResponseItemSchema.offerIndex) &&
        Objects.equals(this.offerTax, diningOfferResponseItemSchema.offerTax) &&
        Objects.equals(this.offerPrice, diningOfferResponseItemSchema.offerPrice) &&
        Objects.equals(this.offerCurrency, diningOfferResponseItemSchema.offerCurrency) &&
        Objects.equals(this.offerCancellationPolicies, diningOfferResponseItemSchema.offerCancellationPolicies) &&
        Objects.equals(this.diningName, diningOfferResponseItemSchema.diningName) &&
        Objects.equals(this.diningDescription, diningOfferResponseItemSchema.diningDescription) &&
        Objects.equals(this.diningAddress, diningOfferResponseItemSchema.diningAddress) &&
        Objects.equals(this.diningLatitude, diningOfferResponseItemSchema.diningLatitude) &&
        Objects.equals(this.diningLongitude, diningOfferResponseItemSchema.diningLongitude) &&
        Objects.equals(this.diningDistance, diningOfferResponseItemSchema.diningDistance) &&
        Objects.equals(this.diningDistanceMetric, diningOfferResponseItemSchema.diningDistanceMetric) &&
        Objects.equals(this.diningImages, diningOfferResponseItemSchema.diningImages) &&
        Objects.equals(this.diningRating, diningOfferResponseItemSchema.diningRating) &&
        Objects.equals(this.diningReviews, diningOfferResponseItemSchema.diningReviews) &&
        Objects.equals(this.diningSubcategories, diningOfferResponseItemSchema.diningSubcategories) &&
        Objects.equals(this.diningHours, diningOfferResponseItemSchema.diningHours);
  }

  @Override
  public int hashCode() {
    return Objects.hash(offerId, supplierOfferId, offerIndex, offerTax, offerPrice, offerCurrency, offerCancellationPolicies, diningName, diningDescription, diningAddress, diningLatitude, diningLongitude, diningDistance, diningDistanceMetric, diningImages, diningRating, diningReviews, diningSubcategories, diningHours);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DiningOfferResponseItemSchema {\n");
    
    sb.append("    offerId: ").append(toIndentedString(offerId)).append("\n");
    sb.append("    supplierOfferId: ").append(toIndentedString(supplierOfferId)).append("\n");
    sb.append("    offerIndex: ").append(toIndentedString(offerIndex)).append("\n");
    sb.append("    offerTax: ").append(toIndentedString(offerTax)).append("\n");
    sb.append("    offerPrice: ").append(toIndentedString(offerPrice)).append("\n");
    sb.append("    offerCurrency: ").append(toIndentedString(offerCurrency)).append("\n");
    sb.append("    offerCancellationPolicies: ").append(toIndentedString(offerCancellationPolicies)).append("\n");
    sb.append("    diningName: ").append(toIndentedString(diningName)).append("\n");
    sb.append("    diningDescription: ").append(toIndentedString(diningDescription)).append("\n");
    sb.append("    diningAddress: ").append(toIndentedString(diningAddress)).append("\n");
    sb.append("    diningLatitude: ").append(toIndentedString(diningLatitude)).append("\n");
    sb.append("    diningLongitude: ").append(toIndentedString(diningLongitude)).append("\n");
    sb.append("    diningDistance: ").append(toIndentedString(diningDistance)).append("\n");
    sb.append("    diningDistanceMetric: ").append(toIndentedString(diningDistanceMetric)).append("\n");
    sb.append("    diningImages: ").append(toIndentedString(diningImages)).append("\n");
    sb.append("    diningRating: ").append(toIndentedString(diningRating)).append("\n");
    sb.append("    diningReviews: ").append(toIndentedString(diningReviews)).append("\n");
    sb.append("    diningSubcategories: ").append(toIndentedString(diningSubcategories)).append("\n");
    sb.append("    diningHours: ").append(toIndentedString(diningHours)).append("\n");
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