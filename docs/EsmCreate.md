# akeyless.Model.EsmCreate
esmCreate is a command that creates a new secret in an External Secrets Manager

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BinaryValue** | **bool** | Use this option if the external secret value is a base64 encoded binary | [optional] 
**Description** | **string** | Description of the external secret | [optional] 
**EsmName** | **string** | Name of the External Secrets Manager item | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**SecretName** | **string** | Name for the new external secret | 
**Tags** | **Dictionary&lt;string, string&gt;** | Tags for the external secret | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Value** | **string** | Value of the external secret item, either text or base64 encoded binary | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

