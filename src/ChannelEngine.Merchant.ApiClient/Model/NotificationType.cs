/* 
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.3
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ChannelEngine.Merchant.ApiClient.Client.OpenAPIDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// Defines NotificationType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum NotificationType
    {
        /// <summary>
        /// Enum CHANNELORDERANONYMIZEDBYREQUEST for value: CHANNEL_ORDER_ANONYMIZED_BY_REQUEST
        /// </summary>
        [EnumMember(Value = "CHANNEL_ORDER_ANONYMIZED_BY_REQUEST")]
        CHANNELORDERANONYMIZEDBYREQUEST = 1,

        /// <summary>
        /// Enum CHANNELORDERANONYMIZEDAUTOMATICALLY for value: CHANNEL_ORDER_ANONYMIZED_AUTOMATICALLY
        /// </summary>
        [EnumMember(Value = "CHANNEL_ORDER_ANONYMIZED_AUTOMATICALLY")]
        CHANNELORDERANONYMIZEDAUTOMATICALLY = 2,

        /// <summary>
        /// Enum CHANNELORDERCANCELLATIONREQUESTNEW for value: CHANNEL_ORDER_CANCELLATION_REQUEST_NEW
        /// </summary>
        [EnumMember(Value = "CHANNEL_ORDER_CANCELLATION_REQUEST_NEW")]
        CHANNELORDERCANCELLATIONREQUESTNEW = 3,

        /// <summary>
        /// Enum CHANNELORDERCORRECTIONNEEDED for value: CHANNEL_ORDER_CORRECTION_NEEDED
        /// </summary>
        [EnumMember(Value = "CHANNEL_ORDER_CORRECTION_NEEDED")]
        CHANNELORDERCORRECTIONNEEDED = 4,

        /// <summary>
        /// Enum CHANNELORDERDUPLICATELINE for value: CHANNEL_ORDER_DUPLICATE_LINE
        /// </summary>
        [EnumMember(Value = "CHANNEL_ORDER_DUPLICATE_LINE")]
        CHANNELORDERDUPLICATELINE = 5,

        /// <summary>
        /// Enum CHANNELORDERINVOICESENDFAILED for value: CHANNEL_ORDER_INVOICE_SEND_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_ORDER_INVOICE_SEND_FAILED")]
        CHANNELORDERINVOICESENDFAILED = 6,

        /// <summary>
        /// Enum CHANNELORDERIMPORTFAILED for value: CHANNEL_ORDER_IMPORT_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_ORDER_IMPORT_FAILED")]
        CHANNELORDERIMPORTFAILED = 7,

        /// <summary>
        /// Enum CHANNELORDERNEW for value: CHANNEL_ORDER_NEW
        /// </summary>
        [EnumMember(Value = "CHANNEL_ORDER_NEW")]
        CHANNELORDERNEW = 8,

        /// <summary>
        /// Enum CHANNELORDEROVERDUE for value: CHANNEL_ORDER_OVERDUE
        /// </summary>
        [EnumMember(Value = "CHANNEL_ORDER_OVERDUE")]
        CHANNELORDEROVERDUE = 9,

        /// <summary>
        /// Enum CHANNELPRODUCTDATAEXPORTFAILED for value: CHANNEL_PRODUCT_DATA_EXPORT_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_PRODUCT_DATA_EXPORT_FAILED")]
        CHANNELPRODUCTDATAEXPORTFAILED = 10,

        /// <summary>
        /// Enum CHANNELPRODUCTDATAIMPORTFAILED for value: CHANNEL_PRODUCT_DATA_IMPORT_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_PRODUCT_DATA_IMPORT_FAILED")]
        CHANNELPRODUCTDATAIMPORTFAILED = 11,

        /// <summary>
        /// Enum CHANNELRETURNEXPORTFAILED for value: CHANNEL_RETURN_EXPORT_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_RETURN_EXPORT_FAILED")]
        CHANNELRETURNEXPORTFAILED = 12,

        /// <summary>
        /// Enum CHANNELRETURNIMPORTFAILED for value: CHANNEL_RETURN_IMPORT_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_RETURN_IMPORT_FAILED")]
        CHANNELRETURNIMPORTFAILED = 13,

        /// <summary>
        /// Enum CHANNELRETURNNEW for value: CHANNEL_RETURN_NEW
        /// </summary>
        [EnumMember(Value = "CHANNEL_RETURN_NEW")]
        CHANNELRETURNNEW = 14,

        /// <summary>
        /// Enum CHANNELRETURNOVERDUE for value: CHANNEL_RETURN_OVERDUE
        /// </summary>
        [EnumMember(Value = "CHANNEL_RETURN_OVERDUE")]
        CHANNELRETURNOVERDUE = 15,

        /// <summary>
        /// Enum CHANNELREFUNDEXPORTFAILED for value: CHANNEL_REFUND_EXPORT_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_REFUND_EXPORT_FAILED")]
        CHANNELREFUNDEXPORTFAILED = 16,

        /// <summary>
        /// Enum CHANNELSHIPMENTIMPORTFAILED for value: CHANNEL_SHIPMENT_IMPORT_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_SHIPMENT_IMPORT_FAILED")]
        CHANNELSHIPMENTIMPORTFAILED = 17,

        /// <summary>
        /// Enum CHANNELSHIPMENTIMPORTSTATUSFAILED for value: CHANNEL_SHIPMENT_IMPORT_STATUS_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_SHIPMENT_IMPORT_STATUS_FAILED")]
        CHANNELSHIPMENTIMPORTSTATUSFAILED = 18,

        /// <summary>
        /// Enum CHANNELSHIPMENTEXPORTFAILED for value: CHANNEL_SHIPMENT_EXPORT_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_SHIPMENT_EXPORT_FAILED")]
        CHANNELSHIPMENTEXPORTFAILED = 19,

        /// <summary>
        /// Enum CHANNELSHIPMENTIMPORTMISSINGLINEFAILED for value: CHANNEL_SHIPMENT_IMPORT_MISSING_LINE_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_SHIPMENT_IMPORT_MISSING_LINE_FAILED")]
        CHANNELSHIPMENTIMPORTMISSINGLINEFAILED = 20,

        /// <summary>
        /// Enum CHANNELFULFILLMENTSHIPMENTIMPORTSTATUSFAILED for value: CHANNEL_FULFILLMENT_SHIPMENT_IMPORT_STATUS_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_FULFILLMENT_SHIPMENT_IMPORT_STATUS_FAILED")]
        CHANNELFULFILLMENTSHIPMENTIMPORTSTATUSFAILED = 21,

        /// <summary>
        /// Enum CHANNELFULFILLMENTSHIPMENTEXPORTFAILED for value: CHANNEL_FULFILLMENT_SHIPMENT_EXPORT_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNEL_FULFILLMENT_SHIPMENT_EXPORT_FAILED")]
        CHANNELFULFILLMENTSHIPMENTEXPORTFAILED = 22,

        /// <summary>
        /// Enum CHANNELFULFILLMENTSHIPMENTEXPORTSUCCEEDED for value: CHANNEL_FULFILLMENT_SHIPMENT_EXPORT_SUCCEEDED
        /// </summary>
        [EnumMember(Value = "CHANNEL_FULFILLMENT_SHIPMENT_EXPORT_SUCCEEDED")]
        CHANNELFULFILLMENTSHIPMENTEXPORTSUCCEEDED = 23,

        /// <summary>
        /// Enum CHANNELFULFILLMENTSHIPMENTLINEFORCLOSEDORDER for value: CHANNEL_FULFILLMENT_SHIPMENT_LINE_FOR_CLOSED_ORDER
        /// </summary>
        [EnumMember(Value = "CHANNEL_FULFILLMENT_SHIPMENT_LINE_FOR_CLOSED_ORDER")]
        CHANNELFULFILLMENTSHIPMENTLINEFORCLOSEDORDER = 24,

        /// <summary>
        /// Enum CHANNELENGINESUPPORTNOTIFICATION for value: CHANNELENGINE_SUPPORT_NOTIFICATION
        /// </summary>
        [EnumMember(Value = "CHANNELENGINE_SUPPORT_NOTIFICATION")]
        CHANNELENGINESUPPORTNOTIFICATION = 25,

        /// <summary>
        /// Enum CHANNELENGINEWEBHOOKRQUESTFAILED for value: CHANNELENGINE_WEBHOOK_RQUEST_FAILED
        /// </summary>
        [EnumMember(Value = "CHANNELENGINE_WEBHOOK_RQUEST_FAILED")]
        CHANNELENGINEWEBHOOKRQUESTFAILED = 26,

        /// <summary>
        /// Enum FEEDNOPRODUCTSFAILED for value: FEED_NO_PRODUCTS_FAILED
        /// </summary>
        [EnumMember(Value = "FEED_NO_PRODUCTS_FAILED")]
        FEEDNOPRODUCTSFAILED = 27,

        /// <summary>
        /// Enum FEEDIMPORTFAILED for value: FEED_IMPORT_FAILED
        /// </summary>
        [EnumMember(Value = "FEED_IMPORT_FAILED")]
        FEEDIMPORTFAILED = 28,

        /// <summary>
        /// Enum GLOBALMESSAGE for value: GLOBAL_MESSAGE
        /// </summary>
        [EnumMember(Value = "GLOBAL_MESSAGE")]
        GLOBALMESSAGE = 29,

        /// <summary>
        /// Enum MERCHANTORDEREXPORTFAILED for value: MERCHANT_ORDER_EXPORT_FAILED
        /// </summary>
        [EnumMember(Value = "MERCHANT_ORDER_EXPORT_FAILED")]
        MERCHANTORDEREXPORTFAILED = 30,

        /// <summary>
        /// Enum PLUGININVALIDSETTING for value: PLUGIN_INVALID_SETTING
        /// </summary>
        [EnumMember(Value = "PLUGIN_INVALID_SETTING")]
        PLUGININVALIDSETTING = 31,

        /// <summary>
        /// Enum PLUGINDEACTIVATED for value: PLUGIN_DEACTIVATED
        /// </summary>
        [EnumMember(Value = "PLUGIN_DEACTIVATED")]
        PLUGINDEACTIVATED = 32,

        /// <summary>
        /// Enum PRODUCTBUNDLEIMPORTFAILED for value: PRODUCT_BUNDLE_IMPORT_FAILED
        /// </summary>
        [EnumMember(Value = "PRODUCT_BUNDLE_IMPORT_FAILED")]
        PRODUCTBUNDLEIMPORTFAILED = 33

    }

}
