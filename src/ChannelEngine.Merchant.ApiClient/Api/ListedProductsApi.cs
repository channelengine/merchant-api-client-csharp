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
    public interface IListedProductsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Listed Products
        /// </summary>
        /// <remarks>
        /// Gets the status of products listed for channel (export status) and on a channel (channel status).&lt;br /&gt;Includes products that were previously deleted from but are now set to be created again.&lt;br /&gt;Note: not all channels provide adequate options to retrieve the status on the channel.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of a channel</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfChannelListedProductResponse</returns>
        CollectionOfChannelListedProductResponse ListedProductGetByFilter(int channelId, int? page = default(int?));

        /// <summary>
        /// Get Listed Products
        /// </summary>
        /// <remarks>
        /// Gets the status of products listed for channel (export status) and on a channel (channel status).&lt;br /&gt;Includes products that were previously deleted from but are now set to be created again.&lt;br /&gt;Note: not all channels provide adequate options to retrieve the status on the channel.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of a channel</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfChannelListedProductResponse</returns>
        ApiResponse<CollectionOfChannelListedProductResponse> ListedProductGetByFilterWithHttpInfo(int channelId, int? page = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IListedProductsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get Listed Products
        /// </summary>
        /// <remarks>
        /// Gets the status of products listed for channel (export status) and on a channel (channel status).&lt;br /&gt;Includes products that were previously deleted from but are now set to be created again.&lt;br /&gt;Note: not all channels provide adequate options to retrieve the status on the channel.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of a channel</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfChannelListedProductResponse</returns>
        System.Threading.Tasks.Task<CollectionOfChannelListedProductResponse> ListedProductGetByFilterAsync(int channelId, int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get Listed Products
        /// </summary>
        /// <remarks>
        /// Gets the status of products listed for channel (export status) and on a channel (channel status).&lt;br /&gt;Includes products that were previously deleted from but are now set to be created again.&lt;br /&gt;Note: not all channels provide adequate options to retrieve the status on the channel.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of a channel</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfChannelListedProductResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionOfChannelListedProductResponse>> ListedProductGetByFilterWithHttpInfoAsync(int channelId, int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IListedProductsApi : IListedProductsApiSync, IListedProductsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ListedProductsApi : IListedProductsApi
    {
        private ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ListedProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ListedProductsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListedProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ListedProductsApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ListedProductsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ListedProductsApi(ChannelEngine.Merchant.ApiClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ListedProductsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ListedProductsApi(ChannelEngine.Merchant.ApiClient.Client.ISynchronousClient client, ChannelEngine.Merchant.ApiClient.Client.IAsynchronousClient asyncClient, ChannelEngine.Merchant.ApiClient.Client.IReadableConfiguration configuration)
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
        /// Get Listed Products Gets the status of products listed for channel (export status) and on a channel (channel status).&lt;br /&gt;Includes products that were previously deleted from but are now set to be created again.&lt;br /&gt;Note: not all channels provide adequate options to retrieve the status on the channel.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of a channel</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfChannelListedProductResponse</returns>
        public CollectionOfChannelListedProductResponse ListedProductGetByFilter(int channelId, int? page = default(int?))
        {
            ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfChannelListedProductResponse> localVarResponse = ListedProductGetByFilterWithHttpInfo(channelId, page);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Listed Products Gets the status of products listed for channel (export status) and on a channel (channel status).&lt;br /&gt;Includes products that were previously deleted from but are now set to be created again.&lt;br /&gt;Note: not all channels provide adequate options to retrieve the status on the channel.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of a channel</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfChannelListedProductResponse</returns>
        public ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfChannelListedProductResponse> ListedProductGetByFilterWithHttpInfo(int channelId, int? page = default(int?))
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

            localVarRequestOptions.PathParameters.Add("channelId", ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToString(channelId)); // path parameter
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
            var localVarResponse = this.Client.Get<CollectionOfChannelListedProductResponse>("/v2/channels/{channelId}/products", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListedProductGetByFilter", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get Listed Products Gets the status of products listed for channel (export status) and on a channel (channel status).&lt;br /&gt;Includes products that were previously deleted from but are now set to be created again.&lt;br /&gt;Note: not all channels provide adequate options to retrieve the status on the channel.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of a channel</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfChannelListedProductResponse</returns>
        public async System.Threading.Tasks.Task<CollectionOfChannelListedProductResponse> ListedProductGetByFilterAsync(int channelId, int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfChannelListedProductResponse> localVarResponse = await ListedProductGetByFilterWithHttpInfoAsync(channelId, page, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get Listed Products Gets the status of products listed for channel (export status) and on a channel (channel status).&lt;br /&gt;Includes products that were previously deleted from but are now set to be created again.&lt;br /&gt;Note: not all channels provide adequate options to retrieve the status on the channel.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="channelId">The id of a channel</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfChannelListedProductResponse)</returns>
        public async System.Threading.Tasks.Task<ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfChannelListedProductResponse>> ListedProductGetByFilterWithHttpInfoAsync(int channelId, int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            localVarRequestOptions.PathParameters.Add("channelId", ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToString(channelId)); // path parameter
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CollectionOfChannelListedProductResponse>("/v2/channels/{channelId}/products", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ListedProductGetByFilter", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
