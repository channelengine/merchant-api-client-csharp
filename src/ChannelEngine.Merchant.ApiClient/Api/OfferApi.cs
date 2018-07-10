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
    public interface IOfferApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Update stock or price.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updates">References to the products that should be updated, and the new values  for the stock or price fields. It is possible to supply only one of the two fields  or both.</param>
        /// <returns>SingleOfCollectionsDictionary2Generic</returns>
        SingleOfCollectionsDictionary2Generic OfferStockPriceUpdate (List<MerchantStockPriceUpdateRequest> updates);

        /// <summary>
        /// Update stock or price.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updates">References to the products that should be updated, and the new values  for the stock or price fields. It is possible to supply only one of the two fields  or both.</param>
        /// <returns>ApiResponse of SingleOfCollectionsDictionary2Generic</returns>
        ApiResponse<SingleOfCollectionsDictionary2Generic> OfferStockPriceUpdateWithHttpInfo (List<MerchantStockPriceUpdateRequest> updates);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Update stock or price.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updates">References to the products that should be updated, and the new values  for the stock or price fields. It is possible to supply only one of the two fields  or both.</param>
        /// <returns>Task of SingleOfCollectionsDictionary2Generic</returns>
        System.Threading.Tasks.Task<SingleOfCollectionsDictionary2Generic> OfferStockPriceUpdateAsync (List<MerchantStockPriceUpdateRequest> updates);

        /// <summary>
        /// Update stock or price.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updates">References to the products that should be updated, and the new values  for the stock or price fields. It is possible to supply only one of the two fields  or both.</param>
        /// <returns>Task of ApiResponse (SingleOfCollectionsDictionary2Generic)</returns>
        System.Threading.Tasks.Task<ApiResponse<SingleOfCollectionsDictionary2Generic>> OfferStockPriceUpdateAsyncWithHttpInfo (List<MerchantStockPriceUpdateRequest> updates);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OfferApi : IOfferApi
    {
        private ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OfferApi(String basePath)
        {
            this.Configuration = new ChannelEngine.Merchant.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ChannelEngine.Merchant.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OfferApi(ChannelEngine.Merchant.ApiClient.Client.Configuration configuration = null)
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
        /// Update stock or price. 
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updates">References to the products that should be updated, and the new values  for the stock or price fields. It is possible to supply only one of the two fields  or both.</param>
        /// <returns>SingleOfCollectionsDictionary2Generic</returns>
        public SingleOfCollectionsDictionary2Generic OfferStockPriceUpdate (List<MerchantStockPriceUpdateRequest> updates)
        {
             ApiResponse<SingleOfCollectionsDictionary2Generic> localVarResponse = OfferStockPriceUpdateWithHttpInfo(updates);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update stock or price. 
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updates">References to the products that should be updated, and the new values  for the stock or price fields. It is possible to supply only one of the two fields  or both.</param>
        /// <returns>ApiResponse of SingleOfCollectionsDictionary2Generic</returns>
        public ApiResponse< SingleOfCollectionsDictionary2Generic > OfferStockPriceUpdateWithHttpInfo (List<MerchantStockPriceUpdateRequest> updates)
        {
            // verify the required parameter 'updates' is set
            if (updates == null)
                throw new ApiException(400, "Missing required parameter 'updates' when calling OfferApi->OfferStockPriceUpdate");

            var localVarPath = "./v2/offer";
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

            if (updates != null && updates.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(updates); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updates; // byte array
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
                Exception exception = ExceptionFactory("OfferStockPriceUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SingleOfCollectionsDictionary2Generic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SingleOfCollectionsDictionary2Generic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SingleOfCollectionsDictionary2Generic)));
        }

        /// <summary>
        /// Update stock or price. 
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updates">References to the products that should be updated, and the new values  for the stock or price fields. It is possible to supply only one of the two fields  or both.</param>
        /// <returns>Task of SingleOfCollectionsDictionary2Generic</returns>
        public async System.Threading.Tasks.Task<SingleOfCollectionsDictionary2Generic> OfferStockPriceUpdateAsync (List<MerchantStockPriceUpdateRequest> updates)
        {
             ApiResponse<SingleOfCollectionsDictionary2Generic> localVarResponse = await OfferStockPriceUpdateAsyncWithHttpInfo(updates);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update stock or price. 
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="updates">References to the products that should be updated, and the new values  for the stock or price fields. It is possible to supply only one of the two fields  or both.</param>
        /// <returns>Task of ApiResponse (SingleOfCollectionsDictionary2Generic)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SingleOfCollectionsDictionary2Generic>> OfferStockPriceUpdateAsyncWithHttpInfo (List<MerchantStockPriceUpdateRequest> updates)
        {
            // verify the required parameter 'updates' is set
            if (updates == null)
                throw new ApiException(400, "Missing required parameter 'updates' when calling OfferApi->OfferStockPriceUpdate");

            var localVarPath = "./v2/offer";
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

            if (updates != null && updates.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(updates); // http body (model) parameter
            }
            else
            {
                localVarPostBody = updates; // byte array
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
                Exception exception = ExceptionFactory("OfferStockPriceUpdate", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SingleOfCollectionsDictionary2Generic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (SingleOfCollectionsDictionary2Generic) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(SingleOfCollectionsDictionary2Generic)));
        }

    }
}
