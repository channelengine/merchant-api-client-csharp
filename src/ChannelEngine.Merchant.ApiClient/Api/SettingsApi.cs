/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.9
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
    public interface ISettingsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get settings.
        /// </summary>
        /// <remarks>
        /// Get merchant base info, settings and vat number.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SingleOfMerchantSettingsResponse</returns>
        SingleOfMerchantSettingsResponse SettingsGet();

        /// <summary>
        /// Get settings.
        /// </summary>
        /// <remarks>
        /// Get merchant base info, settings and vat number.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SingleOfMerchantSettingsResponse</returns>
        ApiResponse<SingleOfMerchantSettingsResponse> SettingsGetWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Get settings.
        /// </summary>
        /// <remarks>
        /// Get merchant base info, settings and vat number.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SingleOfMerchantSettingsResponse</returns>
        System.Threading.Tasks.Task<SingleOfMerchantSettingsResponse> SettingsGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Get settings.
        /// </summary>
        /// <remarks>
        /// Get merchant base info, settings and vat number.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SingleOfMerchantSettingsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SingleOfMerchantSettingsResponse>> SettingsGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISettingsApi : ISettingsApiSync, ISettingsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SettingsApi : ISettingsApi
    {
        private ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SettingsApi(ChannelEngine.Merchant.ApiClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SettingsApi(ChannelEngine.Merchant.ApiClient.Client.ISynchronousClient client, ChannelEngine.Merchant.ApiClient.Client.IAsynchronousClient asyncClient, ChannelEngine.Merchant.ApiClient.Client.IReadableConfiguration configuration)
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
        public String GetBasePath()
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
        /// Get settings. Get merchant base info, settings and vat number.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>SingleOfMerchantSettingsResponse</returns>
        public SingleOfMerchantSettingsResponse SettingsGet()
        {
            ChannelEngine.Merchant.ApiClient.Client.ApiResponse<SingleOfMerchantSettingsResponse> localVarResponse = SettingsGetWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get settings. Get merchant base info, settings and vat number.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of SingleOfMerchantSettingsResponse</returns>
        public ChannelEngine.Merchant.ApiClient.Client.ApiResponse<SingleOfMerchantSettingsResponse> SettingsGetWithHttpInfo()
        {
            ChannelEngine.Merchant.ApiClient.Client.RequestOptions localVarRequestOptions = new ChannelEngine.Merchant.ApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = ChannelEngine.Merchant.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ChannelEngine.Merchant.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<SingleOfMerchantSettingsResponse>("/v2/settings", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SettingsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// Get settings. Get merchant base info, settings and vat number.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of SingleOfMerchantSettingsResponse</returns>
        public async System.Threading.Tasks.Task<SingleOfMerchantSettingsResponse> SettingsGetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            ChannelEngine.Merchant.ApiClient.Client.ApiResponse<SingleOfMerchantSettingsResponse> localVarResponse = await SettingsGetWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Get settings. Get merchant base info, settings and vat number.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (SingleOfMerchantSettingsResponse)</returns>
        public async System.Threading.Tasks.Task<ChannelEngine.Merchant.ApiClient.Client.ApiResponse<SingleOfMerchantSettingsResponse>> SettingsGetWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            ChannelEngine.Merchant.ApiClient.Client.RequestOptions localVarRequestOptions = new ChannelEngine.Merchant.ApiClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = ChannelEngine.Merchant.ApiClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = ChannelEngine.Merchant.ApiClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);


            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarRequestOptions.QueryParameters.Add(ChannelEngine.Merchant.ApiClient.Client.ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<SingleOfMerchantSettingsResponse>("/v2/settings", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SettingsGet", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}