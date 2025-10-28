# akeyless.Model.DynamicSecretUpdateSnowflake
GatewayUpdateProducerSnowflakeCmd is a command that updates a Snowflake dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **string** | Account name | [optional] 
**AccountPassword** | **string** | Database Password | [optional] 
**AccountUsername** | **string** | Database Username | [optional] 
**AuthMode** | **string** | The authentication mode for the temporary user [password/key] | [optional] [default to "password"]
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DbName** | **string** | Database name | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeyAlgo** | **string** |  | [optional] 
**Name** | **string** | Dynamic secret name | 
**NewName** | **string** | Dynamic secret name | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**PrivateKey** | **string** | RSA Private key (base64 encoded) | [optional] 
**PrivateKeyPassphrase** | **string** | The Private key passphrase | [optional] 
**Role** | **string** | User role | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "24h"]
**Warehouse** | **string** | Warehouse name | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

