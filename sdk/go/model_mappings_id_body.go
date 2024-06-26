/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type MappingsIdBody struct {
	TenantId string `json:"tenant_id"`
	SchemaId string `json:"schema_id"`
	FieldId string `json:"field_id"`
	IntegrationId string `json:"integration_id"`
	Status string `json:"status,omitempty"`
	Mapping *MappingsMapping `json:"mapping"`
}
