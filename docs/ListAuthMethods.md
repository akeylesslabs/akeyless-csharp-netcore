# akeyless.Model.ListAuthMethods
listAuthMethods is a command that returns a list of all auth methods in the account. [Deprecated: Use auth-method-list command]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Filter** | **string** | Filter by auth method name or part of it | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**PaginationToken** | **string** | Next page reference | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **List&lt;string&gt;** | The Auth method types list of the requested method. In case it is empty, all types of auth methods will be returned. options: [api_key, azure_ad, oauth2/jwt, saml2, ldap, aws_iam, oidc, universal_identity, gcp, k8s, cert] | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

