# akeyless.Model.GatewayUpdateLogForwardingSyslog
gatewayUpdateLogForwardingSyslog is a command that updates log forwarding config (syslog target)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **string** | Enable Log Forwarding [true/false] | [optional] [default to "true"]
**EnableTls** | **bool** | Enable tls relevant only for network type TCP | [optional] 
**Formatter** | **string** | Syslog formatter [text/cef] | [optional] [default to "text"]
**Host** | **string** | Syslog host | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Network** | **string** | Syslog network [tcp/udp] | [optional] [default to "tcp"]
**OutputFormat** | **string** | Logs format [text/json] | [optional] [default to "text"]
**PullInterval** | **string** | Pull interval in seconds | [optional] [default to "10"]
**TargetTag** | **string** | Syslog target tag | [optional] [default to "use-existing"]
**TlsCertificate** | **string** | Syslog tls certificate | [optional] [default to "use-existing"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

