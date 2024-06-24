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
  public class CarOfferResponseItemSchema {
    /// <summary>
    /// Unique identifier for the car offer.
    /// </summary>
    /// <value>Unique identifier for the car offer.</value>
    [DataMember(Name="offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_id")]
    public Guid? OfferId { get; set; }

    /// <summary>
    /// Unique identifier for the supplier’s offer.
    /// </summary>
    /// <value>Unique identifier for the supplier’s offer.</value>
    [DataMember(Name="supplier_offer_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_offer_id")]
    public Guid? SupplierOfferId { get; set; }

    /// <summary>
    /// Index of the offer for sorting purposes.
    /// </summary>
    /// <value>Index of the offer for sorting purposes.</value>
    [DataMember(Name="offer_index", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_index")]
    public int? OfferIndex { get; set; }

    /// <summary>
    /// Tax applied to the offer.
    /// </summary>
    /// <value>Tax applied to the offer.</value>
    [DataMember(Name="offer_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_tax")]
    public decimal? OfferTax { get; set; }

    /// <summary>
    /// Price of the offer.
    /// </summary>
    /// <value>Price of the offer.</value>
    [DataMember(Name="offer_price", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_price")]
    public decimal? OfferPrice { get; set; }

    /// <summary>
    /// Currency of the offer price.
    /// </summary>
    /// <value>Currency of the offer price.</value>
    [DataMember(Name="offer_currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_currency")]
    public string OfferCurrency { get; set; }

    /// <summary>
    /// Cancellation policies applicable to the offer.
    /// </summary>
    /// <value>Cancellation policies applicable to the offer.</value>
    [DataMember(Name="offer_cancelation_policies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_cancelation_policies")]
    public Object OfferCancelationPolicies { get; set; }

    /// <summary>
    /// Scheduled date for car pickup.
    /// </summary>
    /// <value>Scheduled date for car pickup.</value>
    [DataMember(Name="pickup_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_date")]
    public DateTime? PickupDate { get; set; }

    /// <summary>
    /// Scheduled time for car pickup.
    /// </summary>
    /// <value>Scheduled time for car pickup.</value>
    [DataMember(Name="pickup_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pickup_time")]
    public string PickupTime { get; set; }

    /// <summary>
    /// Scheduled date for car dropoff.
    /// </summary>
    /// <value>Scheduled date for car dropoff.</value>
    [DataMember(Name="dropoff_date", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dropoff_date")]
    public DateTime? DropoffDate { get; set; }

    /// <summary>
    /// Scheduled time for car dropoff.
    /// </summary>
    /// <value>Scheduled time for car dropoff.</value>
    [DataMember(Name="dropoff_time", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dropoff_time")]
    public string DropoffTime { get; set; }

    /// <summary>
    /// Name of the car model.
    /// </summary>
    /// <value>Name of the car model.</value>
    [DataMember(Name="car_name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_name")]
    public string CarName { get; set; }

    /// <summary>
    /// Description of the car.
    /// </summary>
    /// <value>Description of the car.</value>
    [DataMember(Name="car_description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_description")]
    public string CarDescription { get; set; }

    /// <summary>
    /// Address where the car can be picked up.
    /// </summary>
    /// <value>Address where the car can be picked up.</value>
    [DataMember(Name="car_address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_address")]
    public string CarAddress { get; set; }

    /// <summary>
    /// Latitude of the car pickup location.
    /// </summary>
    /// <value>Latitude of the car pickup location.</value>
    [DataMember(Name="car_latitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_latitude")]
    public float? CarLatitude { get; set; }

    /// <summary>
    /// Longitude of the car pickup location.
    /// </summary>
    /// <value>Longitude of the car pickup location.</value>
    [DataMember(Name="car_longitude", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_longitude")]
    public float? CarLongitude { get; set; }

    /// <summary>
    /// Distance the car can be driven.
    /// </summary>
    /// <value>Distance the car can be driven.</value>
    [DataMember(Name="car_distance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_distance")]
    public int? CarDistance { get; set; }

    /// <summary>
    /// Metric system used for car distance (miles/km).
    /// </summary>
    /// <value>Metric system used for car distance (miles/km).</value>
    [DataMember(Name="car_distance_metric", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_distance_metric")]
    public string CarDistanceMetric { get; set; }

    /// <summary>
    /// Array of images of the car.
    /// </summary>
    /// <value>Array of images of the car.</value>
    [DataMember(Name="car_images", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_images")]
    public List<string> CarImages { get; set; }

    /// <summary>
    /// Rating of the car based on user reviews.
    /// </summary>
    /// <value>Rating of the car based on user reviews.</value>
    [DataMember(Name="car_rating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_rating")]
    public decimal? CarRating { get; set; }

    /// <summary>
    /// Number of reviews for the car.
    /// </summary>
    /// <value>Number of reviews for the car.</value>
    [DataMember(Name="car_reviews", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_reviews")]
    public int? CarReviews { get; set; }

    /// <summary>
    /// Type of the car (e.g., sedan, SUV).
    /// </summary>
    /// <value>Type of the car (e.g., sedan, SUV).</value>
    [DataMember(Name="car_type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_type")]
    public string CarType { get; set; }

    /// <summary>
    /// Class of the car (e.g., economy, luxury).
    /// </summary>
    /// <value>Class of the car (e.g., economy, luxury).</value>
    [DataMember(Name="car_class", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_class")]
    public string CarClass { get; set; }

    /// <summary>
    /// Company owning the car or rental service.
    /// </summary>
    /// <value>Company owning the car or rental service.</value>
    [DataMember(Name="car_company", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_company")]
    public string CarCompany { get; set; }

    /// <summary>
    /// Logo of the company owning the car.
    /// </summary>
    /// <value>Logo of the company owning the car.</value>
    [DataMember(Name="car_company_logo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_company_logo")]
    public string CarCompanyLogo { get; set; }

    /// <summary>
    /// Number of passengers the car can hold.
    /// </summary>
    /// <value>Number of passengers the car can hold.</value>
    [DataMember(Name="car_passengers_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_passengers_number")]
    public int? CarPassengersNumber { get; set; }

    /// <summary>
    /// Number of bags the car can hold.
    /// </summary>
    /// <value>Number of bags the car can hold.</value>
    [DataMember(Name="car_bags_number", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "car_bags_number")]
    public int? CarBagsNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CarOfferResponseItemSchema {\n");
      sb.Append("  OfferId: ").Append(OfferId).Append("\n");
      sb.Append("  SupplierOfferId: ").Append(SupplierOfferId).Append("\n");
      sb.Append("  OfferIndex: ").Append(OfferIndex).Append("\n");
      sb.Append("  OfferTax: ").Append(OfferTax).Append("\n");
      sb.Append("  OfferPrice: ").Append(OfferPrice).Append("\n");
      sb.Append("  OfferCurrency: ").Append(OfferCurrency).Append("\n");
      sb.Append("  OfferCancelationPolicies: ").Append(OfferCancelationPolicies).Append("\n");
      sb.Append("  PickupDate: ").Append(PickupDate).Append("\n");
      sb.Append("  PickupTime: ").Append(PickupTime).Append("\n");
      sb.Append("  DropoffDate: ").Append(DropoffDate).Append("\n");
      sb.Append("  DropoffTime: ").Append(DropoffTime).Append("\n");
      sb.Append("  CarName: ").Append(CarName).Append("\n");
      sb.Append("  CarDescription: ").Append(CarDescription).Append("\n");
      sb.Append("  CarAddress: ").Append(CarAddress).Append("\n");
      sb.Append("  CarLatitude: ").Append(CarLatitude).Append("\n");
      sb.Append("  CarLongitude: ").Append(CarLongitude).Append("\n");
      sb.Append("  CarDistance: ").Append(CarDistance).Append("\n");
      sb.Append("  CarDistanceMetric: ").Append(CarDistanceMetric).Append("\n");
      sb.Append("  CarImages: ").Append(CarImages).Append("\n");
      sb.Append("  CarRating: ").Append(CarRating).Append("\n");
      sb.Append("  CarReviews: ").Append(CarReviews).Append("\n");
      sb.Append("  CarType: ").Append(CarType).Append("\n");
      sb.Append("  CarClass: ").Append(CarClass).Append("\n");
      sb.Append("  CarCompany: ").Append(CarCompany).Append("\n");
      sb.Append("  CarCompanyLogo: ").Append(CarCompanyLogo).Append("\n");
      sb.Append("  CarPassengersNumber: ").Append(CarPassengersNumber).Append("\n");
      sb.Append("  CarBagsNumber: ").Append(CarBagsNumber).Append("\n");
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
