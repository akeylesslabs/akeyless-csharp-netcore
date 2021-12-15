# akeyless.Model.DeleteItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteImmediately** | **bool** | When delete-in-days&#x3D;-1, must be set | [optional] [default to false]
**DeleteInDays** | **long** | The number of days to wait before deleting the item (relevant for keys only) | [optional] [default to 7]
**Name** | **string** | Item name | 
**Password** | **string** | Required only when the authentication process requires a username and password | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Required only when the authentication process requires a username and password | [optional] 
**_Version** | **int** | The specific version you want to delete - 0&#x3D;last version, -1&#x3D;entire item with all versions (default) | [optional] [default to -1]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

