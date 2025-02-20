# akeyless.Model.CreateSSHCertIssuer

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProviderType** | **string** |  | [optional] 
**AllowedUsers** | **string** | Users allowed to fetch the certificate, e.g root,ubuntu | [default to "-"]
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Extensions** | **Dictionary&lt;string, string&gt;** | Signed certificates with extensions, e.g permit-port-forwarding&#x3D;\\\&quot;\\\&quot; | [optional] 
**ExternalUsername** | **string** | Externally provided username [true/false] | [optional] [default to "false"]
**FixedUserClaimKeyname** | **string** | For externally provided users, denotes the key-name of IdP claim to extract the username from (relevant only for external-username&#x3D;true) | [optional] 
**HostProvider** | **string** | Host provider type [explicit/target], Default Host provider is explicit, Relevant only for Secure Remote Access of ssh cert issuer, ldap rotated secret and ldap dynamic secret | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Metadata** | **string** | Deprecated - use description | [optional] 
**Name** | **string** | SSH certificate issuer name | 
**Principals** | **string** | Signed certificates with principal, e.g example_role1,example_role2 | [optional] 
**SecureAccessApi** | **string** | Secure Access SSH control API endpoint. E.g. https://my.sra-server:9900 | [optional] 
**SecureAccessBastionApi** | **string** | Deprecated. use secure-access-api | [optional] 
**SecureAccessBastionSsh** | **string** | Deprecated. use secure-access-ssh | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessEnforceHostsRestriction** | **bool** | Enable this flag to enforce connections only to the hosts listed in - -secure-access-host | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers) | [optional] 
**SecureAccessSsh** | **string** | Bastion&#39;s SSH server. E.g. my.sra-server:22 | [optional] 
**SecureAccessSshCredsUser** | **string** | SSH username to connect to target server, must be in &#39;Allowed Users&#39; list | [optional] 
**SecureAccessUseInternalBastion** | **bool** | Deprecated. Use secure-access-use-internal-ssh-access | [optional] 
**SecureAccessUseInternalSshAccess** | **bool** | Use internal SSH Access | [optional] 
**SignerKeyName** | **string** | A key to sign the certificate with | 
**Tag** | **List&lt;string&gt;** | List of the tags attached to this key | [optional] 
**Target** | **List&lt;string&gt;** | A list of linked targets to be associated, Relevant only for Secure Remote Access for ssh cert issuer, ldap rotated secret and ldap dynamic secret, To specify multiple targets use argument multiple times | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Ttl** | **long** | The requested Time To Live for the certificate, in seconds | 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

