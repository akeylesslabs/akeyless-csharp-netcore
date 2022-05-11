# akeyless.Model.CreateClassicKey
CreateClassicKey is a command that creates classic key

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** | Classic Key type; options: [AES128GCM, AES256GCM, AES128SIV, AES256SIV, RSA1024, RSA2048, RSA3072, RSA4096, EC256, EC384] | 
**CertFileData** | **string** | Certificate in a PEM format. | [optional] 
**KeyData** | **string** | Base64-encoded classic key value | [optional] 
**KeyOperations** | **List&lt;string&gt;** | A list of allowed operations for the key (required for azure targets) | [optional] 
**KeyringName** | **string** | Keyring name of the GCP KMS (required for gcp targets) | [optional] 
**KmsAlgorithm** | **string** | Algorithm of the key in GCP KMS (required for gcp targets) | [optional] 
**LocationId** | **string** | Location id of the GCP KMS (required for gcp targets) | [optional] 
**Metadata** | **string** | Metadata about the classic key | [optional] 
**Name** | **string** | ClassicKey name | 
**ProjectId** | **string** | Project id of the GCP KMS (required for gcp targets) | [optional] 
**ProtectionKeyName** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Purpose** | **string** | Purpose of the key in GCP KMS (required for gcp targets) | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this classic key | [optional] 
**TargetName** | **string** | Target name | [optional] 
**TenantSecretType** | **string** | The tenant secret type [Data/SearchIndex/Analytics] (required for salesforce targets) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**VaultName** | **string** | Name of the vault used (required for azure targets) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

