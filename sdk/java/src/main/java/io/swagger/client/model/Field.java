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
import java.util.UUID;
/**
 * Field
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2024-06-24T14:14:21.689997473Z[GMT]")

public class Field {
  @SerializedName("id")
  private UUID id = null;

  @SerializedName("tenant_id")
  private UUID tenantId = null;

  @SerializedName("schema_id")
  private UUID schemaId = null;

  @SerializedName("name")
  private String name = null;

  @SerializedName("slug")
  private String slug = null;

  @SerializedName("type")
  private String type = null;

  @SerializedName("description")
  private String description = null;

  /**
   * Gets or Sets status
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
  private StatusEnum status = StatusEnum.ACTIVE;

  @SerializedName("is_searchable")
  private Boolean isSearchable = false;

  @SerializedName("is_sortable")
  private Boolean isSortable = false;

  @SerializedName("system")
  private Boolean system = false;

  public Field id(UUID id) {
    this.id = id;
    return this;
  }

   /**
   * Get id
   * @return id
  **/
  @Schema(description = "")
  public UUID getId() {
    return id;
  }

  public void setId(UUID id) {
    this.id = id;
  }

  public Field tenantId(UUID tenantId) {
    this.tenantId = tenantId;
    return this;
  }

   /**
   * Get tenantId
   * @return tenantId
  **/
  @Schema(description = "")
  public UUID getTenantId() {
    return tenantId;
  }

  public void setTenantId(UUID tenantId) {
    this.tenantId = tenantId;
  }

  public Field schemaId(UUID schemaId) {
    this.schemaId = schemaId;
    return this;
  }

   /**
   * Get schemaId
   * @return schemaId
  **/
  @Schema(description = "")
  public UUID getSchemaId() {
    return schemaId;
  }

  public void setSchemaId(UUID schemaId) {
    this.schemaId = schemaId;
  }

  public Field name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @Schema(description = "")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public Field slug(String slug) {
    this.slug = slug;
    return this;
  }

   /**
   * Get slug
   * @return slug
  **/
  @Schema(description = "")
  public String getSlug() {
    return slug;
  }

  public void setSlug(String slug) {
    this.slug = slug;
  }

  public Field type(String type) {
    this.type = type;
    return this;
  }

   /**
   * Get type
   * @return type
  **/
  @Schema(description = "")
  public String getType() {
    return type;
  }

  public void setType(String type) {
    this.type = type;
  }

  public Field description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Get description
   * @return description
  **/
  @Schema(description = "")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public Field status(StatusEnum status) {
    this.status = status;
    return this;
  }

   /**
   * Get status
   * @return status
  **/
  @Schema(description = "")
  public StatusEnum getStatus() {
    return status;
  }

  public void setStatus(StatusEnum status) {
    this.status = status;
  }

  public Field isSearchable(Boolean isSearchable) {
    this.isSearchable = isSearchable;
    return this;
  }

   /**
   * Get isSearchable
   * @return isSearchable
  **/
  @Schema(description = "")
  public Boolean isIsSearchable() {
    return isSearchable;
  }

  public void setIsSearchable(Boolean isSearchable) {
    this.isSearchable = isSearchable;
  }

  public Field isSortable(Boolean isSortable) {
    this.isSortable = isSortable;
    return this;
  }

   /**
   * Get isSortable
   * @return isSortable
  **/
  @Schema(description = "")
  public Boolean isIsSortable() {
    return isSortable;
  }

  public void setIsSortable(Boolean isSortable) {
    this.isSortable = isSortable;
  }

  public Field system(Boolean system) {
    this.system = system;
    return this;
  }

   /**
   * Get system
   * @return system
  **/
  @Schema(description = "")
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
    Field field = (Field) o;
    return Objects.equals(this.id, field.id) &&
        Objects.equals(this.tenantId, field.tenantId) &&
        Objects.equals(this.schemaId, field.schemaId) &&
        Objects.equals(this.name, field.name) &&
        Objects.equals(this.slug, field.slug) &&
        Objects.equals(this.type, field.type) &&
        Objects.equals(this.description, field.description) &&
        Objects.equals(this.status, field.status) &&
        Objects.equals(this.isSearchable, field.isSearchable) &&
        Objects.equals(this.isSortable, field.isSortable) &&
        Objects.equals(this.system, field.system);
  }

  @Override
  public int hashCode() {
    return Objects.hash(id, tenantId, schemaId, name, slug, type, description, status, isSearchable, isSortable, system);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Field {\n");
    
    sb.append("    id: ").append(toIndentedString(id)).append("\n");
    sb.append("    tenantId: ").append(toIndentedString(tenantId)).append("\n");
    sb.append("    schemaId: ").append(toIndentedString(schemaId)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    slug: ").append(toIndentedString(slug)).append("\n");
    sb.append("    type: ").append(toIndentedString(type)).append("\n");
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