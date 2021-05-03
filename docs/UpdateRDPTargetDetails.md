# akeyless.Model.UpdateRDPTargetDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminName** | **string** |  | [optional] 
**AdminPwd** | **string** |  | [optional] 
**HostName** | **string** |  | [optional] 
**HostPort** | **string** |  | [optional] 
**Name** | **string** | Target name | 
**NewVersion** | **bool** | Whether to create a new version of not | [optional] [default to false]
**ProtectionKey** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

