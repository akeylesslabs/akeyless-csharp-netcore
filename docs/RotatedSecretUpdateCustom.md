# akeyless.Model.RotatedSecretUpdateCustom

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddTag** | **List&lt;string&gt;** | List of the new tags that will be attached to this item | [optional] 
**AuthenticationCredentials** | **string** | The credentials to connect with use-user-creds/use-target-creds | [optional] [default to "use-user-creds"]
**AutoRotate** | **string** | Whether to automatically rotate every - -rotation-interval days, or disable existing automatic rotation [true/false] | [optional] 
**CustomPayload** | **string** | Secret payload to be sent with rotation request | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] [default to "default_metadata"]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the secret value (if empty, the account default protectionKey key will be used) | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Rotated secret name | 
**NewName** | **string** | New item name | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**RmTag** | **List&lt;string&gt;** | List of the existent tags that will be removed from this item | [optional] 
**RotateAfterDisconnect** | **string** | Rotate the value of the secret after SRA session ends [true/false] | [optional] [default to "false"]
**RotationEventIn** | **List&lt;string&gt;** | How many days before the rotation of the item would you like to be notified | [optional] 
**RotationHour** | **int** | The Hour of the rotation in UTC | [optional] 
**RotationInterval** | **string** | The number of days to wait between every automatic key rotation (1-365) | [optional] 
**SecureAccessAllowExternalUser** | **bool** | Allow providing external user for a domain users | [optional] [default to false]
**SecureAccessBastionIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Bastion | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts - Relevant only for Dynamic Secrets/producers) | [optional] 
**SecureAccessRdpDomain** | **string** | Default domain name server. i.e. microsoft.com | [optional] 
**SecureAccessRdpUser** | **string** | Override the RDP Domain username | [optional] 
**SecureAccessSshUser** | **string** | Override the SSH username as indicated in SSH Certificate Issuer | [optional] 
**SecureAccessUrl** | **string** | Destination URL to inject secrets | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless Web Access Bastion | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless Web Access Bastion | [optional] [default to false]
**TimeoutSec** | **long** | Maximum allowed time in seconds for the custom rotator to return the results | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

