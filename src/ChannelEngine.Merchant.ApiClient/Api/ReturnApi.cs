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
using RestSharp.Portable;
using ChannelEngine.Merchant.ApiClient.Client;
using ChannelEngine.Merchant.ApiClient.Model;

namespace ChannelEngine.Merchant.ApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReturnApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Return
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse</returns>
        ApiResponse ReturnDeclareForMerchant (MerchantReturnRequest model);

        /// <summary>
        /// Create Return
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        ApiResponse<ApiResponse> ReturnDeclareForMerchantWithHttpInfo (MerchantReturnRequest model);
        /// <summary>
        /// Get Returns
        /// </summary>
        /// <remarks>
        /// Get all returns created by the channel. This call is supposed  to be used by merchants. Channels should use the &#39;GET /v2/returns/channel&#39;  call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>CollectionOfMerchantReturnResponse</returns>
        CollectionOfMerchantReturnResponse ReturnGetDeclaredByChannel (DateTime? createdSince);

        /// <summary>
        /// Get Returns
        /// </summary>
        /// <remarks>
        /// Get all returns created by the channel. This call is supposed  to be used by merchants. Channels should use the &#39;GET /v2/returns/channel&#39;  call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>ApiResponse of CollectionOfMerchantReturnResponse</returns>
        ApiResponse<CollectionOfMerchantReturnResponse> ReturnGetDeclaredByChannelWithHttpInfo (DateTime? createdSince);
        /// <summary>
        /// Mark a return as received
        /// </summary>
        /// <remarks>
        /// Mark a return as received
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse</returns>
        ApiResponse ReturnUpdateForMerchant (MerchantReturnUpdateRequest model);

        /// <summary>
        /// Mark a return as received
        /// </summary>
        /// <remarks>
        /// Mark a return as received
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        ApiResponse<ApiResponse> ReturnUpdateForMerchantWithHttpInfo (MerchantReturnUpdateRequest model);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Return
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse> ReturnDeclareForMerchantAsync (MerchantReturnRequest model);

        /// <summary>
        /// Create Return
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as returned by the customer.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ReturnDeclareForMerchantAsyncWithHttpInfo (MerchantReturnRequest model);
        /// <summary>
        /// Get Returns
        /// </summary>
        /// <remarks>
        /// Get all returns created by the channel. This call is supposed  to be used by merchants. Channels should use the &#39;GET /v2/returns/channel&#39;  call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>Task of CollectionOfMerchantReturnResponse</returns>
        System.Threading.Tasks.Task<CollectionOfMerchantReturnResponse> ReturnGetDeclaredByChannelAsync (DateTime? createdSince);

        /// <summary>
        /// Get Returns
        /// </summary>
        /// <remarks>
        /// Get all returns created by the channel. This call is supposed  to be used by merchants. Channels should use the &#39;GET /v2/returns/channel&#39;  call.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>Task of ApiResponse (CollectionOfMerchantReturnResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionOfMerchantReturnResponse>> ReturnGetDeclaredByChannelAsyncWithHttpInfo (DateTime? createdSince);
        /// <summary>
        /// Mark a return as received
        /// </summary>
        /// <remarks>
        /// Mark a return as received
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse> ReturnUpdateForMerchantAsync (MerchantReturnUpdateRequest model);

        /// <summary>
        /// Mark a return as received
        /// </summary>
        /// <remarks>
        /// Mark a return as received
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ReturnUpdateForMerchantAsyncWithHttpInfo (MerchantReturnUpdateRequest model);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReturnApi : IReturnApi
    {
        private ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ReturnApi(String basePath)
        {
            this.Configuration = new ChannelEngine.Merchant.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ChannelEngine.Merchant.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ReturnApi(ChannelEngine.Merchant.ApiClient.Client.Configuration configuration = null)
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
        /// Create Return Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse</returns>
        public ApiResponse ReturnDeclareForMerchant (MerchantReturnRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = ReturnDeclareForMerchantWithHttpInfo(model);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Return Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        public ApiResponse< ApiResponse > ReturnDeclareForMerchantWithHttpInfo (MerchantReturnRequest model)
        {
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling ReturnApi->ReturnDeclareForMerchant");

            var localVarPath = "./v2/returns/merchant";
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

            if (model != null && model.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
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
                Exception exception = ExceptionFactory("ReturnDeclareForMerchant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Create Return Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse> ReturnDeclareForMerchantAsync (MerchantReturnRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = await ReturnDeclareForMerchantAsyncWithHttpInfo(model);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Return Mark (part of) an order as returned by the customer.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ReturnDeclareForMerchantAsyncWithHttpInfo (MerchantReturnRequest model)
        {
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling ReturnApi->ReturnDeclareForMerchant");

            var localVarPath = "./v2/returns/merchant";
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

            if (model != null && model.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
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
                Exception exception = ExceptionFactory("ReturnDeclareForMerchant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Get Returns Get all returns created by the channel. This call is supposed  to be used by merchants. Channels should use the &#39;GET /v2/returns/channel&#39;  call.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>CollectionOfMerchantReturnResponse</returns>
        public CollectionOfMerchantReturnResponse ReturnGetDeclaredByChannel (DateTime? createdSince)
        {
             ApiResponse<CollectionOfMerchantReturnResponse> localVarResponse = ReturnGetDeclaredByChannelWithHttpInfo(createdSince);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Returns Get all returns created by the channel. This call is supposed  to be used by merchants. Channels should use the &#39;GET /v2/returns/channel&#39;  call.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>ApiResponse of CollectionOfMerchantReturnResponse</returns>
        public ApiResponse< CollectionOfMerchantReturnResponse > ReturnGetDeclaredByChannelWithHttpInfo (DateTime? createdSince)
        {
            // verify the required parameter 'createdSince' is set
            if (createdSince == null)
                throw new ApiException(400, "Missing required parameter 'createdSince' when calling ReturnApi->ReturnGetDeclaredByChannel");

            var localVarPath = "./v2/returns/merchant";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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

            if (createdSince != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "createdSince", createdSince)); // query parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReturnGetDeclaredByChannel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CollectionOfMerchantReturnResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (CollectionOfMerchantReturnResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CollectionOfMerchantReturnResponse)));
        }

        /// <summary>
        /// Get Returns Get all returns created by the channel. This call is supposed  to be used by merchants. Channels should use the &#39;GET /v2/returns/channel&#39;  call.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>Task of CollectionOfMerchantReturnResponse</returns>
        public async System.Threading.Tasks.Task<CollectionOfMerchantReturnResponse> ReturnGetDeclaredByChannelAsync (DateTime? createdSince)
        {
             ApiResponse<CollectionOfMerchantReturnResponse> localVarResponse = await ReturnGetDeclaredByChannelAsyncWithHttpInfo(createdSince);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Returns Get all returns created by the channel. This call is supposed  to be used by merchants. Channels should use the &#39;GET /v2/returns/channel&#39;  call.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createdSince"></param>
        /// <returns>Task of ApiResponse (CollectionOfMerchantReturnResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CollectionOfMerchantReturnResponse>> ReturnGetDeclaredByChannelAsyncWithHttpInfo (DateTime? createdSince)
        {
            // verify the required parameter 'createdSince' is set
            if (createdSince == null)
                throw new ApiException(400, "Missing required parameter 'createdSince' when calling ReturnApi->ReturnGetDeclaredByChannel");

            var localVarPath = "./v2/returns/merchant";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
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

            if (createdSince != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "createdSince", createdSince)); // query parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReturnGetDeclaredByChannel", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CollectionOfMerchantReturnResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (CollectionOfMerchantReturnResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CollectionOfMerchantReturnResponse)));
        }

        /// <summary>
        /// Mark a return as received Mark a return as received
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse</returns>
        public ApiResponse ReturnUpdateForMerchant (MerchantReturnUpdateRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = ReturnUpdateForMerchantWithHttpInfo(model);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark a return as received Mark a return as received
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        public ApiResponse< ApiResponse > ReturnUpdateForMerchantWithHttpInfo (MerchantReturnUpdateRequest model)
        {
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling ReturnApi->ReturnUpdateForMerchant");

            var localVarPath = "./v2/returns";
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
                "application/xml", 
                "text/xml", 
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

            if (model != null && model.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
            }

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReturnUpdateForMerchant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Mark a return as received Mark a return as received
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse> ReturnUpdateForMerchantAsync (MerchantReturnUpdateRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = await ReturnUpdateForMerchantAsyncWithHttpInfo(model);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Mark a return as received Mark a return as received
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ReturnUpdateForMerchantAsyncWithHttpInfo (MerchantReturnUpdateRequest model)
        {
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling ReturnApi->ReturnUpdateForMerchant");

            var localVarPath = "./v2/returns";
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
                "application/xml", 
                "text/xml", 
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

            if (model != null && model.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(model); // http body (model) parameter
            }
            else
            {
                localVarPostBody = model; // byte array
            }

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apikey", this.Configuration.GetApiKeyWithPrefix("apikey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ReturnUpdateForMerchant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

    }
}
