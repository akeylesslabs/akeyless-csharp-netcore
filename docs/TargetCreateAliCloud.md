# akeyless.Model.TargetCreateAliCloud

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessKey** | **string** | AliCloud RAM access key secret | [optional] 
**AccessKeyId** | **string** | AliCloud RAM access key ID | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**GenerateExternalId** | **bool** | A unique auto-generated value used in your AliCloud account when configuring the RAM role trust policy to securely delegate access to Akeyless. Relevant only when using GW cloud ID | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**LockOnRead** | **string** | Lock this secret after each successful value read | [optional] 
**LockTtl** | **string** | Lock TTL in minutes | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**Region** | **string** | AliCloud region. Selects the regional STS endpoint. If empty, the global STS endpoint is used | [optional] 
**RoleArn** | **string** | AliCloud RAM role ARN that the Gateway will assume in your AliCloud account (acs:ram::&lt;account-id&gt;:role/&lt;role-name&gt;), relevant only when using external ID | [optional] 
**RotateOnUnlock** | **string** | Rotate this secret after it is unlocked | [optional] 
**SessionToken** | **string** | Required only for temporary security credentials retrieved using STS | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseGwCloudIdentity** | **bool** | Use the Gateway cloud identity | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

