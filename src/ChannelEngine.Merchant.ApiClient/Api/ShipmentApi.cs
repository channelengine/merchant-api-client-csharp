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
    public interface IShipmentApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Shipment
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as shipped.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse</returns>
        ApiResponse ShipmentCreate (MerchantShipmentRequest model);

        /// <summary>
        /// Create Shipment
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as shipped.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        ApiResponse<ApiResponse> ShipmentCreateWithHttpInfo (MerchantShipmentRequest model);
        /// <summary>
        /// Update Shipment
        /// </summary>
        /// <remarks>
        /// Update an existing shipment with tracking information
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The merchant&#39;s shipment reference</param>
        /// <param name="model">The updated tracking information</param>
        /// <returns>ApiResponse</returns>
        ApiResponse ShipmentUpdate (string merchantShipmentNo, MerchantShipmentTrackingRequest model);

        /// <summary>
        /// Update Shipment
        /// </summary>
        /// <remarks>
        /// Update an existing shipment with tracking information
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The merchant&#39;s shipment reference</param>
        /// <param name="model">The updated tracking information</param>
        /// <returns>ApiResponse of ApiResponse</returns>
        ApiResponse<ApiResponse> ShipmentUpdateWithHttpInfo (string merchantShipmentNo, MerchantShipmentTrackingRequest model);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Shipment
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as shipped.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse> ShipmentCreateAsync (MerchantShipmentRequest model);

        /// <summary>
        /// Create Shipment
        /// </summary>
        /// <remarks>
        /// Mark (part of) an order as shipped.
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ShipmentCreateAsyncWithHttpInfo (MerchantShipmentRequest model);
        /// <summary>
        /// Update Shipment
        /// </summary>
        /// <remarks>
        /// Update an existing shipment with tracking information
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The merchant&#39;s shipment reference</param>
        /// <param name="model">The updated tracking information</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse> ShipmentUpdateAsync (string merchantShipmentNo, MerchantShipmentTrackingRequest model);

        /// <summary>
        /// Update Shipment
        /// </summary>
        /// <remarks>
        /// Update an existing shipment with tracking information
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The merchant&#39;s shipment reference</param>
        /// <param name="model">The updated tracking information</param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ShipmentUpdateAsyncWithHttpInfo (string merchantShipmentNo, MerchantShipmentTrackingRequest model);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ShipmentApi : IShipmentApi
    {
        private ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ShipmentApi(String basePath)
        {
            this.Configuration = new ChannelEngine.Merchant.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ChannelEngine.Merchant.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ShipmentApi(ChannelEngine.Merchant.ApiClient.Client.Configuration configuration = null)
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
        /// Create Shipment Mark (part of) an order as shipped.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse</returns>
        public ApiResponse ShipmentCreate (MerchantShipmentRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = ShipmentCreateWithHttpInfo(model);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Shipment Mark (part of) an order as shipped.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>ApiResponse of ApiResponse</returns>
        public ApiResponse< ApiResponse > ShipmentCreateWithHttpInfo (MerchantShipmentRequest model)
        {
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling ShipmentApi->ShipmentCreate");

            var localVarPath = "./v2/shipments";
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
                Exception exception = ExceptionFactory("ShipmentCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Create Shipment Mark (part of) an order as shipped.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse> ShipmentCreateAsync (MerchantShipmentRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = await ShipmentCreateAsyncWithHttpInfo(model);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Shipment Mark (part of) an order as shipped.
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="model"></param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ShipmentCreateAsyncWithHttpInfo (MerchantShipmentRequest model)
        {
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling ShipmentApi->ShipmentCreate");

            var localVarPath = "./v2/shipments";
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
                Exception exception = ExceptionFactory("ShipmentCreate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Update Shipment Update an existing shipment with tracking information
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The merchant&#39;s shipment reference</param>
        /// <param name="model">The updated tracking information</param>
        /// <returns>ApiResponse</returns>
        public ApiResponse ShipmentUpdate (string merchantShipmentNo, MerchantShipmentTrackingRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = ShipmentUpdateWithHttpInfo(merchantShipmentNo, model);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Shipment Update an existing shipment with tracking information
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The merchant&#39;s shipment reference</param>
        /// <param name="model">The updated tracking information</param>
        /// <returns>ApiResponse of ApiResponse</returns>
        public ApiResponse< ApiResponse > ShipmentUpdateWithHttpInfo (string merchantShipmentNo, MerchantShipmentTrackingRequest model)
        {
            // verify the required parameter 'merchantShipmentNo' is set
            if (merchantShipmentNo == null)
                throw new ApiException(400, "Missing required parameter 'merchantShipmentNo' when calling ShipmentApi->ShipmentUpdate");
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling ShipmentApi->ShipmentUpdate");

            var localVarPath = "./v2/shipments/{merchantShipmentNo}";
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

            if (merchantShipmentNo != null) localVarPathParams.Add("merchantShipmentNo", this.Configuration.ApiClient.ParameterToString(merchantShipmentNo)); // path parameter
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
                Exception exception = ExceptionFactory("ShipmentUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

        /// <summary>
        /// Update Shipment Update an existing shipment with tracking information
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The merchant&#39;s shipment reference</param>
        /// <param name="model">The updated tracking information</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse> ShipmentUpdateAsync (string merchantShipmentNo, MerchantShipmentTrackingRequest model)
        {
             ApiResponse<ApiResponse> localVarResponse = await ShipmentUpdateAsyncWithHttpInfo(merchantShipmentNo, model);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Shipment Update an existing shipment with tracking information
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="merchantShipmentNo">The merchant&#39;s shipment reference</param>
        /// <param name="model">The updated tracking information</param>
        /// <returns>Task of ApiResponse (ApiResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ApiResponse>> ShipmentUpdateAsyncWithHttpInfo (string merchantShipmentNo, MerchantShipmentTrackingRequest model)
        {
            // verify the required parameter 'merchantShipmentNo' is set
            if (merchantShipmentNo == null)
                throw new ApiException(400, "Missing required parameter 'merchantShipmentNo' when calling ShipmentApi->ShipmentUpdate");
            // verify the required parameter 'model' is set
            if (model == null)
                throw new ApiException(400, "Missing required parameter 'model' when calling ShipmentApi->ShipmentUpdate");

            var localVarPath = "./v2/shipments/{merchantShipmentNo}";
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

            if (merchantShipmentNo != null) localVarPathParams.Add("merchantShipmentNo", this.Configuration.ApiClient.ParameterToString(merchantShipmentNo)); // path parameter
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
                Exception exception = ExceptionFactory("ShipmentUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ApiResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (ApiResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ApiResponse)));
        }

    }
}
