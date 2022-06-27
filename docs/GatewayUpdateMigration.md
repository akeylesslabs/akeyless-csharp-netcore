# akeyless.Model.GatewayUpdateMigration
gatewayUpdateMigration is a command that update migration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AwsKey** | **string** | AWS Secret Access Key (relevant only for AWS migration) | [optional] 
**AwsKeyId** | **string** | AWS Access Key ID with sufficient permissions to get all secrets, e.g. &#39;arn:aws:secretsmanager:[Region]:[AccountId]:secret:[/path/to/secrets/_*]&#39; (relevant only for AWS migration) | [optional] 
**AwsRegion** | **string** | AWS region of the required Secrets Manager (relevant only for AWS migration) | [optional] 
**AzureClientId** | **string** | Azure Key Vault Access client ID, should be Azure AD App with a service principal (relevant only for Azure Key Vault migration) | [optional] 
**AzureKvName** | **string** | Azure Key Vault Name (relevant only for Azure Key Vault migration) | [optional] 
**AzureSecret** | **string** | Azure Key Vault secret (relevant only for Azure Key Vault migration) | [optional] 
**AzureTenantId** | **string** | Azure Key Vault Access tenant ID (relevant only for Azure Key Vault migration) | [optional] 
**GcpKey** | **string** | Base64-encoded GCP Service Account private key text with sufficient permissions to Secrets Manager, Minimum required permission is Secret Manager Secret Accessor, e.g. &#39;roles/secretmanager.secretAccessor&#39; (relevant only for GCP migration) | [optional] 
**HashiJson** | **string** | Import secret key as json value or independent secrets (relevant only for HasiCorp Vault migration) | [optional] 
**HashiNs** | **List&lt;string&gt;** | HashiCorp Vault Namespaces is a comma-separated list of namespaces which need to be imported into Akeyless Vault. For every provided namespace, all its child namespaces are imported as well, e.g. nmsp/subnmsp1/subnmsp2,nmsp/anothernmsp. By default, import all namespaces (relevant only for HasiCorp Vault migration) | [optional] 
**HashiToken** | **string** | HashiCorp Vault access token with sufficient permissions to preform list &amp; read operations on secrets objects (relevant only for HasiCorp Vault migration) | [optional] 
**HashiUrl** | **string** | HashiCorp Vault API URL, e.g. https://vault-mgr01:8200 (relevant only for HasiCorp Vault migration) | [optional] 
**Id** | **string** | Migration ID (Can be retrieved with gateway-list-migration command) | [optional] 
**K8sCaCertificate** | **List&lt;int&gt;** | For Certificate Authentication method K8s Cluster CA certificate (relevant only for K8s migration with Certificate Authentication method) | [optional] 
**K8sClientCertificate** | **List&lt;int&gt;** | K8s Client certificate with sufficient permission to list and get secrets in the namespace(s) you selected (relevant only for K8s migration with Certificate Authentication method) | [optional] 
**K8sClientKey** | **List&lt;int&gt;** | K8s Client key (relevant only for K8s migration with Certificate Authentication method) | [optional] 
**K8sNamespace** | **string** | K8s Namespace, Use this field to import secrets from a particular namespace only. By default, the secrets are imported from all namespaces (relevant only for K8s migration) | [optional] 
**K8sPassword** | **string** | K8s Client password (relevant only for K8s migration with Password Authentication method) | [optional] 
**K8sSkipSystem** | **bool** | K8s Skip Control Plane Secrets, This option allows to avoid importing secrets from system namespaces (relevant only for K8s migration) | [optional] 
**K8sToken** | **string** | For Token Authentication method K8s Bearer Token with sufficient permission to list and get secrets in the namespace(s) you selected (relevant only for K8s migration with Token Authentication method) | [optional] 
**K8sUrl** | **string** | K8s API Server URL, e.g. https://k8s-api.mycompany.com:6443 (relevant only for K8s migration) | [optional] 
**K8sUsername** | **string** | For Password Authentication method K8s Client username with sufficient permission to list and get secrets in the namespace(s) you selected (relevant only for K8s migration with Password Authentication method) | [optional] 
**Name** | **string** | Migration name | [optional] 
**NewName** | **string** | New migration name | [optional] 
**ProtectionKey** | **string** | The name of the key that protects the classic key value (if empty, the account default key will be used) | [optional] 
**TargetLocation** | **string** | Target location in Akeyless for imported secrets | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

