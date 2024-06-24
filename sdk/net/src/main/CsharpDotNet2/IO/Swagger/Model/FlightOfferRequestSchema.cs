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
  public class FlightOfferRequestSchema {
    /// <summary>
    /// Class options: first, business, premium economy, economy.
    /// </summary>
    /// <value>Class options: first, business, premium economy, economy.</value>
    [DataMember(Name="cabin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cabin")]
    public List Cabin { get; set; }

    /// <summary>
    /// Array of flight legs, each described in FlightLegOfferRequestSchema.
    /// </summary>
    /// <value>Array of flight legs, each described in FlightLegOfferRequestSchema.</value>
    [DataMember(Name="legs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "legs")]
    public List Legs { get; set; }

    /// <summary>
    /// Array of passengers, each described in FlightPassengerOfferRequestSchema.
    /// </summary>
    /// <value>Array of passengers, each described in FlightPassengerOfferRequestSchema.</value>
    [DataMember(Name="passengers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passengers")]
    public List Passengers { get; set; }

    /// <summary>
    /// Array of codes for accessing special negotiated fares.
    /// </summary>
    /// <value>Array of codes for accessing special negotiated fares.</value>
    [DataMember(Name="private_fare_codes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "private_fare_codes")]
    public List PrivateFareCodes { get; set; }

    /// <summary>
    /// Keyword to filter offers.
    /// </summary>
    /// <value>Keyword to filter offers.</value>
    [DataMember(Name="filter_by_keyword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_keyword")]
    public string FilterByKeyword { get; set; }

    /// <summary>
    /// Minimum price filter.
    /// </summary>
    /// <value>Minimum price filter.</value>
    [DataMember(Name="filter_by_price_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_price_min")]
    public float? FilterByPriceMin { get; set; }

    /// <summary>
    /// Maximum price filter.
    /// </summary>
    /// <value>Maximum price filter.</value>
    [DataMember(Name="filter_by_price_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_price_max")]
    public float? FilterByPriceMax { get; set; }

    /// <summary>
    /// Minimum flight duration filter.
    /// </summary>
    /// <value>Minimum flight duration filter.</value>
    [DataMember(Name="filter_by_duration_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_duration_min")]
    public int? FilterByDurationMin { get; set; }

    /// <summary>
    /// Maximum flight duration filter.
    /// </summary>
    /// <value>Maximum flight duration filter.</value>
    [DataMember(Name="filter_by_duration_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_duration_max")]
    public int? FilterByDurationMax { get; set; }

    /// <summary>
    /// Earliest departure time filter.
    /// </summary>
    /// <value>Earliest departure time filter.</value>
    [DataMember(Name="filter_by_departure_time_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_departure_time_min")]
    public string FilterByDepartureTimeMin { get; set; }

    /// <summary>
    /// Latest departure time filter.
    /// </summary>
    /// <value>Latest departure time filter.</value>
    [DataMember(Name="filter_by_departure_time_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_departure_time_max")]
    public string FilterByDepartureTimeMax { get; set; }

    /// <summary>
    /// Earliest arrival time filter.
    /// </summary>
    /// <value>Earliest arrival time filter.</value>
    [DataMember(Name="filter_by_arrival_time_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_arrival_time_min")]
    public string FilterByArrivalTimeMin { get; set; }

    /// <summary>
    /// Latest arrival time filter.
    /// </summary>
    /// <value>Latest arrival time filter.</value>
    [DataMember(Name="filter_by_arrival_time_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_arrival_time_max")]
    public string FilterByArrivalTimeMax { get; set; }

    /// <summary>
    /// Minimum number of stops filter.
    /// </summary>
    /// <value>Minimum number of stops filter.</value>
    [DataMember(Name="filter_by_stops_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_stops_min")]
    public int? FilterByStopsMin { get; set; }

    /// <summary>
    /// Maximum number of stops filter.
    /// </summary>
    /// <value>Maximum number of stops filter.</value>
    [DataMember(Name="filter_by_stops_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_stops_max")]
    public int? FilterByStopsMax { get; set; }

    /// <summary>
    /// List of airline filters.
    /// </summary>
    /// <value>List of airline filters.</value>
    [DataMember(Name="filter_by_airlines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_airlines")]
    public List FilterByAirlines { get; set; }

    /// <summary>
    /// List of airport filters.
    /// </summary>
    /// <value>List of airport filters.</value>
    [DataMember(Name="filter_by_airports", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_airports")]
    public List FilterByAirports { get; set; }

    /// <summary>
    /// Sorting criteria.
    /// </summary>
    /// <value>Sorting criteria.</value>
    [DataMember(Name="sort_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_by")]
    public string SortBy { get; set; }

    /// <summary>
    /// Sorting order, asc or desc.
    /// </summary>
    /// <value>Sorting order, asc or desc.</value>
    [DataMember(Name="sort_order", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_order")]
    public string SortOrder { get; set; }

    /// <summary>
    /// Pagination: page number.
    /// </summary>
    /// <value>Pagination: page number.</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public int? Page { get; set; }

    /// <summary>
    /// Pagination: maximum items per page.
    /// </summary>
    /// <value>Pagination: maximum items per page.</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Language selection for offer details.
    /// </summary>
    /// <value>Language selection for offer details.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Currency in which prices should be provided.
    /// </summary>
    /// <value>Currency in which prices should be provided.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightOfferRequestSchema {\n");
      sb.Append("  Cabin: ").Append(Cabin).Append("\n");
      sb.Append("  Legs: ").Append(Legs).Append("\n");
      sb.Append("  Passengers: ").Append(Passengers).Append("\n");
      sb.Append("  PrivateFareCodes: ").Append(PrivateFareCodes).Append("\n");
      sb.Append("  FilterByKeyword: ").Append(FilterByKeyword).Append("\n");
      sb.Append("  FilterByPriceMin: ").Append(FilterByPriceMin).Append("\n");
      sb.Append("  FilterByPriceMax: ").Append(FilterByPriceMax).Append("\n");
      sb.Append("  FilterByDurationMin: ").Append(FilterByDurationMin).Append("\n");
      sb.Append("  FilterByDurationMax: ").Append(FilterByDurationMax).Append("\n");
      sb.Append("  FilterByDepartureTimeMin: ").Append(FilterByDepartureTimeMin).Append("\n");
      sb.Append("  FilterByDepartureTimeMax: ").Append(FilterByDepartureTimeMax).Append("\n");
      sb.Append("  FilterByArrivalTimeMin: ").Append(FilterByArrivalTimeMin).Append("\n");
      sb.Append("  FilterByArrivalTimeMax: ").Append(FilterByArrivalTimeMax).Append("\n");
      sb.Append("  FilterByStopsMin: ").Append(FilterByStopsMin).Append("\n");
      sb.Append("  FilterByStopsMax: ").Append(FilterByStopsMax).Append("\n");
      sb.Append("  FilterByAirlines: ").Append(FilterByAirlines).Append("\n");
      sb.Append("  FilterByAirports: ").Append(FilterByAirports).Append("\n");
      sb.Append("  SortBy: ").Append(SortBy).Append("\n");
      sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Language: ").Append(Language).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
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
