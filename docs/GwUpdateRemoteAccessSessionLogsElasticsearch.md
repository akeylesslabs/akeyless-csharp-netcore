# akeyless.Model.GwUpdateRemoteAccessSessionLogsElasticsearch
gwUpdateRemoteAccessSessionLogsElasticsearch is a command that updates session log forwarding config (elasticsearch target)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiKey** | **string** | Elasticsearch api key relevant only for api_key auth-type | [optional] 
**AuthType** | **string** | Elasticsearch auth type [api_key/password] | [optional] 
**CloudId** | **string** | Elasticsearch cloud id relevant only for cloud server-type | [optional] 
**Enable** | **string** | Enable Log Forwarding [true/false] | [optional] [default to "true"]
**EnableTls** | **bool** | Enable tls | [optional] 
**Index** | **string** | Elasticsearch index | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Nodes** | **string** | Elasticsearch nodes relevant only for nodes server-type | [optional] 
**OutputFormat** | **string** | Logs format [text/json] | [optional] [default to "text"]
**Password** | **string** | Elasticsearch password relevant only for password auth-type | [optional] 
**PullInterval** | **string** | Pull interval in seconds | [optional] [default to "10"]
**ServerType** | **string** | Elasticsearch server type [cloud/nodes] | [optional] 
**TlsCertificate** | **string** | Elasticsearch tls certificate | [optional] [default to "use-existing"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserName** | **string** | Elasticsearch user name relevant only for password auth-type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

