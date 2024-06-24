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
  public class FlightOfferPassengerSchema {
    /// <summary>
    /// Unique identifier for each passenger.
    /// </summary>
    /// <value>Unique identifier for each passenger.</value>
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
    /// Age of the passenger.
    /// </summary>
    /// <value>Age of the passenger.</value>
    [DataMember(Name="age", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "age")]
    public int? Age { get; set; }

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
    /// Airline with which the passenger has a loyalty program.
    /// </summary>
    /// <value>Airline with which the passenger has a loyalty program.</value>
    [DataMember(Name="loyalty_airline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loyalty_airline")]
    public string LoyaltyAirline { get; set; }

    /// <summary>
    /// Loyalty program membership number.
    /// </summary>
    /// <value>Loyalty program membership number.</value>
    [DataMember(Name="loyalty_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loyalty_number")]
    public string LoyaltyNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FlightOfferPassengerSchema {\n");
      sb.Append("  PassengerId: ").Append(PassengerId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Age: ").Append(Age).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  LoyaltyAirline: ").Append(LoyaltyAirline).Append("\n");
      sb.Append("  LoyaltyNumber: ").Append(LoyaltyNumber).Append("\n");
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
