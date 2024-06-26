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
import io.swagger.client.model.CarBookingCustomerSchema;
import io.swagger.client.model.CarOfferRequestSchema;
import io.swagger.client.model.CarOfferResponseItemSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
import java.util.UUID;
/**
 * CarBookingDetailsResponseSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class CarBookingDetailsResponseSchema {
  @SerializedName("company_id")
  private UUID companyId = null;

  @SerializedName("tenant_id")
  private UUID tenantId = null;

  @SerializedName("category_id")
  private UUID categoryId = null;

  @SerializedName("supplier_id")
  private UUID supplierId = null;

  @SerializedName("booking_id")
  private UUID bookingId = null;

  @SerializedName("supplier_booking_id")
  private UUID supplierBookingId = null;

  @SerializedName("supplier_booking_reference")
  private String supplierBookingReference = null;

  @SerializedName("customer_reference")
  private String customerReference = null;

  @SerializedName("booking_reference")
  private String bookingReference = null;

  @SerializedName("payment_reference")
  private String paymentReference = null;

  @SerializedName("booking_status")
  private String bookingStatus = null;

  @SerializedName("booking_tax")
  private BigDecimal bookingTax = null;

  @SerializedName("booking_price")
  private BigDecimal bookingPrice = null;

  @SerializedName("booking_currency")
  private String bookingCurrency = null;

  @SerializedName("booking_cancelation_policies")
  private String bookingCancelationPolicies = null;

  @SerializedName("customer")
  private CarBookingCustomerSchema customer = null;

  @SerializedName("offer_request")
  private CarOfferRequestSchema offerRequest = null;

  @SerializedName("offer")
  private CarOfferResponseItemSchema offer = null;

  @SerializedName("success")
  private Boolean success = null;

  @SerializedName("error_message")
  private String errorMessage = null;

  public CarBookingDetailsResponseSchema companyId(UUID companyId) {
    this.companyId = companyId;
    return this;
  }

   /**
   * Identifier for the company associated with the booking.
   * @return companyId
  **/
  @Schema(description = "Identifier for the company associated with the booking.")
  public UUID getCompanyId() {
    return companyId;
  }

  public void setCompanyId(UUID companyId) {
    this.companyId = companyId;
  }

  public CarBookingDetailsResponseSchema tenantId(UUID tenantId) {
    this.tenantId = tenantId;
    return this;
  }

   /**
   * Identifier for the tenant associated with the booking.
   * @return tenantId
  **/
  @Schema(description = "Identifier for the tenant associated with the booking.")
  public UUID getTenantId() {
    return tenantId;
  }

  public void setTenantId(UUID tenantId) {
    this.tenantId = tenantId;
  }

  public CarBookingDetailsResponseSchema categoryId(UUID categoryId) {
    this.categoryId = categoryId;
    return this;
  }

   /**
   * Identifier for the category of the booking.
   * @return categoryId
  **/
  @Schema(description = "Identifier for the category of the booking.")
  public UUID getCategoryId() {
    return categoryId;
  }

  public void setCategoryId(UUID categoryId) {
    this.categoryId = categoryId;
  }

  public CarBookingDetailsResponseSchema supplierId(UUID supplierId) {
    this.supplierId = supplierId;
    return this;
  }

   /**
   * Identifier for the supplier of the booking.
   * @return supplierId
  **/
  @Schema(description = "Identifier for the supplier of the booking.")
  public UUID getSupplierId() {
    return supplierId;
  }

  public void setSupplierId(UUID supplierId) {
    this.supplierId = supplierId;
  }

  public CarBookingDetailsResponseSchema bookingId(UUID bookingId) {
    this.bookingId = bookingId;
    return this;
  }

   /**
   * Unique identifier for the booking.
   * @return bookingId
  **/
  @Schema(description = "Unique identifier for the booking.")
  public UUID getBookingId() {
    return bookingId;
  }

  public void setBookingId(UUID bookingId) {
    this.bookingId = bookingId;
  }

  public CarBookingDetailsResponseSchema supplierBookingId(UUID supplierBookingId) {
    this.supplierBookingId = supplierBookingId;
    return this;
  }

   /**
   * Supplier’s identifier for the booking.
   * @return supplierBookingId
  **/
  @Schema(description = "Supplier’s identifier for the booking.")
  public UUID getSupplierBookingId() {
    return supplierBookingId;
  }

  public void setSupplierBookingId(UUID supplierBookingId) {
    this.supplierBookingId = supplierBookingId;
  }

  public CarBookingDetailsResponseSchema supplierBookingReference(String supplierBookingReference) {
    this.supplierBookingReference = supplierBookingReference;
    return this;
  }

   /**
   * Reference number provided by the supplier for the booking.
   * @return supplierBookingReference
  **/
  @Schema(description = "Reference number provided by the supplier for the booking.")
  public String getSupplierBookingReference() {
    return supplierBookingReference;
  }

  public void setSupplierBookingReference(String supplierBookingReference) {
    this.supplierBookingReference = supplierBookingReference;
  }

  public CarBookingDetailsResponseSchema customerReference(String customerReference) {
    this.customerReference = customerReference;
    return this;
  }

   /**
   * Customer reference number associated with the booking.
   * @return customerReference
  **/
  @Schema(description = "Customer reference number associated with the booking.")
  public String getCustomerReference() {
    return customerReference;
  }

  public void setCustomerReference(String customerReference) {
    this.customerReference = customerReference;
  }

  public CarBookingDetailsResponseSchema bookingReference(String bookingReference) {
    this.bookingReference = bookingReference;
    return this;
  }

   /**
   * Internal reference number for the booking.
   * @return bookingReference
  **/
  @Schema(description = "Internal reference number for the booking.")
  public String getBookingReference() {
    return bookingReference;
  }

  public void setBookingReference(String bookingReference) {
    this.bookingReference = bookingReference;
  }

  public CarBookingDetailsResponseSchema paymentReference(String paymentReference) {
    this.paymentReference = paymentReference;
    return this;
  }

   /**
   * Reference number for the payment associated with the booking.
   * @return paymentReference
  **/
  @Schema(description = "Reference number for the payment associated with the booking.")
  public String getPaymentReference() {
    return paymentReference;
  }

  public void setPaymentReference(String paymentReference) {
    this.paymentReference = paymentReference;
  }

  public CarBookingDetailsResponseSchema bookingStatus(String bookingStatus) {
    this.bookingStatus = bookingStatus;
    return this;
  }

   /**
   * Current status of the booking.
   * @return bookingStatus
  **/
  @Schema(description = "Current status of the booking.")
  public String getBookingStatus() {
    return bookingStatus;
  }

  public void setBookingStatus(String bookingStatus) {
    this.bookingStatus = bookingStatus;
  }

  public CarBookingDetailsResponseSchema bookingTax(BigDecimal bookingTax) {
    this.bookingTax = bookingTax;
    return this;
  }

   /**
   * Tax applied to the booking.
   * @return bookingTax
  **/
  @Schema(description = "Tax applied to the booking.")
  public BigDecimal getBookingTax() {
    return bookingTax;
  }

  public void setBookingTax(BigDecimal bookingTax) {
    this.bookingTax = bookingTax;
  }

  public CarBookingDetailsResponseSchema bookingPrice(BigDecimal bookingPrice) {
    this.bookingPrice = bookingPrice;
    return this;
  }

   /**
   * Total price of the booking.
   * @return bookingPrice
  **/
  @Schema(description = "Total price of the booking.")
  public BigDecimal getBookingPrice() {
    return bookingPrice;
  }

  public void setBookingPrice(BigDecimal bookingPrice) {
    this.bookingPrice = bookingPrice;
  }

  public CarBookingDetailsResponseSchema bookingCurrency(String bookingCurrency) {
    this.bookingCurrency = bookingCurrency;
    return this;
  }

   /**
   * Currency used for the booking pricing.
   * @return bookingCurrency
  **/
  @Schema(description = "Currency used for the booking pricing.")
  public String getBookingCurrency() {
    return bookingCurrency;
  }

  public void setBookingCurrency(String bookingCurrency) {
    this.bookingCurrency = bookingCurrency;
  }

  public CarBookingDetailsResponseSchema bookingCancelationPolicies(String bookingCancelationPolicies) {
    this.bookingCancelationPolicies = bookingCancelationPolicies;
    return this;
  }

   /**
   * Cancellation policies applicable to the booking.
   * @return bookingCancelationPolicies
  **/
  @Schema(description = "Cancellation policies applicable to the booking.")
  public String getBookingCancelationPolicies() {
    return bookingCancelationPolicies;
  }

  public void setBookingCancelationPolicies(String bookingCancelationPolicies) {
    this.bookingCancelationPolicies = bookingCancelationPolicies;
  }

  public CarBookingDetailsResponseSchema customer(CarBookingCustomerSchema customer) {
    this.customer = customer;
    return this;
  }

   /**
   * Get customer
   * @return customer
  **/
  @Schema(description = "")
  public CarBookingCustomerSchema getCustomer() {
    return customer;
  }

  public void setCustomer(CarBookingCustomerSchema customer) {
    this.customer = customer;
  }

  public CarBookingDetailsResponseSchema offerRequest(CarOfferRequestSchema offerRequest) {
    this.offerRequest = offerRequest;
    return this;
  }

   /**
   * Get offerRequest
   * @return offerRequest
  **/
  @Schema(description = "")
  public CarOfferRequestSchema getOfferRequest() {
    return offerRequest;
  }

  public void setOfferRequest(CarOfferRequestSchema offerRequest) {
    this.offerRequest = offerRequest;
  }

  public CarBookingDetailsResponseSchema offer(CarOfferResponseItemSchema offer) {
    this.offer = offer;
    return this;
  }

   /**
   * Get offer
   * @return offer
  **/
  @Schema(description = "")
  public CarOfferResponseItemSchema getOffer() {
    return offer;
  }

  public void setOffer(CarOfferResponseItemSchema offer) {
    this.offer = offer;
  }

  public CarBookingDetailsResponseSchema success(Boolean success) {
    this.success = success;
    return this;
  }

   /**
   * Indicates if the booking was successful.
   * @return success
  **/
  @Schema(description = "Indicates if the booking was successful.")
  public Boolean isSuccess() {
    return success;
  }

  public void setSuccess(Boolean success) {
    this.success = success;
  }

  public CarBookingDetailsResponseSchema errorMessage(String errorMessage) {
    this.errorMessage = errorMessage;
    return this;
  }

   /**
   * Provides details on any error that occurred during the booking process.
   * @return errorMessage
  **/
  @Schema(description = "Provides details on any error that occurred during the booking process.")
  public String getErrorMessage() {
    return errorMessage;
  }

  public void setErrorMessage(String errorMessage) {
    this.errorMessage = errorMessage;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CarBookingDetailsResponseSchema carBookingDetailsResponseSchema = (CarBookingDetailsResponseSchema) o;
    return Objects.equals(this.companyId, carBookingDetailsResponseSchema.companyId) &&
        Objects.equals(this.tenantId, carBookingDetailsResponseSchema.tenantId) &&
        Objects.equals(this.categoryId, carBookingDetailsResponseSchema.categoryId) &&
        Objects.equals(this.supplierId, carBookingDetailsResponseSchema.supplierId) &&
        Objects.equals(this.bookingId, carBookingDetailsResponseSchema.bookingId) &&
        Objects.equals(this.supplierBookingId, carBookingDetailsResponseSchema.supplierBookingId) &&
        Objects.equals(this.supplierBookingReference, carBookingDetailsResponseSchema.supplierBookingReference) &&
        Objects.equals(this.customerReference, carBookingDetailsResponseSchema.customerReference) &&
        Objects.equals(this.bookingReference, carBookingDetailsResponseSchema.bookingReference) &&
        Objects.equals(this.paymentReference, carBookingDetailsResponseSchema.paymentReference) &&
        Objects.equals(this.bookingStatus, carBookingDetailsResponseSchema.bookingStatus) &&
        Objects.equals(this.bookingTax, carBookingDetailsResponseSchema.bookingTax) &&
        Objects.equals(this.bookingPrice, carBookingDetailsResponseSchema.bookingPrice) &&
        Objects.equals(this.bookingCurrency, carBookingDetailsResponseSchema.bookingCurrency) &&
        Objects.equals(this.bookingCancelationPolicies, carBookingDetailsResponseSchema.bookingCancelationPolicies) &&
        Objects.equals(this.customer, carBookingDetailsResponseSchema.customer) &&
        Objects.equals(this.offerRequest, carBookingDetailsResponseSchema.offerRequest) &&
        Objects.equals(this.offer, carBookingDetailsResponseSchema.offer) &&
        Objects.equals(this.success, carBookingDetailsResponseSchema.success) &&
        Objects.equals(this.errorMessage, carBookingDetailsResponseSchema.errorMessage);
  }

  @Override
  public int hashCode() {
    return Objects.hash(companyId, tenantId, categoryId, supplierId, bookingId, supplierBookingId, supplierBookingReference, customerReference, bookingReference, paymentReference, bookingStatus, bookingTax, bookingPrice, bookingCurrency, bookingCancelationPolicies, customer, offerRequest, offer, success, errorMessage);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CarBookingDetailsResponseSchema {\n");
    
    sb.append("    companyId: ").append(toIndentedString(companyId)).append("\n");
    sb.append("    tenantId: ").append(toIndentedString(tenantId)).append("\n");
    sb.append("    categoryId: ").append(toIndentedString(categoryId)).append("\n");
    sb.append("    supplierId: ").append(toIndentedString(supplierId)).append("\n");
    sb.append("    bookingId: ").append(toIndentedString(bookingId)).append("\n");
    sb.append("    supplierBookingId: ").append(toIndentedString(supplierBookingId)).append("\n");
    sb.append("    supplierBookingReference: ").append(toIndentedString(supplierBookingReference)).append("\n");
    sb.append("    customerReference: ").append(toIndentedString(customerReference)).append("\n");
    sb.append("    bookingReference: ").append(toIndentedString(bookingReference)).append("\n");
    sb.append("    paymentReference: ").append(toIndentedString(paymentReference)).append("\n");
    sb.append("    bookingStatus: ").append(toIndentedString(bookingStatus)).append("\n");
    sb.append("    bookingTax: ").append(toIndentedString(bookingTax)).append("\n");
    sb.append("    bookingPrice: ").append(toIndentedString(bookingPrice)).append("\n");
    sb.append("    bookingCurrency: ").append(toIndentedString(bookingCurrency)).append("\n");
    sb.append("    bookingCancelationPolicies: ").append(toIndentedString(bookingCancelationPolicies)).append("\n");
    sb.append("    customer: ").append(toIndentedString(customer)).append("\n");
    sb.append("    offerRequest: ").append(toIndentedString(offerRequest)).append("\n");
    sb.append("    offer: ").append(toIndentedString(offer)).append("\n");
    sb.append("    success: ").append(toIndentedString(success)).append("\n");
    sb.append("    errorMessage: ").append(toIndentedString(errorMessage)).append("\n");
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
