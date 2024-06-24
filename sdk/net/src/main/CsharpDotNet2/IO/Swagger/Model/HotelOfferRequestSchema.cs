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
  public class HotelOfferRequestSchema {
    /// <summary>
    /// Latitude of the hotel location.
    /// </summary>
    /// <value>Latitude of the hotel location.</value>
    [DataMember(Name="location_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_latitude")]
    public float? LocationLatitude { get; set; }

    /// <summary>
    /// Longitude of the hotel location.
    /// </summary>
    /// <value>Longitude of the hotel location.</value>
    [DataMember(Name="location_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_longitude")]
    public float? LocationLongitude { get; set; }

    /// <summary>
    /// Search radius from the specified location.
    /// </summary>
    /// <value>Search radius from the specified location.</value>
    [DataMember(Name="location_radius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location_radius")]
    public float? LocationRadius { get; set; }

    /// <summary>
    /// Check-in date for the hotel booking.
    /// </summary>
    /// <value>Check-in date for the hotel booking.</value>
    [DataMember(Name="checkin_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkin_date")]
    public DateTime? CheckinDate { get; set; }

    /// <summary>
    /// Check-out date for the hotel booking.
    /// </summary>
    /// <value>Check-out date for the hotel booking.</value>
    [DataMember(Name="checkout_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkout_date")]
    public DateTime? CheckoutDate { get; set; }

    /// <summary>
    /// Details of rooms including number of adults and children per room.
    /// </summary>
    /// <value>Details of rooms including number of adults and children per room.</value>
    [DataMember(Name="rooms", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rooms")]
    public List<HotelOfferRequestSchemaRooms> Rooms { get; set; }

    /// <summary>
    /// Keyword to filter hotel offers.
    /// </summary>
    /// <value>Keyword to filter hotel offers.</value>
    [DataMember(Name="filter_by_keyword", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_keyword")]
    public string FilterByKeyword { get; set; }

    /// <summary>
    /// Minimum price filter for hotel offers.
    /// </summary>
    /// <value>Minimum price filter for hotel offers.</value>
    [DataMember(Name="filter_by_price_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_price_min")]
    public double? FilterByPriceMin { get; set; }

    /// <summary>
    /// Maximum price filter for hotel offers.
    /// </summary>
    /// <value>Maximum price filter for hotel offers.</value>
    [DataMember(Name="filter_by_price_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_price_max")]
    public double? FilterByPriceMax { get; set; }

    /// <summary>
    /// Minimum distance filter for hotel location.
    /// </summary>
    /// <value>Minimum distance filter for hotel location.</value>
    [DataMember(Name="filter_by_distance_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_distance_min")]
    public float? FilterByDistanceMin { get; set; }

    /// <summary>
    /// Maximum distance filter for hotel location.
    /// </summary>
    /// <value>Maximum distance filter for hotel location.</value>
    [DataMember(Name="filter_by_distance_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_distance_max")]
    public float? FilterByDistanceMax { get; set; }

    /// <summary>
    /// Minimum rating filter for hotels.
    /// </summary>
    /// <value>Minimum rating filter for hotels.</value>
    [DataMember(Name="filter_by_rating_min", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_rating_min")]
    public float? FilterByRatingMin { get; set; }

    /// <summary>
    /// Maximum rating filter for hotels.
    /// </summary>
    /// <value>Maximum rating filter for hotels.</value>
    [DataMember(Name="filter_by_rating_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_rating_max")]
    public float? FilterByRatingMax { get; set; }

    /// <summary>
    /// Filter hotels by star ratings.
    /// </summary>
    /// <value>Filter hotels by star ratings.</value>
    [DataMember(Name="filter_by_stars", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_stars")]
    public List<int?> FilterByStars { get; set; }

    /// <summary>
    /// Filter hotels by available facilities.
    /// </summary>
    /// <value>Filter hotels by available facilities.</value>
    [DataMember(Name="filter_by_facilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_facilities")]
    public List<string> FilterByFacilities { get; set; }

    /// <summary>
    /// Filter hotels by available amenities.
    /// </summary>
    /// <value>Filter hotels by available amenities.</value>
    [DataMember(Name="filter_by_amenities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter_by_amenities")]
    public List<string> FilterByAmenities { get; set; }

    /// <summary>
    /// Field to sort the results by.
    /// </summary>
    /// <value>Field to sort the results by.</value>
    [DataMember(Name="sort_by", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sort_by")]
    public string SortBy { get; set; }

    /// <summary>
    /// Order to sort the results, either asc or desc.
    /// </summary>
    /// <value>Order to sort the results, either asc or desc.</value>
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
    /// Number of items per page for pagination.
    /// </summary>
    /// <value>Number of items per page for pagination.</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Preferred language of the hotel information.
    /// </summary>
    /// <value>Preferred language of the hotel information.</value>
    [DataMember(Name="language", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "language")]
    public string Language { get; set; }

    /// <summary>
    /// Currency in which prices should be displayed.
    /// </summary>
    /// <value>Currency in which prices should be displayed.</value>
    [DataMember(Name="currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Unit of measure for distance, either miles (mi) or kilometers (km).
    /// </summary>
    /// <value>Unit of measure for distance, either miles (mi) or kilometers (km).</value>
    [DataMember(Name="metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metric")]
    public string Metric { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HotelOfferRequestSchema {\n");
      sb.Append("  LocationLatitude: ").Append(LocationLatitude).Append("\n");
      sb.Append("  LocationLongitude: ").Append(LocationLongitude).Append("\n");
      sb.Append("  LocationRadius: ").Append(LocationRadius).Append("\n");
      sb.Append("  CheckinDate: ").Append(CheckinDate).Append("\n");
      sb.Append("  CheckoutDate: ").Append(CheckoutDate).Append("\n");
      sb.Append("  Rooms: ").Append(Rooms).Append("\n");
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
