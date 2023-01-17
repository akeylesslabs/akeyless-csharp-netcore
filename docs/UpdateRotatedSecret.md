# akeyless.Model.UpdateRotatedSecret
updateRotatedSecret is a command that updates rotated secret. [Deprecated: Use gateway-update-item command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**ApiId** | **string** |  | [optional] 
**ApiKey** | **string** |  | [optional] 
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation | [optional] 
**AwsRegion** | **string** | Region (used in aws) | [optional] [default to "us-east-2"]
**CustomPayload** | **string** |  | [optional] 
**Description** | **string** | Description of the object | [optional] [default to "default_metadata"]
**GcpKey** | **string** | Base64-encoded service account private key text | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] 
**KeepPrevVersion** | **string** |  | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | Secret name | 
**NewMetadata** | **string** | Deprecated - use description | [optional] [default to "default_metadata"]
**NewName** | **string** | New item name | [optional] 
**NewVersion** | **bool** | Deprecated | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**RotatedPassword** | **string** |  | [optional] 
**RotatedUsername** | **string** |  | [optional] 
**RotationHour** | **int** |  | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (7-365) | [optional] 
**RotatorCredsType** | **string** |  | [optional] 
**RotatorCustomCmd** | **string** |  | [optional] 
**SecureAccessAllowExternalUser** | **bool** | Secure Access Allow Providing External User (used in ssh) | [optional] [default to false]
**SecureAccessAwsAccountId** | **string** | Secure Access Account Id (used in aws) | [optional] 
**SecureAccessAwsNativeCli** | **bool** | Secure Access Aws Native Cli (used in aws) | [optional] 
**SecureAccessBastionIssuer** | **string** | Secure Access Bastion Issuer | [optional] 
**SecureAccessDbName** | **string** | Secure Access DB Name (used in data bases) | [optional] 
**SecureAccessDbSchema** | **string** | Secure Access Schema (used in mssql, postgresql) | [optional] 
**SecureAccessEnable** | **string** | Secure Access Enabled | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Secure Access Host | [optional] 
**SecureAccessRdpDomain** | **string** | Secure Access Domain (used in ssh) | [optional] 
**SecureAccessRdpUser** | **string** | Secure Access Override User (used in ssh) | [optional] 
**SecureAccessWeb** | **bool** | Secure Access Web | [optional] [default to false]
**SecureAccessWebBrowsing** | **bool** | Secure Access Isolated (used in aws, azure) | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Secure Access Web Proxy (used in aws, azure) | [optional] [default to false]
**SshPassword** | **string** | Deprecated: use RotatedPassword | [optional] 
**SshUsername** | **string** | Deprecated: use RotatedUser | [optional] 
**StorageAccountKeyName** | **string** | The name of the storage account key to rotate [key1/key2/kerb1/kerb2] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

