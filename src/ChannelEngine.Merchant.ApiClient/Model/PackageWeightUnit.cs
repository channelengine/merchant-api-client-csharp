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
    /// Defines PackageWeightUnit
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PackageWeightUnit
    {
        /// <summary>
        /// Enum GRAM for value: GRAM
        /// </summary>
        [EnumMember(Value = "GRAM")]
        GRAM = 1,

        /// <summary>
        /// Enum OUNCE for value: OUNCE
        /// </summary>
        [EnumMember(Value = "OUNCE")]
        OUNCE = 2

    }
}
