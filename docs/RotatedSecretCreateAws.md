# akeyless.Model.RotatedSecretCreateAws

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiId** | **string** | API ID to rotate (relevant only for rotator-type&#x3D;api-key) | [optional] 
**ApiKey** | **string** | API key to rotate (relevant only for rotator-type&#x3D;api-key) | [optional] 
**AuthenticationCredentials** | **string** | The credentials to connect with use-user-creds/use-target-creds | [optional] [default to "use-user-creds"]
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation [true/false] | [optional] 
**AwsRegion** | **string** | Aws Region | [optional] [default to "us-east-2"]
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**GraceRotation** | **string** | Create a new access key without deleting the old key from AWS for backup (relevant only for AWS) [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Rotated secret name | 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**RotateAfterDisconnect** | **string** | Rotate the value of the secret after SRA session ends [true/false] | [optional] [default to "false"]
**RotationEventIn** | **List&lt;string&gt;** | How many days before the rotation of the item would you like to be notified | [optional] 
**RotationHour** | **int** | The Hour of the rotation in UTC | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (1-365) | [optional] 
**RotatorType** | **string** | The rotator type. options: [target/api-key] | 
**SecureAccessAwsAccountId** | **string** | The AWS account id | [optional] 
**SecureAccessAwsNativeCli** | **bool** | The AWS native cli | [optional] 
**SecureAccessBastionIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Bastion | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

