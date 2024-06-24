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
  public class ToursAndActivitiesOfferRequestSchema {
    /// <summary>
    /// Latitude for the location.
    /// </summary>
    /// <value>Latitude for the location.</value>
    [DataMember(Name="location_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_latitude")]
    public float? LocationLatitude { get; set; }

    /// <summary>
    /// Longitude for the location.
    /// </summary>
    /// <value>Longitude for the location.</value>
    [DataMember(Name="location_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_longitude")]
    public float? LocationLongitude { get; set; }

    /// <summary>
    /// Radius to search for tours and activities from the specified location.
    /// </summary>
    /// <value>Radius to search for tours and activities from the specified location.</value>
    [DataMember(Name="location_radius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_radius")]
    public float? LocationRadius { get; set; }

    /// <summary>
    /// Starting date for tours and activities.
    /// </summary>
    /// <value>Starting date for tours and activities.</value>
    [DataMember(Name="start_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "start_date")]
    public DateTime? StartDate { get; set; }

    /// <summary>
    /// Ending date for tours and activities.
    /// </summary>
    /// <value>Ending date for tours and activities.</value>
    [DataMember(Name="end_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "end_date")]
    public DateTime? EndDate { get; set; }

    /// <summary>
    /// Number of adults participating.
    /// </summary>
    /// <value>Number of adults participating.</value>
    [DataMember(Name="adults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adults")]
    public int? Adults { get; set; }

    /// <summary>
    /// Number of children participating.
    /// </summary>
    /// <value>Number of children participating.</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public int? Children { get; set; }

    /// <summary>
    /// Keyword to filter tours and activities.
    /// </summary>
    /// <value>Keyword to filter tours and activities.</value>
    [DataMember(Name="filter_by_keyword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_keyword")]
    public string FilterByKeyword { get; set; }

    /// <summary>
    /// Minimum price filter.
    /// </summary>
    /// <value>Minimum price filter.</value>
    [DataMember(Name="filter_by_price_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_price_min")]
    public decimal? FilterByPriceMin { get; set; }

    /// <summary>
    /// Maximum price filter.
    /// </summary>
    /// <value>Maximum price filter.</value>
    [DataMember(Name="filter_by_price_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_price_max")]
    public decimal? FilterByPriceMax { get; set; }

    /// <summary>
    /// Minimum distance filter.
    /// </summary>
    /// <value>Minimum distance filter.</value>
    [DataMember(Name="filter_by_distance_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_distance_min")]
    public int? FilterByDistanceMin { get; set; }

    /// <summary>
    /// Maximum distance filter.
    /// </summary>
    /// <value>Maximum distance filter.</value>
    [DataMember(Name="filter_by_distance_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_distance_max")]
    public int? FilterByDistanceMax { get; set; }

    /// <summary>
    /// Minimum rating filter.
    /// </summary>
    /// <value>Minimum rating filter.</value>
    [DataMember(Name="filter_by_rating_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_rating_min")]
    public int? FilterByRatingMin { get; set; }

    /// <summary>
    /// Maximum rating filter.
    /// </summary>
    /// <value>Maximum rating filter.</value>
    [DataMember(Name="filter_by_rating_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_rating_max")]
    public int? FilterByRatingMax { get; set; }

    /// <summary>
    /// Subcategories to filter tours and activities.
    /// </summary>
    /// <value>Subcategories to filter tours and activities.</value>
    [DataMember(Name="filter_by_subcategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_subcategories")]
    public List<string> FilterBySubcategories { get; set; }

    /// <summary>
    /// Criteria to sort the search results.
    /// </summary>
    /// <value>Criteria to sort the search results.</value>
    [DataMember(Name="sort_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_by")]
    public string SortBy { get; set; }

    /// <summary>
    /// Order to sort the results (ascending or descending).
    /// </summary>
    /// <value>Order to sort the results (ascending or descending).</value>
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
    /// Number of items per page.
    /// </summary>
    /// <value>Number of items per page.</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Language of the tour offers.
    /// </summary>
    /// <value>Language of the tour offers.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Currency in which prices are displayed.
    /// </summary>
    /// <value>Currency in which prices are displayed.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Unit for distance measurement (mi/km) used in filters.
    /// </summary>
    /// <value>Unit for distance measurement (mi/km) used in filters.</value>
    [DataMember(Name="metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metric")]
    public string Metric { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ToursAndActivitiesOfferRequestSchema {\n");
      sb.Append("  LocationLatitude: ").Append(LocationLatitude).Append("\n");
      sb.Append("  LocationLongitude: ").Append(LocationLongitude).Append("\n");
      sb.Append("  LocationRadius: ").Append(LocationRadius).Append("\n");
      sb.Append("  StartDate: ").Append(StartDate).Append("\n");
      sb.Append("  EndDate: ").Append(EndDate).Append("\n");
      sb.Append("  Adults: ").Append(Adults).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  FilterByKeyword: ").Append(FilterByKeyword).Append("\n");
      sb.Append("  FilterByPriceMin: ").Append(FilterByPriceMin).Append("\n");
      sb.Append("  FilterByPriceMax: ").Append(FilterByPriceMax).Append("\n");
      sb.Append("  FilterByDistanceMin: ").Append(FilterByDistanceMin).Append("\n");
      sb.Append("  FilterByDistanceMax: ").Append(FilterByDistanceMax).Append("\n");
      sb.Append("  FilterByRatingMin: ").Append(FilterByRatingMin).Append("\n");
      sb.Append("  FilterByRatingMax: ").Append(FilterByRatingMax).Append("\n");
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
