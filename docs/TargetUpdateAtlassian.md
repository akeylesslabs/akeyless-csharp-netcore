# akeyless.Model.TargetUpdateAtlassian

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AtlassianAuthType** | **string** | Atlassian auth type: oauth, service_account_token or user_api_token on cloud, pat on data center | [optional] 
**AtlassianAutomationKey** | **string** | Optional Automation REST API key (Jira settings &gt; System &gt; Automation &gt; API keys); the automation API refuses an account token, so without it the automation rules are reported as not read | [optional] 
**AtlassianCaCertificate** | **string** | CA certificate (base64-encoded PEM) of a Data Center site signed by a private CA | [optional] 
**AtlassianClientId** | **string** | Atlassian OAuth 2.0 service account client ID | [optional] 
**AtlassianClientSecret** | **string** | Atlassian OAuth 2.0 service account client secret | [optional] 
**AtlassianCloudId** | **string** | Atlassian Cloud ID of the site (resolved from the site URL when empty) | [optional] 
**AtlassianConfluenceToken** | **string** | Confluence Data Center personal access token | [optional] 
**AtlassianConfluenceUrl** | **string** | Confluence Data Center base URL | [optional] 
**AtlassianDeploymentType** | **string** | Atlassian deployment type: cloud or data_center (inferred from the URL when empty) | [optional] 
**AtlassianEmail** | **string** | Atlassian account email paired with a user API token | [optional] 
**AtlassianJiraToken** | **string** | Jira Data Center personal access token | [optional] 
**AtlassianJiraUrl** | **string** | Jira Data Center base URL | [optional] 
**AtlassianProducts** | **List&lt;string&gt;** | Atlassian products to connect to on cloud: jira, confluence or both (default both) | [optional] 
**AtlassianToken** | **string** | Atlassian Cloud service account API token or user API token | [optional] 
**AtlassianUrl** | **string** | Atlassian Cloud site base URL (https://&lt;site&gt;.atlassian.net) | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**KeepPrevVersion** | **string** | Whether to keep previous version [true/false]. If not set, use default according to account settings | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**LockOnRead** | **string** | Lock this secret after each successful value read | [optional] 
**LockTtl** | **string** | Lock TTL in minutes | [optional] 
**MaxVersions** | **string** | Set the maximum number of versions, limited by the account settings defaults. | [optional] 
**Name** | **string** | Target name | 
**NewName** | **string** | New target name | [optional] 
**RotateOnUnlock** | **string** | Rotate this secret after it is unlocked | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

