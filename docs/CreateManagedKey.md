# akeyless.Model.CreateManagedKey
CreateManagedKey is a command that creates managed key
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** | Managed Key type; options: [AES256GCM, RSA2048] | 
**ManagedKeyValue** | **string** | Base64-encoded managed key value | [optional] 
**Metadata** | **string** | Metadata about the managed key | [optional] 
**Name** | **string** | ManagedKey name | 
**ProtectionKey** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this managed key | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

