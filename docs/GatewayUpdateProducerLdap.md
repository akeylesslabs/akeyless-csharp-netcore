# akeyless.Model.GatewayUpdateProducerLdap
gatewayUpdateProducerLdap is a command that updates ldap producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BindDn** | **string** | Bind DN | [optional] 
**BindDnPassword** | **string** | Bind DN Password | [optional] 
**ExternalUsername** | **string** | Fixed user | [optional] [default to "false"]
**LdapCaCert** | **string** | CA Certificate File Content | [optional] 
**LdapUrl** | **string** | LDAP Server URL | [optional] 
**Name** | **string** | Producer name | 
**NewName** | **string** | Producer name | [optional] 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenExpiration** | **string** | Token expiration | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserAttribute** | **string** | User Attribute | [optional] 
**UserDn** | **string** | User DN | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
