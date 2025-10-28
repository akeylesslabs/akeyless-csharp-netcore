# akeyless.Model.DynamicSecretCreateGcp
dynamicSecretCreateGcp is a command that creates a GCP dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**GcpCredType** | **string** |  | [optional] 
**GcpKey** | **string** | Base64-encoded service account private key text | [optional] 
**GcpKeyAlgo** | **string** | Service account key algorithm, e.g. KEY_ALG_RSA_1024 | [optional] 
**GcpSaEmail** | **string** | The email of the fixed service acocunt to generate keys or tokens for. (revelant for service-account-type&#x3D;fixed) | [optional] 
**GcpTokenScopes** | **string** | Access token scopes list, e.g. scope1,scope2 | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**RoleBinding** | **string** | Role binding definitions in json format | [optional] 
**ServiceAccountType** | **string** | The type of the gcp dynamic secret. Options[fixed, dynamic] | [default to "fixed"]
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

