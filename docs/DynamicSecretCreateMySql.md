# akeyless.Model.DynamicSecretCreateMySql
dynamicSecretCreateMySql is a command that creates mysql dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DbServerCertificates** | **string** | (Optional) DB server certificates | [optional] 
**DbServerName** | **string** | (Optional) Server name for certificate verification | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**MysqlDbname** | **string** | MySQL DB Name | [optional] 
**MysqlHost** | **string** | MySQL Host | [optional] [default to "127.0.0.1"]
**MysqlPassword** | **string** | MySQL Password | [optional] 
**MysqlPort** | **string** | MySQL Port | [optional] [default to "3306"]
**MysqlRevocationStatements** | **string** | MySQL Revocation statements | [optional] 
**MysqlScreationStatements** | **string** | MySQL Creation statements | [optional] 
**MysqlUsername** | **string** | MySQL Username | [optional] 
**Name** | **string** | Dynamic secret name | 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessBastionIssuer** | **string** | Deprecated. use secure-access-certificate-issuer | [optional] 
**SecureAccessCertificateIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Secure Access | [optional] 
**SecureAccessDbName** | **string** | The DB name (relevant only for DB Dynamic-Secret) | [optional] 
**SecureAccessDelay** | **long** | The delay duration, in seconds, to wait after generating just-in-time credentials. Accepted range: 0-120 seconds | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target DB servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts) | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**Ssl** | **bool** | Enable/Disable SSL [true/false] | [optional] [default to false]
**SslCertificate** | **string** | SSL connection certificate | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

