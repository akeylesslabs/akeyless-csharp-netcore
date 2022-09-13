# akeyless.Model.UploadPKCS12

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerFrgId** | **string** | The customer fragment ID that will be used to split the key (if empty, the key will be created independently of a customer fragment) | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item | [optional] 
**In** | **string** | PKCS#12 input file (private key and certificate only) | 
**Json** | **bool** | Set output format to JSON | [optional] 
**Metadata** | **string** | A metadata about the key | [optional] 
**Name** | **string** | Name of key to be created | 
**Passphrase** | **string** | Passphrase to unlock the pkcs#12 bundle | 
**SplitLevel** | **long** | The number of fragments that the item will be split into | [optional] [default to 2]
**Tag** | **List&lt;string&gt;** | List of the tags attached to this key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

