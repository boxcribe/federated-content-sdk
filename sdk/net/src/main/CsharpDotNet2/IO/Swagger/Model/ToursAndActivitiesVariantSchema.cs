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
  public class ToursAndActivitiesVariantSchema {
    /// <summary>
    /// Unique identifier for the tour variant.
    /// </summary>
    /// <value>Unique identifier for the tour variant.</value>
    [DataMember(Name="variant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_id")]
    public Guid? VariantId { get; set; }

    /// <summary>
    /// Identifier given by the supplier for the variant.
    /// </summary>
    /// <value>Identifier given by the supplier for the variant.</value>
    [DataMember(Name="supplier_variant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_variant_id")]
    public Guid? SupplierVariantId { get; set; }

    /// <summary>
    /// Index of the variant for ordering.
    /// </summary>
    /// <value>Index of the variant for ordering.</value>
    [DataMember(Name="variant_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_index")]
    public int? VariantIndex { get; set; }

    /// <summary>
    /// Tax applied to the variant price.
    /// </summary>
    /// <value>Tax applied to the variant price.</value>
    [DataMember(Name="variant_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_tax")]
    public decimal? VariantTax { get; set; }

    /// <summary>
    /// Price of the tour variant.
    /// </summary>
    /// <value>Price of the tour variant.</value>
    [DataMember(Name="variant_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_price")]
    public decimal? VariantPrice { get; set; }

    /// <summary>
    /// Currency of the variant price.
    /// </summary>
    /// <value>Currency of the variant price.</value>
    [DataMember(Name="variant_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_currency")]
    public string VariantCurrency { get; set; }

    /// <summary>
    /// Cancellation policies applicable to the tour variant.
    /// </summary>
    /// <value>Cancellation policies applicable to the tour variant.</value>
    [DataMember(Name="variant_cancellation_policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_cancellation_policies")]
    public string VariantCancellationPolicies { get; set; }

    /// <summary>
    /// Date of the tour.
    /// </summary>
    /// <value>Date of the tour.</value>
    [DataMember(Name="date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date")]
    public DateTime? Date { get; set; }

    /// <summary>
    /// Start time of the tour.
    /// </summary>
    /// <value>Start time of the tour.</value>
    [DataMember(Name="startTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startTime")]
    public string StartTime { get; set; }

    /// <summary>
    /// Number of adults for the tour.
    /// </summary>
    /// <value>Number of adults for the tour.</value>
    [DataMember(Name="adults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adults")]
    public int? Adults { get; set; }

    /// <summary>
    /// Number of children for the tour.
    /// </summary>
    /// <value>Number of children for the tour.</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public int? Children { get; set; }

    /// <summary>
    /// Name of the tour variant.
    /// </summary>
    /// <value>Name of the tour variant.</value>
    [DataMember(Name="variant_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_name")]
    public string VariantName { get; set; }

    /// <summary>
    /// Description of the tour variant.
    /// </summary>
    /// <value>Description of the tour variant.</value>
    [DataMember(Name="variant_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_description")]
    public string VariantDescription { get; set; }

    /// <summary>
    /// Address where the tour variant takes place.
    /// </summary>
    /// <value>Address where the tour variant takes place.</value>
    [DataMember(Name="variant_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_address")]
    public string VariantAddress { get; set; }

    /// <summary>
    /// Latitude coordinate of the tour location.
    /// </summary>
    /// <value>Latitude coordinate of the tour location.</value>
    [DataMember(Name="variant_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_latitude")]
    public float? VariantLatitude { get; set; }

    /// <summary>
    /// Longitude coordinate of the tour location.
    /// </summary>
    /// <value>Longitude coordinate of the tour location.</value>
    [DataMember(Name="variant_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_longitude")]
    public float? VariantLongitude { get; set; }

    /// <summary>
    /// Distance covered during the tour.
    /// </summary>
    /// <value>Distance covered during the tour.</value>
    [DataMember(Name="variant_distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_distance")]
    public decimal? VariantDistance { get; set; }

    /// <summary>
    /// Metric used for distance measurement (miles or kilometers).
    /// </summary>
    /// <value>Metric used for distance measurement (miles or kilometers).</value>
    [DataMember(Name="variant_distance_metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_distance_metric")]
    public string VariantDistanceMetric { get; set; }

    /// <summary>
    /// Array of images related to the tour variant.
    /// </summary>
    /// <value>Array of images related to the tour variant.</value>
    [DataMember(Name="variant_images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_images")]
    public List<string> VariantImages { get; set; }

    /// <summary>
    /// Rating of the tour variant.
    /// </summary>
    /// <value>Rating of the tour variant.</value>
    [DataMember(Name="variant_rating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_rating")]
    public decimal? VariantRating { get; set; }

    /// <summary>
    /// Collection of reviews for the tour variant.
    /// </summary>
    /// <value>Collection of reviews for the tour variant.</value>
    [DataMember(Name="variant_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_reviews")]
    public List<string> VariantReviews { get; set; }

    /// <summary>
    /// Subcategories of the tour variant.
    /// </summary>
    /// <value>Subcategories of the tour variant.</value>
    [DataMember(Name="variant_subcategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "variant_subcategories")]
    public List<string> VariantSubcategories { get; set; }

    /// <summary>
    /// Questions related to booking the tour variant.
    /// </summary>
    /// <value>Questions related to booking the tour variant.</value>
    [DataMember(Name="booking_questions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "booking_questions")]
    public List<string> BookingQuestions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ToursAndActivitiesVariantSchema {\n");
      sb.Append("  VariantId: ").Append(VariantId).Append("\n");
      sb.Append("  SupplierVariantId: ").Append(SupplierVariantId).Append("\n");
      sb.Append("  VariantIndex: ").Append(VariantIndex).Append("\n");
      sb.Append("  VariantTax: ").Append(VariantTax).Append("\n");
      sb.Append("  VariantPrice: ").Append(VariantPrice).Append("\n");
      sb.Append("  VariantCurrency: ").Append(VariantCurrency).Append("\n");
      sb.Append("  VariantCancellationPolicies: ").Append(VariantCancellationPolicies).Append("\n");
      sb.Append("  Date: ").Append(Date).Append("\n");
      sb.Append("  StartTime: ").Append(StartTime).Append("\n");
      sb.Append("  Adults: ").Append(Adults).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  VariantName: ").Append(VariantName).Append("\n");
      sb.Append("  VariantDescription: ").Append(VariantDescription).Append("\n");
      sb.Append("  VariantAddress: ").Append(VariantAddress).Append("\n");
      sb.Append("  VariantLatitude: ").Append(VariantLatitude).Append("\n");
      sb.Append("  VariantLongitude: ").Append(VariantLongitude).Append("\n");
      sb.Append("  VariantDistance: ").Append(VariantDistance).Append("\n");
      sb.Append("  VariantDistanceMetric: ").Append(VariantDistanceMetric).Append("\n");
      sb.Append("  VariantImages: ").Append(VariantImages).Append("\n");
      sb.Append("  VariantRating: ").Append(VariantRating).Append("\n");
      sb.Append("  VariantReviews: ").Append(VariantReviews).Append("\n");
      sb.Append("  VariantSubcategories: ").Append(VariantSubcategories).Append("\n");
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
