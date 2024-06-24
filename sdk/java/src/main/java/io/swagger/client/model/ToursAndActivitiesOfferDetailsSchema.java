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
import io.swagger.client.model.ToursAndActivitiesVariantSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;
import org.threeten.bp.LocalDate;
/**
 * ToursAndActivitiesOfferDetailsSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class ToursAndActivitiesOfferDetailsSchema {
  @SerializedName("offer_id")
  private UUID offerId = null;

  @SerializedName("supplier_offer_id")
  private UUID supplierOfferId = null;

  @SerializedName("offer_index")
  private Integer offerIndex = null;

  @SerializedName("offer_tax")
  private BigDecimal offerTax = null;

  @SerializedName("offer_price")
  private BigDecimal offerPrice = null;

  @SerializedName("offer_currency")
  private String offerCurrency = null;

  @SerializedName("offer_cancelation_policies")
  private String offerCancelationPolicies = null;

  @SerializedName("date")
  private LocalDate date = null;

  @SerializedName("adults")
  private Integer adults = null;

  @SerializedName("children")
  private Integer children = null;

  @SerializedName("tour_name")
  private String tourName = null;

  @SerializedName("tour_description")
  private String tourDescription = null;

  @SerializedName("tour_address")
  private String tourAddress = null;

  @SerializedName("tour_latitude")
  private Float tourLatitude = null;

  @SerializedName("tour_longitude")
  private Float tourLongitude = null;

  @SerializedName("tour_distance")
  private Float tourDistance = null;

  @SerializedName("tour_distance_metric")
  private String tourDistanceMetric = null;

  @SerializedName("tour_images")
  private List<String> tourImages = null;

  @SerializedName("tour_rating")
  private Float tourRating = null;

  @SerializedName("tour_reviews")
  private List<String> tourReviews = null;

  @SerializedName("tour_subcategories")
  private List<String> tourSubcategories = null;

  @SerializedName("booking_questions")
  private List<String> bookingQuestions = null;

  @SerializedName("variants")
  private List<ToursAndActivitiesVariantSchema> variants = null;

  public ToursAndActivitiesOfferDetailsSchema offerId(UUID offerId) {
    this.offerId = offerId;
    return this;
  }

   /**
   * Identifier of the individual offer.
   * @return offerId
  **/
  @Schema(description = "Identifier of the individual offer.")
  public UUID getOfferId() {
    return offerId;
  }

  public void setOfferId(UUID offerId) {
    this.offerId = offerId;
  }

  public ToursAndActivitiesOfferDetailsSchema supplierOfferId(UUID supplierOfferId) {
    this.supplierOfferId = supplierOfferId;
    return this;
  }

   /**
   * Identifier provided by the supplier for the offer.
   * @return supplierOfferId
  **/
  @Schema(description = "Identifier provided by the supplier for the offer.")
  public UUID getSupplierOfferId() {
    return supplierOfferId;
  }

  public void setSupplierOfferId(UUID supplierOfferId) {
    this.supplierOfferId = supplierOfferId;
  }

  public ToursAndActivitiesOfferDetailsSchema offerIndex(Integer offerIndex) {
    this.offerIndex = offerIndex;
    return this;
  }

   /**
   * Index of the offer for ordering.
   * @return offerIndex
  **/
  @Schema(description = "Index of the offer for ordering.")
  public Integer getOfferIndex() {
    return offerIndex;
  }

  public void setOfferIndex(Integer offerIndex) {
    this.offerIndex = offerIndex;
  }

  public ToursAndActivitiesOfferDetailsSchema offerTax(BigDecimal offerTax) {
    this.offerTax = offerTax;
    return this;
  }

   /**
   * Tax applied on the offer.
   * @return offerTax
  **/
  @Schema(description = "Tax applied on the offer.")
  public BigDecimal getOfferTax() {
    return offerTax;
  }

  public void setOfferTax(BigDecimal offerTax) {
    this.offerTax = offerTax;
  }

  public ToursAndActivitiesOfferDetailsSchema offerPrice(BigDecimal offerPrice) {
    this.offerPrice = offerPrice;
    return this;
  }

   /**
   * Price of the offer.
   * @return offerPrice
  **/
  @Schema(description = "Price of the offer.")
  public BigDecimal getOfferPrice() {
    return offerPrice;
  }

  public void setOfferPrice(BigDecimal offerPrice) {
    this.offerPrice = offerPrice;
  }

  public ToursAndActivitiesOfferDetailsSchema offerCurrency(String offerCurrency) {
    this.offerCurrency = offerCurrency;
    return this;
  }

   /**
   * Currency of the offer price.
   * @return offerCurrency
  **/
  @Schema(description = "Currency of the offer price.")
  public String getOfferCurrency() {
    return offerCurrency;
  }

  public void setOfferCurrency(String offerCurrency) {
    this.offerCurrency = offerCurrency;
  }

  public ToursAndActivitiesOfferDetailsSchema offerCancelationPolicies(String offerCancelationPolicies) {
    this.offerCancelationPolicies = offerCancelationPolicies;
    return this;
  }

   /**
   * Cancellation policies applicable to the offer.
   * @return offerCancelationPolicies
  **/
  @Schema(description = "Cancellation policies applicable to the offer.")
  public String getOfferCancelationPolicies() {
    return offerCancelationPolicies;
  }

  public void setOfferCancelationPolicies(String offerCancelationPolicies) {
    this.offerCancelationPolicies = offerCancelationPolicies;
  }

  public ToursAndActivitiesOfferDetailsSchema date(LocalDate date) {
    this.date = date;
    return this;
  }

   /**
   * Date of the tour.
   * @return date
  **/
  @Schema(description = "Date of the tour.")
  public LocalDate getDate() {
    return date;
  }

  public void setDate(LocalDate date) {
    this.date = date;
  }

  public ToursAndActivitiesOfferDetailsSchema adults(Integer adults) {
    this.adults = adults;
    return this;
  }

   /**
   * Number of adults attending.
   * @return adults
  **/
  @Schema(description = "Number of adults attending.")
  public Integer getAdults() {
    return adults;
  }

  public void setAdults(Integer adults) {
    this.adults = adults;
  }

  public ToursAndActivitiesOfferDetailsSchema children(Integer children) {
    this.children = children;
    return this;
  }

   /**
   * Number of children attending.
   * @return children
  **/
  @Schema(description = "Number of children attending.")
  public Integer getChildren() {
    return children;
  }

  public void setChildren(Integer children) {
    this.children = children;
  }

  public ToursAndActivitiesOfferDetailsSchema tourName(String tourName) {
    this.tourName = tourName;
    return this;
  }

   /**
   * Name of the tour.
   * @return tourName
  **/
  @Schema(description = "Name of the tour.")
  public String getTourName() {
    return tourName;
  }

  public void setTourName(String tourName) {
    this.tourName = tourName;
  }

  public ToursAndActivitiesOfferDetailsSchema tourDescription(String tourDescription) {
    this.tourDescription = tourDescription;
    return this;
  }

   /**
   * Description of the tour.
   * @return tourDescription
  **/
  @Schema(description = "Description of the tour.")
  public String getTourDescription() {
    return tourDescription;
  }

  public void setTourDescription(String tourDescription) {
    this.tourDescription = tourDescription;
  }

  public ToursAndActivitiesOfferDetailsSchema tourAddress(String tourAddress) {
    this.tourAddress = tourAddress;
    return this;
  }

   /**
   * Address where the tour will take place.
   * @return tourAddress
  **/
  @Schema(description = "Address where the tour will take place.")
  public String getTourAddress() {
    return tourAddress;
  }

  public void setTourAddress(String tourAddress) {
    this.tourAddress = tourAddress;
  }

  public ToursAndActivitiesOfferDetailsSchema tourLatitude(Float tourLatitude) {
    this.tourLatitude = tourLatitude;
    return this;
  }

   /**
   * Latitude for the tour location.
   * @return tourLatitude
  **/
  @Schema(description = "Latitude for the tour location.")
  public Float getTourLatitude() {
    return tourLatitude;
  }

  public void setTourLatitude(Float tourLatitude) {
    this.tourLatitude = tourLatitude;
  }

  public ToursAndActivitiesOfferDetailsSchema tourLongitude(Float tourLongitude) {
    this.tourLongitude = tourLongitude;
    return this;
  }

   /**
   * Longitude for the tour location.
   * @return tourLongitude
  **/
  @Schema(description = "Longitude for the tour location.")
  public Float getTourLongitude() {
    return tourLongitude;
  }

  public void setTourLongitude(Float tourLongitude) {
    this.tourLongitude = tourLongitude;
  }

  public ToursAndActivitiesOfferDetailsSchema tourDistance(Float tourDistance) {
    this.tourDistance = tourDistance;
    return this;
  }

   /**
   * Distance covered by the tour.
   * @return tourDistance
  **/
  @Schema(description = "Distance covered by the tour.")
  public Float getTourDistance() {
    return tourDistance;
  }

  public void setTourDistance(Float tourDistance) {
    this.tourDistance = tourDistance;
  }

  public ToursAndActivitiesOfferDetailsSchema tourDistanceMetric(String tourDistanceMetric) {
    this.tourDistanceMetric = tourDistanceMetric;
    return this;
  }

   /**
   * Metric for measuring distance (miles or kilometers).
   * @return tourDistanceMetric
  **/
  @Schema(description = "Metric for measuring distance (miles or kilometers).")
  public String getTourDistanceMetric() {
    return tourDistanceMetric;
  }

  public void setTourDistanceMetric(String tourDistanceMetric) {
    this.tourDistanceMetric = tourDistanceMetric;
  }

  public ToursAndActivitiesOfferDetailsSchema tourImages(List<String> tourImages) {
    this.tourImages = tourImages;
    return this;
  }

  public ToursAndActivitiesOfferDetailsSchema addTourImagesItem(String tourImagesItem) {
    if (this.tourImages == null) {
      this.tourImages = new ArrayList<String>();
    }
    this.tourImages.add(tourImagesItem);
    return this;
  }

   /**
   * Array of images related to the tour.
   * @return tourImages
  **/
  @Schema(description = "Array of images related to the tour.")
  public List<String> getTourImages() {
    return tourImages;
  }

  public void setTourImages(List<String> tourImages) {
    this.tourImages = tourImages;
  }

  public ToursAndActivitiesOfferDetailsSchema tourRating(Float tourRating) {
    this.tourRating = tourRating;
    return this;
  }

   /**
   * Rating of the tour.
   * @return tourRating
  **/
  @Schema(description = "Rating of the tour.")
  public Float getTourRating() {
    return tourRating;
  }

  public void setTourRating(Float tourRating) {
    this.tourRating = tourRating;
  }

  public ToursAndActivitiesOfferDetailsSchema tourReviews(List<String> tourReviews) {
    this.tourReviews = tourReviews;
    return this;
  }

  public ToursAndActivitiesOfferDetailsSchema addTourReviewsItem(String tourReviewsItem) {
    if (this.tourReviews == null) {
      this.tourReviews = new ArrayList<String>();
    }
    this.tourReviews.add(tourReviewsItem);
    return this;
  }

   /**
   * Array of reviews for the tour.
   * @return tourReviews
  **/
  @Schema(description = "Array of reviews for the tour.")
  public List<String> getTourReviews() {
    return tourReviews;
  }

  public void setTourReviews(List<String> tourReviews) {
    this.tourReviews = tourReviews;
  }

  public ToursAndActivitiesOfferDetailsSchema tourSubcategories(List<String> tourSubcategories) {
    this.tourSubcategories = tourSubcategories;
    return this;
  }

  public ToursAndActivitiesOfferDetailsSchema addTourSubcategoriesItem(String tourSubcategoriesItem) {
    if (this.tourSubcategories == null) {
      this.tourSubcategories = new ArrayList<String>();
    }
    this.tourSubcategories.add(tourSubcategoriesItem);
    return this;
  }

   /**
   * Subcategories of the tour.
   * @return tourSubcategories
  **/
  @Schema(description = "Subcategories of the tour.")
  public List<String> getTourSubcategories() {
    return tourSubcategories;
  }

  public void setTourSubcategories(List<String> tourSubcategories) {
    this.tourSubcategories = tourSubcategories;
  }

  public ToursAndActivitiesOfferDetailsSchema bookingQuestions(List<String> bookingQuestions) {
    this.bookingQuestions = bookingQuestions;
    return this;
  }

  public ToursAndActivitiesOfferDetailsSchema addBookingQuestionsItem(String bookingQuestionsItem) {
    if (this.bookingQuestions == null) {
      this.bookingQuestions = new ArrayList<String>();
    }
    this.bookingQuestions.add(bookingQuestionsItem);
    return this;
  }

   /**
   * Questions related to booking the tour.
   * @return bookingQuestions
  **/
  @Schema(description = "Questions related to booking the tour.")
  public List<String> getBookingQuestions() {
    return bookingQuestions;
  }

  public void setBookingQuestions(List<String> bookingQuestions) {
    this.bookingQuestions = bookingQuestions;
  }

  public ToursAndActivitiesOfferDetailsSchema variants(List<ToursAndActivitiesVariantSchema> variants) {
    this.variants = variants;
    return this;
  }

  public ToursAndActivitiesOfferDetailsSchema addVariantsItem(ToursAndActivitiesVariantSchema variantsItem) {
    if (this.variants == null) {
      this.variants = new ArrayList<ToursAndActivitiesVariantSchema>();
    }
    this.variants.add(variantsItem);
    return this;
  }

   /**
   * Array of ToursAndActivitiesVariantSchema.
   * @return variants
  **/
  @Schema(description = "Array of ToursAndActivitiesVariantSchema.")
  public List<ToursAndActivitiesVariantSchema> getVariants() {
    return variants;
  }

  public void setVariants(List<ToursAndActivitiesVariantSchema> variants) {
    this.variants = variants;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ToursAndActivitiesOfferDetailsSchema toursAndActivitiesOfferDetailsSchema = (ToursAndActivitiesOfferDetailsSchema) o;
    return Objects.equals(this.offerId, toursAndActivitiesOfferDetailsSchema.offerId) &&
        Objects.equals(this.supplierOfferId, toursAndActivitiesOfferDetailsSchema.supplierOfferId) &&
        Objects.equals(this.offerIndex, toursAndActivitiesOfferDetailsSchema.offerIndex) &&
        Objects.equals(this.offerTax, toursAndActivitiesOfferDetailsSchema.offerTax) &&
        Objects.equals(this.offerPrice, toursAndActivitiesOfferDetailsSchema.offerPrice) &&
        Objects.equals(this.offerCurrency, toursAndActivitiesOfferDetailsSchema.offerCurrency) &&
        Objects.equals(this.offerCancelationPolicies, toursAndActivitiesOfferDetailsSchema.offerCancelationPolicies) &&
        Objects.equals(this.date, toursAndActivitiesOfferDetailsSchema.date) &&
        Objects.equals(this.adults, toursAndActivitiesOfferDetailsSchema.adults) &&
        Objects.equals(this.children, toursAndActivitiesOfferDetailsSchema.children) &&
        Objects.equals(this.tourName, toursAndActivitiesOfferDetailsSchema.tourName) &&
        Objects.equals(this.tourDescription, toursAndActivitiesOfferDetailsSchema.tourDescription) &&
        Objects.equals(this.tourAddress, toursAndActivitiesOfferDetailsSchema.tourAddress) &&
        Objects.equals(this.tourLatitude, toursAndActivitiesOfferDetailsSchema.tourLatitude) &&
        Objects.equals(this.tourLongitude, toursAndActivitiesOfferDetailsSchema.tourLongitude) &&
        Objects.equals(this.tourDistance, toursAndActivitiesOfferDetailsSchema.tourDistance) &&
        Objects.equals(this.tourDistanceMetric, toursAndActivitiesOfferDetailsSchema.tourDistanceMetric) &&
        Objects.equals(this.tourImages, toursAndActivitiesOfferDetailsSchema.tourImages) &&
        Objects.equals(this.tourRating, toursAndActivitiesOfferDetailsSchema.tourRating) &&
        Objects.equals(this.tourReviews, toursAndActivitiesOfferDetailsSchema.tourReviews) &&
        Objects.equals(this.tourSubcategories, toursAndActivitiesOfferDetailsSchema.tourSubcategories) &&
        Objects.equals(this.bookingQuestions, toursAndActivitiesOfferDetailsSchema.bookingQuestions) &&
        Objects.equals(this.variants, toursAndActivitiesOfferDetailsSchema.variants);
  }

  @Override
  public int hashCode() {
    return Objects.hash(offerId, supplierOfferId, offerIndex, offerTax, offerPrice, offerCurrency, offerCancelationPolicies, date, adults, children, tourName, tourDescription, tourAddress, tourLatitude, tourLongitude, tourDistance, tourDistanceMetric, tourImages, tourRating, tourReviews, tourSubcategories, bookingQuestions, variants);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ToursAndActivitiesOfferDetailsSchema {\n");
    
    sb.append("    offerId: ").append(toIndentedString(offerId)).append("\n");
    sb.append("    supplierOfferId: ").append(toIndentedString(supplierOfferId)).append("\n");
    sb.append("    offerIndex: ").append(toIndentedString(offerIndex)).append("\n");
    sb.append("    offerTax: ").append(toIndentedString(offerTax)).append("\n");
    sb.append("    offerPrice: ").append(toIndentedString(offerPrice)).append("\n");
    sb.append("    offerCurrency: ").append(toIndentedString(offerCurrency)).append("\n");
    sb.append("    offerCancelationPolicies: ").append(toIndentedString(offerCancelationPolicies)).append("\n");
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
    sb.append("    adults: ").append(toIndentedString(adults)).append("\n");
    sb.append("    children: ").append(toIndentedString(children)).append("\n");
    sb.append("    tourName: ").append(toIndentedString(tourName)).append("\n");
    sb.append("    tourDescription: ").append(toIndentedString(tourDescription)).append("\n");
    sb.append("    tourAddress: ").append(toIndentedString(tourAddress)).append("\n");
    sb.append("    tourLatitude: ").append(toIndentedString(tourLatitude)).append("\n");
    sb.append("    tourLongitude: ").append(toIndentedString(tourLongitude)).append("\n");
    sb.append("    tourDistance: ").append(toIndentedString(tourDistance)).append("\n");
    sb.append("    tourDistanceMetric: ").append(toIndentedString(tourDistanceMetric)).append("\n");
    sb.append("    tourImages: ").append(toIndentedString(tourImages)).append("\n");
    sb.append("    tourRating: ").append(toIndentedString(tourRating)).append("\n");
    sb.append("    tourReviews: ").append(toIndentedString(tourReviews)).append("\n");
    sb.append("    tourSubcategories: ").append(toIndentedString(tourSubcategories)).append("\n");
    sb.append("    bookingQuestions: ").append(toIndentedString(bookingQuestions)).append("\n");
    sb.append("    variants: ").append(toIndentedString(variants)).append("\n");
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
