# akeyless.Model.TargetCreateGemini
targetCreateGemini is a command that creates a new gemini target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiKey** | **string** | API key for Gemini | [optional] 
**Description** | **string** | Description of the object | [optional] 
**GeminiUrl** | **string** | Base URL of the Gemini API | [optional] [default to "https://generativelanguage.googleapis.com"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Model** | **string** | Default model to use with Gemini | [optional] 
**Name** | **string** | Target name | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

