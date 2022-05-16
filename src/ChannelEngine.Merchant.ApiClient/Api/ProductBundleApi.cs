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
    public interface IProductBundleApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get product bundles.
        /// </summary>
        /// <remarks>
        /// You can get the full product information on bundles from the regular /products endpoint.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search product(s) by Name, MerchantProductNo, Ean or Brand&lt;br /&gt;This search is applied to the result after applying the other filters. (optional)</param>
        /// <param name="eanList">Search products by submitting a list of EAN&#39;s. (optional)</param>
        /// <param name="merchantProductNoList">Search products by submitting a list of MerchantProductNo&#39;s. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfMerchantProductBundleResponse</returns>
        CollectionOfMerchantProductBundleResponse ProductBundleGetByFilter(string search = default(string), List<string> eanList = default(List<string>), List<string> merchantProductNoList = default(List<string>), int? page = default(int?));

        /// <summary>
        /// Get product bundles.
        /// </summary>
        /// <remarks>
        /// You can get the full product information on bundles from the regular /products endpoint.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search product(s) by Name, MerchantProductNo, Ean or Brand&lt;br /&gt;This search is applied to the result after applying the other filters. (optional)</param>
        /// <param name="eanList">Search products by submitting a list of EAN&#39;s. (optional)</param>
        /// <param name="merchantProductNoList">Search products by submitting a list of MerchantProductNo&#39;s. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfMerchantProductBundleResponse</returns>
        ApiResponse<CollectionOfMerchantProductBundleResponse> ProductBundleGetByFilterWithHttpInfo(string search = default(string), List<string> eanList = default(List<string>), List<string> merchantProductNoList = default(List<string>), int? page = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductBundleApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get product bundles.
        /// </summary>
        /// <remarks>
        /// You can get the full product information on bundles from the regular /products endpoint.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search product(s) by Name, MerchantProductNo, Ean or Brand&lt;br /&gt;This search is applied to the result after applying the other filters. (optional)</param>
        /// <param name="eanList">Search products by submitting a list of EAN&#39;s. (optional)</param>
        /// <param name="merchantProductNoList">Search products by submitting a list of MerchantProductNo&#39;s. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfMerchantProductBundleResponse</returns>
        System.Threading.Tasks.Task<CollectionOfMerchantProductBundleResponse> ProductBundleGetByFilterAsync(string search = default(string), List<string> eanList = default(List<string>), List<string> merchantProductNoList = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get product bundles.
        /// </summary>
        /// <remarks>
        /// You can get the full product information on bundles from the regular /products endpoint.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search product(s) by Name, MerchantProductNo, Ean or Brand&lt;br /&gt;This search is applied to the result after applying the other filters. (optional)</param>
        /// <param name="eanList">Search products by submitting a list of EAN&#39;s. (optional)</param>
        /// <param name="merchantProductNoList">Search products by submitting a list of MerchantProductNo&#39;s. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfMerchantProductBundleResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionOfMerchantProductBundleResponse>> ProductBundleGetByFilterWithHttpInfoAsync(string search = default(string), List<string> eanList = default(List<string>), List<string> merchantProductNoList = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProductBundleApi : IProductBundleApiSync, IProductBundleApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProductBundleApi : IProductBundleApi
    {
        private ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBundleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductBundleApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBundleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductBundleApi(string basePath)
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
        /// Initializes a new instance of the <see cref="ProductBundleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductBundleApi(ChannelEngine.Merchant.ApiClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="ProductBundleApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public ProductBundleApi(ChannelEngine.Merchant.ApiClient.Client.ISynchronousClient client, ChannelEngine.Merchant.ApiClient.Client.IAsynchronousClient asyncClient, ChannelEngine.Merchant.ApiClient.Client.IReadableConfiguration configuration)
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
        /// Get product bundles. You can get the full product information on bundles from the regular /products endpoint.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search product(s) by Name, MerchantProductNo, Ean or Brand&lt;br /&gt;This search is applied to the result after applying the other filters. (optional)</param>
        /// <param name="eanList">Search products by submitting a list of EAN&#39;s. (optional)</param>
        /// <param name="merchantProductNoList">Search products by submitting a list of MerchantProductNo&#39;s. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfMerchantProductBundleResponse</returns>
        public CollectionOfMerchantProductBundleResponse ProductBundleGetByFilter(string search = default(string), List<string> eanList = default(List<string>), List<string> merchantProductNoList = default(List<string>), int? page = default(int?))
        {
            ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantProductBundleResponse> localVarResponse = ProductBundleGetByFilterWithHttpInfo(search, eanList, merchantProductNoList, page);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get product bundles. You can get the full product information on bundles from the regular /products endpoint.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search product(s) by Name, MerchantProductNo, Ean or Brand&lt;br /&gt;This search is applied to the result after applying the other filters. (optional)</param>
        /// <param name="eanList">Search products by submitting a list of EAN&#39;s. (optional)</param>
        /// <param name="merchantProductNoList">Search products by submitting a list of MerchantProductNo&#39;s. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfMerchantProductBundleResponse</returns>
        public ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantProductBundleResponse> ProductBundleGetByFilterWithHttpInfo(string search = default(string), List<string> eanList = default(List<string>), List<string> merchantProductNoList = default(List<string>), int? page = default(int?))
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

            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "search", search));
            }
            if (eanList != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "eanList", eanList));
            }
            if (merchantProductNoList != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "merchantProductNoList", merchantProductNoList));
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
            var localVarResponse = this.Client.Get<CollectionOfMerchantProductBundleResponse>("/v2/productbundles", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ProductBundleGetByFilter", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get product bundles. You can get the full product information on bundles from the regular /products endpoint.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search product(s) by Name, MerchantProductNo, Ean or Brand&lt;br /&gt;This search is applied to the result after applying the other filters. (optional)</param>
        /// <param name="eanList">Search products by submitting a list of EAN&#39;s. (optional)</param>
        /// <param name="merchantProductNoList">Search products by submitting a list of MerchantProductNo&#39;s. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CollectionOfMerchantProductBundleResponse</returns>
        public async System.Threading.Tasks.Task<CollectionOfMerchantProductBundleResponse> ProductBundleGetByFilterAsync(string search = default(string), List<string> eanList = default(List<string>), List<string> merchantProductNoList = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantProductBundleResponse> localVarResponse = await ProductBundleGetByFilterWithHttpInfoAsync(search, eanList, merchantProductNoList, page, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get product bundles. You can get the full product information on bundles from the regular /products endpoint.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="search">Search product(s) by Name, MerchantProductNo, Ean or Brand&lt;br /&gt;This search is applied to the result after applying the other filters. (optional)</param>
        /// <param name="eanList">Search products by submitting a list of EAN&#39;s. (optional)</param>
        /// <param name="merchantProductNoList">Search products by submitting a list of MerchantProductNo&#39;s. (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CollectionOfMerchantProductBundleResponse)</returns>
        public async System.Threading.Tasks.Task<ChannelEngine.Merchant.ApiClient.Client.ApiResponse<CollectionOfMerchantProductBundleResponse>> ProductBundleGetByFilterWithHttpInfoAsync(string search = default(string), List<string> eanList = default(List<string>), List<string> merchantProductNoList = default(List<string>), int? page = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
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

            if (search != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "search", search));
            }
            if (eanList != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "eanList", eanList));
            }
            if (merchantProductNoList != null)
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("multi", "merchantProductNoList", merchantProductNoList));
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

            var localVarResponse = await this.AsynchronousClient.GetAsync<CollectionOfMerchantProductBundleResponse>("/v2/productbundles", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("ProductBundleGetByFilter", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
