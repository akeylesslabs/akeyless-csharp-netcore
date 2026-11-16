# akeyless.Model.TargetCreateAnthropic
targetCreateAnthropic is a command that creates a new anthropic target

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AnthropicUrl** | **string** | Base URL of the Anthropic API | [optional] [default to "https://api.anthropic.com"]
**ApiKey** | **string** | API key for Anthropic | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**LockOnRead** | **string** | Lock this secret after each successful value read | [optional] 
**LockTtl** | **string** | Lock TTL in minutes | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**RotateOnUnlock** | **string** | Rotate this secret after it is unlocked | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UseGwCloudIdentity** | **bool** | Use the Gateway&#39;s cloud identity (Anthropic Workload Identity Federation) instead of an API key | [optional] 
**WifAzureAudience** | **string** | Identifier URI (api://&lt;app-id&gt;) of the Entra app registration for the Claude API audience, required with the azure source | [optional] 
**WifFederationRuleId** | **string** | Federation rule ID (fdrl_...), required with use-gw-cloud-identity | [optional] 
**WifIdentityTokenSource** | **string** | Where the Gateway reads its identity token: file (default), gcp, aws or azure | [optional] 
**WifOrganizationId** | **string** | Anthropic organization ID (UUID), required with use-gw-cloud-identity | [optional] 
**WifServiceAccountId** | **string** | Claude service account ID (svac_...), required with use-gw-cloud-identity | [optional] 
**WifWorkspaceId** | **string** | Workspace ID (wrkspc_...), needed only when the federation rule covers more than one workspace | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

