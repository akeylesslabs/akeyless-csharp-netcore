# akeyless.Model.GCPAccessRules
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Audience** | **string** | The audience in the JWT | [optional] [default to "akeyless.io"]
**BoundLabels** | **Dictionary&lt;string, string&gt;** | A map of GCP labels formatted as \&quot;key:value\&quot; strings that must be set on authorized GCE instances. TODO: Because GCP labels are not currently ACL&#39;d .... | [optional] 
**BoundProjects** | **List&lt;string&gt;** | Human and Machine authentication section Array of GCP project IDs. Only entities belonging to any of the provided projects can authenticate. | [optional] 
**BoundRegions** | **List&lt;string&gt;** | List of regions that a GCE instance must belong to in order to be authenticated. TODO: If bound_instance_groups is provided, it is assumed to be a regional group and the group must belong to this region. If bound_zones are provided, this attribute is ignored. | [optional] 
**BoundServiceAccounts** | **List&lt;string&gt;** | List of service accounts the service account must be part of in order to be authenticated | [optional] 
**BoundZones** | **List&lt;string&gt;** | &#x3D;&#x3D;&#x3D; Machine authentication section &#x3D;&#x3D;&#x3D; List of zones that a GCE instance must belong to in order to be authenticated. TODO: If bound_instance_groups is provided, it is assumed to be a zonal group and the group must belong to this zone. | [optional] 
**ServiceAccount** | **string** | ServiceAccount holds the credentials file contents to be used by Akeyless to validate IAM (Human) and GCE (Machine) logins against GCP base64 encoded string | [optional] 
**Type** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

