# akeyless.Model.ScimSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BearerAccessId** | **string** | Access ID of the API Key auth method the IdP uses as the SCIM bearer. | [optional] 
**DefaultIdentityType** | **string** |  | [optional] 
**Enabled** | **bool** |  | [optional] 
**Endpoint** | **string** |  | [optional] 
**GatewayUrl** | **string** | URL of the gateway that serves the SCIM endpoint to the IdP, for the private endpoint. | [optional] 
**ProvisionedAccessId** | **string** | ProvisionedAccessId and ProvisionedType are set on the bearer itself, not on the auth method it provisions. They point back to the SAML or OIDC auth method the bearer provisions, so the gateway can find that auth method from the bearer. | [optional] 
**ProvisionedType** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

