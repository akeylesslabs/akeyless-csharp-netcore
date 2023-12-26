# akeyless.Model.GatewayCreateAllowedAccess
gatewayCreateAllowedAccess is a command that creates allowed access in Gator

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubClaimsCaseInsensitive** | **bool** |  | [optional] 
**AccessId** | **string** | Access ID The access id to be attached to this allowed access. Auth method with this access id should already exist. | 
**CaseSensitive** | **string** | Treat sub claims as case-sensitive [true/false] | [optional] [default to "true"]
**Description** | **string** | Allowed access description | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Allowed access name | 
**Permissions** | **string** | Permissions  Comma-seperated list of permissions for this allowed access. Available permissions: [defaults,targets,classic_keys,automatic_migration,ldap_auth,dynamic_secret,k8s_auth,log_forwarding,zero_knowledge_encryption,rotated_secret,caching,event_forwarding,admin,kmip,general] | [optional] 
**SubClaims** | **Dictionary&lt;string, string&gt;** | Sub claims key/val of sub claims, e.g group&#x3D;admins,developers | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

