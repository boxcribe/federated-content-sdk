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
  public class OfferResult {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Guid? Id { get; set; }

    /// <summary>
    /// Gets or Sets OfferRequestId
    /// </summary>
    [DataMember(Name="offer_request_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "offer_request_id")]
    public Guid? OfferRequestId { get; set; }

    /// <summary>
    /// Gets or Sets NormalizedResponse
    /// </summary>
    [DataMember(Name="normalized_response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "normalized_response")]
    public OfferResultNormalizedResponse NormalizedResponse { get; set; }

    /// <summary>
    /// Offer Request Raw Supplier Boxcribe API Response
    /// </summary>
    /// <value>Offer Request Raw Supplier Boxcribe API Response</value>
    [DataMember(Name="supplier_response", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supplier_response")]
    public Object SupplierResponse { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class OfferResult {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  OfferRequestId: ").Append(OfferRequestId).Append("\n");
      sb.Append("  NormalizedResponse: ").Append(NormalizedResponse).Append("\n");
      sb.Append("  SupplierResponse: ").Append(SupplierResponse).Append("\n");
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
