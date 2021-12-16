# akeyless.Model.CreateRotatedSecret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiId** | **string** |  | [optional] 
**ApiKey** | **string** |  | [optional] 
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation | [optional] 
**CustomPayload** | **string** |  | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Metadata** | **string** | Metadata about the secret | [optional] 
**Name** | **string** | Secret name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**RotatedPassword** | **string** |  | [optional] 
**RotatedUsername** | **string** |  | [optional] 
**RotationHour** | **int** |  | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (1-365) | [optional] 
**RotatorCredsType** | **string** |  | [optional] 
**RotatorCustomCmd** | **string** |  | [optional] 
**RotatorType** | **string** | Rotator Type | 
**SshPassword** | **string** | Deprecated: use RotatedPassword | [optional] 
**SshUsername** | **string** | Deprecated: use RotatedUser | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserAttribute** | **string** | User Attribute | [optional] 
**UserDn** | **string** | User DN | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

