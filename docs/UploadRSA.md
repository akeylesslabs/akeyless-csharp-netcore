# akeyless.Model.UploadRSA

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** | Key type. options: [RSA1024, RSA2048, RSA3072, RSA4096] | 
**CertFileData** | **string** | Certificate in a PEM format. | [optional] 
**CustomerFrgId** | **string** | The customer fragment ID that will be used to split the key (if empty, the key will be created independently of a customer fragment) | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item | [optional] 
**Metadata** | **string** | A metadata about the key | [optional] 
**Name** | **string** | Name of key to be created | 
**RsaFileData** | **string** | RSA private key data, base64 encoded | [optional] 
**SplitLevel** | **long** | The number of fragments that the item will be split into | [optional] [default to 2]
**Tag** | **List&lt;string&gt;** | List of the tags attached to this key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

