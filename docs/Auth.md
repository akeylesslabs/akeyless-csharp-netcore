# akeyless.Model.Auth

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** | Access ID | [optional] 
**AccessKey** | **string** | Access key (relevant only for access-type&#x3D;access_key) | [optional] 
**AccessType** | **string** | Access Type (access_key/password/saml/ldap/k8s/azure_ad/aws_iam/universal_identity/jwt/gcp/k8s) | [optional] [default to "access_key"]
**AdminEmail** | **string** | Email (relevant only for access-type&#x3D;password) | [optional] 
**AdminPassword** | **string** | Password (relevant only for access-type&#x3D;password) | [optional] 
**CloudId** | **string** | The cloud identity (relevant only for access-type&#x3D;azure_ad,aws_iam,gcp) | [optional] 
**GcpAudience** | **string** | GCP JWT audience | [optional] 
**Jwt** | **string** | The Json Web Token (relevant only for access-type&#x3D;jwt/oidc) | [optional] 
**K8sAuthConfigName** | **string** | The K8S Auth config name (relevant only for access-type&#x3D;k8s) | [optional] 
**K8sServiceAccountToken** | **string** | The K8S service account token. (relevant only for access-type&#x3D;k8s) | [optional] 
**LdapPassword** | **string** | LDAP password (relevant only for access-type&#x3D;ldap) | [optional] 
**LdapUsername** | **string** | LDAP username (relevant only for access-type&#x3D;ldap) | [optional] 
**UidToken** | **string** | The universal_identity token (relevant only for access-type&#x3D;universal_identity) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

