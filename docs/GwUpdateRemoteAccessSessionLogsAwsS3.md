# akeyless.Model.GwUpdateRemoteAccessSessionLogsAwsS3
gwUpdateRemoteAccessSessionLogsAwsS3 is a command that updates session log forwarding config (aws-s3 target)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** | AWS access id relevant for access_key auth-type | [optional] 
**AccessKey** | **string** | AWS access key relevant for access_key auth-type | [optional] 
**AuthType** | **string** | AWS auth type [access_key/cloud_id/assume_role] | [optional] 
**BucketName** | **string** | AWS S3 bucket name | [optional] 
**Enable** | **string** | Enable Log Forwarding [true/false] | [optional] [default to "true"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**LogFolder** | **string** | AWS S3 destination folder for logs | [optional] [default to "use-existing"]
**OutputFormat** | **string** | Logs format [text/json] | [optional] [default to "text"]
**PullInterval** | **string** | Pull interval in seconds | [optional] [default to "10"]
**Region** | **string** | AWS region | [optional] 
**RoleArn** | **string** | AWS role arn relevant for assume_role auth-type | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

