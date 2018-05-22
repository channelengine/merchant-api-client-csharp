/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * OpenAPI spec version: 2.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ChannelEngine.Merchant.ApiClient.Client;
using ChannelEngine.Merchant.ApiClient.Model;

namespace ChannelEngine.Merchant.ApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICancellationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Cancellation
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as cancelled.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellation"></param>
        /// <returns>ApiResponse</returns>
        ApiResponse CancellationCreate (MerchantCancellationRequest cancellation);

        /// <summary>
        /// Create Cancellation
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as cancelled.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellation"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        ApiResponse<ApiResponse> CancellationCreateWithHttpInfo (MerchantCancellationRequest cancellation);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Cancellation
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as cancelled.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellation"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse> CancellationCreateAsync (MerchantCancellationRequest cancellation);

        /// <summary>
        /// Create Cancellation
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as cancelled.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellation"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponse>> CancellationCreateAsyncWithHttpInfo (MerchantCancellationRequest cancellation);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CancellationApi : ICancellationApi
    {
        private ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CancellationApi(String basePath)
        {
            this.Configuration = new ChannelEngine.Merchant.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ChannelEngine.Merchant.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CancellationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CancellationApi(ChannelEngine.Merchant.ApiClient.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = ChannelEngine.Merchant.ApiClient.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ChannelEngine.Merchant.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public ChannelEngine.Merchant.ApiClient.Client.Configuration Configuration {get; set;}

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
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create Cancellation Mark (part of) an order as cancelled.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellation"></param>
        /// <returns>ApiResponse</returns>
        public ApiResponse CancellationCreate (MerchantCancellationRequest cancellation)
        {
             ApiResponse<ApiResponse> localVarResponse = CancellationCreateWithHttpInfo(cancellation);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Cancellation Mark (part of) an order as cancelled.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellation"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        public ApiResponse< ApiResponse > CancellationCreateWithHttpInfo (MerchantCancellationRequest cancellation)
        {
            // verify the required parameter 'cancellation' is set
            if (cancellation == null)
                throw new ApiException(400, "Missing required parameter 'cancellation' when calling CancellationApi->CancellationCreate");

            var localVarPath = "/v2/cancellations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cancellation != null && cancellation.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cancellation); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancellation; // byte array
            }

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancellationCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Create Cancellation Mark (part of) an order as cancelled.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellation"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse> CancellationCreateAsync (MerchantCancellationRequest cancellation)
        {
             ApiResponse<ApiResponse> localVarResponse = await CancellationCreateAsyncWithHttpInfo(cancellation);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Cancellation Mark (part of) an order as cancelled.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellation"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponse>> CancellationCreateAsyncWithHttpInfo (MerchantCancellationRequest cancellation)
        {
            // verify the required parameter 'cancellation' is set
            if (cancellation == null)
                throw new ApiException(400, "Missing required parameter 'cancellation' when calling CancellationApi->CancellationCreate");

            var localVarPath = "/v2/cancellations";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (cancellation != null && cancellation.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(cancellation); // http body (model) parameter
            }
            else
            {
                localVarPostBody = cancellation; // byte array
            }

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CancellationCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

    }
}
