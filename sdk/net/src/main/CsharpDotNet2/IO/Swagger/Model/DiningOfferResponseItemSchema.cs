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
  public class DiningOfferResponseItemSchema {
    /// <summary>
    /// Unique identifier for the dining offer.
    /// </summary>
    /// <value>Unique identifier for the dining offer.</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Identifier for the offer provided by the supplier.
    /// </summary>
    /// <value>Identifier for the offer provided by the supplier.</value>
    [DataMember(Name="supplier_offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_offer_id")]
    public Guid? SupplierOfferId { get; set; }

    /// <summary>
    /// Index of the offer for sorting and reference.
    /// </summary>
    /// <value>Index of the offer for sorting and reference.</value>
    [DataMember(Name="offer_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_index")]
    public decimal? OfferIndex { get; set; }

    /// <summary>
    /// Tax applied to the dining offer.
    /// </summary>
    /// <value>Tax applied to the dining offer.</value>
    [DataMember(Name="offer_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_tax")]
    public decimal? OfferTax { get; set; }

    /// <summary>
    /// Price of the dining experience.
    /// </summary>
    /// <value>Price of the dining experience.</value>
    [DataMember(Name="offer_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_price")]
    public decimal? OfferPrice { get; set; }

    /// <summary>
    /// Currency in which the offer is priced.
    /// </summary>
    /// <value>Currency in which the offer is priced.</value>
    [DataMember(Name="offer_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_currency")]
    public string OfferCurrency { get; set; }

    /// <summary>
    /// Cancellation policies applicable to the dining offer.
    /// </summary>
    /// <value>Cancellation policies applicable to the dining offer.</value>
    [DataMember(Name="offer_cancellation_policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_cancellation_policies")]
    public string OfferCancellationPolicies { get; set; }

    /// <summary>
    /// Name of the dining establishment.
    /// </summary>
    /// <value>Name of the dining establishment.</value>
    [DataMember(Name="dining_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_name")]
    public string DiningName { get; set; }

    /// <summary>
    /// Description of the dining establishment and the dining experience.
    /// </summary>
    /// <value>Description of the dining establishment and the dining experience.</value>
    [DataMember(Name="dining_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_description")]
    public string DiningDescription { get; set; }

    /// <summary>
    /// Physical address of the dining establishment.
    /// </summary>
    /// <value>Physical address of the dining establishment.</value>
    [DataMember(Name="dining_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_address")]
    public string DiningAddress { get; set; }

    /// <summary>
    /// Latitude coordinate of the dining location.
    /// </summary>
    /// <value>Latitude coordinate of the dining location.</value>
    [DataMember(Name="dining_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_latitude")]
    public float? DiningLatitude { get; set; }

    /// <summary>
    /// Longitude coordinate of the dining location.
    /// </summary>
    /// <value>Longitude coordinate of the dining location.</value>
    [DataMember(Name="dining_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_longitude")]
    public float? DiningLongitude { get; set; }

    /// <summary>
    /// Distance to the dining location from a reference point, if applicable.
    /// </summary>
    /// <value>Distance to the dining location from a reference point, if applicable.</value>
    [DataMember(Name="dining_distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_distance")]
    public float? DiningDistance { get; set; }

    /// <summary>
    /// Metric used to measure the distance (e.g., miles, kilometers).
    /// </summary>
    /// <value>Metric used to measure the distance (e.g., miles, kilometers).</value>
    [DataMember(Name="dining_distance_metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_distance_metric")]
    public string DiningDistanceMetric { get; set; }

    /// <summary>
    /// Collection of images of the dining establishment and dishes.
    /// </summary>
    /// <value>Collection of images of the dining establishment and dishes.</value>
    [DataMember(Name="dining_images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_images")]
    public List<string> DiningImages { get; set; }

    /// <summary>
    /// Rating of the dining establishment based on customer reviews.
    /// </summary>
    /// <value>Rating of the dining establishment based on customer reviews.</value>
    [DataMember(Name="dining_rating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_rating")]
    public float? DiningRating { get; set; }

    /// <summary>
    /// Customer reviews for the dining establishment.
    /// </summary>
    /// <value>Customer reviews for the dining establishment.</value>
    [DataMember(Name="dining_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_reviews")]
    public List<string> DiningReviews { get; set; }

    /// <summary>
    /// List of subcategories the dining offer belongs to (e.g., Italian, Seafood, Fine Dining).
    /// </summary>
    /// <value>List of subcategories the dining offer belongs to (e.g., Italian, Seafood, Fine Dining).</value>
    [DataMember(Name="dining_subcategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_subcategories")]
    public List<string> DiningSubcategories { get; set; }

    /// <summary>
    /// Operating hours of the dining establishment.
    /// </summary>
    /// <value>Operating hours of the dining establishment.</value>
    [DataMember(Name="dining_hours", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dining_hours")]
    public List<string> DiningHours { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DiningOfferResponseItemSchema {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  SupplierOfferId: ").Append(SupplierOfferId).Append("\n");
      sb.Append("  OfferIndex: ").Append(OfferIndex).Append("\n");
      sb.Append("  OfferTax: ").Append(OfferTax).Append("\n");
      sb.Append("  OfferPrice: ").Append(OfferPrice).Append("\n");
      sb.Append("  OfferCurrency: ").Append(OfferCurrency).Append("\n");
      sb.Append("  OfferCancellationPolicies: ").Append(OfferCancellationPolicies).Append("\n");
      sb.Append("  DiningName: ").Append(DiningName).Append("\n");
      sb.Append("  DiningDescription: ").Append(DiningDescription).Append("\n");
      sb.Append("  DiningAddress: ").Append(DiningAddress).Append("\n");
      sb.Append("  DiningLatitude: ").Append(DiningLatitude).Append("\n");
      sb.Append("  DiningLongitude: ").Append(DiningLongitude).Append("\n");
      sb.Append("  DiningDistance: ").Append(DiningDistance).Append("\n");
      sb.Append("  DiningDistanceMetric: ").Append(DiningDistanceMetric).Append("\n");
      sb.Append("  DiningImages: ").Append(DiningImages).Append("\n");
      sb.Append("  DiningRating: ").Append(DiningRating).Append("\n");
      sb.Append("  DiningReviews: ").Append(DiningReviews).Append("\n");
      sb.Append("  DiningSubcategories: ").Append(DiningSubcategories).Append("\n");
      sb.Append("  DiningHours: ").Append(DiningHours).Append("\n");
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
