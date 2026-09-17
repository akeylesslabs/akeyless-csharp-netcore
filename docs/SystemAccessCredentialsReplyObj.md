# akeyless.Model.SystemAccessCredentialsReplyObj

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessId** | **string** |  | [optional] 
**AuthCreds** | **string** | Temporary credentials for accessing Auth | [optional] 
**CsrfToken** | **string** | CSRF token for synchronizer-token pattern (only populated for WebUI clients) | [optional] 
**Expiry** | **long** | Credentials expiration date | [optional] 
**KfmCreds** | **string** | Temporary credentials for accessing the KFMs instances | [optional] 
**NeedMfaAppFirstConfig** | **bool** | If the user didn&#39;t complete to configure the MFA app | [optional] 
**RecoveryKeyId** | **string** | RecoveryKeyID identifies the DPoP-bound recovery key for WebUI session recovery. | [optional] 
**RequiredMfa** | **string** |  | [optional] 
**SubClaims** | **Dictionary&lt;string, List&lt;string&gt;&gt;** | SubClaims carries the IdP-verified RBAC claims for offline placeholder creds (empty UAM JWT); parsed from the ID token at callback time. | [optional] 
**Token** | **string** | Credentials tmp token | [optional] 
**UamCreds** | **string** | Temporary credentials for accessing the UAM service | [optional] 
**UniqueId** | **string** | UniqueId is set only on Gateway-minted offline placeholder creds (empty UAM JWT), carrying the IdP unique identifier so usage-time RBAC can resolve identity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

