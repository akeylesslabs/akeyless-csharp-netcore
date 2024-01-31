# akeyless.Model.SignPKCS1
signPKCS1 is a command that calculates the signature of hashed data using RSASSA-PKCS1-V1_5-SIGN from RSA PKCS#1 v1.5.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayId** | **string** | The display id of the key to use in the signing process | [optional] 
**HashFunction** | **string** | HashFunction defines the hash function (e.g. sha-256) | [optional] 
**InputFormat** | **string** | Select default assumed format for the plaintext message. Currently supported options: [base64] | [optional] 
**ItemId** | **long** | The item id of the key to use in the signing process | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyName** | **string** | The name of the RSA key to use in the signing process | [optional] 
**Message** | **string** | The message to be signed | 
**Prehashed** | **bool** | Markes that the message is already hashed | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**_Version** | **int** | The version of the key to use for signing | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

