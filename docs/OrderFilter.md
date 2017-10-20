# ChannelEngine.Api.Client.Model.OrderFilter
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Statuses** | **List&lt;string&gt;** |  | [optional] 
**MerchantOrderNos** | **List&lt;string&gt;** |  | [optional] 
**ExcludeMarketplaceFulfilledOrdersAndLines** | **bool?** |  | [optional] 
**FulfillmentType** | **string** | Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true. | [optional] 
**Page** | **int?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

