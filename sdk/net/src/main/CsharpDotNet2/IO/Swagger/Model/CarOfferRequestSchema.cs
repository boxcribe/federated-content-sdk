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
  public class CarOfferRequestSchema {
    /// <summary>
    /// Latitude for car pickup location.
    /// </summary>
    /// <value>Latitude for car pickup location.</value>
    [DataMember(Name="pickup_location_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_location_latitude")]
    public float? PickupLocationLatitude { get; set; }

    /// <summary>
    /// Longitude for car pickup location.
    /// </summary>
    /// <value>Longitude for car pickup location.</value>
    [DataMember(Name="pickup_location_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_location_longitude")]
    public float? PickupLocationLongitude { get; set; }

    /// <summary>
    /// Scheduled date for car pickup.
    /// </summary>
    /// <value>Scheduled date for car pickup.</value>
    [DataMember(Name="pickup_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_date")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Scheduled time for car pickup.
    /// </summary>
    /// <value>Scheduled time for car pickup.</value>
    [DataMember(Name="pickup_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_time")]
    public string PickupTime { get; set; }

    /// <summary>
    /// Latitude for car dropoff location.
    /// </summary>
    /// <value>Latitude for car dropoff location.</value>
    [DataMember(Name="dropoff_location_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dropoff_location_latitude")]
    public float? DropoffLocationLatitude { get; set; }

    /// <summary>
    /// Longitude for car dropoff location.
    /// </summary>
    /// <value>Longitude for car dropoff location.</value>
    [DataMember(Name="dropoff_location_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dropoff_location_longitude")]
    public float? DropoffLocationLongitude { get; set; }

    /// <summary>
    /// Scheduled date for car dropoff.
    /// </summary>
    /// <value>Scheduled date for car dropoff.</value>
    [DataMember(Name="dropoff_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dropoff_date")]
    public DateTime? DropoffDate { get; set; }

    /// <summary>
    /// Scheduled time for car dropoff.
    /// </summary>
    /// <value>Scheduled time for car dropoff.</value>
    [DataMember(Name="dropoff_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dropoff_time")]
    public string DropoffTime { get; set; }

    /// <summary>
    /// Keyword to filter car offers.
    /// </summary>
    /// <value>Keyword to filter car offers.</value>
    [DataMember(Name="filter_by_keyword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_keyword")]
    public string FilterByKeyword { get; set; }

    /// <summary>
    /// Minimum price to filter car offers.
    /// </summary>
    /// <value>Minimum price to filter car offers.</value>
    [DataMember(Name="filter_by_price_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_price_min")]
    public decimal? FilterByPriceMin { get; set; }

    /// <summary>
    /// Maximum price to filter car offers.
    /// </summary>
    /// <value>Maximum price to filter car offers.</value>
    [DataMember(Name="filter_by_price_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_price_max")]
    public decimal? FilterByPriceMax { get; set; }

    /// <summary>
    /// Minimum distance filter for car offers.
    /// </summary>
    /// <value>Minimum distance filter for car offers.</value>
    [DataMember(Name="filter_by_distance_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_distance_min")]
    public int? FilterByDistanceMin { get; set; }

    /// <summary>
    /// Maximum distance filter for car offers.
    /// </summary>
    /// <value>Maximum distance filter for car offers.</value>
    [DataMember(Name="filter_by_distance_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_distance_max")]
    public int? FilterByDistanceMax { get; set; }

    /// <summary>
    /// Minimum rating filter for car offers.
    /// </summary>
    /// <value>Minimum rating filter for car offers.</value>
    [DataMember(Name="filter_by_rating_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_rating_min")]
    public int? FilterByRatingMin { get; set; }

    /// <summary>
    /// Maximum rating filter for car offers.
    /// </summary>
    /// <value>Maximum rating filter for car offers.</value>
    [DataMember(Name="filter_by_rating_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_rating_max")]
    public int? FilterByRatingMax { get; set; }

    /// <summary>
    /// Minimum passengers capacity filter for car offers.
    /// </summary>
    /// <value>Minimum passengers capacity filter for car offers.</value>
    [DataMember(Name="filter_by_passengers_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_passengers_min")]
    public int? FilterByPassengersMin { get; set; }

    /// <summary>
    /// Maximum passengers capacity filter for car offers.
    /// </summary>
    /// <value>Maximum passengers capacity filter for car offers.</value>
    [DataMember(Name="filter_by_passengers_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_passengers_max")]
    public int? FilterByPassengersMax { get; set; }

    /// <summary>
    /// Types of cars to filter by.
    /// </summary>
    /// <value>Types of cars to filter by.</value>
    [DataMember(Name="filter_by_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_type")]
    public List<string> FilterByType { get; set; }

    /// <summary>
    /// Car rental companies to filter by.
    /// </summary>
    /// <value>Car rental companies to filter by.</value>
    [DataMember(Name="filter_by_company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_company")]
    public List<string> FilterByCompany { get; set; }

    /// <summary>
    /// Field to sort car offers by.
    /// </summary>
    /// <value>Field to sort car offers by.</value>
    [DataMember(Name="sort_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_by")]
    public string SortBy { get; set; }

    /// <summary>
    /// Order to sort car offers (asc, desc).
    /// </summary>
    /// <value>Order to sort car offers (asc, desc).</value>
    [DataMember(Name="sort_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_order")]
    public string SortOrder { get; set; }

    /// <summary>
    /// Page number for pagination.
    /// </summary>
    /// <value>Page number for pagination.</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public int? Page { get; set; }

    /// <summary>
    /// Number of offers per page.
    /// </summary>
    /// <value>Number of offers per page.</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Language for the offers.
    /// </summary>
    /// <value>Language for the offers.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Currency for the offers.
    /// </summary>
    /// <value>Currency for the offers.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Distance metric (mi/km) used in filters.
    /// </summary>
    /// <value>Distance metric (mi/km) used in filters.</value>
    [DataMember(Name="metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metric")]
    public string Metric { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CarOfferRequestSchema {\n");
      sb.Append("  PickupLocationLatitude: ").Append(PickupLocationLatitude).Append("\n");
      sb.Append("  PickupLocationLongitude: ").Append(PickupLocationLongitude).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  PickupTime: ").Append(PickupTime).Append("\n");
      sb.Append("  DropoffLocationLatitude: ").Append(DropoffLocationLatitude).Append("\n");
      sb.Append("  DropoffLocationLongitude: ").Append(DropoffLocationLongitude).Append("\n");
      sb.Append("  DropoffDate: ").Append(DropoffDate).Append("\n");
      sb.Append("  DropoffTime: ").Append(DropoffTime).Append("\n");
      sb.Append("  FilterByKeyword: ").Append(FilterByKeyword).Append("\n");
      sb.Append("  FilterByPriceMin: ").Append(FilterByPriceMin).Append("\n");
      sb.Append("  FilterByPriceMax: ").Append(FilterByPriceMax).Append("\n");
      sb.Append("  FilterByDistanceMin: ").Append(FilterByDistanceMin).Append("\n");
      sb.Append("  FilterByDistanceMax: ").Append(FilterByDistanceMax).Append("\n");
      sb.Append("  FilterByRatingMin: ").Append(FilterByRatingMin).Append("\n");
      sb.Append("  FilterByRatingMax: ").Append(FilterByRatingMax).Append("\n");
      sb.Append("  FilterByPassengersMin: ").Append(FilterByPassengersMin).Append("\n");
      sb.Append("  FilterByPassengersMax: ").Append(FilterByPassengersMax).Append("\n");
      sb.Append("  FilterByType: ").Append(FilterByType).Append("\n");
      sb.Append("  FilterByCompany: ").Append(FilterByCompany).Append("\n");
      sb.Append("  SortBy: ").Append(SortBy).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  Metric: ").Append(Metric).Append("\n");
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
