# akeyless.Model.UpdateAccountSettings

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | **string** | Address | [optional] 
**City** | **string** | City | [optional] 
**CompanyName** | **string** | Company name | [optional] 
**Country** | **string** | Country | [optional] 
**DefaultKeyName** | **string** | Set the account default key based on the DFC key name. Use \&quot;set-original-akeyless-default-key\&quot; to revert to using the original default key of the account. | [optional] 
**DefaultShareLinkTtlMinutes** | **string** | Set the default ttl in minutes for sharing item number between 60 and 43200 | [optional] 
**DefaultVersioning** | **string** | If set to true, new versions is enabled by default | [optional] 
**DpEnableClassicKeyProtection** | **string** | Set to update protection with classic keys state [true/false] | [optional] 
**DynamicSecretMaxTtl** | **long** | Set the maximum ttl for dynamic secrets | [optional] 
**DynamicSecretMaxTtlEnable** | **string** | Set a maximum ttl for dynamic secrets [true/false] | [optional] 
**ForceNewVersions** | **string** | If set to true, new version will be created on update | [optional] 
**InvalidCharacters** | **string** | Characters that cannot be used for items/targets/roles/auths/event_forwarder names. Empty string will enforce nothing. | [optional] [default to "notReceivedInvalidCharacter"]
**ItemType** | **string** | VersionSettingsObjectType defines object types for account version settings | [optional] 
**ItemsDeletionProtection** | **string** | Set or unset the default behaviour of items deletion protection [true/false] | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**JwtTtlDefault** | **long** | Default ttl | [optional] 
**JwtTtlMax** | **long** | Maximum ttl | [optional] 
**JwtTtlMin** | **long** | Minimum ttl | [optional] 
**LockDefaultKey** | **string** | Lock the account&#39;s default protection key, if set - users will not be able to use a different protection key, relevant only if default-key-name is configured [true/false] | [optional] 
**MaxRotationInterval** | **int** | Set the maximum rotation interval for rotated secrets auto rotation settings | [optional] 
**MaxRotationIntervalEnable** | **string** | Set a maximum rotation interval for rotated secrets auto rotation settings [true/false] | [optional] 
**MaxVersions** | **string** | Max versions | [optional] 
**PasswordLength** | **long** | Password length between 5 - to 50 characters | [optional] 
**Phone** | **string** | Phone number | [optional] 
**PostalCode** | **string** | Postal code | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UsageEventEnable** | **string** | Enable event for objects that have not been used or changed [true/false] | [optional] 
**UsageEventInterval** | **long** | Interval by days for unused objects. Default and minimum interval is 90 days | [optional] 
**UsageEventObjectType** | **string** | Usage event is supported for auth method or secrets-and-keys [auth/item] | [optional] 
**UseLowerLetters** | **string** | Password must contain lower case letters [true/false] | [optional] 
**UseNumbers** | **string** | Password must contain numbers [true/false] | [optional] 
**UseSpecialCharacters** | **string** | Password must contain special characters [true/false] | [optional] 
**UseCapitalLetters** | **string** | Password must contain capital letters [true/false] | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

