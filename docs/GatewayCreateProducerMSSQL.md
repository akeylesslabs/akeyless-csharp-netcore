# akeyless.Model.GatewayCreateProducerMSSQL
gatewayCreateProducerMSSQL is a command that creates mssql producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GatewayUrl** | **string** | Gateway url | [optional] [default to "http://localhost:8000"]
**MssqlCreateStatements** | **string** | MSSQL Creation statements | [optional] 
**MssqlDbname** | **string** | MSSQL Name | 
**MssqlHost** | **string** | MSSQL Host | [optional] [default to "127.0.0.1"]
**MssqlPassword** | **string** | MSSQL Password | 
**MssqlPort** | **string** | MSSQL Port | [optional] [default to "1433"]
**MssqlRevocationStatements** | **string** | MSSQL Revocation statements | [optional] 
**MssqlUsername** | **string** | MSSQL Username | 
**Name** | **string** | Producer name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

