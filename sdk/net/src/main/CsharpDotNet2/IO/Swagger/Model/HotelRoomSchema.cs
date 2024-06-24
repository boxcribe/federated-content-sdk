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
  public class HotelRoomSchema {
    /// <summary>
    /// Unique identifier for each room.
    /// </summary>
    /// <value>Unique identifier for each room.</value>
    [DataMember(Name="room_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "room_id")]
    public Guid? RoomId { get; set; }

    /// <summary>
    /// Supplier specific identifier for the room.
    /// </summary>
    /// <value>Supplier specific identifier for the room.</value>
    [DataMember(Name="supplier_room_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_room_id")]
    public string SupplierRoomId { get; set; }

    /// <summary>
    /// Position of the room in the list.
    /// </summary>
    /// <value>Position of the room in the list.</value>
    [DataMember(Name="room_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "room_index")]
    public int? RoomIndex { get; set; }

    /// <summary>
    /// Start date of the hotel reservation.
    /// </summary>
    /// <value>Start date of the hotel reservation.</value>
    [DataMember(Name="checkin_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkin_date")]
    public DateTime? CheckinDate { get; set; }

    /// <summary>
    /// End date of the hotel reservation.
    /// </summary>
    /// <value>End date of the hotel reservation.</value>
    [DataMember(Name="checkout_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkout_date")]
    public DateTime? CheckoutDate { get; set; }

    /// <summary>
    /// Number of adults that can be accommodated in the room.
    /// </summary>
    /// <value>Number of adults that can be accommodated in the room.</value>
    [DataMember(Name="adults", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "adults")]
    public int? Adults { get; set; }

    /// <summary>
    /// Number of children that can be accommodated in the room.
    /// </summary>
    /// <value>Number of children that can be accommodated in the room.</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public int? Children { get; set; }

    /// <summary>
    /// Tax rate applicable to the room price.
    /// </summary>
    /// <value>Tax rate applicable to the room price.</value>
    [DataMember(Name="room_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "room_tax")]
    public double? RoomTax { get; set; }

    /// <summary>
    /// Nightly rate for the room.
    /// </summary>
    /// <value>Nightly rate for the room.</value>
    [DataMember(Name="room_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "room_price")]
    public double? RoomPrice { get; set; }

    /// <summary>
    /// Currency used for the room pricing.
    /// </summary>
    /// <value>Currency used for the room pricing.</value>
    [DataMember(Name="room_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "room_currency")]
    public string RoomCurrency { get; set; }

    /// <summary>
    /// Details about the cancellation policy for the room.
    /// </summary>
    /// <value>Details about the cancellation policy for the room.</value>
    [DataMember(Name="room_cancellation_policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "room_cancellation_policies")]
    public Object RoomCancellationPolicies { get; set; }

    /// <summary>
    /// Type or name of the room.
    /// </summary>
    /// <value>Type or name of the room.</value>
    [DataMember(Name="room_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "room_name")]
    public string RoomName { get; set; }

    /// <summary>
    /// Description of the room including amenities and features.
    /// </summary>
    /// <value>Description of the room including amenities and features.</value>
    [DataMember(Name="room_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "room_description")]
    public string RoomDescription { get; set; }

    /// <summary>
    /// Images showcasing the room.
    /// </summary>
    /// <value>Images showcasing the room.</value>
    [DataMember(Name="room_images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "room_images")]
    public List<string> RoomImages { get; set; }

    /// <summary>
    /// Maximum quantity of this room type available.
    /// </summary>
    /// <value>Maximum quantity of this room type available.</value>
    [DataMember(Name="room_quantity_max", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "room_quantity_max")]
    public int? RoomQuantityMax { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HotelRoomSchema {\n");
      sb.Append("  RoomId: ").Append(RoomId).Append("\n");
      sb.Append("  SupplierRoomId: ").Append(SupplierRoomId).Append("\n");
      sb.Append("  RoomIndex: ").Append(RoomIndex).Append("\n");
      sb.Append("  CheckinDate: ").Append(CheckinDate).Append("\n");
      sb.Append("  CheckoutDate: ").Append(CheckoutDate).Append("\n");
      sb.Append("  Adults: ").Append(Adults).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  RoomTax: ").Append(RoomTax).Append("\n");
      sb.Append("  RoomPrice: ").Append(RoomPrice).Append("\n");
      sb.Append("  RoomCurrency: ").Append(RoomCurrency).Append("\n");
      sb.Append("  RoomCancellationPolicies: ").Append(RoomCancellationPolicies).Append("\n");
      sb.Append("  RoomName: ").Append(RoomName).Append("\n");
      sb.Append("  RoomDescription: ").Append(RoomDescription).Append("\n");
      sb.Append("  RoomImages: ").Append(RoomImages).Append("\n");
      sb.Append("  RoomQuantityMax: ").Append(RoomQuantityMax).Append("\n");
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
