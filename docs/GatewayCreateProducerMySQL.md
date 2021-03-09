# akeyless.Model.GatewayCreateProducerMySQL
gatewayCreateProducerMySQL is a command that creates mysql producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DbServerCertificates** | **string** | (Optional) DB server certificates | [optional] 
**DbServerName** | **string** | (Optional) Server name for certificate verification | [optional] 
**GatewayUrl** | **string** | Gateway url | [optional] [default to "http://localhost:8000"]
**MysqlDbname** | **string** | MySQL DB Name | 
**MysqlHost** | **string** | MySQL Host | [optional] [default to "127.0.0.1"]
**MysqlPassword** | **string** | MySQL Password | 
**MysqlPort** | **string** | MySQL Port | [optional] [default to "3306"]
**MysqlScreationStatements** | **string** | MySQL Creation statements | [optional] 
**MysqlUsername** | **string** | MySQL Username | 
**Name** | **string** | Producer name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

