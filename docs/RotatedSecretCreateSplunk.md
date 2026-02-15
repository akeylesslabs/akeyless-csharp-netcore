# akeyless.Model.RotatedSecretCreateSplunk
rotatedSecretCreateSplunk is a command that creates a rotated secret for a Splunk target. Currently we support target-rotator behavior (rotate credentials on the target itself).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Audience** | **string** | Token audience for Splunk token creation (required for rotator-type&#x3D;token) | [optional] 
**AuthenticationCredentials** | **string** | The credentials to connect with use-user-creds/use-target-creds | [optional] [default to "use-user-creds"]
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation [true/false] | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**ExpirationDate** | **string** | Token expiration date in YYYY-MM-DD format (required for rotator-type&#x3D;token when manual rotation is selected and no existing token is provided). Time will be set to 00:00 UTC. | [optional] 
**HecToken** | **string** | Current Splunk HEC token value to store (relevant only for rotator-type&#x3D;hec-token). If not provided, a new HEC input will be created in Splunk. | [optional] 
**HecTokenName** | **string** | Splunk HEC input name to manage  (required for rotator-type&#x3D;hec-token) | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Rotated secret name | 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**RotatedPassword** | **string** | rotated-username password (relevant only for rotator-type&#x3D;password) | [optional] 
**RotatedUsername** | **string** | username to be rotated, if selected use-self-creds at rotator-creds-type, this username will try to rotate it&#39;s own password, if use-target-creds is selected, target credentials will be use to rotate the rotated-password (relevant only for rotator-type&#x3D;password) | [optional] 
**RotationEventIn** | **List&lt;string&gt;** | How many days before the rotation of the item would you like to be notified | [optional] 
**RotationHour** | **int** | The Hour of the rotation in UTC | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (1-365) | [optional] 
**RotatorType** | **string** | The rotator type. options: [target/password/token/hec-token] | 
**SplunkToken** | **string** | Current Splunk authentication token to store (relevant only for rotator-type&#x3D;token). If not provided, a new token will be created in Splunk. | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | The target name to associate | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**TokenOwner** | **string** | Splunk token owner username (relevant only for rotator-type&#x3D;token) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

