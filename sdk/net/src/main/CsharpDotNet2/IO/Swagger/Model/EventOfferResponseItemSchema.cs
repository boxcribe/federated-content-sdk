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
  public class EventOfferResponseItemSchema {
    /// <summary>
    /// Unique identifier for the offer.
    /// </summary>
    /// <value>Unique identifier for the offer.</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Unique identifier for the supplier’s offer.
    /// </summary>
    /// <value>Unique identifier for the supplier’s offer.</value>
    [DataMember(Name="supplier_offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_offer_id")]
    public Guid? SupplierOfferId { get; set; }

    /// <summary>
    /// Index of the offer for sorting purposes.
    /// </summary>
    /// <value>Index of the offer for sorting purposes.</value>
    [DataMember(Name="offer_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_index")]
    public decimal? OfferIndex { get; set; }

    /// <summary>
    /// Tax applied to the offer.
    /// </summary>
    /// <value>Tax applied to the offer.</value>
    [DataMember(Name="offer_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_tax")]
    public decimal? OfferTax { get; set; }

    /// <summary>
    /// Price of the offer.
    /// </summary>
    /// <value>Price of the offer.</value>
    [DataMember(Name="offer_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_price")]
    public decimal? OfferPrice { get; set; }

    /// <summary>
    /// Currency of the offer price.
    /// </summary>
    /// <value>Currency of the offer price.</value>
    [DataMember(Name="offer_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_currency")]
    public string OfferCurrency { get; set; }

    /// <summary>
    /// Cancellation policies applicable to the offer.
    /// </summary>
    /// <value>Cancellation policies applicable to the offer.</value>
    [DataMember(Name="offer_cancelation_policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_cancelation_policies")]
    public string OfferCancelationPolicies { get; set; }

    /// <summary>
    /// Date of the event.
    /// </summary>
    /// <value>Date of the event.</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Number of adults involved in the event.
    /// </summary>
    /// <value>Number of adults involved in the event.</value>
    [DataMember(Name="adults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adults")]
    public decimal? Adults { get; set; }

    /// <summary>
    /// Number of children involved in the event.
    /// </summary>
    /// <value>Number of children involved in the event.</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public decimal? Children { get; set; }

    /// <summary>
    /// Name of the event.
    /// </summary>
    /// <value>Name of the event.</value>
    [DataMember(Name="event_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_name")]
    public string EventName { get; set; }

    /// <summary>
    /// Description of the event.
    /// </summary>
    /// <value>Description of the event.</value>
    [DataMember(Name="event_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_description")]
    public string EventDescription { get; set; }

    /// <summary>
    /// Address where the event will take place.
    /// </summary>
    /// <value>Address where the event will take place.</value>
    [DataMember(Name="event_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_address")]
    public string EventAddress { get; set; }

    /// <summary>
    /// Latitude of the event location.
    /// </summary>
    /// <value>Latitude of the event location.</value>
    [DataMember(Name="event_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_latitude")]
    public float? EventLatitude { get; set; }

    /// <summary>
    /// Longitude of the event location.
    /// </summary>
    /// <value>Longitude of the event location.</value>
    [DataMember(Name="event_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_longitude")]
    public float? EventLongitude { get; set; }

    /// <summary>
    /// Distance to the event from a reference point.
    /// </summary>
    /// <value>Distance to the event from a reference point.</value>
    [DataMember(Name="event_distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_distance")]
    public decimal? EventDistance { get; set; }

    /// <summary>
    /// Metric used to measure the distance to the event.
    /// </summary>
    /// <value>Metric used to measure the distance to the event.</value>
    [DataMember(Name="event_distance_metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_distance_metric")]
    public string EventDistanceMetric { get; set; }

    /// <summary>
    /// Images of the event.
    /// </summary>
    /// <value>Images of the event.</value>
    [DataMember(Name="event_images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_images")]
    public List<string> EventImages { get; set; }

    /// <summary>
    /// Rating of the event.
    /// </summary>
    /// <value>Rating of the event.</value>
    [DataMember(Name="event_rating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_rating")]
    public decimal? EventRating { get; set; }

    /// <summary>
    /// Reviews of the event.
    /// </summary>
    /// <value>Reviews of the event.</value>
    [DataMember(Name="event_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_reviews")]
    public List<string> EventReviews { get; set; }

    /// <summary>
    /// Venue where the event will take place.
    /// </summary>
    /// <value>Venue where the event will take place.</value>
    [DataMember(Name="event_venue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_venue")]
    public string EventVenue { get; set; }

    /// <summary>
    /// Capacity of the venue.
    /// </summary>
    /// <value>Capacity of the venue.</value>
    [DataMember(Name="event_venue_capacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_venue_capacity")]
    public decimal? EventVenueCapacity { get; set; }

    /// <summary>
    /// Performers at the event.
    /// </summary>
    /// <value>Performers at the event.</value>
    [DataMember(Name="event_performers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_performers")]
    public List<string> EventPerformers { get; set; }

    /// <summary>
    /// Subcategories of the event.
    /// </summary>
    /// <value>Subcategories of the event.</value>
    [DataMember(Name="event_subcategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "event_subcategories")]
    public List<string> EventSubcategories { get; set; }

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
      sb.Append("class EventOfferResponseItemSchema {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  SupplierOfferId: ").Append(SupplierOfferId).Append("\n");
      sb.Append("  OfferIndex: ").Append(OfferIndex).Append("\n");
      sb.Append("  OfferTax: ").Append(OfferTax).Append("\n");
      sb.Append("  OfferPrice: ").Append(OfferPrice).Append("\n");
      sb.Append("  OfferCurrency: ").Append(OfferCurrency).Append("\n");
      sb.Append("  OfferCancelationPolicies: ").Append(OfferCancelationPolicies).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  Adults: ").Append(Adults).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  EventName: ").Append(EventName).Append("\n");
      sb.Append("  EventDescription: ").Append(EventDescription).Append("\n");
      sb.Append("  EventAddress: ").Append(EventAddress).Append("\n");
      sb.Append("  EventLatitude: ").Append(EventLatitude).Append("\n");
      sb.Append("  EventLongitude: ").Append(EventLongitude).Append("\n");
      sb.Append("  EventDistance: ").Append(EventDistance).Append("\n");
      sb.Append("  EventDistanceMetric: ").Append(EventDistanceMetric).Append("\n");
      sb.Append("  EventImages: ").Append(EventImages).Append("\n");
      sb.Append("  EventRating: ").Append(EventRating).Append("\n");
      sb.Append("  EventReviews: ").Append(EventReviews).Append("\n");
      sb.Append("  EventVenue: ").Append(EventVenue).Append("\n");
      sb.Append("  EventVenueCapacity: ").Append(EventVenueCapacity).Append("\n");
      sb.Append("  EventPerformers: ").Append(EventPerformers).Append("\n");
      sb.Append("  EventSubcategories: ").Append(EventSubcategories).Append("\n");
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
