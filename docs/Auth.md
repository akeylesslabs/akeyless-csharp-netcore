# akeyless.Model.Auth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** | Access ID | [optional] 
**AccessKey** | **string** | Access key (relevant only for access-type&#x3D;access_key) | [optional] 
**AccessType** | **string** | Access Type (access_key/password/saml/ldap/k8s/azure_ad/oidc/aws_iam/universal_identity/jwt/gcp/cert) | [optional] [default to "access_key"]
**AccountId** | **string** | Account id (relevant only for access-type&#x3D;password where the email address is associated with more than one account) | [optional] 
**AdminEmail** | **string** | Email (relevant only for access-type&#x3D;password) | [optional] 
**AdminPassword** | **string** | Password (relevant only for access-type&#x3D;password) | [optional] 
**CertData** | **string** | Certificate data encoded in base64. Used if file was not provided. (relevant only for access-type&#x3D;cert) | [optional] 
**CloudId** | **string** | The cloud identity (relevant only for access-type&#x3D;azure_ad,aws_iam,gcp) | [optional] 
**Debug** | **bool** |  | [optional] 
**GatewayUrl** | **string** | Gateway URL relevant only for access-type&#x3D;k8s/oauth2/saml/oidc | [optional] 
**GcpAudience** | **string** | GCP JWT audience | [optional] [default to "akeyless.io"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Jwt** | **string** | The Json Web Token (relevant only for access-type&#x3D;jwt/oidc) | [optional] 
**K8sAuthConfigName** | **string** | The K8S Auth config name (relevant only for access-type&#x3D;k8s) | [optional] 
**K8sServiceAccountToken** | **string** | The K8S service account token. (relevant only for access-type&#x3D;k8s) | [optional] 
**KeyData** | **string** | Private key data encoded in base64. Used if file was not provided.(relevant only for access-type&#x3D;cert) | [optional] 
**LdapPassword** | **string** | LDAP password (relevant only for access-type&#x3D;ldap) | [optional] 
**LdapUsername** | **string** | LDAP username (relevant only for access-type&#x3D;ldap) | [optional] 
**OciAuthType** | **string** | The type of the OCI configuration to use [instance/apikey/resource] (relevant only for access-type&#x3D;oci) | [optional] [default to "apikey"]
**OciGroupOcid** | **List&lt;string&gt;** | A list of Oracle Cloud IDs groups (relevant only for access-type&#x3D;oci) | [optional] 
**UidToken** | **string** | The universal_identity token (relevant only for access-type&#x3D;universal_identity) | [optional] 
**UseRemoteBrowser** | **bool** | Returns a link to complete the authentication remotely (relevant only for access-type&#x3D;saml/oidc) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

