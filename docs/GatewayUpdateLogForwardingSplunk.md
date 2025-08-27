# akeyless.Model.GatewayUpdateLogForwardingSplunk
gatewayUpdateLogForwardingSplunk is a command that updates log forwarding config (splunk target)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **string** | Enable Log Forwarding [true/false] | [optional] [default to "true"]
**EnableBatch** | **string** | Enable batch forwarding [true/false] | [optional] [default to "true"]
**EnableTls** | **bool** | Enable tls | [optional] 
**Index** | **string** | Splunk index | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**OutputFormat** | **string** | Logs format [text/json] | [optional] [default to "text"]
**PullInterval** | **string** | Pull interval in seconds | [optional] [default to "10"]
**Source** | **string** | Splunk source | [optional] [default to "use-existing"]
**SourceType** | **string** | Splunk source type | [optional] [default to "use-existing"]
**SplunkToken** | **string** | Splunk token | [optional] 
**SplunkUrl** | **string** | Splunk server URL | [optional] 
**TlsCertificate** | **string** | Splunk tls certificate | [optional] [default to "use-existing"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

