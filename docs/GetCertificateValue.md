# akeyless.Model.GetCertificateValue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertIssuerName** | **string** | The parent PKI Certificate Issuer&#39;s name of the certificate, required when used with display-id and token | [optional] 
**DisplayId** | **string** | Certificate display ID | [optional] 
**Format** | **string** | Format to download the certificate in [pem/pfx/jks], pfx/jks require a password | [optional] [default to "pem"]
**IgnoreCache** | **string** | Retrieve the Secret value without checking the Gateway&#39;s cache [true/false]. This flag is only relevant when using the RestAPI | [optional] [default to "false"]
**IncludePrivateKey** | **bool** | If set, includes the private key in the pfx/jks file, only relevant when format is pfx or jks | [optional] 
**IssuanceToken** | **string** | Token for getting the issued certificate | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**LeafOnly** | **bool** | If set, downloads only the leaf certificate instead of the full chain, only available for certificates issued with split certificate chain enabled | [optional] 
**Name** | **string** | Certificate name | [optional] 
**Password** | **string** | Password to protect the pfx/jks file, required when format is pfx or jks | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**VarVersion** | **int** | Certificate version | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

