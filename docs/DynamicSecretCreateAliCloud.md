# akeyless.Model.DynamicSecretCreateAliCloud
dynamicSecretCreateAliCloud is a command that creates AliCloud dynamic secret

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AdminRotationIntervalDays** | **long** | Admin credentials rotation interval (days) | [optional] [default to 0]
**AlicloudAccessKeyId** | **string** | AliCloud RAM access key ID | [optional] 
**AlicloudAccessMode** | **string** |  | [optional] 
**AlicloudAccessSecretKey** | **string** | AliCloud RAM access key secret | [optional] 
**AlicloudExternalId** | **string** | The external ID in the trust policy of the AliCloud roles (relevant only for assume_role mode) | [optional] 
**AlicloudRegion** | **string** | AliCloud region. Selects the regional STS endpoint. If empty, the global STS endpoint is used | [optional] 
**AlicloudRoleArns** | **string** | AliCloud role ARNs allowed in the Assume Role operation (relevant only for assume_role mode) | [optional] 
**AlicloudSessionPolicy** | **string** | Session policy document (JSON) that limits the assumed role session (relevant only for assume_role mode) | [optional] 
**AlicloudSetSourceIdentity** | **bool** | Send the requester&#39;s identity as the SourceIdentity of the assumed role session, so it shows in ActionTrail (relevant only for assume_role mode). Needs sts:SetSourceIdentity in both the producer identity&#39;s policy and the role trust policy | [optional] [default to false]
**AlicloudSite** | **string** | The Alibaba Cloud site of the account: international or china. It selects the console sign-in host of the RAM user | [optional] [default to "international"]
**AlicloudUserConsoleAccess** | **bool** | Enable AliCloud RAM user console access (relevant only for ram_user mode) | [optional] [default to false]
**AlicloudUserGroups** | **string** | AliCloud user groups (relevant only for ram_user mode) | [optional] 
**AlicloudUserInlinePolicy** | **string** | RAM policy document (JSON) for a custom policy created for each RAM user (relevant only for ram_user mode) | [optional] 
**AlicloudUserPolicies** | **string** | AliCloud policies attached to the RAM user, in the form &lt;System|Custom&gt;:&lt;PolicyName&gt; (relevant only for ram_user mode) | [optional] 
**AlicloudUserProgrammaticAccess** | **bool** | Enable AliCloud RAM user programmatic access (relevant only for ram_user mode) | [optional] [default to true]
**AraEnabled** | **bool** | Enable or disable Agentic Runtime Authority rule enforcement for this item. Mirrors commands.AgenticRulesParams.AraEnabled. | [optional] 
**CustomUsernameTemplate** | **string** | Customize how temporary usernames are generated using go template | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**EnableAdminRotation** | **bool** | Automatic admin credentials rotation | [optional] [default to false]
**EnableAgenticRuntimeAuthority** | **bool** | EnableAra is the documented spelling of AraEnabled; - -ara-enabled shipped first and stays as an undocumented alias. | [optional] 
**EnableAiQuorum** | **bool** | Turns on AI Quorum checks for this item. | [optional] 
**InputRule** | **List&lt;string&gt;** | Agentic input rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Sanitize input) Mirrors commands.AgenticRulesParams — kept separate because ResourceDS cannot embed it (different package, different struct layout). | [optional] 
**ItemCustomFields** | **Dictionary&lt;string, string&gt;** | Additional custom fields to associate with the item | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Dynamic secret name | 
**OutputRule** | **List&lt;string&gt;** | Agentic output rule in name&#x3D;...,rule&#x3D;... format (e.g. name&#x3D;rule1,rule&#x3D;Mask secrets) | [optional] 
**PasswordLength** | **string** | The length of the password to be generated | [optional] 
**ProducerEncryptionKeyName** | **string** | Dynamic producer encryption key | [optional] 
**SkipDryRun** | **bool** | If set, dry-run will be skipped [true/false] | [optional] 
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

