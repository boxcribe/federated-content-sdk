/*
 * Federated Content API
 *
 * Welcome to the Federated Content API following Open API Specification (Version 3.0.0)
 *
 * API version: 1.0.0
 * Generated by: Swagger Codegen (https://github.com/swagger-api/swagger-codegen.git)
 */
package swagger

type Category struct {
	Id string `json:"id,omitempty"`
	Name string `json:"name,omitempty"`
	Slug string `json:"slug,omitempty"`
	Icon string `json:"icon,omitempty"`
	Sort int32 `json:"sort,omitempty"`
}
