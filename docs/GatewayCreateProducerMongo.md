# akeyless.Model.GatewayCreateProducerMongo
gatewayCreateProducerMongo is a command that creates either mongodb  producer or mongodb atlas producer [Deprecated: Use dynamic-secret-create-mongodb command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AraEnabled** | **bool** | Enable or disable Agentic Runtime Authority rule enforcement for this item. Mirrors commands.AgenticRulesParams.AraEnabled. | [optional] 
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**EnableAgenticRuntimeAuthority** | **bool** | EnableAra is the documented spelling of AraEnabled; - -ara-enabled shipped first and stays as an undocumented alias. | [optional] 
**EnableAiQuorum** | **bool** | Turns on AI Quorum checks for this item. | [optional] 
**InputRule** | **List&lt;string&gt;** | Agentic input rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Sanitize input) Mirrors commands.AgenticRulesParams — kept separate because ResourceDS cannot embed it (different package, different struct layout). | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**MongodbAtlasApiPrivateKey** | **string** | MongoDB Atlas private key | [optional] 
**MongodbAtlasApiPublicKey** | **string** | MongoDB Atlas public key | [optional] 
**MongodbAtlasProjectId** | **string** | MongoDB Atlas project ID | [optional] 
**MongodbCustomData** | **string** | MongoDB custom data | [optional] 
**MongodbDefaultAuthDb** | **string** | MongoDB server default authentication database | [optional] 
**MongodbHostPort** | **string** | MongoDB server host and port | [optional] 
**MongodbName** | **string** | MongoDB Name | [optional] 
**MongodbPassword** | **string** | MongoDB server password. You will prompted to provide a password if it will not appear in CLI parameters | [optional] 
**MongodbRoles** | **string** | MongoDB Roles | [optional] [default to "[]"]
**MongodbScopes** | **string** | MongoDB Scopes (Atlas only) | [optional] 
**MongodbServerUri** | **string** | MongoDB server URI | [optional] 
**MongodbUriOptions** | **string** | MongoDB server URI options | [optional] 
**MongodbUsername** | **string** | MongoDB server username | [optional] 
**Name** | **string** | Dynamic secret name | 
**OutputRule** | **List&lt;string&gt;** | Agentic output rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Mask secrets) | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Encrypt producer with following key | [optional] 
**SecureAccessBastionIssuer** | **string** | Deprecated. use secure-access-certificate-issuer | [optional] 
**SecureAccessCertificateIssuer** | **string** | Path to the SSH Certificate Issuer for your Akeyless Secure Access | [optional] 
**SecureAccessDbName** | **string** | The DB name (relevant only for DB Dynamic-Secret) | [optional] 
**SecureAccessDelay** | **long** | The delay duration, in seconds, to wait after generating just-in-time credentials. Accepted range: 0-120 seconds | [optional] 
**SecureAccessEnable** | **string** | Enable/Disable secure remote access [true/false] | [optional] 
**SecureAccessHost** | **List&lt;string&gt;** | Target DB servers for connections (In case of Linked Target association, host(s) will inherit Linked Target hosts) | [optional] 
**SecureAccessWeb** | **bool** | Enable Web Secure Remote Access | [optional] [default to false]
**SkipDryRun** | **string** | If set, dry-run will be skipped | [optional] 
**Tags** | **List&lt;string&gt;** | Add tags attached to this object | [optional] 
**TargetName** | **string** | Target name | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseCapitalLetters** | **string** | Specifies whether the generated temporary password must contain at least one uppercase character from the ISO basic Latin alphabet (A to Z). [true/false] | [optional] 
**UseLowerLetters** | **string** | Specifies whether the generated temporary password must contain at least one lowercase character from the ISO basic Latin alphabet (a to z). [true/false] | [optional] 
**UseNumbers** | **string** | Specifies whether the generated temporary password must contain at least one numeric character (0 to 9). [true/false] | [optional] 
**UseSpecialCharacters** | **string** |  | [optional] 
**UserTtl** | **string** | User TTL | [optional] [default to "60m"]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

