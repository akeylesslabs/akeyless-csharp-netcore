# akeyless.Model.CreateAWSTarget
createAWSTarget is a command that creates a new target. [Deprecated: Use target-create-aws command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessKey** | **string** | AWS secret access key | 
**AccessKeyId** | **string** | AWS access key ID | 
**Comment** | **string** | Deprecated - use description | [optional] 
**Description** | **string** | Description of the object | [optional] 
**GenerateExternalId** | **bool** | A unique auto-generated value used in your AWS account when configuring your AWS IAM role to securely delegate access to Akeyless. Relevant only when using GW cloud ID | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**Region** | **string** | AWS region | [optional] [default to "us-east-2"]
**RoleArn** | **string** | AWS IAM role identifier that Gateway will assume in your AWS account, relevant only when using external ID | [optional] 
**SessionToken** | **string** | Required only for temporary security credentials retrieved using STS | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseGwCloudIdentity** | **bool** | Use the GW&#39;s Cloud IAM | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

