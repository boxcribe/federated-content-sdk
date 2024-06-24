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
  public class EventOfferRequestSchema {
    /// <summary>
    /// Latitude for the event location.
    /// </summary>
    /// <value>Latitude for the event location.</value>
    [DataMember(Name="location_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_latitude")]
    public float? LocationLatitude { get; set; }

    /// <summary>
    /// Longitude for the event location.
    /// </summary>
    /// <value>Longitude for the event location.</value>
    [DataMember(Name="location_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_longitude")]
    public float? LocationLongitude { get; set; }

    /// <summary>
    /// Radius to search for events around the location coordinates.
    /// </summary>
    /// <value>Radius to search for events around the location coordinates.</value>
    [DataMember(Name="location_radius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_radius")]
    public float? LocationRadius { get; set; }

    /// <summary>
    /// Start date for the event search.
    /// </summary>
    /// <value>Start date for the event search.</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// End date for the event search.
    /// </summary>
    /// <value>End date for the event search.</value>
    [DataMember(Name="end_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_date")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Keywords to filter the events.
    /// </summary>
    /// <value>Keywords to filter the events.</value>
    [DataMember(Name="filter_by_keyword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_keyword")]
    public string FilterByKeyword { get; set; }

    /// <summary>
    /// Minimum price to filter the events.
    /// </summary>
    /// <value>Minimum price to filter the events.</value>
    [DataMember(Name="filter_by_price_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_price_min")]
    public decimal? FilterByPriceMin { get; set; }

    /// <summary>
    /// Maximum price to filter the events.
    /// </summary>
    /// <value>Maximum price to filter the events.</value>
    [DataMember(Name="filter_by_price_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_price_max")]
    public decimal? FilterByPriceMax { get; set; }

    /// <summary>
    /// Minimum distance to filter events.
    /// </summary>
    /// <value>Minimum distance to filter events.</value>
    [DataMember(Name="filter_by_distance_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_distance_min")]
    public decimal? FilterByDistanceMin { get; set; }

    /// <summary>
    /// Maximum distance to filter events.
    /// </summary>
    /// <value>Maximum distance to filter events.</value>
    [DataMember(Name="filter_by_distance_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_distance_max")]
    public decimal? FilterByDistanceMax { get; set; }

    /// <summary>
    /// Minimum rating to filter events.
    /// </summary>
    /// <value>Minimum rating to filter events.</value>
    [DataMember(Name="filter_by_rating_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_rating_min")]
    public decimal? FilterByRatingMin { get; set; }

    /// <summary>
    /// Maximum rating to filter events.
    /// </summary>
    /// <value>Maximum rating to filter events.</value>
    [DataMember(Name="filter_by_rating_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_rating_max")]
    public decimal? FilterByRatingMax { get; set; }

    /// <summary>
    /// Filter events by specific performers.
    /// </summary>
    /// <value>Filter events by specific performers.</value>
    [DataMember(Name="filter_by_performers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_performers")]
    public List<string> FilterByPerformers { get; set; }

    /// <summary>
    /// Filter events by specific subcategories.
    /// </summary>
    /// <value>Filter events by specific subcategories.</value>
    [DataMember(Name="filter_by_subcategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_subcategories")]
    public List<string> FilterBySubcategories { get; set; }

    /// <summary>
    /// Field to sort events by.
    /// </summary>
    /// <value>Field to sort events by.</value>
    [DataMember(Name="sort_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_by")]
    public string SortBy { get; set; }

    /// <summary>
    /// Order to sort events (asc, desc).
    /// </summary>
    /// <value>Order to sort events (asc, desc).</value>
    [DataMember(Name="sort_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_order")]
    public string SortOrder { get; set; }

    /// <summary>
    /// Page number for pagination.
    /// </summary>
    /// <value>Page number for pagination.</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public decimal? Page { get; set; }

    /// <summary>
    /// Number of events per page.
    /// </summary>
    /// <value>Number of events per page.</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public decimal? Limit { get; set; }

    /// <summary>
    /// Language for the event offers.
    /// </summary>
    /// <value>Language for the event offers.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Currency for the event offers.
    /// </summary>
    /// <value>Currency for the event offers.</value>
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
      sb.Append("class EventOfferRequestSchema {\n");
      sb.Append("  LocationLatitude: ").Append(LocationLatitude).Append("\n");
      sb.Append("  LocationLongitude: ").Append(LocationLongitude).Append("\n");
      sb.Append("  LocationRadius: ").Append(LocationRadius).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  FilterByKeyword: ").Append(FilterByKeyword).Append("\n");
      sb.Append("  FilterByPriceMin: ").Append(FilterByPriceMin).Append("\n");
      sb.Append("  FilterByPriceMax: ").Append(FilterByPriceMax).Append("\n");
      sb.Append("  FilterByDistanceMin: ").Append(FilterByDistanceMin).Append("\n");
      sb.Append("  FilterByDistanceMax: ").Append(FilterByDistanceMax).Append("\n");
      sb.Append("  FilterByRatingMin: ").Append(FilterByRatingMin).Append("\n");
      sb.Append("  FilterByRatingMax: ").Append(FilterByRatingMax).Append("\n");
      sb.Append("  FilterByPerformers: ").Append(FilterByPerformers).Append("\n");
      sb.Append("  FilterBySubcategories: ").Append(FilterBySubcategories).Append("\n");
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
