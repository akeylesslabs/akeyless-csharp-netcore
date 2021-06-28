# akeyless.Model.UpdateEKSTarget
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comment** | **string** | Comment about the target | [optional] 
**EksAccessKeyId** | **string** | Access Key ID | 
**EksClusterCert** | **string** | EKS cluster CA certificate | 
**EksClusterEndpoint** | **string** | EKS cluster URL endpoint | 
**EksClusterName** | **string** | EKS cluster name | 
**EksRegion** | **string** | Region | [optional] [default to "us-east-2"]
**EksSecretAccessKey** | **string** | Secret Access Key | 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | Target name | 
**NewName** | **string** | New target name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UpdateVersion** | **bool** | Create new version for the target | [optional] [default to false]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

