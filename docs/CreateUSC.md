# akeyless.Model.CreateUSC
CreateUSC is a command that creates a Universal Secrets Connector

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AzureKvName** | **string** | Azure Key Vault name (Relevant only for Azure targets) | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the Universal Secrets Connector | [optional] 
**GcpProjectId** | **string** | GCP Project ID (Relevant only for GCP targets) | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**K8sNamespace** | **string** | K8s namespace (Relevant to Kubernetes targets) | [optional] 
**Name** | **string** | Universal Secrets Connector name | 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this Universal Secrets Connector | [optional] 
**TargetToAssociate** | **string** | Target Universal Secrets Connector to connect | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UscPrefix** | **string** | Prefix for all secrets created in AWS Secrets Manager | [optional] 
**UsePrefixAsFilter** | **string** | Whether to filter the USC secret list using the specified usc-prefix [true/false] | [optional] [default to "false"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

