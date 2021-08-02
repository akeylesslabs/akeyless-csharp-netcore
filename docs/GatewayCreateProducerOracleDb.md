# akeyless.Model.GatewayCreateProducerOracleDb
gatewayCreateProducerOracleDb is a command that creates oracle db producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DbServerCertificates** | **string** | (Optional) DB server certificates | [optional] 
**DbServerName** | **string** | (Optional) Server name for certificate verification | [optional] 
**Name** | **string** | Producer name | 
**OracleHost** | **string** | Oracle Host | [optional] [default to "127.0.0.1"]
**OraclePassword** | **string** | Oracle Password | 
**OraclePort** | **string** | Oracle Port | [optional] [default to "1521"]
**OracleScreationStatements** | **string** | Oracle Creation statements | [optional] 
**OracleServiceName** | **string** | Oracle DB Name | 
**OracleUsername** | **string** | Oracle Username | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

