# akeyless.Model.GetGroupOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** |  | [optional] 
**CreationDate** | **DateTime** |  | [optional] 
**Description** | **string** |  | [optional] 
**GrantedRoles** | [**List&lt;GrantedRole&gt;**](GrantedRole.md) | GrantedRoles are the roles a member of this group gets at login, through the group&#39;s akeyless_groups claim. Read-only, and filled only for the SCIM bearer that owns the group: a group name on its own says nothing about the access it carries, which is what a reviewer certifying the entitlement has to judge. | [optional] 
**GrantedRolesKnown** | **bool** | GrantedRolesKnown is set when GrantedRoles was computed, so an empty list means \&quot;grants no role\&quot; rather than \&quot;not computed\&quot; (another caller, or an older UAM). | [optional] 
**GroupAlias** | **string** |  | [optional] 
**GroupId** | **string** |  | [optional] 
**GroupName** | **string** |  | [optional] 
**IsSubclaimsWithOperator** | **bool** |  | [optional] 
**ModificationDate** | **DateTime** |  | [optional] 
**ScimExternalId** | **string** |  | [optional] 
**ScimManaged** | **bool** |  | [optional] 
**ScimProvisionedAccessId** | **string** |  | [optional] 
**UserAssignments** | [**List&lt;AccessPermissionAssignment&gt;**](AccessPermissionAssignment.md) |  | [optional] 
**VarVersion** | **string** | Version identifies the member assignments this group was read with. Pass it back as UpdateGroupInput.ExpectedVersion to make the update conditional. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

