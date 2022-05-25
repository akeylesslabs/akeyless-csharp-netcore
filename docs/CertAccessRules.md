# akeyless.Model.CertAccessRules

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BoundCommonNames** | **List&lt;string&gt;** | A list of names. At least one must exist in the Common Name. Supports globbing. | [optional] 
**BoundDnsSans** | **List&lt;string&gt;** | A list of DNS names. At least one must exist in the SANs. Supports globbing. | [optional] 
**BoundEmailSans** | **List&lt;string&gt;** | A list of Email Addresses. At least one must exist in the SANs. Supports globbing. | [optional] 
**BoundExtensions** | **List&lt;string&gt;** | A list of extensions formatted as \&quot;oid:value\&quot;. Expects the extension value to be some type of ASN1 encoded string. All values must match. Supports globbing on \&quot;value\&quot;. | [optional] 
**BoundOrganizationalUnits** | **List&lt;string&gt;** | A list of Organizational Units names. At least one must exist in the OU field. | [optional] 
**BoundUriSans** | **List&lt;string&gt;** | A list of URIs. At least one must exist in the SANs. Supports globbing. | [optional] 
**Certificate** | **string** | Base64 encdoed PEM certificate | [optional] 
**RevokedCertIds** | **List&lt;string&gt;** | A list of revoked cert ids | [optional] 
**UniqueIdentifier** | **string** | A unique identifier to distinguish different users | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

