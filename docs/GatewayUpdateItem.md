# akeyless.Model.GatewayUpdateItem
gatewayUpdateItem is a command that updates classic key

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**ApiId** | **string** | API ID to rotate (relevant only for rotator-type&#x3D;api-key) | [optional] 
**ApiKey** | **string** | API key to rotate (relevant only for rotator-type&#x3D;api-key) | [optional] 
**AppId** | **string** | ApplicationId (used in azure) | [optional] 
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation [true/false] | [optional] 
**CustomPayload** | **string** | Secret payload to be sent with rotation request (relevant only for rotator-type&#x3D;custom) | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] [default to "default_metadata"]
**GcpKey** | **string** | Base64-encoded service account private key text | [optional] 
**GcpServiceAccountEmail** | **string** | The email of the gcp service account to rotate | [optional] 
**GcpServiceAccountKeyId** | **string** | The key id of the gcp service account to rotate | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. (relevant only for - -type&#x3D;rotated-secret). If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | Item name | 
**NewMetadata** | **string** | Deprecated - use description | [optional] [default to "default_metadata"]
**NewName** | **string** | New item name | [optional] 
**NewVersion** | **bool** | Deprecated | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**RotatedPassword** | **string** | rotated-username password (relevant only for rotator-type&#x3D;password) | [optional] 
**RotatedUsername** | **string** | username to be rotated, if selected \\\&quot;use-self-creds\\\&quot; at rotator-creds-type, this username will try to rotate it&#39;s own password, if \\\&quot;use-target-creds\\\&quot; is selected, target credentials will be use to rotate the rotated-password (relevant only for rotator-type&#x3D;password) | [optional] 
**RotationHour** | **int** | The Rotation Hour | [optional] [default to 0]
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (1-365) | [optional] 
**RotatorCredsType** | **string** | The rotation credentials type | [optional] [default to "use-self-creds"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **string** | Item type | 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

