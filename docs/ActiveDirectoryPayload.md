# akeyless.Model.ActiveDirectoryPayload

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActiveDirectoryTargetId** | **long** |  | [optional] 
**AiCertificateDiscovery** | **bool** |  | [optional] 
**AutoRotate** | **bool** |  | [optional] 
**AutoRotateIntervalInDays** | **int** |  | [optional] 
**AutoRotateRotationHour** | **int** |  | [optional] 
**CertificatesExpirationEvents** | [**List&lt;CertificateExpirationEvent&gt;**](CertificateExpirationEvent.md) |  | [optional] 
**CertificatesPathTemplate** | **string** |  | [optional] 
**ComputerBaseDn** | **string** |  | [optional] 
**DiscoverIisApps** | **bool** |  | [optional] 
**DiscoverLocalUsers** | **bool** | Deprecated | [optional] 
**DiscoverServices** | **bool** |  | [optional] 
**DiscoveryTypes** | **List&lt;string&gt;** |  | [optional] 
**DomainName** | **string** |  | [optional] 
**DomainServerTargetsPathTemplate** | **string** |  | [optional] 
**DomainUsersRotatedSecretsPathTemplate** | **string** |  | [optional] 
**EnablePasswordPolicy** | **bool** | EnablePasswordPolicy enables applying PasswordPolicy to newly created domain/local user rotated secrets. Pointer so omitted values are preserved on partial update (nil &#x3D; not provided). | [optional] 
**EnableRdpSra** | **bool** |  | [optional] 
**LocalUsersIgnoreList** | **Dictionary&lt;string, bool&gt;** |  | [optional] 
**LocalUsersRotatedSecretsPathTemplate** | **string** |  | [optional] 
**OsFilter** | **string** |  | [optional] 
**PasswordPolicy** | [**PasswordPolicyInfo**](PasswordPolicyInfo.md) |  | [optional] 
**SkipDryRun** | **bool** | SkipDryRun enables skip_dry_run on newly created domain/local user rotated secrets. Pointer so omitted values are preserved on partial update (nil &#x3D; not provided). When false/unset, existing rotated-secret SkipDryRun values are left unchanged on sync. | [optional] 
**SshPort** | **string** |  | [optional] 
**TargetFormat** | **string** |  | [optional] 
**TargetsType** | **string** |  | [optional] 
**UserBaseDn** | **string** |  | [optional] 
**UserGroups** | **List&lt;string&gt;** |  | [optional] 
**WinrmOverHttp** | **bool** |  | [optional] 
**WinrmPort** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

