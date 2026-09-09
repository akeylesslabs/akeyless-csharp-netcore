# akeyless.Model.CertificateChainInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AutoRenewCertificate** | **bool** |  | [optional] 
**CertificateChain** | [**List&lt;CertificateInfo&gt;**](CertificateInfo.md) |  | [optional] 
**CertificateFormat** | **string** |  | [optional] 
**CertificateHasPrivateKey** | **bool** |  | [optional] 
**CertificateIssuerGwClusterId** | **long** |  | [optional] 
**CertificateIssuerGwClusterUrl** | **string** |  | [optional] 
**CertificateIssuerItemId** | **long** |  | [optional] 
**CertificateIssuerName** | **string** |  | [optional] 
**CertificatePem** | **string** |  | [optional] 
**CertificateStatus** | **string** |  | [optional] 
**CommonName** | **string** |  | [optional] 
**CsrPem** | **string** | CSRPEM contains the PEM-encoded CSR for pending certificates (HTTP-01 challenge) | [optional] 
**ErrorMessage** | **string** |  | [optional] 
**ExpirationDate** | **DateTime** |  | [optional] 
**ExpirationEvents** | [**List&lt;CertificateExpirationEvent&gt;**](CertificateExpirationEvent.md) |  | [optional] 
**ExternalCaId** | [**NullString**](NullString.md) |  | [optional] 
**IssuanceStatus** | **string** |  | [optional] 
**LeafCertificatePem** | **string** | LeafCertificatePem contains only the leaf certificate, derived from CertificatePem. Populated only when the certificate was issued with SplitCertificateChain enabled. | [optional] 
**NotBefore** | **DateTime** |  | [optional] 
**RenewBeforeExpirationInDays** | **long** |  | [optional] 
**SplitCertificateChain** | **bool** | SplitCertificateChain reflects whether this certificate was issued while its PKI Cert Issuer had split-certificate-chain enabled. When true, LeafCertificatePem is populated in addition to CertificatePem (which always holds the full chain). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

