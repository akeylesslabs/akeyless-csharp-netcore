# akeyless.Model.DynamicSecretUpdateAws
dynamicSecretUpdateAws is a command that Updates aws dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessMode** | **string** |  | [optional] 
**AdminRotationIntervalDays** | **long** | Admin credentials rotation interval (days) | [optional] [default to 0]
**AwsAccessKeyId** | **string** | Access Key ID | [optional] 
**AwsAccessSecretKey** | **string** | Secret Access Key | [optional] 
**AwsExternalId** | **string** | The AWS External ID associated with the AWS role (relevant only for assume_role mode) | [optional] 
**AwsRoleArns** | **string** | AWS Role ARNs to be used in the Assume Role operation (relevant only for assume_role mode) | [optional] 
**AwsUserConsoleAccess** | **bool** | AWS User console access | [optional] [default to false]
**AwsUserGroups** | **string** | AWS User groups | [optional] 
**AwsUserPolicies** | **string** | AWS User policies | [optional] 
**AwsUserProgrammaticAccess** | **bool** | Enable AWS User programmatic access | [optional] [default to true]
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EnableAdminRotation** | **bool** | Automatic admin credentials rotation | [optional] [default to false]
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**Region** | **string** | Region | [optional] [default to "us-east-2"]
**SecureAccessAwsAccountId** | **string** | The AWS account id | [optional] 
**SecureAccessAwsNativeCli** | **bool** | The AWS native cli | [optional] 
**SecureAccessBastionIssuer** | **string** | Deprecated. use secure-access-certificate-issuer | [optional] 
**SecureAccessCertificateIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Secure Access | [optional] 
**SecureAccessDelay** | **long** | The delay duration, in seconds, to wait after generating just-in-time credentials. Accepted range: 0-120 seconds | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to true]
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless&#39;s Secure Remote Access (SRA) | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless&#39;s Secure Remote Access (SRA) | [optional] [default to false]
**SessionTags** | **string** | String of Key value session tags comma separated, relevant only for Assumed Role | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TransitiveTagKeys** | **string** | String of transitive tag keys space separated, relevant only for Assumed Role | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

