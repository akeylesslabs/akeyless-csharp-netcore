# akeyless.Model.PolicyUpdateKeys

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedAlgorithms** | **List&lt;string&gt;** | Specify allowed key algorithms (e.g., [RSA2048,AES128GCM]) | [optional] 
**AllowedKeyNames** | **List&lt;string&gt;** | Specify allowed protection key names. To enforce using the account&#39;s default protection key, use &#39;default-account-key&#39; | [optional] 
**AllowedKeyTypes** | **List&lt;string&gt;** | Specify allowed key protection types (dfc, classic-key) | [optional] 
**Id** | **string** | Policy id | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**MaxRotationIntervalDays** | **int** | Set the maximum rotation interval for automatic key rotation. | [optional] 
**ObjectTypes** | **List&lt;string&gt;** | The object type this policy will apply to (items, targets) | [optional] 
**Path** | **string** | The path the policy refers to | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

