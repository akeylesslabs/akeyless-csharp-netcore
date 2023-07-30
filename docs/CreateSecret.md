# akeyless.Model.CreateSecret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**CustomField** | **Dictionary&lt;string, string&gt;** | For Password Management use, additional fields | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this item [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**InjectUrl** | **List&lt;string&gt;** | For Password Management use, reflect the website context | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Metadata** | **string** | Deprecated - use description | [optional] 
**MultilineValue** | **bool** | The provided value is a multiline value (separated by &#39;\\n&#39;) | [optional] 
**Name** | **string** | Secret name | 
**Password** | **string** | For Password Management use, additional fields | [optional] 
**ProtectionKey** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**SecureAccessBastionIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Bastion | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers) | [optional] 
**SecureAccessRdpUser** | **string** | Remote Desktop Username | [optional] 
**SecureAccessSshCreds** | **string** | Static-Secret values contains SSH Credentials, either Private Key or Password [password/private-key] | [optional] 
**SecureAccessSshUser** | **string** | Override the SSH username as indicated in SSH Certificate Issuer | [optional] 
**SecureAccessUrl** | **string** | Destination URL to inject secrets | [optional] 
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless Web Access Bastion | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless Web Access Bastion | [optional] [default to false]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **string** | The secret sub type [generic/password] | [optional] [default to "generic"]
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | For Password Management use | [optional] 
**Value** | **string** | The secret value (only relevant for type &#39;generic&#39;) | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

