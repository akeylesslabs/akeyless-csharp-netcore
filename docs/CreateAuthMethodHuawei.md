# akeyless.Model.CreateAuthMethodHuawei
createAuthMethodHuawei is a command that creates a new auth method that will be able to authenticate using Huawei credentials.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**AllowedClientType** | **List&lt;string&gt;** | limit the auth method usage for specific client types [cli,ui,gateway-admin,sdk,mobile,extension] | [optional] 
**AuditLogsClaims** | **List&lt;string&gt;** | Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot; | [optional] 
**AuthUrl** | **string** | sts URL | [optional] [default to "https://iam.myhwclouds.com:443/v3"]
**BoundDomainId** | **List&lt;string&gt;** | A list of domain IDs that the access is restricted to | [optional] 
**BoundDomainName** | **List&lt;string&gt;** | A list of domain names that the access is restricted to | [optional] 
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the IPs that the access is restricted to | [optional] 
**BoundTenantId** | **List&lt;string&gt;** | A list of full tenant ids that the access is restricted to | [optional] 
**BoundTenantName** | **List&lt;string&gt;** | A list of full tenant names that the access is restricted to | [optional] 
**BoundUserId** | **List&lt;string&gt;** | A list of full user ids that the access is restricted to | [optional] 
**BoundUserName** | **List&lt;string&gt;** | A list of full user-name that the access is restricted to | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Auth Method description | [optional] 
**ExpirationEventIn** | **List&lt;string&gt;** | How many days before the expiration of the auth method would you like to be notified. | [optional] 
**ForceSubClaims** | **bool** | if true: enforce role-association must include sub claims | [optional] 
**GwBoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the GW IPs that the access is restricted to | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**JwtTtl** | **long** | Jwt TTL | [optional] [default to 0]
**Name** | **string** | Auth Method name | 
**ProductType** | **List&lt;string&gt;** | Choose the relevant product type for the auth method [sm, sra, pm, dp, ca] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

