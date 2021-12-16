# akeyless.Model.UpdateRotatedSecret
updateRotatedSecret is a command that updates rotated secret. [Deprecated: Use gateway-update-item command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**ApiId** | **string** |  | [optional] 
**ApiKey** | **string** |  | [optional] 
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation | [optional] 
**CustomPayload** | **string** |  | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | Secret name | 
**NewMetadata** | **string** | New item metadata | [optional] [default to "default_metadata"]
**NewName** | **string** | New item name | [optional] 
**NewVersion** | **bool** | Whether to create a new version of not | [optional] [default to false]
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**RotatedPassword** | **string** |  | [optional] 
**RotatedUsername** | **string** |  | [optional] 
**RotationHour** | **int** |  | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (7-365) | [optional] 
**RotatorCredsType** | **string** |  | [optional] 
**RotatorCustomCmd** | **string** |  | [optional] 
**SshPassword** | **string** | Deprecated: use RotatedPassword | [optional] 
**SshUsername** | **string** | Deprecated: use RotatedUser | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

