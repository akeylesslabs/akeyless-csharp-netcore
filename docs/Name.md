# akeyless.Model.Name
Name represents an X.509 distinguished name. This only includes the common elements of a DN. Note that Name is only an approximation of the X.509 structure. If an accurate representation is needed, asn1.Unmarshal the raw subject or issuer as an RDNSequence.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Country** | **List&lt;string&gt;** |  | [optional] 
**ExtraNames** | [**List&lt;AttributeTypeAndValue&gt;**](AttributeTypeAndValue.md) | ExtraNames contains attributes to be copied, raw, into any marshaled distinguished names. Values override any attributes with the same OID. The ExtraNames field is not populated when parsing, see Names. | [optional] 
**Locality** | **List&lt;string&gt;** |  | [optional] 
**Names** | [**List&lt;AttributeTypeAndValue&gt;**](AttributeTypeAndValue.md) | Names contains all parsed attributes. When parsing distinguished names, this can be used to extract non-standard attributes that are not parsed by this package. When marshaling to RDNSequences, the Names field is ignored, see ExtraNames. | [optional] 
**SerialNumber** | **string** |  | [optional] 
**StreetAddress** | **List&lt;string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

