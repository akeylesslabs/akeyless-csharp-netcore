# akeyless.Model.ListSRASessions
listSRASessions is a command that returns sra sessions of the given user

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**ResourceType** | **List&lt;string&gt;** | session resource type. In case it is empty, all resources type will be returned. options: [mysql, k8s, ssh, mongodb, mssql, postgres, aws, eks, gke, rdp] | [optional] 
**StatusType** | **List&lt;string&gt;** | session status type. In case it is empty, only active sessions will be returned. options: [connecting, connected, failed, completed, terminated] | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

