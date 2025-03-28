# akeyless.Model.GwUpdateRemoteAccessSessionLogsSumologic
gwUpdateRemoteAccessSessionLogsSumologic is a command that updates session log forwarding config (sumologic target)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **string** | Enable Log Forwarding [true/false] | [optional] [default to "true"]
**Endpoint** | **string** | Sumologic endpoint URL | [optional] 
**Host** | **string** | Sumologic host | [optional] [default to "use-existing"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**OutputFormat** | **string** | Logs format [text/json] | [optional] [default to "text"]
**PullInterval** | **string** | Pull interval in seconds | [optional] [default to "10"]
**SumologicTags** | **string** | A comma-separated list of Sumologic tags | [optional] [default to "use-existing"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

