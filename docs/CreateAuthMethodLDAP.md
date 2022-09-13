# akeyless.Model.CreateAuthMethodLDAP
createAuthMethodLDAP is a command that creates a new auth method that will be able to authenticate using LDAP.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the IPs that the access is restricted to | [optional] 
**ForceSubClaims** | **bool** | if true: enforce role-association must include sub claims | [optional] 
**GenKey** | **string** | Automatically generate key-pair for LDAP configuration. If set to false, a public key needs to be provided | [optional] [default to "true"]
**GwBoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the GW IPs that the access is restricted to | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] 
**JwtTtl** | **long** | Jwt TTL | [optional] 
**Name** | **string** | Auth Method name | 
**PublicKeyData** | **string** | A public key generated for LDAP authentication method on Akeyless in base64 or PEM format [RSA2048] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UniqueIdentifier** | **string** | A unique identifier (ID) value should be configured for OAuth2, LDAP and SAML authentication method types and is usually a value such as the email, username, or upn for example. Whenever a user logs in with a token, these authentication types issue a \&quot;sub claim\&quot; that contains details uniquely identifying that user. This sub claim includes a key containing the ID value that you configured, and is used to distinguish between different users from within the same organization. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

