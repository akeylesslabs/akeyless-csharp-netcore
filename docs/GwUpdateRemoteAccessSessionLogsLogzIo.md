# akeyless.Model.GwUpdateRemoteAccessSessionLogsLogzIo
gwUpdateRemoteAccessSessionLogsLogzIo is a command that updates session log forwarding config (logz-io target)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **string** | Enable Log Forwarding [true/false] | [optional] [default to "true"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**LogzIoToken** | **string** | Logz-io token | [optional] 
**OutputFormat** | **string** | Logs format [text/json] | [optional] [default to "text"]
**Protocol** | **string** | LogzIo protocol [tcp/https] | [optional] 
**PullInterval** | **string** | Pull interval in seconds | [optional] [default to "10"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

