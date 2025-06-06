# akeyless.Model.CreateAuthMethodCert
createAuthMethodCert is a command that creates a new auth method that will be able to authenticate using a client certificate. [Deprecated: Use auth-method-create-cert command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**AllowedCors** | **string** | Comma separated list of allowed CORS domains to be validated as part of the authentication flow. | [optional] 
**AuditLogsClaims** | **List&lt;string&gt;** | Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot; | [optional] 
**BoundCommonNames** | **List&lt;string&gt;** | A list of names. At least one must exist in the Common Name. Supports globbing. | [optional] 
**BoundDnsSans** | **List&lt;string&gt;** | A list of DNS names. At least one must exist in the SANs. Supports globbing. | [optional] 
**BoundEmailSans** | **List&lt;string&gt;** | A list of Email Addresses. At least one must exist in the SANs. Supports globbing. | [optional] 
**BoundExtensions** | **List&lt;string&gt;** | A list of extensions formatted as \&quot;oid:value\&quot;. Expects the extension value to be some type of ASN1 encoded string. All values much match. Supports globbing on \&quot;value\&quot;. | [optional] 
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the IPs that the access is restricted to | [optional] 
**BoundOrganizationalUnits** | **List&lt;string&gt;** | A list of Organizational Units names. At least one must exist in the OU field. | [optional] 
**BoundUriSans** | **List&lt;string&gt;** | A list of URIs. At least one must exist in the SANs. Supports globbing. | [optional] 
**CertificateData** | **string** | The certificate data in base64, if no file was provided | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Auth Method description | [optional] 
**ExpirationEventIn** | **List&lt;string&gt;** | How many days before the expiration of the auth method would you like to be notified. | [optional] 
**ForceSubClaims** | **bool** | if true: enforce role-association must include sub claims | [optional] 
**GwBoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the GW IPs that the access is restricted to | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**JwtTtl** | **long** | Jwt TTL | [optional] [default to 0]
**Name** | **string** | Auth Method name | 
**ProductType** | **List&lt;string&gt;** | Choose the relevant product type for the auth method [sm, sra, pm, dp, ca] | [optional] 
**RevokedCertIds** | **List&lt;string&gt;** | A list of revoked cert ids | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UniqueIdentifier** | **string** | A unique identifier (ID) value should be configured, such as common_name or organizational_unit Whenever a user logs in with a token, these authentication types issue a \&quot;sub claim\&quot; that contains details uniquely identifying that user. This sub claim includes a key containing the ID value that you configured, and is used to distinguish between different users from within the same organization. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

