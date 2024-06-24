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
  public class TransportOfferDetailsSchema {
    /// <summary>
    /// Unique identifier of the offer.
    /// </summary>
    /// <value>Unique identifier of the offer.</value>
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
    /// Index number of the offer.
    /// </summary>
    /// <value>Index number of the offer.</value>
    [DataMember(Name="offer_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_index")]
    public int? OfferIndex { get; set; }

    /// <summary>
    /// Applicable taxes on the offer.
    /// </summary>
    /// <value>Applicable taxes on the offer.</value>
    [DataMember(Name="offer_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_tax")]
    public decimal? OfferTax { get; set; }

    /// <summary>
    /// Total price of the offer.
    /// </summary>
    /// <value>Total price of the offer.</value>
    [DataMember(Name="offer_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_price")]
    public decimal? OfferPrice { get; set; }

    /// <summary>
    /// Currency of the offer.
    /// </summary>
    /// <value>Currency of the offer.</value>
    [DataMember(Name="offer_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_currency")]
    public string OfferCurrency { get; set; }

    /// <summary>
    /// Cancellation policies of the offer.
    /// </summary>
    /// <value>Cancellation policies of the offer.</value>
    [DataMember(Name="offer_cancelation_policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_cancelation_policies")]
    public string OfferCancelationPolicies { get; set; }

    /// <summary>
    /// Date when the transport is scheduled to be picked up.
    /// </summary>
    /// <value>Date when the transport is scheduled to be picked up.</value>
    [DataMember(Name="pickup_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_date")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Time when the transport is scheduled to be picked up.
    /// </summary>
    /// <value>Time when the transport is scheduled to be picked up.</value>
    [DataMember(Name="pickup_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_time")]
    public string PickupTime { get; set; }

    /// <summary>
    /// Number of adults included in the transport offer.
    /// </summary>
    /// <value>Number of adults included in the transport offer.</value>
    [DataMember(Name="adults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adults")]
    public int? Adults { get; set; }

    /// <summary>
    /// Number of children included in the transport offer.
    /// </summary>
    /// <value>Number of children included in the transport offer.</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public int? Children { get; set; }

    /// <summary>
    /// Date when the transport is scheduled to be returned.
    /// </summary>
    /// <value>Date when the transport is scheduled to be returned.</value>
    [DataMember(Name="return_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_date")]
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// Time when the transport is scheduled to be returned.
    /// </summary>
    /// <value>Time when the transport is scheduled to be returned.</value>
    [DataMember(Name="return_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_time")]
    public string ReturnTime { get; set; }

    /// <summary>
    /// Name of the transport provider or vehicle.
    /// </summary>
    /// <value>Name of the transport provider or vehicle.</value>
    [DataMember(Name="transport_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_name")]
    public string TransportName { get; set; }

    /// <summary>
    /// Description of the transport.
    /// </summary>
    /// <value>Description of the transport.</value>
    [DataMember(Name="transport_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_description")]
    public string TransportDescription { get; set; }

    /// <summary>
    /// Address where the transport is located or where it operates.
    /// </summary>
    /// <value>Address where the transport is located or where it operates.</value>
    [DataMember(Name="transport_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_address")]
    public string TransportAddress { get; set; }

    /// <summary>
    /// Latitude coordinate of the transport location.
    /// </summary>
    /// <value>Latitude coordinate of the transport location.</value>
    [DataMember(Name="transport_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_latitude")]
    public float? TransportLatitude { get; set; }

    /// <summary>
    /// Longitude coordinate of the transport location.
    /// </summary>
    /// <value>Longitude coordinate of the transport location.</value>
    [DataMember(Name="transport_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_longitude")]
    public float? TransportLongitude { get; set; }

    /// <summary>
    /// Distance covered by the transport offer.
    /// </summary>
    /// <value>Distance covered by the transport offer.</value>
    [DataMember(Name="transport_distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_distance")]
    public decimal? TransportDistance { get; set; }

    /// <summary>
    /// Metric unit for transport distance (e.g., kilometers, miles).
    /// </summary>
    /// <value>Metric unit for transport distance (e.g., kilometers, miles).</value>
    [DataMember(Name="transport_distance_metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_distance_metric")]
    public string TransportDistanceMetric { get; set; }

    /// <summary>
    /// Collection of images of the transport.
    /// </summary>
    /// <value>Collection of images of the transport.</value>
    [DataMember(Name="transport_images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_images")]
    public List<string> TransportImages { get; set; }

    /// <summary>
    /// Rating of the transport.
    /// </summary>
    /// <value>Rating of the transport.</value>
    [DataMember(Name="transport_rating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_rating")]
    public decimal? TransportRating { get; set; }

    /// <summary>
    /// Reviews for the transport.
    /// </summary>
    /// <value>Reviews for the transport.</value>
    [DataMember(Name="transport_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_reviews")]
    public List<string> TransportReviews { get; set; }

    /// <summary>
    /// Type of transport (e.g., car, van, scooter).
    /// </summary>
    /// <value>Type of transport (e.g., car, van, scooter).</value>
    [DataMember(Name="transport_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_type")]
    public string TransportType { get; set; }

    /// <summary>
    /// Class of the transport (e.g., economy, luxury).
    /// </summary>
    /// <value>Class of the transport (e.g., economy, luxury).</value>
    [DataMember(Name="transport_class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_class")]
    public string TransportClass { get; set; }

    /// <summary>
    /// Company providing the transport.
    /// </summary>
    /// <value>Company providing the transport.</value>
    [DataMember(Name="transport_company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_company")]
    public string TransportCompany { get; set; }

    /// <summary>
    /// Logo of the company providing the transport.
    /// </summary>
    /// <value>Logo of the company providing the transport.</value>
    [DataMember(Name="transport_company_logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_company_logo")]
    public string TransportCompanyLogo { get; set; }

    /// <summary>
    /// Number of passengers the transport can accommodate.
    /// </summary>
    /// <value>Number of passengers the transport can accommodate.</value>
    [DataMember(Name="transport_passengers_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_passengers_number")]
    public int? TransportPassengersNumber { get; set; }

    /// <summary>
    /// Number of bags the transport can accommodate.
    /// </summary>
    /// <value>Number of bags the transport can accommodate.</value>
    [DataMember(Name="transport_bags_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_bags_number")]
    public int? TransportBagsNumber { get; set; }

    /// <summary>
    /// List of amenities provided with the transport.
    /// </summary>
    /// <value>List of amenities provided with the transport.</value>
    [DataMember(Name="transport_amenities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transport_amenities")]
    public List<string> TransportAmenities { get; set; }

    /// <summary>
    /// Questions related to booking the transport.
    /// </summary>
    /// <value>Questions related to booking the transport.</value>
    [DataMember(Name="booking_questions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_questions")]
    public List<string> BookingQuestions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransportOfferDetailsSchema {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  SupplierOfferId: ").Append(SupplierOfferId).Append("\n");
      sb.Append("  OfferIndex: ").Append(OfferIndex).Append("\n");
      sb.Append("  OfferTax: ").Append(OfferTax).Append("\n");
      sb.Append("  OfferPrice: ").Append(OfferPrice).Append("\n");
      sb.Append("  OfferCurrency: ").Append(OfferCurrency).Append("\n");
      sb.Append("  OfferCancelationPolicies: ").Append(OfferCancelationPolicies).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  PickupTime: ").Append(PickupTime).Append("\n");
      sb.Append("  Adults: ").Append(Adults).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  ReturnDate: ").Append(ReturnDate).Append("\n");
      sb.Append("  ReturnTime: ").Append(ReturnTime).Append("\n");
      sb.Append("  TransportName: ").Append(TransportName).Append("\n");
      sb.Append("  TransportDescription: ").Append(TransportDescription).Append("\n");
      sb.Append("  TransportAddress: ").Append(TransportAddress).Append("\n");
      sb.Append("  TransportLatitude: ").Append(TransportLatitude).Append("\n");
      sb.Append("  TransportLongitude: ").Append(TransportLongitude).Append("\n");
      sb.Append("  TransportDistance: ").Append(TransportDistance).Append("\n");
      sb.Append("  TransportDistanceMetric: ").Append(TransportDistanceMetric).Append("\n");
      sb.Append("  TransportImages: ").Append(TransportImages).Append("\n");
      sb.Append("  TransportRating: ").Append(TransportRating).Append("\n");
      sb.Append("  TransportReviews: ").Append(TransportReviews).Append("\n");
      sb.Append("  TransportType: ").Append(TransportType).Append("\n");
      sb.Append("  TransportClass: ").Append(TransportClass).Append("\n");
      sb.Append("  TransportCompany: ").Append(TransportCompany).Append("\n");
      sb.Append("  TransportCompanyLogo: ").Append(TransportCompanyLogo).Append("\n");
      sb.Append("  TransportPassengersNumber: ").Append(TransportPassengersNumber).Append("\n");
      sb.Append("  TransportBagsNumber: ").Append(TransportBagsNumber).Append("\n");
      sb.Append("  TransportAmenities: ").Append(TransportAmenities).Append("\n");
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
