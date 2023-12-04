# akeyless.Model.GetCertificateValue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CertIssuerName** | **string** | The parent PKI Certificate Issuer&#39;s name of the certificate, required when used with display-id and token | [optional] 
**DisplayId** | **string** | Certificate display ID | [optional] 
**IgnoreCache** | **string** | Retrieve the Secret value without checking the Gateway&#39;s cache [true/false]. This flag is only relevant when using the RestAPI | [optional] [default to "false"]
**IssuanceToken** | **string** | Token for getting the issued certificate | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Certificate name | [default to "dummy_certificate_name"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**_Version** | **int** | Certificate version | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

