# ChannelEngine.Api.Client.Api.ShipmentApi

All URIs are relative to *http://dev.channelengine.local/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ShipmentCreate**](ShipmentApi.md#shipmentcreate) | **POST** /v2/shipments | Merchant: Create Shipment
[**ShipmentIndex**](ShipmentApi.md#shipmentindex) | **GET** /v2/shipments | Channel: Get Shipments
[**ShipmentUpdate**](ShipmentApi.md#shipmentupdate) | **PUT** /v2/shipments/{merchantShipmentNo} | Merchant: Update Shipment


<a name="shipmentcreate"></a>
# **ShipmentCreate**
> ApiResponse ShipmentCreate (MerchantShipmentRequest model)

Merchant: Create Shipment

For merchants.    Mark (part of) an order as shipped.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class ShipmentCreateExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apikey", "Bearer");

            var apiInstance = new ShipmentApi();
            var model = new MerchantShipmentRequest(); // MerchantShipmentRequest | 

            try
            {
                // Merchant: Create Shipment
                ApiResponse result = apiInstance.ShipmentCreate(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**MerchantShipmentRequest**](MerchantShipmentRequest.md)|  | 

### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentindex"></a>
# **ShipmentIndex**
> CollectionOfChannelShipmentResponse ShipmentIndex (DateTime? createdSince)

Channel: Get Shipments

For channels.    Gets all shipments created since the supplied date.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class ShipmentIndexExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apikey", "Bearer");

            var apiInstance = new ShipmentApi();
            var createdSince = 2013-10-20T19:20:30+01:00;  // DateTime? | 

            try
            {
                // Channel: Get Shipments
                CollectionOfChannelShipmentResponse result = apiInstance.ShipmentIndex(createdSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentIndex: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createdSince** | **DateTime?**|  | 

### Return type

[**CollectionOfChannelShipmentResponse**](CollectionOfChannelShipmentResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="shipmentupdate"></a>
# **ShipmentUpdate**
> ApiResponse ShipmentUpdate (string merchantShipmentNo, MerchantShipmentTrackingRequest model)

Merchant: Update Shipment

For merchants.    Update an existing shipment with tracking information

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class ShipmentUpdateExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apikey", "Bearer");

            var apiInstance = new ShipmentApi();
            var merchantShipmentNo = merchantShipmentNo_example;  // string | The merchant's shipment reference
            var model = new MerchantShipmentTrackingRequest(); // MerchantShipmentTrackingRequest | The updated tracking information

            try
            {
                // Merchant: Update Shipment
                ApiResponse result = apiInstance.ShipmentUpdate(merchantShipmentNo, model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentUpdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **merchantShipmentNo** | **string**| The merchant&#39;s shipment reference | 
 **model** | [**MerchantShipmentTrackingRequest**](MerchantShipmentTrackingRequest.md)| The updated tracking information | 

### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

