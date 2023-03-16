# akeyless.Model.UpdateRotatedSecret
updateRotatedSecret is a command that updates rotated secret. [Deprecated: Use gateway-update-item command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**ApiId** | **string** | API ID to rotate | [optional] 
**ApiKey** | **string** | API key to rotate | [optional] 
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation [true/false] | [optional] 
**AwsRegion** | **string** | Region (used in aws) | [optional] [default to "us-east-2"]
**CustomPayload** | **string** | Secret payload to be sent with rotation request (relevant only for rotator-type&#x3D;custom) | [optional] 
**Description** | **string** | Description of the object | [optional] [default to "default_metadata"]
**GcpKey** | **string** | Base64-encoded service account private key text | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | Secret name | 
**NewMetadata** | **string** | Deprecated - use description | [optional] [default to "default_metadata"]
**NewName** | **string** | New item name | [optional] 
**NewVersion** | **bool** | Deprecated | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**RotateAfterDisconnect** | **string** | Rotate the value of the secret after SRA session ends [true/false] | [optional] [default to "false"]
**RotatedPassword** | **string** | rotated-username password | [optional] 
**RotatedUsername** | **string** | username to be rotated, if selected use-self-creds at rotator-creds-type, this username will try to rotate it&#39;s own password, if use-target-creds is selected, target credentials will be use to rotate the rotated-password | [optional] 
**RotationHour** | **int** | The Hour of the rotation in UTC | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (7-365) | [optional] 
**RotatorCredsType** | **string** | The credentials to connect with use-self-creds/use-target-creds | [optional] [default to "use-self-creds"]
**RotatorCustomCmd** | **string** | \&quot;Custom rotation command (relevant only for ssh target) | [optional] 
**SecureAccessAllowExternalUser** | **bool** | Allow providing external user for a domain users (relevant only for rdp) | [optional] [default to false]
**SecureAccessAwsAccountId** | **string** | The AWS account id (relevant only for aws) | [optional] 
**SecureAccessAwsNativeCli** | **bool** | The AWS native cli | [optional] 
**SecureAccessBastionIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Bastion | [optional] 
**SecureAccessDbName** | **string** | The DB name (relevant only for DB Dynamic-Secret) | [optional] 
**SecureAccessDbSchema** | **string** | The db schema (relevant only for mssql or postgresql) | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers) | [optional] 
**SecureAccessRdpDomain** | **string** | Required when the Dynamic Secret is used for a domain user (relevant only for RDP Dynamic-Secret) | [optional] 
**SecureAccessRdpUser** | **string** | Override the RDP Domain username (relevant only for rdp) | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless Web Access Bastion (relevant only for aws or azure) | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless Web Access Bastion (relevant only for aws or azure) | [optional] [default to false]
**SshPassword** | **string** | Deprecated: use RotatedPassword | [optional] 
**SshUsername** | **string** | Deprecated: use RotatedUser | [optional] 
**StorageAccountKeyName** | **string** | The name of the storage account key to rotate [key1/key2/kerb1/kerb2] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

