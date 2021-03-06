# akeyless.Model.EncryptFile
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EncryptionContext** | **Dictionary&lt;string, string&gt;** | name-value pair that specifies the encryption context to be used for authenticated encryption. If used here, the same value must be supplied to the decrypt command or decryption will fail | [optional] 
**In** | **string** | Path to the file to be encrypted. If not provided, the content will be taken from stdin | 
**KeyName** | **string** | The name of the key to use in the encryption process | 
**Out** | **string** | Path to the output file. If not provided, the output will be sent to stdout | [optional] 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

