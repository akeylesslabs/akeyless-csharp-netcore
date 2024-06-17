# akeyless.Model.GatewayUpdateLogForwardingLogstash
gatewayUpdateLogForwardingLogstash is a command that updates log forwarding config (logstash target)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Dns** | **string** | Logstash dns | [optional] 
**Enable** | **string** | Enable Log Forwarding [true/false] | [optional] [default to "true"]
**EnableTls** | **bool** | Enable tls | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**OutputFormat** | **string** | Logs format [text/json] | [optional] [default to "text"]
**Protocol** | **string** | Logstash protocol [tcp/udp] | [optional] 
**PullInterval** | **string** | Pull interval in seconds | [optional] [default to "10"]
**TlsCertificate** | **string** | Logstash tls certificate | [optional] [default to "use-existing"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

