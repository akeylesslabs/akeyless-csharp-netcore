# akeyless.Model.UscCreate
uscCreate is a command that creates a new secret in a Universal Secrets Connector

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BinaryValue** | **bool** | Use this option if the universal secrets value is a base64 encoded binary | [optional] 
**Description** | **string** | Description of the universal secrets | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Namespace** | **string** | The namespace (relevant for Hashi vault target) | [optional] 
**ObjectType** | **string** |  | [optional] 
**PfxPassword** | **string** | Optional, the passphrase that protects the private key within the pfx certificate (Relevant only for Azure KV certificates) | [optional] 
**SecretName** | **string** | Name for the new universal secrets | 
**Tags** | **Dictionary&lt;string, string&gt;** | Tags for the universal secrets | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UscName** | **string** | Name of the Universal Secrets Connector item | 
**Value** | **string** | Value of the universal secrets item, either text or base64 encoded binary | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

