# ChannelEngine.Api.Client.Api.ReturnApi

All URIs are relative to *http://dev.channelengine.local/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ReturnDeclareForChannel**](ReturnApi.md#returndeclareforchannel) | **POST** /v2/returns/channel | Channel: Create Return
[**ReturnDeclareForMerchant**](ReturnApi.md#returndeclareformerchant) | **POST** /v2/returns/merchant | Merchant: Create Return
[**ReturnGetDeclaredByChannel**](ReturnApi.md#returngetdeclaredbychannel) | **GET** /v2/returns/merchant | Merchant: Get Returns
[**ReturnGetDeclaredByMerchant**](ReturnApi.md#returngetdeclaredbymerchant) | **GET** /v2/returns/channel | Channel: Get Returns


<a name="returndeclareforchannel"></a>
# **ReturnDeclareForChannel**
> ApiResponse ReturnDeclareForChannel (ChannelReturnRequest model)

Channel: Create Return

For channels.                Mark (part of) an order as returned by the customer.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class ReturnDeclareForChannelExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apikey", "Bearer");

            var apiInstance = new ReturnApi();
            var model = new ChannelReturnRequest(); // ChannelReturnRequest | 

            try
            {
                // Channel: Create Return
                ApiResponse result = apiInstance.ReturnDeclareForChannel(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnApi.ReturnDeclareForChannel: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**ChannelReturnRequest**](ChannelReturnRequest.md)|  | 

### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returndeclareformerchant"></a>
# **ReturnDeclareForMerchant**
> ApiResponse ReturnDeclareForMerchant (MerchantReturnRequest model)

Merchant: Create Return

For merchants.    Mark (part of) an order as returned by the customer.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class ReturnDeclareForMerchantExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apikey", "Bearer");

            var apiInstance = new ReturnApi();
            var model = new MerchantReturnRequest(); // MerchantReturnRequest | 

            try
            {
                // Merchant: Create Return
                ApiResponse result = apiInstance.ReturnDeclareForMerchant(model);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnApi.ReturnDeclareForMerchant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **model** | [**MerchantReturnRequest**](MerchantReturnRequest.md)|  | 

### Return type

[**ApiResponse**](ApiResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returngetdeclaredbychannel"></a>
# **ReturnGetDeclaredByChannel**
> CollectionOfMerchantReturnResponse ReturnGetDeclaredByChannel (DateTime? createdSince)

Merchant: Get Returns

For merchants.    Get all returns created by the channel. This call is supposed  to be used by merchants. Channels should use the 'GET /v2/returns/channel'  call.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class ReturnGetDeclaredByChannelExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apikey", "Bearer");

            var apiInstance = new ReturnApi();
            var createdSince = 2013-10-20T19:20:30+01:00;  // DateTime? | 

            try
            {
                // Merchant: Get Returns
                CollectionOfMerchantReturnResponse result = apiInstance.ReturnGetDeclaredByChannel(createdSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnApi.ReturnGetDeclaredByChannel: " + e.Message );
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

[**CollectionOfMerchantReturnResponse**](CollectionOfMerchantReturnResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="returngetdeclaredbymerchant"></a>
# **ReturnGetDeclaredByMerchant**
> CollectionOfChannelReturnResponse ReturnGetDeclaredByMerchant (DateTime? createdSince)

Channel: Get Returns

For channels.                Get all returns created by the merchant. This call is supposed  to be used by channels. Merchants should use the 'GET /v2/returns/merchant'  call.

### Example
```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class ReturnGetDeclaredByMerchantExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apikey", "Bearer");

            var apiInstance = new ReturnApi();
            var createdSince = 2013-10-20T19:20:30+01:00;  // DateTime? | 

            try
            {
                // Channel: Get Returns
                CollectionOfChannelReturnResponse result = apiInstance.ReturnGetDeclaredByMerchant(createdSince);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReturnApi.ReturnGetDeclaredByMerchant: " + e.Message );
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

[**CollectionOfChannelReturnResponse**](CollectionOfChannelReturnResponse.md)

### Authorization

[apikey](../README.md#apikey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

