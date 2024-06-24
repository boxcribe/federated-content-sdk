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
import java.util.ArrayList;
import java.util.List;
import java.util.UUID;
import org.threeten.bp.LocalDate;
/**
 * HotelRoomSchema
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class HotelRoomSchema {
  @SerializedName("room_id")
  private UUID roomId = null;

  @SerializedName("supplier_room_id")
  private String supplierRoomId = null;

  @SerializedName("room_index")
  private Integer roomIndex = null;

  @SerializedName("checkin_date")
  private LocalDate checkinDate = null;

  @SerializedName("checkout_date")
  private LocalDate checkoutDate = null;

  @SerializedName("adults")
  private Integer adults = null;

  @SerializedName("children")
  private Integer children = null;

  @SerializedName("room_tax")
  private Double roomTax = null;

  @SerializedName("room_price")
  private Double roomPrice = null;

  @SerializedName("room_currency")
  private String roomCurrency = null;

  @SerializedName("room_cancellation_policies")
  private Object roomCancellationPolicies = null;

  @SerializedName("room_name")
  private String roomName = null;

  @SerializedName("room_description")
  private String roomDescription = null;

  @SerializedName("room_images")
  private List<String> roomImages = null;

  @SerializedName("room_quantity_max")
  private Integer roomQuantityMax = null;

  public HotelRoomSchema roomId(UUID roomId) {
    this.roomId = roomId;
    return this;
  }

   /**
   * Unique identifier for each room.
   * @return roomId
  **/
  @Schema(description = "Unique identifier for each room.")
  public UUID getRoomId() {
    return roomId;
  }

  public void setRoomId(UUID roomId) {
    this.roomId = roomId;
  }

  public HotelRoomSchema supplierRoomId(String supplierRoomId) {
    this.supplierRoomId = supplierRoomId;
    return this;
  }

   /**
   * Supplier specific identifier for the room.
   * @return supplierRoomId
  **/
  @Schema(description = "Supplier specific identifier for the room.")
  public String getSupplierRoomId() {
    return supplierRoomId;
  }

  public void setSupplierRoomId(String supplierRoomId) {
    this.supplierRoomId = supplierRoomId;
  }

  public HotelRoomSchema roomIndex(Integer roomIndex) {
    this.roomIndex = roomIndex;
    return this;
  }

   /**
   * Position of the room in the list.
   * @return roomIndex
  **/
  @Schema(description = "Position of the room in the list.")
  public Integer getRoomIndex() {
    return roomIndex;
  }

  public void setRoomIndex(Integer roomIndex) {
    this.roomIndex = roomIndex;
  }

  public HotelRoomSchema checkinDate(LocalDate checkinDate) {
    this.checkinDate = checkinDate;
    return this;
  }

   /**
   * Start date of the hotel reservation.
   * @return checkinDate
  **/
  @Schema(description = "Start date of the hotel reservation.")
  public LocalDate getCheckinDate() {
    return checkinDate;
  }

  public void setCheckinDate(LocalDate checkinDate) {
    this.checkinDate = checkinDate;
  }

  public HotelRoomSchema checkoutDate(LocalDate checkoutDate) {
    this.checkoutDate = checkoutDate;
    return this;
  }

   /**
   * End date of the hotel reservation.
   * @return checkoutDate
  **/
  @Schema(description = "End date of the hotel reservation.")
  public LocalDate getCheckoutDate() {
    return checkoutDate;
  }

  public void setCheckoutDate(LocalDate checkoutDate) {
    this.checkoutDate = checkoutDate;
  }

  public HotelRoomSchema adults(Integer adults) {
    this.adults = adults;
    return this;
  }

   /**
   * Number of adults that can be accommodated in the room.
   * @return adults
  **/
  @Schema(description = "Number of adults that can be accommodated in the room.")
  public Integer getAdults() {
    return adults;
  }

  public void setAdults(Integer adults) {
    this.adults = adults;
  }

  public HotelRoomSchema children(Integer children) {
    this.children = children;
    return this;
  }

   /**
   * Number of children that can be accommodated in the room.
   * @return children
  **/
  @Schema(description = "Number of children that can be accommodated in the room.")
  public Integer getChildren() {
    return children;
  }

  public void setChildren(Integer children) {
    this.children = children;
  }

  public HotelRoomSchema roomTax(Double roomTax) {
    this.roomTax = roomTax;
    return this;
  }

   /**
   * Tax rate applicable to the room price.
   * @return roomTax
  **/
  @Schema(description = "Tax rate applicable to the room price.")
  public Double getRoomTax() {
    return roomTax;
  }

  public void setRoomTax(Double roomTax) {
    this.roomTax = roomTax;
  }

  public HotelRoomSchema roomPrice(Double roomPrice) {
    this.roomPrice = roomPrice;
    return this;
  }

   /**
   * Nightly rate for the room.
   * @return roomPrice
  **/
  @Schema(description = "Nightly rate for the room.")
  public Double getRoomPrice() {
    return roomPrice;
  }

  public void setRoomPrice(Double roomPrice) {
    this.roomPrice = roomPrice;
  }

  public HotelRoomSchema roomCurrency(String roomCurrency) {
    this.roomCurrency = roomCurrency;
    return this;
  }

   /**
   * Currency used for the room pricing.
   * @return roomCurrency
  **/
  @Schema(description = "Currency used for the room pricing.")
  public String getRoomCurrency() {
    return roomCurrency;
  }

  public void setRoomCurrency(String roomCurrency) {
    this.roomCurrency = roomCurrency;
  }

  public HotelRoomSchema roomCancellationPolicies(Object roomCancellationPolicies) {
    this.roomCancellationPolicies = roomCancellationPolicies;
    return this;
  }

   /**
   * Details about the cancellation policy for the room.
   * @return roomCancellationPolicies
  **/
  @Schema(description = "Details about the cancellation policy for the room.")
  public Object getRoomCancellationPolicies() {
    return roomCancellationPolicies;
  }

  public void setRoomCancellationPolicies(Object roomCancellationPolicies) {
    this.roomCancellationPolicies = roomCancellationPolicies;
  }

  public HotelRoomSchema roomName(String roomName) {
    this.roomName = roomName;
    return this;
  }

   /**
   * Type or name of the room.
   * @return roomName
  **/
  @Schema(description = "Type or name of the room.")
  public String getRoomName() {
    return roomName;
  }

  public void setRoomName(String roomName) {
    this.roomName = roomName;
  }

  public HotelRoomSchema roomDescription(String roomDescription) {
    this.roomDescription = roomDescription;
    return this;
  }

   /**
   * Description of the room including amenities and features.
   * @return roomDescription
  **/
  @Schema(description = "Description of the room including amenities and features.")
  public String getRoomDescription() {
    return roomDescription;
  }

  public void setRoomDescription(String roomDescription) {
    this.roomDescription = roomDescription;
  }

  public HotelRoomSchema roomImages(List<String> roomImages) {
    this.roomImages = roomImages;
    return this;
  }

  public HotelRoomSchema addRoomImagesItem(String roomImagesItem) {
    if (this.roomImages == null) {
      this.roomImages = new ArrayList<String>();
    }
    this.roomImages.add(roomImagesItem);
    return this;
  }

   /**
   * Images showcasing the room.
   * @return roomImages
  **/
  @Schema(description = "Images showcasing the room.")
  public List<String> getRoomImages() {
    return roomImages;
  }

  public void setRoomImages(List<String> roomImages) {
    this.roomImages = roomImages;
  }

  public HotelRoomSchema roomQuantityMax(Integer roomQuantityMax) {
    this.roomQuantityMax = roomQuantityMax;
    return this;
  }

   /**
   * Maximum quantity of this room type available.
   * @return roomQuantityMax
  **/
  @Schema(description = "Maximum quantity of this room type available.")
  public Integer getRoomQuantityMax() {
    return roomQuantityMax;
  }

  public void setRoomQuantityMax(Integer roomQuantityMax) {
    this.roomQuantityMax = roomQuantityMax;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    HotelRoomSchema hotelRoomSchema = (HotelRoomSchema) o;
    return Objects.equals(this.roomId, hotelRoomSchema.roomId) &&
        Objects.equals(this.supplierRoomId, hotelRoomSchema.supplierRoomId) &&
        Objects.equals(this.roomIndex, hotelRoomSchema.roomIndex) &&
        Objects.equals(this.checkinDate, hotelRoomSchema.checkinDate) &&
        Objects.equals(this.checkoutDate, hotelRoomSchema.checkoutDate) &&
        Objects.equals(this.adults, hotelRoomSchema.adults) &&
        Objects.equals(this.children, hotelRoomSchema.children) &&
        Objects.equals(this.roomTax, hotelRoomSchema.roomTax) &&
        Objects.equals(this.roomPrice, hotelRoomSchema.roomPrice) &&
        Objects.equals(this.roomCurrency, hotelRoomSchema.roomCurrency) &&
        Objects.equals(this.roomCancellationPolicies, hotelRoomSchema.roomCancellationPolicies) &&
        Objects.equals(this.roomName, hotelRoomSchema.roomName) &&
        Objects.equals(this.roomDescription, hotelRoomSchema.roomDescription) &&
        Objects.equals(this.roomImages, hotelRoomSchema.roomImages) &&
        Objects.equals(this.roomQuantityMax, hotelRoomSchema.roomQuantityMax);
  }

  @Override
  public int hashCode() {
    return Objects.hash(roomId, supplierRoomId, roomIndex, checkinDate, checkoutDate, adults, children, roomTax, roomPrice, roomCurrency, roomCancellationPolicies, roomName, roomDescription, roomImages, roomQuantityMax);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class HotelRoomSchema {\n");
    
    sb.append("    roomId: ").append(toIndentedString(roomId)).append("\n");
    sb.append("    supplierRoomId: ").append(toIndentedString(supplierRoomId)).append("\n");
    sb.append("    roomIndex: ").append(toIndentedString(roomIndex)).append("\n");
    sb.append("    checkinDate: ").append(toIndentedString(checkinDate)).append("\n");
    sb.append("    checkoutDate: ").append(toIndentedString(checkoutDate)).append("\n");
    sb.append("    adults: ").append(toIndentedString(adults)).append("\n");
    sb.append("    children: ").append(toIndentedString(children)).append("\n");
    sb.append("    roomTax: ").append(toIndentedString(roomTax)).append("\n");
    sb.append("    roomPrice: ").append(toIndentedString(roomPrice)).append("\n");
    sb.append("    roomCurrency: ").append(toIndentedString(roomCurrency)).append("\n");
    sb.append("    roomCancellationPolicies: ").append(toIndentedString(roomCancellationPolicies)).append("\n");
    sb.append("    roomName: ").append(toIndentedString(roomName)).append("\n");
    sb.append("    roomDescription: ").append(toIndentedString(roomDescription)).append("\n");
    sb.append("    roomImages: ").append(toIndentedString(roomImages)).append("\n");
    sb.append("    roomQuantityMax: ").append(toIndentedString(roomQuantityMax)).append("\n");
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
