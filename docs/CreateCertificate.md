# akeyless.Model.CreateCertificate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertificateData** | **string** | Content of the certificate PEM in a Base64 format. | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**ExpirationEventIn** | **List&lt;string&gt;** | How many days before the expiration of the certificate would you like to be notified. | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key to use to encrypt the certificate&#39;s key (if empty, the account default protectionKey key will be used) | [optional] 
**KeyData** | **string** | Content of the certificate&#39;s private key PEM in a Base64 format. | [optional] 
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | Certificate name | 
**Tags** | **List&lt;string&gt;** | List of the tags attached to this certificate | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
