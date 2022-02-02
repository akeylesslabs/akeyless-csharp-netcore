# akeyless.Model.GatewayCreateProducerPostgreSQL
gatewayCreateProducerPostgreSQL is a command that creates postgresql producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreationStatements** | **string** | PostgreSQL Creation statements | [optional] 
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**PostgresqlDbName** | **string** | PostgreSQL DB Name | [optional] 
**PostgresqlHost** | **string** | PostgreSQL Host | [optional] [default to "127.0.0.1"]
**PostgresqlPassword** | **string** | PostgreSQL Password | [optional] 
**PostgresqlPort** | **string** | PostgreSQL Port | [optional] [default to "5432"]
**PostgresqlUsername** | **string** | PostgreSQL Username | [optional] 
**ProducerEncryptionKey** | **string** | Dynamic producer encryption key | [optional] 
**RevocationStatement** | **string** | PostgreSQL Revocation statements | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessDbSchema** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessWeb** | **bool** |  | [optional] 
**Ssl** | **bool** | SSL connection mode | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

