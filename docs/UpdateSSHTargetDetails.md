# akeyless.Model.UpdateSSHTargetDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Host** | **string** |  | [optional] 
**Name** | **string** | Target name | 
**NewVersion** | **bool** | Whether to create a new version of not | [optional] [default to false]
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Port** | **string** |  | [optional] 
**PrivateKey** | **string** |  | [optional] 
**PrivateKeyPassword** | **string** |  | [optional] 
**ProtectionKey** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**SshPassword** | **string** |  | [optional] 
**SshUsername** | **string** |  | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

