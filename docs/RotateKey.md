# akeyless.Model.RotateKey
rotateKey is a command that rotates an existing key, creating a new version. [Deprecated: Use command update-rotation-settings] of it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation | [optional] 
**Name** | **string** | Key name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (7-365) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

