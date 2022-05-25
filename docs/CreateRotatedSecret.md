# akeyless.Model.CreateRotatedSecret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiId** | **string** |  | [optional] 
**ApiKey** | **string** |  | [optional] 
**ApplicationId** | **string** | ApplicationId (used in azure) | [optional] 
**AuthenticationCredentials** | **string** |  | [optional] 
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation | [optional] 
**AwsRegion** | **string** | Region (used in aws) | [optional] [default to "us-east-2"]
**CustomPayload** | **string** |  | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Metadata** | **string** | Metadata about the secret | [optional] 
**Name** | **string** | Secret name | 
**RotatedPassword** | **string** |  | [optional] 
**RotatedUsername** | **string** |  | [optional] 
**RotationHour** | **int** |  | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (1-365) | [optional] 
**RotatorCredsType** | **string** |  | [optional] 
**RotatorCustomCmd** | **string** |  | [optional] 
**RotatorType** | **string** | Rotator Type | 
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
**StorageAccountKeyName** | **string** | The name of the storage account key to rotate [key1/key2/kerb1/kerb2] (relevat to azure-storage-account) | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserAttribute** | **string** | User Attribute | [optional] 
**UserDn** | **string** | User DN | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

