using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class EventTicketSchema {
    /// <summary>
    /// Unique identifier for the ticket.
    /// </summary>
    /// <value>Unique identifier for the ticket.</value>
    [DataMember(Name="ticket_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_id")]
    public Guid? TicketId { get; set; }

    /// <summary>
    /// Identifier for the ticket provided by the supplier.
    /// </summary>
    /// <value>Identifier for the ticket provided by the supplier.</value>
    [DataMember(Name="supplier_ticket_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_ticket_id")]
    public Guid? SupplierTicketId { get; set; }

    /// <summary>
    /// Index number of the ticket for ordering.
    /// </summary>
    /// <value>Index number of the ticket for ordering.</value>
    [DataMember(Name="ticket_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_index")]
    public decimal? TicketIndex { get; set; }

    /// <summary>
    /// Applicable tax on the ticket price.
    /// </summary>
    /// <value>Applicable tax on the ticket price.</value>
    [DataMember(Name="ticket_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_tax")]
    public decimal? TicketTax { get; set; }

    /// <summary>
    /// Price of the ticket.
    /// </summary>
    /// <value>Price of the ticket.</value>
    [DataMember(Name="ticket_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_price")]
    public decimal? TicketPrice { get; set; }

    /// <summary>
    /// Currency in which the ticket is priced.
    /// </summary>
    /// <value>Currency in which the ticket is priced.</value>
    [DataMember(Name="ticket_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_currency")]
    public string TicketCurrency { get; set; }

    /// <summary>
    /// Policies regarding ticket cancellation.
    /// </summary>
    /// <value>Policies regarding ticket cancellation.</value>
    [DataMember(Name="ticket_cancellation_policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_cancellation_policies")]
    public string TicketCancellationPolicies { get; set; }

    /// <summary>
    /// Section of the venue where the seat is located.
    /// </summary>
    /// <value>Section of the venue where the seat is located.</value>
    [DataMember(Name="ticket_section", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_section")]
    public string TicketSection { get; set; }

    /// <summary>
    /// Row of the section where the seat is located.
    /// </summary>
    /// <value>Row of the section where the seat is located.</value>
    [DataMember(Name="ticket_row", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_row")]
    public string TicketRow { get; set; }

    /// <summary>
    /// Specific seat number.
    /// </summary>
    /// <value>Specific seat number.</value>
    [DataMember(Name="ticket_seat", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_seat")]
    public string TicketSeat { get; set; }

    /// <summary>
    /// Description of the ticket.
    /// </summary>
    /// <value>Description of the ticket.</value>
    [DataMember(Name="ticket_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_description")]
    public string TicketDescription { get; set; }

    /// <summary>
    /// Available options for ticket delivery.
    /// </summary>
    /// <value>Available options for ticket delivery.</value>
    [DataMember(Name="ticket_delivery_options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_delivery_options")]
    public List<string> TicketDeliveryOptions { get; set; }

    /// <summary>
    /// Quantities of tickets available for purchase.
    /// </summary>
    /// <value>Quantities of tickets available for purchase.</value>
    [DataMember(Name="ticket_quantities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ticket_quantities")]
    public List<int?> TicketQuantities { get; set; }

    /// <summary>
    /// Questions related to booking the event.
    /// </summary>
    /// <value>Questions related to booking the event.</value>
    [DataMember(Name="booking_questions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_questions")]
    public List<string> BookingQuestions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventTicketSchema {\n");
      sb.Append("  TicketId: ").Append(TicketId).Append("\n");
      sb.Append("  SupplierTicketId: ").Append(SupplierTicketId).Append("\n");
      sb.Append("  TicketIndex: ").Append(TicketIndex).Append("\n");
      sb.Append("  TicketTax: ").Append(TicketTax).Append("\n");
      sb.Append("  TicketPrice: ").Append(TicketPrice).Append("\n");
      sb.Append("  TicketCurrency: ").Append(TicketCurrency).Append("\n");
      sb.Append("  TicketCancellationPolicies: ").Append(TicketCancellationPolicies).Append("\n");
      sb.Append("  TicketSection: ").Append(TicketSection).Append("\n");
      sb.Append("  TicketRow: ").Append(TicketRow).Append("\n");
      sb.Append("  TicketSeat: ").Append(TicketSeat).Append("\n");
      sb.Append("  TicketDescription: ").Append(TicketDescription).Append("\n");
      sb.Append("  TicketDeliveryOptions: ").Append(TicketDeliveryOptions).Append("\n");
      sb.Append("  TicketQuantities: ").Append(TicketQuantities).Append("\n");
      sb.Append("  BookingQuestions: ").Append(BookingQuestions).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
