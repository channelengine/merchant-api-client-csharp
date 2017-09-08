# ChannelEngine.Api.Client.Api.CancellationApi

All URIs are relative to *http://dev.channelengine.local/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancellationCreate**](CancellationApi.md#cancellationcreate) | **POST** /v2/cancellations | Merchant: Create Cancellation
[**CancellationIndex**](CancellationApi.md#cancellationindex) | **GET** /v2/cancellations | Channel: Get Cancellations


<a name="cancellationcreate"></a>
# **CancellationCreate**
> ApiResponse CancellationCreate (MerchantCancellationRequest cancellation)

Merchant: Create Cancellation

For merchants.    Mark (part of) an order as cancelled.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class CancellationCreateExample
    {
        public void main()
        {
            
            // Configure API key authorization: apikey
            Configuration.Default.ApiKey.Add("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("apikey", "Bearer");

            var apiInstance = new CancellationApi();
            var cancellation = new MerchantCancellationRequest(); // MerchantCancellationRequest | 

            try
            {
                // Merchant: Create Cancellation
                ApiResponse result = apiInstance.CancellationCreate(cancellation);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CancellationApi.CancellationCreate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cancellation** | [**MerchantCancellationRequest**](MerchantCancellationRequest.md)|  | 

### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="cancellationindex"></a>
# **CancellationIndex**
> CollectionOfChannelCancellationResponse CancellationIndex (DateTime? createdSince)

Channel: Get Cancellations

For channels.    Gets all cancellations created since the supplied date.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class CancellationIndexExample
    {
        public void main()
        {
            
            // Configure API key authorization: apikey
            Configuration.Default.ApiKey.Add("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("apikey", "Bearer");

            var apiInstance = new CancellationApi();
            var createdSince = 2013-10-20T19:20:30+01:00;  // DateTime? | 

            try
            {
                // Channel: Get Cancellations
                CollectionOfChannelCancellationResponse result = apiInstance.CancellationIndex(createdSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CancellationApi.CancellationIndex: " + e.Message );
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

[**CollectionOfChannelCancellationResponse**](CollectionOfChannelCancellationResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

