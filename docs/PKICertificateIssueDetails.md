# akeyless.Model.PKICertificateIssueDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AcmeEnabled** | **bool** |  | [optional] 
**AllowAnyName** | **bool** |  | [optional] 
**AllowCopyExtFromCsr** | **bool** |  | [optional] 
**AllowSubdomains** | **bool** |  | [optional] 
**AllowedDomainsList** | **List&lt;string&gt;** |  | [optional] 
**AllowedExtraExtensions** | **Dictionary&lt;string, List&lt;string&gt;&gt;** |  | [optional] 
**AllowedIpSans** | **List&lt;string&gt;** |  | [optional] 
**AllowedUriSans** | **List&lt;string&gt;** |  | [optional] 
**AutoRenewCertificate** | **bool** |  | [optional] 
**BasicConstraintsValidForNonCa** | **bool** |  | [optional] 
**CertificateAuthorityMode** | **string** |  | [optional] 
**ClientFlag** | **bool** |  | [optional] 
**CodeSigningFlag** | **bool** |  | [optional] 
**Country** | **List&lt;string&gt;** |  | [optional] 
**CreatePrivateCrl** | **bool** |  | [optional] 
**CreatePublicCrl** | **bool** |  | [optional] 
**DestinationPath** | **string** | DestinationPath is the destination to save generated certificates | [optional] 
**DisableWildcards** | **bool** |  | [optional] 
**EnforceHostnames** | **bool** |  | [optional] 
**ExpirationEvents** | [**List&lt;CertificateExpirationEvent&gt;**](CertificateExpirationEvent.md) | ExpirationNotification holds a list of expiration notices that should be sent in case a certificate is about to expire, this value is being propagated to the Certificate resources that are created | [optional] 
**GwClusterId** | **long** |  | [optional] 
**GwClusterUrl** | **string** | GWClusterURL is required when CAMode is \&quot;public\&quot; and it defines the cluster URL the PKI should be issued from. The GW cluster must have permissions to read associated target&#39;s details | [optional] 
**IsCa** | **bool** |  | [optional] 
**KeyBits** | **long** |  | [optional] 
**KeyType** | **string** |  | [optional] 
**KeyUsageList** | **List&lt;string&gt;** |  | [optional] 
**Locality** | **List&lt;string&gt;** |  | [optional] 
**MaxPathLen** | **long** |  | [optional] 
**NonCriticalKeyUsage** | **bool** |  | [optional] 
**NotBeforeDuration** | **long** | A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years. | [optional] 
**OrganizationList** | **List&lt;string&gt;** |  | [optional] 
**OrganizationUnitList** | **List&lt;string&gt;** |  | [optional] 
**PkiIssuerType** | **string** |  | [optional] 
**PostalCode** | **List&lt;string&gt;** |  | [optional] 
**ProtectGeneratedCertificates** | **bool** | ProtectGeneratedCertificates dictates whether the created certificates should be protected from deletion | [optional] 
**Province** | **List&lt;string&gt;** |  | [optional] 
**RenewBeforeExpirationInDays** | **long** |  | [optional] 
**RequireCn** | **bool** |  | [optional] 
**ServerFlag** | **bool** |  | [optional] 
**StreetAddress** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

