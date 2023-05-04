# akeyless.Model.CreateGlobalSignTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Comment** | **string** | Deprecated - use description | [optional] 
**ContactEmail** | **string** | Email of the GlobalSign GCC account contact | 
**ContactFirstName** | **string** | First name of the GlobalSign GCC account contact | 
**ContactLastName** | **string** | Last name of the GlobalSign GCC account contact | 
**ContactPhone** | **string** | Telephone of the GlobalSign GCC account contact | 
**Description** | **string** | Description of the object | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | Target name | 
**Password** | **string** | Password of the GlobalSign GCC account | 
**ProfileId** | **string** | Profile ID of the GlobalSign GCC account | 
**Timeout** | **string** | Timeout waiting for certificate validation in Duration format (1h - 1 Hour, 20m - 20 Minutes, 33m3s - 33 Minutes and 3 Seconds), maximum 1h. | [optional] [default to "5m"]
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 
**Username** | **string** | Username of the GlobalSign GCC account | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

