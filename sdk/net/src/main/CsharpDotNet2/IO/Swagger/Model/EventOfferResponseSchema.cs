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
  public class EventOfferResponseSchema {
    /// <summary>
    /// Identifier for the company offering the rental.
    /// </summary>
    /// <value>Identifier for the company offering the rental.</value>
    [DataMember(Name="company_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company_id")]
    public Guid? CompanyId { get; set; }

    /// <summary>
    /// Identifier for the tenant.
    /// </summary>
    /// <value>Identifier for the tenant.</value>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public Guid? TenantId { get; set; }

    /// <summary>
    /// Identifier for the category of the offer.
    /// </summary>
    /// <value>Identifier for the category of the offer.</value>
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
    /// Array of EventOfferResponseItemSchema detailing individual car offers.
    /// </summary>
    /// <value>Array of EventOfferResponseItemSchema detailing individual car offers.</value>
    [DataMember(Name="offers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offers")]
    public List<EventOfferResponseItemSchema> Offers { get; set; }

    /// <summary>
    /// Current page in pagination.
    /// </summary>
    /// <value>Current page in pagination.</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public decimal? Page { get; set; }

    /// <summary>
    /// Page size in pagination.
    /// </summary>
    /// <value>Page size in pagination.</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public decimal? Limit { get; set; }

    /// <summary>
    /// Total number of records available.
    /// </summary>
    /// <value>Total number of records available.</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public decimal? Total { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class EventOfferResponseSchema {\n");
      sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  SupplierId: ").Append(SupplierId).Append("\n");
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
