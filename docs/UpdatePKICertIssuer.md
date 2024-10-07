# akeyless.Model.UpdatePKICertIssuer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**AllowAnyName** | **bool** | If set, clients can request certificates for any CN | [optional] 
**AllowCopyExtFromCsr** | **bool** | If set, will allow copying the extra extensions from the csr file (if given) | [optional] 
**AllowSubdomains** | **bool** | If set, clients can request certificates for subdomains and wildcard subdomains of the allowed domains | [optional] 
**AllowedDomains** | **string** | A list of the allowed domains that clients can request to be included in the certificate (in a comma-delimited list) | [optional] 
**AllowedExtraExtensions** | **string** | A json string containing the allowed extra extensions for the pki cert issuer | [optional] 
**AllowedUriSans** | **string** | A list of the allowed URIs that clients can request to be included in the certificate as part of the URI Subject Alternative Names (in a comma-delimited list) | [optional] 
**ClientFlag** | **bool** | If set, certificates will be flagged for client auth use | [optional] 
**CodeSigningFlag** | **bool** | If set, certificates will be flagged for code signing use | [optional] 
**Country** | **string** | A comma-separated list of countries that will be set in the issued certificate | [optional] 
**CreatePrivateCrl** | **bool** | Set this to allow the issuer will expose a CRL endpoint in the Gateway | [optional] 
**CreatePublicCrl** | **bool** | Set this to allow the cert issuer will expose a public CRL endpoint | [optional] 
**CriticalKeyUsage** | **string** | Mark key usage as critical [true/false] | [optional] [default to "true"]
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**DestinationPath** | **string** | A path in which to save generated certificates | [optional] 
**EnableAcme** | **bool** | If set, the cert issuer will support the acme protocol | [optional] 
**ExpirationEventIn** | **List&lt;string&gt;** | How many days before the expiration of the certificate would you like to be notified. | [optional] 
**GwClusterUrl** | **string** | The GW cluster URL to issue the certificate from. Required in Public CA mode, to allow CRLs on private CA, or to enable ACME | [optional] 
**IsCa** | **bool** | If set, the basic constraints extension will be added to certificate | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyUsage** | **string** | key-usage | [optional] [default to "DigitalSignature,KeyAgreement,KeyEncipherment"]
**Locality** | **string** | A comma-separated list of localities that will be set in the issued certificate | [optional] 
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | PKI certificate issuer name | 
**NewName** | **string** | New item name | [optional] 
**NotEnforceHostnames** | **bool** | If set, any names are allowed for CN and SANs in the certificate and not only a valid host name | [optional] 
**NotRequireCn** | **bool** | If set, clients can request certificates without a CN | [optional] 
**OrganizationalUnits** | **string** | A comma-separated list of organizational units (OU) that will be set in the issued certificate | [optional] 
**Organizations** | **string** | A comma-separated list of organizations (O) that will be set in the issued certificate | [optional] 
**PostalCode** | **string** | A comma-separated list of postal codes that will be set in the issued certificate | [optional] 
**ProtectCertificates** | **bool** | Whether to protect generated certificates from deletion | [optional] 
**Province** | **string** | A comma-separated list of provinces that will be set in the issued certificate | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**ServerFlag** | **bool** | If set, certificates will be flagged for server auth use | [optional] 
**SignerKeyName** | **string** | A key to sign the certificate with, required in Private CA mode | [default to "dummy_signer_key"]
**StreetAddress** | **string** | A comma-separated list of street addresses that will be set in the issued certificate | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **string** | The maximum requested Time To Live for issued certificates, in seconds. In case of Public CA, this is based on the CA target&#39;s supported maximum TTLs | 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

