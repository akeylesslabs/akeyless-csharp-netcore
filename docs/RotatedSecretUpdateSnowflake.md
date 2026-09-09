# akeyless.Model.RotatedSecretUpdateSnowflake

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**AraEnabled** | **bool** | Enable or disable Agentic Runtime Authority rule enforcement for this item. When false, user-defined input/output rules are stored but not enforced; the base security validation still runs.  AraEnabled is tri-state (nil/true/false), not a plain bool: it self-encodes its wire value (see akl.OptionalBool) so an explicit false survives the curl-proxy relay instead of being dropped like a default-false bool flag. | [optional] 
**AuthenticationCredentials** | **string** | The credentials to connect with use-user-creds/use-target-creds | [optional] [default to "use-user-creds"]
**AutoRotate** | **string** |  | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] [default to "default_metadata"]
**EnableAgenticRuntimeAuthority** | **bool** | EnableAra is the documented spelling of AraEnabled. Both set the same field; - -ara-enabled shipped first and stays as an undocumented alias so existing scripts and the Terraform provider keep working. | [optional] 
**EnableAiQuorum** | **bool** | Turns on AI Quorum checks for this item. | [optional] 
**InputRule** | **List&lt;string&gt;** | Agentic input rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Sanitize input) | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** |  | [optional] 
**LockOnRead** | **string** | Lock this secret after each successful value read | [optional] 
**LockTtl** | **string** | Lock TTL in minutes | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Rotated secret name | 
**NewName** | **string** | New item name | [optional] 
**OutputRule** | **List&lt;string&gt;** | Agentic output rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Mask secrets) | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**PrivateKey** | **string** | RSA Private key (base64 encoded) to rotate (relevant only for rotator-type&#x3D;key) | [optional] 
**PrivateKeyFileName** | **string** | The path to the file containing the private key (relevant only for rotator-type&#x3D;key) | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**RotateOnUnlock** | **string** | Rotate this secret after it is unlocked | [optional] 
**RotatedPassword** | **string** | rotated-username password (relevant only for rotator-type&#x3D;password) | [optional] 
**RotatedUsername** | **string** | username to be rotated, if selected use-self-creds at rotator-creds-type, this username will try to rotate it&#39;s own password, if use-target-creds is selected, target credentials will be use to rotate the rotated-password (relevant only for rotator-type&#x3D;password or rotator-type&#x3D;key) | [optional] 
**RotationEventIn** | **List&lt;string&gt;** | How many days before the rotation of the item would you like to be notified | [optional] 
**RotationHour** | **int** |  | [optional] 
**RotationInterval** | **string** |  | [optional] 
**RotationStatement** | **string** | Snowflake rotation statement | [optional] 
**SkipDryRun** | **string** | If set, dry-run will be skipped | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseCapitalLetters** | **string** | Specifies whether the generated temporary password must contain at least one uppercase character from the ISO basic Latin alphabet (A to Z). [true/false] | [optional] 
**UseLowerLetters** | **string** | Specifies whether the generated temporary password must contain at least one lowercase character from the ISO basic Latin alphabet (a to z). [true/false] | [optional] 
**UseNumbers** | **string** | Specifies whether the generated temporary password must contain at least one numeric character (0 to 9). [true/false] | [optional] 
**UseSpecialCharacters** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

