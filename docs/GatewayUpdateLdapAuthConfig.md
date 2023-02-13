# akeyless.Model.GatewayUpdateLdapAuthConfig
gatewayUpdateLdapAuth is a command that updates ldap auth config

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** | The access ID of the Ldap auth method | [optional] 
**BindDn** | **string** | Bind DN | [optional] 
**BindDnPassword** | **string** | Bind DN Password | [optional] 
**GroupAttr** | **string** | Group Attr | [optional] 
**GroupDn** | **string** | Group Dn | [optional] 
**GroupFilter** | **string** | Group Filter | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**LdapCaCert** | **string** | LDAP CA Certificate (base64 encoded) | [optional] 
**LdapEnable** | **string** | Enable Ldap [true/false] | [optional] 
**LdapUrl** | **string** | LDAP Server URL, e.g. ldap://planetexpress.com:389 | [optional] 
**LdapAnonymousSearch** | **bool** | Ldap Anonymous Search | [optional] 
**SigningKeyData** | **string** | The private key (base64 encoded), associated with the public key defined in the Ldap auth | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserAttribute** | **string** | User Attribute | [optional] 
**UserDn** | **string** | User DN | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

