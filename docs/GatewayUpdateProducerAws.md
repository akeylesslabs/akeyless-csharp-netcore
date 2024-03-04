# akeyless.Model.GatewayUpdateProducerAws
gatewayUpdateProducerAws is a command that Updates aws producer [Deprecated: Use dynamic-secret-update-aws command]

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
**AwsUserProgrammaticAccess** | **bool** | Enable AWS User programmatic access | [optional] [default to true]
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**EnableAdminRotation** | **bool** | Automatic admin credentials rotation | [optional] [default to false]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Region** | **string** | Region | [optional] [default to "us-east-2"]
**SecureAccessAwsAccountId** | **string** | The AWS account id | [optional] 
**SecureAccessAwsNativeCli** | **bool** | The AWS native cli | [optional] 
**SecureAccessBastionIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Bastion | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to true]
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless Web Access Bastion | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless Web Access Bastion | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

