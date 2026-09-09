# akeyless.Model.AgenticRules

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Enabled is a pointer so rules persisted before this field existed (nil) keep enforcing, rather than silently switching off. | [optional] 
**InputRules** | [**List&lt;AgenticRule&gt;**](AgenticRule.md) |  | [optional] 
**OutputRules** | [**List&lt;AgenticRule&gt;**](AgenticRule.md) |  | [optional] 
**QuorumEnabled** | **bool** | QuorumEnabled asks for this item&#39;s policy decisions to be evaluated by every model configured on the gateway rather than the Default alone.  Also a pointer, but with the opposite nil meaning to Enabled above: nil is OFF. Enabled defaults on because it governs rules that were already being enforced before the field existed, whereas quorum is new behavior that multiplies latency and denies fail-closed - an item that never asked for it must not acquire it by upgrade. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

