# akeyless.Model.RotatedSecretProvisionCreate
provision-on-rotation provisions this target after a successful key rotation and is only supported for rotator type key-rotator.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Rotated secret name | 
**PrivateKeyPassphrase** | **string** | Optional passphrase used to encrypt the private key file on the remote host | [optional] 
**PrivateKeyRemotePath** | **string** | Remote path for the private key (required when provision-keys is private-key on host targets) | [optional] 
**ProvisionKeys** | **string** | Keys to provision: public-key (default) or private-key (also pushes the public key) | [optional] 
**ProvisionOnRotation** | **bool** | When true, provision keys to this target after a successful key rotation. Only supported for rotator type key-rotator. Defaults to true. Set false to turn it off. | [optional] 
**PublicKeyRemotePath** | **string** | Remote path for the public key (defaults from the rotated secret) | [optional] 
**TargetName** | **string** | Target name to provision keys to (must differ from the rotation target) | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

