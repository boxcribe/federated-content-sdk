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
  public class HotelOfferResponseItemSchema {
    /// <summary>
    /// Unique identifier for the hotel offer.
    /// </summary>
    /// <value>Unique identifier for the hotel offer.</value>
    [DataMember(Name="offerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerId")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Unique identifier given by the supplier for the hotel offer.
    /// </summary>
    /// <value>Unique identifier given by the supplier for the hotel offer.</value>
    [DataMember(Name="supplierOfferId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplierOfferId")]
    public Guid? SupplierOfferId { get; set; }

    /// <summary>
    /// Index number of the offer for sorting and referencing purposes.
    /// </summary>
    /// <value>Index number of the offer for sorting and referencing purposes.</value>
    [DataMember(Name="offerIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerIndex")]
    public int? OfferIndex { get; set; }

    /// <summary>
    /// Applicable tax amount for the offer.
    /// </summary>
    /// <value>Applicable tax amount for the offer.</value>
    [DataMember(Name="offerTax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerTax")]
    public double? OfferTax { get; set; }

    /// <summary>
    /// Total price of the hotel offer.
    /// </summary>
    /// <value>Total price of the hotel offer.</value>
    [DataMember(Name="offerPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerPrice")]
    public double? OfferPrice { get; set; }

    /// <summary>
    /// Currency in which the offer price is denominated.
    /// </summary>
    /// <value>Currency in which the offer price is denominated.</value>
    [DataMember(Name="offerCurrency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerCurrency")]
    public string OfferCurrency { get; set; }

    /// <summary>
    /// Details of the cancellation policies applicable to the offer.
    /// </summary>
    /// <value>Details of the cancellation policies applicable to the offer.</value>
    [DataMember(Name="offerCancellationPolicies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offerCancellationPolicies")]
    public Object OfferCancellationPolicies { get; set; }

    /// <summary>
    /// Scheduled check-in date for the hotel stay.
    /// </summary>
    /// <value>Scheduled check-in date for the hotel stay.</value>
    [DataMember(Name="checkinDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkinDate")]
    public DateTime? CheckinDate { get; set; }

    /// <summary>
    /// Scheduled check-out date for the hotel stay.
    /// </summary>
    /// <value>Scheduled check-out date for the hotel stay.</value>
    [DataMember(Name="checkoutDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "checkoutDate")]
    public DateTime? CheckoutDate { get; set; }

    /// <summary>
    /// Name of the hotel.
    /// </summary>
    /// <value>Name of the hotel.</value>
    [DataMember(Name="hotelName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelName")]
    public string HotelName { get; set; }

    /// <summary>
    /// Description of the hotel.
    /// </summary>
    /// <value>Description of the hotel.</value>
    [DataMember(Name="hotelDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelDescription")]
    public string HotelDescription { get; set; }

    /// <summary>
    /// Physical address of the hotel.
    /// </summary>
    /// <value>Physical address of the hotel.</value>
    [DataMember(Name="hotelAddress", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelAddress")]
    public string HotelAddress { get; set; }

    /// <summary>
    /// Geographic latitude of the hotel.
    /// </summary>
    /// <value>Geographic latitude of the hotel.</value>
    [DataMember(Name="hotelLatitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelLatitude")]
    public float? HotelLatitude { get; set; }

    /// <summary>
    /// Geographic longitude of the hotel.
    /// </summary>
    /// <value>Geographic longitude of the hotel.</value>
    [DataMember(Name="hotelLongitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelLongitude")]
    public float? HotelLongitude { get; set; }

    /// <summary>
    /// Distance of the hotel from a central point of interest, if applicable.
    /// </summary>
    /// <value>Distance of the hotel from a central point of interest, if applicable.</value>
    [DataMember(Name="hotelDistance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelDistance")]
    public double? HotelDistance { get; set; }

    /// <summary>
    /// Unit of measurement for the distance (e.g., km, miles).
    /// </summary>
    /// <value>Unit of measurement for the distance (e.g., km, miles).</value>
    [DataMember(Name="hotelDistanceMetric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelDistanceMetric")]
    public string HotelDistanceMetric { get; set; }

    /// <summary>
    /// Array of images associated with the hotel.
    /// </summary>
    /// <value>Array of images associated with the hotel.</value>
    [DataMember(Name="hotelImages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelImages")]
    public List<string> HotelImages { get; set; }

    /// <summary>
    /// Overall rating of the hotel.
    /// </summary>
    /// <value>Overall rating of the hotel.</value>
    [DataMember(Name="hotelRating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelRating")]
    public float? HotelRating { get; set; }

    /// <summary>
    /// Collection of reviews for the hotel.
    /// </summary>
    /// <value>Collection of reviews for the hotel.</value>
    [DataMember(Name="hotelReviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelReviews")]
    public Dictionary<string, Object> HotelReviews { get; set; }

    /// <summary>
    /// Star rating of the hotel.
    /// </summary>
    /// <value>Star rating of the hotel.</value>
    [DataMember(Name="hotelStars", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelStars")]
    public int? HotelStars { get; set; }

    /// <summary>
    /// Standard check-in time at the hotel.
    /// </summary>
    /// <value>Standard check-in time at the hotel.</value>
    [DataMember(Name="hotelCheckinTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelCheckinTime")]
    public string HotelCheckinTime { get; set; }

    /// <summary>
    /// Standard check-out time at the hotel.
    /// </summary>
    /// <value>Standard check-out time at the hotel.</value>
    [DataMember(Name="hotelCheckoutTime", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelCheckoutTime")]
    public string HotelCheckoutTime { get; set; }

    /// <summary>
    /// List of facilities available at the hotel.
    /// </summary>
    /// <value>List of facilities available at the hotel.</value>
    [DataMember(Name="hotelFacilities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelFacilities")]
    public List<string> HotelFacilities { get; set; }

    /// <summary>
    /// List of amenities offered by the hotel.
    /// </summary>
    /// <value>List of amenities offered by the hotel.</value>
    [DataMember(Name="hotelAmenities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelAmenities")]
    public List<string> HotelAmenities { get; set; }

    /// <summary>
    /// General policies of the hotel.
    /// </summary>
    /// <value>General policies of the hotel.</value>
    [DataMember(Name="hotelPolicies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hotelPolicies")]
    public List<string> HotelPolicies { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HotelOfferResponseItemSchema {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  SupplierOfferId: ").Append(SupplierOfferId).Append("\n");
      sb.Append("  OfferIndex: ").Append(OfferIndex).Append("\n");
      sb.Append("  OfferTax: ").Append(OfferTax).Append("\n");
      sb.Append("  OfferPrice: ").Append(OfferPrice).Append("\n");
      sb.Append("  OfferCurrency: ").Append(OfferCurrency).Append("\n");
      sb.Append("  OfferCancellationPolicies: ").Append(OfferCancellationPolicies).Append("\n");
      sb.Append("  CheckinDate: ").Append(CheckinDate).Append("\n");
      sb.Append("  CheckoutDate: ").Append(CheckoutDate).Append("\n");
      sb.Append("  HotelName: ").Append(HotelName).Append("\n");
      sb.Append("  HotelDescription: ").Append(HotelDescription).Append("\n");
      sb.Append("  HotelAddress: ").Append(HotelAddress).Append("\n");
      sb.Append("  HotelLatitude: ").Append(HotelLatitude).Append("\n");
      sb.Append("  HotelLongitude: ").Append(HotelLongitude).Append("\n");
      sb.Append("  HotelDistance: ").Append(HotelDistance).Append("\n");
      sb.Append("  HotelDistanceMetric: ").Append(HotelDistanceMetric).Append("\n");
      sb.Append("  HotelImages: ").Append(HotelImages).Append("\n");
      sb.Append("  HotelRating: ").Append(HotelRating).Append("\n");
      sb.Append("  HotelReviews: ").Append(HotelReviews).Append("\n");
      sb.Append("  HotelStars: ").Append(HotelStars).Append("\n");
      sb.Append("  HotelCheckinTime: ").Append(HotelCheckinTime).Append("\n");
      sb.Append("  HotelCheckoutTime: ").Append(HotelCheckoutTime).Append("\n");
      sb.Append("  HotelFacilities: ").Append(HotelFacilities).Append("\n");
      sb.Append("  HotelAmenities: ").Append(HotelAmenities).Append("\n");
      sb.Append("  HotelPolicies: ").Append(HotelPolicies).Append("\n");
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
