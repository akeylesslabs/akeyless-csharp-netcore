# akeyless.Model.RotatedSecretUpdateSnowflake

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**AuthenticationCredentials** | **string** | The credentials to connect with use-user-creds/use-target-creds | [optional] [default to "use-user-creds"]
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation [true/false] | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] [default to "default_metadata"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Rotated secret name | 
**NewName** | **string** | New item name | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**PrivateKey** | **string** | RSA Private key (base64 encoded) to rotate (relevant only for rotator-type&#x3D;key) | [optional] 
**PrivateKeyFileName** | **string** | The path to the file containing the private key (relevant only for rotator-type&#x3D;key) | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**RotatedPassword** | **string** | rotated-username password (relevant only for rotator-type&#x3D;password) | [optional] 
**RotatedUsername** | **string** | username to be rotated, if selected use-self-creds at rotator-creds-type, this username will try to rotate it&#39;s own password, if use-target-creds is selected, target credentials will be use to rotate the rotated-password (relevant only for rotator-type&#x3D;password or rotator-type&#x3D;key) | [optional] 
**RotationEventIn** | **List&lt;string&gt;** | How many days before the rotation of the item would you like to be notified | [optional] 
**RotationHour** | **int** | The Hour of the rotation in UTC | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (1-365) | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

