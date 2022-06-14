# akeyless.Model.AssocTargetItem
assocTargetItem is a command that creates an association between target and item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**KeyOperations** | **List&lt;string&gt;** | A list of allowed operations for the key (required for azure targets) | [optional] 
**KeyringName** | **string** | Keyring name of the GCP KMS (required for gcp targets) | [optional] 
**KmsAlgorithm** | **string** | Algorithm of the key in GCP KMS (required for gcp targets) | [optional] 
**LocationId** | **string** | Location id of the GCP KMS (required for gcp targets) | [optional] 
**Name** | **string** | The item to associate | 
**ProjectId** | **string** | Project id of the GCP KMS (required for gcp targets) | [optional] 
**Purpose** | **string** | Purpose of the key in GCP KMS (required for gcp targets) | [optional] 
**TargetName** | **string** | The target to associate | 
**TenantSecretType** | **string** | The tenant secret type [Data/SearchIndex/Analytics] (required for salesforce targets) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**VaultName** | **string** | Name of the vault used (required for azure targets) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

