# akeyless.Model.UploadRSA

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alg** | **string** | Key type. options: [RSA1024, RSA2048, RSA3072, RSA4096] | 
**CertFileData** | **string** | Certificate in a PEM format. | [optional] 
**CustomerFrgId** | **string** | The customer fragment ID that will be used to split the key (if empty, the key will be created independently of a customer fragment) | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | Name of key to be created | 
**Overwrite** | **string** | When the overwrite flag is set, this command will only update an existing key [true/false] | [optional] [default to "false"]
**RsaFileData** | **string** | RSA private key data, base64 encoded | [optional] 
**SplitLevel** | **long** | The number of fragments that the item will be split into | [optional] [default to 3]
**Tag** | **List&lt;string&gt;** | List of the tags attached to this key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

