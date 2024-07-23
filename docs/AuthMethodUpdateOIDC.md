# akeyless.Model.AuthMethodUpdateOIDC
authMethodUpdateOIDC is a command that updates a new auth method that will be available to authenticate using OIDC.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**AllowedRedirectUri** | **List&lt;string&gt;** | Allowed redirect URIs after the authentication | [optional] 
**Audience** | **string** | Audience claim to be used as part of the authentication flow. In case set, it must match the one configured on the Identity Provider&#39;s Application | [optional] 
**AuditLogsClaims** | **List&lt;string&gt;** | Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot; | [optional] 
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the IPs that the access is restricted to | [optional] 
**ClientId** | **string** | Client ID | [optional] 
**ClientSecret** | **string** | Client Secret | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Auth Method description | [optional] 
**ForceSubClaims** | **bool** | if true: enforce role-association must include sub claims | [optional] 
**GwBoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the GW IPs that the access is restricted to | [optional] 
**Issuer** | **string** | Issuer URL | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**JwtTtl** | **long** | Jwt TTL | [optional] [default to 0]
**Name** | **string** | Auth Method name | 
**NewName** | **string** | Auth Method new name | [optional] 
**ProductType** | **List&lt;string&gt;** | Choose the relevant product type for the auth method [sm, sra, pm, dp, ca] | [optional] 
**RequiredScopes** | **List&lt;string&gt;** | RequiredScopes is a list of required scopes that the oidc method will request from the oidc provider and the user must approve | [optional] 
**RequiredScopesPrefix** | **string** | RequiredScopesPrefix is a a prefix to add to all required-scopes when requesting them from the oidc server (for example, azures&#39; Application ID URI) | [optional] 
**SubclaimsDelimiters** | **List&lt;string&gt;** | A list of additional sub claims delimiters (relevant only for SAML, OIDC, OAuth2/JWT) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UniqueIdentifier** | **string** | A unique identifier (ID) value should be configured for OIDC, OAuth2, LDAP and SAML authentication method types and is usually a value such as the email, username, or upn for example. Whenever a user logs in with a token, these authentication types issue a \&quot;sub claim\&quot; that contains details uniquely identifying that user. This sub claim includes a key containing the ID value that you configured, and is used to distinguish between different users from within the same organization. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

