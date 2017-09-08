# ChannelEngine.Api.Client.Model.ChannelProductResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | An unique identifier which ChannelEngine uses to identify the product.  Needed in the call &#39;POST /v2/products/data&#39; | [optional] 
**ParentChannelProductNo** | **string** |  | [optional] 
**MappedFields** | **Dictionary&lt;string, string&gt;** | A channel can require certain fields to be available. The channel  can provide ChannelEngine with this fields after which the merchants  will be able to fill in this field using custom conditions in ChannelEngine. | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Brand** | **string** |  | [optional] 
**Size** | **string** |  | [optional] 
**Color** | **string** |  | [optional] 
**Ean** | **string** |  | [optional] 
**ManufacturerProductNumber** | **string** |  | [optional] 
**Stock** | **int?** |  | [optional] 
**Price** | **double?** | Price, including VAT. | [optional] 
**MSRP** | **double?** | Manufacturer&#39;s suggested retail price | [optional] 
**PurchasePrice** | **double?** |  | [optional] 
**VatRateType** | **string** | The type of VAT which applies to this product.  See: http://ec.europa.eu/taxation_customs/taxation/vat/topics/rates_en.htm | [optional] 
**ShippingCost** | **double?** |  | [optional] 
**ShippingTime** | **string** | A textual representation of the shippingtime.  For example, in Dutch: &#39;Op werkdagen voor 22:00 uur besteld, morgen in huis&#39; | [optional] 
**Url** | **string** | A URL pointing to the merchant&#39;s webpage  which displays this product. | [optional] 
**ImageUrl** | **string** | A URL at which an image of this product  can be found. | [optional] 
**CategoryTrail** | **string** | The category to which this product belongs.  Please supply this field in the following format:  &#39;maincategory &amp;gt; category &amp;gt; subcategory&#39;  For example:  &#39;vehicles &amp;gt; bikes &amp;gt; mountainbike&#39; | [optional] 
**ExtraData** | [**List&lt;ExtraDataItem&gt;**](ExtraDataItem.md) | An optional list of key-value pairs containing  extra data about this product. This data can be  sent to channels or used for filtering products. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

