# akeyless.Model.DynamicSecretUpdateEks
dynamicSecretUpdateEks is a command that updates eks dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EksAccessKeyId** | **string** | Access Key ID | [optional] 
**EksAssumeRole** | **string** | IAM assume role | [optional] 
**EksClusterCaCert** | **string** | EKS cluster CA certificate | [optional] 
**EksClusterEndpoint** | **string** | EKS cluster URL endpoint | [optional] 
**EksClusterName** | **string** | EKS cluster name | [optional] 
**EksRegion** | **string** | Region | [optional] [default to "us-east-2"]
**EksSecretAccessKey** | **string** | Secret Access Key | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret new name | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SecureAccessAllowPortForwading** | **bool** | Enable Port forwarding while using CLI access | [optional] 
**SecureAccessBastionIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Bastion | [optional] 
**SecureAccessClusterEndpoint** | **string** | The K8s cluster endpoint URL | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "15m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

