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
import io.swagger.client.model.EventTicketSchema;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * EventGetOfferAvailabilityResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class EventGetOfferAvailabilityResponse {
  @SerializedName("tickets")
  private List<EventTicketSchema> tickets = null;

  public EventGetOfferAvailabilityResponse tickets(List<EventTicketSchema> tickets) {
    this.tickets = tickets;
    return this;
  }

  public EventGetOfferAvailabilityResponse addTicketsItem(EventTicketSchema ticketsItem) {
    if (this.tickets == null) {
      this.tickets = new ArrayList<EventTicketSchema>();
    }
    this.tickets.add(ticketsItem);
    return this;
  }

   /**
   * Array of EventTicketSchema.
   * @return tickets
  **/
  @Schema(description = "Array of EventTicketSchema.")
  public List<EventTicketSchema> getTickets() {
    return tickets;
  }

  public void setTickets(List<EventTicketSchema> tickets) {
    this.tickets = tickets;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    EventGetOfferAvailabilityResponse eventGetOfferAvailabilityResponse = (EventGetOfferAvailabilityResponse) o;
    return Objects.equals(this.tickets, eventGetOfferAvailabilityResponse.tickets);
  }

  @Override
  public int hashCode() {
    return Objects.hash(tickets);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class EventGetOfferAvailabilityResponse {\n");
    
    sb.append("    tickets: ").append(toIndentedString(tickets)).append("\n");
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
