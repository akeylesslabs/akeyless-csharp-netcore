# akeyless.Model.CreateLdapTarget
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** | Access ID | 
**BindDn** | **string** | Bind DN | [optional] 
**BindDnPassword** | **string** | Bind DN Password | [optional] 
**Comment** | **string** | Comment about the target | [optional] 
**EnableAnonymSearch** | **bool** | EnableAnonymousSearch | [optional] 
**GroupAttribute** | **string** | Group attribute | [optional] 
**GroupDn** | **string** | Group DN | [optional] 
**GroupFilter** | **string** | Group attribute | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**LdapCaCert** | **string** | CA Certificate File Content | [optional] 
**LdapUrl** | **string** | LDAP Server URL | 
**Name** | **string** | Target name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**PrivateKey** | **string** | Base64-encoded ldap private key text | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenExpiration** | **string** | Token expiration | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserAttribute** | **string** | User Attribute | [optional] 
**UserDn** | **string** | User DN | 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

