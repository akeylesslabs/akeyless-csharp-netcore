# akeyless.Model.AiQuorumSetting
It is the outermost of the three gates a quorum needs (account, then the item's own toggle, then more than one model configured on the gateway). Off means every item evaluates against the Default model alone, whatever the items and gateways below it are configured with - so an operator can stop quorum account-wide in one action if a provider starts failing, without unpicking per-item configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enable** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

