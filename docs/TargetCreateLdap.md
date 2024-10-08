# akeyless.Model.TargetCreateLdap
targetCreateLdap is a command that creates a new ldap target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BindDn** | **string** | Bind DN | 
**BindDnPassword** | **string** | Bind DN Password | 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**LdapCaCert** | **string** | CA Certificate File Content | [optional] 
**LdapUrl** | **string** | LDAP Server URL | 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**ServerType** | **string** | Set Ldap server type, Options:[OpenLDAP, ActiveDirectory]. Default is OpenLDAP | [optional] [default to "OpenLDAP"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenExpiration** | **string** | Token expiration | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

