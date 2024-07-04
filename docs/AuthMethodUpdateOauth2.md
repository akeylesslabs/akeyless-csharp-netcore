# akeyless.Model.AuthMethodUpdateOauth2
authMethodUpdateOauth2 is a command that updates a new auth method that will be able to authenticate using Oauth2.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**Audience** | **string** | The audience in the JWT | [optional] 
**AuditLogsClaims** | **List&lt;string&gt;** | Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot; | [optional] 
**BoundClientIds** | **List&lt;string&gt;** | The clients ids that the access is restricted to | [optional] 
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the IPs that the access is restricted to | [optional] 
**Cert** | **string** | CertificateFile Path to a file that contain the certificate in a PEM format. | [optional] 
**CertFileData** | **string** | CertificateFileData PEM Certificate in a Base64 format. | [optional] 
**Description** | **string** | Auth Method description | [optional] 
**ForceSubClaims** | **bool** | if true: enforce role-association must include sub claims | [optional] 
**GatewayUrl** | **string** | Akeyless Gateway URL (Configuration Management port). Relevant only when the jwks-uri is accessible only from the gateway. | [optional] 
**GwBoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the GW IPs that the access is restricted to | [optional] 
**Issuer** | **string** | Issuer URL | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**JwksJsonData** | **string** | The JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. base64 encoded string | [optional] 
**JwksUri** | **string** | The URL to the JSON Web Key Set (JWKS) that containing the public keys that should be used to verify any JSON Web Token (JWT) issued by the authorization server. | [default to "default_jwks_url"]
**JwtTtl** | **long** | Jwt TTL | [optional] [default to 0]
**Name** | **string** | Auth Method name | 
**NewName** | **string** | Auth Method new name | [optional] 
**ProductType** | **List&lt;string&gt;** | Choose the relevant product type for the auth method [sm, sra, pm, dp, ca] | [optional] 
**SubclaimsDelimiters** | **List&lt;string&gt;** | A list of additional sub claims delimiters (relevant only for SAML, OIDC, OAuth2/JWT) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UniqueIdentifier** | **string** | A unique identifier (ID) value should be configured for OAuth2, LDAP and SAML authentication method types and is usually a value such as the email, username, or upn for example. Whenever a user logs in with a token, these authentication types issue a \&quot;sub claim\&quot; that contains details uniquely identifying that user. This sub claim includes a key containing the ID value that you configured, and is used to distinguish between different users from within the same organization. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

