# akeyless.Model.UpdateCertificateValue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**CertificateData** | **string** | Content of the certificate in a Base64 format. | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**ExpirationEventIn** | **List&lt;string&gt;** | How many days before the expiration of the certificate would you like to be notified. | [optional] 
**Format** | **string** | CertificateFormat of the certificate and private key, possible values: cer,crt,pem,pfx,p12. Required when passing inline certificate content with - -certificate-data or - -key-data, otherwise format is derived from the file extension. | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key to use to encrypt the certificate&#39;s key (if empty, the account default protectionKey key will be used) | [optional] 
**KeyData** | **string** | Content of the certificate&#39;s private key in a Base64 format. | [optional] 
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | Certificate name | 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

