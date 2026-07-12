# akeyless.Model.GrokTargetDetails
GrokTargetDetails defines details related to connecting to an xAI (Grok) provider. Grok exposes an OpenAI-compatible REST API, so the agent layer reuses the OpenAI client with a custom BaseURL.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiKey** | **string** |  | [optional] 
**GrokUrl** | **string** |  | [optional] 
**TeamId** | **string** | TeamID is the xAI team this API key belongs to. Stored only; not sent to xAI by the gateway. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

