# akeyless.Model.UpdateAWSTargetDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessKey** | **string** | The aws secret access key | [optional] 
**AccessKeyId** | **string** | The aws access key id | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Name** | **string** | Target name | 
**NewVersion** | **bool** | Deprecated | [optional] 
**ProtectionKey** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Region** | **string** | The aws region | [optional] [default to "us-east-2"]
**SessionToken** | **string** | Required only for temporary security credentials retrieved via STS, otherwise it can be an empty string | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

