/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.13.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using ChannelEngine.Merchant.ApiClient.Client;
using ChannelEngine.Merchant.ApiClient.Model;

namespace ChannelEngine.Merchant.ApiClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompetitionPriceApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the BuyBox winner prices
        /// </summary>
        /// <remarks>
        /// Get the current price of the BuyBox winner per product for a channel.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of the channel (optional)</param>
        /// <param name="gtinList">Search products by submitting a list of GTIN&#39;s. (optional)&lt;br /&gt;Max. 2000. (optional)</param>
        /// <param name="skuList">Search products by submitting a list of Sku&#39;s. (optional)&lt;br /&gt;Max. 2000. If GtinList is already set, this one is ignored. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfMerchantProductWithBuyBoxPrice</returns>
        CollectionOfMerchantProductWithBuyBoxPrice CompetitionPricesGetBuyBoxPrices(int? channelId = default(int?), List<string> gtinList = default(List<string>), List<string> skuList = default(List<string>), int? page = default(int?));

        /// <summary>
        /// Get the BuyBox winner prices
        /// </summary>
        /// <remarks>
        /// Get the current price of the BuyBox winner per product for a channel.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of the channel (optional)</param>
        /// <param name="gtinList">Search products by submitting a list of GTIN&#39;s. (optional)&lt;br /&gt;Max. 2000. (optional)</param>
        /// <param name="skuList">Search products by submitting a list of Sku&#39;s. (optional)&lt;br /&gt;Max. 2000. If GtinList is already set, this one is ignored. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfMerchantProductWithBuyBoxPrice</returns>
        ApiResponse<CollectionOfMerchantProductWithBuyBoxPrice> CompetitionPricesGetBuyBoxPricesWithHttpInfo(int? channelId = default(int?), List<string> gtinList = default(List<string>), List<string> skuList = default(List<string>), int? page = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompetitionPriceApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the BuyBox winner prices
        /// </summary>
        /// <remarks>
        /// Get the current price of the BuyBox winner per product for a channel.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of the channel (optional)</param>
        /// <param name="gtinList">Search products by submitting a list of GTIN&#39;s. (optional)&lt;br /&gt;Max. 2000. (optional)</param>
        /// <param name="skuList">Search products by submitting a list of Sku&#39;s. (optional)&lt;br /&gt;Max. 2000. If GtinList is already set, this one is ignored. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfMerchantProductWithBuyBoxPrice</returns>
        System.Threading.Tasks.Task<CollectionOfMerchantProductWithBuyBoxPrice> CompetitionPricesGetBuyBoxPricesAsync(int? channelId = default(int?), List<string> gtinList = default(List<string>), List<string> skuList = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the BuyBox winner prices
        /// </summary>
        /// <remarks>
        /// Get the current price of the BuyBox winner per product for a channel.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of the channel (optional)</param>
        /// <param name="gtinList">Search products by submitting a list of GTIN&#39;s. (optional)&lt;br /&gt;Max. 2000. (optional)</param>
        /// <param name="skuList">Search products by submitting a list of Sku&#39;s. (optional)&lt;br /&gt;Max. 2000. If GtinList is already set, this one is ignored. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfMerchantProductWithBuyBoxPrice)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionOfMerchantProductWithBuyBoxPrice>> CompetitionPricesGetBuyBoxPricesWithHttpInfoAsync(int? channelId = default(int?), List<string> gtinList = default(List<string>), List<string> skuList = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompetitionPriceApi : ICompetitionPriceApiSync, ICompetitionPriceApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CompetitionPriceApi : ICompetitionPriceApi
    {
        private ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitionPriceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompetitionPriceApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitionPriceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompetitionPriceApi(string basePath)
        {
            this.Configuration = ChannelEngine.Merchant.ApiClient.Client.Configuration.MergeConfigurations(
                ChannelEngine.Merchant.ApiClient.Client.GlobalConfiguration.Instance,
                new ChannelEngine.Merchant.ApiClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new ChannelEngine.Merchant.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ChannelEngine.Merchant.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = ChannelEngine.Merchant.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitionPriceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CompetitionPriceApi(ChannelEngine.Merchant.ApiClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = ChannelEngine.Merchant.ApiClient.Client.Configuration.MergeConfigurations(
                ChannelEngine.Merchant.ApiClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new ChannelEngine.Merchant.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new ChannelEngine.Merchant.ApiClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = ChannelEngine.Merchant.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitionPriceApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CompetitionPriceApi(ChannelEngine.Merchant.ApiClient.Client.ISynchronousClient client, ChannelEngine.Merchant.ApiClient.Client.IAsynchronousClient asyncClient, ChannelEngine.Merchant.ApiClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = ChannelEngine.Merchant.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public ChannelEngine.Merchant.ApiClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public ChannelEngine.Merchant.ApiClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ChannelEngine.Merchant.ApiClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Get the BuyBox winner prices Get the current price of the BuyBox winner per product for a channel.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of the channel (optional)</param>
        /// <param name="gtinList">Search products by submitting a list of GTIN&#39;s. (optional)&lt;br /&gt;Max. 2000. (optional)</param>
        /// <param name="skuList">Search products by submitting a list of Sku&#39;s. (optional)&lt;br /&gt;Max. 2000. If GtinList is already set, this one is ignored. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfMerchantProductWithBuyBoxPrice</returns>
        public CollectionOfMerchantProductWithBuyBoxPrice CompetitionPricesGetBuyBoxPrices(int? channelId = default(int?), List<string> gtinList = default(List<string>), List<string> skuList = default(List<string>), int? page = default(int?))
        {
            ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantProductWithBuyBoxPrice> localVarResponse = CompetitionPricesGetBuyBoxPricesWithHttpInfo(channelId, gtinList, skuList, page);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the BuyBox winner prices Get the current price of the BuyBox winner per product for a channel.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of the channel (optional)</param>
        /// <param name="gtinList">Search products by submitting a list of GTIN&#39;s. (optional)&lt;br /&gt;Max. 2000. (optional)</param>
        /// <param name="skuList">Search products by submitting a list of Sku&#39;s. (optional)&lt;br /&gt;Max. 2000. If GtinList is already set, this one is ignored. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfMerchantProductWithBuyBoxPrice</returns>
        public ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantProductWithBuyBoxPrice> CompetitionPricesGetBuyBoxPricesWithHttpInfo(int? channelId = default(int?), List<string> gtinList = default(List<string>), List<string> skuList = default(List<string>), int? page = default(int?))
        {
            ChannelEngine.Merchant.ApiClient.Client.RequestOptions localVarRequestOptions = new ChannelEngine.Merchant.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = ChannelEngine.Merchant.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ChannelEngine.Merchant.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (channelId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "channelId", channelId));
            }
            if (gtinList != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "gtinList", gtinList));
            }
            if (skuList != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "skuList", skuList));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CollectionOfMerchantProductWithBuyBoxPrice>("/v2/competitionprices/buyboxprices", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CompetitionPricesGetBuyBoxPrices", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the BuyBox winner prices Get the current price of the BuyBox winner per product for a channel.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of the channel (optional)</param>
        /// <param name="gtinList">Search products by submitting a list of GTIN&#39;s. (optional)&lt;br /&gt;Max. 2000. (optional)</param>
        /// <param name="skuList">Search products by submitting a list of Sku&#39;s. (optional)&lt;br /&gt;Max. 2000. If GtinList is already set, this one is ignored. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfMerchantProductWithBuyBoxPrice</returns>
        public async System.Threading.Tasks.Task<CollectionOfMerchantProductWithBuyBoxPrice> CompetitionPricesGetBuyBoxPricesAsync(int? channelId = default(int?), List<string> gtinList = default(List<string>), List<string> skuList = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantProductWithBuyBoxPrice> localVarResponse = await CompetitionPricesGetBuyBoxPricesWithHttpInfoAsync(channelId, gtinList, skuList, page, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the BuyBox winner prices Get the current price of the BuyBox winner per product for a channel.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of the channel (optional)</param>
        /// <param name="gtinList">Search products by submitting a list of GTIN&#39;s. (optional)&lt;br /&gt;Max. 2000. (optional)</param>
        /// <param name="skuList">Search products by submitting a list of Sku&#39;s. (optional)&lt;br /&gt;Max. 2000. If GtinList is already set, this one is ignored. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfMerchantProductWithBuyBoxPrice)</returns>
        public async System.Threading.Tasks.Task<ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantProductWithBuyBoxPrice>> CompetitionPricesGetBuyBoxPricesWithHttpInfoAsync(int? channelId = default(int?), List<string> gtinList = default(List<string>), List<string> skuList = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ChannelEngine.Merchant.ApiClient.Client.RequestOptions localVarRequestOptions = new ChannelEngine.Merchant.ApiClient.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };


            var localVarContentType = ChannelEngine.Merchant.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ChannelEngine.Merchant.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (channelId != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "channelId", channelId));
            }
            if (gtinList != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "gtinList", gtinList));
            }
            if (skuList != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "skuList", skuList));
            }
            if (page != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "page", page));
            }

            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<CollectionOfMerchantProductWithBuyBoxPrice>("/v2/competitionprices/buyboxprices", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CompetitionPricesGetBuyBoxPrices", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
