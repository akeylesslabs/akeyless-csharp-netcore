# akeyless.Model.DynamicSecretUpdateGcp
dynamicSecretUpdateGcp is a command that updates a GCP dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessType** | **string** |  | [optional] 
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**FixedUserClaimKeyname** | **string** | For externally provided users, denotes the key-name of IdP claim to extract the username from (Relevant only when - -access-type&#x3D;external) | [optional] [default to "ext_email"]
**GcpCredType** | **string** |  | [optional] 
**GcpKey** | **string** | Base64-encoded service account private key text | [optional] 
**GcpKeyAlgo** | **string** | Service account key algorithm, e.g. KEY_ALG_RSA_1024 (Relevant only when - -access-type&#x3D;sa and - -gcp-cred-type&#x3D;key) | [optional] 
**GcpProjectId** | **string** | GCP Project ID override for dynamic secret operations | [optional] 
**GcpSaEmail** | **string** | The email of the fixed service account to generate keys or tokens for (Relevant only when - -access-type&#x3D;sa and - -service-account-type&#x3D;fixed) | [optional] 
**GcpTokenScopes** | **string** | Access token scopes list, e.g. scope1,scope2 (Relevant only when - -access-type&#x3D;sa; required when - -gcp-cred-type&#x3D;token) | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**RoleBinding** | **string** | Role binding definitions in JSON format (Relevant only when - -access-type&#x3D;sa and - -service-account-type&#x3D;dynamic) | [optional] 
**RoleNames** | **string** | Comma-separated list of GCP roles to assign to the user (Relevant only when - -access-type&#x3D;external) | [optional] 
**SecureAccessDelay** | **long** | The delay duration, in seconds, to wait after generating just-in-time credentials. Accepted range: 0-120 seconds | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessUrl** | **string** | Destination URL to inject secrets | [optional] 
**SecureAccessWebBrowsing** | **bool** | Secure browser via Akeyless&#39;s Secure Remote Access (SRA) | [optional] [default to false]
**SecureAccessWebProxy** | **bool** | Web-Proxy via Akeyless&#39;s Secure Remote Access (SRA) | [optional] [default to false]
**ServiceAccountType** | **string** | The type of the GCP service account. Options [fixed, dynamic] (Relevant only when - -access-type&#x3D;sa) | [optional] [default to "fixed"]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

