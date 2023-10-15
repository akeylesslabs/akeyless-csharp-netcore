# akeyless.Model.AccountGeneralSettings
AccountGeneralSettings describes general settings for an account

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountDefaultKeyItemId** | **long** | AccountDefaultKeyItemID is the item ID of the DFC key item configured as the default protection key | [optional] 
**AccountDefaultKeyName** | **string** | AccountDefaultKeyName is the name of the DFC key item configured as the default key This is here simply for the response to include the item name in addition to the display ID so the client can properly show this to the user. It will not be saved to the DB, only the AccountDefaultKeyItemID will. | [optional] 
**DataProtectionSection** | [**DataProtectionSection**](DataProtectionSection.md) |  | [optional] 
**EnableRequestForAccess** | **bool** |  | [optional] 
**InvalidCharacters** | **string** | InvalidCharacters is the invalid characters for items/targets/roles/auths/notifier_forwarder naming convention | [optional] 
**LockDefaultKey** | **bool** | LockDefaultKey determines whether the configured default key can be updated by end-users on a per-request basis true - all requests use the configured default key false - every request can determine its protection key (default) nil - change nothing (every request can determine its protection key (default)) This parameter is only relevant if AccountDefaultKeyItemID is not empty | [optional] 
**PasswordPolicy** | [**PasswordPolicyInfo**](PasswordPolicyInfo.md) |  | [optional] 
**ProtectItemsByDefault** | **bool** |  | [optional] 
**SharingPolicy** | [**SharingPolicyInfo**](SharingPolicyInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

