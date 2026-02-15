# akeyless.Model.SplunkTargetDetails
SplunkTargetDetails defines details related to connecting to a Splunk server

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Audience** | **string** | Token audience | [optional] 
**AuthMode** | **string** | Authentication mode: \&quot;username\&quot; or \&quot;token\&quot; | [optional] 
**Password** | **string** |  | [optional] 
**SplunkPayload** | [**SplunkPayload**](SplunkPayload.md) |  | [optional] 
**SplunkUrl** | **string** | Splunk server URL | [optional] 
**Token** | **string** | Token is used when AuthMode &#x3D;&#x3D; \&quot;token\&quot; | [optional] 
**TokenOwner** | **string** | Token owner (the Splunk user who owns the token, required for token rotation) | [optional] 
**UseTls** | **bool** | Use TLS certificate verification when connecting to the Splunk management API. | [optional] 
**Username** | **string** | Username &amp; Password are used when AuthMode &#x3D;&#x3D; \&quot;username\&quot; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

