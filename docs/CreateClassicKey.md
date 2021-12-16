# akeyless.Model.CreateClassicKey
CreateClassicKey is a command that creates classic key
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** | Classic Key type; options: [AES128GCM, AES256GCM, AES128SIV, AES256SIV, RSA1024, RSA2048, RSA3072, RSA4096, EC256, EC384] | 
**CertFileData** | **string** | Certificate in a PEM format. | [optional] 
**KeyData** | **string** | Base64-encoded classic key value | [optional] 
**Metadata** | **string** | Metadata about the classic key | [optional] 
**Name** | **string** | ClassicKey name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProtectionKeyName** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this classic key | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

