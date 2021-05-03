# akeyless.Model.CreateRotatedSecret
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation | [optional] 
**GatewayUrl** | **string** | Gateway url | [optional] [default to "http://localhost:8000"]
**Metadata** | **string** | Metadata about the secret | [optional] 
**Name** | **string** | Secret name | 
**ProtectionKey** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (7-365) | [optional] 
**RotationHour** | **int** |  | [optional] 
**RotatorCredsType** | **string** |  | [optional] 
**RotatorType** | **string** |  | [optional] 
**SshPassword** | **string** |  | [optional] 
**SshUsername** | **string** |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** |  | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

