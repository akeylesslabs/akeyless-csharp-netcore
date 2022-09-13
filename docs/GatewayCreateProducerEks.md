# akeyless.Model.GatewayCreateProducerEks
gatewayCreateProducerEks is a command that creates eks producer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteProtection** | **string** | Protection from accidental deletion of this item | [optional] 
**EksAccessKeyId** | **string** | Access Key ID | [optional] 
**EksAssumeRole** | **string** | IAM assume role | [optional] 
**EksClusterCaCert** | **string** | EKS cluster CA certificate | [optional] 
**EksClusterEndpoint** | **string** | EKS cluster URL endpoint | [optional] 
**EksClusterName** | **string** | EKS cluster name | [optional] 
**EksRegion** | **string** | Region | [optional] [default to "us-east-2"]
**EksSecretAccessKey** | **string** | Secret Access Key | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] 
**Name** | **string** | Producer name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessAllowPortForwading** | **bool** |  | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessClusterEndpoint** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessWeb** | **bool** |  | [optional] 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this secret | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

