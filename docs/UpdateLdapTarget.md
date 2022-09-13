# akeyless.Model.UpdateLdapTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BindDn** | **string** |  | [optional] 
**BindDnPassword** | **string** |  | [optional] 
**Comment** | **string** | Comment about the target | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] 
**KeepPrevVersion** | **string** |  | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**LdapCaCert** | **string** |  | [optional] 
**LdapUrl** | **string** |  | [optional] 
**Name** | **string** | Target name | 
**NewName** | **string** | New target name | [optional] 
**ServerType** | **string** | Set Ldap server type, Options:[OpenLDAP, ActiveDirectory] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenExpiration** | **string** |  | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UpdateVersion** | **bool** | Deprecated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

