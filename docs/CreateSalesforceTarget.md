# akeyless.Model.CreateSalesforceTarget

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AppPrivateKeyData** | **string** | Base64 encoded PEM of the connected app private key (relevant for JWT auth only) | [optional] 
**AuthFlow** | **string** | type of the auth flow (&#39;jwt&#39; / &#39;user-password&#39;) | 
**CaCertData** | **string** | Base64 encoded PEM cert to use when uploading a new key to Salesforce | [optional] 
**CaCertName** | **string** | name of the certificate in Salesforce tenant to use when uploading new key | [optional] 
**ClientId** | **string** | Client ID of the oauth2 app to use for connecting to Salesforce | 
**ClientSecret** | **string** | Client secret of the oauth2 app to use for connecting to Salesforce (required for password flow) | [optional] 
**Comment** | **string** | Comment about the target | [optional] 
**Email** | **string** | The email of the user attached to the oauth2 app used for connecting to Salesforce | 
**Json** | **bool** | Set output format to JSON | [optional] 
**Key** | **string** | The name of a key that used to encrypt the target secret value (if empty, the account default protectionKey key will be used) | [optional] 
**Name** | **string** | Target name | 
**Password** | **string** | The password of the user attached to the oauth2 app used for connecting to Salesforce (required for user-password flow) | [optional] 
**SecurityToken** | **string** | The security token of the user attached to the oauth2 app used for connecting to Salesforce  (required for user-password flow) | [optional] 
**TenantUrl** | **string** | Url of the Salesforce tenant | 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

