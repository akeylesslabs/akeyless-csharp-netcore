# akeyless.Model.TargetUpdateOpenAI
targetUpdateOpenAI is a command that updates an existing openai target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiKey** | **string** | API key for OpenAI | [optional] 
**ApiKeyId** | **string** | API key ID | [optional] 
**Description** | **string** | Description of the object | [optional] [default to "default_comment"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Model** | **string** | Default model to use with OpenAI | [optional] 
**Name** | **string** | Target name | 
**NewComment** | **string** | Deprecated - use description | [optional] [default to "default_comment"]
**NewName** | **string** | New target name | [optional] 
**OpenaiUrl** | **string** | Base URL of the OpenAI API | [optional] [default to "https://api.openai.com/v1"]
**OrganizationId** | **string** | Organization ID | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

