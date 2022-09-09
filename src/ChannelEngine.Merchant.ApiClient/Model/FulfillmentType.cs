/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.13.0
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
    /// Defines FulfillmentType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum FulfillmentType
    {
        /// <summary>
        /// Enum ALL for value: ALL
        /// </summary>
        [EnumMember(Value = "ALL")]
        ALL = 1,

        /// <summary>
        /// Enum ONLYMERCHANT for value: ONLY_MERCHANT
        /// </summary>
        [EnumMember(Value = "ONLY_MERCHANT")]
        ONLY_MERCHANT = 2,

        /// <summary>
        /// Enum ONLYCHANNEL for value: ONLY_CHANNEL
        /// </summary>
        [EnumMember(Value = "ONLY_CHANNEL")]
        ONLY_CHANNEL = 3,

        /// <summary>
        /// Enum MIXED for value: MIXED
        /// </summary>
        [EnumMember(Value = "MIXED")]
        MIXED = 4,

        /// <summary>
        /// Enum INCLUDESMERCHANT for value: INCLUDES_MERCHANT
        /// </summary>
        [EnumMember(Value = "INCLUDES_MERCHANT")]
        INCLUDES_MERCHANT = 5

    }
}
