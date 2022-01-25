/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.11
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = ChannelEngine.Merchant.ApiClient.Client.OpenAPIDateConverter;

namespace ChannelEngine.Merchant.ApiClient.Model
{
    /// <summary>
    /// Defines OrderSupport
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum OrderSupport
    {
        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 1,

        /// <summary>
        /// Enum ORDERS for value: ORDERS
        /// </summary>
        [EnumMember(Value = "ORDERS")]
        ORDERS = 2,

        /// <summary>
        /// Enum SPLITORDERS for value: SPLIT_ORDERS
        /// </summary>
        [EnumMember(Value = "SPLIT_ORDERS")]
        SPLIT_ORDERS = 3,

        /// <summary>
        /// Enum SPLITORDERLINES for value: SPLIT_ORDER_LINES
        /// </summary>
        [EnumMember(Value = "SPLIT_ORDER_LINES")]
        SPLIT_ORDER_LINES = 4

    }
}
