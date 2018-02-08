# ChannelEngine
Please visit https://www.channelengine.com/developers/ for more information.
The API reference can be found at https://demo.channelengine.net/api/swagger/ui/index

## Getting Started

```csharp
using System;
using System.Diagnostics;
using ChannelEngine.Api.Client.Api;
using ChannelEngine.Api.Client.Client;
using ChannelEngine.Api.Client.Model;

namespace Example
{
    public class Example
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
