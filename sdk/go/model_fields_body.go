/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type FieldsBody struct {
	// The unique identifier of the tenant
	TenantId string `json:"tenant_id,omitempty"`
	// The unique identifier of the schema
	SchemaId string `json:"schema_id"`
	// Name of the field
	Name string `json:"name"`
	// Type of the field (e.g., string, number)
	Type_ string `json:"type"`
	// Slug for the field
	Slug string `json:"slug"`
	// Description of the field
	Description string `json:"description,omitempty"`
	// Status of the field, indicating if it is active
	Status string `json:"status,omitempty"`
	// Flag indicating if the field can be used in search operations
	IsSearchable bool `json:"is_searchable,omitempty"`
	// Flag indicating if the field can be sorted
	IsSortable bool `json:"is_sortable,omitempty"`
	// Indicates if the field is a system field
	System bool `json:"system,omitempty"`
}
