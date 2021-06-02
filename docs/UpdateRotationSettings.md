# akeyless.Model.UpdateRotationSettings
updateRotationSettings is a command that updates rotations settings of an existing key
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoRotate** | **bool** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation | 
**Name** | **string** | Key name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**RotationInterval** | **long** | The number of days to wait between every automatic key rotation (7-365) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

