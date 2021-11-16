# akeyless.Model.GatewayUpdateProducerMSSQL
gatewayUpdateProducerMSSQL is a command that updates mssql producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MssqlCreateStatements** | **string** | MSSQL Creation statements | [optional] 
**MssqlDbname** | **string** | MSSQL Name | [optional] 
**MssqlHost** | **string** | MSSQL Host | [optional] [default to "127.0.0.1"]
**MssqlPassword** | **string** | MSSQL Password | [optional] 
**MssqlPort** | **string** | MSSQL Port | [optional] [default to "1433"]
**MssqlRevocationStatements** | **string** | MSSQL Revocation statements | [optional] 
**MssqlUsername** | **string** | MSSQL Username | [optional] 
**Name** | **string** | Producer name | 
**NewName** | **string** | Producer name | [optional] 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessDbSchema** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessWeb** | **bool** |  | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

