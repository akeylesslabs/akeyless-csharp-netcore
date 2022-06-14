# akeyless.Model.GatewayUpdateMigration
gatewayUpdateMigration is a command that update migration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AwsKey** | **string** | AWS Secret Access Key | [optional] 
**AwsKeyId** | **string** | AWS Access Key ID | [optional] 
**AwsRegion** | **string** | AWS region | [optional] 
**AzureClientId** | **string** | Azure KV Access client ID | [optional] 
**AzureKvName** | **string** | Azure Key Vault Name | [optional] 
**AzureSecret** | **string** | Azure KV secret | [optional] 
**AzureTenantId** | **string** | Azure KV Access tenant ID | [optional] 
**GcpKey** | **string** | Base64-encoded service account private key text | [optional] 
**HashiJson** | **string** | Import secret key as json value or independent secrets | [optional] 
**HashiNs** | **List&lt;string&gt;** | Hashi namespaces | [optional] 
**HashiToken** | **string** | Hashi token | [optional] 
**HashiUrl** | **string** | Hashi url | [optional] 
**Id** | **string** | Migration ID | [optional] 
**K8sCaCertificate** | **List&lt;int&gt;** | For Certificate Authentication method K8s Cluster CA certificate | [optional] 
**K8sClientCertificate** | **List&lt;int&gt;** | K8s Client certificate | [optional] 
**K8sClientKey** | **List&lt;int&gt;** | K8s Client key | [optional] 
**K8sNamespace** | **string** | K8s Namespace | [optional] 
**K8sPassword** | **string** | K8s client password | [optional] 
**K8sSkipSystem** | **bool** | K8s Skip Control Plane Secrets | [optional] 
**K8sToken** | **string** | For Token Authentication method K8s Bearer Token | [optional] 
**K8sUrl** | **string** | K8s Endpoint URL | [optional] 
**K8sUsername** | **string** | For Password Authentication method K8s client username | [optional] 
**Name** | **string** | Migration name | 
**ProtectionKey** | **string** | The name of the key that protects the classic key value (if empty, the account default key will be used) | [optional] 
**TargetLocation** | **string** | Target location in Akeyless for imported secrets | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **string** | Migration type, can be: hashi/aws/gcp/k8s/azure_kv | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

