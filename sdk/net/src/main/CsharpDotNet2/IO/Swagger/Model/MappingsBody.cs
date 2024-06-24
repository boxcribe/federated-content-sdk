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
  public class MappingsBody {
    /// <summary>
    /// Gets or Sets TenantId
    /// </summary>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public Guid? TenantId { get; set; }

    /// <summary>
    /// Gets or Sets SchemaId
    /// </summary>
    [DataMember(Name="schema_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schema_id")]
    public Guid? SchemaId { get; set; }

    /// <summary>
    /// Gets or Sets FieldId
    /// </summary>
    [DataMember(Name="field_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "field_id")]
    public Guid? FieldId { get; set; }

    /// <summary>
    /// Gets or Sets IntegrationId
    /// </summary>
    [DataMember(Name="integration_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "integration_id")]
    public Guid? IntegrationId { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets Mapping
    /// </summary>
    [DataMember(Name="mapping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mapping")]
    public MappingsMapping Mapping { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MappingsBody {\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
      sb.Append("  FieldId: ").Append(FieldId).Append("\n");
      sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
