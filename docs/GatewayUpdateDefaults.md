# akeyless.Model.GatewayUpdateDefaults
gatewayUpdateDefaults is a command that updates defaults settings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertAccessId** | **string** | Default Certificate access id for UI login | [optional] [default to "use-existing"]
**EventOnStatusChange** | **string** | Trigger an event when Gateway status is changed [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of the gateway default encryption key | [optional] [default to "Default"]
**OidcAccessId** | **string** | Default OIDC access id for UI login | [optional] [default to "use-existing"]
**SamlAccessId** | **string** | Default SAML access id for UI login | [optional] [default to "use-existing"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

