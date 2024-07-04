# akeyless.Model.TargetList
targetList is a command that returns a list of targets

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filter** | **string** | Filter by auth method name or part of it | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**PaginationToken** | **string** | Next page reference | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **List&lt;string&gt;** | The target types list . In case it is empty, all types of targets will be returned. options: [hanadb cassandra aws ssh gke eks mysql mongodb snowflake mssql redshift artifactory azure rabbitmq k8s venafi gcp oracle dockerhub ldap github chef web salesforce postgres] | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

