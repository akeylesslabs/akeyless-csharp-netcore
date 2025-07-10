# akeyless.Model.GatewayUpdateProducerRedshift
gatewayUpdateProducerRedshift is a command that updates redshift producer [Deprecated: Use dynamic-secret-update-redshift command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreationStatements** | **string** | Redshift Creation statements | [optional] 
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKey** | **string** | Dynamic producer encryption key | [optional] 
**RedshiftDbName** | **string** | Redshift DB Name | [optional] 
**RedshiftHost** | **string** | Redshift Host | [optional] [default to "127.0.0.1"]
**RedshiftPassword** | **string** | Redshift Password | [optional] 
**RedshiftPort** | **string** | Redshift Port | [optional] [default to "5439"]
**RedshiftUsername** | **string** | Redshift Username | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target DB servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts) | [optional] 
**Ssl** | **bool** | Enable/Disable SSL [true/false] | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

