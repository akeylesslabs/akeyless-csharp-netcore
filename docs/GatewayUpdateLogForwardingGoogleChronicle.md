# akeyless.Model.GatewayUpdateLogForwardingGoogleChronicle
gatewayUpdateLogForwardingGoogleChronicle is a command that updates log forwarding config (google-chronicle target)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerId** | **string** | Google chronicle customer id | [optional] 
**Enable** | **string** | Enable Log Forwarding [true/false] | [optional] [default to "true"]
**GcpKey** | **string** | Base64-encoded service account private key text | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**LogType** | **string** | Google chronicle log type | [optional] 
**OutputFormat** | **string** | Logs format [text/json] | [optional] [default to "text"]
**PullInterval** | **string** | Pull interval in seconds | [optional] [default to "10"]
**Region** | **string** | Google chronicle region [eu_multi_region/london/us_multi_region/singapore/tel_aviv] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

