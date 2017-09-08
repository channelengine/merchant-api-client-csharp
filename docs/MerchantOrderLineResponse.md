# ChannelEngine.Api.Client.Model.MerchantOrderLineResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MerchantProductNo** | **string** |  | [optional] 
**ChannelProductNo** | **string** |  | 
**Quantity** | **int?** |  | 
**UnitPriceInclVat** | **double?** | The value of a single unit of the ordered product including VAT  (in the tenant&#39;s base currency calculated using the exchange rate at the time of ordering). | 
**FeeFixed** | **double?** | A fixed fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable. | [optional] 
**FeeRate** | **double?** | A percentage fee that is charged by the Channel for this orderline.  This field is optional, send 0 if not applicable. | [optional] 
**Condition** | **string** | The condition of the product, this can be used to indicate that a product is a second-hand product | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

