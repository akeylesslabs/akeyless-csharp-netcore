# akeyless.Model.UpdateSSHCertIssuer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**AllowedUsers** | **string** | Users allowed to fetch the certificate, e.g root,ubuntu | 
**Extensions** | **Dictionary&lt;string, string&gt;** | Signed certificates with extensions, e.g permit-port-forwarding&#x3D;\\\&quot;\\\&quot; | [optional] 
**Metadata** | **string** | A metadata about the issuer | [optional] 
**Name** | **string** | SSH certificate issuer name | 
**NewName** | **string** | New item name | [optional] 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Principals** | **string** | Signed certificates with principal, e.g example_role1,example_role2 | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**SecureAccessBastionApi** | **string** |  | [optional] 
**SecureAccessBastionSsh** | **string** |  | [optional] 
**SecureAccessEnable** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** |  | [optional] 
**SecureAccessSshCredsUser** | **string** |  | [optional] 
**SecureAccessUseInternalBastion** | **bool** |  | [optional] 
**SignerKeyName** | **string** | A key to sign the certificate with | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **long** | he requested Time To Live for the certificate, in seconds | 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
