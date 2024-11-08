# akeyless.Model.AuthMethodAccessInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** |  | [optional] 
**AccessIdAlias** | **string** | for accounts where AccessId holds encrypted email this field will hold generated AccessId, for accounts based on regular AccessId it will be equal to accessId itself | [optional] 
**ApiKeyAccessRules** | [**APIKeyAccessRules**](APIKeyAccessRules.md) |  | [optional] 
**AuditLogsClaims** | **List&lt;string&gt;** |  | [optional] 
**AwsIamAccessRules** | [**AWSIAMAccessRules**](AWSIAMAccessRules.md) |  | [optional] 
**AzureAdAccessRules** | [**AzureADAccessRules**](AzureADAccessRules.md) |  | [optional] 
**CertAccessRules** | [**CertAccessRules**](CertAccessRules.md) |  | [optional] 
**CidrWhitelist** | **string** |  | [optional] 
**EmailPassAccessRules** | [**EmailPassAccessRules**](EmailPassAccessRules.md) |  | [optional] 
**ForceSubClaims** | **bool** | if true the role associated with this auth method must include sub claims | [optional] 
**GcpAccessRules** | [**GCPAccessRules**](GCPAccessRules.md) |  | [optional] 
**GwCidrWhitelist** | **string** |  | [optional] 
**HuaweiAccessRules** | [**HuaweiAccessRules**](HuaweiAccessRules.md) |  | [optional] 
**JwtTtl** | **long** |  | [optional] 
**K8sAccessRules** | [**KubernetesAccessRules**](KubernetesAccessRules.md) |  | [optional] 
**KerberosAccessRules** | [**KerberosAccessRules**](KerberosAccessRules.md) |  | [optional] 
**LdapAccessRules** | [**LDAPAccessRules**](LDAPAccessRules.md) |  | [optional] 
**Oauth2AccessRules** | [**OAuth2AccessRules**](OAuth2AccessRules.md) |  | [optional] 
**OciAccessRules** | [**OCIAccessRules**](OCIAccessRules.md) |  | [optional] 
**OidcAccessRules** | [**OIDCAccessRules**](OIDCAccessRules.md) |  | [optional] 
**ProductTypes** | **List&lt;string&gt;** | List of product types this auth method will be in use of | [optional] 
**RulesType** | **string** |  | [optional] 
**SamlAccessRules** | [**SAMLAccessRules**](SAMLAccessRules.md) |  | [optional] 
**SubClaimsDelimiters** | **List&lt;string&gt;** |  | [optional] 
**UniversalIdentityAccessRules** | [**UniversalIdentityAccessRules**](UniversalIdentityAccessRules.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

