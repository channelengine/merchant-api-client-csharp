# ChannelEngine.Api.Client.Model.ChannelOrderRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChannelOrderNo** | **string** | The unique order reference used by the Channel | 
**Lines** | [**List&lt;ChannelOrderLineRequest&gt;**](ChannelOrderLineRequest.md) | The order lines | 
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

