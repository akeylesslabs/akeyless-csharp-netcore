# akeyless.Model.AddGatewayAllowedAccessId
Responses:  default: errorResponse 200: addGatewayAllowedAccessIdResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** | The access id that will be able to access to gateway | 
**ClusterName** | **string** | The name of the updated cluster, e.g. acc-abcd12345678/p-123456789012/defaultCluster | 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**SubClaims** | **Dictionary&lt;string, string&gt;** | key/val of sub claims, e.g group&#x3D;admins,developers | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

