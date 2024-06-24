using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Offer Request Normalized Boxcribe API Response
  /// </summary>
  [DataContract]
  public class OfferResultNormalizedResponse {
    /// <summary>
    /// Gets or Sets Ids
    /// </summary>
    [DataMember(Name="ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ids")]
    public string Ids { get; set; }

    /// <summary>
    /// Gets or Sets Category
    /// </summary>
    [DataMember(Name="category", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category")]
    public string Category { get; set; }

    /// <summary>
    /// Gets or Sets Index
    /// </summary>
    [DataMember(Name="index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "index")]
    public int? Index { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public string Address { get; set; }

    /// <summary>
    /// Gets or Sets Latitude
    /// </summary>
    [DataMember(Name="latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "latitude")]
    public decimal? Latitude { get; set; }

    /// <summary>
    /// Gets or Sets Longitude
    /// </summary>
    [DataMember(Name="longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "longitude")]
    public decimal? Longitude { get; set; }

    /// <summary>
    /// Gets or Sets Distance
    /// </summary>
    [DataMember(Name="distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distance")]
    public decimal? Distance { get; set; }

    /// <summary>
    /// Gets or Sets DistanceUnitOfMeasure
    /// </summary>
    [DataMember(Name="distanceUnitOfMeasure", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "distanceUnitOfMeasure")]
    public string DistanceUnitOfMeasure { get; set; }

    /// <summary>
    /// Gets or Sets Pictures
    /// </summary>
    [DataMember(Name="pictures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pictures")]
    public List<string> Pictures { get; set; }

    /// <summary>
    /// Gets or Sets Tax
    /// </summary>
    [DataMember(Name="tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tax")]
    public decimal? Tax { get; set; }

    /// <summary>
    /// Gets or Sets Price
    /// </summary>
    [DataMember(Name="price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "price")]
    public decimal? Price { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets PriceDescription
    /// </summary>
    [DataMember(Name="priceDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "priceDescription")]
    public string PriceDescription { get; set; }

    /// <summary>
    /// Gets or Sets FreeCancellation
    /// </summary>
    [DataMember(Name="freeCancellation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "freeCancellation")]
    public bool? FreeCancellation { get; set; }

    /// <summary>
    /// Gets or Sets Rating
    /// </summary>
    [DataMember(Name="rating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rating")]
    public decimal? Rating { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets OhterAttributes
    /// </summary>
    [DataMember(Name="ohter_attributes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ohter_attributes")]
    public Object OhterAttributes { get; set; }

    /// <summary>
    /// Gets or Sets OfferRooms
    /// </summary>
    [DataMember(Name="offer_rooms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_rooms")]
    public List OfferRooms { get; set; }

    /// <summary>
    /// Gets or Sets OfferVariants
    /// </summary>
    [DataMember(Name="offer_variants", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_variants")]
    public List OfferVariants { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferResultNormalizedResponse {\n");
      sb.Append("  Ids: ").Append(Ids).Append("\n");
      sb.Append("  Category: ").Append(Category).Append("\n");
      sb.Append("  Index: ").Append(Index).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Latitude: ").Append(Latitude).Append("\n");
      sb.Append("  Longitude: ").Append(Longitude).Append("\n");
      sb.Append("  Distance: ").Append(Distance).Append("\n");
      sb.Append("  DistanceUnitOfMeasure: ").Append(DistanceUnitOfMeasure).Append("\n");
      sb.Append("  Pictures: ").Append(Pictures).Append("\n");
      sb.Append("  Tax: ").Append(Tax).Append("\n");
      sb.Append("  Price: ").Append(Price).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  PriceDescription: ").Append(PriceDescription).Append("\n");
      sb.Append("  FreeCancellation: ").Append(FreeCancellation).Append("\n");
      sb.Append("  Rating: ").Append(Rating).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  OhterAttributes: ").Append(OhterAttributes).Append("\n");
      sb.Append("  OfferRooms: ").Append(OfferRooms).Append("\n");
      sb.Append("  OfferVariants: ").Append(OfferVariants).Append("\n");
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
