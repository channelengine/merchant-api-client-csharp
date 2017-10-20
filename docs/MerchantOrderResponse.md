# ChannelEngine.Api.Client.Model.MerchantOrderResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | The unique identifier used by ChannelEngine. This identifier does  not have to be saved. It should only be used in a call to acknowledge the order. | [optional] 
**ChannelName** | **string** |  | [optional] 
**ChannelOrderSupport** | **string** |  | [optional] 
**ChannelOrderNo** | **string** |  | [optional] 
**Status** | **string** |  | [optional] 
**Lines** | [**List&lt;MerchantOrderLineResponse&gt;**](MerchantOrderLineResponse.md) |  | [optional] 
**Phone** | **string** |  | [optional] 
**Email** | **string** |  | 
**CompanyRegistrationNo** | **string** |  | [optional] 
**VatNo** | **string** |  | [optional] 
**PaymentMethod** | **string** |  | 
**ShippingCostsInclVat** | **double?** | The shipping fee including VAT  (in the tenant&#39;s base currency calculated using the exchange rate at the time of ordering). | 
**CurrencyCode** | **string** |  | 
**OrderDate** | **DateTime?** |  | 
**ChannelCustomerNo** | **string** |  | [optional] 
**BillingAddress** | [**EntitiesAddressModels**](EntitiesAddressModels.md) |  | 
**ShippingAddress** | [**EntitiesAddressModels**](EntitiesAddressModels.md) |  | 
**ExtraData** | **Dictionary&lt;string, string&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

