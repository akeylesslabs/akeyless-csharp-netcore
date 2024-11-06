# akeyless.Model.Configure

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** | Access ID | [optional] 
**AccessKey** | **string** | Access Key | [optional] 
**AccessType** | **string** | Access Type (access_key/password/azure_ad/saml/oidc/aws_iam/gcp/k8s/cert) | [optional] [default to "access_key"]
**AccountId** | **string** | Account id (relevant only for access-type&#x3D;password where the email address is associated with more than one account) | [optional] 
**AdminEmail** | **string** | Email (relevant only for access-type&#x3D;password) | [optional] 
**AdminPassword** | **string** | Password (relevant only for access-type&#x3D;password) | [optional] 
**AzureAdObjectId** | **string** | Azure Active Directory ObjectId (relevant only for access-type&#x3D;azure_ad) | [optional] 
**CertData** | **string** | Certificate data encoded in base64. Used if file was not provided. (relevant only for access-type&#x3D;cert in Curl Context) | [optional] 
**CertIssuerName** | **string** | Certificate Issuer Name | [optional] 
**CertUsername** | **string** | The username to sign in the SSH certificate (use a comma-separated list for more than one username) | [optional] 
**DefaultLocationPrefix** | **string** | Default path prefix for name of items, targets and auth methods | [optional] 
**DisablePafxfast** | **string** | Disable the FAST negotiation in the Kerberos authentication method | [optional] 
**GatewaySpn** | **string** | The service principal name of the gateway as registered in LDAP (i.e., HTTP/gateway) | [optional] 
**GcpAudience** | **string** | GCP JWT audience | [optional] [default to "akeyless.io"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**K8sAuthConfigName** | **string** | The K8S Auth config name (relevant only for access-type&#x3D;k8s) | [optional] 
**KerberosUsername** | **string** | TThe username for the entry within the keytab to authenticate via Kerberos | [optional] 
**KeyData** | **string** | Private key data encoded in base64. Used if file was not provided.(relevant only for access-type&#x3D;cert in Curl Context) | [optional] 
**KeytabData** | **string** | Base64-encoded content of a valid keytab file, containing the service account&#39;s entry. | [optional] 
**Krb5ConfData** | **string** | Base64-encoded content of a valid krb5.conf file, specifying the settings and parameters required for Kerberos authentication. | [optional] 
**LegacySigningAlgName** | **bool** | Set this option to output legacy (&#39;ssh-rsa-cert-v01@openssh.com&#39;) signing algorithm name in the certificate. | [optional] 
**OciAuthType** | **string** | The type of the OCI configuration to use [instance/apikey/resource] (relevant only for access-type&#x3D;oci) | [optional] [default to "apikey"]
**OciGroupOcid** | **List&lt;string&gt;** | A list of Oracle Cloud IDs groups (relevant only for access-type&#x3D;oci) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

