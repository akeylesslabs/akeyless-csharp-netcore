# akeyless.Model.CreateSSHCertIssuer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowedUsers** | **string** | Users allowed to fetch the certificate, e.g root,ubuntu | 
**DeleteProtection** | **string** | Protection from accidental deletion of this item | [optional] 
**Extensions** | **Dictionary&lt;string, string&gt;** | Signed certificates with extensions, e.g permit-port-forwarding&#x3D;\\\&quot;\\\&quot; | [optional] 
**Metadata** | **string** | A metadata about the issuer | [optional] 
**Name** | **string** | SSH certificate issuer name | 
**Principals** | **string** | Signed certificates with principal, e.g example_role1,example_role2 | [optional] 
**SecureAccessBastionApi** | **string** |  | [optional] 
**SecureAccessBastionSsh** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessSshCredsUser** | **string** |  | [optional] 
**SecureAccessUseInternalBastion** | **bool** |  | [optional] 
**SignerKeyName** | **string** | A key to sign the certificate with | 
**Tag** | **List&lt;string&gt;** | List of the tags attached to this key | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **long** | he requested Time To Live for the certificate, in seconds | 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

