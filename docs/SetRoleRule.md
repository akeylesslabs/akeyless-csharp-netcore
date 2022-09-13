# akeyless.Model.SetRoleRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Capability** | **List&lt;string&gt;** | List of the approved/denied capabilities in the path options: [read, create, update, delete, list, deny] | 
**Json** | **bool** | Set output format to JSON | [optional] 
**Path** | **string** | The path the rule refers to | 
**RoleName** | **string** | The role name to be updated | 
**RuleType** | **string** | item-rule, target-rule, role-rule, auth-method-rule, search-rule, reports-rule, gw-reports-rule or sra-reports-rule | [optional] [default to "item-rule"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

