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
    /// Defines ChannelCarrierRecommendationApi
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ChannelCarrierRecommendationApi
    {
        /// <summary>
        /// Enum NEUTRAL for value: NEUTRAL
        /// </summary>
        [EnumMember(Value = "NEUTRAL")]
        NEUTRAL = 1,

        /// <summary>
        /// Enum RECOMMENDED for value: RECOMMENDED
        /// </summary>
        [EnumMember(Value = "RECOMMENDED")]
        RECOMMENDED = 2,

        /// <summary>
        /// Enum DISCOMMENDED for value: DISCOMMENDED
        /// </summary>
        [EnumMember(Value = "DISCOMMENDED")]
        DISCOMMENDED = 3

    }
}
