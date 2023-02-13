# akeyless.Model.DeleteItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**DeleteImmediately** | **bool** | When delete-in-days&#x3D;-1, must be set | [optional] [default to false]
**DeleteInDays** | **long** | The number of days to wait before deleting the item (relevant for keys only) | [optional] [default to 7]
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Name** | **string** | Item name | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**_Version** | **int** | The specific version you want to delete - 0&#x3D;last version, -1&#x3D;entire item with all versions (default) | [optional] [default to -1]

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

