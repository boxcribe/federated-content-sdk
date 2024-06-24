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
  public class FlightOfferSegmentSchema {
    /// <summary>
    /// Unique identifier for the flight segment.
    /// </summary>
    /// <value>Unique identifier for the flight segment.</value>
    [DataMember(Name="segment_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "segment_id")]
    public Guid? SegmentId { get; set; }

    /// <summary>
    /// Total duration of the flight segment in minutes.
    /// </summary>
    /// <value>Total duration of the flight segment in minutes.</value>
    [DataMember(Name="duration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// Name of the origin airport.
    /// </summary>
    /// <value>Name of the origin airport.</value>
    [DataMember(Name="origin_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin_name")]
    public string OriginName { get; set; }

    /// <summary>
    /// IATA code of the origin airport.
    /// </summary>
    /// <value>IATA code of the origin airport.</value>
    [DataMember(Name="origin_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin_code")]
    public string OriginCode { get; set; }

    /// <summary>
    /// Latitude of the origin airport.
    /// </summary>
    /// <value>Latitude of the origin airport.</value>
    [DataMember(Name="origin_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin_latitude")]
    public float? OriginLatitude { get; set; }

    /// <summary>
    /// Longitude of the origin airport.
    /// </summary>
    /// <value>Longitude of the origin airport.</value>
    [DataMember(Name="origin_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin_longitude")]
    public float? OriginLongitude { get; set; }

    /// <summary>
    /// Terminal at the origin airport.
    /// </summary>
    /// <value>Terminal at the origin airport.</value>
    [DataMember(Name="origin_terminal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin_terminal")]
    public string OriginTerminal { get; set; }

    /// <summary>
    /// Name of the destination airport.
    /// </summary>
    /// <value>Name of the destination airport.</value>
    [DataMember(Name="destination_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination_name")]
    public string DestinationName { get; set; }

    /// <summary>
    /// IATA code of the destination airport.
    /// </summary>
    /// <value>IATA code of the destination airport.</value>
    [DataMember(Name="destination_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination_code")]
    public string DestinationCode { get; set; }

    /// <summary>
    /// Latitude of the destination airport.
    /// </summary>
    /// <value>Latitude of the destination airport.</value>
    [DataMember(Name="destination_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination_latitude")]
    public float? DestinationLatitude { get; set; }

    /// <summary>
    /// Longitude of the destination airport.
    /// </summary>
    /// <value>Longitude of the destination airport.</value>
    [DataMember(Name="destination_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination_longitude")]
    public float? DestinationLongitude { get; set; }

    /// <summary>
    /// Terminal at the destination airport.
    /// </summary>
    /// <value>Terminal at the destination airport.</value>
    [DataMember(Name="destination_terminal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destination_terminal")]
    public string DestinationTerminal { get; set; }

    /// <summary>
    /// Scheduled departure date and time.
    /// </summary>
    /// <value>Scheduled departure date and time.</value>
    [DataMember(Name="departure_date_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "departure_date_time")]
    public string DepartureDateTime { get; set; }

    /// <summary>
    /// Scheduled arrival date and time.
    /// </summary>
    /// <value>Scheduled arrival date and time.</value>
    [DataMember(Name="arrival_date_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "arrival_date_time")]
    public string ArrivalDateTime { get; set; }

    /// <summary>
    /// Name of the operating airline.
    /// </summary>
    /// <value>Name of the operating airline.</value>
    [DataMember(Name="operating_airline_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operating_airline_name")]
    public string OperatingAirlineName { get; set; }

    /// <summary>
    /// Code of the operating airline.
    /// </summary>
    /// <value>Code of the operating airline.</value>
    [DataMember(Name="operating_airline_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operating_airline_code")]
    public string OperatingAirlineCode { get; set; }

    /// <summary>
    /// Logo of the operating airline.
    /// </summary>
    /// <value>Logo of the operating airline.</value>
    [DataMember(Name="operating_airline_logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "operating_airline_logo")]
    public string OperatingAirlineLogo { get; set; }

    /// <summary>
    /// Name of the marketing airline.
    /// </summary>
    /// <value>Name of the marketing airline.</value>
    [DataMember(Name="marketing_airline_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marketing_airline_name")]
    public string MarketingAirlineName { get; set; }

    /// <summary>
    /// Code of the marketing airline.
    /// </summary>
    /// <value>Code of the marketing airline.</value>
    [DataMember(Name="marketing_airline_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marketing_airline_code")]
    public string MarketingAirlineCode { get; set; }

    /// <summary>
    /// Logo of the marketing airline.
    /// </summary>
    /// <value>Logo of the marketing airline.</value>
    [DataMember(Name="marketing_airline_logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marketing_airline_logo")]
    public string MarketingAirlineLogo { get; set; }

    /// <summary>
    /// Name of the aircraft.
    /// </summary>
    /// <value>Name of the aircraft.</value>
    [DataMember(Name="aircraft_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aircraft_name")]
    public string AircraftName { get; set; }

    /// <summary>
    /// Code of the aircraft.
    /// </summary>
    /// <value>Code of the aircraft.</value>
    [DataMember(Name="aircraft_code", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "aircraft_code")]
    public string AircraftCode { get; set; }

    /// <summary>
    /// Name of the fare brand.
    /// </summary>
    /// <value>Name of the fare brand.</value>
    [DataMember(Name="fare_brand_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fare_brand_name")]
    public string FareBrandName { get; set; }

    /// <summary>
    /// Array of FlightOfferSegmentPassengerSchema detailing passenger information.
    /// </summary>
    /// <value>Array of FlightOfferSegmentPassengerSchema detailing passenger information.</value>
    [DataMember(Name="passengers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passengers")]
    public List<FlightOfferSegmentPassengerSchema> Passengers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightOfferSegmentSchema {\n");
      sb.Append("  SegmentId: ").Append(SegmentId).Append("\n");
      sb.Append("  Duration: ").Append(Duration).Append("\n");
      sb.Append("  OriginName: ").Append(OriginName).Append("\n");
      sb.Append("  OriginCode: ").Append(OriginCode).Append("\n");
      sb.Append("  OriginLatitude: ").Append(OriginLatitude).Append("\n");
      sb.Append("  OriginLongitude: ").Append(OriginLongitude).Append("\n");
      sb.Append("  OriginTerminal: ").Append(OriginTerminal).Append("\n");
      sb.Append("  DestinationName: ").Append(DestinationName).Append("\n");
      sb.Append("  DestinationCode: ").Append(DestinationCode).Append("\n");
      sb.Append("  DestinationLatitude: ").Append(DestinationLatitude).Append("\n");
      sb.Append("  DestinationLongitude: ").Append(DestinationLongitude).Append("\n");
      sb.Append("  DestinationTerminal: ").Append(DestinationTerminal).Append("\n");
      sb.Append("  DepartureDateTime: ").Append(DepartureDateTime).Append("\n");
      sb.Append("  ArrivalDateTime: ").Append(ArrivalDateTime).Append("\n");
      sb.Append("  OperatingAirlineName: ").Append(OperatingAirlineName).Append("\n");
      sb.Append("  OperatingAirlineCode: ").Append(OperatingAirlineCode).Append("\n");
      sb.Append("  OperatingAirlineLogo: ").Append(OperatingAirlineLogo).Append("\n");
      sb.Append("  MarketingAirlineName: ").Append(MarketingAirlineName).Append("\n");
      sb.Append("  MarketingAirlineCode: ").Append(MarketingAirlineCode).Append("\n");
      sb.Append("  MarketingAirlineLogo: ").Append(MarketingAirlineLogo).Append("\n");
      sb.Append("  AircraftName: ").Append(AircraftName).Append("\n");
      sb.Append("  AircraftCode: ").Append(AircraftCode).Append("\n");
      sb.Append("  FareBrandName: ").Append(FareBrandName).Append("\n");
      sb.Append("  Passengers: ").Append(Passengers).Append("\n");
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
