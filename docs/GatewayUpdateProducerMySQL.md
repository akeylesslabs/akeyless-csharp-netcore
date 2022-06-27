# akeyless.Model.GatewayUpdateProducerMySQL
gatewayUpdateProducerMySQL is a command that updates mysql producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DbServerCertificates** | **string** | (Optional) DB server certificates | [optional] 
**DbServerName** | **string** | (Optional) Server name for certificate verification | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item | [optional] 
**MysqlDbname** | **string** | MySQL DB Name | [optional] 
**MysqlHost** | **string** | MySQL Host | [optional] [default to "127.0.0.1"]
**MysqlPassword** | **string** | MySQL Password | [optional] 
**MysqlPort** | **string** | MySQL Port | [optional] [default to "3306"]
**MysqlScreationStatements** | **string** | MySQL Creation statements | [optional] 
**MysqlUsername** | **string** | MySQL Username | [optional] 
**Name** | **string** | Producer name | 
**NewName** | **string** | Producer name | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessWeb** | **bool** |  | [optional] 
**Ssl** | **bool** | SSL connection mode | [optional] 
**SslCertificate** | **string** | SSL connection certificate | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

