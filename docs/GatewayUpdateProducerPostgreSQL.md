# akeyless.Model.GatewayUpdateProducerPostgreSQL
gatewayUpdateProducerPostgreSQL is a command that updates postgresql producer [Deprecated: Use dynamic-secret-update-postgresql command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreationStatements** | **string** | PostgreSQL Creation statements | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**PostgresqlDbName** | **string** | PostgreSQL DB Name | [optional] 
**PostgresqlHost** | **string** | PostgreSQL Host | [optional] [default to "127.0.0.1"]
**PostgresqlPassword** | **string** | PostgreSQL Password | [optional] 
**PostgresqlPort** | **string** | PostgreSQL Port | [optional] [default to "5432"]
**PostgresqlUsername** | **string** | PostgreSQL Username | [optional] 
**ProducerEncryptionKey** | **string** | Dynamic producer encryption key | [optional] 
**RevocationStatement** | **string** | PostgreSQL Revocation statements | [optional] 
**SecureAccessBastionIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Bastion | [optional] 
**SecureAccessDbSchema** | **string** | The DB schema | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target DB servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts) | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**Ssl** | **bool** | Enable/Disable SSL [true/false] | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

