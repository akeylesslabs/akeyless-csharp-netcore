# akeyless.Model.AuthMethodCreateGcp
authMethodCreateGcp is a command that creates a new auth method that will be able to authenticate using GCP IAM Service Account credentials or GCE instance credentials.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessExpires** | **long** | Access expiration date in Unix timestamp (select 0 for access without expiry date) | [optional] [default to 0]
**Audience** | **string** | The audience to verify in the JWT received by the client | [default to "akeyless.io"]
**AuditLogsClaims** | **List&lt;string&gt;** | Subclaims to include in audit logs, e.g \&quot;- -audit-logs-claims email - -audit-logs-claims username\&quot; | [optional] 
**BoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the IPs that the access is restricted to | [optional] 
**BoundLabels** | **List&lt;string&gt;** | A comma-separated list of GCP labels formatted as \&quot;key:value\&quot; strings that must be set on authorized GCE instances. TODO: Because GCP labels are not currently ACL&#39;d .... | [optional] 
**BoundProjects** | **List&lt;string&gt;** | &#x3D;&#x3D;&#x3D; Human and Machine authentication section &#x3D;&#x3D;&#x3D; Array of GCP project IDs. Only entities belonging to any of the provided projects can authenticate. | [optional] 
**BoundRegions** | **List&lt;string&gt;** | List of regions that a GCE instance must belong to in order to be authenticated. TODO: If bound_instance_groups is provided, it is assumed to be a regional group and the group must belong to this region. If bound_zones are provided, this attribute is ignored. | [optional] 
**BoundServiceAccounts** | **List&lt;string&gt;** | List of service accounts the service account must be part of in order to be authenticated. | [optional] 
**BoundZones** | **List&lt;string&gt;** | &#x3D;&#x3D;&#x3D; Machine authentication section &#x3D;&#x3D;&#x3D; List of zones that a GCE instance must belong to in order to be authenticated. TODO: If bound_instance_groups is provided, it is assumed to be a zonal group and the group must belong to this zone. | [optional] 
**DeleteProtection** | **string** | Protection from accidental deletion of this object [true/false] | [optional] 
**Description** | **string** | Auth Method description | [optional] 
**ExpirationEventIn** | **List&lt;string&gt;** | How many days before the expiration of the auth method would you like to be notified. | [optional] 
**ForceSubClaims** | **bool** | if true: enforce role-association must include sub claims | [optional] 
**GwBoundIps** | **List&lt;string&gt;** | A CIDR whitelist with the GW IPs that the access is restricted to | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**JwtTtl** | **long** | Jwt TTL | [optional] [default to 0]
**Name** | **string** | Auth Method name | 
**ProductType** | **List&lt;string&gt;** | Choose the relevant product type for the auth method [sm, sra, pm, dp, ca] | [optional] 
**ServiceAccountCredsData** | **string** | ServiceAccount credentials data instead of giving a file path, base64 encoded | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **string** | Type of the GCP Access Rules | 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**UniqueIdentifier** | **string** | A unique identifier (ID) value which is a \&quot;sub claim\&quot; name that contains details uniquely identifying that resource. This \&quot;sub claim\&quot; is used to distinguish between different identities. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

