/*
 * Federated Content API
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * FieldsBody
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class FieldsBody {
  @SerializedName("tenant_id")
  private String tenantId = null;

  @SerializedName("schema_id")
  private String schemaId = null;

  @SerializedName("name")
  private String name = null;

  @SerializedName("type")
  private String type = null;

  @SerializedName("slug")
  private String slug = null;

  @SerializedName("description")
  private String description = null;

  /**
   * Status of the field, indicating if it is active
   */
  @JsonAdapter(StatusEnum.Adapter.class)
  public enum StatusEnum {
    @SerializedName("Active")
    ACTIVE("Active"),
    @SerializedName("Inactive")
    INACTIVE("Inactive");

    private String value;

    StatusEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static StatusEnum fromValue(String input) {
      for (StatusEnum b : StatusEnum.values()) {
        if (b.value.equals(input)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<StatusEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final StatusEnum enumeration) throws IOException {
        jsonWriter.value(String.valueOf(enumeration.getValue()));
      }

      @Override
      public StatusEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return StatusEnum.fromValue((String)(value));
      }
    }
  }  @SerializedName("status")
  private StatusEnum status = null;

  @SerializedName("is_searchable")
  private Boolean isSearchable = false;

  @SerializedName("is_sortable")
  private Boolean isSortable = false;

  @SerializedName("system")
  private Boolean system = false;

  public FieldsBody tenantId(String tenantId) {
    this.tenantId = tenantId;
    return this;
  }

   /**
   * The unique identifier of the tenant
   * @return tenantId
  **/
  @Schema(description = "The unique identifier of the tenant")
  public String getTenantId() {
    return tenantId;
  }

  public void setTenantId(String tenantId) {
    this.tenantId = tenantId;
  }

  public FieldsBody schemaId(String schemaId) {
    this.schemaId = schemaId;
    return this;
  }

   /**
   * The unique identifier of the schema
   * @return schemaId
  **/
  @Schema(required = true, description = "The unique identifier of the schema")
  public String getSchemaId() {
    return schemaId;
  }

  public void setSchemaId(String schemaId) {
    this.schemaId = schemaId;
  }

  public FieldsBody name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Name of the field
   * @return name
  **/
  @Schema(required = true, description = "Name of the field")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public FieldsBody type(String type) {
    this.type = type;
    return this;
  }

   /**
   * Type of the field (e.g., string, number)
   * @return type
  **/
  @Schema(required = true, description = "Type of the field (e.g., string, number)")
  public String getType() {
    return type;
  }

  public void setType(String type) {
    this.type = type;
  }

  public FieldsBody slug(String slug) {
    this.slug = slug;
    return this;
  }

   /**
   * Slug for the field
   * @return slug
  **/
  @Schema(required = true, description = "Slug for the field")
  public String getSlug() {
    return slug;
  }

  public void setSlug(String slug) {
    this.slug = slug;
  }

  public FieldsBody description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Description of the field
   * @return description
  **/
  @Schema(description = "Description of the field")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public FieldsBody status(StatusEnum status) {
    this.status = status;
    return this;
  }

   /**
   * Status of the field, indicating if it is active
   * @return status
  **/
  @Schema(description = "Status of the field, indicating if it is active")
  public StatusEnum getStatus() {
    return status;
  }

  public void setStatus(StatusEnum status) {
    this.status = status;
  }

  public FieldsBody isSearchable(Boolean isSearchable) {
    this.isSearchable = isSearchable;
    return this;
  }

   /**
   * Flag indicating if the field can be used in search operations
   * @return isSearchable
  **/
  @Schema(description = "Flag indicating if the field can be used in search operations")
  public Boolean isIsSearchable() {
    return isSearchable;
  }

  public void setIsSearchable(Boolean isSearchable) {
    this.isSearchable = isSearchable;
  }

  public FieldsBody isSortable(Boolean isSortable) {
    this.isSortable = isSortable;
    return this;
  }

   /**
   * Flag indicating if the field can be sorted
   * @return isSortable
  **/
  @Schema(description = "Flag indicating if the field can be sorted")
  public Boolean isIsSortable() {
    return isSortable;
  }

  public void setIsSortable(Boolean isSortable) {
    this.isSortable = isSortable;
  }

  public FieldsBody system(Boolean system) {
    this.system = system;
    return this;
  }

   /**
   * Indicates if the field is a system field
   * @return system
  **/
  @Schema(description = "Indicates if the field is a system field")
  public Boolean isSystem() {
    return system;
  }

  public void setSystem(Boolean system) {
    this.system = system;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FieldsBody fieldsBody = (FieldsBody) o;
    return Objects.equals(this.tenantId, fieldsBody.tenantId) &&
        Objects.equals(this.schemaId, fieldsBody.schemaId) &&
        Objects.equals(this.name, fieldsBody.name) &&
        Objects.equals(this.type, fieldsBody.type) &&
        Objects.equals(this.slug, fieldsBody.slug) &&
        Objects.equals(this.description, fieldsBody.description) &&
        Objects.equals(this.status, fieldsBody.status) &&
        Objects.equals(this.isSearchable, fieldsBody.isSearchable) &&
        Objects.equals(this.isSortable, fieldsBody.isSortable) &&
        Objects.equals(this.system, fieldsBody.system);
  }

  @Override
  public int hashCode() {
    return Objects.hash(tenantId, schemaId, name, type, slug, description, status, isSearchable, isSortable, system);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FieldsBody {\n");
    
    sb.append("    tenantId: ").append(toIndentedString(tenantId)).append("\n");
    sb.append("    schemaId: ").append(toIndentedString(schemaId)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
    sb.append("    slug: ").append(toIndentedString(slug)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    status: ").append(toIndentedString(status)).append("\n");
    sb.append("    isSearchable: ").append(toIndentedString(isSearchable)).append("\n");
    sb.append("    isSortable: ").append(toIndentedString(isSortable)).append("\n");
    sb.append("    system: ").append(toIndentedString(system)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
