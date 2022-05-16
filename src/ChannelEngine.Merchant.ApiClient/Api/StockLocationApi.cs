/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.11.0
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
    public interface IStockLocationApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the stock locations (or virtual warehouses).
        /// </summary>
        /// <remarks>
        /// Get the different stock locations (or virtual warehouses) that are in use.&lt;br /&gt;This may include stock locations for &#39;fulfillment by ... (Amazon/bol/CDiscount)&#39; (FBA/LVB/FBC) solutions.&lt;br /&gt;You can use the id&#39;s to get to stock of products in specific stock location, e.g. the FBA stock for the products.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CollectionOfMerchantStockLocationResponse</returns>
        CollectionOfMerchantStockLocationResponse StockLocationIndex();

        /// <summary>
        /// Get the stock locations (or virtual warehouses).
        /// </summary>
        /// <remarks>
        /// Get the different stock locations (or virtual warehouses) that are in use.&lt;br /&gt;This may include stock locations for &#39;fulfillment by ... (Amazon/bol/CDiscount)&#39; (FBA/LVB/FBC) solutions.&lt;br /&gt;You can use the id&#39;s to get to stock of products in specific stock location, e.g. the FBA stock for the products.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CollectionOfMerchantStockLocationResponse</returns>
        ApiResponse<CollectionOfMerchantStockLocationResponse> StockLocationIndexWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStockLocationApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get the stock locations (or virtual warehouses).
        /// </summary>
        /// <remarks>
        /// Get the different stock locations (or virtual warehouses) that are in use.&lt;br /&gt;This may include stock locations for &#39;fulfillment by ... (Amazon/bol/CDiscount)&#39; (FBA/LVB/FBC) solutions.&lt;br /&gt;You can use the id&#39;s to get to stock of products in specific stock location, e.g. the FBA stock for the products.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfMerchantStockLocationResponse</returns>
        System.Threading.Tasks.Task<CollectionOfMerchantStockLocationResponse> StockLocationIndexAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get the stock locations (or virtual warehouses).
        /// </summary>
        /// <remarks>
        /// Get the different stock locations (or virtual warehouses) that are in use.&lt;br /&gt;This may include stock locations for &#39;fulfillment by ... (Amazon/bol/CDiscount)&#39; (FBA/LVB/FBC) solutions.&lt;br /&gt;You can use the id&#39;s to get to stock of products in specific stock location, e.g. the FBA stock for the products.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfMerchantStockLocationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionOfMerchantStockLocationResponse>> StockLocationIndexWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IStockLocationApi : IStockLocationApiSync, IStockLocationApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class StockLocationApi : IStockLocationApi
    {
        private ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StockLocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StockLocationApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StockLocationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StockLocationApi(string basePath)
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
        /// Initializes a new instance of the <see cref="StockLocationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public StockLocationApi(ChannelEngine.Merchant.ApiClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="StockLocationApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public StockLocationApi(ChannelEngine.Merchant.ApiClient.Client.ISynchronousClient client, ChannelEngine.Merchant.ApiClient.Client.IAsynchronousClient asyncClient, ChannelEngine.Merchant.ApiClient.Client.IReadableConfiguration configuration)
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
        /// Get the stock locations (or virtual warehouses). Get the different stock locations (or virtual warehouses) that are in use.&lt;br /&gt;This may include stock locations for &#39;fulfillment by ... (Amazon/bol/CDiscount)&#39; (FBA/LVB/FBC) solutions.&lt;br /&gt;You can use the id&#39;s to get to stock of products in specific stock location, e.g. the FBA stock for the products.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CollectionOfMerchantStockLocationResponse</returns>
        public CollectionOfMerchantStockLocationResponse StockLocationIndex()
        {
            ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantStockLocationResponse> localVarResponse = StockLocationIndexWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the stock locations (or virtual warehouses). Get the different stock locations (or virtual warehouses) that are in use.&lt;br /&gt;This may include stock locations for &#39;fulfillment by ... (Amazon/bol/CDiscount)&#39; (FBA/LVB/FBC) solutions.&lt;br /&gt;You can use the id&#39;s to get to stock of products in specific stock location, e.g. the FBA stock for the products.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CollectionOfMerchantStockLocationResponse</returns>
        public ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantStockLocationResponse> StockLocationIndexWithHttpInfo()
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


            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CollectionOfMerchantStockLocationResponse>("/v2/stocklocations", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("StockLocationIndex", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get the stock locations (or virtual warehouses). Get the different stock locations (or virtual warehouses) that are in use.&lt;br /&gt;This may include stock locations for &#39;fulfillment by ... (Amazon/bol/CDiscount)&#39; (FBA/LVB/FBC) solutions.&lt;br /&gt;You can use the id&#39;s to get to stock of products in specific stock location, e.g. the FBA stock for the products.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfMerchantStockLocationResponse</returns>
        public async System.Threading.Tasks.Task<CollectionOfMerchantStockLocationResponse> StockLocationIndexAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantStockLocationResponse> localVarResponse = await StockLocationIndexWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get the stock locations (or virtual warehouses). Get the different stock locations (or virtual warehouses) that are in use.&lt;br /&gt;This may include stock locations for &#39;fulfillment by ... (Amazon/bol/CDiscount)&#39; (FBA/LVB/FBC) solutions.&lt;br /&gt;You can use the id&#39;s to get to stock of products in specific stock location, e.g. the FBA stock for the products.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfMerchantStockLocationResponse)</returns>
        public async System.Threading.Tasks.Task<ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantStockLocationResponse>> StockLocationIndexWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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


            // authentication (apiKey) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<CollectionOfMerchantStockLocationResponse>("/v2/stocklocations", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("StockLocationIndex", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
