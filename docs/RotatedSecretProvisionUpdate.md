# akeyless.Model.RotatedSecretProvisionUpdate
provision-on-rotation provisions this target after a successful key rotation and is only supported for rotator type key-rotator. Omit the flag to keep the current value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Rotated secret name | 
**NewTargetName** | **string** | New target name when retargeting the provisioning association | [optional] 
**PrivateKeyPassphrase** | **string** | Passphrase used to encrypt the private key file (omit to keep current; requires Read) | [optional] 
**PrivateKeyRemotePath** | **string** | Remote path for the private key (omit to keep current) | [optional] 
**ProvisionKeys** | **string** | Keys to provision: public-key or private-key (omit to keep current) | [optional] 
**ProvisionOnRotation** | **bool** | When true, provision keys to this target after a successful key rotation. Only supported for rotator type key-rotator. Omit to keep the current value. Set false to turn it off. | [optional] 
**PublicKeyRemotePath** | **string** | Remote path for the public key (omit to keep current) | [optional] 
**TargetName** | **string** | Target name of the provisioning association to update | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

