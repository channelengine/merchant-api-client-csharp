/*
 * ChannelEngine Merchant API
 *
 * ChannelEngine API for merchants
 *
 * The version of the OpenAPI document: 2.9.10
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
    /// Defines Condition
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Condition
    {
        /// <summary>
        /// Enum NEW for value: NEW
        /// </summary>
        [EnumMember(Value = "NEW")]
        NEW = 1,

        /// <summary>
        /// Enum NEWREFURBISHED for value: NEW_REFURBISHED
        /// </summary>
        [EnumMember(Value = "NEW_REFURBISHED")]
        NEW_REFURBISHED = 2,

        /// <summary>
        /// Enum USEDASNEW for value: USED_AS_NEW
        /// </summary>
        [EnumMember(Value = "USED_AS_NEW")]
        USED_AS_NEW = 3,

        /// <summary>
        /// Enum USEDGOOD for value: USED_GOOD
        /// </summary>
        [EnumMember(Value = "USED_GOOD")]
        USED_GOOD = 4,

        /// <summary>
        /// Enum USEDREASONABLE for value: USED_REASONABLE
        /// </summary>
        [EnumMember(Value = "USED_REASONABLE")]
        USED_REASONABLE = 5,

        /// <summary>
        /// Enum USEDMEDIOCRE for value: USED_MEDIOCRE
        /// </summary>
        [EnumMember(Value = "USED_MEDIOCRE")]
        USED_MEDIOCRE = 6,

        /// <summary>
        /// Enum UNKNOWN for value: UNKNOWN
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 7,

        /// <summary>
        /// Enum USEDVERYGOOD for value: USED_VERY_GOOD
        /// </summary>
        [EnumMember(Value = "USED_VERY_GOOD")]
        USED_VERY_GOOD = 8

    }
}
