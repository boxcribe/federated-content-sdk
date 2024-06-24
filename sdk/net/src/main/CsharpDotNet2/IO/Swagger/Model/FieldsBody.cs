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
  public class FieldsBody {
    /// <summary>
    /// The unique identifier of the tenant
    /// </summary>
    /// <value>The unique identifier of the tenant</value>
    [DataMember(Name="tenant_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tenant_id")]
    public string TenantId { get; set; }

    /// <summary>
    /// The unique identifier of the schema
    /// </summary>
    /// <value>The unique identifier of the schema</value>
    [DataMember(Name="schema_id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schema_id")]
    public string SchemaId { get; set; }

    /// <summary>
    /// Name of the field
    /// </summary>
    /// <value>Name of the field</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Type of the field (e.g., string, number)
    /// </summary>
    /// <value>Type of the field (e.g., string, number)</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Slug for the field
    /// </summary>
    /// <value>Slug for the field</value>
    [DataMember(Name="slug", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "slug")]
    public string Slug { get; set; }

    /// <summary>
    /// Description of the field
    /// </summary>
    /// <value>Description of the field</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Status of the field, indicating if it is active
    /// </summary>
    /// <value>Status of the field, indicating if it is active</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public string Status { get; set; }

    /// <summary>
    /// Flag indicating if the field can be used in search operations
    /// </summary>
    /// <value>Flag indicating if the field can be used in search operations</value>
    [DataMember(Name="is_searchable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_searchable")]
    public bool? IsSearchable { get; set; }

    /// <summary>
    /// Flag indicating if the field can be sorted
    /// </summary>
    /// <value>Flag indicating if the field can be sorted</value>
    [DataMember(Name="is_sortable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "is_sortable")]
    public bool? IsSortable { get; set; }

    /// <summary>
    /// Indicates if the field is a system field
    /// </summary>
    /// <value>Indicates if the field is a system field</value>
    [DataMember(Name="system", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "system")]
    public bool? System { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FieldsBody {\n");
      sb.Append("  TenantId: ").Append(TenantId).Append("\n");
      sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Slug: ").Append(Slug).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  IsSearchable: ").Append(IsSearchable).Append("\n");
      sb.Append("  IsSortable: ").Append(IsSortable).Append("\n");
      sb.Append("  System: ").Append(System).Append("\n");
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
