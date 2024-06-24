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
  public class TransportOfferResponseSchema {
    /// <summary>
    /// Identifier of the company.
    /// </summary>
    /// <value>Identifier of the company.</value>
    [DataMember(Name="company_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "company_id")]
    public Guid? CompanyId { get; set; }

    /// <summary>
    /// Identifier of the tenant.
    /// </summary>
    /// <value>Identifier of the tenant.</value>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public Guid? TenantId { get; set; }

    /// <summary>
    /// Category identifier.
    /// </summary>
    /// <value>Category identifier.</value>
    [DataMember(Name="category_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "category_id")]
    public Guid? CategoryId { get; set; }

    /// <summary>
    /// Supplier identifier.
    /// </summary>
    /// <value>Supplier identifier.</value>
    [DataMember(Name="supplier_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_id")]
    public Guid? SupplierId { get; set; }

    /// <summary>
    /// Current page of the response.
    /// </summary>
    /// <value>Current page of the response.</value>
    [DataMember(Name="page", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "page")]
    public int? Page { get; set; }

    /// <summary>
    /// Limit of items per page in the response.
    /// </summary>
    /// <value>Limit of items per page in the response.</value>
    [DataMember(Name="limit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "limit")]
    public int? Limit { get; set; }

    /// <summary>
    /// Total number of items available.
    /// </summary>
    /// <value>Total number of items available.</value>
    [DataMember(Name="total", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "total")]
    public int? Total { get; set; }

    /// <summary>
    /// Array of TransportOfferResponseItemSchema detailing individual offers.
    /// </summary>
    /// <value>Array of TransportOfferResponseItemSchema detailing individual offers.</value>
    [DataMember(Name="offers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offers")]
    public List<TransportOfferResponseItemSchema> Offers { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TransportOfferResponseSchema {\n");
      sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
      sb.Append("  SupplierId: ").Append(SupplierId).Append("\n");
      sb.Append("  Page: ").Append(Page).Append("\n");
      sb.Append("  Limit: ").Append(Limit).Append("\n");
      sb.Append("  Total: ").Append(Total).Append("\n");
      sb.Append("  Offers: ").Append(Offers).Append("\n");
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
