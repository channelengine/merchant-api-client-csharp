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
    public interface INotificationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Notifications
        /// </summary>
        /// <remarks>
        /// Gets all notifications based on filter
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the notification date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the notification date, until this date. This date is exclusive. (optional)</param>
        /// <param name="types">Notification type(s) to filter on (optional)</param>
        /// <param name="merchantOrderNos">Filter on unique order reference used by the merchant (optional)</param>
        /// <param name="channelOrderNos">Filter on unique order reference used by the channel (optional)</param>
        /// <param name="merchantReturnNos">Filter on unique return reference used by the merchant (optional)</param>
        /// <param name="channelReturnNos">Filter on unique return reference used by the channel (optional)</param>
        /// <param name="merchantShipmentNos">Filter on unique shipment reference used by the merchant (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfMerchantNotificationResponse</returns>
        CollectionOfMerchantNotificationResponse NotificationIndex (DateTime? fromDate = null, DateTime? toDate = null, List<string> types = null, List<string> merchantOrderNos = null, List<string> channelOrderNos = null, List<string> merchantReturnNos = null, List<string> channelReturnNos = null, List<string> merchantShipmentNos = null, int? page = null);

        /// <summary>
        /// Get Notifications
        /// </summary>
        /// <remarks>
        /// Gets all notifications based on filter
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the notification date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the notification date, until this date. This date is exclusive. (optional)</param>
        /// <param name="types">Notification type(s) to filter on (optional)</param>
        /// <param name="merchantOrderNos">Filter on unique order reference used by the merchant (optional)</param>
        /// <param name="channelOrderNos">Filter on unique order reference used by the channel (optional)</param>
        /// <param name="merchantReturnNos">Filter on unique return reference used by the merchant (optional)</param>
        /// <param name="channelReturnNos">Filter on unique return reference used by the channel (optional)</param>
        /// <param name="merchantShipmentNos">Filter on unique shipment reference used by the merchant (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfMerchantNotificationResponse</returns>
        ApiResponse<CollectionOfMerchantNotificationResponse> NotificationIndexWithHttpInfo (DateTime? fromDate = null, DateTime? toDate = null, List<string> types = null, List<string> merchantOrderNos = null, List<string> channelOrderNos = null, List<string> merchantReturnNos = null, List<string> channelReturnNos = null, List<string> merchantShipmentNos = null, int? page = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Notifications
        /// </summary>
        /// <remarks>
        /// Gets all notifications based on filter
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the notification date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the notification date, until this date. This date is exclusive. (optional)</param>
        /// <param name="types">Notification type(s) to filter on (optional)</param>
        /// <param name="merchantOrderNos">Filter on unique order reference used by the merchant (optional)</param>
        /// <param name="channelOrderNos">Filter on unique order reference used by the channel (optional)</param>
        /// <param name="merchantReturnNos">Filter on unique return reference used by the merchant (optional)</param>
        /// <param name="channelReturnNos">Filter on unique return reference used by the channel (optional)</param>
        /// <param name="merchantShipmentNos">Filter on unique shipment reference used by the merchant (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>Task of CollectionOfMerchantNotificationResponse</returns>
        System.Threading.Tasks.Task<CollectionOfMerchantNotificationResponse> NotificationIndexAsync (DateTime? fromDate = null, DateTime? toDate = null, List<string> types = null, List<string> merchantOrderNos = null, List<string> channelOrderNos = null, List<string> merchantReturnNos = null, List<string> channelReturnNos = null, List<string> merchantShipmentNos = null, int? page = null);

        /// <summary>
        /// Get Notifications
        /// </summary>
        /// <remarks>
        /// Gets all notifications based on filter
        /// </remarks>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the notification date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the notification date, until this date. This date is exclusive. (optional)</param>
        /// <param name="types">Notification type(s) to filter on (optional)</param>
        /// <param name="merchantOrderNos">Filter on unique order reference used by the merchant (optional)</param>
        /// <param name="channelOrderNos">Filter on unique order reference used by the channel (optional)</param>
        /// <param name="merchantReturnNos">Filter on unique return reference used by the merchant (optional)</param>
        /// <param name="channelReturnNos">Filter on unique return reference used by the channel (optional)</param>
        /// <param name="merchantShipmentNos">Filter on unique shipment reference used by the merchant (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>Task of ApiResponse (CollectionOfMerchantNotificationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CollectionOfMerchantNotificationResponse>> NotificationIndexAsyncWithHttpInfo (DateTime? fromDate = null, DateTime? toDate = null, List<string> types = null, List<string> merchantOrderNos = null, List<string> channelOrderNos = null, List<string> merchantReturnNos = null, List<string> channelReturnNos = null, List<string> merchantShipmentNos = null, int? page = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NotificationApi : INotificationApi
    {
        private ChannelEngine.Merchant.ApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationApi(String basePath)
        {
            this.Configuration = new ChannelEngine.Merchant.ApiClient.Client.Configuration { BasePath = basePath };

            ExceptionFactory = ChannelEngine.Merchant.ApiClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NotificationApi(ChannelEngine.Merchant.ApiClient.Client.Configuration configuration = null)
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
        /// Get Notifications Gets all notifications based on filter
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the notification date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the notification date, until this date. This date is exclusive. (optional)</param>
        /// <param name="types">Notification type(s) to filter on (optional)</param>
        /// <param name="merchantOrderNos">Filter on unique order reference used by the merchant (optional)</param>
        /// <param name="channelOrderNos">Filter on unique order reference used by the channel (optional)</param>
        /// <param name="merchantReturnNos">Filter on unique return reference used by the merchant (optional)</param>
        /// <param name="channelReturnNos">Filter on unique return reference used by the channel (optional)</param>
        /// <param name="merchantShipmentNos">Filter on unique shipment reference used by the merchant (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>CollectionOfMerchantNotificationResponse</returns>
        public CollectionOfMerchantNotificationResponse NotificationIndex (DateTime? fromDate = null, DateTime? toDate = null, List<string> types = null, List<string> merchantOrderNos = null, List<string> channelOrderNos = null, List<string> merchantReturnNos = null, List<string> channelReturnNos = null, List<string> merchantShipmentNos = null, int? page = null)
        {
             ApiResponse<CollectionOfMerchantNotificationResponse> localVarResponse = NotificationIndexWithHttpInfo(fromDate, toDate, types, merchantOrderNos, channelOrderNos, merchantReturnNos, channelReturnNos, merchantShipmentNos, page);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Notifications Gets all notifications based on filter
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the notification date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the notification date, until this date. This date is exclusive. (optional)</param>
        /// <param name="types">Notification type(s) to filter on (optional)</param>
        /// <param name="merchantOrderNos">Filter on unique order reference used by the merchant (optional)</param>
        /// <param name="channelOrderNos">Filter on unique order reference used by the channel (optional)</param>
        /// <param name="merchantReturnNos">Filter on unique return reference used by the merchant (optional)</param>
        /// <param name="channelReturnNos">Filter on unique return reference used by the channel (optional)</param>
        /// <param name="merchantShipmentNos">Filter on unique shipment reference used by the merchant (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>ApiResponse of CollectionOfMerchantNotificationResponse</returns>
        public ApiResponse< CollectionOfMerchantNotificationResponse > NotificationIndexWithHttpInfo (DateTime? fromDate = null, DateTime? toDate = null, List<string> types = null, List<string> merchantOrderNos = null, List<string> channelOrderNos = null, List<string> merchantReturnNos = null, List<string> channelReturnNos = null, List<string> merchantShipmentNos = null, int? page = null)
        {

            var localVarPath = "./v2/notifications";
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
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fromDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fromDate", fromDate)); // query parameter
            if (toDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "toDate", toDate)); // query parameter
            if (types != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "types", types)); // query parameter
            if (merchantOrderNos != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "merchantOrderNos", merchantOrderNos)); // query parameter
            if (channelOrderNos != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "channelOrderNos", channelOrderNos)); // query parameter
            if (merchantReturnNos != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "merchantReturnNos", merchantReturnNos)); // query parameter
            if (channelReturnNos != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "channelReturnNos", channelReturnNos)); // query parameter
            if (merchantShipmentNos != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "merchantShipmentNos", merchantShipmentNos)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

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
                Exception exception = ExceptionFactory("NotificationIndex", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CollectionOfMerchantNotificationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (CollectionOfMerchantNotificationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CollectionOfMerchantNotificationResponse)));
        }

        /// <summary>
        /// Get Notifications Gets all notifications based on filter
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the notification date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the notification date, until this date. This date is exclusive. (optional)</param>
        /// <param name="types">Notification type(s) to filter on (optional)</param>
        /// <param name="merchantOrderNos">Filter on unique order reference used by the merchant (optional)</param>
        /// <param name="channelOrderNos">Filter on unique order reference used by the channel (optional)</param>
        /// <param name="merchantReturnNos">Filter on unique return reference used by the merchant (optional)</param>
        /// <param name="channelReturnNos">Filter on unique return reference used by the channel (optional)</param>
        /// <param name="merchantShipmentNos">Filter on unique shipment reference used by the merchant (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>Task of CollectionOfMerchantNotificationResponse</returns>
        public async System.Threading.Tasks.Task<CollectionOfMerchantNotificationResponse> NotificationIndexAsync (DateTime? fromDate = null, DateTime? toDate = null, List<string> types = null, List<string> merchantOrderNos = null, List<string> channelOrderNos = null, List<string> merchantReturnNos = null, List<string> channelReturnNos = null, List<string> merchantShipmentNos = null, int? page = null)
        {
             ApiResponse<CollectionOfMerchantNotificationResponse> localVarResponse = await NotificationIndexAsyncWithHttpInfo(fromDate, toDate, types, merchantOrderNos, channelOrderNos, merchantReturnNos, channelReturnNos, merchantShipmentNos, page);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Notifications Gets all notifications based on filter
        /// </summary>
        /// <exception cref="ChannelEngine.Merchant.ApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fromDate">Filter on the notification date, starting from this date. This date is inclusive. (optional)</param>
        /// <param name="toDate">Filter on the notification date, until this date. This date is exclusive. (optional)</param>
        /// <param name="types">Notification type(s) to filter on (optional)</param>
        /// <param name="merchantOrderNos">Filter on unique order reference used by the merchant (optional)</param>
        /// <param name="channelOrderNos">Filter on unique order reference used by the channel (optional)</param>
        /// <param name="merchantReturnNos">Filter on unique return reference used by the merchant (optional)</param>
        /// <param name="channelReturnNos">Filter on unique return reference used by the channel (optional)</param>
        /// <param name="merchantShipmentNos">Filter on unique shipment reference used by the merchant (optional)</param>
        /// <param name="page">The page to filter on. Starts at 1. (optional)</param>
        /// <returns>Task of ApiResponse (CollectionOfMerchantNotificationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CollectionOfMerchantNotificationResponse>> NotificationIndexAsyncWithHttpInfo (DateTime? fromDate = null, DateTime? toDate = null, List<string> types = null, List<string> merchantOrderNos = null, List<string> channelOrderNos = null, List<string> merchantReturnNos = null, List<string> channelReturnNos = null, List<string> merchantShipmentNos = null, int? page = null)
        {

            var localVarPath = "./v2/notifications";
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
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fromDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fromDate", fromDate)); // query parameter
            if (toDate != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "toDate", toDate)); // query parameter
            if (types != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "types", types)); // query parameter
            if (merchantOrderNos != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "merchantOrderNos", merchantOrderNos)); // query parameter
            if (channelOrderNos != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "channelOrderNos", channelOrderNos)); // query parameter
            if (merchantReturnNos != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "merchantReturnNos", merchantReturnNos)); // query parameter
            if (channelReturnNos != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "channelReturnNos", channelReturnNos)); // query parameter
            if (merchantShipmentNos != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("multi", "merchantShipmentNos", merchantShipmentNos)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter

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
                Exception exception = ExceptionFactory("NotificationIndex", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CollectionOfMerchantNotificationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (CollectionOfMerchantNotificationResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CollectionOfMerchantNotificationResponse)));
        }

    }
}