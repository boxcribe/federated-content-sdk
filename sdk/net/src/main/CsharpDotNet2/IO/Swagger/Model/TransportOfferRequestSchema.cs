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
  public class TransportOfferRequestSchema {
    /// <summary>
    /// Latitude for the pickup location.
    /// </summary>
    /// <value>Latitude for the pickup location.</value>
    [DataMember(Name="pickup_location_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_location_latitude")]
    public float? PickupLocationLatitude { get; set; }

    /// <summary>
    /// Longitude for the pickup location.
    /// </summary>
    /// <value>Longitude for the pickup location.</value>
    [DataMember(Name="pickup_location_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_location_longitude")]
    public float? PickupLocationLongitude { get; set; }

    /// <summary>
    /// Date of the pickup.
    /// </summary>
    /// <value>Date of the pickup.</value>
    [DataMember(Name="pickup_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_date")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Time of the pickup.
    /// </summary>
    /// <value>Time of the pickup.</value>
    [DataMember(Name="pickup_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_time")]
    public string PickupTime { get; set; }

    /// <summary>
    /// Number of adults.
    /// </summary>
    /// <value>Number of adults.</value>
    [DataMember(Name="adults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adults")]
    public int? Adults { get; set; }

    /// <summary>
    /// Number of children.
    /// </summary>
    /// <value>Number of children.</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public int? Children { get; set; }

    /// <summary>
    /// Latitude for the return location.
    /// </summary>
    /// <value>Latitude for the return location.</value>
    [DataMember(Name="return_location_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_location_latitude")]
    public float? ReturnLocationLatitude { get; set; }

    /// <summary>
    /// Longitude for the return location.
    /// </summary>
    /// <value>Longitude for the return location.</value>
    [DataMember(Name="return_location_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_location_longitude")]
    public float? ReturnLocationLongitude { get; set; }

    /// <summary>
    /// Date of the return.
    /// </summary>
    /// <value>Date of the return.</value>
    [DataMember(Name="return_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_date")]
    public DateTime? ReturnDate { get; set; }

    /// <summary>
    /// Time of the return.
    /// </summary>
    /// <value>Time of the return.</value>
    [DataMember(Name="return_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "return_time")]
    public string ReturnTime { get; set; }

    /// <summary>
    /// Keyword filter.
    /// </summary>
    /// <value>Keyword filter.</value>
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
    /// Filter by star rating.
    /// </summary>
    /// <value>Filter by star rating.</value>
    [DataMember(Name="filter_by_stars", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_stars")]
    public List<string> FilterByStars { get; set; }

    /// <summary>
    /// Facilities filter.
    /// </summary>
    /// <value>Facilities filter.</value>
    [DataMember(Name="filter_by_facilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_facilities")]
    public List<string> FilterByFacilities { get; set; }

    /// <summary>
    /// Amenities filter.
    /// </summary>
    /// <value>Amenities filter.</value>
    [DataMember(Name="filter_by_amenities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_amenities")]
    public List<string> FilterByAmenities { get; set; }

    /// <summary>
    /// Minimum passengers filter.
    /// </summary>
    /// <value>Minimum passengers filter.</value>
    [DataMember(Name="filter_by_passengers_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_passengers_min")]
    public int? FilterByPassengersMin { get; set; }

    /// <summary>
    /// Maximum passengers filter.
    /// </summary>
    /// <value>Maximum passengers filter.</value>
    [DataMember(Name="filter_by_passengers_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_passengers_max")]
    public int? FilterByPassengersMax { get; set; }

    /// <summary>
    /// Minimum bags filter.
    /// </summary>
    /// <value>Minimum bags filter.</value>
    [DataMember(Name="filter_by_bags_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_bags_min")]
    public int? FilterByBagsMin { get; set; }

    /// <summary>
    /// Maximum bags filter.
    /// </summary>
    /// <value>Maximum bags filter.</value>
    [DataMember(Name="filter_by_bags_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_bags_max")]
    public int? FilterByBagsMax { get; set; }

    /// <summary>
    /// Type filter.
    /// </summary>
    /// <value>Type filter.</value>
    [DataMember(Name="filter_by_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_type")]
    public List<string> FilterByType { get; set; }

    /// <summary>
    /// Company filter.
    /// </summary>
    /// <value>Company filter.</value>
    [DataMember(Name="filter_by_company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_company")]
    public List<string> FilterByCompany { get; set; }

    /// <summary>
    /// Class filter.
    /// </summary>
    /// <value>Class filter.</value>
    [DataMember(Name="filter_by_class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_class")]
    public List<string> FilterByClass { get; set; }

    /// <summary>
    /// Sorting parameter.
    /// </summary>
    /// <value>Sorting parameter.</value>
    [DataMember(Name="sort_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_by")]
    public string SortBy { get; set; }

    /// <summary>
    /// Sort order (asc/desc).
    /// </summary>
    /// <value>Sort order (asc/desc).</value>
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
    /// Limit of results per page.
    /// </summary>
    /// <value>Limit of results per page.</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Language for the results.
    /// </summary>
    /// <value>Language for the results.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Currency for pricing.
    /// </summary>
    /// <value>Currency for pricing.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Unit of measurement for distances.
    /// </summary>
    /// <value>Unit of measurement for distances.</value>
    [DataMember(Name="metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metric")]
    public string Metric { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransportOfferRequestSchema {\n");
      sb.Append("  PickupLocationLatitude: ").Append(PickupLocationLatitude).Append("\n");
      sb.Append("  PickupLocationLongitude: ").Append(PickupLocationLongitude).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  PickupTime: ").Append(PickupTime).Append("\n");
      sb.Append("  Adults: ").Append(Adults).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  ReturnLocationLatitude: ").Append(ReturnLocationLatitude).Append("\n");
      sb.Append("  ReturnLocationLongitude: ").Append(ReturnLocationLongitude).Append("\n");
      sb.Append("  ReturnDate: ").Append(ReturnDate).Append("\n");
      sb.Append("  ReturnTime: ").Append(ReturnTime).Append("\n");
      sb.Append("  FilterByKeyword: ").Append(FilterByKeyword).Append("\n");
      sb.Append("  FilterByPriceMin: ").Append(FilterByPriceMin).Append("\n");
      sb.Append("  FilterByPriceMax: ").Append(FilterByPriceMax).Append("\n");
      sb.Append("  FilterByDistanceMin: ").Append(FilterByDistanceMin).Append("\n");
      sb.Append("  FilterByDistanceMax: ").Append(FilterByDistanceMax).Append("\n");
      sb.Append("  FilterByRatingMin: ").Append(FilterByRatingMin).Append("\n");
      sb.Append("  FilterByRatingMax: ").Append(FilterByRatingMax).Append("\n");
      sb.Append("  FilterByStars: ").Append(FilterByStars).Append("\n");
      sb.Append("  FilterByFacilities: ").Append(FilterByFacilities).Append("\n");
      sb.Append("  FilterByAmenities: ").Append(FilterByAmenities).Append("\n");
      sb.Append("  FilterByPassengersMin: ").Append(FilterByPassengersMin).Append("\n");
      sb.Append("  FilterByPassengersMax: ").Append(FilterByPassengersMax).Append("\n");
      sb.Append("  FilterByBagsMin: ").Append(FilterByBagsMin).Append("\n");
      sb.Append("  FilterByBagsMax: ").Append(FilterByBagsMax).Append("\n");
      sb.Append("  FilterByType: ").Append(FilterByType).Append("\n");
      sb.Append("  FilterByCompany: ").Append(FilterByCompany).Append("\n");
      sb.Append("  FilterByClass: ").Append(FilterByClass).Append("\n");
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
