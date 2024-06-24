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
  public class ToursAndActivitiesOfferDetailsSchema {
    /// <summary>
    /// Identifier of the individual offer.
    /// </summary>
    /// <value>Identifier of the individual offer.</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Identifier provided by the supplier for the offer.
    /// </summary>
    /// <value>Identifier provided by the supplier for the offer.</value>
    [DataMember(Name="supplier_offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_offer_id")]
    public Guid? SupplierOfferId { get; set; }

    /// <summary>
    /// Index of the offer for ordering.
    /// </summary>
    /// <value>Index of the offer for ordering.</value>
    [DataMember(Name="offer_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_index")]
    public int? OfferIndex { get; set; }

    /// <summary>
    /// Tax applied on the offer.
    /// </summary>
    /// <value>Tax applied on the offer.</value>
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
    /// Date of the tour.
    /// </summary>
    /// <value>Date of the tour.</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Number of adults attending.
    /// </summary>
    /// <value>Number of adults attending.</value>
    [DataMember(Name="adults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adults")]
    public int? Adults { get; set; }

    /// <summary>
    /// Number of children attending.
    /// </summary>
    /// <value>Number of children attending.</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public int? Children { get; set; }

    /// <summary>
    /// Name of the tour.
    /// </summary>
    /// <value>Name of the tour.</value>
    [DataMember(Name="tour_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_name")]
    public string TourName { get; set; }

    /// <summary>
    /// Description of the tour.
    /// </summary>
    /// <value>Description of the tour.</value>
    [DataMember(Name="tour_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_description")]
    public string TourDescription { get; set; }

    /// <summary>
    /// Address where the tour will take place.
    /// </summary>
    /// <value>Address where the tour will take place.</value>
    [DataMember(Name="tour_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_address")]
    public string TourAddress { get; set; }

    /// <summary>
    /// Latitude for the tour location.
    /// </summary>
    /// <value>Latitude for the tour location.</value>
    [DataMember(Name="tour_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_latitude")]
    public float? TourLatitude { get; set; }

    /// <summary>
    /// Longitude for the tour location.
    /// </summary>
    /// <value>Longitude for the tour location.</value>
    [DataMember(Name="tour_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_longitude")]
    public float? TourLongitude { get; set; }

    /// <summary>
    /// Distance covered by the tour.
    /// </summary>
    /// <value>Distance covered by the tour.</value>
    [DataMember(Name="tour_distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_distance")]
    public float? TourDistance { get; set; }

    /// <summary>
    /// Metric for measuring distance (miles or kilometers).
    /// </summary>
    /// <value>Metric for measuring distance (miles or kilometers).</value>
    [DataMember(Name="tour_distance_metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_distance_metric")]
    public string TourDistanceMetric { get; set; }

    /// <summary>
    /// Array of images related to the tour.
    /// </summary>
    /// <value>Array of images related to the tour.</value>
    [DataMember(Name="tour_images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_images")]
    public List<string> TourImages { get; set; }

    /// <summary>
    /// Rating of the tour.
    /// </summary>
    /// <value>Rating of the tour.</value>
    [DataMember(Name="tour_rating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_rating")]
    public float? TourRating { get; set; }

    /// <summary>
    /// Array of reviews for the tour.
    /// </summary>
    /// <value>Array of reviews for the tour.</value>
    [DataMember(Name="tour_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_reviews")]
    public List<string> TourReviews { get; set; }

    /// <summary>
    /// Subcategories of the tour.
    /// </summary>
    /// <value>Subcategories of the tour.</value>
    [DataMember(Name="tour_subcategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tour_subcategories")]
    public List<string> TourSubcategories { get; set; }

    /// <summary>
    /// Questions related to booking the tour.
    /// </summary>
    /// <value>Questions related to booking the tour.</value>
    [DataMember(Name="booking_questions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_questions")]
    public List<string> BookingQuestions { get; set; }

    /// <summary>
    /// Array of ToursAndActivitiesVariantSchema.
    /// </summary>
    /// <value>Array of ToursAndActivitiesVariantSchema.</value>
    [DataMember(Name="variants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variants")]
    public List<ToursAndActivitiesVariantSchema> Variants { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ToursAndActivitiesOfferDetailsSchema {\n");
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
      sb.Append("  TourName: ").Append(TourName).Append("\n");
      sb.Append("  TourDescription: ").Append(TourDescription).Append("\n");
      sb.Append("  TourAddress: ").Append(TourAddress).Append("\n");
      sb.Append("  TourLatitude: ").Append(TourLatitude).Append("\n");
      sb.Append("  TourLongitude: ").Append(TourLongitude).Append("\n");
      sb.Append("  TourDistance: ").Append(TourDistance).Append("\n");
      sb.Append("  TourDistanceMetric: ").Append(TourDistanceMetric).Append("\n");
      sb.Append("  TourImages: ").Append(TourImages).Append("\n");
      sb.Append("  TourRating: ").Append(TourRating).Append("\n");
      sb.Append("  TourReviews: ").Append(TourReviews).Append("\n");
      sb.Append("  TourSubcategories: ").Append(TourSubcategories).Append("\n");
      sb.Append("  BookingQuestions: ").Append(BookingQuestions).Append("\n");
      sb.Append("  Variants: ").Append(Variants).Append("\n");
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
