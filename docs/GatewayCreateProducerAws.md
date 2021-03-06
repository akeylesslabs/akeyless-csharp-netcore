# akeyless.Model.GatewayCreateProducerAws
gatewayCreateProducerAws is a command that creates aws producer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessMode** | **string** |  | [optional] 
**AdminRotationIntervalDays** | **long** | Admin credentials rotation interval (days) | [optional] [default to 0]
**AwsAccessKeyId** | **string** | Access Key ID | [optional] 
**AwsAccessSecretKey** | **string** | Secret Access Key | [optional] 
**AwsRoleArns** | **string** | AWS Role ARNs to be used in the Assume Role operation (relevant only for assume_role mode) | [optional] 
**AwsUserConsoleAccess** | **bool** | AWS User console access | [optional] [default to false]
**AwsUserGroups** | **string** | AWS User groups | [optional] 
**AwsUserPolicies** | **string** | AWS User policies | [optional] 
**AwsUserProgrammaticAccess** | **bool** | AWS User programmatic access | [optional] [default to true]
**EnableAdminRotation** | **bool** | Automatic admin credentials rotation | [optional] [default to false]
**Name** | **string** | Producer name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Region** | **string** | Region | [optional] [default to "us-east-2"]
**SecureAccessAwsAccountId** | **string** |  | [optional] 
**SecureAccessAwsNativeCli** | **bool** |  | [optional] 
**SecureAccessBastionIssuer** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessWebBrowsing** | **bool** |  | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

