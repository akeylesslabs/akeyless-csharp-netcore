# akeyless.Model.CreatePKICertIssuer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowAnyName** | **bool** | If set, clients can request certificates for any CN | [optional] 
**AllowSubdomains** | **bool** | If set, clients can request certificates for subdomains and wildcard subdomains of the allowed domains | [optional] 
**AllowedDomains** | **string** | A list of the allowed domains that clients can request to be included in the certificate (in a comma-delimited list) | [optional] 
**AllowedUriSans** | **string** | A list of the allowed URIs that clients can request to be included in the certificate as part of the URI Subject Alternative Names (in a comma-delimited list) | [optional] 
**ClientFlag** | **bool** | If set, certificates will be flagged for client auth use | [optional] 
**CodeSigningFlag** | **bool** | If set, certificates will be flagged for code signing use | [optional] 
**Country** | **string** | A comma-separated list of countries that will be set in the issued certificate | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item | [optional] 
**KeyUsage** | **string** | key-usage | [optional] [default to "DigitalSignature,KeyAgreement,KeyEncipherment"]
**Locality** | **string** | A comma-separated list of localities that will be set in the issued certificate | [optional] 
**Metadata** | **string** | A metadata about the issuer | [optional] 
**Name** | **string** | PKI certificate issuer name | 
**NotEnforceHostnames** | **bool** | If set, any names are allowed for CN and SANs in the certificate and not only a valid host name | [optional] 
**NotRequireCn** | **bool** | If set, clients can request certificates without a CN | [optional] 
**OrganizationalUnits** | **string** | A comma-separated list of organizational units (OU) that will be set in the issued certificate | [optional] 
**Organizations** | **string** | A comma-separated list of organizations (O) that will be set in the issued certificate | [optional] 
**PostalCode** | **string** | A comma-separated list of postal codes that will be set in the issued certificate | [optional] 
**Province** | **string** | A comma-separated list of provinces that will be set in the issued certificate | [optional] 
**ServerFlag** | **bool** | If set, certificates will be flagged for server auth use | [optional] 
**SignerKeyName** | **string** | A key to sign the certificate with | 
**StreetAddress** | **string** | A comma-separated list of street addresses that will be set in the issued certificate | [optional] 
**Tag** | **List&lt;string&gt;** | List of the tags attached to this key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **long** | he requested Time To Live for the certificate, in seconds | 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

