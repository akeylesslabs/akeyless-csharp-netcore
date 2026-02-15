# akeyless.Model.TargetCreateSplunk
targetCreateSplunk is a command that creates a new splunk target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Audience** | **string** | Splunk token audience (required when using token authentication for rotation) | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**Password** | **string** | Splunk Password (used when authenticating with username/password) | [optional] 
**Token** | **string** | Splunk Token (used when authenticating with token) | [optional] 
**TokenOwner** | **string** | Splunk Token Owner (required when using token authentication for rotation) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Url** | **string** | Splunk server URL | 
**UseTls** | **bool** | Use TLS certificate verification when connecting to the Splunk management API | [optional] [default to true]
**Username** | **string** | Splunk Username (used when authenticating with username/password) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

