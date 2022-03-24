/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.10.0
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
    /// Defines CreatorFilter
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CreatorFilter
    {
        /// <summary>
        /// Enum ONLYFROMMERCHANT for value: ONLY_FROM_MERCHANT
        /// </summary>
        [EnumMember(Value = "ONLY_FROM_MERCHANT")]
        ONLY_FROM_MERCHANT = 1,

        /// <summary>
        /// Enum ONLYFROMCHANNEL for value: ONLY_FROM_CHANNEL
        /// </summary>
        [EnumMember(Value = "ONLY_FROM_CHANNEL")]
        ONLY_FROM_CHANNEL = 2,

        /// <summary>
        /// Enum MIXED for value: MIXED
        /// </summary>
        [EnumMember(Value = "MIXED")]
        MIXED = 3

    }
}
