# akeyless.Model.CreateSecret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProviderType** | **string** |  | [optional] 
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**AraEnabled** | **bool** | Enable or disable Agentic Runtime Authority rule enforcement for this item. When false, user-defined input/output rules are stored but not enforced; the base security validation still runs.  AraEnabled is tri-state (nil/true/false), not a plain bool: it self-encodes its wire value (see akl.OptionalBool) so an explicit false survives the curl-proxy relay instead of being dropped like a default-false bool flag. | [optional] 
**ChangeEvent** | **string** | Trigger an event when a secret value changed [true/false] (Relevant only for Static Secret) | [optional] 
**CustomField** | **Dictionary&lt;string, string&gt;** | For Password Management use, additional fields | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EnableAgenticRuntimeAuthority** | **bool** | EnableAra is the documented spelling of AraEnabled. Both set the same field; - -ara-enabled shipped first and stays as an undocumented alias so existing scripts and the Terraform provider keep working. | [optional] 
**EnableAiQuorum** | **bool** | Turns on AI Quorum checks for this item. | [optional] 
**Format** | **string** | Secret format [text/json/key-value] (relevant only for type &#39;generic&#39;) | [optional] [default to "text"]
**HostProvider** | **string** | Host provider type [explicit/target], Default Host provider is explicit, Relevant only for SRA items. | [optional] 
**InjectUrl** | **List&lt;string&gt;** | For Password Management use, reflect the website context | [optional] 
**InputRule** | **List&lt;string&gt;** | Agentic input rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Sanitize input) | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**LockDuringSraSession** | **string** | Lock this secret for read/update while an SRA session is active | [optional] 
**LockOnRead** | **string** | Lock this secret after each successful value read | [optional] 
**LockTtl** | **string** | Lock TTL in minutes | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Metadata** | **string** | Deprecated - use description | [optional] 
**MultilineValue** | **bool** | The provided value is a multiline value (separated by &#39;\\n&#39;) | [optional] 
**Name** | **string** | Secret name | 
**OutputRule** | **List&lt;string&gt;** | Agentic output rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Mask secrets) | [optional] 
**Password** | **string** | For Password Management use, additional fields | [optional] 
**ProtectionKey** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**SecureAccessBastionIssuer** | **string** | Deprecated. use secure-access-certificate-issuer | [optional] 
**SecureAccessCertificateIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Secure Access | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessEnforceHostsRestriction** | **bool** | Enforce connections only to allowed SRA hosts | [optional] 
**SecureAccessGateway** | **string** |  | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers) | [optional] 
**SecureAccessRdpUser** | **string** | Remote Desktop Username | [optional] 
**SecureAccessSshCreds** | **string** | Static-Secret values contains SSH Credentials, either Private Key or Password [password/private-key] | [optional] 
**SecureAccessSshUser** | **string** | Override the SSH username as indicated in SSH Certificate Issuer | [optional] 
**SecureAccessUrl** | **string** | Destination URL to inject secrets | [optional] 
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless&#39;s Secure Remote Access (SRA) | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless&#39;s Secure Remote Access (SRA) | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**Target** | **List&lt;string&gt;** | A list of targets to be associated with an SRA item, To specify multiple targets use argument multiple times | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **string** | The secret sub type [generic/password] | [optional] [default to "generic"]
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | For Password Management use | [optional] 
**Value** | **string** | The secret value (relevant only for type &#39;generic&#39;) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

