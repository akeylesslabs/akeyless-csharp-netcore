# akeyless.Model.ImportPasswords
importPasswords is a command that import passwords

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "personal"]
**Format** | **string** | Password format type [LastPass/Chrome/Firefox] | [optional] [default to "LastPass"]
**ImportPath** | **string** | File path | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**ProtectionKey** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**TargetFolder** | **string** | Target folder for imported passwords | [optional] [default to "/"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UpdateMode** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

