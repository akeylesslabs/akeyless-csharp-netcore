# akeyless.Model.RotatedSecretDetailsInfo
RotatedSecretDetailsInfo The rotated secret rotator info

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AwsUserName** | **string** |  | [optional] 
**DeletePreviousVersionInDays** | **int** |  | [optional] 
**EnableCustomPasswordPolicy** | **bool** |  | [optional] 
**GraceRotation** | **bool** |  | [optional] 
**GraceRotationHour** | **int** |  | [optional] 
**GraceRotationInterval** | **int** |  | [optional] 
**GraceRotationTiming** | **string** |  | [optional] 
**GwClusterId** | **long** |  | [optional] 
**IisAppsDetails** | [**List&lt;WindowsService&gt;**](WindowsService.md) |  | [optional] 
**KeyAlgorithm** | **string** | SSHKeyAlgorithm identifies the key algorithm an SSH rotated secret uses. Kept apart from Algorithm, which is an encryption-key enum and has no ECDSA-384 or ECDSA-521. | [optional] 
**LastRotationError** | **string** |  | [optional] 
**ManagedByAkeyless** | **bool** |  | [optional] 
**MaxVersions** | **long** |  | [optional] 
**NextAutoRotateType** | **string** |  | [optional] 
**NumberOfVersionsToSave** | **int** |  | [optional] 
**PublicKeyRemotePath** | **string** |  | [optional] 
**RotationHour** | **int** |  | [optional] 
**RotationIntervalMin** | **bool** |  | [optional] 
**RotationStatement** | **string** |  | [optional] 
**RotatorCredsType** | **string** |  | [optional] 
**RotatorStatus** | **string** | RotationStatus defines types of rotation Status | [optional] 
**RotatorType** | **string** |  | [optional] 
**SamePassword** | **bool** |  | [optional] 
**ServicesDetails** | [**List&lt;WindowsService&gt;**](WindowsService.md) |  | [optional] 
**SkipDryRun** | **bool** |  | [optional] 
**TimeoutSeconds** | **long** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

