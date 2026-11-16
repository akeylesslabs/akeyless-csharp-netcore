# akeyless.Model.AtlassianTargetDetails
An Atlassian site (Jira, Confluence or both) credential, on Atlassian Cloud or Data Center. Cloud uses the site URL (https://<site>.atlassian.net) with an OAuth 2.0 service account, a service account API token, or a user API token paired with the account email. Data Center uses a personal access token per product, with its own Jira and Confluence URLs. Read by the SDR Atlassian scanner.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AtlassianAuthType** | **string** |  | [optional] 
**AtlassianAutomationKey** | **string** | AtlassianAutomationKey is an optional Automation REST API key (Jira settings &gt; System &gt; Automation &gt; API keys). Atlassian&#39;s automation API refuses an account API token, so without this key the scanner reports the automation rules as not read. | [optional] 
**AtlassianCaCertificate** | **string** | AtlassianCACertificate is a base64-encoded PEM CA certificate for a Data Center site signed by a private CA. | [optional] 
**AtlassianClientId** | **string** |  | [optional] 
**AtlassianClientSecret** | **string** |  | [optional] 
**AtlassianCloudId** | **string** |  | [optional] 
**AtlassianConfluenceToken** | **string** |  | [optional] 
**AtlassianConfluenceUrl** | **string** |  | [optional] 
**AtlassianDeploymentType** | **string** | When empty, the deployment type, auth type and products are inferred from the fields above, so targets saved before these fields existed keep working. | [optional] 
**AtlassianEmail** | **string** |  | [optional] 
**AtlassianJiraToken** | **string** |  | [optional] 
**AtlassianJiraUrl** | **string** |  | [optional] 
**AtlassianProducts** | **List&lt;string&gt;** |  | [optional] 
**AtlassianToken** | **string** |  | [optional] 
**AtlassianUrl** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

