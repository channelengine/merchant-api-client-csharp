# ChannelEngine.Api.Client.Api.OfferApi

All URIs are relative to *http://dev.channelengine.local/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OfferStockPriceUpdate**](OfferApi.md#offerstockpriceupdate) | **PUT** /v2/offer | Update stock or price.


<a name="offerstockpriceupdate"></a>
# **OfferStockPriceUpdate**
> SingleOfCollectionsDictionary2Generic OfferStockPriceUpdate (List<MerchantStockPriceUpdateRequest> updates)

Update stock or price.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class OfferStockPriceUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.ApiKey.Add("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("apikey", "Bearer");

            var apiInstance = new OfferApi();
            var updates = new List<MerchantStockPriceUpdateRequest>(); // List<MerchantStockPriceUpdateRequest> | References to the products that should be updated, and the new values  for the stock or price fields. It is possible to supply only one of the two fields  or both.

            try
            {
                // Update stock or price.
                SingleOfCollectionsDictionary2Generic result = apiInstance.OfferStockPriceUpdate(updates);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OfferApi.OfferStockPriceUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **updates** | [**List&lt;MerchantStockPriceUpdateRequest&gt;**](MerchantStockPriceUpdateRequest.md)| References to the products that should be updated, and the new values  for the stock or price fields. It is possible to supply only one of the two fields  or both. | 

### Return type

[**SingleOfCollectionsDictionary2Generic**](SingleOfCollectionsDictionary2Generic.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

