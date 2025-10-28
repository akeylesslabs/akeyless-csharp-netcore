# akeyless.Model.GatewayUpdateProducerMSSQL
gatewayUpdateProducerMSSQL is a command that updates mssql producer [Deprecated: Use dynamic-secret-update-mssql command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**MssqlCreateStatements** | **string** | MSSQL Creation statements | [optional] 
**MssqlDbname** | **string** | MSSQL Name | [optional] 
**MssqlHost** | **string** | MSSQL Host | [optional] [default to "127.0.0.1"]
**MssqlPassword** | **string** | MSSQL Password | [optional] 
**MssqlPort** | **string** | MSSQL Port | [optional] [default to "1433"]
**MssqlRevocationStatements** | **string** | MSSQL Revocation statements | [optional] 
**MssqlUsername** | **string** | MSSQL Username | [optional] 
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessBastionIssuer** | **string** | Deprecated. use secure-access-certificate-issuer | [optional] 
**SecureAccessCertificateIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Secure Access | [optional] 
**SecureAccessDbName** | **string** | The DB name (relevant only for DB Dynamic-Secret) | [optional] 
**SecureAccessDbSchema** | **string** | The DB schema | [optional] 
**SecureAccessDelay** | **long** | The delay duration, in seconds, to wait after generating just-in-time credentials. Accepted range: 0-120 seconds | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target DB servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts) | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

