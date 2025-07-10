# akeyless.Model.DynamicSecretCreateOracleDb
dynamicSecretCreateOracleDb is a command that creates oracle db dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DbServerCertificates** | **string** | (Optional) DB server certificates | [optional] 
**DbServerName** | **string** | (Optional) Server name for certificate verification | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**OracleHost** | **string** | Oracle Host | [optional] [default to "127.0.0.1"]
**OraclePassword** | **string** | Oracle Password | [optional] 
**OraclePort** | **string** | Oracle Port | [optional] [default to "1521"]
**OracleRevocationStatements** | **string** | Oracle Revocation statements | [optional] 
**OracleScreationStatements** | **string** | Oracle Creation statements | [optional] 
**OracleServiceName** | **string** | Oracle DB Name | [optional] 
**OracleUsername** | **string** | Oracle Username | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessBastionIssuer** | **string** | Deprecated. use secure-access-certificate-issuer | [optional] 
**SecureAccessCertificateIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Secure Access | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] [default to "false"]
**SecureAccessHost** | **List&lt;string&gt;** | Target DB servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts) | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

