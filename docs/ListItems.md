# akeyless.Model.ListItems

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Accessibility** | **string** | for personal password manager | [optional] [default to "regular"]
**AdvancedFilter** | **string** | Filter by item name/username/website or part of it | [optional] 
**AutoPagination** | **string** | Retrieve all items using pagination, when disabled retrieving only first 1000 items | [optional] [default to "enabled"]
**Filter** | **string** | Filter by item name or part of it | [optional] 
**Json** | **bool** | Set output format to JSON | [optional] [default to false]
**MinimalView** | **bool** | Show only basic information of the items | [optional] 
**ModifiedAfter** | **long** | List only secrets modified after specified date (in unix time) | [optional] 
**PaginationToken** | **string** | Next page reference | [optional] 
**Path** | **string** | Path to folder | [optional] 
**SraOnly** | **bool** | Filter by items with SRA functionality enabled | [optional] [default to false]
**SubTypes** | **List&lt;string&gt;** |  | [optional] 
**Tag** | **string** | Filter by item tag | [optional] 
**Token** | **string** | Authentication token (see &#x60;/auth&#x60; and &#x60;/configure&#x60;) | [optional] 
**Type** | **List&lt;string&gt;** | The item types list of the requested items. In case it is empty, all types of items will be returned. options: [key, static-secret, dynamic-secret, classic-key] | [optional] 
**UidToken** | **string** | The universal identity token, Required only for universal_identity authentication | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

