# akeyless.Model.GatewayUpdateRemoteAccessRdpRecordings
gatewayUpdateRemoteAccessRdpRecordings is a command that update remote access rdp recording config

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AwsStorageAccessKeyId** | **string** | AWS access key id. For more information refer to https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_access-keys.html | [optional] 
**AwsStorageBucketName** | **string** | The AWS bucket name. For more information refer to https://docs.aws.amazon.com/s3/ | [optional] 
**AwsStorageBucketPrefix** | **string** | The folder name in S3 bucket. For more information refer to https://docs.aws.amazon.com/s3/ | [optional] 
**AwsStorageRegion** | **string** | The region where the storage is located | [optional] 
**AwsStorageSecretAccessKey** | **string** | AWS secret access key. For more information refer to https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_access-keys.html | [optional] 
**AzureStorageAccountName** | **string** | Azure account name. For more information refer to https://learn.microsoft.com/en-us/azure/storage/common/storage-account-overview | [optional] 
**AzureStorageClientId** | **string** | Azure client id. For more information refer to https://learn.microsoft.com/en-us/azure/storage/common/storage-account-get-info?tabs&#x3D;portal | [optional] 
**AzureStorageClientSecret** | **string** | Azure client secret. For more information refer to https://learn.microsoft.com/en-us/azure/storage/common/storage-account-get-info?tabs&#x3D;portal | [optional] 
**AzureStorageContainerName** | **string** | Azure container name. For more information refer to https://learn.microsoft.com/en-us/rest/api/storageservices/naming-and-referencing-containers- -blobs- -and-metadata | [optional] 
**AzureStorageTenantId** | **string** | Azure tenant id. For more information refer to https://learn.microsoft.com/en-us/entra/fundamentals/how-to-find-tenant | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**RdpSessionRecording** | **string** | Enable recording of rdp session [true/false] | [optional] 
**RdpSessionStorage** | **string** | Rdp session recording storage destination [local/aws/azure] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

