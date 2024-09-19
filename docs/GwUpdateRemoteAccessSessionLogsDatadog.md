# akeyless.Model.GwUpdateRemoteAccessSessionLogsDatadog
gwUpdateRemoteAccessSessionLogsDatadog is a command that updates session log forwarding config (datadog target)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiKey** | **string** | Datadog api key | [optional] 
**Enable** | **string** | Enable Log Forwarding [true/false] | [optional] [default to "true"]
**Host** | **string** | Datadog host | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**LogService** | **string** | Datadog log service | [optional] [default to "use-existing"]
**LogSource** | **string** | Datadog log source | [optional] [default to "use-existing"]
**LogTags** | **string** | A comma-separated list of Datadog log tags formatted as \&quot;key:value\&quot; strings | [optional] [default to "use-existing"]
**OutputFormat** | **string** | Logs format [text/json] | [optional] [default to "text"]
**PullInterval** | **string** | Pull interval in seconds | [optional] [default to "10"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

