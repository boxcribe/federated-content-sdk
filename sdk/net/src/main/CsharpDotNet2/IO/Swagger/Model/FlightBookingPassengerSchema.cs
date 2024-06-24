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
  public class FlightBookingPassengerSchema {
    /// <summary>
    /// Unique identifier for the passenger.
    /// </summary>
    /// <value>Unique identifier for the passenger.</value>
    [DataMember(Name="passenger_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passenger_id")]
    public Guid? PassengerId { get; set; }

    /// <summary>
    /// Type of passenger (adult, child, infant, infant with seat).
    /// </summary>
    /// <value>Type of passenger (adult, child, infant, infant with seat).</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Title of the passenger (e.g., Mr., Mrs.).
    /// </summary>
    /// <value>Title of the passenger (e.g., Mr., Mrs.).</value>
    [DataMember(Name="title", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title")]
    public string Title { get; set; }

    /// <summary>
    /// First name of the passenger.
    /// </summary>
    /// <value>First name of the passenger.</value>
    [DataMember(Name="first_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "first_name")]
    public string FirstName { get; set; }

    /// <summary>
    /// Last name of the passenger.
    /// </summary>
    /// <value>Last name of the passenger.</value>
    [DataMember(Name="last_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last_name")]
    public string LastName { get; set; }

    /// <summary>
    /// Gender of the passenger.
    /// </summary>
    /// <value>Gender of the passenger.</value>
    [DataMember(Name="gender", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "gender")]
    public string Gender { get; set; }

    /// <summary>
    /// Date of birth of the passenger.
    /// </summary>
    /// <value>Date of birth of the passenger.</value>
    [DataMember(Name="date_of_birth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "date_of_birth")]
    public DateTime? DateOfBirth { get; set; }

    /// <summary>
    /// Country of the passenger.
    /// </summary>
    /// <value>Country of the passenger.</value>
    [DataMember(Name="country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "country")]
    public string Country { get; set; }

    /// <summary>
    /// International dialing prefix for phone number.
    /// </summary>
    /// <value>International dialing prefix for phone number.</value>
    [DataMember(Name="phone_prefix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_prefix")]
    public string PhonePrefix { get; set; }

    /// <summary>
    /// Phone number of the passenger.
    /// </summary>
    /// <value>Phone number of the passenger.</value>
    [DataMember(Name="phone_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "phone_number")]
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Type of passport.
    /// </summary>
    /// <value>Type of passport.</value>
    [DataMember(Name="passport_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passport_type")]
    public string PassportType { get; set; }

    /// <summary>
    /// Passport number of the passenger.
    /// </summary>
    /// <value>Passport number of the passenger.</value>
    [DataMember(Name="passport_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passport_number")]
    public string PassportNumber { get; set; }

    /// <summary>
    /// Expiration date of the passport.
    /// </summary>
    /// <value>Expiration date of the passport.</value>
    [DataMember(Name="passport_expiration_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passport_expiration_date")]
    public DateTime? PassportExpirationDate { get; set; }

    /// <summary>
    /// Country of issue of the passport.
    /// </summary>
    /// <value>Country of issue of the passport.</value>
    [DataMember(Name="passport_country", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passport_country")]
    public string PassportCountry { get; set; }

    /// <summary>
    /// Airline with which the passenger has loyalty membership.
    /// </summary>
    /// <value>Airline with which the passenger has loyalty membership.</value>
    [DataMember(Name="loyalty_airline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loyalty_airline")]
    public string LoyaltyAirline { get; set; }

    /// <summary>
    /// Loyalty membership number.
    /// </summary>
    /// <value>Loyalty membership number.</value>
    [DataMember(Name="loyalty_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loyalty_number")]
    public string LoyaltyNumber { get; set; }

    /// <summary>
    /// Known traveler number.
    /// </summary>
    /// <value>Known traveler number.</value>
    [DataMember(Name="known_traveler_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "known_traveler_number")]
    public string KnownTravelerNumber { get; set; }

    /// <summary>
    /// Redress number of the passenger.
    /// </summary>
    /// <value>Redress number of the passenger.</value>
    [DataMember(Name="passenger_redress_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "passenger_redress_number")]
    public string PassengerRedressNumber { get; set; }

    /// <summary>
    /// Identifier for any associated infant passenger.
    /// </summary>
    /// <value>Identifier for any associated infant passenger.</value>
    [DataMember(Name="associated_infant_passenger_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "associated_infant_passenger_id")]
    public Guid? AssociatedInfantPassengerId { get; set; }

    /// <summary>
    /// Array of selected seats, each defined in BookingPassengerSelectedSeatSchema.
    /// </summary>
    /// <value>Array of selected seats, each defined in BookingPassengerSelectedSeatSchema.</value>
    [DataMember(Name="seats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seats")]
    public List<BookingPassengerSelectedSeatSchema> Seats { get; set; }

    /// <summary>
    /// Array of extra bags, each defined in BookingPassengerExtraBagSchema.
    /// </summary>
    /// <value>Array of extra bags, each defined in BookingPassengerExtraBagSchema.</value>
    [DataMember(Name="bags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bags")]
    public List<BookingPassengerExtraBagSchema> Bags { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightBookingPassengerSchema {\n");
      sb.Append("  PassengerId: ").Append(PassengerId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Title: ").Append(Title).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Gender: ").Append(Gender).Append("\n");
      sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
      sb.Append("  Country: ").Append(Country).Append("\n");
      sb.Append("  PhonePrefix: ").Append(PhonePrefix).Append("\n");
      sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
      sb.Append("  PassportType: ").Append(PassportType).Append("\n");
      sb.Append("  PassportNumber: ").Append(PassportNumber).Append("\n");
      sb.Append("  PassportExpirationDate: ").Append(PassportExpirationDate).Append("\n");
      sb.Append("  PassportCountry: ").Append(PassportCountry).Append("\n");
      sb.Append("  LoyaltyAirline: ").Append(LoyaltyAirline).Append("\n");
      sb.Append("  LoyaltyNumber: ").Append(LoyaltyNumber).Append("\n");
      sb.Append("  KnownTravelerNumber: ").Append(KnownTravelerNumber).Append("\n");
      sb.Append("  PassengerRedressNumber: ").Append(PassengerRedressNumber).Append("\n");
      sb.Append("  AssociatedInfantPassengerId: ").Append(AssociatedInfantPassengerId).Append("\n");
      sb.Append("  Seats: ").Append(Seats).Append("\n");
      sb.Append("  Bags: ").Append(Bags).Append("\n");
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
