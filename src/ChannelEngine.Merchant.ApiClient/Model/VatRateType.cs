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
    /// Defines VatRateType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum VatRateType
    {
        /// <summary>
        /// Enum STANDARD for value: STANDARD
        /// </summary>
        [EnumMember(Value = "STANDARD")]
        STANDARD = 1,

        /// <summary>
        /// Enum REDUCED for value: REDUCED
        /// </summary>
        [EnumMember(Value = "REDUCED")]
        REDUCED = 2,

        /// <summary>
        /// Enum SUPERREDUCED for value: SUPER_REDUCED
        /// </summary>
        [EnumMember(Value = "SUPER_REDUCED")]
        SUPER_REDUCED = 3,

        /// <summary>
        /// Enum EXEMPT for value: EXEMPT
        /// </summary>
        [EnumMember(Value = "EXEMPT")]
        EXEMPT = 4

    }
}
