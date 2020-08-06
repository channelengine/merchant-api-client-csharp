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
    /// Defines ReturnStatus
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum ReturnStatus
    {
        /// <summary>
        /// Enum INPROGRESS for value: IN_PROGRESS
        /// </summary>
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS = 1,

        /// <summary>
        /// Enum RECEIVED for value: RECEIVED
        /// </summary>
        [EnumMember(Value = "RECEIVED")]
        RECEIVED = 2,

        /// <summary>
        /// Enum CANCELLED for value: CANCELLED
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        CANCELLED = 3

    }

}
