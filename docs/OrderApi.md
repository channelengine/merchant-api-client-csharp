# ChannelEngine.Api.Client.Api.OrderApi

All URIs are relative to *http://dev.channelengine.local/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OrderAcknowledge**](OrderApi.md#orderacknowledge) | **POST** /v2/orders/acknowledge | Merchant: Acknowledge Order
[**OrderCreate**](OrderApi.md#ordercreate) | **POST** /v2/orders | Channel: Create Order
[**OrderGetByFilter**](OrderApi.md#ordergetbyfilter) | **GET** /v2/orders | Merchant: Get Orders By Filter
[**OrderGetNew**](OrderApi.md#ordergetnew) | **GET** /v2/orders/new | Merchant: Get New Orders
[**OrderInvoice**](OrderApi.md#orderinvoice) | **GET** /v2/orders/{merchantOrderNo}/invoice | Merchant: Download Invoice
[**OrderPackingSlip**](OrderApi.md#orderpackingslip) | **GET** /v2/orders/{merchantOrderNo}/packingslip | Merchant: Download Packing Slip


<a name="orderacknowledge"></a>
# **OrderAcknowledge**
> ApiResponse OrderAcknowledge (OrderAcknowledgement model)

Merchant: Acknowledge Order

For merchants.    Acknowledge an order. By acknowledging the order the merchant can confirm that  the order has been imported. When acknowledging an order the merchant has to supply  references that uniquely identify the order and the order lines. These references  will be used in the other API calls.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class OrderAcknowledgeExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.ApiKey.Add("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("apikey", "Bearer");

            var apiInstance = new OrderApi();
            var model = new OrderAcknowledgement(); // OrderAcknowledgement | Relations between the id's returned by ChannelEngine and the references which the merchant uses

            try
            {
                // Merchant: Acknowledge Order
                ApiResponse result = apiInstance.OrderAcknowledge(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderAcknowledge: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**OrderAcknowledgement**](OrderAcknowledgement.md)| Relations between the id&#39;s returned by ChannelEngine and the references which the merchant uses | 

### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordercreate"></a>
# **OrderCreate**
> ApiResponse OrderCreate (ChannelOrderRequest model)

Channel: Create Order

For channels.    Create a new order in ChannelEngine.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class OrderCreateExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.ApiKey.Add("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("apikey", "Bearer");

            var apiInstance = new OrderApi();
            var model = new ChannelOrderRequest(); // ChannelOrderRequest | 

            try
            {
                // Channel: Create Order
                ApiResponse result = apiInstance.OrderCreate(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**ChannelOrderRequest**](ChannelOrderRequest.md)|  | 

### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetbyfilter"></a>
# **OrderGetByFilter**
> CollectionOfMerchantOrderResponse OrderGetByFilter (List<string> filterStatuses = null, List<string> filterMerchantOrderNos = null, bool? filterExcludeMarketplaceFulfilledOrdersAndLines = null, string filterFulfillmentType = null, int? filterPage = null)

Merchant: Get Orders By Filter

For merchants.                Fetch orders based on the provided OrderFilter

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class OrderGetByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.ApiKey.Add("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("apikey", "Bearer");

            var apiInstance = new OrderApi();
            var filterStatuses = new List<string>(); // List<string> |  (optional) 
            var filterMerchantOrderNos = new List<string>(); // List<string> |  (optional) 
            var filterExcludeMarketplaceFulfilledOrdersAndLines = true;  // bool? |  (optional) 
            var filterFulfillmentType = filterFulfillmentType_example;  // string | Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true. (optional) 
            var filterPage = 56;  // int? |  (optional) 

            try
            {
                // Merchant: Get Orders By Filter
                CollectionOfMerchantOrderResponse result = apiInstance.OrderGetByFilter(filterStatuses, filterMerchantOrderNos, filterExcludeMarketplaceFulfilledOrdersAndLines, filterFulfillmentType, filterPage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filterStatuses** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **filterMerchantOrderNos** | [**List&lt;string&gt;**](string.md)|  | [optional] 
 **filterExcludeMarketplaceFulfilledOrdersAndLines** | **bool?**|  | [optional] 
 **filterFulfillmentType** | **string**| Filter orders on fulfillment type. This will include all orders lines, even if they are partially fulfilled by the marketplace.  To exclude orders and lines that are fulfilled by the marketplace from the response, set ExcludeMarketplaceFulfilledOrdersAndLines to true. | [optional] 
 **filterPage** | **int?**|  | [optional] 

### Return type

[**CollectionOfMerchantOrderResponse**](CollectionOfMerchantOrderResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ordergetnew"></a>
# **OrderGetNew**
> CollectionOfMerchantOrderResponse OrderGetNew ()

Merchant: Get New Orders

For merchants.                Fetch newly placed orders (order with status NEW).

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class OrderGetNewExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.ApiKey.Add("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("apikey", "Bearer");

            var apiInstance = new OrderApi();

            try
            {
                // Merchant: Get New Orders
                CollectionOfMerchantOrderResponse result = apiInstance.OrderGetNew();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderGetNew: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CollectionOfMerchantOrderResponse**](CollectionOfMerchantOrderResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderinvoice"></a>
# **OrderInvoice**
> System.IO.Stream OrderInvoice (string merchantOrderNo, bool? useCustomerCulture = null)

Merchant: Download Invoice

For merchants.    Generates the ChannelEngine VAT invoice for this order in PDF

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class OrderInvoiceExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.ApiKey.Add("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("apikey", "Bearer");

            var apiInstance = new OrderApi();
            var merchantOrderNo = merchantOrderNo_example;  // string | The unique order reference as used by the merchant
            var useCustomerCulture = true;  // bool? | Generate the invoice in the billing address' country's language (optional) 

            try
            {
                // Merchant: Download Invoice
                System.IO.Stream result = apiInstance.OrderInvoice(merchantOrderNo, useCustomerCulture);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderInvoice: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantOrderNo** | **string**| The unique order reference as used by the merchant | 
 **useCustomerCulture** | **bool?**| Generate the invoice in the billing address&#39; country&#39;s language | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="orderpackingslip"></a>
# **OrderPackingSlip**
> System.IO.Stream OrderPackingSlip (string merchantOrderNo, bool? useCustomerCulture = null)

Merchant: Download Packing Slip

For merchants.    Generates the ChannelEngine packing slip for this order in PDF

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class OrderPackingSlipExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.ApiKey.Add("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("apikey", "Bearer");

            var apiInstance = new OrderApi();
            var merchantOrderNo = merchantOrderNo_example;  // string | The unique order reference as used by the merchant
            var useCustomerCulture = true;  // bool? | Generate the invoice in the billing address' country's language (optional) 

            try
            {
                // Merchant: Download Packing Slip
                System.IO.Stream result = apiInstance.OrderPackingSlip(merchantOrderNo, useCustomerCulture);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderApi.OrderPackingSlip: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantOrderNo** | **string**| The unique order reference as used by the merchant | 
 **useCustomerCulture** | **bool?**| Generate the invoice in the billing address&#39; country&#39;s language | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/pdf

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

