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
  public class HotelOfferResponseSchema {
    /// <summary>
    /// Identifier for the company making the offer.
    /// </summary>
    /// <value>Identifier for the company making the offer.</value>
    [DataMember(Name="company_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company_id")]
    public Guid? CompanyId { get; set; }

    /// <summary>
    /// Identifier for the tenant involved in the offer.
    /// </summary>
    /// <value>Identifier for the tenant involved in the offer.</value>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public Guid? TenantId { get; set; }

    /// <summary>
    /// Category identifier for the offer.
    /// </summary>
    /// <value>Category identifier for the offer.</value>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public Guid? CategoryId { get; set; }

    /// <summary>
    /// Identifier for the supplier of the offer.
    /// </summary>
    /// <value>Identifier for the supplier of the offer.</value>
    [DataMember(Name="supplier_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_id")]
    public Guid? SupplierId { get; set; }

    /// <summary>
    /// Tax applied to the offer price.
    /// </summary>
    /// <value>Tax applied to the offer price.</value>
    [DataMember(Name="offer_tax", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_tax")]
    public double? OfferTax { get; set; }

    /// <summary>
    /// Array of offers detailed in the HotelOfferResponseItemSchema.
    /// </summary>
    /// <value>Array of offers detailed in the HotelOfferResponseItemSchema.</value>
    [DataMember(Name="offers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offers")]
    public List<HotelOfferResponseItemSchema> Offers { get; set; }

    /// <summary>
    /// Current page in the pagination of offers.
    /// </summary>
    /// <value>Current page in the pagination of offers.</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public int? Page { get; set; }

    /// <summary>
    /// Number of items per page in the offer list.
    /// </summary>
    /// <value>Number of items per page in the offer list.</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Total number of offers available.
    /// </summary>
    /// <value>Total number of offers available.</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class HotelOfferResponseSchema {\n");
      sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  SupplierId: ").Append(SupplierId).Append("\n");
      sb.Append("  OfferTax: ").Append(OfferTax).Append("\n");
      sb.Append("  Offers: ").Append(Offers).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
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
