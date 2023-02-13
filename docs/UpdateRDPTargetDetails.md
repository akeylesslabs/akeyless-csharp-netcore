# akeyless.Model.UpdateRDPTargetDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminName** | **string** | The admin name | [optional] 
**AdminPwd** | **string** | The admin password | [optional] 
**HostName** | **string** | The rdp host name | [optional] 
**HostPort** | **string** | The rdp port | [optional] [default to "22"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Name** | **string** | Target name | 
**NewVersion** | **bool** | Deprecated | [optional] 
**ProtectionKey** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

