# akeyless.Model.CreateAuthMethodAWSIAM
createAuthMethodAWSIAM is a command that creates a new Auth Method that will be able to authenticate using AWS IAM credentials.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**BoundArn** | **List&lt;string&gt;** | A list of full arns that the access is restricted to | [optional] 
**BoundAwsAccountId** | **List&lt;string&gt;** | A list of AWS account-IDs that the access is restricted to | 
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the IPs that the access is restricted to | [optional] 
**BoundResourceId** | **List&lt;string&gt;** | A list of full resource ids that the access is restricted to | [optional] 
**BoundRoleId** | **List&lt;string&gt;** | A list of full role ids that the access is restricted to | [optional] 
**BoundRoleName** | **List&lt;string&gt;** | A list of full role-name that the access is restricted to | [optional] 
**BoundUserId** | **List&lt;string&gt;** | A list of full user ids that the access is restricted to | [optional] 
**BoundUserName** | **List&lt;string&gt;** | A list of full user-name that the access is restricted to | [optional] 
**ForceSubClaims** | **bool** | if true: enforce role-association must include sub claims | [optional] 
**GwBoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the GW IPs that the access is restricted to | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**JwtTtl** | **long** | Jwt TTL | [optional] [default to 0]
**Name** | **string** | Auth Method name | 
**StsUrl** | **string** | sts URL | [optional] [default to "https://sts.amazonaws.com"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

