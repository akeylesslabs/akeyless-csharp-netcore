# akeyless.Model.GatewayUpdateItem
gatewayUpdateItem is a command that updates classic key
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**ApiId** | **string** |  | [optional] 
**ApiKey** | **string** |  | [optional] 
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation | [optional] 
**CustomPayload** | **string** |  | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | Item name | 
**NewMetadata** | **string** | New item metadata | [optional] [default to "default_metadata"]
**NewName** | **string** | New item name | [optional] 
**NewVersion** | **bool** | Whether to create a new version of not | [optional] [default to false]
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**RotatedPassword** | **string** |  | [optional] 
**RotatedUsername** | **string** |  | [optional] 
**RotationHour** | **int** | The Rotation Hour | [optional] [default to 0]
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (1-365) | [optional] 
**RotatorCredsType** | **string** | The rotation credentials type | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **string** | Item type | 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
